<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BTNABONO = New System.Windows.Forms.Button()
        Me.DETALLESDEPAGOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DETALLESDEPAGOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.DETALLESDEPAGOSTableAdapter()
        Me.PAGIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APagar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagado = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.DATADETALLEVENTA.AutoGenerateColumns = False
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATADETALLEVENTA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DATADETALLEVENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATADETALLEVENTA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Unidades, Me.PrecioUnitario, Me.Semanas, Me.Enganche, Me.Total})
        Me.DATADETALLEVENTA.DataSource = Me.VISTADETALLEVENTASBindingSource
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DATADETALLEVENTA.DefaultCellStyle = DataGridViewCellStyle18
        Me.DATADETALLEVENTA.Location = New System.Drawing.Point(0, 45)
        Me.DATADETALLEVENTA.MultiSelect = False
        Me.DATADETALLEVENTA.Name = "DATADETALLEVENTA"
        Me.DATADETALLEVENTA.ReadOnly = True
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATADETALLEVENTA.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.DATADETALLEVENTA.RowHeadersVisible = False
        Me.DATADETALLEVENTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATADETALLEVENTA.Size = New System.Drawing.Size(799, 198)
        Me.DATADETALLEVENTA.TabIndex = 0
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
        DataGridViewCellStyle13.Format = "N2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.Unidades.DefaultCellStyle = DataGridViewCellStyle13
        Me.Unidades.HeaderText = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.ReadOnly = True
        Me.Unidades.Width = 70
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.DataPropertyName = "Precio unitario"
        DataGridViewCellStyle14.Format = "C2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.PrecioUnitario.DefaultCellStyle = DataGridViewCellStyle14
        Me.PrecioUnitario.HeaderText = "Precio unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        '
        'Semanas
        '
        Me.Semanas.DataPropertyName = "Semanas"
        DataGridViewCellStyle15.Format = "N0"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.Semanas.DefaultCellStyle = DataGridViewCellStyle15
        Me.Semanas.HeaderText = "Semanas"
        Me.Semanas.Name = "Semanas"
        Me.Semanas.ReadOnly = True
        Me.Semanas.Width = 65
        '
        'Enganche
        '
        Me.Enganche.DataPropertyName = "Enganche"
        DataGridViewCellStyle16.Format = "C2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.Enganche.DefaultCellStyle = DataGridViewCellStyle16
        Me.Enganche.HeaderText = "Enganche"
        Me.Enganche.Name = "Enganche"
        Me.Enganche.ReadOnly = True
        Me.Enganche.Width = 80
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle17.Format = "C2"
        DataGridViewCellStyle17.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle17
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
        Me.Panel1.Size = New System.Drawing.Size(799, 44)
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
        Me.Panel2.Location = New System.Drawing.Point(0, 246)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 44)
        Me.Panel2.TabIndex = 4
        '
        'DATAPAGOS
        '
        Me.DATAPAGOS.AllowUserToAddRows = False
        Me.DATAPAGOS.AllowUserToDeleteRows = False
        Me.DATAPAGOS.AutoGenerateColumns = False
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATAPAGOS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DATAPAGOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAPAGOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PAGIDDataGridViewTextBoxColumn, Me.VENID, Me.Fecha, Me.Cliente, Me.APagar, Me.Pagado})
        Me.DATAPAGOS.DataSource = Me.DETALLESDEPAGOSBindingSource
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DATAPAGOS.DefaultCellStyle = DataGridViewCellStyle21
        Me.DATAPAGOS.Location = New System.Drawing.Point(0, 292)
        Me.DATAPAGOS.Name = "DATAPAGOS"
        Me.DATAPAGOS.ReadOnly = True
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATAPAGOS.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DATAPAGOS.RowHeadersVisible = False
        Me.DATAPAGOS.Size = New System.Drawing.Size(799, 198)
        Me.DATAPAGOS.TabIndex = 5
        '
        'BTNABONO
        '
        Me.BTNABONO.AutoSize = True
        Me.BTNABONO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNABONO.Location = New System.Drawing.Point(667, 528)
        Me.BTNABONO.Name = "BTNABONO"
        Me.BTNABONO.Size = New System.Drawing.Size(132, 54)
        Me.BTNABONO.TabIndex = 6
        Me.BTNABONO.Text = "Abonar"
        Me.BTNABONO.UseVisualStyleBackColor = True
        '
        'DETALLESDEPAGOSBindingSource
        '
        Me.DETALLESDEPAGOSBindingSource.DataMember = "DETALLESDEPAGOS"
        Me.DETALLESDEPAGOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'DETALLESDEPAGOSTableAdapter
        '
        Me.DETALLESDEPAGOSTableAdapter.ClearBeforeFill = True
        '
        'PAGIDDataGridViewTextBoxColumn
        '
        Me.PAGIDDataGridViewTextBoxColumn.DataPropertyName = "PAGID"
        Me.PAGIDDataGridViewTextBoxColumn.HeaderText = "PAGID"
        Me.PAGIDDataGridViewTextBoxColumn.Name = "PAGIDDataGridViewTextBoxColumn"
        Me.PAGIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.PAGIDDataGridViewTextBoxColumn.Visible = False
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
        'APagar
        '
        Me.APagar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.APagar.DataPropertyName = "A pagar"
        Me.APagar.HeaderText = "A pagar"
        Me.APagar.Name = "APagar"
        Me.APagar.ReadOnly = True
        Me.APagar.Width = 69
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
        'FrmDetallesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 594)
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
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Unidades As DataGridViewTextBoxColumn
    Friend WithEvents PrecioUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Semanas As DataGridViewTextBoxColumn
    Friend WithEvents Enganche As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DATAPAGOS As DataGridView
    Friend WithEvents BTNABONO As Button
    Friend WithEvents DETALLESDEPAGOSBindingSource As BindingSource
    Friend WithEvents DETALLESDEPAGOSTableAdapter As MuebleAlexDataSetTableAdapters.DETALLESDEPAGOSTableAdapter
    Friend WithEvents PAGIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VENID As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents APagar As DataGridViewTextBoxColumn
    Friend WithEvents Pagado As DataGridViewTextBoxColumn
End Class
