Public Class FrmCotizaciones
    Private Sub FrmCotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTAPRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.VISTAPRODUCTOSTableAdapter.Connection = Conexion
        Me.VISTAPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAPRODUCTOS)
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTACLIENTES' Puede moverla o quitarla según sea necesario.
        Me.VISTACLIENTESTableAdapter.Connection = Conexion
        Me.VISTACLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.VISTACLIENTES)

        EstiloBotones.CambiarColorBotones(Me)
        DATACOTIZACIONES.BackgroundColor = ColorFormulario
        Me.BackColor = ColorFormulario
        CMBCLIENTE.Focus()
        CMBCLIENTE.SelectedIndex = -1
        CMBPRODUCTO.SelectedIndex = -1
        TXTCANTIDAD.Text = 0
        TXTCANTIDAD.TextAlign = HorizontalAlignment.Center

        DATACOTIZACIONES.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATACOTIZACIONES.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
    End Sub

    Private Sub BTNSUM_Click(sender As Object, e As EventArgs) Handles BTNSUM.Click
        TXTCANTIDAD.Text = Val(TXTCANTIDAD.Text) + 1
    End Sub

    Private Sub BTNRES_Click(sender As Object, e As EventArgs) Handles BTNRES.Click
        If TXTCANTIDAD.Text >= 1 Then
            TXTCANTIDAD.Text = Val(TXTCANTIDAD.Text) - 1
        End If

    End Sub

    Private Sub TXTCANTIDAD_TextChanged(sender As Object, e As EventArgs) Handles TXTCANTIDAD.TextChanged

    End Sub

    Private Sub TXTCANTIDAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCANTIDAD.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            'Si no es un número ni una tecla de control, cancela el evento KeyPress
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            'Si no es un número ni una tecla de control, cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub BTNAGREGAR_Click(sender As Object, e As EventArgs) Handles BTNAGREGAR.Click
        If CMBPRODUCTO.SelectedIndex = -1 Then
            CMBPRODUCTO.Focus()
            Return
        End If

        Dim PROID As Integer = Convert.ToInt32(CMBPRODUCTO.SelectedValue)
        Dim cantidad As Integer = Val(Me.TXTCANTIDAD.Text)
        Dim descuento As Double = 0

        'Consultar datos desde la vista en la base de datos
        Dim query As String = "SELECT * FROM VISTAPRODUCTOS WHERE PROID = @PROID"
        Dim comando As New SqlClient.SqlCommand(query, Conexion)
        comando.Parameters.AddWithValue("@PROID", PROID)

        Dim adaptador As New SqlClient.SqlDataAdapter(comando)
        Dim tablaNueva As New DataTable()
        adaptador.Fill(tablaNueva)

        'Verificar si el DataGridView ya tiene datos
        Dim tablaExistente As DataTable

        If DATACOTIZACIONES.DataSource IsNot Nothing Then
            tablaExistente = CType(DATACOTIZACIONES.DataSource, DataTable)
        Else
            tablaExistente = tablaNueva.Clone() 'Copiar estructura de la tabla
        End If

        'Agregar columnas si no existen en `tablaExistente`
        If Not tablaExistente.Columns.Contains("Cantidad") Then
            tablaExistente.Columns.Add("Cantidad", GetType(Integer))
        End If
        If Not tablaExistente.Columns.Contains("Descuento") Then
            tablaExistente.Columns.Add("Descuento", GetType(Double))
        End If
        If Not tablaExistente.Columns.Contains("PROSUBTOTAL") Then
            tablaExistente.Columns.Add("PROSUBTOTAL", GetType(Double))
        End If

        'Verificar si el producto ya existe en el `DataGridView`
        Dim productoExistente As DataRow = tablaExistente.Select("PROID = " & PROID).FirstOrDefault()

        If productoExistente IsNot Nothing Then
            'Si el producto ya existe, actualizar cantidad, descuento y subtotal
            productoExistente("Cantidad") = Convert.ToInt32(productoExistente("Cantidad")) + cantidad
            productoExistente("Descuento") = descuento 'Se actualiza el descuento
            productoExistente("PROSUBTOTAL") = (Convert.ToDouble(productoExistente("Cantidad")) * Convert.ToDouble(productoExistente("PROPRECIO"))) - descuento
        Else
            'Si no existe, agregarlo como nueva fila con cantidad y descuento
            Dim nuevaFila As DataRow = tablaExistente.NewRow()
            nuevaFila("PROID") = PROID
            nuevaFila("Cantidad") = cantidad
            nuevaFila("Descuento") = descuento
            nuevaFila("PROSUBTOTAL") = (cantidad * Convert.ToDouble(tablaNueva.Rows(0)("PROPRECIO"))) - descuento

            'Importar los datos de la vista en la nueva fila
            For Each columna As DataColumn In tablaNueva.Columns
                If Not nuevaFila.Table.Columns.Contains(columna.ColumnName) Then Continue For
                nuevaFila(columna.ColumnName) = tablaNueva.Rows(0)(columna.ColumnName)
            Next

            tablaExistente.Rows.Add(nuevaFila)
        End If

        'Actualizar el `DataGridView` sin sobrescribir registros anteriores
        DATACOTIZACIONES.DataSource = tablaExistente
        ConfigurarEdicionDataGridView() 'Llamada al método para bloquear columnas
        ActualizarSumatorias()
        DATACOTIZACIONES.Columns("PROPRECIO").DefaultCellStyle.Format = "C2"
        DATACOTIZACIONES.Columns("PROSUBTOTAL").DefaultCellStyle.Format = "C2"
        DATACOTIZACIONES.Columns("PROID").Visible = False
        DATACOTIZACIONES.Columns("PRONOMBRE").HeaderText = "Producto"
        DATACOTIZACIONES.Columns("PRONOMBRE").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DATACOTIZACIONES.Columns("Cantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DATACOTIZACIONES.Columns("Descuento").HeaderText = "Descuento"
        DATACOTIZACIONES.Columns("Descuento").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DATACOTIZACIONES.Columns("PROSUBTOTAL").HeaderText = "Total"
        DATACOTIZACIONES.Columns("PROCLAVE").Visible = False
        DATACOTIZACIONES.Columns("PROPRECIO").HeaderText = "Precio"
        DATACOTIZACIONES.Columns("PROPRECIO").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DATACOTIZACIONES.Columns("PROEXISTENCIAS").Visible = False
        TXTCANTIDAD.Text = 0
        CMBPRODUCTO.SelectedIndex = -1
        CMBPRODUCTO.Focus()
    End Sub

    Private Sub ActualizarSumatorias()
        Dim sumaSubtotal As Double = 0
        Dim sumaDescuento As Double = 0
        Dim sumaTotal As Double = 0

        ' Recorrer todas las filas del DataGridView
        For Each fila As DataGridViewRow In DATACOTIZACIONES.Rows
            If Not fila.IsNewRow Then
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
                Dim precio As Double = Convert.ToDouble(fila.Cells("PROPRECIO").Value)
                Dim descuento As Double = Convert.ToDouble(fila.Cells("Descuento").Value)
                Dim subtotal As Double = (cantidad * precio)

                sumaSubtotal += subtotal
                sumaDescuento += descuento
                sumaTotal += subtotal - descuento
            End If
        Next

        ' Asignar los valores calculados a los Label
        LBLSUBTOTAL.Text = sumaSubtotal.ToString("C2")
        LBLDESCUENTO.Text = sumaDescuento.ToString("C2")
        LBLTOTAL.Text = sumaTotal.ToString("C2")
    End Sub

    Private Sub ConfigurarEdicionDataGridView()
        'Bloquear todas las columnas excepto "Cantidad"
        For Each col As DataGridViewColumn In DATACOTIZACIONES.Columns
            If col.Name.Contains("Descuento") Then
                col.ReadOnly = False
            Else
                col.ReadOnly = True
            End If
        Next
    End Sub

    Private Sub DATACOTIZACIONES_KeyDown(sender As Object, e As KeyEventArgs) Handles DATACOTIZACIONES.KeyDown
        If DATACOTIZACIONES.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DATACOTIZACIONES.SelectedRows(0)

            'Verificar si la fila contiene la columna "Cantidad"
            If filaSeleccionada.Cells("Cantidad").Value IsNot Nothing Then
                Dim cantidadActual As Integer = Convert.ToInt32(filaSeleccionada.Cells("Cantidad").Value)

                'Modificar cantidad según la tecla presionada
                If e.KeyCode = Keys.Add OrElse e.KeyCode = Keys.Oemplus Then ' Tecla "+"
                    cantidadActual += 1
                ElseIf e.KeyCode = Keys.Subtract OrElse e.KeyCode = Keys.OemMinus Then ' Tecla "-"
                    cantidadActual = Math.Max(1, cantidadActual - 1) 'Evitar valores negativos o cero
                End If

                'Actualizar la celda de cantidad en la fila seleccionada
                filaSeleccionada.Cells("Cantidad").Value = cantidadActual
            End If
        End If
    End Sub

    Private Sub DATACOTIZACIONES_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DATACOTIZACIONES.CellValueChanged
        'Verificar que la celda modificada pertenece a la columna "Cantidad"
        If e.ColumnIndex = DATACOTIZACIONES.Columns("Cantidad").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DATACOTIZACIONES.Rows(e.RowIndex)

            'Obtener los valores necesarios
            Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
            Dim precio As Double = Convert.ToDouble(fila.Cells("PROPRECIO").Value)
            Dim descuento As Double = Convert.ToDouble(fila.Cells("Descuento").Value)

            'Recalcular el subtotal
            fila.Cells("PROSUBTOTAL").Value = (cantidad * precio) - descuento
        End If

        If e.ColumnIndex = DATACOTIZACIONES.Columns("Descuento").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DATACOTIZACIONES.Rows(e.RowIndex)

            'Obtener los valores necesarios
            Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
            Dim precio As Double = Convert.ToDouble(fila.Cells("PROPRECIO").Value)
            Dim descuento As Double = Convert.ToDouble(fila.Cells("Descuento").Value)

            'Recalcular el subtotal
            fila.Cells("PROSUBTOTAL").Value = (cantidad * precio) - descuento
        End If

        If e.ColumnIndex = DATACOTIZACIONES.Columns("Cantidad").Index OrElse e.ColumnIndex = DATACOTIZACIONES.Columns("Descuento").Index Then
            Dim fila As DataGridViewRow = DATACOTIZACIONES.Rows(e.RowIndex)

            'Recalcular subtotal
            Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
            Dim precio As Double = Convert.ToDouble(fila.Cells("PROPRECIO").Value)
            Dim descuento As Double = Convert.ToDouble(fila.Cells("Descuento").Value)
            fila.Cells("PROSUBTOTAL").Value = (cantidad * precio) - descuento

            ActualizarSumatorias() 'Actualizar etiquetas después del cambio
        End If


    End Sub

    Private Sub TXTCANTIDAD_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTCANTIDAD.KeyDown
        If e.KeyCode = Keys.Add Then
            TXTCANTIDAD.Text = Val(TXTCANTIDAD.Text) + 1
        End If
        If e.KeyCode = Keys.Subtract Then
            If TXTCANTIDAD.Text >= 1 Then
                TXTCANTIDAD.Text = Val(TXTCANTIDAD.Text) - 1
            End If
        End If
    End Sub

    Private Sub DATACOTIZACIONES_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles DATACOTIZACIONES.EditingControlShowing
        ' Verificar si la celda pertenece a la columna "Descuento"
        If DATACOTIZACIONES.CurrentCell.ColumnIndex = DATACOTIZACIONES.Columns("Descuento").Index Then
            Dim txtBox As TextBox = TryCast(e.Control, TextBox)
            If txtBox IsNot Nothing Then
                ' Eliminar cualquier manejador previo para evitar duplicaciones
                RemoveHandler txtBox.KeyPress, AddressOf SoloNumeros
                ' Agregar evento para restringir entrada numérica
                AddHandler txtBox.KeyPress, AddressOf SoloNumeros
            End If
        End If
    End Sub

    ' Método que permite solo números y punto decimal en el campo
    Private Sub SoloNumeros(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Cancela la entrada si no es número ni punto decimal
        End If

        ' Evitar múltiples puntos decimales
        Dim txtBox As TextBox = TryCast(sender, TextBox)
        If e.KeyChar = "." AndAlso txtBox.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub CMBPRODUCTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPRODUCTO.SelectedIndexChanged
        ' Verificar que haya un producto seleccionado
        If CMBPRODUCTO.SelectedIndex <> -1 Then
            Dim PROID As Integer = Convert.ToInt32(CMBPRODUCTO.SelectedValue)

            ' Consultar el precio desde la vista en la base de datos
            Dim query As String = "SELECT PROPRECIO FROM VISTAPRODUCTOS WHERE PROID = @PROID"
            Dim comando As New SqlClient.SqlCommand(query, Conexion)
            comando.Parameters.AddWithValue("@PROID", PROID)

            Try
                Conexion.Open() ' Abrir la conexión
                Dim precio As Object = comando.ExecuteScalar()
                Conexion.Close() ' Cerrar la conexión

                ' Si se obtuvo un precio, asignarlo y darle formato de moneda
                If precio IsNot Nothing Then
                    LBLPRECIO.Text = Convert.ToDouble(precio).ToString("C2")
                Else
                    LBLPRECIO.Text = "$0.00"
                End If
            Catch ex As Exception
                MessageBox.Show("Error al obtener el precio: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If Conexion.State = ConnectionState.Open Then
                    Conexion.Close()
                End If
            End Try
        End If
    End Sub
End Class