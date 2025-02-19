Public Class FrmInventario
    Dim ALTA As New FrmAltaProductos
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLPRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
        Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)

    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click

        ALTA.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLPRODUCTOSBindingSource.Filter = "PRONOMBRE LIKE '*" & TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        If DATAINVENTARIO.RowCount > 0 Then
            idbusqueda = DATAINVENTARIO.CurrentRow.Cells("PROID").Value
            ALTA.TXTCLAVE.Text = DATAINVENTARIO.CurrentRow.Cells("PROCLAVE").Value
            ALTA.TXTNOMBRE.Text = DATAINVENTARIO.CurrentRow.Cells("PRONOMBRE").Value
            ALTA.SPINNER.Value = DATAINVENTARIO.CurrentRow.Cells("PROEXISTENCIAS").Value
            ALTA.TXTPRECIO.Text = DATAINVENTARIO.CurrentRow.Cells("PROPRECIO").Value

            If ALTA.ShowDialog = DialogResult.OK Then
                Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
                Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
            End If
        End If
    End Sub
End Class