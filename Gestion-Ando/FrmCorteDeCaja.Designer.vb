<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCorteDeCaja
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DATACORTECAJA = New System.Windows.Forms.DataGridView()
        Me.VISTACORTECAJABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMBUSUARIO = New System.Windows.Forms.ComboBox()
        Me.VISTAUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTNABRIRCAJA = New System.Windows.Forms.Button()
        Me.BTNCERRARCAJA = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBLSALDOINICIAL = New System.Windows.Forms.Label()
        Me.LBLINGRESOS = New System.Windows.Forms.Label()
        Me.LBLEGRESOS = New System.Windows.Forms.Label()
        Me.LBLSALDOFINAL = New System.Windows.Forms.Label()
        Me.VISTAUSUARIOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTAUSUARIOSTableAdapter()
        Me.VISTACORTECAJATableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTACORTECAJATableAdapter()
        Me.No_Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Venta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DATACORTECAJA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTACORTECAJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DATACORTECAJA
        '
        Me.DATACORTECAJA.AllowUserToAddRows = False
        Me.DATACORTECAJA.AllowUserToDeleteRows = False
        Me.DATACORTECAJA.AllowUserToResizeColumns = False
        Me.DATACORTECAJA.AllowUserToResizeRows = False
        Me.DATACORTECAJA.AutoGenerateColumns = False
        Me.DATACORTECAJA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DATACORTECAJA.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DATACORTECAJA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DATACORTECAJA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATACORTECAJA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No_Venta, Me.Fecha, Me.Venta, Me.Vendedor, Me.Total})
        Me.DATACORTECAJA.DataSource = Me.VISTACORTECAJABindingSource
        Me.DATACORTECAJA.Location = New System.Drawing.Point(12, 85)
        Me.DATACORTECAJA.MultiSelect = False
        Me.DATACORTECAJA.Name = "DATACORTECAJA"
        Me.DATACORTECAJA.ReadOnly = True
        Me.DATACORTECAJA.RowHeadersVisible = False
        Me.DATACORTECAJA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATACORTECAJA.Size = New System.Drawing.Size(776, 230)
        Me.DATACORTECAJA.TabIndex = 0
        Me.DATACORTECAJA.TabStop = False
        '
        'VISTACORTECAJABindingSource
        '
        Me.VISTACORTECAJABindingSource.DataMember = "VISTACORTECAJA"
        Me.VISTACORTECAJABindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Corte de caja de:"
        '
        'CMBUSUARIO
        '
        Me.CMBUSUARIO.DataSource = Me.VISTAUSUARIOSBindingSource
        Me.CMBUSUARIO.DisplayMember = "USUNOMBRE"
        Me.CMBUSUARIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBUSUARIO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBUSUARIO.FormattingEnabled = True
        Me.CMBUSUARIO.Location = New System.Drawing.Point(144, 12)
        Me.CMBUSUARIO.Name = "CMBUSUARIO"
        Me.CMBUSUARIO.Size = New System.Drawing.Size(339, 35)
        Me.CMBUSUARIO.TabIndex = 2
        Me.CMBUSUARIO.ValueMember = "USUID"
        '
        'VISTAUSUARIOSBindingSource
        '
        Me.VISTAUSUARIOSBindingSource.DataMember = "VISTAUSUARIOS"
        Me.VISTAUSUARIOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'BTNABRIRCAJA
        '
        Me.BTNABRIRCAJA.AutoSize = True
        Me.BTNABRIRCAJA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNABRIRCAJA.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNABRIRCAJA.Location = New System.Drawing.Point(542, 12)
        Me.BTNABRIRCAJA.Name = "BTNABRIRCAJA"
        Me.BTNABRIRCAJA.Size = New System.Drawing.Size(112, 37)
        Me.BTNABRIRCAJA.TabIndex = 3
        Me.BTNABRIRCAJA.Text = "Abrir caja"
        Me.BTNABRIRCAJA.UseVisualStyleBackColor = True
        '
        'BTNCERRARCAJA
        '
        Me.BTNCERRARCAJA.AutoSize = True
        Me.BTNCERRARCAJA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCERRARCAJA.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCERRARCAJA.Location = New System.Drawing.Point(676, 12)
        Me.BTNCERRARCAJA.Name = "BTNCERRARCAJA"
        Me.BTNCERRARCAJA.Size = New System.Drawing.Size(112, 37)
        Me.BTNCERRARCAJA.TabIndex = 4
        Me.BTNCERRARCAJA.Text = "Corte de caja"
        Me.BTNCERRARCAJA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 358)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 27)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Saldo de caja inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 358)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ingresos del día"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(458, 358)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Egresos del día"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(651, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Saldo de caja final"
        '
        'LBLSALDOINICIAL
        '
        Me.LBLSALDOINICIAL.AutoSize = True
        Me.LBLSALDOINICIAL.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSALDOINICIAL.Location = New System.Drawing.Point(67, 397)
        Me.LBLSALDOINICIAL.Name = "LBLSALDOINICIAL"
        Me.LBLSALDOINICIAL.Size = New System.Drawing.Size(29, 27)
        Me.LBLSALDOINICIAL.TabIndex = 9
        Me.LBLSALDOINICIAL.Text = ". . ."
        '
        'LBLINGRESOS
        '
        Me.LBLINGRESOS.AutoSize = True
        Me.LBLINGRESOS.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLINGRESOS.Location = New System.Drawing.Point(285, 397)
        Me.LBLINGRESOS.Name = "LBLINGRESOS"
        Me.LBLINGRESOS.Size = New System.Drawing.Size(29, 27)
        Me.LBLINGRESOS.TabIndex = 10
        Me.LBLINGRESOS.Text = ". . ."
        '
        'LBLEGRESOS
        '
        Me.LBLEGRESOS.AutoSize = True
        Me.LBLEGRESOS.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEGRESOS.Location = New System.Drawing.Point(496, 397)
        Me.LBLEGRESOS.Name = "LBLEGRESOS"
        Me.LBLEGRESOS.Size = New System.Drawing.Size(29, 27)
        Me.LBLEGRESOS.TabIndex = 11
        Me.LBLEGRESOS.Text = ". . ."
        '
        'LBLSALDOFINAL
        '
        Me.LBLSALDOFINAL.AutoSize = True
        Me.LBLSALDOFINAL.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSALDOFINAL.Location = New System.Drawing.Point(706, 397)
        Me.LBLSALDOFINAL.Name = "LBLSALDOFINAL"
        Me.LBLSALDOFINAL.Size = New System.Drawing.Size(29, 27)
        Me.LBLSALDOFINAL.TabIndex = 12
        Me.LBLSALDOFINAL.Text = ". . ."
        '
        'VISTAUSUARIOSTableAdapter
        '
        Me.VISTAUSUARIOSTableAdapter.ClearBeforeFill = True
        '
        'VISTACORTECAJATableAdapter
        '
        Me.VISTACORTECAJATableAdapter.ClearBeforeFill = True
        '
        'No_Venta
        '
        Me.No_Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.No_Venta.DataPropertyName = "No_Venta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.No_Venta.DefaultCellStyle = DataGridViewCellStyle3
        Me.No_Venta.HeaderText = "No.Venta"
        Me.No_Venta.Name = "No_Venta"
        Me.No_Venta.ReadOnly = True
        Me.No_Venta.Width = 77
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
        'Venta
        '
        Me.Venta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Venta.DataPropertyName = "Venta"
        Me.Venta.HeaderText = "Venta"
        Me.Venta.Name = "Venta"
        Me.Venta.ReadOnly = True
        Me.Venta.Width = 60
        '
        'Vendedor
        '
        Me.Vendedor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Vendedor.DataPropertyName = "Vendedor"
        Me.Vendedor.HeaderText = "Vendedor"
        Me.Vendedor.Name = "Vendedor"
        Me.Vendedor.ReadOnly = True
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Total.DataPropertyName = "Total"
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle4
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 56
        '
        'FrmCorteDeCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBLSALDOFINAL)
        Me.Controls.Add(Me.LBLEGRESOS)
        Me.Controls.Add(Me.LBLINGRESOS)
        Me.Controls.Add(Me.LBLSALDOINICIAL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNCERRARCAJA)
        Me.Controls.Add(Me.BTNABRIRCAJA)
        Me.Controls.Add(Me.CMBUSUARIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DATACORTECAJA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmCorteDeCaja"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Corte de caja"
        CType(Me.DATACORTECAJA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTACORTECAJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DATACORTECAJA As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBUSUARIO As ComboBox
    Friend WithEvents BTNABRIRCAJA As Button
    Friend WithEvents BTNCERRARCAJA As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBLSALDOINICIAL As Label
    Friend WithEvents LBLINGRESOS As Label
    Friend WithEvents LBLEGRESOS As Label
    Friend WithEvents LBLSALDOFINAL As Label
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents VISTAUSUARIOSBindingSource As BindingSource
    Friend WithEvents VISTAUSUARIOSTableAdapter As MuebleAlexDataSetTableAdapters.VISTAUSUARIOSTableAdapter
    Friend WithEvents VISTACORTECAJABindingSource As BindingSource
    Friend WithEvents VISTACORTECAJATableAdapter As MuebleAlexDataSetTableAdapters.VISTACORTECAJATableAdapter
    Friend WithEvents NoVenta As DataGridViewTextBoxColumn
    Friend WithEvents No_Venta As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Venta As DataGridViewTextBoxColumn
    Friend WithEvents Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
End Class
