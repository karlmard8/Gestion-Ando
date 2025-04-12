<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventario
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
        Me.DATAINVENTARIO = New System.Windows.Forms.DataGridView()
        Me.PROID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCLAVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRONOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROEXISTENCIAS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROPRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROIMAGEN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROEXISTED = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TBLPRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNREPORTE = New System.Windows.Forms.Button()
        Me.TBLPRODUCTOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.TBLPRODUCTOSTableAdapter()
        Me.VISTAPRODUCTO = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DATAINVENTARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLPRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAPRODUCTO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DATAINVENTARIO
        '
        Me.DATAINVENTARIO.AllowUserToAddRows = False
        Me.DATAINVENTARIO.AllowUserToDeleteRows = False
        Me.DATAINVENTARIO.AllowUserToResizeColumns = False
        Me.DATAINVENTARIO.AllowUserToResizeRows = False
        Me.DATAINVENTARIO.AutoGenerateColumns = False
        Me.DATAINVENTARIO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DATAINVENTARIO.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DATAINVENTARIO.BackgroundColor = System.Drawing.Color.White
        Me.DATAINVENTARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAINVENTARIO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROID, Me.PROCLAVE, Me.PRONOMBRE, Me.PROEXISTENCIAS, Me.PROPRECIO, Me.PROIMAGEN, Me.PROEXISTED})
        Me.DATAINVENTARIO.DataSource = Me.TBLPRODUCTOSBindingSource
        Me.DATAINVENTARIO.Location = New System.Drawing.Point(12, 92)
        Me.DATAINVENTARIO.MultiSelect = False
        Me.DATAINVENTARIO.Name = "DATAINVENTARIO"
        Me.DATAINVENTARIO.ReadOnly = True
        Me.DATAINVENTARIO.RowHeadersVisible = False
        Me.DATAINVENTARIO.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATAINVENTARIO.Size = New System.Drawing.Size(1400, 720)
        Me.DATAINVENTARIO.TabIndex = 0
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
        Me.PROCLAVE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.PROCLAVE.DataPropertyName = "PROCLAVE"
        Me.PROCLAVE.HeaderText = "Clave"
        Me.PROCLAVE.Name = "PROCLAVE"
        Me.PROCLAVE.ReadOnly = True
        Me.PROCLAVE.Width = 59
        '
        'PRONOMBRE
        '
        Me.PRONOMBRE.DataPropertyName = "PRONOMBRE"
        Me.PRONOMBRE.HeaderText = "Nombre"
        Me.PRONOMBRE.Name = "PRONOMBRE"
        Me.PRONOMBRE.ReadOnly = True
        '
        'PROEXISTENCIAS
        '
        Me.PROEXISTENCIAS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.PROEXISTENCIAS.DataPropertyName = "PROEXISTENCIAS"
        Me.PROEXISTENCIAS.HeaderText = "Existencias"
        Me.PROEXISTENCIAS.Name = "PROEXISTENCIAS"
        Me.PROEXISTENCIAS.ReadOnly = True
        Me.PROEXISTENCIAS.Width = 85
        '
        'PROPRECIO
        '
        Me.PROPRECIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PROPRECIO.DataPropertyName = "PROPRECIO"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PROPRECIO.DefaultCellStyle = DataGridViewCellStyle1
        Me.PROPRECIO.HeaderText = "Precio"
        Me.PROPRECIO.Name = "PROPRECIO"
        Me.PROPRECIO.ReadOnly = True
        Me.PROPRECIO.Width = 62
        '
        'PROIMAGEN
        '
        Me.PROIMAGEN.DataPropertyName = "PROIMAGEN"
        Me.PROIMAGEN.HeaderText = "Foto"
        Me.PROIMAGEN.Name = "PROIMAGEN"
        Me.PROIMAGEN.ReadOnly = True
        Me.PROIMAGEN.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PROIMAGEN.Visible = False
        '
        'PROEXISTED
        '
        Me.PROEXISTED.DataPropertyName = "PROEXISTE"
        Me.PROEXISTED.HeaderText = "PROEXISTE"
        Me.PROEXISTED.Name = "PROEXISTED"
        Me.PROEXISTED.ReadOnly = True
        Me.PROEXISTED.Visible = False
        '
        'TBLPRODUCTOSBindingSource
        '
        Me.TBLPRODUCTOSBindingSource.DataMember = "TBLPRODUCTOS"
        Me.TBLPRODUCTOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEDITAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDITAR.Location = New System.Drawing.Point(1079, 847)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNEDITAR.TabIndex = 5
        Me.BTNEDITAR.Text = "Editar"
        Me.BTNEDITAR.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(880, 847)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(132, 54)
        Me.BTNNUEVO.TabIndex = 4
        Me.BTNNUEVO.Text = "Nuevo"
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(1280, 847)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNELIMINAR.TabIndex = 5
        Me.BTNELIMINAR.Text = "Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Buscar"
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBUSCAR.Location = New System.Drawing.Point(110, 30)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(927, 29)
        Me.TXTBUSCAR.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1052, 62)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.AutoSize = True
        Me.BTNREPORTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTE.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.Location = New System.Drawing.Point(1280, 41)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(133, 45)
        Me.BTNREPORTE.TabIndex = 14
        Me.BTNREPORTE.Text = "Generar reporte"
        Me.BTNREPORTE.UseVisualStyleBackColor = True
        '
        'TBLPRODUCTOSTableAdapter
        '
        Me.TBLPRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'VISTAPRODUCTO
        '
        Me.VISTAPRODUCTO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.VISTAPRODUCTO.Location = New System.Drawing.Point(1418, 122)
        Me.VISTAPRODUCTO.Name = "VISTAPRODUCTO"
        Me.VISTAPRODUCTO.Size = New System.Drawing.Size(466, 440)
        Me.VISTAPRODUCTO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.VISTAPRODUCTO.TabIndex = 15
        Me.VISTAPRODUCTO.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1483, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 29)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Selecciona un producto para mostrar su imagen"
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1896, 940)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.VISTAPRODUCTO)
        Me.Controls.Add(Me.BTNREPORTE)
        Me.Controls.Add(Me.TXTBUSCAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNEDITAR)
        Me.Controls.Add(Me.BTNNUEVO)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.DATAINVENTARIO)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInventario"
        Me.Text = "FrmInventario"
        CType(Me.DATAINVENTARIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLPRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAPRODUCTO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DATAINVENTARIO As DataGridView
    Friend WithEvents BTNEDITAR As Button
    Friend WithEvents BTNNUEVO As Button
    Friend WithEvents BTNELIMINAR As Button
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents TBLPRODUCTOSBindingSource As BindingSource
    Friend WithEvents TBLPRODUCTOSTableAdapter As MuebleAlexDataSetTableAdapters.TBLPRODUCTOSTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTBUSCAR As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNREPORTE As Button
    Friend WithEvents PROID As DataGridViewTextBoxColumn
    Friend WithEvents PROCLAVE As DataGridViewTextBoxColumn
    Friend WithEvents PRONOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents PROEXISTENCIAS As DataGridViewTextBoxColumn
    Friend WithEvents PROPRECIO As DataGridViewTextBoxColumn
    Friend WithEvents PROIMAGEN As DataGridViewTextBoxColumn
    Friend WithEvents PROEXISTED As DataGridViewCheckBoxColumn
    Friend WithEvents VISTAPRODUCTO As PictureBox
    Friend WithEvents Label2 As Label
End Class
