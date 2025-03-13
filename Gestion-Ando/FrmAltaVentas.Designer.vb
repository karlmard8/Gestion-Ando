<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaVentas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTPAGO = New System.Windows.Forms.TextBox()
        Me.BTNPAGAR = New System.Windows.Forms.Button()
        Me.TXTCAMBIO = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTMESES = New System.Windows.Forms.TextBox()
        Me.RBCREDITO = New System.Windows.Forms.RadioButton()
        Me.RBCONTADO = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LBLIVA = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLSUB = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DtgProductos = New System.Windows.Forms.DataGridView()
        Me.GRUPO2 = New System.Windows.Forms.Panel()
        Me.CMBPRECIO = New System.Windows.Forms.ComboBox()
        Me.VISTAPRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblSubTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.CMBPRODUCTO = New System.Windows.Forms.ComboBox()
        Me.CmbClave = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LBLDETALLESPRODUCTO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LBLUSUARIOACTUAL = New System.Windows.Forms.Label()
        Me.CmbClientes = New System.Windows.Forms.ComboBox()
        Me.VISTACLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLCLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GRUPO1 = New System.Windows.Forms.GroupBox()
        Me.VISTAVENTASBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTAVENTASTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTAVENTASTableAdapter()
        Me.TBLCLIENTESTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.TBLCLIENTESTableAdapter()
        Me.VISTACLIENTESTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTACLIENTESTableAdapter()
        Me.VISTAPRODUCTOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTAPRODUCTOSTableAdapter()
        Me.PROID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCLAVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRONOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROPRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROSUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DtgProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO2.SuspendLayout()
        CType(Me.VISTAPRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTACLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRUPO1.SuspendLayout()
        CType(Me.VISTAVENTASBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXTPAGO)
        Me.GroupBox2.Controls.Add(Me.BTNPAGAR)
        Me.GroupBox2.Controls.Add(Me.TXTCAMBIO)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TXTMESES)
        Me.GroupBox2.Controls.Add(Me.RBCREDITO)
        Me.GroupBox2.Controls.Add(Me.RBCONTADO)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 392)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(474, 133)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PAGO"
        '
        'TXTPAGO
        '
        Me.TXTPAGO.Font = New System.Drawing.Font("Dubai", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPAGO.Location = New System.Drawing.Point(152, 64)
        Me.TXTPAGO.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTPAGO.Name = "TXTPAGO"
        Me.TXTPAGO.Size = New System.Drawing.Size(87, 26)
        Me.TXTPAGO.TabIndex = 25
        '
        'BTNPAGAR
        '
        Me.BTNPAGAR.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BTNPAGAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPAGAR.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPAGAR.Location = New System.Drawing.Point(257, 64)
        Me.BTNPAGAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNPAGAR.Name = "BTNPAGAR"
        Me.BTNPAGAR.Size = New System.Drawing.Size(133, 65)
        Me.BTNPAGAR.TabIndex = 30
        Me.BTNPAGAR.Text = "Pagar"
        Me.BTNPAGAR.UseVisualStyleBackColor = False
        '
        'TXTCAMBIO
        '
        Me.TXTCAMBIO.AutoSize = True
        Me.TXTCAMBIO.BackColor = System.Drawing.Color.Gold
        Me.TXTCAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTCAMBIO.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCAMBIO.ForeColor = System.Drawing.Color.Red
        Me.TXTCAMBIO.Location = New System.Drawing.Point(152, 103)
        Me.TXTCAMBIO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TXTCAMBIO.Name = "TXTCAMBIO"
        Me.TXTCAMBIO.Size = New System.Drawing.Size(92, 26)
        Me.TXTCAMBIO.TabIndex = 29
        Me.TXTCAMBIO.Text = "Procesando..."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(72, 101)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 27)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "Cambio"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(5, 64)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(131, 27)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Dinero ingresado"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(332, 26)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 27)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Meses"
        '
        'TXTMESES
        '
        Me.TXTMESES.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMESES.Location = New System.Drawing.Point(388, 26)
        Me.TXTMESES.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTMESES.Name = "TXTMESES"
        Me.TXTMESES.Size = New System.Drawing.Size(68, 30)
        Me.TXTMESES.TabIndex = 24
        '
        'RBCREDITO
        '
        Me.RBCREDITO.AutoSize = True
        Me.RBCREDITO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBCREDITO.Location = New System.Drawing.Point(245, 24)
        Me.RBCREDITO.Margin = New System.Windows.Forms.Padding(2)
        Me.RBCREDITO.Name = "RBCREDITO"
        Me.RBCREDITO.Size = New System.Drawing.Size(81, 31)
        Me.RBCREDITO.TabIndex = 18
        Me.RBCREDITO.TabStop = True
        Me.RBCREDITO.Text = "Crédito"
        Me.RBCREDITO.UseVisualStyleBackColor = True
        '
        'RBCONTADO
        '
        Me.RBCONTADO.AutoSize = True
        Me.RBCONTADO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBCONTADO.Location = New System.Drawing.Point(150, 24)
        Me.RBCONTADO.Margin = New System.Windows.Forms.Padding(2)
        Me.RBCONTADO.Name = "RBCONTADO"
        Me.RBCONTADO.Size = New System.Drawing.Size(89, 31)
        Me.RBCONTADO.TabIndex = 17
        Me.RBCONTADO.TabStop = True
        Me.RBCONTADO.Text = "Contado"
        Me.RBCONTADO.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(21, 25)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 27)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Forma de pago"
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.AutoSize = True
        Me.LBLTOTAL.BackColor = System.Drawing.Color.Gold
        Me.LBLTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTOTAL.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTAL.ForeColor = System.Drawing.Color.Red
        Me.LBLTOTAL.Location = New System.Drawing.Point(558, 443)
        Me.LBLTOTAL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(92, 26)
        Me.LBLTOTAL.TabIndex = 32
        Me.LBLTOTAL.Text = "Procesando..."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(493, 445)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 27)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "TOTAL"
        '
        'LBLIVA
        '
        Me.LBLIVA.AutoSize = True
        Me.LBLIVA.BackColor = System.Drawing.Color.Gold
        Me.LBLIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLIVA.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIVA.ForeColor = System.Drawing.Color.Red
        Me.LBLIVA.Location = New System.Drawing.Point(558, 418)
        Me.LBLIVA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLIVA.Name = "LBLIVA"
        Me.LBLIVA.Size = New System.Drawing.Size(92, 26)
        Me.LBLIVA.TabIndex = 30
        Me.LBLIVA.Text = "Procesando..."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(515, 418)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 27)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "IVA"
        '
        'LBLSUB
        '
        Me.LBLSUB.AutoSize = True
        Me.LBLSUB.BackColor = System.Drawing.Color.Gold
        Me.LBLSUB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLSUB.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSUB.ForeColor = System.Drawing.Color.Red
        Me.LBLSUB.Location = New System.Drawing.Point(558, 393)
        Me.LBLSUB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLSUB.Name = "LBLSUB"
        Me.LBLSUB.Size = New System.Drawing.Size(92, 26)
        Me.LBLSUB.TabIndex = 28
        Me.LBLSUB.Text = "Procesando..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(482, 394)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 27)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "SubTotal"
        '
        'DtgProductos
        '
        Me.DtgProductos.AllowUserToAddRows = False
        Me.DtgProductos.AllowUserToDeleteRows = False
        Me.DtgProductos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtgProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PROID, Me.PROCLAVE, Me.PRONOMBRE, Me.PROCANTIDAD, Me.PROPRECIO, Me.PROSUBTOTAL})
        Me.DtgProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.DtgProductos.Location = New System.Drawing.Point(0, 260)
        Me.DtgProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.DtgProductos.Name = "DtgProductos"
        Me.DtgProductos.ReadOnly = True
        Me.DtgProductos.RowHeadersVisible = False
        Me.DtgProductos.RowHeadersWidth = 51
        Me.DtgProductos.RowTemplate.Height = 24
        Me.DtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgProductos.Size = New System.Drawing.Size(650, 122)
        Me.DtgProductos.TabIndex = 26
        '
        'GRUPO2
        '
        Me.GRUPO2.BackColor = System.Drawing.SystemColors.Control
        Me.GRUPO2.Controls.Add(Me.CMBPRECIO)
        Me.GRUPO2.Controls.Add(Me.BtnQuitar)
        Me.GRUPO2.Controls.Add(Me.BtnAgregar)
        Me.GRUPO2.Controls.Add(Me.LblSubTotal)
        Me.GRUPO2.Controls.Add(Me.Label12)
        Me.GRUPO2.Controls.Add(Me.Label6)
        Me.GRUPO2.Controls.Add(Me.TxtCantidad)
        Me.GRUPO2.Controls.Add(Me.CMBPRODUCTO)
        Me.GRUPO2.Controls.Add(Me.CmbClave)
        Me.GRUPO2.Controls.Add(Me.Label10)
        Me.GRUPO2.Controls.Add(Me.Label9)
        Me.GRUPO2.Controls.Add(Me.Label8)
        Me.GRUPO2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRUPO2.Location = New System.Drawing.Point(0, 158)
        Me.GRUPO2.Margin = New System.Windows.Forms.Padding(2)
        Me.GRUPO2.Name = "GRUPO2"
        Me.GRUPO2.Size = New System.Drawing.Size(650, 102)
        Me.GRUPO2.TabIndex = 25
        '
        'CMBPRECIO
        '
        Me.CMBPRECIO.BackColor = System.Drawing.SystemColors.Control
        Me.CMBPRECIO.DataSource = Me.VISTAPRODUCTOSBindingSource
        Me.CMBPRECIO.DisplayMember = "PROPRECIO"
        Me.CMBPRECIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CMBPRECIO.Enabled = False
        Me.CMBPRECIO.FormattingEnabled = True
        Me.CMBPRECIO.Location = New System.Drawing.Point(471, 18)
        Me.CMBPRECIO.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBPRECIO.Name = "CMBPRECIO"
        Me.CMBPRECIO.Size = New System.Drawing.Size(92, 21)
        Me.CMBPRECIO.TabIndex = 17
        Me.CMBPRECIO.Tag = ""
        Me.CMBPRECIO.ValueMember = "PROID"
        '
        'VISTAPRODUCTOSBindingSource
        '
        Me.VISTAPRODUCTOSBindingSource.DataMember = "VISTAPRODUCTOS"
        Me.VISTAPRODUCTOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitar.Location = New System.Drawing.Point(582, 63)
        Me.BtnQuitar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnQuitar.Name = "BtnQuitar"
        Me.BtnQuitar.Size = New System.Drawing.Size(66, 33)
        Me.BtnQuitar.TabIndex = 16
        Me.BtnQuitar.Text = "Quitar"
        Me.BtnQuitar.UseVisualStyleBackColor = True
        '
        'BtnAgregar
        '
        Me.BtnAgregar.AutoSize = True
        Me.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(512, 63)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(66, 33)
        Me.BtnAgregar.TabIndex = 15
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LblSubTotal
        '
        Me.LblSubTotal.AutoSize = True
        Me.LblSubTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSubTotal.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotal.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblSubTotal.Location = New System.Drawing.Point(271, 70)
        Me.LblSubTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(31, 26)
        Me.LblSubTotal.TabIndex = 14
        Me.LblSubTotal.Text = "0.0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(192, 73)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 27)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "SubTotal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(9, 73)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Location = New System.Drawing.Point(87, 76)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(65, 20)
        Me.TxtCantidad.TabIndex = 11
        '
        'CMBPRODUCTO
        '
        Me.CMBPRODUCTO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBPRODUCTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBPRODUCTO.BackColor = System.Drawing.SystemColors.Control
        Me.CMBPRODUCTO.DataSource = Me.VISTAPRODUCTOSBindingSource
        Me.CMBPRODUCTO.DisplayMember = "PRONOMBRE"
        Me.CMBPRODUCTO.FormattingEnabled = True
        Me.CMBPRODUCTO.Location = New System.Drawing.Point(271, 20)
        Me.CMBPRODUCTO.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBPRODUCTO.Name = "CMBPRODUCTO"
        Me.CMBPRODUCTO.Size = New System.Drawing.Size(116, 21)
        Me.CMBPRODUCTO.TabIndex = 9
        Me.CMBPRODUCTO.ValueMember = "PROID"
        '
        'CmbClave
        '
        Me.CmbClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbClave.BackColor = System.Drawing.SystemColors.Control
        Me.CmbClave.DataSource = Me.VISTAPRODUCTOSBindingSource
        Me.CmbClave.DisplayMember = "PROCLAVE"
        Me.CmbClave.FormattingEnabled = True
        Me.CmbClave.Location = New System.Drawing.Point(65, 18)
        Me.CmbClave.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbClave.Name = "CmbClave"
        Me.CmbClave.Size = New System.Drawing.Size(87, 21)
        Me.CmbClave.TabIndex = 8
        Me.CmbClave.ValueMember = "PROID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(411, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 27)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Precio"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(191, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 27)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Producto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(9, 14)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 27)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Clave"
        '
        'LBLDETALLESPRODUCTO
        '
        Me.LBLDETALLESPRODUCTO.BackColor = System.Drawing.Color.Transparent
        Me.LBLDETALLESPRODUCTO.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLDETALLESPRODUCTO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDETALLESPRODUCTO.Location = New System.Drawing.Point(0, 130)
        Me.LBLDETALLESPRODUCTO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLDETALLESPRODUCTO.Name = "LBLDETALLESPRODUCTO"
        Me.LBLDETALLESPRODUCTO.Size = New System.Drawing.Size(650, 28)
        Me.LBLDETALLESPRODUCTO.TabIndex = 24
        Me.LBLDETALLESPRODUCTO.Text = "Datos del producto"
        Me.LBLDETALLESPRODUCTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(324, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Usuario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(9, 90)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 27)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente"
        '
        'LBLUSUARIOACTUAL
        '
        Me.LBLUSUARIOACTUAL.BackColor = System.Drawing.Color.Transparent
        Me.LBLUSUARIOACTUAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLUSUARIOACTUAL.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSUARIOACTUAL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBLUSUARIOACTUAL.Location = New System.Drawing.Point(398, 41)
        Me.LBLUSUARIOACTUAL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLUSUARIOACTUAL.Name = "LBLUSUARIOACTUAL"
        Me.LBLUSUARIOACTUAL.Size = New System.Drawing.Size(247, 24)
        Me.LBLUSUARIOACTUAL.TabIndex = 6
        '
        'CmbClientes
        '
        Me.CmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbClientes.BackColor = System.Drawing.SystemColors.Control
        Me.CmbClientes.DataSource = Me.VISTACLIENTESBindingSource
        Me.CmbClientes.DisplayMember = "Expr1"
        Me.CmbClientes.Font = New System.Drawing.Font("Dubai", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(84, 90)
        Me.CmbClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(554, 30)
        Me.CmbClientes.TabIndex = 7
        Me.CmbClientes.ValueMember = "CLIID"
        '
        'VISTACLIENTESBindingSource
        '
        Me.VISTACLIENTESBindingSource.DataMember = "VISTACLIENTES"
        Me.VISTACLIENTESBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'TBLCLIENTESBindingSource
        '
        Me.TBLCLIENTESBindingSource.DataMember = "TBLCLIENTES"
        Me.TBLCLIENTESBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'GRUPO1
        '
        Me.GRUPO1.BackColor = System.Drawing.SystemColors.Control
        Me.GRUPO1.Controls.Add(Me.CmbClientes)
        Me.GRUPO1.Controls.Add(Me.LBLUSUARIOACTUAL)
        Me.GRUPO1.Controls.Add(Me.Label4)
        Me.GRUPO1.Controls.Add(Me.Label3)
        Me.GRUPO1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRUPO1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRUPO1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GRUPO1.Location = New System.Drawing.Point(0, 0)
        Me.GRUPO1.Margin = New System.Windows.Forms.Padding(2)
        Me.GRUPO1.Name = "GRUPO1"
        Me.GRUPO1.Padding = New System.Windows.Forms.Padding(2)
        Me.GRUPO1.Size = New System.Drawing.Size(650, 130)
        Me.GRUPO1.TabIndex = 23
        Me.GRUPO1.TabStop = False
        Me.GRUPO1.Text = "Datos de la venta"
        '
        'VISTAVENTASBindingSource
        '
        Me.VISTAVENTASBindingSource.DataMember = "VISTAVENTAS"
        Me.VISTAVENTASBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'VISTAVENTASTableAdapter
        '
        Me.VISTAVENTASTableAdapter.ClearBeforeFill = True
        '
        'TBLCLIENTESTableAdapter
        '
        Me.TBLCLIENTESTableAdapter.ClearBeforeFill = True
        '
        'VISTACLIENTESTableAdapter
        '
        Me.VISTACLIENTESTableAdapter.ClearBeforeFill = True
        '
        'VISTAPRODUCTOSTableAdapter
        '
        Me.VISTAPRODUCTOSTableAdapter.ClearBeforeFill = True
        '
        'PROID
        '
        Me.PROID.HeaderText = "PROID"
        Me.PROID.MinimumWidth = 6
        Me.PROID.Name = "PROID"
        Me.PROID.ReadOnly = True
        Me.PROID.Visible = False
        Me.PROID.Width = 125
        '
        'PROCLAVE
        '
        Me.PROCLAVE.HeaderText = "CLAVE"
        Me.PROCLAVE.MinimumWidth = 6
        Me.PROCLAVE.Name = "PROCLAVE"
        Me.PROCLAVE.ReadOnly = True
        Me.PROCLAVE.Width = 80
        '
        'PRONOMBRE
        '
        Me.PRONOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PRONOMBRE.HeaderText = "PRODUCTO"
        Me.PRONOMBRE.MinimumWidth = 6
        Me.PRONOMBRE.Name = "PRONOMBRE"
        Me.PRONOMBRE.ReadOnly = True
        '
        'PROCANTIDAD
        '
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.PROCANTIDAD.DefaultCellStyle = DataGridViewCellStyle1
        Me.PROCANTIDAD.HeaderText = "CANTIDAD"
        Me.PROCANTIDAD.MinimumWidth = 6
        Me.PROCANTIDAD.Name = "PROCANTIDAD"
        Me.PROCANTIDAD.ReadOnly = True
        Me.PROCANTIDAD.Width = 75
        '
        'PROPRECIO
        '
        Me.PROPRECIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.PROPRECIO.DefaultCellStyle = DataGridViewCellStyle2
        Me.PROPRECIO.HeaderText = "PRECIO"
        Me.PROPRECIO.MinimumWidth = 6
        Me.PROPRECIO.Name = "PROPRECIO"
        Me.PROPRECIO.ReadOnly = True
        Me.PROPRECIO.Width = 72
        '
        'PROSUBTOTAL
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.PROSUBTOTAL.DefaultCellStyle = DataGridViewCellStyle3
        Me.PROSUBTOTAL.HeaderText = "TOTAL"
        Me.PROSUBTOTAL.MinimumWidth = 6
        Me.PROSUBTOTAL.Name = "PROSUBTOTAL"
        Me.PROSUBTOTAL.ReadOnly = True
        Me.PROSUBTOTAL.Width = 80
        '
        'FrmAltaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 530)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LBLTOTAL)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.LBLIVA)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.LBLSUB)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DtgProductos)
        Me.Controls.Add(Me.GRUPO2)
        Me.Controls.Add(Me.LBLDETALLESPRODUCTO)
        Me.Controls.Add(Me.GRUPO1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAltaVentas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de ventas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DtgProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO2.ResumeLayout(False)
        Me.GRUPO2.PerformLayout()
        CType(Me.VISTAPRODUCTOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTACLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRUPO1.ResumeLayout(False)
        Me.GRUPO1.PerformLayout()
        CType(Me.VISTAVENTASBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXTPAGO As TextBox
    Friend WithEvents BTNPAGAR As Button
    Friend WithEvents TXTCAMBIO As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTMESES As TextBox
    Friend WithEvents RBCREDITO As RadioButton
    Friend WithEvents RBCONTADO As RadioButton
    Friend WithEvents Label13 As Label
    Friend WithEvents LBLTOTAL As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents LBLIVA As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LBLSUB As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DtgProductos As DataGridView
    Friend WithEvents GRUPO2 As Panel
    Friend WithEvents CMBPRECIO As ComboBox
    Friend WithEvents BtnQuitar As Button
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LblSubTotal As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCantidad As TextBox
    Friend WithEvents CMBPRODUCTO As ComboBox
    Friend WithEvents CmbClave As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LBLDETALLESPRODUCTO As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LBLUSUARIOACTUAL As Label
    Friend WithEvents CmbClientes As ComboBox
    Friend WithEvents GRUPO1 As GroupBox
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents VISTAVENTASBindingSource As BindingSource
    Friend WithEvents VISTAVENTASTableAdapter As MuebleAlexDataSetTableAdapters.VISTAVENTASTableAdapter
    Friend WithEvents TBLCLIENTESBindingSource As BindingSource
    Friend WithEvents TBLCLIENTESTableAdapter As MuebleAlexDataSetTableAdapters.TBLCLIENTESTableAdapter
    Friend WithEvents VISTACLIENTESBindingSource As BindingSource
    Friend WithEvents VISTACLIENTESTableAdapter As MuebleAlexDataSetTableAdapters.VISTACLIENTESTableAdapter
    Friend WithEvents VISTAPRODUCTOSBindingSource As BindingSource
    Friend WithEvents VISTAPRODUCTOSTableAdapter As MuebleAlexDataSetTableAdapters.VISTAPRODUCTOSTableAdapter
    Friend WithEvents PROID As DataGridViewTextBoxColumn
    Friend WithEvents PROCLAVE As DataGridViewTextBoxColumn
    Friend WithEvents PRONOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents PROCANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents PROPRECIO As DataGridViewTextBoxColumn
    Friend WithEvents PROSUBTOTAL As DataGridViewTextBoxColumn
End Class
