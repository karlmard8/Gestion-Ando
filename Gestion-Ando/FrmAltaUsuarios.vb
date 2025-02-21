Public Class FrmAltaUsuarios
    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs)
        For Each ctrl As Control In Me.Controls.OfType(Of TextBox)()
            ctrl.Text = String.Empty
        Next
        TXTNOMBRE.Focus()
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If String.IsNullOrWhiteSpace(TXTLOGIN.Text) Then
            MsgBox("Login faltante", MsgBoxStyle.Information)
            TXTLOGIN.Focus()
        Else
            If idbusqueda = 0 Then
                StrSql = "ALTAUSUARIOS"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
            End If

            comando.Parameters.Add("@USUNOMBRE", SqlDbType.VarChar, 80).Value = TXTNOMBRE.Text
            comando.Parameters.Add("@USULOGIN", SqlDbType.VarChar, 10).Value = TXTLOGIN.Text
            comando.Parameters.Add("@USUCLAVE", SqlDbType.VarChar, 10).Value = TXTCLAVE.Text
            comando.Parameters.Add("@USUTIPO", SqlDbType.VarChar, 80).Value = TXTTIPO.Text
            comando.Parameters.Add("@PRUEBA", SqlDbType.Int).Direction = ParameterDirection.Output

            If Conectar() = True Then
                ' Asegúrate de que el valor del parámetro de salida está disponible después de la ejecución del comando
                If comando.Parameters("@PRUEBA").Value = 1 Then
                    MsgBox("Usuario guardado", MsgBoxStyle.Information, "Confirmacion")
                    DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Usuario existente", MsgBoxStyle.Critical, "Advertencia")
                    TXTNOMBRE.Focus()
                End If
            End If
        End If
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