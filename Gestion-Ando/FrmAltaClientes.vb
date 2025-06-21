Public Class FrmAltaClientes

    Private Sub FrmAltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        EstiloBotones.CambiarColorBotones(Me)

        TXTCODIGO.Focus()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is ComboBox OrElse TypeOf ctrl Is Button Then
                AddHandler ctrl.KeyDown, AddressOf Control_KeyDown
                AddHandler ctrl.KeyDown, AddressOf FrmAltaClientes_KeyDown
            End If
        Next
    End Sub

    Private Sub FrmAltaClientes_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is System.Windows.Forms.TextBox Then
                DirectCast(ctrl, System.Windows.Forms.TextBox).Clear()
            ElseIf TypeOf ctrl Is System.Windows.Forms.NumericUpDown Then
                DirectCast(ctrl, System.Windows.Forms.NumericUpDown).Value = 0
            ElseIf TypeOf ctrl Is System.Windows.Forms.ComboBox Then
                DirectCast(ctrl, System.Windows.Forms.ComboBox).SelectedIndex = -1
            End If
        Next

        If Me.Controls.Contains(TXTCODIGO) Then
            TXTCODIGO.Focus()
        End If
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.TXTCREDITO.SelectedIndex = -1
        Me.Close()
        TXTCODIGO.Focus()
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If String.IsNullOrEmpty(TXTCODIGO.Text) Then
            MessageBox.Show("Código faltante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TXTCODIGO.Focus()

        Else
            If idbusqueda = 0 Then
                StrSql = "ALTACLIENTES"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
            Else
                StrSql = "EDITARCLIENTES"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@CLIID", SqlDbType.BigInt).Value = idbusqueda
            End If

            comando.Parameters.Add("@CLICODIGO", SqlDbType.VarChar, 10).Value = TXTCODIGO.Text
            comando.Parameters.Add("@CLINOMBRE", SqlDbType.VarChar, 100).Value = TXTNOMBRE.Text
            comando.Parameters.Add("@CLIAPEPATERNO", SqlDbType.VarChar, 50).Value = TXTAPEPATERNO.Text
            comando.Parameters.Add("@CLIAPEMATERNO", SqlDbType.VarChar, 50).Value = TXTAPEMATERNO.Text
            comando.Parameters.Add("@CLIDIRECCION", SqlDbType.VarChar, 100).Value = TXTCALLE.Text
            comando.Parameters.Add("@CLICOLONIA", SqlDbType.VarChar, 80).Value = TXTCOLONIIA.Text
            comando.Parameters.Add("@CLICP", SqlDbType.VarChar, 5).Value = TXTCP.Text
            comando.Parameters.Add("@CLICIUDAD", SqlDbType.VarChar, 80).Value = TXTCIUDAD.Text
            comando.Parameters.Add("@CLIESTADO", SqlDbType.VarChar, 30).Value = TXTESTADO.Text
            comando.Parameters.Add("@CLITELEFONO", SqlDbType.VarChar, 10).Value = TXTTELEFONO.Text
            comando.Parameters.Add("@CLICORREO", SqlDbType.VarChar, 100).Value = TXTCORREO.Text
            comando.Parameters.Add("@CLICOMENTARIOS", SqlDbType.VarChar, 250).Value = TXTNOTAS.Text
            comando.Parameters.Add("@CLIHISTORIALCREDITICIO", SqlDbType.VarChar, 20).Value = TXTCREDITO.Text
            comando.Parameters.Add("@CLIRFC", SqlDbType.VarChar, 20).Value = TXTRFC.Text
            comando.Parameters.Add("@CLIREGIMENFISCAL", SqlDbType.VarChar, 100).Value = TXTREGIMEN.Text
            comando.Parameters.Add("@CLICFDI", SqlDbType.VarChar, 100).Value = TXTCFDI.Text
            comando.Parameters.Add("@RETORNO", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output

            If Conectar() = True Then
                If comando.Parameters("@RETORNO").Value = "GUARDADO" Then
                    MsgBox("Cliente registrado", MsgBoxStyle.Information, "Confirmación")
                    DialogResult = DialogResult.OK
                    Me.Close()

                Else
                    MsgBox("Código existente", MsgBoxStyle.Exclamation, "Advertencia")
                    TXTCODIGO.Focus()

                End If
            End If
        End If
        TXTCODIGO.Focus()
    End Sub

    Private Sub TXTRFC_TextChanged(sender As Object, e As EventArgs) Handles TXTRFC.TextChanged
        Dim cursorPos As Integer = TXTRFC.SelectionStart

        ' Convertir todo el texto a mayúsculas
        TXTRFC.Text = TXTRFC.Text.ToUpper()

        ' Restaurar la posición del cursor
        TXTRFC.SelectionStart = cursorPos
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

    Private Sub TXTTELEFONO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTTELEFONO.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True ' Bloquear cualquier otra entrada
        End If
    End Sub

    Private Sub TXTCP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCP.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> "-" AndAlso e.KeyChar <> Chr(8) Then
            e.Handled = True ' Bloquear cualquier otra entrada
        End If
    End Sub
End Class