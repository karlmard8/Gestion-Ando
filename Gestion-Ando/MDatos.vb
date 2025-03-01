Module MDatos

    Public Conexion As SqlClient.SqlConnection
    Public comando As SqlClient.SqlCommand
    Public StrSql As String
    Public dts As New DataSet
    Public idbusqueda As Long
    Public TIPO As String


    Public Function Conectar() As Boolean
        Dim ret As Boolean
        Try
            'comando = New SqlClient.SqlCommand(StrSql, Conexion)
            'comando.CommandType = CommandType.StoredProcedure
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
        Conexion = New SqlClient.SqlConnection("server=desktop-8q10a8h\sqlexpress; database=MuebleAlex; uid=sa; pwd=c1oooooo;")
        'Primer servidor: LAPTOP-MI2EEO5C\SQLEXPRESS
        'Segundo servidor: desktop-8q10a8h\sqlexpress
    End Sub

End Module
