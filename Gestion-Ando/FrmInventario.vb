Public Class FrmInventario
    Dim ALTAINVENTARIO As New FrmAltaProductos
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLPRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
        Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)

    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        ALTAINVENTARIO.LBLPRODUCTOS.Text = "Alta de producto"

        For Each control As Control In ALTAINVENTARIO.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is NumericUpDown Then
                DirectCast(control, NumericUpDown).Value = 0
            End If
        Next
        idbusqueda = 0
        If ALTAINVENTARIO.ShowDialog = DialogResult.OK Then
            Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
            Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
        End If
        ALTAINVENTARIO.TXTPRECIO.Text = 0


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLPRODUCTOSBindingSource.Filter = "PRONOMBRE LIKE '*" & TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        ALTAINVENTARIO.LBLPRODUCTOS.Text = "Editar inforación de producto"

        If DATAINVENTARIO.RowCount > 0 Then
            idbusqueda = DATAINVENTARIO.CurrentRow.Cells("PROID").Value
            ALTAINVENTARIO.TXTCLAVE.Text = DATAINVENTARIO.CurrentRow.Cells("PROCLAVE").Value
            ALTAINVENTARIO.TXTNOMBRE.Text = DATAINVENTARIO.CurrentRow.Cells("PRONOMBRE").Value
            ALTAINVENTARIO.SPINNER.Value = DATAINVENTARIO.CurrentRow.Cells("PROEXISTENCIAS").Value
            ALTAINVENTARIO.TXTPRECIO.Text = DATAINVENTARIO.CurrentRow.Cells("PROPRECIO").Value

            If ALTAINVENTARIO.ShowDialog = DialogResult.OK Then
                Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
                Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
            End If
        End If

    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim CONFIRMAR = MsgBox("¿Eliminar producto?", MsgBoxStyle.YesNo, "Confirmación")
        If CONFIRMAR = MsgBoxResult.Yes Then
            StrSql = "ELIMINARPRODUCTOS"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@PROID", SqlDbType.BigInt).Value = Me.DATAINVENTARIO.CurrentRow.Cells("PROID").Value

            If Conectar() = True Then
                Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
                Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
                MsgBox("Producto eliminado", MsgBoxStyle.Information, "Conformación")
            End If
        End If

    End Sub
End Class