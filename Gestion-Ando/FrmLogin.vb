Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FrmLogin
    Private Sub BTNENTRAR_Click(sender As Object, e As EventArgs) Handles BTNENTRAR.Click
        StrSql = "SELECT * FROM TBLUSUARIOS WHERE USULOGIN ='" & Me.TXTLOGIN.Text & "' AND USUCLAVE = '" & Me.TXTCONTRASEÑA.Text & "' AND USUEXISTE = 1"
        If Leer("TBLUSUARIOS") = True Then
            Me.Hide()
            Dim ventana As New FrmPrincipal
            ventana.Show()
        Else
            MsgBox("Usuario o contraseña son incorrectos", MsgBoxStyle.Critical, "Advertencia")
        End If
        'TIPO = "OPERADOR"
        StrSql = "SELECT USUCLAVE FROM TBLUSUARIOS WHERE USULOGIN = @Login AND USUCLAVE = @Clave AND USUEXISTE = 1 AND USUTIPO = 'Administrador'"
        Dim comando As New SqlClient.SqlCommand(StrSql, Conexion)
        comando.Parameters.AddWithValue("@Login", Me.TXTLOGIN.Text)
        comando.Parameters.AddWithValue("@Clave", Me.TXTCONTRASEÑA.Text)

        ' Abrir la conexión
        Conexion.Open()

        ' Ejecutar la consulta y almacenar las contraseñas en una lista
        Dim reader As SqlClient.SqlDataReader = comando.ExecuteReader()
        Dim contraseñas As New List(Of String)

        While reader.Read()
            contraseñas.Add(reader("USUCLAVE").ToString())
        End While

        ' Cerrar la conexión
        Conexion.Close()

        Dim contraseñaIngresada As String = TXTCONTRASEÑA.Text

        ' Validar la contraseña
        MsgBox(contraseñaIngresada)
    End Sub
    Private Function ValidarContraseña(contraseñaIngresada As String, contraseñas As List(Of String)) As Boolean
        Return contraseñas.Contains(contraseñaIngresada)
    End Function

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call inicio()


    End Sub
End Class
