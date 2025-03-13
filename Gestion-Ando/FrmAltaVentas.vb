Public Class FrmAltaVentas
    Private Sub FrmAltaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONEXION PARA VISTAPRODUCTOS
        Me.VISTAPRODUCTOSTableAdapter.Connection = Conexion
        Me.VISTAPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAPRODUCTOS)
        'CONEXION PARA VISTACLIENTES
        Me.VISTACLIENTESTableAdapter.Connection = Conexion
        Me.VISTACLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.VISTACLIENTES)

        Me.BackColor = ColorFormulario
        BtnAgregar.BackColor = ColorBotones
        BtnQuitar.BackColor = ColorBotones
        BTNPAGAR.BackColor = ColorBotones
        LBLUSUARIOACTUAL.Text = USUARIOACTUAL
        CmbClientes.SelectedValue = 0
        CmbClave.SelectedValue = 0
        CMBPRODUCTO.SelectedValue = 0
        CMBPRECIO.SelectedValue = 0
        TXTMESES.Enabled = False
        TXTPAGO.Enabled = False

    End Sub
End Class