Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmVentas
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet1.VISTAVENTAS' Puede moverla o quitarla según sea necesario.
        Me.VISTAVENTASTableAdapter.Connection = Conexion
        Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet1.VISTAVENTAS)
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTAVENTAS' Puede moverla o quitarla según sea necesario.
        Me.BackColor = ColorFormulario
        BTNNUEVO.BackColor = ColorBotones
        BTNELIMINAR.BackColor = ColorBotones
        BTNREPORTE.BackColor = ColorBotones
        DATAVENTAS.BackgroundColor = ColorFormulario
        DETALLEVENTAS.Location = New Point(540, 187)
        DATAVENTAS.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAVENTAS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)

    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.VISTAVENTASBindingSource.Filter = "CLIENTE LIKE '*" & Me.TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim CONFIRMACION = MsgBox("¿Eliminar venta?", MsgBoxStyle.YesNo, "Advertencia")
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
                    MessageBox.Show("No hay una fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                    .Columns("Producto").Width = 546
                    .Columns("Producto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    .Columns.Add("Unidades", "Unidades")
                    .Columns("Unidades").DataPropertyName = "Unidades"
                    .Columns("Unidades").DefaultCellStyle.Format = "N0"

                    .Columns.Add("PrecioUnitario", "Precio unitario")
                    .Columns("PrecioUnitario").DataPropertyName = "Precio unitario"
                    .Columns("PrecioUnitario").DefaultCellStyle.Format = "C2"
                    .Columns("PrecioUnitario").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

                    .Columns.Add("Total", "Total")
                    .Columns("Total").DataPropertyName = "Total"
                    .Columns("Total").DefaultCellStyle.Format = "C2"

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
                        .Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

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
                        .Columns("A PAGAR").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

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
        ' Crear un nuevo formulario
        Dim OPCIONESVENTAS As New Form()
        OPCIONESVENTAS.Text = "Formato de reporte"
        OPCIONESVENTAS.Size = New Size(300, 200)
        OPCIONESVENTAS.ShowIcon = False
        OPCIONESVENTAS.BackColor = ColorFormulario
        OPCIONESVENTAS.StartPosition = FormStartPosition.CenterScreen
        OPCIONESVENTAS.FormBorderStyle = FormBorderStyle.FixedSingle
        OPCIONESVENTAS.MaximizeBox = False
        OPCIONESVENTAS.MinimizeBox = False


        ' Crear el primer RadioButton
        Dim opcion1 As New RadioButton()
        opcion1.Text = "Ventas generales"
        opcion1.Location = New Point(50, 30)
        opcion1.AutoSize = True

        ' Crear el segundo RadioButton
        Dim opcion2 As New RadioButton()
        opcion2.Text = "Ventas"
        opcion2.Location = New Point(50, 60)
        opcion2.AutoSize = True

        ' Crear un botón de aceptar
        Dim btnAceptar As New Button()
        btnAceptar.BackColor = ColorBotones
        btnAceptar.Text = "Aceptar"
        btnAceptar.Location = New Point(100, 100)
        AddHandler btnAceptar.Click, Sub(sender, e)
                                         If opcion1.Checked Then
                                             Dim MUESTRA As New FrmReportes
                                             Dim MANIFIESTO As New ReportDocument
                                             MANIFIESTO.FileName = "C:\Users\carlo\Documents\GitHub\Gestion-Ando\Gestion-Ando\RPTVENTASGENERAL.rpt"
                                             Dim crDatabase As Database
                                             Dim crTables As Tables
                                             Dim crTable As Table = Nothing
                                             Dim crLogOnInfo As TableLogOnInfo
                                             Dim crConnInfo As New ConnectionInfo()
                                             crDatabase = MANIFIESTO.Database
                                             crTables = crDatabase.Tables
                                             For Each crTable In crTables
                                                 With crConnInfo
                                                     .ServerName = "desktop-8q10a8h\sqlexpress"
                                                     .DatabaseName = "MuebleAlex"
                                                     .UserID = "sa"
                                                     .Password = "c1oooooo"
                                                 End With
                                                 crLogOnInfo = crTable.LogOnInfo
                                                 crLogOnInfo.ConnectionInfo = crConnInfo
                                                 crTable.ApplyLogOnInfo(crLogOnInfo)
                                             Next
                                             crTable.Location = "MuebleAlex" & "." & "dbo" & "." & "VISTAVENTAS"
                                             crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1)
                                             MUESTRA.Reportes.ReportSource = MANIFIESTO
                                             MUESTRA.ShowDialog()
                                             OPCIONESVENTAS.Close()
                                         ElseIf opcion2.Checked Then
                                             MessageBox.Show("Seleccionaste Opción 2", "Resultado")
                                         Else
                                             MsgBox("Selecciona una opción.", MsgBoxStyle.Information, "Advertencia")
                                         End If

                                     End Sub

        ' Agregar los controles al formulario emergente
        OPCIONESVENTAS.Controls.Add(opcion1)
        OPCIONESVENTAS.Controls.Add(opcion2)
        OPCIONESVENTAS.Controls.Add(btnAceptar)

        ' Mostrar el formulario como emergente
        OPCIONESVENTAS.ShowDialog()
    End Sub

    Private Sub BTNREPORTE_Click(sender As Object, e As EventArgs) Handles BTNREPORTE.Click
        MostrarFormularioEmergente()
    End Sub
End Class