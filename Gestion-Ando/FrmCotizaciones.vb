Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports iTextSharp.text.pdf.draw

Public Class FrmCotizaciones

    Public nombreVendedor As String
    Public Sub GenerarPDF()
        Try
            ' Cuadro de diálogo para que el usuario seleccione la ubicación del PDF
            Dim guardarDialogo As New SaveFileDialog()
            guardarDialogo.Filter = "Archivos PDF (*.pdf)|*.pdf"
            guardarDialogo.Title = "Guardar PDF"
            guardarDialogo.FileName = "Cotizacion.pdf"

            If guardarDialogo.ShowDialog() = DialogResult.OK Then
                Dim rutaPDF As String = guardarDialogo.FileName

                ' Consultar la información de la cotización
                StrSql = "SELECT TBLCOTIZACIONES.COTID AS 'No.Cotización',COTFECHA AS Fecha,USUNOMBRE AS Vendedor, PRONOMBRE as Producto, 
                     PROPRECIO as 'Precio individual', PROCANTIDAD as Cantidad, 
                     PRODESCUENTO as Descuento, PROTOTAL AS 'Precio final' ,COTSUBTOTAL as SubTotal, 
                     COTDESCUENTO as 'Descuento total', COTTOTAL as Total
                  FROM TBLCOTIZACIONES 
                  INNER JOIN TBLDETALLECOTIZACIONES ON TBLCOTIZACIONES.COTID = TBLDETALLECOTIZACIONES.COTID
                  INNER JOIN TBLUSUARIOS ON TBLCOTIZACIONES.USUID = TBLUSUARIOS.USUID
                  INNER JOIN TBLPRODUCTOS ON TBLDETALLECOTIZACIONES.PROID = TBLPRODUCTOS.PROID
                  WHERE TBLCOTIZACIONES.COTID = @COTID"

                Dim comando As New SqlCommand(StrSql, Conexion)
                If HISTORIAL = False Then
                    comando.Parameters.AddWithValue("@COTID", COTID - 1)
                Else
                    comando.Parameters.AddWithValue("@COTID", DATACOTIZACIONES.CurrentRow().Cells("No.Cotización").Value)
                End If

                Dim adaptador As New SqlDataAdapter(comando)
                Dim tablaDatos As New DataTable()
                adaptador.Fill(tablaDatos)

                ' Verificar si hay registros
                If tablaDatos.Rows.Count = 0 Then
                    MessageBox.Show("No hay registros disponibles para esta cotización.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If

                ' Extraer valores importantes
                Dim subtotal As String = String.Format("{0:C}", Convert.ToDecimal(tablaDatos.Rows(0)("SubTotal")))
                Dim descuentoTotal As String = String.Format("{0:C}", Convert.ToDecimal(tablaDatos.Rows(0)("Descuento total")))
                Dim total As String = String.Format("{0:C}", Convert.ToDecimal(tablaDatos.Rows(0)("Total")))
                nombreVendedor = tablaDatos.Rows(0)("Vendedor").ToString()

                ' Eliminar columnas antes de mostrar la tabla
                tablaDatos.Columns.Remove("Vendedor")
                tablaDatos.Columns.Remove("SubTotal")
                tablaDatos.Columns.Remove("Descuento total")
                tablaDatos.Columns.Remove("Total")
                tablaDatos.Columns.Remove("No.Cotización")
                tablaDatos.Columns.Remove("Fecha")

                ' Configurar documento PDF con márgenes más amplios
                Dim doc As New Document(PageSize.A4.Rotate(), 50, 50, 40, 40)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(rutaPDF, FileMode.Create))

                ' Mantener referencias a las clases de pie de página y encabezado
                Dim eventoPie As New PiePaginaPDF()
                writer.PageEvent = eventoPie
                Dim eventoEncabezado As New EncabezadoPDF()
                writer.PageEvent = eventoEncabezado

                doc.Open()

                ' Definir fuentes mejoradas
                Dim fuenteTitulo As Font = FontFactory.GetFont("Helvetica", 25)
                Dim fuenteEncabezado As Font = FontFactory.GetFont("Dubai", 15)
                Dim fuenteCuerpo As Font = FontFactory.GetFont("Times-Roman", 12)
                Dim fuenteResumen As Font = FontFactory.GetFont("Dubai", 12)

                ' Cargar el logo y definir su ubicación en la página
                Dim ruta As String = Application.StartupPath & "\LogoGestion-Ando.png"
                Dim imagen As Image = Image.GetInstance(ruta)
                imagen.ScaleAbsolute(150, 150) ' Ajustar tamaño de la imagen
                imagen.SetAbsolutePosition(20, doc.PageSize.Height - 140) ' Ubicación en la parte superior izquierda

                doc.Add(imagen) ' Agregar la imagen al documento

                ' Agregar título y espacio adicional para bajar el contenido
                Dim titulo As New Paragraph("Cotización de productos", fuenteTitulo)
                titulo.Alignment = Element.ALIGN_CENTER
                titulo.SpacingBefore = 60 ' Espacio antes del título
                titulo.SpacingAfter = 0 ' Aumentar espacio para mover el contenido hacia abajo

                doc.Add(titulo)

                ' Línea separadora antes de la tabla (Ubicación de la tabla)
                doc.Add(New Chunk(New LineSeparator()))

                ' Crear tabla con todas las columnas
                Dim tablaPDF As New PdfPTable(tablaDatos.Columns.Count)
                tablaPDF.WidthPercentage = 100

                ' Ajustar ancho de columnas para que "Producto" sea más amplio
                Dim anchos(tablaDatos.Columns.Count - 1) As Single
                For i As Integer = 0 To tablaDatos.Columns.Count - 1
                    If tablaDatos.Columns(i).ColumnName = "Producto" Then
                        anchos(i) = 3
                    Else
                        anchos(i) = 1
                    End If
                Next
                tablaPDF.SetWidths(anchos)

                ' Agregar encabezados con diseño mejorado
                For Each columna As DataColumn In tablaDatos.Columns
                    Dim celdaEncabezado As New PdfPCell(New Phrase(columna.ColumnName, fuenteEncabezado))
                    celdaEncabezado.BackgroundColor = New BaseColor(213, 191, 168)
                    celdaEncabezado.HorizontalAlignment = Element.ALIGN_CENTER
                    tablaPDF.AddCell(celdaEncabezado)
                Next

                ' Agregar filas de datos con alineación correcta y formato de moneda
                For Each fila As DataRow In tablaDatos.Rows
                    For Each columna As DataColumn In tablaDatos.Columns
                        Dim valor As Object = fila(columna.ColumnName)

                        ' Restaurar formato de moneda para los valores monetarios
                        If columna.ColumnName = "Precio individual" OrElse columna.ColumnName = "Descuento" OrElse columna.ColumnName = "Precio final" Then
                            valor = String.Format("{0:C}", Convert.ToDecimal(valor))
                        End If

                        ' Crear celda y establecer alineación correcta
                        Dim celda As New PdfPCell(New Phrase(valor.ToString(), fuenteCuerpo))

                        ' Alinear al centro todo excepto "Producto"
                        If columna.ColumnName <> "Producto" Then
                            celda.HorizontalAlignment = Element.ALIGN_CENTER
                        End If

                        celda.VerticalAlignment = Element.ALIGN_MIDDLE
                        tablaPDF.AddCell(celda)
                    Next
                Next

                ' Agregar la tabla de productos al documento
                doc.Add(tablaPDF)

                ' Mostrar "Subtotal", "Descuento total" y "Total" justo debajo de la tabla
                Dim resumen As New Paragraph("Subtotal: " & subtotal & vbCrLf &
                                         "Descuento total: " & descuentoTotal & vbCrLf &
                                         "Total: " & total, fuenteResumen)
                resumen.Alignment = Element.ALIGN_RIGHT
                resumen.SpacingBefore = 10
                doc.Add(resumen)

                doc.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error al generar el PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CMBCLIENTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBCLIENTE.SelectedIndexChanged
        If HISTORIAL = False Then
            ' Si estamos en modo historial, no hacemos nada al cambiar el cliente
            Return
        End If
        If CMBCLIENTE.SelectedValue IsNot Nothing AndAlso IsNumeric(CMBCLIENTE.SelectedValue) Then
            StrSql = "SELECT TBLCOTIZACIONES.COTID as 'No.Cotización',COTFECHA AS Fecha, USUNOMBRE AS Vendedor,CLINOMBRE +' '+ CLIAPEPATERNO+ ' '+CLIAPEMATERNO AS Cliente,
                             COTSUBTOTAL as SubTotal, COTDESCUENTO as 'Descuento total', COTTOTAL as Total
                  FROM TBLCOTIZACIONES 
                  INNER JOIN TBLUSUARIOS ON TBLCOTIZACIONES.USUID = TBLUSUARIOS.USUID
                  INNER JOIN TBLCLIENTES ON TBLCOTIZACIONES.CLIID=TBLCLIENTES.CLIID
                  WHERE TBLCOTIZACIONES.CLIID = @CLIID AND COTEXISTE=1 ORDER BY TBLCOTIZACIONES.COTID DESC"


            Dim comando As New SqlCommand(StrSql, Conexion)
            comando.Parameters.AddWithValue("@CLIID", CMBCLIENTE.SelectedValue)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tablaDatos As New DataTable()
            adaptador.Fill(tablaDatos)

            DATACOTIZACIONES.ReadOnly = True
            DATACOTIZACIONES.DataSource = tablaDatos

            DATACOTIZACIONES.Columns("No.Cotización").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DATACOTIZACIONES.Columns("No.Cotización").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DATACOTIZACIONES.Columns("Vendedor").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            DATACOTIZACIONES.Columns("SubTotal").DefaultCellStyle.Format = "C2"
            DATACOTIZACIONES.Columns("SubTotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DATACOTIZACIONES.Columns("Descuento total").DefaultCellStyle.Format = "C2"
            DATACOTIZACIONES.Columns("Descuento total").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DATACOTIZACIONES.Columns("Descuento total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DATACOTIZACIONES.Columns("Total").DefaultCellStyle.Format = "C2"
            DATACOTIZACIONES.Columns("Total").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DATACOTIZACIONES.Columns("Cliente").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            DATACOTIZACIONES.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        End If

    End Sub

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

        If HISTORIAL = False Then
            ACTUALIZARCOITD()
            BTNENVIAR.Location = New Point(1706, 442)
            BTNELIMINAR.Visible = False
        End If

        If HISTORIAL = True Then
            Me.AGREGARPRODUCTOS.Visible = False
            LBLCLIENTE.Location = New Point(279, 140)
            CMBCLIENTE.Location = New Point(362, 137)
            DATACOTIZACIONES.Size = New Size(1300, 567)
            DATACOTIZACIONES.Location = New Point(200, 242)
            BTNGUARDAR.Location = New Point(1600, 242)
            BTNELIMINAR.Location = New Point(1600, 442)
            BTNENVIAR.Location = New Point(1600, 642)
            BTNGUARDAR.Text = "Generar PDF"
        End If
    End Sub

    Public Sub ACTUALIZARCOITD()
        StrSql = "SELECT (MAX(COTID) + 1) FROM TBLCOTIZACIONES;"
        comando = New SqlClient.SqlCommand(StrSql, Conexion)
        Try
            If Conectar() = True Then
                Conexion.Open() ' Abrir la conexión manualmente
                Dim resultado As Object = comando.ExecuteScalar()
                If resultado IsNot DBNull.Value AndAlso resultado IsNot Nothing Then
                    COTID = Convert.ToInt64(resultado)
                Else
                    COTID = 1
                End If
                LBLCOTID.Text = COTID.ToString("D5")

            End If
        Catch ex As Exception
            MsgBox("Error al obtener el ID de la cotización: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
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
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTNAGREGAR_Click(sender As Object, e As EventArgs) Handles BTNAGREGAR.Click
        If CMBPRODUCTO.SelectedIndex = -1 Then
            CMBPRODUCTO.Focus()
            Return
        End If

        If TXTCANTIDAD.Text = 0 Then
            TXTCANTIDAD.Focus()
            Return
        End If

        Dim PROID As Integer = Convert.ToInt32(CMBPRODUCTO.SelectedValue)
        Dim cantidad As Integer = Val(Me.TXTCANTIDAD.Text)
        Dim descuento As Double = 0

        Dim query As String = "SELECT * FROM VISTAPRODUCTOS WHERE PROID = @PROID"
        Dim comando As New SqlClient.SqlCommand(query, Conexion)
        comando.Parameters.AddWithValue("@PROID", PROID)

        Dim adaptador As New SqlClient.SqlDataAdapter(comando)
        Dim tablaNueva As New DataTable()
        adaptador.Fill(tablaNueva)

        Dim tablaExistente As DataTable

        If DATACOTIZACIONES.DataSource IsNot Nothing Then
            tablaExistente = CType(DATACOTIZACIONES.DataSource, DataTable)
        Else
            tablaExistente = tablaNueva.Clone()
        End If

        If Not tablaExistente.Columns.Contains("Cantidad") Then
            tablaExistente.Columns.Add("Cantidad", GetType(Integer))
        End If
        If Not tablaExistente.Columns.Contains("Descuento") Then
            tablaExistente.Columns.Add("Descuento", GetType(Double))
        End If
        If Not tablaExistente.Columns.Contains("PROSUBTOTAL") Then
            tablaExistente.Columns.Add("PROSUBTOTAL", GetType(Double))
        End If


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
        ConfigurarEdicionDataGridView()
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
        LBLPRECIO.Text = ". . ."
    End Sub

    Private Sub ActualizarSumatorias()
        Dim sumaSubtotal As Double = 0
        Dim sumaDescuento As Double = 0
        Dim sumaTotal As Double = 0

        ' Recorrer todas las filas del DataGridView
        For Each fila As DataGridViewRow In DATACOTIZACIONES.Rows
            If Not fila.IsNewRow Then
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
                Dim precio As Double
                If HISTORIAL = True Then
                    precio = Convert.ToDouble(fila.Cells("Precio individual").Value)
                Else
                    precio = Convert.ToDouble(fila.Cells("PROPRECIO").Value)
                End If

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
        If HISTORIAL = True Then
            Return
        End If

        If DATACOTIZACIONES.SelectedRows.Count > 0 Then
            Dim filaSeleccionada As DataGridViewRow = DATACOTIZACIONES.SelectedRows(0)

            ' Verificar si la fila contiene la columna "Cantidad"
            If filaSeleccionada.Cells("Cantidad").Value IsNot Nothing Then
                Dim cantidadActual As Integer = Convert.ToInt32(filaSeleccionada.Cells("Cantidad").Value)

                ' Modificar cantidad según la tecla presionada
                If e.KeyCode = Keys.Add OrElse e.KeyCode = Keys.Oemplus Then ' Tecla "+"
                    cantidadActual += 1
                    filaSeleccionada.Cells("Cantidad").Value = cantidadActual
                    
                ElseIf e.KeyCode = Keys.Subtract OrElse e.KeyCode = Keys.OemMinus Then ' Tecla "-"
                    If cantidadActual > 1 Then
                        cantidadActual -= 1
                        filaSeleccionada.Cells("Cantidad").Value = cantidadActual
                    Else
                        ' Si la cantidad es 1 y se presiona "-", eliminar la fila
                        DATACOTIZACIONES.Rows.Remove(filaSeleccionada)
                        ActualizarSumatorias()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub DATACOTIZACIONES_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DATACOTIZACIONES.CellValueChanged
        'Verificar que la celda modificada pertenece a la columna "Cantidad"
        If e.ColumnIndex = DATACOTIZACIONES.Columns("Cantidad").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DATACOTIZACIONES.Rows(e.RowIndex)

            'Obtener los valores necesarios
            Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
            Dim precio As Double
            If HISTORIAL = True Then
                precio = Convert.ToDouble(fila.Cells("Precio individual").Value)
            Else
                precio = Convert.ToDouble(fila.Cells("PROPRECIO").Value)
            End If

            Dim descuento As Double = Convert.ToDouble(fila.Cells("Descuento").Value)

            'Recalcular el subtotal
            If HISTORIAL = True Then
                fila.Cells("SubTotal").Value = (cantidad * precio) - descuento
            Else
                fila.Cells("PROSUBTOTAL").Value = (cantidad * precio) - descuento
            End If

        End If

        If e.ColumnIndex = DATACOTIZACIONES.Columns("Descuento").Index AndAlso e.RowIndex >= 0 Then
            Dim fila As DataGridViewRow = DATACOTIZACIONES.Rows(e.RowIndex)

            'Obtener los valores necesarios
            Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
            Dim precio As Double
            If HISTORIAL = True Then
                precio = Convert.ToDouble(fila.Cells("Precio individual").Value)
            Else
                precio = Convert.ToDouble(fila.Cells("PROPRECIO").Value)
            End If
            Dim descuento As Double = Convert.ToDouble(fila.Cells("Descuento").Value)

            'Recalcular el subtotal
            If HISTORIAL = True Then
                fila.Cells("SubTotal").Value = (cantidad * precio) - descuento
            Else
                fila.Cells("PROSUBTOTAL").Value = (cantidad * precio) - descuento
            End If
        End If

        If e.ColumnIndex = DATACOTIZACIONES.Columns("Cantidad").Index OrElse e.ColumnIndex = DATACOTIZACIONES.Columns("Descuento").Index Then
            Dim fila As DataGridViewRow = DATACOTIZACIONES.Rows(e.RowIndex)

            'Recalcular subtotal
            Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
            Dim precio As Double
            If HISTORIAL = True Then
                precio = Convert.ToDouble(fila.Cells("Precio individual").Value)
            Else
                precio = Convert.ToDouble(fila.Cells("PROPRECIO").Value)
            End If
            Dim descuento As Double = Convert.ToDouble(fila.Cells("Descuento").Value)
            If HISTORIAL = True Then
                fila.Cells("SubTotal").Value = (cantidad * precio) - descuento
            Else
                fila.Cells("PROSUBTOTAL").Value = (cantidad * precio) - descuento
            End If

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

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            BTNAGREGAR.PerformClick()
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

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        If DATACOTIZACIONES.CurrentRow Is Nothing Then
            MsgBox("Selecciona una cotización válida para eliminar.", MsgBoxStyle.Exclamation, "Advertencia")
            Return
        End If

        If MessageBox.Show("¿Estás seguro que deseas eliminar esta cotización?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
            End If

            Dim cotID As Long = Convert.ToInt64(DATACOTIZACIONES.CurrentRow.Cells("No.Cotización").Value)

            Dim comando As New SqlCommand("ELIMINARCOTIZACION", Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@COTID", cotID)

            comando.ExecuteNonQuery()

            'Si no hubo excepción, asumimos éxito
            MsgBox("Cotización eliminada exitosamente", MsgBoxStyle.Information, "Confirmación")
            CMBCLIENTE_SelectedIndexChanged(Nothing, Nothing) ' Actualizar la lista de cotizaciones


        Catch ex As Exception
            MsgBox("Error al eliminar la cotización: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try
    End Sub


    Public COTID As Long
    Dim LIMPIAR As Boolean
    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        If HISTORIAL = True Then
            LIMPIAR = True
        End If
        If HISTORIAL = True AndAlso DATACOTIZACIONES.RowCount = 0 Then
            Return
        End If
        Try

            If HISTORIAL = True Then
                GenerarPDF()
                Return
            End If
            If CMBCLIENTE.SelectedIndex = -1 Then
                MsgBox("Seleccione un cliente", MsgBoxStyle.Exclamation, "Advertencia")
                CMBCLIENTE.Focus()
                Return
            End If

            If DATACOTIZACIONES.RowCount = 0 Then
                MsgBox("Debe agregar al menos un producto a la cotización", MsgBoxStyle.Exclamation, "Advertencia")
                CMBPRODUCTO.Focus()
                Return
            End If

            ' Ejecutar el procedimiento almacenado para registrar la cotización
            StrSql = "ALTACOTIZACION"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.AddWithValue("@CLIID", CMBCLIENTE.SelectedValue)
            comando.Parameters.AddWithValue("@COTFECHA", DateTime.Now)
            comando.Parameters.AddWithValue("@USUID", IDUSUARIOACTUAL)
            comando.Parameters.AddWithValue("@COTDESCUENTO", LBLDESCUENTO.Text.Replace("$", "").Replace(",", ""))
            comando.Parameters.AddWithValue("@COTSUBTOTAL", LBLSUBTOTAL.Text.Replace("$", "").Replace(",", ""))
            comando.Parameters.AddWithValue("@COTTOTAL", LBLTOTAL.Text.Replace("$", "").Replace(",", ""))
            comando.Parameters.Add("@RETORNO", SqlDbType.BigInt).Direction = ParameterDirection.Output

            If Conectar() = True Then
                COTID = comando.Parameters("@RETORNO").Value

                ' Registrar los productos en detalle de cotización
                For REC = 0 To Me.DATACOTIZACIONES.RowCount - 1
                    StrSql = "ALTADETALLECOTIZACIONES"
                    comando = New SqlClient.SqlCommand(StrSql, Conexion)
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.AddWithValue("@COTID", COTID)
                    comando.Parameters.Add("@PROID", SqlDbType.BigInt).Value = Me.DATACOTIZACIONES.Rows(REC).Cells("PROID").Value
                    comando.Parameters.Add("@PROCANTIDAD", SqlDbType.Int).Value = Me.DATACOTIZACIONES.Rows(REC).Cells("CANTIDAD").Value
                    comando.Parameters.Add("@PRODESCUENTO", SqlDbType.Money).Value = Me.DATACOTIZACIONES.Rows(REC).Cells("DESCUENTO").Value
                    comando.Parameters.Add("@PROTOTAL", SqlDbType.Money).Value = Convert.ToDecimal(Me.DATACOTIZACIONES.Rows(REC).Cells("PROSUBTOTAL").Value)
                    comando.Parameters.Add("@RETORNO", SqlDbType.Bit).Direction = ParameterDirection.Output
                    Conectar()
                Next

                MsgBox("Cotización registrada exitosamente", MsgBoxStyle.Information, "Confirmación")
                LimpiarCampos()
                ACTUALIZARCOITD()
                GenerarPDF()
            End If
        Catch
            MsgBox("Error al registrar la cotización", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub LimpiarCampos()
        ' Limpiar los campos del formulario
        CMBPRODUCTO.SelectedIndex = -1
        TXTCANTIDAD.Text = "0"
        LBLPRECIO.Text = ". . ."
        DATACOTIZACIONES.DataSource = Nothing
        LBLSUBTOTAL.Text = "$0.00"
        LBLDESCUENTO.Text = "$0.00"
        LBLTOTAL.Text = "$0.00"
    End Sub

    Private Sub DATACOTIZACIONES_SelectionChanged(sender As Object, e As EventArgs) Handles DATACOTIZACIONES.SelectionChanged
        If HISTORIAL = False Then
            Return
        End If
        LBLCOTID.Text = If(DATACOTIZACIONES.CurrentRow IsNot Nothing, DATACOTIZACIONES.CurrentRow.Cells("No.Cotización").Value.ToString(), "0")
        LBLSUBTOTAL.Text = If(DATACOTIZACIONES.CurrentRow IsNot Nothing, String.Format("{0:C2}", Convert.ToDecimal(DATACOTIZACIONES.CurrentRow.Cells("SubTotal").Value)), "$0.00")
        LBLDESCUENTO.Text = If(DATACOTIZACIONES.CurrentRow IsNot Nothing, String.Format("{0:C2}", Convert.ToDecimal(DATACOTIZACIONES.CurrentRow.Cells("Descuento total").Value)), "$0.00")
        LBLTOTAL.Text = If(DATACOTIZACIONES.CurrentRow IsNot Nothing, String.Format("{0:C2}", Convert.ToDecimal(DATACOTIZACIONES.CurrentRow.Cells("Total").Value)), "$0.00")
    End Sub

    Private Sub BTNENVIAR_Click(sender As Object, e As EventArgs) Handles BTNENVIAR.Click
        If HISTORIAL = True AndAlso DATACOTIZACIONES.RowCount = 0 Then
            Return
        End If
        BTNGUARDAR_Click(sender, e) ' Llamar al método de guardar para generar el PDF
        Try
            'Validar si se ha seleccionado un cliente
            If CMBCLIENTE.SelectedIndex < 0 Then
                MessageBox.Show("Antes selecciona un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                CMBCLIENTE.Focus()
                Return
            End If

            'Consultar el correo del cliente en la base de datos
            StrSql = "SELECT CLICORREO FROM TBLCLIENTES WHERE CLIID = @CLIID"
            Dim comando As New SqlCommand(StrSql, Conexion)
            comando.Parameters.AddWithValue("@CLIID", CMBCLIENTE.SelectedValue)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tablaDatos As New DataTable()
            adaptador.Fill(tablaDatos)

            'Validar si el cliente tiene correo registrado
            If tablaDatos.Rows.Count = 0 OrElse String.IsNullOrEmpty(tablaDatos.Rows(0)("CLICORREO").ToString().Trim()) Then
                MessageBox.Show("El cliente no tiene un correo electrónico registrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            'Obtener el correo del cliente
            Dim destinatario As String = tablaDatos.Rows(0)("CLICORREO").ToString().Trim()

            'Definir el asunto y cuerpo del mensaje
            Dim asunto As String
            If HISTORIAL = True Then
                asunto = "Cotización de productos. No." + DATACOTIZACIONES.CurrentRow.Cells("No.Cotización").Value.ToString()
            Else
                asunto = "Cotización de productos. No. " + (COTID - 1).ToString()
            End If

            Dim mensaje As String = "Le envío la cotización de los productos solicitados. Buen día"
            Dim cuerpo As String = mensaje.Replace(" ", "%20")

            'Construir la URL personalizada
            Dim gmailURL As String = $"https://mail.google.com/mail/u/0/?view=cm&fs=1&tf=1&to={destinatario}&su={asunto}&body={cuerpo}"

            'Abrir Gmail solo si hay un destinatario válido
            Process.Start(New ProcessStartInfo(gmailURL) With {.UseShellExecute = True})
            If LIMPIAR = False Then
                CMBCLIENTE.SelectedIndex = -1
            End If

        Catch ex As Exception
            MessageBox.Show("Error al abrir Gmail: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BTNQUITAR.Click
        ' Verificar que haya una fila seleccionada
        If DATACOTIZACIONES.CurrentRow IsNot Nothing Then
            ' Obtener la cantidad del producto seleccionado en DataCotizaciones
            Dim cantidadProducto As Integer = Convert.ToInt32(DATACOTIZACIONES.CurrentRow.Cells("Cantidad").Value)

            ' Verificar si la cantidad es mayor que 1
            If cantidadProducto > 1 Then
                ' Restar 1 a la cantidad
                cantidadProducto -= 1

                ' Actualizar la cantidad en la fila
                DATACOTIZACIONES.CurrentRow.Cells("Cantidad").Value = cantidadProducto

                ' Actualizar el subtotal en la fila
                Dim precio As Double = Convert.ToDouble(DATACOTIZACIONES.CurrentRow.Cells("PROPRECIO").Value)
                DATACOTIZACIONES.CurrentRow.Cells("PROSUBTOTAL").Value = cantidadProducto * precio
            Else
                ' Si la cantidad es 1 o menor, eliminar la fila
                DATACOTIZACIONES.Rows.Remove(DATACOTIZACIONES.CurrentRow)
            End If

            ' Recalcular el subtotal acumulado después de quitar el producto
            ActualizarSumatorias()

        Else
            MsgBox("Selecciona un producto para quitar", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

End Class

Public Class PiePaginaPDF
    Inherits PdfPageEventHelper

    Private ReadOnly _fuentePie As Font = FontFactory.GetFont("Dubai", 10)

    Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)
        Dim cb As PdfContentByte = writer.DirectContent
        Dim fechaTexto As String

        If HISTORIAL = True Then
            fechaTexto = "Generado el: " + FrmCotizaciones.DATACOTIZACIONES.CurrentRow.Cells("Fecha").Value.ToString() + " por " + FrmCotizaciones.DATACOTIZACIONES.CurrentRow.Cells("Vendedor").Value.ToString()
        Else
            fechaTexto = "Generado el: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + " por " + FrmCotizaciones.nombreVendedor
        End If

        ' Definir la posición en la que se imprimirá el pie de página
        Dim piePagina As New Paragraph(fechaTexto, _fuentePie)
        Dim x As Single = document.LeftMargin
        Dim y As Single = document.BottomMargin - 10 ' Colocar en la parte más baja posible

        ' Imprimir el pie de página en la parte inferior de cada hoja
        ColumnText.ShowTextAligned(cb, Element.ALIGN_RIGHT, New Phrase(piePagina), document.Right, y, 0)
    End Sub
End Class

Public Class EncabezadoPDF
    Inherits PdfPageEventHelper

    Private ReadOnly _fuenteEncabezado As Font = FontFactory.GetFont("Dubai", 12)

    Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)
        Dim cb As PdfContentByte = writer.DirectContent
        Dim textoEncabezado As String = "Powered by Gestion-Ando"
        If HISTORIAL = True Then
            textoEncabezado += ". Cotización No. " + FrmCotizaciones.DATACOTIZACIONES.CurrentRow.Cells("No.Cotización").Value.ToString()
        Else
            textoEncabezado += ". Cotización No. " + (FrmCotizaciones.COTID - 1).ToString
        End If
        'Definir la posición en la parte superior derecha
        Dim x As Single = document.Right
        Dim y As Single = document.Top ' Ajuste para colocarlo justo arriba

        'Agregar el texto al documento
        ColumnText.ShowTextAligned(cb, Element.ALIGN_RIGHT, New Phrase(textoEncabezado, _fuenteEncabezado), x, y, 0)
    End Sub
End Class