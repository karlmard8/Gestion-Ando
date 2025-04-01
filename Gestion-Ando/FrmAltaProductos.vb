Public Class FrmAltaProductos
    Private Sub FrmAltaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        BTNGUARDAR.BackColor = ColorBotones
        BTNLIMPIAR.BackColor = ColorBotones
        BTNCANCELAR.BackColor = ColorBotones
        BTNCARGARIMG.BackColor = ColorBotones
        'Revisar cuando guarda 1000
        SPINNER.Minimum = -1000
        SPINNER.Maximum = 1000
        SPINNER.TabIndex = 4
        Me.Controls.Add(SPINNER)
        If TIPO = "Operativo" Then


        End If
        If FrmInventario.BANDERA = "NUEVO" Then
            PRODIMAGEN.Image = Nothing
            imagenRuta = String.Empty
        End If
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox OrElse TypeOf ctrl Is Button OrElse TypeOf ctrl Is NumericUpDown Then
                AddHandler ctrl.KeyDown, AddressOf Control_KeyDown
                AddHandler ctrl.KeyDown, AddressOf Textbox_KeyDown
                AddHandler ctrl.KeyDown, AddressOf Button_KeyDown
                AddHandler ctrl.KeyDown, AddressOf SPINNER_KeyDown
            End If
        Next
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ' Definir el ancho del borde
        Dim bordeAncho As Integer = 1

        ' Crear un pincel para el borde (color y grosor)
        Dim bordeColor As Color = Color.Black ' Color negro para simular FixedSingle
        Dim bordePen As New Pen(bordeColor, bordeAncho)

        ' Dibujar el borde alrededor del formulario
        e.Graphics.DrawRectangle(bordePen, 0, 0, Me.ClientSize.Width - 1, Me.ClientSize.Height - 1)

        ' Liberar el recurso del pincel
        bordePen.Dispose()
    End Sub

    Private Sub Control_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Evitar el sonido "ding" cuando se presiona Enter

            Dim currentControl As Control = CType(sender, Control)
            Me.SelectNextControl(currentControl, True, True, True, True)
        End If
    End Sub

    Public Sub Textbox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            BTNCANCELAR.PerformClick()
        End If
    End Sub

    Private Sub Button_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            BTNCANCELAR.PerformClick()
        End If
    End Sub

    Private Sub SPINNER_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            BTNCANCELAR.PerformClick()
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
            MsgBox("Información faltante", MsgBoxStyle.Critical, "Advertencia")
            TXTCLAVE.Focus()

        ElseIf TXTNOMBRE.Text = String.Empty Or TXTPRECIO.Text = String.Empty Then
            MsgBox("Información faltante", MsgBoxStyle.Critical, "Advertencia")
            TXTCLAVE.Focus()

        ElseIf String.IsNullOrWhiteSpace(SPINNER.Text) Then
            MsgBox("Información faltante", MsgBoxStyle.Critical, "Advertencia")
            TXTCLAVE.Focus()

        Else
            If idbusqueda = 0 Then
                StrSql = "ALTAPRODUCTOS"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@PROPRECIO", SqlDbType.Money).Value = TXTPRECIO.Text
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
        Dim CARGARIMG As New OpenFileDialog()

        ' Configurar propiedades del OpenFileDialog
        CARGARIMG.InitialDirectory = "C:\"
        CARGARIMG.Filter = "Todos los archivos de imagen|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif;*.tiff;*.ico;*.webp|Todos los archivos (*.*)|*.*"
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

End Class