Public Class FrmClientes
    Dim NUEVO As New FrmAltaClientes
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLCLIENTES' Puede moverla o quitarla según sea necesario..
        Me.TBLCLIENTESTableAdapter.Connection = Conexion
        Me.TBLCLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.TBLCLIENTES)

    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click

        NUEVO.ShowDialog()
        NUEVO.LBLCLIENTES.Text = "Alta de clientes"
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLCLIENTESBindingSource.Filter = "CLINOMBRE LIKE '*" & TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        NUEVO.LBLCLIENTES.Text = "Editar perfil de cliente"
    End Sub
End Class