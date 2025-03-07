Public Class FrmAltaProductos
    Private Sub FrmAltaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SPINNER.Location = New Point(151, 121)
        SPINNER.Minimum = 0
        SPINNER.Maximum = 1000
        SPINNER.TabIndex = 4
        Me.Controls.Add(SPINNER)
        If TIPO = "Operativo" Then


        End If
        If FrmInventario.BANDERA = "NUEVO" Then
            PRODIMAGEN.Image = Nothing
            imagenRuta = String.Empty
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.TXTCLAVE.Focus()
        Me.Close()
        LBLPRODUCTOS.Text = " "

    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is NumericUpDown Then
                DirectCast(control, NumericUpDown).Value = 0
            End If
        Next
        TXTCLAVE.Focus()
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If String.IsNullOrWhiteSpace(TXTCLAVE.Text) Then
            MsgBox("Clave faltante", MsgBoxStyle.Critical, "Advertencia")
            TXTCLAVE.Focus()

        Else
            If idbusqueda = 0 Then
                StrSql = "ALTAPRODUCTOS"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                If TXTPRECIO.Text = String.Empty Then
                    TXTPRECIO.Text = "0"
                    comando.Parameters.Add("@PROPRECIO", SqlDbType.Money).Value = TXTPRECIO.Text
                End If
            Else
                StrSql = "EDITARPRODUCTOS"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("PROID", SqlDbType.BigInt).Value = idbusqueda
                comando.Parameters.Add("@PROPRECIO", SqlDbType.Money).Value = TXTPRECIO.Text
            End If

            comando.Parameters.Add("@PROCLAVE", SqlDbType.VarChar, 10).Value = TXTCLAVE.Text
            comando.Parameters.Add("@PRONOMBRE", SqlDbType.VarChar, 255).Value = TXTNOMBRE.Text
            comando.Parameters.Add("@PROEXISTENCIAS", SqlDbType.Int).Value = Integer.Parse(SPINNER.Text)
            comando.Parameters.Add("@PROIMAGEN", SqlDbType.VarChar, 100).Value = imagenRuta

            comando.Parameters.Add("@RETORNO", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output

            If Conectar() = True Then
                If comando.Parameters("@RETORNO").Value = "GUARDADO" Then
                    MsgBox("Producto guardado", MsgBoxStyle.Information, "Confirmación")
                    DialogResult = DialogResult.OK
                    Me.Close()

                Else
                    MsgBox("Producto ya existente, verfique la clave", MsgBoxStyle.Critical, "Advertencia")
                    TXTCLAVE.Focus()
                End If

            End If

        End If
    End Sub

    Private Sub TXTPRECIO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPRECIO.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub
    Public Property imagenRuta As String
    Private Sub BTNCARGARIMG_Click(sender As Object, e As EventArgs) Handles BTNCARGARIMG.Click
        Dim CARGARIMG As New OpenFileDialog


        CARGARIMG.InitialDirectory = "C:\"
        CARGARIMG.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png"
        CARGARIMG.FilterIndex = 1
        CARGARIMG.RestoreDirectory = True

        ' Mostrar el OpenFileDialog y verificar si el usuario seleccionó un archivo
        If CARGARIMG.ShowDialog() = DialogResult.OK Then
            ' Obtener la ruta del archivo seleccionado
            imagenRuta = CARGARIMG.FileName

            ' Cargar la imagen en el PictureBox
            PRODIMAGEN.Image = Image.FromFile(imagenRuta)
        End If
    End Sub

    Private Sub BTNLIMPIARIMG_Click(sender As Object, e As EventArgs) Handles BTNLIMPIARIMG.Click
        PRODIMAGEN.Image = Nothing
        imagenRuta = String.Empty

    End Sub
    Dim MOSTRARIMAGEN As New FrmImagenProducto
    Private Sub PRODIMAGEN_Click(sender As Object, e As EventArgs) Handles PRODIMAGEN.Click
        If PRODIMAGEN.Image Is Nothing Or imagenRuta Is String.Empty Then
            MsgBox("No hay imagen disponible", MsgBoxStyle.Information, "Advertencia")

        Else
            If FrmInventario.BANDERA = "EDITAR" Then
                MOSTRARIMAGEN.IMAGENGND.Image = Image.FromFile(FrmInventario.rutaImagen)
                MOSTRARIMAGEN.ShowDialog()

            Else
                MOSTRARIMAGEN.IMAGENGND.Image = Image.FromFile(imagenRuta)
                MOSTRARIMAGEN.ShowDialog()
            End If
        End If
    End Sub

    Private Sub TXTNOMBRE_TextChanged(sender As Object, e As EventArgs) Handles TXTNOMBRE.TextChanged
        If TXTNOMBRE.Text = String.Empty Then
            FrmImagenProducto.Text = ". . ."

        Else
            FrmImagenProducto.Text = "Poducto: " + TXTNOMBRE.Text
        End If
    End Sub
End Class