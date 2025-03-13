Public Class FrmAltaVentas
    Private Sub FrmAltaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLCLIENTES' Puede moverla o quitarla según sea necesario.
        Me.TBLCLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.TBLCLIENTES)
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTAVENTAS' Puede moverla o quitarla según sea necesario.
        Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAVENTAS)
        Me.BackColor = ColorFormulario
        BtnAgregar.BackColor = ColorBotones
        BtnQuitar.BackColor = ColorBotones
        BTNPAGAR.BackColor = ColorBotones
        LBLUSUARIOACTUAL.Text = USUARIOACTUAL
    End Sub
End Class