Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports CrystalDecisions.ReportAppServer


Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrEmpty(My.Settings.ServidorSql) OrElse String.IsNullOrEmpty(My.Settings.IdLicencia) Then
            My.Settings.ServidorSql = InputBox("Ingrese el nombre del servidor:", "Configuración de servidor")
            My.Settings.IdLicencia = InputBox("Ingrese el ID de la licencia:", "Configuración de licencia")
            My.Settings.Save()
        End If

        SERVIDOR = My.Settings.ServidorSql
        BASEDATOS = "MuebleAlex"
        USUARIO = "sa"
        CONTRASEÑA = "c1oooooo"

        'Aplicar configuraciones de diseño
        Me.BackColor = ColorFormulario
        EstiloBotones.CambiarColorBotones(Me)

        'Llamar funciones adicionales
        Call inicio()

        'Manejar eventos para los `TextBox`
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.KeyDown, AddressOf TextBox_KeyDown
            End If
        Next

        VerificarUsuarios()
    End Sub

    Dim BOTON As Boolean = False
    Public Sub VerificarUsuarios()
        StrSql = "SELECT * FROM TBLUSUARIOS WHERE USUEXISTE = 1"
        If Leer("TBLUSUARIOS") = False Then
            If BOTON = False Then
                MessageBox.Show("No hay usuarios en el sistema, es momento de crear uno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            FrmAltaUsuarios.LBLUSUARIOS.Text = "Crear nuevo usuario"
            FrmAltaUsuarios.LBLUSUARIOS.Location = New Point(160, 10)
            FrmAltaUsuarios.ShowInTaskbar = True
            FrmAltaUsuarios.ShowDialog()
        ElseIf Leer("TBLUSUARIOS") = True Then
            BTNCREARUSUARIO.Visible = False
        End If
    End Sub

    Private Sub FrmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Validamos la licencia solo después de que el formulario esté completamente visible
        If BLOQUEO = False Then
            btnlogin.Visible = False
            btnLogin_Click(sender, e)
            ValidarJsonFirebase()
        End If
    End Sub

    Public fechaVencimiento As DateTime
    Dim estado As String
    Dim BLOQUEODEFINITIVO As Boolean
    Private hashOriginalJson As String = ""

    Public Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If BLOQUEO = True Then
            MessageBox.Show("Acceso bloqueado. Contacte a soporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Obtener datos de la licencia en Firestore
        Dim validador As New FirestoreConexion()
        Dim clave As String = My.Settings.IdLicencia
        Dim snapshot = Await validador.ObtenerDocumento(clave)

        'Validar que el documento tiene los datos necesarios
        If snapshot IsNot Nothing AndAlso snapshot.ContainsKey("Estado") AndAlso snapshot.ContainsKey("FechaVencimiento") Then
            estado = snapshot("Estado").ToString()

            'Convertir timestamp de Firestore a DateTime
            Dim fechaVencimientoTimestamp As Google.Cloud.Firestore.Timestamp = snapshot("FechaVencimiento")
            fechaVencimiento = fechaVencimientoTimestamp.ToDateTime()

            'Validar estado y fecha de vencimiento
            If estado.Trim() = "Activa" And fechaVencimiento >= DateTime.Now Then
                'Licencia válida, continuar con la aplicación
            Else
                MessageBox.Show("Error de seguridad: hay problemas para verificar la licencia." & vbCrLf & "Contacte a soporte.",
                        "Alerta de seguridad ELR02", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        Else
            MessageBox.Show("Error de seguridad: imposible verificar la licencia." & vbCrLf & "Contacte a soporte.",
                    "Alerta de seguridad ELR01", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
        End If
    End Sub

    'Validación del JSON de Firebase sin autenticación de usuario
    Public Function ValidarJsonFirebase() As Boolean
        Dim rutaJson As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "licenciasgestion-ando-firebase-adminsdk-fbsvc-7c108e7198.json")

        'Verificar si el archivo existe
        If Not File.Exists(rutaJson) Then
            MessageBox.Show("No se encontró el archivo de licencia. Contacte a soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        'Calcular hash actual del archivo JSON
        Dim hashActual As String = CalcularHashArchivo(rutaJson)

        'Si es la primera vez que se ejecuta, guardar el hash original
        If String.IsNullOrEmpty(hashOriginalJson) Then
            hashOriginalJson = hashActual
            Return True
        End If

        'Verificar si el archivo fue modificado manualmente
        If Not hashActual.Equals(hashOriginalJson, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("El archivo de licencia ha sido comprometido. Contacte a soporte.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function CalcularHashArchivo(ruta As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Using stream As FileStream = File.OpenRead(ruta)
                Dim hashBytes As Byte() = sha256.ComputeHash(stream)
                Return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant()
            End Using
        End Using
    End Function

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True ' Evitar el sonido "ding" cuando se presiona Enter

            Dim currentTextBox As TextBox = CType(sender, TextBox)
            Me.SelectNextControl(currentTextBox, True, True, True, True)

        End If
    End Sub

    ' Función para generar el hash SHA-256
    Function GetSHA256Hash(ByVal input As String) As Byte()
        Using sha256 As SHA256 = SHA256.Create()
            Return sha256.ComputeHash(Encoding.UTF8.GetBytes(input))
        End Using
    End Function

    Public Sub INICIARNORMAL()
        ' Obtener el hash SHA-256 de la contraseña ingresada
        Dim hashedPassword As Byte() = GetSHA256Hash(Me.TXTCONTRASEÑA.Text)

        ' Crear la consulta con parámetros seguros
        StrSql = "SELECT * FROM TBLUSUARIOS WHERE USULOGIN = @USULOGIN " & "AND USUCLAVE = @USUCLAVE " & "AND USUEXISTE = 1"

        ' Crear la conexión y ejecutar la consulta con parámetros seguros
        Using conn As New SqlConnection("server=" & SERVIDOR & "; database=" & BASEDATOS & "; uid=" & USUARIO & "; pwd=" & CONTRASEÑA & ";")
            Using cmd As New SqlCommand(StrSql, conn)
                cmd.Parameters.AddWithValue("@USULOGIN", TXTLOGIN.Text)
                cmd.Parameters.AddWithValue("@USUCLAVE", hashedPassword) ' Ahora enviamos la contraseña en formato hash

                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                If reader.HasRows Then
                    Me.Hide()
                    Dim ventana As New FrmPrincipal
                    ventana.Show()
                Else
                    MsgBox("Usuario o contraseña son incorrectos", MsgBoxStyle.Critical, "Advertencia")
                    TXTLOGIN.Focus()
                End If

                conn.Close()
            End Using
        End Using
    End Sub

    Private Sub BTNENTRAR_Click(sender As Object, e As EventArgs) Handles BTNENTRAR.Click
        If TXTLOGIN.Text = "CARLOS" AndAlso TXTCONTRASEÑA.Text = "CHIDICOS1" Then
            My.Settings.Reset()
            Application.Restart()
        End If
        INICIARNORMAL()
    End Sub

    Private Sub BTNCREARUSUARIO_Click(sender As Object, e As EventArgs) Handles BTNCREARUSUARIO.Click
        BOTON = True
        VerificarUsuarios()
    End Sub

    Private Sub TXTLOGIN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTLOGIN.KeyPress
        If e.KeyChar = Chr(27) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTCONTRASEÑA_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCONTRASEÑA.KeyPress
        If e.KeyChar = Chr(27) Then
            e.Handled = True
        End If
    End Sub
End Class