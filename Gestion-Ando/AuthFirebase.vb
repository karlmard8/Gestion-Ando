Imports System.IO
Imports Firebase.Auth
Imports Google.Cloud.Firestore

Module AuthFirebase
    Public Property BLOQUEO As Boolean = False   'ESTABLECER SI LA LICENCIA ES REMOTA O LOCAL (FALSE ES REMOTA Y TRUE ES LOCAL)

    Private ReadOnly ApiKey As String = "AIzaSyCkl-B3TYEUS3y1PUwmHrbSt13_sl_PmMM" ' Reemplázalo con la clave API Web de Firebase
    Private authProvider As New FirebaseAuthProvider(New FirebaseConfig(ApiKey))

    'Variable global para almacenar el usuario autenticado
    Public AuthUser As FirebaseAuthLink

    ' 🔹 Función para iniciar sesión con email y contraseña
    Public Async Function IniciarSesion(email As String, password As String) As Task(Of Boolean)
        If BLOQUEO = True Then
            Return False ' 🔥 Devolver un valor si el acceso está bloqueado
        End If

        Try
            AuthUser = Await authProvider.SignInWithEmailAndPasswordAsync(email, password)
            Return True
        Catch ex As FirebaseAuthException
            MessageBox.Show("Error de autenticación: Verifique la conexión a internet o llame a soporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Return False ' 🔥 Asegurar que siempre haya un retorno
        End Try
    End Function


    Public Class FirestoreConexion
        Dim MENSAJES As Boolean = False
        Private firestoreDb As FirestoreDb
        Private conexionInicializada As Boolean = False

        Public Sub New()
            If BLOQUEO = False Then
                ' Continuar si la licencia es remota
            Else
                Exit Sub
            End If


            ' Obtener ruta al archivo JSON en la carpeta del .exe
            Dim rutaJson As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "licenciasgestion-ando-firebase-adminsdk-fbsvc-7c108e7198.json")

            ' Validar existencia del archivo JSON
            If Not File.Exists(rutaJson) Then
                MessageBox.Show("El archivo JSON de Firebase no se encuentra en la carpeta de la aplicación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexionInicializada = False
                Exit Sub
            End If

            ' Establecer variable de entorno y crear la conexión
            Try
                Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", rutaJson)
                firestoreDb = FirestoreDb.Create("licenciasgestion-ando")
                conexionInicializada = True
            Catch ex As Exception
                MENSAJES = True
                MessageBox.Show("Alerta de seguridad: la licencia fue comprometida." &
                                vbCrLf & "Contacte a sporte.", "Alerta de seguridad ELR03", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexionInicializada = False
                Application.Exit()
            End Try
        End Sub

        Async Function ObtenerDocumento(calveNumero As Integer) As Task(Of Dictionary(Of String, Object))
            If BLOQUEO = True Then
                Return Nothing ' 🔥 Siempre debe devolver un valor
            End If

            If AuthFirebase.AuthUser Is Nothing Then
                MessageBox.Show("Usuario no autenticado. " & vbCrLf & "Contacte a soporte.", "Alerta de seguridad ELR04", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End If

            If Not conexionInicializada OrElse firestoreDb Is Nothing Then
                MessageBox.Show("No se pudo establecer la conexión a Firestore. " & vbCrLf & "Verifique las credenciales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End If

            Try
                Dim query = firestoreDb.Collection("Licencias").WhereEqualTo("Calve", calveNumero)
                Dim snapshot = Await query.GetSnapshotAsync()

                If snapshot.Documents.Count > 0 Then
                    Return snapshot.Documents(0).ToDictionary()
                End If
            Catch ex As Exception
                MessageBox.Show("Error al consultar Firestore: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return Nothing ' 🔥 Asegurar que se devuelva un valor en todos los casos
        End Function

    End Class

End Module