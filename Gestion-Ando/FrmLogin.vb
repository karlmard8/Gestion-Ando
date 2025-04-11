Imports System.Data.SqlClient
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

    Private Sub BTNENTRAR_Click(sender As Object, e As EventArgs) Handles BTNENTRAR.Click
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
End Class