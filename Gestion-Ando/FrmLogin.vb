Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FrmLogin
    Private Sub BTNENTRAR_Click(sender As Object, e As EventArgs) Handles BTNENTRAR.Click
        StrSql = "SELECT * FROM TBLUSUARIOS WHERE USULOGIN ='" & Me.TXTLOGIN.Text & "' AND USUCLAVE = '" & Me.TXTCONTRASEÑA.Text & "' AND USUEXISTE =1"

        If Leer("TBLUSUARIOS") = True Then
            Me.Hide()
            Dim ventana As New FrmPrincipal
            ventana.Show()
        Else
            MsgBox("Usuario o contraseña son incorrectos", MsgBoxStyle.Critical, "Advertencia")
        End If
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call inicio()
    End Sub
End Class
