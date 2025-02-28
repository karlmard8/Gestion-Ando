Public Class FrmAltaProductos
    Private Sub FrmAltaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTPRECIO.Text = "0"
        SPINNER.Location = New Point(151, 121)
        SPINNER.Minimum = 0
        SPINNER.Maximum = 1000
        SPINNER.TabIndex = 4
        Me.Controls.Add(SPINNER)
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

            Else
                StrSql = "EDITARPRODUCTOS"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("PROID", SqlDbType.BigInt).Value = idbusqueda
            End If

            comando.Parameters.Add("@PROCLAVE", SqlDbType.VarChar, 10).Value = TXTCLAVE.Text
            comando.Parameters.Add("@PRONOMBRE", SqlDbType.VarChar, 255).Value = TXTNOMBRE.Text
            comando.Parameters.Add("@PROEXISTENCIAS", SqlDbType.Int).Value = Integer.Parse(SPINNER.Text)
            comando.Parameters.Add("@PROPRECIO", SqlDbType.Money).Value = TXTPRECIO.Text
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
End Class