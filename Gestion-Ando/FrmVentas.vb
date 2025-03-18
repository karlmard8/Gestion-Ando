Public Class FrmVentas
    Private Sub FrmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet1.VISTAVENTAS' Puede moverla o quitarla según sea necesario.
        Me.VISTAVENTASTableAdapter.Connection = Conexion
        Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet1.VISTAVENTAS)
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTAVENTAS' Puede moverla o quitarla según sea necesario.
        Me.VISTAVENTASTableAdapter.Connection = Conexion
        Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAVENTAS)
        Me.BackColor = ColorFormulario
        BTNNUEVO.BackColor = ColorBotones
        BTNELIMINAR.BackColor = ColorBotones
        BTNREPORTE.BackColor = ColorBotones
        DATAVENTAS.BackgroundColor = ColorFormulario
        DETALLEVENTAS.Location = New Point(540, 187)
        DATAVENTAS.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAVENTAS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.VISTAVENTASBindingSource.Filter = "CLIENTE LIKE '*" & Me.TXTBUSCAR.Text & "*'"
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
                Me.VISTAVENTASBindingSource.DataSource = Me.MuebleAlexDataSet.VISTAVENTAS
                MsgBox("Venta eliminada", MsgBoxStyle.Information, "Confirmación")
            End If
        End If
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        If FrmAltaVentas.ShowDialog = DialogResult.OK Then
            Me.VISTAVENTASTableAdapter.Connection = Conexion
            Me.VISTAVENTASTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAVENTAS)
            Me.VISTAVENTASBindingSource.DataSource = Me.MuebleAlexDataSet.VISTAVENTAS
        End If
    End Sub
    Dim DETALLEVENTAS As New FrmDetallesVentas

    Private Sub DATAVENTAS_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DATAVENTAS.CellDoubleClick
        If idbusqueda >= 0 Then
            Try
                ' Verificar que haya una fila seleccionada
                If DATAVENTAS.CurrentRow Is Nothing Then
                    MessageBox.Show("No hay una fila seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Obtener el VENID y verificar que es válido
                Dim venId As Object = DATAVENTAS.CurrentRow.Cells("VENID").Value
                If venId Is Nothing OrElse Not IsNumeric(venId) Then
                    MessageBox.Show("Error: No se pudo obtener el VENID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                ' Limpiar el DataGridView antes de cargar los nuevos datos
                With DETALLEVENTAS.DATADETALLEVENTA
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear() ' Asegura que las columnas se restablezcan correctamente
                End With

                ' Abrir conexión
                Conexion.Open()

                ' Configurar comando para ejecutar el procedimiento almacenado
                StrSql = "VISTADETALLEVENTAS"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = Convert.ToInt64(venId)

                ' Usar adaptador para obtener datos
                Dim adaptador As New SqlClient.SqlDataAdapter(comando)
                Dim tabla As New DataTable()

                ' Llenar la tabla con los datos obtenidos
                adaptador.Fill(tabla)

                ' Verificar si la consulta devolvió datos
                If tabla.Rows.Count = 0 Then
                    MessageBox.Show("No se encontraron detalles de venta para VENID: " & venId, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

                ' Cerrar conexión
                Conexion.Close()

                ' Asignar los nuevos datos al DataGridView
                With DETALLEVENTAS.DATADETALLEVENTA
                    .AutoGenerateColumns = False
                    .DataSource = tabla

                    ' Restaurar configuraciones de tamaño de las columnas
                    .Columns.Add("Producto", "Producto")
                    .Columns("Producto").DataPropertyName = "Producto"
                    .Columns("Producto").Width = 546
                    .Columns("Producto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    .Columns.Add("Unidades", "Unidades")
                    .Columns("Unidades").DataPropertyName = "Unidades"
                    .Columns("Unidades").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .Columns("Unidades").DefaultCellStyle.Format = "N0"

                    .Columns.Add("PrecioUnitario", "Precio unitario")
                    .Columns("PrecioUnitario").DataPropertyName = "Precio unitario"
                    .Columns("PrecioUnitario").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .Columns("PrecioUnitario").DefaultCellStyle.Format = "C2"

                    .Columns.Add("Semanas", "Semanas")
                    .Columns("Semanas").DataPropertyName = "Semanas"
                    .Columns("Semanas").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    .Columns("Semanas").DefaultCellStyle.Format = "N0"

                    .Columns.Add("Enganche", "Enganche")
                    .Columns("Enganche").DataPropertyName = "Enganche"
                    .Columns("Enganche").Width = 80
                    .Columns("Enganche").DefaultCellStyle.Format = "C2"

                    .Columns.Add("Total", "Total")
                    .Columns("Total").DataPropertyName = "Total"
                    .Columns("Total").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    .Columns("Total").DefaultCellStyle.Format = "C2"
                End With

                ' Mostrar el formulario de detalles de ventas
                DETALLEVENTAS.ShowDialog()


                ' Limpiar el DataGridView al cerrar la ventana
                With DETALLEVENTAS.DATADETALLEVENTA
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                ' Asegurar que la conexión se cierra
                If Conexion.State = ConnectionState.Open Then Conexion.Close()
            End Try
        End If
    End Sub

End Class