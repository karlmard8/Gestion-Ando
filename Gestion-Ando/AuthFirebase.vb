Imports Firebase.Auth

Module AuthFirebase
    Private ReadOnly ApiKey As String = "AIzaSyCkl-B3TYEUS3y1PUwmHrbSt13_sl_PmMM" ' Reemplázalo con la clave API Web de Firebase
    Private authProvider As New FirebaseAuthProvider(New FirebaseConfig(ApiKey))

    ' 🔥 Variable global para almacenar el usuario autenticado
    Public AuthUser As FirebaseAuthLink

    ' 🔹 Función para iniciar sesión con email y contraseña
    Public Async Function IniciarSesion(email As String, password As String) As Task(Of Boolean)
        Try
            AuthUser = Await authProvider.SignInWithEmailAndPasswordAsync(email, password)
            MessageBox.Show("Inicio de sesión exitoso. ID de usuario: " & AuthUser.User.LocalId, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As FirebaseAuthException
            MessageBox.Show("Error de autenticación: " & ex.Reason & vbCrLf & "Mensaje: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module