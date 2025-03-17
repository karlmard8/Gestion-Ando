<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.DATAVENTAS = New System.Windows.Forms.DataGridView()
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNREPORTE = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.VISTAVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.VISTAVENTASTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTAVENTASTableAdapter()
        Me.VENFECHA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUNOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENFORMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VENID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEXISTE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VENEXISTE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DATAVENTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(656, 855)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNELIMINAR.TabIndex = 5
        Me.BTNELIMINAR.Text = "Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = False
        '
        'DATAVENTAS
        '
        Me.DATAVENTAS.AllowUserToAddRows = False
        Me.DATAVENTAS.AllowUserToDeleteRows = False
        Me.DATAVENTAS.AutoGenerateColumns = False
        Me.DATAVENTAS.BackgroundColor = System.Drawing.Color.White
        Me.DATAVENTAS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DATAVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAVENTAS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VENFECHA, Me.CLIENTE, Me.USUNOMBRE, Me.VENFORMA, Me.VENTOTAL, Me.VENID, Me.CLIEXISTE, Me.VENEXISTE})
        Me.DATAVENTAS.DataSource = Me.VISTAVENTASBindingSource
        Me.DATAVENTAS.GridColor = System.Drawing.SystemColors.Control
        Me.DATAVENTAS.Location = New System.Drawing.Point(12, 92)
        Me.DATAVENTAS.Name = "DATAVENTAS"
        Me.DATAVENTAS.ReadOnly = True
        Me.DATAVENTAS.RowHeadersVisible = False
        Me.DATAVENTAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATAVENTAS.Size = New System.Drawing.Size(776, 720)
        Me.DATAVENTAS.TabIndex = 4
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBUSCAR.Location = New System.Drawing.Point(115, 28)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(385, 22)
        Me.TXTBUSCAR.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 27)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 53)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.AutoSize = True
        Me.BTNREPORTE.BackColor = System.Drawing.Color.White
        Me.BTNREPORTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTE.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.Location = New System.Drawing.Point(655, 41)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(133, 45)
        Me.BTNREPORTE.TabIndex = 18
        Me.BTNREPORTE.Text = "Generar reporte"
        Me.BTNREPORTE.UseVisualStyleBackColor = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(456, 855)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(132, 54)
        Me.BTNNUEVO.TabIndex = 19
        Me.BTNNUEVO.Text = "Nuevo"
        Me.BTNNUEVO.UseVisualStyleBackColor = False
        '
        'VISTAVENTASBindingSource
        '
        Me.VISTAVENTASBindingSource.DataMember = "VISTAVENTAS"
        Me.VISTAVENTASBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VISTAVENTASTableAdapter
        '
        Me.VISTAVENTASTableAdapter.ClearBeforeFill = True
        '
        'VENFECHA
        '
        Me.VENFECHA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VENFECHA.DataPropertyName = "VENFECHA"
        Me.VENFECHA.HeaderText = "Fecha"
        Me.VENFECHA.Name = "VENFECHA"
        Me.VENFECHA.ReadOnly = True
        Me.VENFECHA.Width = 62
        '
        'CLIENTE
        '
        Me.CLIENTE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLIENTE.DataPropertyName = "CLIENTE"
        Me.CLIENTE.HeaderText = "Cliente"
        Me.CLIENTE.Name = "CLIENTE"
        Me.CLIENTE.ReadOnly = True
        '
        'USUNOMBRE
        '
        Me.USUNOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.USUNOMBRE.DataPropertyName = "USUNOMBRE"
        Me.USUNOMBRE.HeaderText = "Vendedor"
        Me.USUNOMBRE.Name = "USUNOMBRE"
        Me.USUNOMBRE.ReadOnly = True
        Me.USUNOMBRE.Width = 78
        '
        'VENFORMA
        '
        Me.VENFORMA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VENFORMA.DataPropertyName = "VENFORMA"
        Me.VENFORMA.HeaderText = "Venta"
        Me.VENFORMA.Name = "VENFORMA"
        Me.VENFORMA.ReadOnly = True
        Me.VENFORMA.Width = 60
        '
        'VENTOTAL
        '
        Me.VENTOTAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.VENTOTAL.DataPropertyName = "VENTOTAL"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.VENTOTAL.DefaultCellStyle = DataGridViewCellStyle1
        Me.VENTOTAL.HeaderText = "Total"
        Me.VENTOTAL.Name = "VENTOTAL"
        Me.VENTOTAL.ReadOnly = True
        Me.VENTOTAL.Width = 56
        '
        'VENID
        '
        Me.VENID.DataPropertyName = "VENID"
        Me.VENID.HeaderText = "VENID"
        Me.VENID.Name = "VENID"
        Me.VENID.ReadOnly = True
        Me.VENID.Visible = False
        '
        'CLIEXISTE
        '
        Me.CLIEXISTE.DataPropertyName = "CLIEXISTE"
        Me.CLIEXISTE.HeaderText = "CLIEXISTE"
        Me.CLIEXISTE.Name = "CLIEXISTE"
        Me.CLIEXISTE.ReadOnly = True
        Me.CLIEXISTE.Visible = False
        '
        'VENEXISTE
        '
        Me.VENEXISTE.DataPropertyName = "VENEXISTE"
        Me.VENEXISTE.HeaderText = "VENEXISTE"
        Me.VENEXISTE.Name = "VENEXISTE"
        Me.VENEXISTE.ReadOnly = True
        Me.VENEXISTE.Visible = False
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 930)
        Me.Controls.Add(Me.BTNNUEVO)
        Me.Controls.Add(Me.BTNREPORTE)
        Me.Controls.Add(Me.TXTBUSCAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.DATAVENTAS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmVentas"
        Me.Text = "FrmVentas"
        CType(Me.DATAVENTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNELIMINAR As Button
    Friend WithEvents DATAVENTAS As DataGridView
    Friend WithEvents TXTBUSCAR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNREPORTE As Button
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents VISTAVENTASBindingSource As BindingSource
    Friend WithEvents VISTAVENTASTableAdapter As MuebleAlexDataSetTableAdapters.VISTAVENTASTableAdapter
    Friend WithEvents BTNNUEVO As Button
    Friend WithEvents VENFECHA As DataGridViewTextBoxColumn
    Friend WithEvents CLIENTE As DataGridViewTextBoxColumn
    Friend WithEvents USUNOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents VENFORMA As DataGridViewTextBoxColumn
    Friend WithEvents VENTOTAL As DataGridViewTextBoxColumn
    Friend WithEvents VENID As DataGridViewTextBoxColumn
    Friend WithEvents CLIEXISTE As DataGridViewCheckBoxColumn
    Friend WithEvents VENEXISTE As DataGridViewCheckBoxColumn
End Class
