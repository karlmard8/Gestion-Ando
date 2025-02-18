<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventario
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.TBLPRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLPRODUCTOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.TBLPRODUCTOSTableAdapter()
        Me.PROID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCLAVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRONOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROEXISTENCIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROPRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROEXISTED = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROID, Me.PROCLAVE, Me.PRONOMBRE, Me.PROEXISTENCIAS, Me.PROPRECIO, Me.PROEXISTED})
        Me.DataGridView1.DataSource = Me.TBLPRODUCTOSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1830, 720)
        Me.DataGridView1.TabIndex = 0
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDITAR.Location = New System.Drawing.Point(1509, 855)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNEDITAR.TabIndex = 6
        Me.BTNEDITAR.Text = "Editar"
        Me.BTNEDITAR.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(1310, 855)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(132, 54)
        Me.BTNNUEVO.TabIndex = 5
        Me.BTNNUEVO.Text = "Nuevo"
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(1710, 855)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNELIMINAR.TabIndex = 4
        Me.BTNELIMINAR.Text = "Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = True
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLPRODUCTOSBindingSource
        '
        Me.TBLPRODUCTOSBindingSource.DataMember = "TBLPRODUCTOS"
        Me.TBLPRODUCTOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'TBLPRODUCTOSTableAdapter
        '
        Me.TBLPRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'PROID
        '
        Me.PROID.DataPropertyName = "PROID"
        Me.PROID.HeaderText = "PROID"
        Me.PROID.Name = "PROID"
        Me.PROID.ReadOnly = True
        Me.PROID.Visible = False
        '
        'PROCLAVE
        '
        Me.PROCLAVE.DataPropertyName = "PROCLAVE"
        Me.PROCLAVE.HeaderText = "Clave"
        Me.PROCLAVE.Name = "PROCLAVE"
        Me.PROCLAVE.ReadOnly = True
        '
        'PRONOMBRE
        '
        Me.PRONOMBRE.DataPropertyName = "PRONOMBRE"
        Me.PRONOMBRE.HeaderText = "Nombre"
        Me.PRONOMBRE.Name = "PRONOMBRE"
        Me.PRONOMBRE.ReadOnly = True
        Me.PRONOMBRE.Width = 1527
        '
        'PROEXISTENCIAS
        '
        Me.PROEXISTENCIAS.DataPropertyName = "PROEXISTENCIAS"
        Me.PROEXISTENCIAS.HeaderText = "Existencias"
        Me.PROEXISTENCIAS.Name = "PROEXISTENCIAS"
        Me.PROEXISTENCIAS.ReadOnly = True
        '
        'PROPRECIO
        '
        Me.PROPRECIO.DataPropertyName = "PROPRECIO"
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.PROPRECIO.DefaultCellStyle = DataGridViewCellStyle5
        Me.PROPRECIO.HeaderText = "Precio"
        Me.PROPRECIO.Name = "PROPRECIO"
        Me.PROPRECIO.ReadOnly = True
        '
        'PROEXISTED
        '
        Me.PROEXISTED.DataPropertyName = "PROEXISTE"
        Me.PROEXISTED.HeaderText = "PROEXISTE"
        Me.PROEXISTED.Name = "PROEXISTED"
        Me.PROEXISTED.ReadOnly = True
        Me.PROEXISTED.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 27)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(927, 20)
        Me.TextBox1.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1052, 53)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1860, 930)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNEDITAR)
        Me.Controls.Add(Me.BTNNUEVO)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInventario"
        Me.Text = "FrmInventario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTNEDITAR As Button
    Friend WithEvents BTNNUEVO As Button
    Friend WithEvents BTNELIMINAR As Button
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents TBLPRODUCTOSBindingSource As BindingSource
    Friend WithEvents TBLPRODUCTOSTableAdapter As MuebleAlexDataSetTableAdapters.TBLPRODUCTOSTableAdapter
    Friend WithEvents PROID As DataGridViewTextBoxColumn
    Friend WithEvents PROCLAVE As DataGridViewTextBoxColumn
    Friend WithEvents PRONOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents PROEXISTENCIAS As DataGridViewTextBoxColumn
    Friend WithEvents PROPRECIO As DataGridViewTextBoxColumn
    Friend WithEvents PROEXISTED As DataGridViewCheckBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
