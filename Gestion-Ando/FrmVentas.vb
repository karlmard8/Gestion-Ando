Public Class FrmVentas
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTAVENTAS' Puede moverla o quitarla según sea necesario.
        Me.VISTAVENTASTableAdapter.Connection = Conexion
        Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAVENTAS)
        Me.BackColor = ColorFormulario
        BTNNUEVO.BackColor = ColorBotones
        BTNELIMINAR.BackColor = ColorBotones
        BTNREPORTE.BackColor = ColorBotones
        DATAVENTAS.BackgroundColor = ColorFormulario
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.VISTAVENTASBindingSource.Filter = "USUNOMBRE LIKE '*" & Me.TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim CONFIRMACION = MsgBox("¿Eliminar venta?", MsgBoxStyle.YesNo, "Advertencia")
        If CONFIRMACION = DialogResult.Yes Then
            StrSql = "ELIMINARVENTA"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = Me.DATAVENTAS.CurrentRow.Cells("VENID").Value

            If Conectar() = True Then
                Me.VISTAVENTASTableAdapter.Connection = Conexion
                Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAVENTAS)
                MsgBox("Venta eliminada", MsgBoxStyle.Information, "Confirmación")
            End If
        End If
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        FrmAltaVentas.ShowDialog()
    End Sub
End Class