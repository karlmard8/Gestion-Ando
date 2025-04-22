Imports System.Data.SqlClient
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text


Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SE DECLARAN LAS CREDENCIALES PARA LA BASE DE DATOS
        SERVIDOR = "192.168.1.67"
        BASEDATOS = "MuebleAlex"
        USUARIO = "sa"
        CONTRASEÑA = "c1oooooo"

        Me.BackColor = ColorFormulario
        Me.BTNENTRAR.BackColor = ColorBotones
        Me.BTNCREARUSUARIO.BackColor = ColorBotones
        Call inicio()

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
        Else
            btnlogin.Visible = False
            ValidarLicenciaLocal()
        End If
    End Sub


    Public fechaVencimiento As DateTime
    Dim estado As String
    Private Const NOMBRE_JSON_FIREBASE As String = "licenciasgestion-ando-firebase-adminsdk-fbsvc-7c108e7198.json"
    Private hashOriginalJson As String = ""

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
            Dim Calve As Integer = 123
            Dim snapshot = Await validador.ObtenerDocumento(Calve)

            If snapshot IsNot Nothing AndAlso snapshot.ContainsKey("Estado") AndAlso snapshot.ContainsKey("FechaVencimiento") Then
                estado = snapshot("Estado").ToString()

                ' 🔹 Convertir timestamp de Firestore a DateTime
                Dim fechaVencimientoTimestamp As Google.Cloud.Firestore.Timestamp = snapshot("FechaVencimiento")
                Dim fechaVencimiento As DateTime = fechaVencimientoTimestamp.ToDateTime()

                If estado.Trim() = "Activa" And fechaVencimiento >= DateTime.Now Then
                    'MessageBox.Show("Licencia válida. La aplicación continuará.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Error de seguridad: hay problemas para verificar la licencia." &
                                    vbCrLf & "Contacte a soporte.", "Alerta de seguridad ELR02", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Application.Exit()
                End If
            Else
                MessageBox.Show("Error de seguridad: imposible verificar la licencia." &
                                vbCrLf & "Contacte a soporte", "Alerta de seguridad ELR01", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Application.Exit()
            End If
        End If
    End Sub

    Public Function ValidarJsonFirebase() As Boolean
        Dim rutaJson As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, NOMBRE_JSON_FIREBASE)

        ' 1. Verificar si el archivo existe
        If Not File.Exists(rutaJson) Then
            MessageBox.Show("No se encontró el archivo JSON de Firebase.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        ' 2. Calcular hash actual del archivo JSON
        Dim hashActual As String = CalcularHashArchivo(rutaJson)

        ' 3. Si es la primera vez que se ejecuta, guardar el hash original
        If String.IsNullOrEmpty(hashOriginalJson) Then
            hashOriginalJson = hashActual
            Return True
        End If

        ' 4. Verificar si el archivo fue modificado manualmente
        If Not hashActual.Equals(hashOriginalJson, StringComparison.OrdinalIgnoreCase) Then
            MessageBox.Show("El archivo JSON de Firebase fue modificado manualmente. Se requiere autenticación del usuario maestro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function



    'LICENCIA LOCAL
    Public archivo As FileInfo
    Dim codigoUNICO As String
    Public Sub ValidarLicenciaLocal()
        Dim rutaArchivo As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LICENCIA.txt")
        Dim rutaHash As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LICENCIA.hash")
        archivo = New FileInfo(rutaArchivo)

        ' 🔒 Validaciones iniciales
        If Not File.Exists(rutaArchivo) Then
            MessageBox.Show("Error de seguridad: no se pudo rerificar la licencia, contacte a soporte", "Alerta de integridad ELL03", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BLOQUEO = True
            Application.Exit()
            Exit Sub
        End If

        If Not File.Exists(rutaHash) Then
            MessageBox.Show("Error de seguridad: la licencia ha sido comprometida, contacte a soporte", "Alerta de integridad ELL01", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BLOQUEO = True
            TXTLOGIN.PasswordChar = "*"
            Exit Sub
        End If

        ' 🔐 Validar integridad del archivo
        Dim hashGuardado As String = File.ReadAllText(rutaHash).Trim()
        Dim hashActual As String = CalcularHashArchivo(rutaArchivo).Trim()

        If Not hashGuardado.Equals(hashActual) Then
            MessageBox.Show("Error de seguridad: la licencia ha sido comprometida, contacte a soporte", "Alerta de integridad ELL02", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BLOQUEO = True
            TXTLOGIN.PasswordChar = "*"
            Exit Sub
        End If

        ' 🔒 Ocultar y proteger el archivo (una vez validado)
        archivo.Attributes = archivo.Attributes Or FileAttributes.Hidden
        archivo.IsReadOnly = True

        ' 🔍 Leer contenido del archivo
        Dim lineas As String() = File.ReadAllLines(rutaArchivo)
        Dim datosLicencia As New Dictionary(Of String, String)

        For Each linea As String In lineas
            Dim partes As String() = linea.Split("="c)
            If partes.Length = 2 Then
                datosLicencia(partes(0).Trim()) = partes(1).Trim()
            End If
        Next

        If datosLicencia.ContainsKey("FechaVencimiento") Then
            Dim fechaTexto As String = datosLicencia("FechaVencimiento").Trim()

            If String.IsNullOrEmpty(fechaTexto) Then
                MessageBox.Show("Ingresa usuario maestro para activar una licencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TXTLOGIN.PasswordChar = "*"
                BLOQUEO = True
                Exit Sub
            End If

            Try
                fechaVencimiento = DateTime.Parse(fechaTexto)
            Catch ex As Exception
                MessageBox.Show("Error: La fecha de la licencia tiene un formato incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                BLOQUEO = True
                Exit Sub
            End Try

            Dim diasRestantes As Integer = (fechaVencimiento - DateTime.Now).Days

            If fechaVencimiento >= DateTime.Now Then
                If diasRestantes <= 5 Then
                    If diasRestantes = 0 Then
                        MessageBox.Show("Atención: La licencia vence hoy.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Else
                        MessageBox.Show("Atención: La licencia vencerá en " & diasRestantes & " día(s).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End If
                BLOQUEO = False
            Else
                MessageBox.Show("Licencia vencida, ingrese usuario maestro o contacte a soporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TXTLOGIN.PasswordChar = "*"
                BLOQUEO = True
            End If
        Else
            MessageBox.Show("Error: No se encontraron datos válidos en el archivo de licencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BLOQUEO = True
        End If
    End Sub

    Public Sub ACTUALIZARLICENCIA()
        Dim NUEVAFECHAS As New Form()
        NUEVAFECHAS.Text = "Actualizar licencia"
        NUEVAFECHAS.Size = New Size(300, 200)
        NUEVAFECHAS.StartPosition = FormStartPosition.CenterScreen
        NUEVAFECHAS.FormBorderStyle = FormBorderStyle.FixedSingle
        NUEVAFECHAS.MaximizeBox = False
        NUEVAFECHAS.MinimizeBox = False
        NUEVAFECHAS.ShowIcon = False
        NUEVAFECHAS.ShowInTaskbar = False
        NUEVAFECHAS.BackColor = ColorFormulario

        Dim FECHA As DateTimePicker = New DateTimePicker()
        FECHA.Location = New Point(30, 30)
        FECHA.Font = New Font("Dubai", 14, FontStyle.Regular)
        FECHA.Width = 200
        FECHA.Format = DateTimePickerFormat.Short
        FECHA.MaxDate = DateTime.Now.AddYears(1) ' Establecer la fecha máxima a un año a partir de ahora
        FECHA.MinDate = DateTime.Now ' Establecer la fecha mínima a la fecha actual

        Dim CONFIRMAR As New Button()
        CONFIRMAR.Text = "Guardar"
        CONFIRMAR.Location = New Point(100, 100)
        CONFIRMAR.BackColor = ColorBotones
        CONFIRMAR.Font = New Font("Dubai", 14, FontStyle.Regular)
        CONFIRMAR.AutoSize = True
        CONFIRMAR.Cursor = Cursors.Hand

        AddHandler CONFIRMAR.Click, Sub(sender2, e2)
                                        Dim fechaSeleccionada As String = FECHA.Value.ToString("dd/MM/yyyy")
                                        Dim resultado As DialogResult = MessageBox.Show("¿Actualizar licencia al: " & fechaSeleccionada & "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                        If resultado = DialogResult.Yes Then
                                            'DESBLOQUEA Y MUESTRA EL ARCHIVO
                                            archivo.IsReadOnly = False
                                            archivo.Attributes = archivo.Attributes And Not FileAttributes.Hidden

                                            Dim atributo As String = "FechaVencimiento="
                                            ModificarLicencia(atributo + fechaSeleccionada + " 23:59:59")
                                            archivo.IsReadOnly = True

                                            'BLOQUEA Y OCULTA EL ARCHIVO
                                            archivo.Attributes = archivo.Attributes Or FileAttributes.Hidden
                                            archivo.IsReadOnly = True
                                            Application.Exit()
                                        End If
                                    End Sub

        NUEVAFECHAS.Controls.Add(FECHA)
        NUEVAFECHAS.Controls.Add(CONFIRMAR)
        NUEVAFECHAS.ShowDialog()
    End Sub

    Public Sub ModificarLicencia(fechaNueva As String)
        Dim rutaArchivo As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LICENCIA.txt")
        Dim rutaHash As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LICENCIA.hash")

        ' 🧼 QUITAR ATRIBUTOS DE PROTECCIÓN TEMPORALMENTE
        If File.Exists(rutaArchivo) Then
            File.SetAttributes(rutaArchivo, FileAttributes.Normal)
        End If

        If File.Exists(rutaHash) Then
            File.SetAttributes(rutaHash, FileAttributes.Normal)
        End If

        ' 📝 MODIFICAR LICENCIA
        Try
            File.WriteAllText(rutaArchivo, fechaNueva)

            ' 🔐 Calcular nuevo hash y escribirlo
            Dim nuevoHash = CalcularHashArchivo(rutaArchivo)
            File.WriteAllText(rutaHash, nuevoHash)

            ' 🔙 VOLVER A PROTEGER LOS ARCHIVOS
            File.SetAttributes(rutaArchivo, FileAttributes.Hidden Or FileAttributes.ReadOnly)
            File.SetAttributes(rutaHash, FileAttributes.Hidden Or FileAttributes.ReadOnly)

            MessageBox.Show("Licencia actualizada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al actualizar la licencia: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Function CalcularHashArchivo(ruta As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Using stream As FileStream = File.OpenRead(ruta)
                Dim hashBytes As Byte() = sha256.ComputeHash(stream)
                Return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant()
            End Using
        End Using
    End Function


    Private Function VerificarIntegridadLicencia() As Boolean
        Dim rutaHash As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LICENCIA.hash")
        Dim rutaLicencia As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LICENCIA.txt")

        If Not File.Exists(rutaHash) Then
            ' Primera ejecución: se genera hash y se guarda
            Dim hashActual = CalcularHashArchivo(rutaLicencia)
            File.WriteAllText(rutaHash, hashActual)
            File.SetAttributes(rutaHash, FileAttributes.Hidden)
            Return True
        Else
            Dim hashGuardado = File.ReadAllText(rutaHash).Trim()
            Dim hashActual = CalcularHashArchivo(rutaLicencia).Trim()

            Return hashGuardado = hashActual
        End If
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

    Public Sub UsuarioMaestro()
        If BLOQUEO = True Then
            If TXTLOGIN.Text = "CARLOS" And TXTCONTRASEÑA.Text = "CHIDICOS1" Then
                archivo.IsReadOnly = False
                'MessageBox.Show("Acceso concedido como usuario maestro.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Application.Exit()
                ACTUALIZARLICENCIA()
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
        Dim sql As String = "SELECT * FROM TBLUSUARIOS WHERE USULOGIN = @USULOGIN " & "AND USUCLAVE = @USUCLAVE " & "AND USUEXISTE = 1"

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

    Private Sub BTNCREARUSUARIO_Click(sender As Object, e As EventArgs) Handles BTNCREARUSUARIO.Click
        BOTON = True
        VerificarUsuarios()
    End Sub
End Class