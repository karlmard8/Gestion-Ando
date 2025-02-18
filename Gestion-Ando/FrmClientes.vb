Public Class FrmClientes
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLCLIENTES' Puede moverla o quitarla según sea necesario..
        Me.TBLCLIENTESTableAdapter.Connection = Conexion
        Me.TBLCLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.TBLCLIENTES)

    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        Dim NUEVO As New FrmAltaClientes
        NUEVO.ShowDialog()
    End Sub
End Class