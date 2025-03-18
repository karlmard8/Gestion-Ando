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

                ' ===================== LIMPIAR DATA GRID VIEWS =====================
                With DETALLEVENTAS.DATADETALLEVENTA
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

                With DETALLEVENTAS.DATAPAGOS
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

                ' ===================== CARGAR DETALLE DE VENTAS =====================
                Conexion.Open()
                StrSql = "VISTADETALLEVENTAS"
                Dim comandoVentas As New SqlClient.SqlCommand(StrSql, Conexion)
                comandoVentas.CommandType = CommandType.StoredProcedure
                comandoVentas.Parameters.Add("@VENID", SqlDbType.BigInt).Value = Convert.ToInt64(venId)

                Dim adaptadorVentas As New SqlClient.SqlDataAdapter(comandoVentas)
                Dim tablaVentas As New DataTable()
                adaptadorVentas.Fill(tablaVentas)
                Conexion.Close()

                ' Configurar y asignar datos al DataGridView de ventas
                With DETALLEVENTAS.DATADETALLEVENTA
                    .AutoGenerateColumns = False
                    .DataSource = tablaVentas

                    .Columns.Add("Producto", "Producto")
                    .Columns("Producto").DataPropertyName = "Producto"
                    .Columns("Producto").Width = 546
                    .Columns("Producto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    .Columns.Add("Unidades", "Unidades")
                    .Columns("Unidades").DataPropertyName = "Unidades"
                    .Columns("Unidades").DefaultCellStyle.Format = "N0"

                    .Columns.Add("PrecioUnitario", "Precio unitario")
                    .Columns("PrecioUnitario").DataPropertyName = "Precio unitario"
                    .Columns("PrecioUnitario").DefaultCellStyle.Format = "C2"
                    .Columns("PrecioUnitario").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

                    .Columns.Add("Total", "Total")
                    .Columns("Total").DataPropertyName = "Total"
                    .Columns("Total").DefaultCellStyle.Format = "C2"
                End With

                ' ===================== CARGAR DETALLE DE PAGOS =====================
                Conexion.Open()
                StrSql = "DETALLESDEPAGOS"
                Dim comandoPagos As New SqlClient.SqlCommand(StrSql, Conexion)
                comandoPagos.CommandType = CommandType.StoredProcedure
                comandoPagos.Parameters.Add("@VENID", SqlDbType.BigInt).Value = Convert.ToInt64(venId)

                Dim adaptadorPagos As New SqlClient.SqlDataAdapter(comandoPagos)
                Dim tablaPagos As New DataTable()
                adaptadorPagos.Fill(tablaPagos)
                Conexion.Close()

                ' Configurar y asignar datos al DataGridView de pagos
                With DETALLEVENTAS.DATAPAGOS
                    .AutoGenerateColumns = False
                    .DataSource = tablaPagos

                    .Columns.Add("Fecha", "Fecha de Pago")
                    .Columns("Fecha").DataPropertyName = "Fecha"
                    .Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

                    .Columns.Add("Cliente", "Cliente")
                    .Columns("Cliente").DataPropertyName = "Cliente"
                    .Columns("Cliente").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

                    .Columns.Add("APagar", "A pagar")
                    .Columns("APagar").DataPropertyName = "APagar"
                    .Columns("APagar").DefaultCellStyle.Format = "C2"
                    .Columns("APagar").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader

                    .Columns.Add("Pagado", "Pagado")
                    .Columns("Pagado").DataPropertyName = "Pagado"
                    .Columns("Pagado").DefaultCellStyle.Format = "C2"
                    .Columns("Pagado").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                End With

                ' Mostrar el formulario de detalles de ventas
                DETALLEVENTAS.ShowDialog()

                ' ===================== LIMPIAR DATA GRID VIEWS AL CERRAR =====================
                With DETALLEVENTAS.DATADETALLEVENTA
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

                With DETALLEVENTAS.DATAPAGOS
                    .DataSource = Nothing
                    .Rows.Clear()
                    .Columns.Clear()
                End With

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Conexion.State = ConnectionState.Open Then Conexion.Close()
            End Try
        End If
    End Sub
End Class