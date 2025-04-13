Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SE DECLARAN LAS CREDENCIALES PARA LA BASE DE DATOS
        SERVIDOR = "desktop-8q10a8h\sqlexpress"
        BASEDATOS = "MuebleAlex"
        USUARIO = "sa"
        CONTRASEÑA = "c1oooooo"

        Me.BackColor = ColorFormulario
        Me.BTNENTRAR.BackColor = ColorBotones
        Call inicio()

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.KeyDown, AddressOf TextBox_KeyDown
            End If
        Next

    End Sub

    Private Sub FrmLogin_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        'Validamos la licencia solo después de que el formulario esté completamente visible
        If BLOQUEO = False Then
            btnlogin.Visible = False
            btnLogin_Click(sender, e)
        Else
            btnlogin.Visible = False
            ValidarLicenciaLocal()
        End If
    End Sub

    Public fechaVencimiento As DateTime
    Dim estado As String
    'LICENCIA EN FIREBASE
    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If BLOQUEO = False Then

        Else
            Exit Sub
        End If
        Dim email As String = "karlsant888@gmail.com"
        Dim password As String = "c1oooooo"

        If Await IniciarSesion(email, password) Then
            Dim validador As New FirestoreConexion()
            Dim Calve As Integer = 123 ' 🔥 Ahora buscamos por número
            Dim snapshot = Await validador.ObtenerDocumento(Calve)

            If snapshot IsNot Nothing AndAlso snapshot.ContainsKey("Estado") AndAlso snapshot.ContainsKey("FechaVencimiento") Then
                estado = snapshot("Estado").ToString()

                ' 🔹 Convertir timestamp de Firestore a DateTime
                Dim fechaVencimientoTimestamp As Google.Cloud.Firestore.Timestamp = snapshot("FechaVencimiento")
                Dim fechaVencimiento As DateTime = fechaVencimientoTimestamp.ToDateTime()

                If estado.Trim() = "Activa" And fechaVencimiento >= DateTime.Now Then
                    'MessageBox.Show("Licencia válida. La aplicación continuará.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Licencia inválida. Estado: " & estado & " - Fecha vencida: " & fechaVencimiento, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                End If
            Else
                MessageBox.Show("Error: No se encontró el campo 'Estado' o 'FechaVencimiento' en Firestore.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        End If
    End Sub


    'LICENCIA LOCAL
    Public archivo As FileInfo
    Dim codigoUNICO As String
    Public Sub ValidarLicenciaLocal()
        Dim rutaArchivo As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LICENCIA.txt")
        archivo = New FileInfo(rutaArchivo)

        archivo.IsReadOnly = False   'HABILITAR EL MODO LECTURA DEL ARCHIVO DE LICENCIA

        ' 🔹 Verificar si el archivo existe
        If Not archivo.Exists Then
            MessageBox.Show("No se encontró el archivo de licencia. Se requiere validación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BLOQUEO = True ' 🔥 Bloquear la aplicación si no hay archivo
            Exit Sub
        End If

        ' 🔹 Leer el contenido del archivo
        Dim lineas As String() = System.IO.File.ReadAllLines(rutaArchivo)
        Dim datosLicencia As New Dictionary(Of String, String)

        For Each linea As String In lineas
            Dim partes As String() = linea.Split("="c)
            If partes.Length = 2 Then
                datosLicencia(partes(0).Trim()) = partes(1).Trim()
            End If
        Next

        ' 🔹 Validar datos de la licencia
        If datosLicencia.ContainsKey("Estado") AndAlso datosLicencia.ContainsKey("FechaVencimiento") AndAlso datosLicencia.ContainsKey("CodigoUnico") Then
            estado = datosLicencia("Estado").Trim()
            fechaVencimiento = DateTime.Parse(datosLicencia("FechaVencimiento").Trim())
            codigoUNICO = datosLicencia("CodigoUnico").Trim()

            Dim diasRestantes As Integer = (fechaVencimiento - DateTime.Now).Days

            If estado = "Activa" And fechaVencimiento >= DateTime.Now And codigoUNICO = "123" Then
                ' 🔹 Solo mostrar alerta si faltan 3 días o menos
                If diasRestantes <= 3 Then

                    If diasRestantes = 0 Then
                        MessageBox.Show("Atención: La licencia vence hoy", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Atención: La licencia vencerá en " & diasRestantes & " día(s).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
                BLOQUEO = False ' 🔥 No bloquear la app porque la licencia sigue válida
            Else
                MessageBox.Show("Licencia inválida, ingrese usuario maestro o contacte a soporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXTLOGIN.PasswordChar = "*"
            End If
        Else
            MessageBox.Show("Error: No se encontraron datos válidos en el archivo de licencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BLOQUEO = True ' 🔥 Bloquear la app si el archivo no tiene la estructura correcta
        End If
    End Sub

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

    Public Sub UsuarioMaestro()
        If BLOQUEO = True Then
            If TXTLOGIN.Text = "CARLOS" And TXTCONTRASEÑA.Text = "CHIDICOS1" Then
                archivo.IsReadOnly = False
                MessageBox.Show("Acceso concedido como usuario maestro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Application.Exit()
            Else
                MsgBox("Usuario maestro inválido", MsgBoxStyle.Critical, "Error")
                TXTCONTRASEÑA.Text = String.Empty
                TXTLOGIN.Text = String.Empty
                TXTLOGIN.Focus()
            End If
        End If
    End Sub

    Public Sub INICIARNORMAL()
        ' Obtener el hash SHA-256 de la contraseña ingresada
        Dim hashedPassword As Byte() = GetSHA256Hash(Me.TXTCONTRASEÑA.Text)

        ' Crear la consulta con parámetros seguros
        Dim sql As String = "SELECT * FROM TBLUSUARIOS WHERE USULOGIN = @USULOGIN " &
                        "AND USUCLAVE = @USUCLAVE " &
                        "AND USUEXISTE = 1"

        ' Crear la conexión y ejecutar la consulta con parámetros seguros
        Using conn As New SqlConnection("server=" & SERVIDOR & "; database=" & BASEDATOS & "; uid=" & USUARIO & "; pwd=" & CONTRASEÑA & ";")
            Using cmd As New SqlCommand(sql, conn)
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
        If BLOQUEO = True Then
            UsuarioMaestro()
        Else
            INICIARNORMAL()
        End If

    End Sub
End Class