Public Class FrmDetallesVentas
    Private Sub FrmDetallesVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        DATADETALLEVENTA.BackgroundColor = ColorFormulario
        DATADETALLEVENTA.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATADETALLEVENTA.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
    End Sub
End Class