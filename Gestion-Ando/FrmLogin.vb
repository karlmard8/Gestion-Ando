
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FrmLogin

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call inicio()

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.KeyDown, AddressOf TextBox_KeyDown
            End If
        Next
    End Sub
    Private Sub TXTCONTRASEÑA_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTCONTRASEÑA.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTNENTRAR.PerformClick()
        End If

    End Sub
    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Evitar el sonido "ding" cuando se presiona Enter

            Dim currentTextBox As TextBox = CType(sender, TextBox)
            Me.SelectNextControl(currentTextBox, True, True, True, True)

        End If
    End Sub

    Private Sub BTNENTRAR_Click(sender As Object, e As EventArgs) Handles BTNENTRAR.Click
        StrSql = "SELECT * FROM TBLUSUARIOS WHERE USULOGIN ='" & Me.TXTLOGIN.Text & "' AND USUCLAVE = '" & Me.TXTCONTRASEÑA.Text & "' AND USUEXISTE = 1"
        If Leer("TBLUSUARIOS") = True Then
            Me.Hide()
            Dim ventana As New FrmPrincipal
            ventana.Show()
        Else
            MsgBox("Usuario o contraseña son incorrectos", MsgBoxStyle.Critical, "Advertencia")
            TXTLOGIN.Focus()
        End If

    End Sub


End Class
