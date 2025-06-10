Public Class FRMINICIO
    Private Sub FRMINICIO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
    End Sub

    Private Sub BTNGMAIL_Click(sender As Object, e As EventArgs) Handles BTNGMAIL.Click
        Dim gmailURL As String = $"https://mail.google.com/mail/u/0/?view=cm&fs=1&tf=1&to={"gestionandosoporte@gmail.com"}"

        ' 🔹 Abrir Gmail solo si hay un destinatario válido
        Process.Start(New ProcessStartInfo(gmailURL) With {.UseShellExecute = True})
    End Sub

    Private Sub BTNWHATSAPP_Click(sender As Object, e As EventArgs) Handles BTNWHATSAPP.Click
        Dim numero As String = "523222388858"
        Dim url As String = "https://wa.me/" & numero

        Process.Start(url)
    End Sub
End Class