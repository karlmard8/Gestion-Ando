﻿Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.Extensions.Logging

Public Class FrmAltaVentas
    Private Sub FrmAltaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' CONEXION PARA VISTAPRODUCTOS
        Me.VISTAPRODUCTOSTableAdapter.Connection = Conexion
        Me.VISTAPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAPRODUCTOS)

        ' CONEXION PARA VISTACLIENTES
        Me.VISTACLIENTESTableAdapter.Connection = Conexion
        Me.VISTACLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.VISTACLIENTES)

        ' Configuración de colores y controles
        DtgProductos.TabStop = False
        Me.BackColor = ColorFormulario
        GRUPO1.BackColor = ColorFormulario
        GRUPO2.BackColor = ColorFormulario
        DtgProductos.BackgroundColor = ColorFormulario
        EstiloBotones.CambiarColorBotones(Me)

        LBLUSUARIOACTUAL.Text = USUARIOACTUAL
        CmbClientes.SelectedValue = 0
        CmbClave.SelectedValue = -1
        CmbClave.Visible = False
        CMBEXISTENCIAS.BackColor = Color.White
        LBLCLAVE.Visible = False
        TXTMESES.Enabled = False
        TXTPAGO.Enabled = False
        TXTENGANCHE.Enabled = False
        RBCONTADO.Checked = False
        RBCREDITO.Checked = False
        CMBPRECIO.FormatString = "C2"

        If RBCONTADO.Checked = False Then
            TXTPAGO.Enabled = False
        End If
        If RBCREDITO.Checked = False Then
            TXTMESES.Enabled = False
            TXTENGANCHE.Enabled = False
        End If

        ' --- CONFIGURACIÓN DE COMBOBOX DE PRODUCTOS ---
        ' Enlazar todos al mismo origen de datos
        Dim bsProductos As New BindingSource()
        bsProductos.DataSource = MuebleAlexDataSet.VISTAPRODUCTOS

        ' Remover eventos para evitar ejecución no deseada
        RemoveHandler CMBPRODUCTO.SelectedIndexChanged, AddressOf CMBPRODUCTO_SelectedIndexChanged

        ' Configuración de ComboBox de productos
        CmbClave.DataSource = bsProductos
        CmbClave.DisplayMember = "PROCLAVE"
        CmbClave.ValueMember = "PROID"
        CmbClave.SelectedIndex = -1

        CMBPRODUCTO.DataSource = bsProductos
        CMBPRODUCTO.DisplayMember = "PRONOMBRE"
        CMBPRODUCTO.ValueMember = "PROID"
        CMBPRODUCTO.SelectedIndex = -1 ' No seleccionar nada al inicio

        CMBPRECIO.DataSource = bsProductos
        CMBPRECIO.DisplayMember = "PROPrecio"
        CMBPRECIO.ValueMember = "PrOID"
        CMBPRECIO.SelectedIndex = -1 ' No seleccionar nada al inicio

        CMBEXISTENCIAS.DataSource = bsProductos
        CMBEXISTENCIAS.DisplayMember = "PROExistencias"
        CMBEXISTENCIAS.ValueMember = "PrOID"
        CMBEXISTENCIAS.SelectedIndex = -1 ' No seleccionar nada al inicio

        ' Forzar actualización visual
        CMBPRODUCTO.Refresh()
        CMBPRECIO.Refresh()
        CMBEXISTENCIAS.Refresh()

        ' Restaurar evento
        AddHandler CMBPRODUCTO.SelectedIndexChanged, AddressOf CMBPRODUCTO_SelectedIndexChanged

        ' Activar capturas de teclado
        Me.KeyPreview = True
        If TIPO = "Operativo" Then
            RBCREDITO.Enabled = False
        ElseIf TIPO = "Administrador" Then
            RBCREDITO.Enabled = True
        End If

        AddHandler FrmPrincipal.Timer1.Tick, AddressOf ActualizarFecha
        FrmPrincipal.Timer1.Interval = 1000
        FrmPrincipal.Timer1.Start()
        DtgProductos.DefaultCellStyle.Font = New Font("Dubai", 12)
        DtgProductos.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
    End Sub

    Private Sub FrmAltaVentas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TXTCODIGOBARRAS.Focus()
        TXTCODIGOBARRAS.Clear()
    End Sub

    Private Sub FrmAltaVentas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Text = "Procesando..."
            End If
        Next
        LBLSUB.Text = "Procesando..."
        LBLIVA.Text = "Procesando..."
        LBLTOTAL.Text = "Procesando..."
        TXTCODIGOBARRAS.Focus()
        TXTPAGO.Text = String.Empty
        TXTENGANCHE.Text = String.Empty
        TXTMESES.Text = String.Empty
        DtgProductos.Rows.Clear()
    End Sub

    Private Sub CMBPRECIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPRECIO.SelectedIndexChanged
        Me.LblSubTotal.Text = Val(TxtCantidad.Text) * Val(CMBPRECIO.Text)
        TxtCantidad.Text = String.Empty

    End Sub

    Private Sub TxtCantidad_GotFocus(sender As Object, e As EventArgs) Handles TxtCantidad.GotFocus
        CMBPRECIO.FormatString = ""
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        Dim SUBTOTAL = Val(TxtCantidad.Text) * Val(CMBPRECIO.Text)
        Me.LblSubTotal.Text = SUBTOTAL.ToString("C2")
    End Sub

    Private Sub CMBPRODUCTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPRODUCTO.SelectedIndexChanged
        TxtCantidad.Enabled = False
        If CMBPRODUCTO.SelectedIndex >= 0 Then
            TxtCantidad.Enabled = True
        End If
    End Sub

    Private Sub RBCREDITO_CheckedChanged(sender As Object, e As EventArgs) Handles RBCREDITO.CheckedChanged
        TXTMESES.Enabled = True
        TXTENGANCHE.Enabled = True
        TXTMESES.Focus()
        TXTPAGO.Enabled = False
        TXTPAGO.Text = String.Empty
        TXTCAMBIO.Text = "N/A"
    End Sub

    Private Sub RBCONTADO_CheckedChanged(sender As Object, e As EventArgs) Handles RBCONTADO.CheckedChanged
        TXTCAMBIO.Text = "Procesando..."
        TXTPAGO.Enabled = True
        TXTPAGO.Focus()
        TXTMESES.Enabled = False
        TXTMESES.Text = String.Empty
        TXTENGANCHE.Enabled = False
        TXTENGANCHE.Text = String.Empty
    End Sub


    Public fechaParametro As DateTime

    Private Sub ActualizarFecha(sender As Object, e As EventArgs)
        fechaParametro = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
        'LabelFecha.Text = fechaParametro.ToString("dd/MM/yyyy HH:mm:ss") 'Mostrar en etiqueta
    End Sub

    Dim VENID As Long
    Private Sub BTNPAGAR_Click(sender As Object, e As EventArgs) Handles BTNPAGAR.Click
        If Me.CmbClientes.SelectedValue > 0 Then
            If (Me.DtgProductos.RowCount > 0) Then
                If RBCONTADO.Checked = True Or RBTDEBITO.Checked = True Or RBTCREDITO.Checked = True Then
                    If Val(Me.TXTPAGO.Text) >= (Me.LBLTOTAL.Text).ToString Then
                        StrSql = "ALTAVENTA"
                        comando = New SqlClient.SqlCommand(StrSql, Conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.Add("@VENFECHA", SqlDbType.DateTime).Value = fechaParametro.ToString("yyyy-MM-dd HH:mm:ss")
                        comando.Parameters.Add("@VENTOTAL", SqlDbType.Money).Value = Me.LBLTOTAL.Text
                        If RBTDEBITO.Checked Then
                            comando.Parameters.Add("@VENFORMA", SqlDbType.VarChar, 10).Value = "T. Débito"
                        ElseIf RBTCREDITO.Checked Then
                            comando.Parameters.Add("@VENFORMA", SqlDbType.VarChar, 10).Value = "T. Crédito"
                        ElseIf RBCONTADO.Checked Then
                            comando.Parameters.Add("@VENFORMA", SqlDbType.VarChar, 10).Value = "Contado"
                        End If
                        comando.Parameters.Add("@VENMESES", SqlDbType.Int).Value = 0
                        If TXTENGANCHE.Text = String.Empty Then
                            comando.Parameters.Add("@VENENGANCHE", SqlDbType.Money).Value = 0
                        End If
                        comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = IDUSUARIOACTUAL
                        comando.Parameters.Add("@CLIID", SqlDbType.BigInt).Value = Me.CmbClientes.SelectedValue
                        comando.Parameters.Add("@RETORNO", SqlDbType.BigInt).Direction = ParameterDirection.Output
                        If Conectar() = True Then
                            VENID = comando.Parameters("@RETORNO").Value
                            For REC = 0 To Me.DtgProductos.RowCount - 1
                                StrSql = "ALTADETVENTA"
                                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                                comando.CommandType = CommandType.StoredProcedure
                                comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = VENID
                                comando.Parameters.Add("@PROID", SqlDbType.BigInt).Value = Me.DtgProductos.Rows(REC).Cells("PROID").Value
                                comando.Parameters.Add("@DETCANTIDAD", SqlDbType.Int).Value = Me.DtgProductos.Rows(REC).Cells("PROCANTIDAD").Value
                                comando.Parameters.Add("DETPRECIO", SqlDbType.Money).Value = Me.DtgProductos.Rows(REC).Cells("PROPRECIO").Value
                                comando.Parameters.Add("DETSUBTOTAL", SqlDbType.Money).Value = Me.DtgProductos.Rows(REC).Cells("PROSUBTOTAL").Value
                                Conectar()
                            Next
                            MsgBox("Venta exitosa", MsgBoxStyle.Information, "Confirmación")

                            FrmVentas.CargarDatos()

                            Dim IMPRIMIR As DialogResult = MessageBox.Show("¿Desea imprimir el ticket?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If IMPRIMIR = DialogResult.Yes Then
                                ' Llamar al método de impresión
                                ImprimirTicket(Me)
                            End If
                            DialogResult = DialogResult.OK
                            ReiniciarFormulario()
                            FrmVentas.CargarDatos()
                        End If
                    Else
                        MsgBox("Dinero faltante", MsgBoxStyle.Exclamation, "Advertencia")
                    End If
                Else
                    If Val(Me.TXTMESES.Text) > 0 Then
                        StrSql = "ALTAVENTA"
                        comando = New SqlClient.SqlCommand(StrSql, Conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.Add("@VENFECHA", SqlDbType.DateTime).Value = fechaParametro.ToString("yyyy-MM-dd HH:mm:ss")
                        comando.Parameters.Add("@VENTOTAL", SqlDbType.Money).Value = Me.LBLTOTAL.Text
                        comando.Parameters.Add("@VENFORMA", SqlDbType.VarChar, 10).Value = "Crédito"
                        comando.Parameters.Add("@VENMESES", SqlDbType.Int).Value = Me.TXTMESES.Text
                        If TXTENGANCHE.Text = String.Empty Then
                            comando.Parameters.Add("@VENENGANCHE", SqlDbType.Money).Value = 0
                        Else
                            comando.Parameters.Add("@VENENGANCHE", SqlDbType.Money).Value = Me.TXTENGANCHE.Text
                        End If
                        comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = IDUSUARIOACTUAL
                        comando.Parameters.Add("@CLIID", SqlDbType.BigInt).Value = Me.CmbClientes.SelectedValue
                        comando.Parameters.Add("@RETORNO", SqlDbType.BigInt).Direction = ParameterDirection.Output
                        If Conectar() = True Then
                            VENID = comando.Parameters("@RETORNO").Value
                            For REC = 0 To Me.DtgProductos.RowCount - 1
                                StrSql = "ALTADETVENTA"
                                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                                comando.CommandType = CommandType.StoredProcedure
                                comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = VENID
                                comando.Parameters.Add("@PROID", SqlDbType.BigInt).Value = Me.DtgProductos.Rows(REC).Cells("PROID").Value
                                comando.Parameters.Add("@DETCANTIDAD", SqlDbType.Int).Value = Me.DtgProductos.Rows(REC).Cells("PROCANTIDAD").Value
                                comando.Parameters.Add("DETPRECIO", SqlDbType.Money).Value = Me.DtgProductos.Rows(REC).Cells("PROPRECIO").Value
                                comando.Parameters.Add("DETSUBTOTAL", SqlDbType.Money).Value = Me.DtgProductos.Rows(REC).Cells("PROSUBTOTAL").Value
                                Conectar()
                            Next
                            DialogResult = DialogResult.OK
                            MsgBox("Venta exitosa", MsgBoxStyle.Information, "Confirmación")

                            previousTotal = 0
                            FrmVentas.CargarDatos()


                            Dim IMPRIMIR As DialogResult = MessageBox.Show("¿Desea imprimir el ticket?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            If IMPRIMIR = DialogResult.Yes Then
                                ' Llamar al método de impresión
                                ImprimirTicket(Me)
                            End If
                            ReiniciarFormulario()
                        End If
                    Else
                        MsgBox("Ingresa el lapso de crédito", MsgBoxStyle.Exclamation, "Advertencia")

                        TXTMESES.Focus()
                    End If
                End If
            Else
                MsgBox("Ingresa un producto", MsgBoxStyle.Exclamation, "Advertencia")
                Me.CMBPRODUCTO.Focus()
            End If
        Else
            MsgBox("Ingresa un cliente", MsgBoxStyle.Exclamation, "Advertencia")
            Me.CmbClientes.Focus()
        End If


    End Sub

    Private Sub ReiniciarFormulario()
        Dim nuevoForm As New FrmAltaVentas()
        nuevoForm.Show()
        Me.Close()
    End Sub

    Public Sub ImprimirTicket(Optional ByVal formularioOrigen As Form = Nothing)

        'Detectar desde qué formulario se ejecuta
        If TypeOf formularioOrigen Is FrmAltaVentas Then
            'Obtener VENID desde la variable declarada en FrmAltaVentas
            VENID = CType(formularioOrigen, FrmAltaVentas).VENID
        ElseIf TypeOf formularioOrigen Is FrmVentas Then
            'Obtener VENID desde un DataGridView en otro formulario
            If CType(formularioOrigen, FrmVentas).DATAVENTAS.SelectedRows.Count > 0 Then
                VENID = CType(formularioOrigen, FrmVentas).DATAVENTAS.SelectedRows(0).Cells("VENID").Value
            Else
                MessageBox.Show("Selecciona una venta antes de imprimir el ticket.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Else
            MessageBox.Show("El formulario origen no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        'Definir la ruta del reporte
        Dim RUTAREPORTE As String = System.IO.Path.Combine(Application.StartupPath, "RPTTICKETVENTA.rpt")
        If Not System.IO.File.Exists(RUTAREPORTE) Then
            MessageBox.Show("No se encontró el archivo de reporte en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'Crear conexión a SQL Server
        Dim conexion As New SqlConnection("Server=" & SERVIDOR & ";Database=" & BASEDATOS & ";User Id=" & USUARIO & ";Password=" & CONTRASEÑA)
        Dim comando As New SqlCommand("EXEC IMPRIMIRTICKET @VENID", conexion)
        comando.Parameters.AddWithValue("@VENID", VENID)
        Dim adapter As New SqlDataAdapter(comando)
        Dim ds As New DataSet()

        Try
            conexion.Open()
            adapter.Fill(ds, "IMPRIMIRTICKET")
            conexion.Close()
        Catch ex As Exception
            MessageBox.Show("Error al obtener datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        'Cargar el reporte y asignar el DataSet
        Dim MANIFIESTO As New ReportDocument()
        MANIFIESTO.Load(RUTAREPORTE)
        MANIFIESTO.SetDataSource(ds.Tables("IMPRIMIRTICKET"))

        'Mostrar el reporte
        Dim MUESTRA As New FrmReportes()
        MUESTRA.Reportes.ReportSource = MANIFIESTO
        MUESTRA.Reportes.Refresh()
        MUESTRA.ShowDialog()
    End Sub


    Private Sub TxtPago_TextChanged(sender As Object, e As EventArgs) Handles TXTPAGO.TextChanged

        If TXTPAGO.Text < LBLTOTAL.Text Then
            TXTCAMBIO.Text = 0.ToString("C2")
        Else
            Dim cambio As Decimal = (Val(TXTPAGO.Text) - LBLTOTAL.Text).ToString("C2")
            If cambio > 0 Then
                Me.TXTCAMBIO.Text = cambio.ToString("C2")
            Else
                Me.TXTCAMBIO.Text = 0.ToString("C2")
            End If

        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If CMBPRODUCTO.Text = String.Empty Then
            CMBPRODUCTO.Focus()
        ElseIf TxtCantidad.Text = String.Empty Then
            TxtCantidad.Focus()
        ElseIf TxtCantidad.Text < 1 Then
            MsgBox("Agrega al menos un producto", MsgBoxStyle.Exclamation, "Advertencia")
            TxtCantidad.Focus()
        Else
            ' Obtener valores actuales
            Dim cantidad As Integer = Val(Me.TxtCantidad.Text)
            Dim precio As Double = (Me.CMBPRECIO.Text).ToString
            Dim subtotal As Double = cantidad * precio  ' Calcular el subtotal del producto
            Dim productoId As Long = Me.CmbClave.SelectedValue

            ' Verificar si el producto ya existe en el DataGridView
            Dim productoExistente As DataGridViewRow = Nothing
            For Each fila As DataGridViewRow In Me.DtgProductos.Rows
                If Not fila.IsNewRow AndAlso Convert.ToInt64(fila.Cells("PROID").Value) = productoId Then
                    productoExistente = fila
                    Exit For
                End If
            Next

            If productoExistente IsNot Nothing Then
                ' Si el producto ya existe, actualizar la cantidad y el subtotal
                Dim cantidadExistente As Integer = Convert.ToInt32(productoExistente.Cells("PROCANTIDAD").Value)
                Dim nuevaCantidad As Integer = cantidadExistente + cantidad
                productoExistente.Cells("PROCANTIDAD").Value = nuevaCantidad

                ' Actualizar el subtotal
                Dim nuevoSubtotal As Double = nuevaCantidad * precio
                productoExistente.Cells("PROSUBTOTAL").Value = nuevoSubtotal

                ' Actualizar el total acumulado
                ActualizarTotales()
            Else
                ' Si el producto no existe, agregarlo como una nueva fila
                Me.DtgProductos.Rows.Add(productoId, Me.CmbClave.Text, Me.CMBPRODUCTO.Text, cantidad, precio.ToString("c2"), subtotal)

                ' Actualizar el total acumulado
                ActualizarTotales()

            End If

            ' Restablecer valores de los ComboBox y campos
            Me.CmbClave.SelectedValue = 0
            Me.CMBPRECIO.SelectedValue = 0
            Me.CMBPRODUCTO.SelectedValue = 0
            Me.CMBEXISTENCIAS.SelectedValue = 0
            Me.TxtCantidad.Text = String.Empty

            ' Configuración final
            CMBPRODUCTO.Focus()
            LblSubTotal.Text = "Procesando..."
            CMBPRECIO.FormatString = "C2"
            CMBPRECIO.Text = String.Empty
        End If
    End Sub

    ' Método para actualizar el total, subtotal e IVA
    Private Sub ActualizarTotales()
        ' Acumular el subtotal correctamente
        Dim subtotalAcumulado As Double = 0
        For Each fila As DataGridViewRow In Me.DtgProductos.Rows
            If Not fila.IsNewRow Then  ' Evitar filas en blanco
                subtotalAcumulado += Convert.ToDouble(fila.Cells("PROSUBTOTAL").Value)
            End If
        Next

        ' Actualizar las etiquetas con los valores correctos
        Me.LBLSUB.Text = subtotalAcumulado.ToString("C2")

        ' Calcular IVA (solo informativo, pero no se suma al total)
        Dim IVA As Double = Math.Round(0.16 * subtotalAcumulado, 2)
        LBLIVA.Text = IVA.ToString("C2")

        ' El total ahora es igual al subtotal
        LBLTOTAL.Text = subtotalAcumulado.ToString("C2")
    End Sub


    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        If DtgProductos.CurrentRow IsNot Nothing Then
            Dim cantidadProducto As Integer = Convert.ToInt32(DtgProductos.CurrentRow.Cells("PROCANTIDAD").Value)
            If cantidadProducto > 1 Then
                cantidadProducto -= 1
                DtgProductos.CurrentRow.Cells("PROCANTIDAD").Value = cantidadProducto

                Dim precioTexto As String = DtgProductos.CurrentRow.Cells("PROPRECIO").Value.ToString().Replace("$", "").Trim()
                Dim precio As Double = Double.Parse(precioTexto, Globalization.NumberStyles.Currency, Globalization.CultureInfo.CurrentCulture)
                DtgProductos.CurrentRow.Cells("PROSUBTOTAL").Value = cantidadProducto * precio
            Else
                DtgProductos.Rows.Remove(DtgProductos.CurrentRow)
            End If
            ActualizarTotales()
        Else
            MsgBox("Selecciona un producto para quitar", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub


    Private Function IVA(SUBTOTAL As Double) As Double
        Dim RESULTADO As Double
        RESULTADO = SUBTOTAL * 0.16
        Return RESULTADO
    End Function

    Private Sub TXTENGANCHE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTENGANCHE.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTPAGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPAGO.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TXTMESES_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTMESES.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub FrmAltaVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private previousTotal As Double = 0

    Private Sub TXTENGANCHE_TextChanged(sender As Object, e As EventArgs) Handles TXTENGANCHE.TextChanged
        LBLTOTAL.Text = (LBLSUB.Text).ToString
        Dim enganche As Double
        If Double.TryParse(TXTENGANCHE.Text, enganche) Then
            If previousTotal = 0 Then
                previousTotal = Val(LBLTOTAL.Text.Replace("$", "").Replace(",", ""))
            End If

            Dim newTotal As Double = previousTotal - enganche

            If newTotal < 0 Then
                LBLTOTAL.Text = "$0.00"
            Else
                LBLTOTAL.Text = newTotal.ToString("C2")
            End If
        Else
            LBLTOTAL.Text = previousTotal.ToString("C2")
        End If
    End Sub

    Private ultimaTeclaPresionada As DateTime
    Private lecturaCodigoBarras As Boolean = False
    Private lecturaActual As String = ""

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        Dim tiempoEntreTeclas As TimeSpan = DateTime.Now - ultimaTeclaPresionada
        ultimaTeclaPresionada = DateTime.Now

        ' Detectar si el usuario está escribiendo manualmente (intervalo mayor a 200ms)
        If tiempoEntreTeclas.TotalMilliseconds > 200 Then
            lecturaCodigoBarras = False
        Else
            lecturaCodigoBarras = True
        End If

        ' Acumular solo si no estamos leyendo desde el TextBox (aunque ya no se usará)
        If lecturaCodigoBarras Then
            lecturaActual &= ChrW(msg.WParam.ToInt32())
        End If

        ' Procesar al presionar Enter
        If keyData = Keys.Enter AndAlso lecturaCodigoBarras Then
            ' Leer directamente el texto completo del textbox
            Dim codigoLeido As String = TXTCODIGOBARRAS.Text.Trim()

            ' Filtrar caracteres no alfanuméricos
            codigoLeido = System.Text.RegularExpressions.Regex.Replace(codigoLeido, "[^a-zA-Z0-9]", "")

            If codigoLeido.Length > 0 Then
                ' Buscar en la tabla
                Dim tablaProductos As DataTable = CType(CType(CMBPRODUCTO.DataSource, BindingSource).DataSource, DataTable)
                Dim filtro As String = $"PROCLAVE = '{codigoLeido.Replace("'", "''")}'"
                Dim resultado() As DataRow = tablaProductos.Select(filtro)

                If resultado.Length > 0 Then
                    Dim proId As Integer = Convert.ToInt32(resultado(0)("PROID"))
                    CmbClave.SelectedValue = proId
                    CMBPRODUCTO.SelectedValue = proId
                    CMBPRECIO.SelectedValue = proId

                    TxtCantidad.Text = "1"
                    BtnAgregar.PerformClick()
                Else
                    MessageBox.Show("Producto no encontrado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If

                ' Limpiar
                TXTCODIGOBARRAS.Clear()
                TXTCODIGOBARRAS.Focus()
                lecturaActual = ""
                lecturaCodigoBarras = False
                Return True
            End If
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub RBTDEBITO_CheckedChanged(sender As Object, e As EventArgs) Handles RBTDEBITO.CheckedChanged
        RBCONTADO_CheckedChanged(sender, e)
    End Sub
    Private Sub RBTCREDITO_CheckedChanged(sender As Object, e As EventArgs) Handles RBTCREDITO.CheckedChanged
        RBCONTADO_CheckedChanged(sender, e)
    End Sub

End Class