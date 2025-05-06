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

    'VARIABLE PARA ESTABLECER PRODUCTO EN CLASE O PRODUCTO EN VENTA
    Public TIPOPRODUCTO As String = "VENTA"


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
        'SERVIDOR PUBLICO 192.168.1.67
    End Sub

    Public Class EstiloBotones
        Public Shared Sub CambiarColorBotones(ByVal formulario As Form)
            For Each ctrl As Control In formulario.Controls
                If TypeOf ctrl Is Button Then
                    Dim btn As Button = CType(ctrl, Button)
                    btn.BackColor = ColorBotones ' 🔥 Usa el color global definido en otro módulo
                    btn.ForeColor = Color.Black
                End If
            Next
        End Sub
    End Class

End Module