Public Class FrmVentas
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        BTNNUEVO.BackColor = ColorBotones
        BTNEDITAR.BackColor = ColorBotones
        BTNELIMINAR.BackColor = ColorBotones
        BTNREPORTE.BackColor = ColorBotones
        DATAVENTAS.BackgroundColor = ColorFormulario
    End Sub
End Class