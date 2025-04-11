Imports Google.Cloud.Firestore

Module MDatos

    Public Conexion As SqlClient.SqlConnection
    Public comando As SqlClient.SqlCommand
    Public StrSql As String
    Public dts As New DataSet
    Public idbusqueda As Long
    Public TIPO As String
    Public USUARIOACTUAL As String
    Public IDUSUARIOACTUAL As Integer
    Public FECHA

    Public Property ColorBotones As Color = Color.FromArgb(213, 191, 168) 'Color para botones café

    Public Property ColorFormulario As Color = Color.FromArgb(255, 251, 248) 'Color principal

    Public Property ColorMenuStrip As Color = Color.FromArgb(147, 116, 88) 'Color para menustrip

    Public Function Conectar() As Boolean
        Dim ret As Boolean
        Try
            comando.Connection.Open()
            comando.ExecuteNonQuery()
            ret = True
        Catch ex As Exception
            ret = False
            MsgBox("SE A PRODUCIDO EL SIGUIENTE ERROR :" & ex.Message & " ", MsgBoxStyle.Critical, "")
        End Try
        comando.Connection.Close()

        Return ret
    End Function


    Public Function Leer(ByVal tabla As String) As Boolean
        Dim ret As Boolean
        dts.Clear()
        Dim adp As New SqlClient.SqlDataAdapter(StrSql, Conexion)
        Try
            adp.Fill(dts, tabla)
            If dts.Tables(tabla).Rows.Count > 0 Then
                ret = True
            Else
                ret = False
            End If
        Catch EX As Exception
            MsgBox("Error Al Realizar La Operacion, Servidor No Encontrado", MsgBoxStyle.Critical, "")
        End Try

        Return ret
    End Function

    Public Property SERVIDOR As String
    Public Property BASEDATOS As String
    Public Property USUARIO As String
    Public Property CONTRASEÑA As String

    Public Sub inicio()
        Conexion = New SqlClient.SqlConnection("server=" & SERVIDOR & "; database=" & BASEDATOS & "; uid=" & USUARIO & "; pwd=" & CONTRASEÑA & ";")
        'SERVIDOR LOCAL desktop-8q10a8h\sqlexpress
        'SERVIDOR PUBLICO 192.168.1.73
    End Sub

    'CONEXION A LAS LICENCIAS

    Public Class FirestoreConexion
        Private firestoreDb As FirestoreDb

        Public Sub New()
            Dim rutaCredenciales As String = "C:\Users\carlo\Downloads\licenciasgestion-ando-firebase-adminsdk-fbsvc-7c108e7198.json"
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", rutaCredenciales)
            firestoreDb = FirestoreDb.Create("licenciasgestion-ando")
        End Sub

        Async Function ObtenerDocumento(calveNumero As Integer) As Task(Of Dictionary(Of String, Object))
            If AuthFirebase.AuthUser Is Nothing Then
                MessageBox.Show("Usuario no autenticado. Inicie sesión antes de validar la licencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return Nothing
            End If

            ' 🔹 Filtrar los documentos por el campo "Calve" en lugar de buscar por ID
            Dim query = firestoreDb.Collection("Licencias").WhereEqualTo("Calve", calveNumero)
            Dim snapshot = Await query.GetSnapshotAsync()

            If snapshot.Documents.Count > 0 Then
                Return snapshot.Documents(0).ToDictionary() ' 🔥 Tomamos el primer documento que coincida
            End If

            Return Nothing
        End Function
    End Class
End Module
