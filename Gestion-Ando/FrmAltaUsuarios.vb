Public Class FrmAltaUsuarios
    Private Sub FrmAltaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        BTNGUARDAR.BackColor = ColorBotones
        BTNLIMPIAR.BackColor = ColorBotones
        BTNCANCELAR.BackColor = ColorBotones
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox OrElse TypeOf ctrl Is Button OrElse TypeOf ctrl Is NumericUpDown Then
                AddHandler ctrl.KeyDown, AddressOf Control_KeyDown
                AddHandler ctrl.KeyDown, AddressOf FrmAltaUsuarios_KeyDown
            End If
        Next
    End Sub

    Private Sub FrmAltaUsuarios_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub Control_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Evitar el sonido "ding" cuando se presiona Enter

            Dim currentControl As Control = CType(sender, Control)
            Me.SelectNextControl(currentControl, True, True, True, True)
        End If
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
    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.TXTTIPO.SelectedIndex = -1
        Me.Close()
        TXTNOMBRE.Focus()
    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs)
        For Each ctrl As Control In Me.Controls.OfType(Of TextBox)()
            ctrl.Text = String.Empty
        Next
        TXTNOMBRE.Focus()
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If TXTCONFIRMAR.Text <> TXTCLAVE.Text Then
            MsgBox("Las contraseñas no coinciden", MsgBoxStyle.Critical, "Error")
        Else
            If String.IsNullOrWhiteSpace(TXTLOGIN.Text) Then
                MsgBox("Login faltante", MsgBoxStyle.Information)
                TXTLOGIN.Focus()
            Else
                If idbusqueda = 0 Then
                    StrSql = "ALTAUSUARIOS"
                    comando = New SqlClient.SqlCommand(StrSql, Conexion)
                    comando.CommandType = CommandType.StoredProcedure

                Else
                    StrSql = "EDITARUSUARIOS"
                    comando = New SqlClient.SqlCommand(StrSql, Conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Add("USUID", SqlDbType.BigInt).Value = idbusqueda
                End If

                comando.Parameters.Add("@USUNOMBRE", SqlDbType.VarChar, 80).Value = TXTNOMBRE.Text
                comando.Parameters.Add("@USULOGIN", SqlDbType.VarChar, 10).Value = TXTLOGIN.Text
                comando.Parameters.Add("@USUCLAVE", SqlDbType.VarChar, 10).Value = TXTCLAVE.Text
                comando.Parameters.Add("@USUTIPO", SqlDbType.VarChar, 15).Value = TXTTIPO.Text
                comando.Parameters.Add("@RETORNO", SqlDbType.Int).Direction = ParameterDirection.Output

                If Conectar() = True Then
                    If comando.Parameters("@RETORNO").Value = 1 Then
                        MsgBox("Usuario guardado", MsgBoxStyle.Information, "Confirmacion")
                        DialogResult = DialogResult.OK
                        Me.Close()
                    Else
                        MsgBox("Usuario existente", MsgBoxStyle.Critical, "Advertencia")
                        TXTNOMBRE.Focus()
                    End If
                End If
            End If
        End If
        TXTNOMBRE.Focus()
    End Sub

    Private Sub BTNLIMPIAR_Click_1(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).Clear()
            End If
            If TypeOf ctrl Is ComboBox Then
                DirectCast(ctrl, ComboBox).SelectedIndex = -1
            End If
        Next
        TXTNOMBRE.Focus()
    End Sub

End Class