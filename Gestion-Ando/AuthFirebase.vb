Imports System.IO
Imports Google.Cloud.Firestore

Module AuthFirebase
    Public Property BLOQUEO As Boolean = False   'ESTABLECER SI LA LICENCIA ES REMOTA O LOCAL (FALSE ES REMOTA Y TRUE ES LOCAL)

    Public Class FirestoreConexion
        Dim MENSAJES As Boolean = False
        Private firestoreDb As FirestoreDb
        Private conexionInicializada As Boolean = False

        Public Sub New()

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
                MessageBox.Show("Alerta de seguridad: la licencia fue comprometida." & vbCrLf & "Contacte a soporte.", "Alerta de seguridad ELR03", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conexionInicializada = False
                Application.Exit()
            End Try
        End Sub

        Async Function ObtenerDocumento(calveNumero As String) As Task(Of Dictionary(Of String, Object))
            If BLOQUEO = True Then
                Return Nothing 'Siempre debe devolver un valor
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

            Return Nothing 'Asegurar que se devuelva un valor en todos los casos
        End Function

    End Class

End Module