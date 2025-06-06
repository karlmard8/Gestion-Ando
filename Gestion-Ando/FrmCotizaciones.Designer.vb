<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCotizaciones
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DATACOTIZACIONES = New System.Windows.Forms.DataGridView()
        Me.CMBCLIENTE = New System.Windows.Forms.ComboBox()
        Me.VISTACLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.LBLCLIENTE = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBPRODUCTO = New System.Windows.Forms.ComboBox()
        Me.VISTAPRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNENVIAR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBLCOTID = New System.Windows.Forms.Label()
        Me.VISTACLIENTESTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTACLIENTESTableAdapter()
        Me.VISTAPRODUCTOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTAPRODUCTOSTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TXTCANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNSUM = New System.Windows.Forms.Button()
        Me.BTNRES = New System.Windows.Forms.Button()
        Me.BTNAGREGAR = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LBLPRECIO = New System.Windows.Forms.Label()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLSUBTOTAL = New System.Windows.Forms.Label()
        Me.LBLDESCUENTO = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AGREGARPRODUCTOS = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DATACOTIZACIONES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTACLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAPRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.AGREGARPRODUCTOS.SuspendLayout()
        Me.SuspendLayout()
        '
        'DATACOTIZACIONES
        '
        Me.DATACOTIZACIONES.AllowUserToAddRows = False
        Me.DATACOTIZACIONES.AllowUserToDeleteRows = False
        Me.DATACOTIZACIONES.AllowUserToResizeColumns = False
        Me.DATACOTIZACIONES.AllowUserToResizeRows = False
        Me.DATACOTIZACIONES.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DATACOTIZACIONES.BackgroundColor = System.Drawing.Color.White
        Me.DATACOTIZACIONES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DATACOTIZACIONES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DATACOTIZACIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DATACOTIZACIONES.DefaultCellStyle = DataGridViewCellStyle2
        Me.DATACOTIZACIONES.Location = New System.Drawing.Point(0, 242)
        Me.DATACOTIZACIONES.MultiSelect = False
        Me.DATACOTIZACIONES.Name = "DATACOTIZACIONES"
        Me.DATACOTIZACIONES.RowHeadersVisible = False
        Me.DATACOTIZACIONES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATACOTIZACIONES.Size = New System.Drawing.Size(1700, 567)
        Me.DATACOTIZACIONES.TabIndex = 0
        Me.DATACOTIZACIONES.TabStop = False
        '
        'CMBCLIENTE
        '
        Me.CMBCLIENTE.DataSource = Me.VISTACLIENTESBindingSource
        Me.CMBCLIENTE.DisplayMember = "Expr1"
        Me.CMBCLIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBCLIENTE.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCLIENTE.FormattingEnabled = True
        Me.CMBCLIENTE.Location = New System.Drawing.Point(110, 67)
        Me.CMBCLIENTE.Name = "CMBCLIENTE"
        Me.CMBCLIENTE.Size = New System.Drawing.Size(414, 35)
        Me.CMBCLIENTE.TabIndex = 1
        Me.CMBCLIENTE.ValueMember = "CLIID"
        '
        'VISTACLIENTESBindingSource
        '
        Me.VISTACLIENTESBindingSource.DataMember = "VISTACLIENTES"
        Me.VISTACLIENTESBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LBLCLIENTE
        '
        Me.LBLCLIENTE.AutoSize = True
        Me.LBLCLIENTE.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCLIENTE.Location = New System.Drawing.Point(29, 70)
        Me.LBLCLIENTE.Name = "LBLCLIENTE"
        Me.LBLCLIENTE.Size = New System.Drawing.Size(70, 32)
        Me.LBLCLIENTE.TabIndex = 2
        Me.LBLCLIENTE.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Producto"
        '
        'CMBPRODUCTO
        '
        Me.CMBPRODUCTO.DataSource = Me.VISTAPRODUCTOSBindingSource
        Me.CMBPRODUCTO.DisplayMember = "PRONOMBRE"
        Me.CMBPRODUCTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBPRODUCTO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBPRODUCTO.FormattingEnabled = True
        Me.CMBPRODUCTO.Location = New System.Drawing.Point(112, 13)
        Me.CMBPRODUCTO.Name = "CMBPRODUCTO"
        Me.CMBPRODUCTO.Size = New System.Drawing.Size(1315, 35)
        Me.CMBPRODUCTO.TabIndex = 3
        Me.CMBPRODUCTO.ValueMember = "PROID"
        '
        'VISTAPRODUCTOSBindingSource
        '
        Me.VISTAPRODUCTOSBindingSource.DataMember = "VISTAPRODUCTOS"
        Me.VISTAPRODUCTOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.AutoSize = True
        Me.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.Location = New System.Drawing.Point(1706, 242)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(177, 60)
        Me.BTNGUARDAR.TabIndex = 9
        Me.BTNGUARDAR.Text = "Guardar cotización"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.AutoSize = True
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(1706, 442)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(177, 60)
        Me.BTNELIMINAR.TabIndex = 10
        Me.BTNELIMINAR.Text = "Eliminar cotización"
        Me.BTNELIMINAR.UseVisualStyleBackColor = True
        '
        'BTNENVIAR
        '
        Me.BTNENVIAR.AutoSize = True
        Me.BTNENVIAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNENVIAR.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNENVIAR.Location = New System.Drawing.Point(1706, 642)
        Me.BTNENVIAR.Name = "BTNENVIAR"
        Me.BTNENVIAR.Size = New System.Drawing.Size(177, 60)
        Me.BTNENVIAR.TabIndex = 11
        Me.BTNENVIAR.Text = "Enviar por correo"
        Me.BTNENVIAR.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1579, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "No. Cotización:"
        '
        'LBLCOTID
        '
        Me.LBLCOTID.AutoSize = True
        Me.LBLCOTID.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCOTID.Location = New System.Drawing.Point(1718, 12)
        Me.LBLCOTID.Name = "LBLCOTID"
        Me.LBLCOTID.Size = New System.Drawing.Size(29, 27)
        Me.LBLCOTID.TabIndex = 10
        Me.LBLCOTID.Text = ". . ."
        '
        'VISTACLIENTESTableAdapter
        '
        Me.VISTACLIENTESTableAdapter.ClearBeforeFill = True
        '
        'VISTAPRODUCTOSTableAdapter
        '
        Me.VISTAPRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1896, 49)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TXTCANTIDAD
        '
        Me.TXTCANTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCANTIDAD.Location = New System.Drawing.Point(158, 77)
        Me.TXTCANTIDAD.MaxLength = 10
        Me.TXTCANTIDAD.Name = "TXTCANTIDAD"
        Me.TXTCANTIDAD.Size = New System.Drawing.Size(100, 26)
        Me.TXTCANTIDAD.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 32)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cantidad"
        '
        'BTNSUM
        '
        Me.BTNSUM.AutoSize = True
        Me.BTNSUM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSUM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSUM.Location = New System.Drawing.Point(264, 75)
        Me.BTNSUM.Name = "BTNSUM"
        Me.BTNSUM.Size = New System.Drawing.Size(29, 30)
        Me.BTNSUM.TabIndex = 6
        Me.BTNSUM.Text = "+"
        Me.BTNSUM.UseVisualStyleBackColor = True
        '
        'BTNRES
        '
        Me.BTNRES.AutoSize = True
        Me.BTNRES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNRES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNRES.Location = New System.Drawing.Point(123, 75)
        Me.BTNRES.Name = "BTNRES"
        Me.BTNRES.Size = New System.Drawing.Size(29, 30)
        Me.BTNRES.TabIndex = 4
        Me.BTNRES.Text = "-"
        Me.BTNRES.UseVisualStyleBackColor = True
        '
        'BTNAGREGAR
        '
        Me.BTNAGREGAR.AutoSize = True
        Me.BTNAGREGAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNAGREGAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNAGREGAR.Location = New System.Drawing.Point(892, 66)
        Me.BTNAGREGAR.Name = "BTNAGREGAR"
        Me.BTNAGREGAR.Size = New System.Drawing.Size(77, 37)
        Me.BTNAGREGAR.TabIndex = 7
        Me.BTNAGREGAR.Text = "Agregar"
        Me.BTNAGREGAR.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1432, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 32)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Precio:"
        '
        'LBLPRECIO
        '
        Me.LBLPRECIO.AutoSize = True
        Me.LBLPRECIO.Font = New System.Drawing.Font("Dubai Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPRECIO.Location = New System.Drawing.Point(1492, 19)
        Me.LBLPRECIO.Name = "LBLPRECIO"
        Me.LBLPRECIO.Size = New System.Drawing.Size(34, 27)
        Me.LBLPRECIO.TabIndex = 18
        Me.LBLPRECIO.Text = ". . ."
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.AutoSize = True
        Me.LBLTOTAL.Font = New System.Drawing.Font("Dubai Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTAL.Location = New System.Drawing.Point(1482, 70)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(34, 27)
        Me.LBLTOTAL.TabIndex = 0
        Me.LBLTOTAL.Text = ". . ."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1481, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 32)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "SubTotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(783, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 32)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Descuento aplicado"
        '
        'LBLSUBTOTAL
        '
        Me.LBLSUBTOTAL.AutoSize = True
        Me.LBLSUBTOTAL.Font = New System.Drawing.Font("Dubai Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSUBTOTAL.Location = New System.Drawing.Point(151, 70)
        Me.LBLSUBTOTAL.Name = "LBLSUBTOTAL"
        Me.LBLSUBTOTAL.Size = New System.Drawing.Size(34, 27)
        Me.LBLSUBTOTAL.TabIndex = 4
        Me.LBLSUBTOTAL.Text = ". . ."
        '
        'LBLDESCUENTO
        '
        Me.LBLDESCUENTO.AutoSize = True
        Me.LBLDESCUENTO.Font = New System.Drawing.Font("Dubai Medium", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDESCUENTO.Location = New System.Drawing.Point(819, 70)
        Me.LBLDESCUENTO.Name = "LBLDESCUENTO"
        Me.LBLDESCUENTO.Size = New System.Drawing.Size(34, 27)
        Me.LBLDESCUENTO.TabIndex = 5
        Me.LBLDESCUENTO.Text = ". . ."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LBLDESCUENTO)
        Me.GroupBox1.Controls.Add(Me.LBLSUBTOTAL)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LBLTOTAL)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 815)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1700, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'AGREGARPRODUCTOS
        '
        Me.AGREGARPRODUCTOS.Controls.Add(Me.Button1)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.LBLPRECIO)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.Label9)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.CMBPRODUCTO)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.BTNAGREGAR)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.Label2)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.BTNRES)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.TXTCANTIDAD)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.BTNSUM)
        Me.AGREGARPRODUCTOS.Controls.Add(Me.Label8)
        Me.AGREGARPRODUCTOS.Location = New System.Drawing.Point(0, 125)
        Me.AGREGARPRODUCTOS.Name = "AGREGARPRODUCTOS"
        Me.AGREGARPRODUCTOS.Size = New System.Drawing.Size(1700, 111)
        Me.AGREGARPRODUCTOS.TabIndex = 2
        Me.AGREGARPRODUCTOS.TabStop = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1009, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 37)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Quitar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmCotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1896, 930)
        Me.Controls.Add(Me.LBLCOTID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNENVIAR)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLCLIENTE)
        Me.Controls.Add(Me.CMBCLIENTE)
        Me.Controls.Add(Me.DATACOTIZACIONES)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AGREGARPRODUCTOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCotizaciones"
        Me.ShowInTaskbar = False
        Me.Text = "FrmCotizaciones"
        CType(Me.DATACOTIZACIONES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTACLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAPRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.AGREGARPRODUCTOS.ResumeLayout(False)
        Me.AGREGARPRODUCTOS.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DATACOTIZACIONES As DataGridView
    Friend WithEvents CMBCLIENTE As ComboBox
    Friend WithEvents LBLCLIENTE As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CMBPRODUCTO As ComboBox
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents BTNELIMINAR As Button
    Friend WithEvents BTNENVIAR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LBLCOTID As Label
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents VISTACLIENTESBindingSource As BindingSource
    Friend WithEvents VISTACLIENTESTableAdapter As MuebleAlexDataSetTableAdapters.VISTACLIENTESTableAdapter
    Friend WithEvents VISTAPRODUCTOSBindingSource As BindingSource
    Friend WithEvents VISTAPRODUCTOSTableAdapter As MuebleAlexDataSetTableAdapters.VISTAPRODUCTOSTableAdapter
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TXTCANTIDAD As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BTNSUM As Button
    Friend WithEvents BTNRES As Button
    Friend WithEvents BTNAGREGAR As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents LBLPRECIO As Label
    Friend WithEvents LBLTOTAL As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LBLSUBTOTAL As Label
    Friend WithEvents LBLDESCUENTO As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents AGREGARPRODUCTOS As GroupBox
    Friend WithEvents Button1 As Button
End Class
