Public Class FrmInventario
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLPRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
        Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)

    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click

    End Sub
End Class