Imports System.Data.SqlClient
Imports System.Web.Routing
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmVentas
    Dim tablaOriginal As DataTable
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBFILTRO.SelectedIndex = 0
        CargarDatos()
        Me.BackColor = ColorFormulario
        EstiloBotones.CambiarColorBotones(Me)
        TXTBUSCAR.Focus()
        DATAVENTAS.BackgroundColor = ColorFormulario
        DETALLEVENTAS.Location = New Point(540, 187)
        DATAVENTAS.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAVENTAS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
        DATAVENTAS.BackgroundColor = ColorFormulario
        If TIPO = "Operativo" Then
            BTNELIMINAR.Enabled = False
        ElseIf TIPO = "Administrador" Then
            BTNELIMINAR.Enabled = True
        End If
        AddHandler BTNELIMINAR.MouseEnter, AddressOf BTNELIMINAR_MouseEnter
        AddHandler BTNELIMINAR.MouseLeave, AddressOf BTNELIMINAR_MouseLeave
    End Sub

    Public Sub CargarDatos()
        Dim cadenaConexion As String = "server=" & SERVIDOR & "; database=" & BASEDATOS & "; uid=" & USUARIO & "; pwd=" & CONTRASEÑA & ";"
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT * FROM VISTAVENTAS WHERE VENEXISTE=1 AND VENFECHA BETWEEN DATEADD(MONTH, -2, GETDATE()) AND GETDATE() ORDER BY VENID DESC"
        Dim adapter As New SqlDataAdapter(sql, conexion)
        Dim dt As New DataTable()

        Try
            conexion.Open()
            adapter.Fill(dt)

            ' Guardar una copia de la tabla original para restauración
            tablaOriginal = dt.Copy()

            DATAVENTAS.DataSource = tablaOriginal
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub
    Private Sub BTNELIMINAR_MouseEnter(sender As Object, e As EventArgs)
        BTNELIMINAR.BackColor = Color.Red
    End Sub

    Private Sub BTNELIMINAR_MouseLeave(sender As Object, e As EventArgs)
        BTNELIMINAR.BackColor = ColorBotones
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Dim OPCIONES As String
        If CMBFILTRO.SelectedItem = "Vendedor" Then
            OPCIONES = "USUNOMBRE"
        Else
            OPCIONES = "Cliente"
        End If

        If tablaOriginal IsNot Nothing Then
            Dim textoFiltrado As String = TXTBUSCAR.Text.Replace("'", "''")

            If textoFiltrado.Trim() = "" Then
                ' Restaurar la tabla completa
                DATAVENTAS.DataSource = tablaOriginal.Copy()
            Else
                ' Filtrar solo si hay texto
                Dim resultado = tablaOriginal.Select(OPCIONES & " LIKE '%" & textoFiltrado & "%'")
                If resultado.Length > 0 Then
                    DATAVENTAS.DataSource = resultado.CopyToDataTable()
                Else
                    DATAVENTAS.DataSource = tablaOriginal.Clone() ' Mostrar tabla vacía si no hay resultados
                End If
            End If
        End If
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click

        If DATAVENTAS.RowCount <= 0 Then
            MsgBox("No hay productos para eliminar", MsgBoxStyle.Exclamation, "Advertencia")

        Else
            Dim CONFIRMACION = MsgBox("¿Eliminar venta?", MsgBoxStyle.YesNo, "Confirmación")
            If CONFIRMACION = DialogResult.Yes Then
                StrSql = "ELIMINARVENTA"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = Me.DATAVENTAS.CurrentRow.Cells("VENID").Value

                If Conectar() = True Then
                    Me.VISTAVENTASTableAdapter.Connection = Conexion
                    Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAVENTAS)
                    Me.VISTAVENTASBindingSource.DataSource = Me.MuebleAlexDataSet.VISTAVENTAS
                    MsgBox("Venta eliminada", MsgBoxStyle.Information, "Confirmación")
                    CargarDatos()
                End If
            End If
        End If

    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        If FrmAltaVentas.ShowDialog = DialogResult.OK Then
            Me.VISTAVENTASTableAdapter.Connection = Conexion
            Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAVENTAS)
            Me.VISTAVENTASBindingSource.DataSource = Me.MuebleAlexDataSet.VISTAVENTAS
        End If

    End Sub

    Public contado As Boolean

    Dim DETALLEVENTAS As New FrmDetallesVentas

    Private Sub DATAVENTAS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATAVENTAS.CellDoubleClick
        If DATAVENTAS.CurrentRow IsNot Nothing Then
            ' Obtener el valor de una celda usando el índice de columna
            Dim valorCelda As Object = DATAVENTAS.CurrentRow.Cells("VENFORMA").Value ' Índice 0 para la primera columna
            If valorCelda = "Contado" Then
                contado = 1
            Else
                contado = 0
            End If
        End If

        If idbusqueda >= 0 Then
            Try
                ' Verificar que haya una fila seleccionada
                If DATAVENTAS.CurrentRow Is Nothing Then
                    MessageBox.Show("No hay una fila seleccionada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                ' Obtener el VENID y verificar que es válido
                Dim venId As Object = DATAVENTAS.CurrentRow.Cells("VENID").Value
                If venId Is Nothing OrElse Not IsNumeric(venId) Then
                    MessageBox.Show("Error: No se pudo obtener el ID de la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' ===================== LIMPIAR DATA GRID VIEWS =====================
                With DETALLEVENTAS.DATADETALLEVENTA
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

                With DETALLEVENTAS.DATAPAGOS
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

                ' ===================== CARGAR DETALLE DE VENTAS =====================
                Conexion.Open()
                StrSql = "VISTADETALLEVENTAS"
                Dim comandoVentas As New SqlClient.SqlCommand(StrSql, Conexion)
                comandoVentas.CommandType = CommandType.StoredProcedure
                comandoVentas.Parameters.Add("@VENID", SqlDbType.BigInt).Value = Convert.ToInt64(venId)

                Dim adaptadorVentas As New SqlClient.SqlDataAdapter(comandoVentas)
                Dim tablaVentas As New DataTable()
                adaptadorVentas.Fill(tablaVentas)
                Conexion.Close()

                ' Configurar y asignar datos al DataGridView de ventas
                With DETALLEVENTAS.DATADETALLEVENTA
                    .AutoGenerateColumns = False
                    .DataSource = tablaVentas

                    .Columns.Add("Producto", "Producto")
                    .Columns("Producto").DataPropertyName = "Producto"
                    .Columns("Producto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    .Columns.Add("Unidades", "Unidades")
                    .Columns("Unidades").DataPropertyName = "Unidades"
                    .Columns("Unidades").DefaultCellStyle.Format = "N0"
                    .Columns("Unidades").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                    .Columns.Add("Precio Unitario", "Precio unitario")
                    .Columns("Precio Unitario").DataPropertyName = "Precio unitario"
                    .Columns("Precio Unitario").DefaultCellStyle.Format = "C2"
                    .Columns("Precio Unitario").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                    .Columns.Add("Total", "Total")
                    .Columns("Total").DataPropertyName = "Total"
                    .Columns("Total").DefaultCellStyle.Format = "C2"
                    .Columns("Total").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                    .Columns.Add("Ganancia", "Ganancia")
                    .Columns("Ganancia").DataPropertyName = "Ganancia"
                    .Columns("Ganancia").DefaultCellStyle.Format = "C2"
                    .Columns("Ganancia").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

                End With

                If contado = 0 Then
                    ' ===================== CARGAR DETALLE DE PAGOS =====================
                    Conexion.Open()
                    StrSql = "DETALLESDEPAGOS"
                    Dim comandoPagos As New SqlClient.SqlCommand(StrSql, Conexion)
                    comandoPagos.CommandType = CommandType.StoredProcedure
                    comandoPagos.Parameters.Add("@VENID", SqlDbType.BigInt).Value = Convert.ToInt64(venId)

                    Dim adaptadorPagos As New SqlClient.SqlDataAdapter(comandoPagos)
                    Dim tablaPagos As New DataTable()
                    adaptadorPagos.Fill(tablaPagos)
                    Conexion.Close()

                    ' Configurar y asignar datos al DataGridView de pagos
                    With DETALLEVENTAS.DATAPAGOS
                        .AutoGenerateColumns = False
                        .DataSource = tablaPagos

                        .Columns.Add("Fecha", "Fecha de Pago")
                        .Columns("Fecha").DataPropertyName = "Fecha"
                        .Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                        .Columns.Add("Cliente", "Cliente")
                        .Columns("Cliente").DataPropertyName = "Cliente"
                        .Columns("Cliente").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                        .Columns.Add("Enganche", "Enganche")
                        .Columns("Enganche").DataPropertyName = "Enganche"
                        .Columns("Enganche").DefaultCellStyle.Format = "C2"
                        .Columns("Enganche").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                        .Columns.Add("A PAGAR", "A pagar")
                        .Columns("A PAGAR").DataPropertyName = "A PAGAR"
                        .Columns("A PAGAR").DefaultCellStyle.Format = "C2"
                        .Columns("A PAGAR").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                        .Columns.Add("Pagado", "Pagado")
                        .Columns("Pagado").DataPropertyName = "Pagado"
                        .Columns("Pagado").DefaultCellStyle.Format = "C2"
                        .Columns("Pagado").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

                        .Columns.Add("PAGID", "PAGID")
                        .Columns("PAGID").DataPropertyName = "PAGID"
                        .Columns("PAGID").Width = 546
                        .Columns("PAGID").Visible = False

                        .Columns.Add("VENID", "VENID")
                        .Columns("VENID").DataPropertyName = "VENID"
                        .Columns("VENID").Width = 546
                        .Columns("VENID").Visible = False

                    End With
                End If
                ' Mostrar el formulario de detalles de ventas
                DETALLEVENTAS.ShowDialog()
                Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet1.VISTAVENTAS)
                ' ===================== LIMPIAR DATA GRID VIEWS AL CERRAR =====================
                With DETALLEVENTAS.DATADETALLEVENTA
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

                With DETALLEVENTAS.DATAPAGOS
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Conexion.State = ConnectionState.Open Then Conexion.Close()
            End Try
        End If


    End Sub

    Public Sub MostrarFormularioEmergente()
        Dim OPCIONESVENTAS As New Form()
        OPCIONESVENTAS.Text = "Formato de reporte"
        OPCIONESVENTAS.Size = New Size(300, 400)
        OPCIONESVENTAS.ShowIcon = False
        OPCIONESVENTAS.BackColor = ColorFormulario
        OPCIONESVENTAS.StartPosition = FormStartPosition.CenterScreen
        OPCIONESVENTAS.FormBorderStyle = FormBorderStyle.FixedSingle
        OPCIONESVENTAS.MaximizeBox = False
        OPCIONESVENTAS.MinimizeBox = False
        OPCIONESVENTAS.ShowInTaskbar = False

        ' Habilitar KeyPreview para capturar teclas
        OPCIONESVENTAS.KeyPreview = True

        ' Agregar un manejador de eventos para cerrar el formulario con la tecla Esc
        AddHandler OPCIONESVENTAS.KeyDown, Sub(sender, e)
                                               If e.KeyCode = Keys.Escape Then
                                                   OPCIONESVENTAS.Close()
                                               End If
                                           End Sub

        ' Crear los RadioButton
        Dim VENTAGENERAL As New RadioButton()
        VENTAGENERAL.Checked = True
        VENTAGENERAL.Text = "Ventas generales"
        VENTAGENERAL.Location = New Point(50, 30)
        VENTAGENERAL.Font = New Font("Dubai", 16, FontStyle.Regular)
        VENTAGENERAL.AutoSize = True

        Dim VENTAFILTRADO As New RadioButton()
        VENTAFILTRADO.Text = "Ventas de"
        VENTAFILTRADO.Location = New Point(50, 80)
        VENTAFILTRADO.Font = New Font("Dubai", 16, FontStyle.Regular)
        VENTAFILTRADO.AutoSize = True

        ' Crear los DateTimePicker
        Dim CALENDARIOINICIAL As New DateTimePicker()
        CALENDARIOINICIAL.Location = New Point(50, 135)
        CALENDARIOINICIAL.Width = 200
        CALENDARIOINICIAL.Format = DateTimePickerFormat.Short
        CALENDARIOINICIAL.Enabled = False
        CALENDARIOINICIAL.Font = New Font("Dubai", 14, FontStyle.Regular)

        Dim ETIQUETA As New Label()
        ETIQUETA.Text = "a"
        ETIQUETA.Font = New Font("Dubai", 16, FontStyle.Regular)
        ETIQUETA.AutoSize = True
        ETIQUETA.Location = New Point(135, 180)
        ETIQUETA.BackColor = ColorFormulario

        Dim CALENDARIOFINAL As New DateTimePicker()
        CALENDARIOFINAL.Location = New Point(50, 220)
        CALENDARIOFINAL.Width = 200
        CALENDARIOFINAL.Format = DateTimePickerFormat.Short
        CALENDARIOFINAL.Enabled = False
        CALENDARIOFINAL.Font = New Font("Dubai", 14, FontStyle.Regular)

        ' Evento para habilitar/deshabilitar DateTimePicker
        AddHandler VENTAFILTRADO.CheckedChanged, Sub(sender, e)
                                                     CALENDARIOINICIAL.Enabled = VENTAFILTRADO.Checked
                                                     CALENDARIOFINAL.Enabled = VENTAFILTRADO.Checked
                                                 End Sub

        ' Botón de aceptar
        Dim btnAceptar As New Button()
        btnAceptar.BackColor = ColorBotones
        btnAceptar.Text = "Aceptar"
        btnAceptar.Location = New Point(100, 280)
        btnAceptar.AutoSize = True
        btnAceptar.Font = New Font("Dubai", 14, FontStyle.Regular)
        btnAceptar.Cursor = Cursors.Hand

        AddHandler btnAceptar.Click, Sub(sender, e)
                                         Dim rutaReporte As String
                                         Dim rutaBase As String = Application.StartupPath
                                         OPCIONESVENTAS.Close()
                                         ' Seleccionar el reporte correcto
                                         If VENTAGENERAL.Checked Then
                                             rutaReporte = System.IO.Path.Combine(rutaBase, "RPTVENTASGENERAL.rpt")
                                         ElseIf VENTAFILTRADO.Checked Then
                                             rutaReporte = System.IO.Path.Combine(rutaBase, "RPTVENTASFILTRADAS.rpt")
                                         Else
                                             MsgBox("Selecciona una opción.", MsgBoxStyle.Information, "Advertencia")
                                             Exit Sub
                                         End If

                                         ' Validar existencia del archivo de reporte
                                         If Not System.IO.File.Exists(rutaReporte) Then
                                             MessageBox.Show("No se encontró el archivo de reporte en la ruta especificada: " & rutaReporte, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                             Exit Sub
                                         End If

                                         ' Cargar el reporte
                                         Dim MANIFIESTO As New ReportDocument()
                                         MANIFIESTO.Load(rutaReporte)

                                         ' Configurar conexión a la base de datos
                                         Dim crConnInfo As New ConnectionInfo()
                                         With crConnInfo
                                             .ServerName = SERVIDOR
                                             .DatabaseName = BASEDATOS
                                             .UserID = USUARIO
                                             .Password = CONTRASEÑA
                                         End With

                                         ' Aplicar conexión a cada tabla del reporte
                                         Dim crDatabase As Database = MANIFIESTO.Database
                                         Dim crTables As Tables = crDatabase.Tables
                                         For Each crTable As Table In crTables
                                             Dim crLogOnInfo As TableLogOnInfo = crTable.LogOnInfo
                                             crLogOnInfo.ConnectionInfo = crConnInfo
                                             crTable.ApplyLogOnInfo(crLogOnInfo)

                                             ' Ajustar la ubicación de la tabla para evitar solicitud de credenciales
                                             crTable.Location = crConnInfo.DatabaseName & ".dbo." & crTable.Name
                                         Next

                                         ' Verificar y refrescar la base de datos
                                         MANIFIESTO.VerifyDatabase()
                                         MANIFIESTO.Refresh()

                                         ' Si es un reporte filtrado, asignar parámetros de fecha
                                         ' Obtener los campos de parámetros del reporte
                                         Dim paramFields As ParameterFieldDefinitions = MANIFIESTO.DataDefinition.ParameterFields

                                         ' Asignar valores manualmente a cada parámetro
                                         If VENTAFILTRADO.Checked Then
                                             paramFields("@FECHAINICIAL").ApplyCurrentValues(New ParameterValues() From {New ParameterDiscreteValue() With {.Value = CALENDARIOINICIAL.Value.ToString("yyyy-MM-dd")}})
                                             paramFields("@FECHAFINAL").ApplyCurrentValues(New ParameterValues() From {New ParameterDiscreteValue() With {.Value = CALENDARIOFINAL.Value.ToString("yyyy-MM-dd")}})
                                         End If

                                         ' Mostrar el reporte
                                         Dim MUESTRA As New FrmReportes()
                                         MUESTRA.Reportes.ReportSource = MANIFIESTO
                                         MUESTRA.Reportes.Refresh()
                                         MUESTRA.ShowDialog()

                                     End Sub

        ' Agregar controles al formulario emergente
        OPCIONESVENTAS.Controls.Add(VENTAGENERAL)
        OPCIONESVENTAS.Controls.Add(VENTAFILTRADO)
        OPCIONESVENTAS.Controls.Add(CALENDARIOINICIAL)
        OPCIONESVENTAS.Controls.Add(CALENDARIOFINAL)
        OPCIONESVENTAS.Controls.Add(ETIQUETA)
        OPCIONESVENTAS.Controls.Add(btnAceptar)

        ' Mostrar el formulario emergente
        OPCIONESVENTAS.ShowDialog()
    End Sub

    Private Sub BTNREPORTE_Click(sender As Object, e As EventArgs) Handles BTNREPORTE.Click
        MostrarFormularioEmergente()
    End Sub

    Private Sub BTNIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNIMPRIMIR.Click
        FrmAltaVentas.ImprimirTicket(Me)
    End Sub

    Private Sub CMBFILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBFILTRO.SelectedIndexChanged
        TXTBUSCAR_TextChanged(sender, e)
    End Sub

End Class