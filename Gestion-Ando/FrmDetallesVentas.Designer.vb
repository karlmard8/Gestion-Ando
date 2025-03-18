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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DATADETALLEVENTA = New System.Windows.Forms.DataGridView()
        Me.VISTADETALLEVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.VISTADETALLEVENTASTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTADETALLEVENTASTableAdapter()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unidades = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUnitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semanas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Enganche = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DATADETALLEVENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTADETALLEVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DATADETALLEVENTA
        '
        Me.DATADETALLEVENTA.AllowUserToAddRows = False
        Me.DATADETALLEVENTA.AllowUserToDeleteRows = False
        Me.DATADETALLEVENTA.AutoGenerateColumns = False
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATADETALLEVENTA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.DATADETALLEVENTA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATADETALLEVENTA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Unidades, Me.PrecioUnitario, Me.Semanas, Me.Enganche, Me.Total})
        Me.DATADETALLEVENTA.DataSource = Me.VISTADETALLEVENTASBindingSource
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DATADETALLEVENTA.DefaultCellStyle = DataGridViewCellStyle23
        Me.DATADETALLEVENTA.Location = New System.Drawing.Point(1, 0)
        Me.DATADETALLEVENTA.MultiSelect = False
        Me.DATADETALLEVENTA.Name = "DATADETALLEVENTA"
        Me.DATADETALLEVENTA.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATADETALLEVENTA.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DATADETALLEVENTA.RowHeadersVisible = False
        Me.DATADETALLEVENTA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATADETALLEVENTA.Size = New System.Drawing.Size(799, 269)
        Me.DATADETALLEVENTA.TabIndex = 0
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
        DataGridViewCellStyle18.Format = "N2"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.Unidades.DefaultCellStyle = DataGridViewCellStyle18
        Me.Unidades.HeaderText = "Unidades"
        Me.Unidades.Name = "Unidades"
        Me.Unidades.ReadOnly = True
        Me.Unidades.Width = 70
        '
        'PrecioUnitario
        '
        Me.PrecioUnitario.DataPropertyName = "Precio unitario"
        DataGridViewCellStyle19.Format = "C2"
        DataGridViewCellStyle19.NullValue = Nothing
        Me.PrecioUnitario.DefaultCellStyle = DataGridViewCellStyle19
        Me.PrecioUnitario.HeaderText = "Precio unitario"
        Me.PrecioUnitario.Name = "PrecioUnitario"
        Me.PrecioUnitario.ReadOnly = True
        '
        'Semanas
        '
        Me.Semanas.DataPropertyName = "Semanas"
        DataGridViewCellStyle20.Format = "N0"
        DataGridViewCellStyle20.NullValue = Nothing
        Me.Semanas.DefaultCellStyle = DataGridViewCellStyle20
        Me.Semanas.HeaderText = "Semanas"
        Me.Semanas.Name = "Semanas"
        Me.Semanas.ReadOnly = True
        Me.Semanas.Width = 65
        '
        'Enganche
        '
        Me.Enganche.DataPropertyName = "Enganche"
        DataGridViewCellStyle21.Format = "C2"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.Enganche.DefaultCellStyle = DataGridViewCellStyle21
        Me.Enganche.HeaderText = "Enganche"
        Me.Enganche.Name = "Enganche"
        Me.Enganche.ReadOnly = True
        Me.Enganche.Width = 80
        '
        'Total
        '
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle22.Format = "C2"
        DataGridViewCellStyle22.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle22
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 80
        '
        'FrmDetallesVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 270)
        Me.Controls.Add(Me.DATADETALLEVENTA)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetallesVentas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de venta"
        CType(Me.DATADETALLEVENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTADETALLEVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
