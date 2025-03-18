Public Class FrmDetallesVentas
    Private Sub FrmDetallesVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        DATADETALLEVENTA.BackgroundColor = ColorFormulario
        DATADETALLEVENTA.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATADETALLEVENTA.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)

        DATAPAGOS.BackgroundColor = ColorFormulario
        DATAPAGOS.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAPAGOS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)

        Me.BTNABONO.BackColor = ColorBotones
    End Sub

    Private Sub BTNABONO_Click(sender As Object, e As EventArgs) Handles BTNABONO.Click
        If idbusqueda = 0 Then
            StrSql = "PAGOCREDITO"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = DATAPAGOS.CurrentRow.Cells("VENID").Value
            comando.Parameters.Add("@PAGID", SqlDbType.BigInt).Value = DATAPAGOS.CurrentRow.Cells("PAGID").Value
            comando.Parameters.Add("@RETORNO", SqlDbType.Bit).Direction = ParameterDirection.Output

            If Conectar() = True Then
                If comando.Parameters("@RETORNO").Value = 1 Then
                    MsgBox("Pago realizado", MsgBoxStyle.Information, "Confirmación")
                    DialogResult = DialogResult.OK

                End If
            End If
        End If
    End Sub
End Class