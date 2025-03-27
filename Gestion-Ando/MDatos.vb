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


    Public Sub inicio()
        Conexion = New SqlClient.SqlConnection("server=192.168.1.68; database=MuebleAlex; uid=sa; pwd=c1oooooo;")
        'SERVIDOR LOCAL desktop-8q10a8h\sqlexpress
        'SERVIDOR PUBLICO 192.168.1.68
    End Sub

End Module
