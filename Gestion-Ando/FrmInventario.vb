Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmInventario
    Dim ALTAINVENTARIO As New FrmAltaProductos
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        BTNNUEVO.BackColor = ColorBotones
        BTNEDITAR.BackColor = ColorBotones
        BTNELIMINAR.BackColor = ColorBotones
        BTNREPORTE.BackColor = ColorBotones
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
        Me.TBLPRODUCTOSBindingSource.Filter = "PRONOMBRE LIKE '*" & TXTBUSCAR.Text & "*'"
    End Sub

    Public Property rutaImagen As String
    Public Property BANDERA As String
    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        ALTAINVENTARIO.LBLPRODUCTOS.Text = "Editar inforación de producto"
        ALTAINVENTARIO.LBLPRODUCTOS.Location = New Point(165, 9)

        If DATAINVENTARIO.RowCount > 0 Then
            idbusqueda = DATAINVENTARIO.CurrentRow.Cells("PROID").Value
            ALTAINVENTARIO.TXTCLAVE.Text = DATAINVENTARIO.CurrentRow.Cells("PROCLAVE").Value
            ALTAINVENTARIO.TXTNOMBRE.Text = DATAINVENTARIO.CurrentRow.Cells("PRONOMBRE").Value
            ALTAINVENTARIO.SPINNER.Value = DATAINVENTARIO.CurrentRow.Cells("PROEXISTENCIAS").Value
            ALTAINVENTARIO.TXTPRECIO.Text = Convert.ToInt32(DATAINVENTARIO.CurrentRow.Cells("PROPRECIO").Value).ToString()
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
    End Sub

    Private Sub DATAINVENTARIO_SelectionChanged(sender As Object, e As EventArgs) Handles DATAINVENTARIO.SelectionChanged
        Try
            ' Verificar que el DataGridView tenga filas y una fila seleccionada
            If DATAINVENTARIO.SelectedRows.Count > 0 AndAlso DATAINVENTARIO.SelectedRows(0) IsNot Nothing Then
                ' Obtener la ruta de la imagen desde la celda del DataGridView
                Dim rutaImagen As String = CStr(DATAINVENTARIO.SelectedRows(0).Cells("PROIMAGEN").Value)

                Dim NombreProducto As String = DATAINVENTARIO.SelectedRows(0).Cells("PRONOMBRE").Value
                Dim EXISTENCIAS As Integer = DATAINVENTARIO.SelectedRows(0).Cells("PROEXISTENCIAS").Value
                Dim PRECIO As Integer = DATAINVENTARIO.SelectedRows(0).Cells("PROPRECIO").Value
                LBLPRODUCTO.Text = "Producto: " + NombreProducto
                LBLEXISTENCIAS.Text = "Existencias: " + EXISTENCIAS.ToString("N0")
                LBLPRECIO.Text = "Precio: " + PRECIO.ToString("C2")
                ' Verificar que la ruta de la imagen no esté vacía o nula
                If Not String.IsNullOrEmpty(rutaImagen) AndAlso File.Exists(rutaImagen) Then
                    ' Cargar la imagen desde la ruta
                    Dim imagen As Image = Image.FromFile(rutaImagen)

                    ' Asignar la imagen al PictureBox
                    VISTAPRODUCTO.Image = imagen
                Else
                    ' Manejar el caso donde la ruta de la imagen es inválida
                    VISTAPRODUCTO.Image = Nothing
                    MessageBox.Show("Error al cargar la imagen")
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
        ' Crear un nuevo formulario
        Dim OPCIONESVENTAS As New Form()
        OPCIONESVENTAS.Text = "Tipo de reporte"
        OPCIONESVENTAS.Size = New Size(300, 250)
        OPCIONESVENTAS.ShowIcon = False
        OPCIONESVENTAS.BackColor = ColorFormulario
        OPCIONESVENTAS.StartPosition = FormStartPosition.CenterScreen
        OPCIONESVENTAS.FormBorderStyle = FormBorderStyle.FixedSingle
        OPCIONESVENTAS.MaximizeBox = False
        OPCIONESVENTAS.MinimizeBox = False


        ' Crear el primer RadioButton
        Dim opcion1 As New RadioButton()
        opcion1.Checked = True
        opcion1.Text = "Inventario general"
        opcion1.Location = New Point(50, 30)
        opcion1.Font = New Font("Dubai", 16, FontStyle.Regular)
        opcion1.AutoSize = True
        opcion1.TabIndex = 1

        'Crear el segundo RadioButton
        Dim opcion2 As New RadioButton()
        opcion2.Text = "Inventario existente"
        opcion2.Location = New Point(50, 80)
        opcion2.Font = New Font("Dubai", 16, FontStyle.Regular)
        opcion2.AutoSize = True
        opcion2.TabIndex = 2

        ' Crear un botón de aceptar
        Dim btnAceptar As New Button()
        btnAceptar.BackColor = ColorBotones
        btnAceptar.Text = "Aceptar"
        btnAceptar.Location = New Point(100, 150)
        btnAceptar.AutoSize = True
        btnAceptar.Font = New Font("Dubai", 14, FontStyle.Regular)
        btnAceptar.TabIndex = 3
        AddHandler btnAceptar.Click, Sub(sender, e)
                                         If opcion1.Checked Then
                                             Dim MUESTRA As New FrmReportes
                                             Dim MANIFIESTO As New ReportDocument
                                             MANIFIESTO.FileName = "C:\Users\carlo\OneDrive\Escritorio\Copia Gestion-Ando\Gestion-Ando\Gestion-Ando\RPTINVENTARIO.rpt"
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
                                             crTable.Location = "MuebleAlex" & "." & "dbo" & "." & "VISTAPRODUCTOS"
                                             crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1)
                                             MUESTRA.Reportes.ReportSource = MANIFIESTO
                                             MUESTRA.Reportes.RefreshReport()
                                             MUESTRA.ShowDialog()
                                             OPCIONESVENTAS.Close()


                                         ElseIf opcion2.Checked Then
                                             Dim MUESTRA As New FrmReportes
                                             Dim MANIFIESTO As New ReportDocument
                                             MANIFIESTO.FileName = "C:\Users\carlo\OneDrive\Escritorio\Copia Gestion-Ando\Gestion-Ando\Gestion-Ando\RPTINVENTARIOEXISTENTE.rpt"
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
                                             crTable.Location = "MuebleAlex" & "." & "dbo" & "." & "VISTAPRODUCTOSEXISTENTES"
                                             crTable.Location.Substring(crTable.Location.LastIndexOf(".") + 1)
                                             MUESTRA.Reportes.ReportSource = MANIFIESTO
                                             MUESTRA.Reportes.RefreshReport()
                                             MUESTRA.ShowDialog()
                                             OPCIONESVENTAS.Close()
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
End Class