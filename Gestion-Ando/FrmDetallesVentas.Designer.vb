﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetallesVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DATADETALLEVENTA = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semanas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enganche = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VISTADETALLEVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.VISTADETALLEVENTASTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTADETALLEVENTASTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DATAPAGOS = New System.Windows.Forms.DataGridView()
        Me.PAGID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PAGAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLESDEPAGOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTNABONO = New System.Windows.Forms.Button()
        Me.DETALLESDEPAGOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.DETALLESDEPAGOSTableAdapter()
        CType(Me.DATADETALLEVENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTADETALLEVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DATAPAGOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DETALLESDEPAGOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DATADETALLEVENTA
        '
        Me.DATADETALLEVENTA.AllowUserToAddRows = False
        Me.DATADETALLEVENTA.AllowUserToDeleteRows = False
        Me.DATADETALLEVENTA.AllowUserToResizeColumns = False
        Me.DATADETALLEVENTA.AllowUserToResizeRows = False
        Me.DATADETALLEVENTA.AutoGenerateColumns = False
        Me.DATADETALLEVENTA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATADETALLEVENTA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DATADETALLEVENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATADETALLEVENTA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Unidades, Me.PrecioUnitario, Me.Semanas, Me.Enganche, Me.Total})
        Me.DATADETALLEVENTA.DataSource = Me.VISTADETALLEVENTASBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DATADETALLEVENTA.DefaultCellStyle = DataGridViewCellStyle7
        Me.DATADETALLEVENTA.Location = New System.Drawing.Point(0, 45)
        Me.DATADETALLEVENTA.MultiSelect = False
        Me.DATADETALLEVENTA.Name = "DATADETALLEVENTA"
        Me.DATADETALLEVENTA.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATADETALLEVENTA.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DATADETALLEVENTA.RowHeadersVisible = False
        Me.DATADETALLEVENTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATADETALLEVENTA.Size = New System.Drawing.Size(904, 250)
        Me.DATADETALLEVENTA.TabIndex = 0
        Me.DATADETALLEVENTA.TabStop = False
        '
        'Producto
        '
        Me.Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Producto.DataPropertyName = "Producto"
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        '
        'Unidades
        '
        Me.Unidades.DataPropertyName = "Unidades"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Unidades.DefaultCellStyle = DataGridViewCellStyle2
        Me.Unidades.HeaderText = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.ReadOnly = True
        Me.Unidades.Width = 70
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PrecioUnitario.DataPropertyName = "Precio unitario"
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PrecioUnitario.DefaultCellStyle = DataGridViewCellStyle3
        Me.PrecioUnitario.HeaderText = "Precio unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        Me.PrecioUnitario.Width = 99
        '
        'Semanas
        '
        Me.Semanas.DataPropertyName = "Semanas"
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Semanas.DefaultCellStyle = DataGridViewCellStyle4
        Me.Semanas.HeaderText = "Semanas"
        Me.Semanas.Name = "Semanas"
        Me.Semanas.ReadOnly = True
        Me.Semanas.Width = 65
        '
        'Enganche
        '
        Me.Enganche.DataPropertyName = "Enganche"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.Enganche.DefaultCellStyle = DataGridViewCellStyle5
        Me.Enganche.HeaderText = "Enganche"
        Me.Enganche.Name = "Enganche"
        Me.Enganche.ReadOnly = True
        Me.Enganche.Width = 80
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle6
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 80
        '
        'VISTADETALLEVENTASBindingSource
        '
        Me.VISTADETALLEVENTASBindingSource.DataMember = "VISTADETALLEVENTAS"
        Me.VISTADETALLEVENTASBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VISTADETALLEVENTASTableAdapter
        '
        Me.VISTADETALLEVENTASTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Detalles de venta"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 44)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Detalles de pagos"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(904, 44)
        Me.Panel2.TabIndex = 4
        '
        'DATAPAGOS
        '
        Me.DATAPAGOS.AllowUserToAddRows = False
        Me.DATAPAGOS.AllowUserToDeleteRows = False
        Me.DATAPAGOS.AllowUserToResizeColumns = False
        Me.DATAPAGOS.AllowUserToResizeRows = False
        Me.DATAPAGOS.AutoGenerateColumns = False
        Me.DATAPAGOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATAPAGOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DATAPAGOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAPAGOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PAGID, Me.VENID, Me.Fecha, Me.Cliente, Me.PAGAR, Me.Pagado})
        Me.DATAPAGOS.DataSource = Me.DETALLESDEPAGOSBindingSource
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DATAPAGOS.DefaultCellStyle = DataGridViewCellStyle11
        Me.DATAPAGOS.Location = New System.Drawing.Point(0, 342)
        Me.DATAPAGOS.MultiSelect = False
        Me.DATAPAGOS.Name = "DATAPAGOS"
        Me.DATAPAGOS.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATAPAGOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DATAPAGOS.RowHeadersVisible = False
        Me.DATAPAGOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATAPAGOS.Size = New System.Drawing.Size(904, 250)
        Me.DATAPAGOS.TabIndex = 5
        Me.DATAPAGOS.TabStop = False
        '
        'PAGID
        '
        Me.PAGID.DataPropertyName = "PAGID"
        Me.PAGID.HeaderText = "PAGID"
        Me.PAGID.Name = "PAGID"
        Me.PAGID.ReadOnly = True
        Me.PAGID.Visible = False
        '
        'VENID
        '
        Me.VENID.DataPropertyName = "VENID"
        Me.VENID.HeaderText = "VENID"
        Me.VENID.Name = "VENID"
        Me.VENID.ReadOnly = True
        Me.VENID.Visible = False
        '
        'Fecha
        '
        Me.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        Me.Fecha.Width = 62
        '
        'Cliente
        '
        Me.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        Me.Cliente.ReadOnly = True
        '
        'PAGAR
        '
        Me.PAGAR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PAGAR.DataPropertyName = "A pagar"
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.PAGAR.DefaultCellStyle = DataGridViewCellStyle10
        Me.PAGAR.HeaderText = "A pagar"
        Me.PAGAR.Name = "PAGAR"
        Me.PAGAR.ReadOnly = True
        Me.PAGAR.Width = 69
        '
        'Pagado
        '
        Me.Pagado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Pagado.DataPropertyName = "Pagado"
        Me.Pagado.HeaderText = "Pagado"
        Me.Pagado.Name = "Pagado"
        Me.Pagado.ReadOnly = True
        Me.Pagado.Width = 69
        '
        'DETALLESDEPAGOSBindingSource
        '
        Me.DETALLESDEPAGOSBindingSource.DataMember = "DETALLESDEPAGOS"
        Me.DETALLESDEPAGOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'BTNABONO
        '
        Me.BTNABONO.AutoSize = True
        Me.BTNABONO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNABONO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNABONO.Location = New System.Drawing.Point(760, 605)
        Me.BTNABONO.Name = "BTNABONO"
        Me.BTNABONO.Size = New System.Drawing.Size(132, 54)
        Me.BTNABONO.TabIndex = 6
        Me.BTNABONO.Text = "Abonar"
        Me.BTNABONO.UseVisualStyleBackColor = True
        '
        'DETALLESDEPAGOSTableAdapter
        '
        Me.DETALLESDEPAGOSTableAdapter.ClearBeforeFill = True
        '
        'FrmDetallesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 671)
        Me.Controls.Add(Me.BTNABONO)
        Me.Controls.Add(Me.DATAPAGOS)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DATADETALLEVENTA)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetallesVentas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de venta y pagos"
        CType(Me.DATADETALLEVENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTADETALLEVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DATAPAGOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DETALLESDEPAGOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DATADETALLEVENTA As DataGridView
    Friend WithEvents VISTADETALLEVENTASBindingSource As BindingSource
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents VISTADETALLEVENTASTableAdapter As MuebleAlexDataSetTableAdapters.VISTADETALLEVENTASTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DATAPAGOS As DataGridView
    Friend WithEvents BTNABONO As Button
    Friend WithEvents DETALLESDEPAGOSBindingSource As BindingSource
    Friend WithEvents DETALLESDEPAGOSTableAdapter As MuebleAlexDataSetTableAdapters.DETALLESDEPAGOSTableAdapter
    Friend WithEvents PAGID As DataGridViewTextBoxColumn
    Friend WithEvents VENID As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents PAGAR As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Unidades As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Semanas As DataGridViewTextBoxColumn
    Friend WithEvents Enganche As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
