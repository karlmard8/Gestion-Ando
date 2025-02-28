Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmAltaClientes
    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is System.Windows.Forms.TextBox Then
                DirectCast(ctrl, System.Windows.Forms.TextBox).Clear()
            ElseIf TypeOf ctrl Is System.Windows.Forms.NumericUpDown Then
                DirectCast(ctrl, System.Windows.Forms.NumericUpDown).Value = 0
            End If
        Next

        If Me.Controls.Contains(TXTCODIGO) Then
            TXTCODIGO.Focus()
        End If
    End Sub


    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub

    Private Sub FrmAltaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTCODIGO.Focus()
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        DialogResult = DialogResult.OK
        If String.IsNullOrEmpty(TXTCODIGO.Text) Then
            MsgBox("Codigo faltante", MsgBoxStyle.Information)
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
            comando.Parameters.Add("@CLICOMENTARIOS", SqlDbType.VarChar, 250).Value = TXTNOTAS.Text             'NO GUARDA EL DATO
            comando.Parameters.Add("@CLIHISTORIALCREDITICIO", SqlDbType.VarChar, 20).Value = TXTCREDITO.Text    'NO GUARDA EL DATO 
            comando.Parameters.Add("@CLIRFC", SqlDbType.VarChar, 20).Value = TXTRFC.Text                        'NO GUARDA LEL DATO
            comando.Parameters.Add("@CLIREGIMENFISCAL", SqlDbType.VarChar, 100).Value = TXTREGIMEN.Text
            comando.Parameters.Add("@CLICFDI", SqlDbType.VarChar, 100).Value = TXTCFDI.Text
            comando.Parameters.Add("@RETORNO", SqlDbType.VarChar, 30).Direction = ParameterDirection.Output

            If Conectar() = True Then
                If comando.Parameters("@RETORNO").Value = "GUARDADO" Then
                    MsgBox("Cliente registrado", MsgBoxStyle.Information, "Conformación")
                    DialogResult = DialogResult.OK
                    Me.Close()

                Else
                    MsgBox("Cliente existente", MsgBoxStyle.Critical, "Advertencia")
                    TXTCODIGO.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub TXTRFC_TextChanged(sender As Object, e As EventArgs) Handles TXTRFC.TextChanged
        Dim cursorPos As Integer = TXTRFC.SelectionStart

        ' Convertir todo el texto a mayúsculas
        TXTRFC.Text = TXTRFC.Text.ToUpper()

        ' Restaurar la posición del cursor
        TXTRFC.SelectionStart = cursorPos
    End Sub
End Class