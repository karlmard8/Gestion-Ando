Module MetodoDatagridview
    Public Function ObtenerValorCelda(row As DataGridViewRow, nombreColumna As String) As String
        Try
            Dim valor = row.Cells(nombreColumna).Value
            If valor IsNot Nothing AndAlso Not IsDBNull(valor) Then
                Return valor.ToString().Trim()
            End If
        Catch ex As Exception
            ' Opcional: puedes loguear o manejar el error si quieres rastrear columnas faltantes
        End Try
        Return String.Empty
    End Function
End Module
