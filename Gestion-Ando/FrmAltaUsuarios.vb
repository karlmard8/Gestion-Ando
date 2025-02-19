Public Class FrmAltaUsuarios
    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        For Each ctrl As Control In Me.Controls.OfType(Of TextBox)()
            ctrl.Text = String.Empty
        Next
        TXTNOMBRE.Focus()
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If TXTLOGIN.Text = String.Empty Then
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
            comando.Parameters.Add("@USUTIPO", SqlDbType.VarChar, 80).Value = TXTTIPO.SelectedValue
            comando.Parameters.Add("@RETORNO", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output

            If Conectar() = True Then
                comando.ExecuteNonQuery() ' Ejecuta el comando SQL

                ' Asegúrate de que el valor del parámetro de salida está disponible después de la ejecución del comando
                If comando.Parameters("@RETORNO").Value.ToString() = "GUARDADO" Then
                    MsgBox("Proveedor guardado", MsgBoxStyle.Information, "Confirmacion")
                    DialogResult = DialogResult.OK
                    Me.Close()
                Else
                    MsgBox("Proveedor existente", MsgBoxStyle.Critical, "Advertencia")
                End If
            End If
        End If
    End Sub

End Class