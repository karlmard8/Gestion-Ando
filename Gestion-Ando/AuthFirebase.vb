Imports Firebase.Auth
Imports Google.Cloud.Firestore

Module AuthFirebase
    Public Property BLOQUEO As Boolean = True   'ESTABLECER SI LA LICENCIA ES REMOTA O LOCAL (FALSE ES REMOTA Y TRUE ES LOCAL)

    Private ReadOnly ApiKey As String = "AIzaSyCkl-B3TYEUS3y1PUwmHrbSt13_sl_PmMM" ' Reemplázalo con la clave API Web de Firebase
    Private authProvider As New FirebaseAuthProvider(New FirebaseConfig(ApiKey))

    'Variable global para almacenar el usuario autenticado
    Public AuthUser As FirebaseAuthLink

    ' 🔹 Función para iniciar sesión con email y contraseña
    Public Async Function IniciarSesion(email As String, password As String) As Task(Of Boolean)
        If BLOQUEO = False Then

        Else
            Exit Function
        End If
        Try
            AuthUser = Await authProvider.SignInWithEmailAndPasswordAsync(email, password)
            'MessageBox.Show("Inicio de sesión exitoso. ID de usuario: " & AuthUser.User.LocalId, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True
        Catch ex As FirebaseAuthException
            MessageBox.Show("Error de autenticación: Verifique la conexión a internet o llame a soporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Return False
        End Try
    End Function


    Public Class FirestoreConexion

        Private firestoreDb As FirestoreDb

        Public Sub New()
            If BLOQUEO = False Then

            Else
                Exit Sub
            End If

            Dim rutaCredenciales As String = "C:\Users\carlo\Downloads\licenciasgestion-ando-firebase-adminsdk-fbsvc-7c108e7198.json"

            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", rutaCredenciales)
            firestoreDb = FirestoreDb.Create("licenciasgestion-ando")
        End Sub

        Async Function ObtenerDocumento(calveNumero As Integer) As Task(Of Dictionary(Of String, Object))
            If BLOQUEO = False Then

            Else
                Exit Function
            End If

            If AuthFirebase.AuthUser Is Nothing Then
                MessageBox.Show("Usuario no autenticado. Inicie sesión antes de validar la licencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End If

            'Filtrar los documentos por el campo "Calve" en lugar de buscar por ID
            Dim query = firestoreDb.Collection("Licencias").WhereEqualTo("Calve", calveNumero)
            Dim snapshot = Await query.GetSnapshotAsync()

            If snapshot.Documents.Count > 0 Then
                Return snapshot.Documents(0).ToDictionary() ' 🔥 Tomamos el primer documento que coincida
            End If

            Return Nothing
        End Function
    End Class
End Module