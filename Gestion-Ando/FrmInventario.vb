Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmInventario
    Dim ALTAINVENTARIO As New FrmAltaProductos
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        EstiloBotones.CambiarColorBotones(Me)

        Me.DATAINVENTARIO.BackgroundColor = ColorFormulario
        TXTBUSCAR.Focus()
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLPRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
        Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
        ALTAINVENTARIO.TXTCLAVE.Focus()
        If TIPO = "Operativo" Then
            BTNEDITAR.Enabled = False
            BTNELIMINAR.Enabled = False
        End If
        AddHandler BTNELIMINAR.MouseEnter, AddressOf Button1_MouseEnter
        AddHandler BTNELIMINAR.MouseLeave, AddressOf Button1_MouseLeave
        DATAINVENTARIO.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAINVENTARIO.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
        ' Cambiar el color del botón a rojo cuando el cursor pasa por encima
        BTNELIMINAR.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        ' Restaurar el color original del botón cuando el cursor sale del botón
        BTNELIMINAR.BackColor = ColorBotones
    End Sub
    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        BANDERA = "NUEVO"
        ALTAINVENTARIO.LBLPRODUCTOS.Text = "Registro de producto"
        ALTAINVENTARIO.LBLPRODUCTOS.Location = New Point(190, 9)

        For Each control As Control In ALTAINVENTARIO.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is NumericUpDown Then
                DirectCast(control, NumericUpDown).Value = 0
            End If
        Next
        idbusqueda = 0
        If ALTAINVENTARIO.ShowDialog = DialogResult.OK Then
            Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
            Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
        End If

        TXTBUSCAR.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Dim textoFiltrado As String = TXTBUSCAR.Text.Replace("'", "''")
        Me.TBLPRODUCTOSBindingSource.Filter = "PRONOMBRE LIKE '*" & textoFiltrado & "*'"
    End Sub

    Public Property rutaImagen As String
    Public Property BANDERA As String
    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        ALTAINVENTARIO.LBLPRODUCTOS.Text = "Editar inforación de producto"
        ALTAINVENTARIO.LBLPRODUCTOS.Location = New Point(165, 9)
        ALTAINVENTARIO.SPINNER.Minimum = -1000
        ALTAINVENTARIO.SPINNER.Maximum = 1000

        If DATAINVENTARIO.RowCount > 0 Then
            idbusqueda = DATAINVENTARIO.CurrentRow.Cells("PROID").Value
            ALTAINVENTARIO.TXTCLAVE.Text = DATAINVENTARIO.CurrentRow.Cells("PROCLAVE").Value
            ALTAINVENTARIO.TXTNOMBRE.Text = DATAINVENTARIO.CurrentRow.Cells("PRONOMBRE").Value
            ALTAINVENTARIO.SPINNER.Value = DATAINVENTARIO.CurrentRow.Cells("PROEXISTENCIAS").Value
            ALTAINVENTARIO.TXTCOSTO.Text = Convert.ToInt64(DATAINVENTARIO.CurrentRow.Cells("PROCOSTO").Value).ToString()
            ALTAINVENTARIO.TXTPRECIO.Text = Convert.ToInt64(DATAINVENTARIO.CurrentRow.Cells("PROPRECIO").Value).ToString()
            ALTAINVENTARIO.imagenRuta = DATAINVENTARIO.CurrentRow.Cells("PROIMAGEN").Value

            'CODIGO PARA CARGAR LA IMAGEN DE UN REGISTRO EXISTENTE
            Try
                ' Obtener la ruta de la imagen desde la celda del DataGridView
                rutaImagen = CStr(DATAINVENTARIO.CurrentRow.Cells("PROIMAGEN").Value)

                ' Verificar que la ruta no esté vacía o nula
                If Not String.IsNullOrEmpty(rutaImagen) AndAlso File.Exists(rutaImagen) Then
                    ' Cargar la imagen desde la ruta
                    Dim imagen As Image = Image.FromFile(rutaImagen)

                    ' Asignar la imagen al PictureBox
                    ALTAINVENTARIO.PRODIMAGEN.Image = imagen
                    BANDERA = "EDITAR"

                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar la imagen: " & ex.Message)
            End Try

            If ALTAINVENTARIO.ShowDialog = DialogResult.OK Then
                Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
                Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
            End If
        End If
        TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        If DATAINVENTARIO.RowCount <= 0 Then
            MsgBox("No hay clientes para eliminar", MsgBoxStyle.Critical, "Advertencia")

        Else
            Dim CONFIRMAR = MsgBox("¿Eliminar producto?", MsgBoxStyle.YesNo, "Confirmación")
            If CONFIRMAR = MsgBoxResult.Yes Then
                StrSql = "ELIMINARPRODUCTOS"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@PROID", SqlDbType.BigInt).Value = Me.DATAINVENTARIO.CurrentRow.Cells("PROID").Value

                If Conectar() = True Then
                    Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
                    Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
                    MsgBox("Producto eliminado", MsgBoxStyle.Information, "Conformación")
                End If
            End If
            TXTBUSCAR.Focus()
        End If
    End Sub

    Private Sub DATAINVENTARIO_SelectionChanged(sender As Object, e As EventArgs) Handles DATAINVENTARIO.SelectionChanged
        Try
            ' Verificar que el DataGridView tenga filas y una fila seleccionada
            If DATAINVENTARIO.SelectedRows.Count > 0 AndAlso DATAINVENTARIO.SelectedRows(0) IsNot Nothing Then
                ' Obtener la ruta de la imagen desde la celda del DataGridView
                Dim rutaImagen As String = CStr(DATAINVENTARIO.SelectedRows(0).Cells("PROIMAGEN").Value)

                Dim NombreProducto As String = DATAINVENTARIO.SelectedRows(0).Cells("PRONOMBRE").Value
                Dim EXISTENCIAS As Integer = DATAINVENTARIO.SelectedRows(0).Cells("PROEXISTENCIAS").Value
                Dim PRECIO As Long = DATAINVENTARIO.SelectedRows(0).Cells("PROPRECIO").Value

                ' Verificar que la ruta de la imagen no esté vacía o nula
                If Not String.IsNullOrEmpty(rutaImagen) AndAlso File.Exists(rutaImagen) Then
                    ' Cargar la imagen desde la ruta
                    Dim imagen As Image = Image.FromFile(rutaImagen)

                    ' Asignar la imagen al PictureBox
                    VISTAPRODUCTO.Image = imagen
                Else
                    ' Manejar el caso donde la ruta de la imagen es inválida
                    rutaImagen = Application.StartupPath & "\PRODUCTODEFECTO.png"
                    Dim imagen As Image = Image.FromFile(rutaImagen)
                    VISTAPRODUCTO.Image = imagen
                End If
            End If
        Catch ex As Exception
            ' Manejar cualquier otro error
            MessageBox.Show("Error al cargar la imagen: " & ex.Message)
        End Try
    End Sub

    Private Sub BTNREPORTE_Click(sender As Object, e As EventArgs) Handles BTNREPORTE.Click
        MostrarFormularioEmergente()
    End Sub

    Public Sub MostrarFormularioEmergente()
        Dim OPCIONESVENTAS As New Form()
        OPCIONESVENTAS.Text = "Tipo de reporte"
        OPCIONESVENTAS.Size = New Size(300, 250)
        OPCIONESVENTAS.ShowIcon = False
        OPCIONESVENTAS.BackColor = ColorFormulario
        OPCIONESVENTAS.StartPosition = FormStartPosition.CenterScreen
        OPCIONESVENTAS.FormBorderStyle = FormBorderStyle.FixedSingle
        OPCIONESVENTAS.MaximizeBox = False
        OPCIONESVENTAS.MinimizeBox = False
        OPCIONESVENTAS.ShowInTaskbar = False

        ' Habilitar KeyPreview para capturar teclas
        OPCIONESVENTAS.KeyPreview = True

        ' Agregar evento para cerrar con tecla Esc
        AddHandler OPCIONESVENTAS.KeyDown, Sub(sender, e)
                                               If e.KeyCode = Keys.Escape Then
                                                   OPCIONESVENTAS.Close()
                                               End If
                                           End Sub

        ' Crear los RadioButton
        Dim INVENTARIOGEN As New RadioButton()
        INVENTARIOGEN.Checked = True
        INVENTARIOGEN.Text = "Inventario general"
        INVENTARIOGEN.Location = New Point(50, 30)
        INVENTARIOGEN.Font = New Font("Dubai", 16, FontStyle.Regular)
        INVENTARIOGEN.AutoSize = True

        Dim INVENTARIOFILTRADO As New RadioButton()
        INVENTARIOFILTRADO.Text = "Inventario existente"
        INVENTARIOFILTRADO.Location = New Point(50, 80)
        INVENTARIOFILTRADO.Font = New Font("Dubai", 16, FontStyle.Regular)
        INVENTARIOFILTRADO.AutoSize = True

        ' Botón de aceptar
        Dim btnAceptar As New Button()
        btnAceptar.BackColor = ColorBotones
        btnAceptar.Text = "Aceptar"
        btnAceptar.Location = New Point(100, 150)
        btnAceptar.AutoSize = True
        btnAceptar.Font = New Font("Dubai", 14, FontStyle.Regular)
        btnAceptar.Cursor = Cursors.Hand

        AddHandler btnAceptar.Click, Sub(sender, e)
                                         Dim rutaReporte As String
                                         Dim rutaBase As String = Application.StartupPath
                                         OPCIONESVENTAS.Close()

                                         ' Seleccionar el reporte correcto
                                         If INVENTARIOGEN.Checked Then
                                             rutaReporte = System.IO.Path.Combine(rutaBase, "RPTINVENTARIO.rpt")
                                         ElseIf INVENTARIOFILTRADO.Checked Then
                                             rutaReporte = System.IO.Path.Combine(rutaBase, "RPTINVENTARIOEXISTENTE.rpt")
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
                                             crTable.Location = crConnInfo.DatabaseName & ".dbo." & crTable.Name
                                         Next

                                         ' Verificar y refrescar la base de datos
                                         MANIFIESTO.VerifyDatabase()
                                         MANIFIESTO.Refresh()

                                         ' Mostrar el reporte
                                         Dim MUESTRA As New FrmReportes()
                                         MUESTRA.Reportes.ReportSource = MANIFIESTO
                                         MUESTRA.Reportes.Refresh()
                                         MUESTRA.ShowDialog()
                                     End Sub

        ' Agregar controles al formulario emergente
        OPCIONESVENTAS.Controls.Add(INVENTARIOGEN)
        OPCIONESVENTAS.Controls.Add(INVENTARIOFILTRADO)
        OPCIONESVENTAS.Controls.Add(btnAceptar)

        ' Mostrar el formulario emergente
        OPCIONESVENTAS.ShowDialog()
    End Sub
End Class