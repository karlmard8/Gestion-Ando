Public Class FrmUsuarios
    Dim ALTAUSUARIO As New FrmAltaUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLUSUARIOS' Puede moverla o quitarla según sea necesario.
        Me.TBLUSUARIOSTableAdapter.Connection = Conexion
        Me.TBLUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLUSUARIOS)

    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLUSUARIOSBindingSource.Filter = "USUNOMBRE LIKE '*" & Me.TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        idbusqueda = 0

        If ALTAUSUARIO.ShowDialog() = DialogResult.OK Then
            Me.TBLUSUARIOSTableAdapter.Connection = Conexion
            Me.TBLUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLUSUARIOS)
        End If
    End Sub
End Class