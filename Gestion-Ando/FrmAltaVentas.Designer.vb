<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaVentas
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTENGANCHE = New System.Windows.Forms.TextBox()
        Me.TXTPAGO = New System.Windows.Forms.TextBox()
        Me.TXTCAMBIO = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTMESES = New System.Windows.Forms.TextBox()
        Me.RBCREDITO = New System.Windows.Forms.RadioButton()
        Me.RBCONTADO = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.BTNPAGAR = New System.Windows.Forms.Button()
        Me.LBLTOTAL = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LBLIVA = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBLSUB = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DtgProductos = New System.Windows.Forms.DataGridView()
        Me.PROID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCLAVE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRONOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROCANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROPRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PROSUBTOTAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRUPO2 = New System.Windows.Forms.Panel()
        Me.CMBEXISTENCIAS = New System.Windows.Forms.ComboBox()
        Me.VISTAPRODUCTOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBPRECIO = New System.Windows.Forms.ComboBox()
        Me.BtnQuitar = New System.Windows.Forms.Button()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LblSubTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCantidad = New System.Windows.Forms.TextBox()
        Me.CMBPRODUCTO = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbClave = New System.Windows.Forms.ComboBox()
        Me.LBLCLAVE = New System.Windows.Forms.Label()
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
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TXTENGANCHE)
        Me.GroupBox2.Controls.Add(Me.TXTPAGO)
        Me.GroupBox2.Controls.Add(Me.TXTCAMBIO)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TXTMESES)
        Me.GroupBox2.Controls.Add(Me.RBCREDITO)
        Me.GroupBox2.Controls.Add(Me.RBCONTADO)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(2, 508)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(654, 198)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PAGO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(443, 144)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 27)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Enganche"
        '
        'TXTENGANCHE
        '
        Me.TXTENGANCHE.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTENGANCHE.Location = New System.Drawing.Point(526, 141)
        Me.TXTENGANCHE.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTENGANCHE.MaxLength = 15
        Me.TXTENGANCHE.Name = "TXTENGANCHE"
        Me.TXTENGANCHE.Size = New System.Drawing.Size(68, 30)
        Me.TXTENGANCHE.TabIndex = 30
        '
        'TXTPAGO
        '
        Me.TXTPAGO.Font = New System.Drawing.Font("Dubai", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPAGO.Location = New System.Drawing.Point(152, 81)
        Me.TXTPAGO.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTPAGO.MaxLength = 15
        Me.TXTPAGO.Name = "TXTPAGO"
        Me.TXTPAGO.Size = New System.Drawing.Size(87, 33)
        Me.TXTPAGO.TabIndex = 25
        '
        'TXTCAMBIO
        '
        Me.TXTCAMBIO.BackColor = System.Drawing.Color.Transparent
        Me.TXTCAMBIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTCAMBIO.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCAMBIO.ForeColor = System.Drawing.Color.Black
        Me.TXTCAMBIO.Location = New System.Drawing.Point(147, 146)
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
        Me.Label18.Location = New System.Drawing.Point(67, 144)
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
        Me.Label16.Location = New System.Drawing.Point(5, 85)
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
        Me.Label14.Location = New System.Drawing.Point(448, 85)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 27)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Semanas"
        '
        'TXTMESES
        '
        Me.TXTMESES.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMESES.Location = New System.Drawing.Point(526, 84)
        Me.TXTMESES.Margin = New System.Windows.Forms.Padding(2)
        Me.TXTMESES.MaxLength = 10
        Me.TXTMESES.Name = "TXTMESES"
        Me.TXTMESES.Size = New System.Drawing.Size(68, 30)
        Me.TXTMESES.TabIndex = 24
        '
        'RBCREDITO
        '
        Me.RBCREDITO.AutoSize = True
        Me.RBCREDITO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RBCREDITO.Location = New System.Drawing.Point(513, 23)
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
        'BTNPAGAR
        '
        Me.BTNPAGAR.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BTNPAGAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPAGAR.Font = New System.Drawing.Font("Dubai", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPAGAR.Location = New System.Drawing.Point(1000, 618)
        Me.BTNPAGAR.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNPAGAR.Name = "BTNPAGAR"
        Me.BTNPAGAR.Size = New System.Drawing.Size(130, 85)
        Me.BTNPAGAR.TabIndex = 35
        Me.BTNPAGAR.Text = "Pagar"
        Me.BTNPAGAR.UseVisualStyleBackColor = False
        '
        'LBLTOTAL
        '
        Me.LBLTOTAL.BackColor = System.Drawing.Color.Transparent
        Me.LBLTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLTOTAL.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTOTAL.ForeColor = System.Drawing.Color.Black
        Me.LBLTOTAL.Location = New System.Drawing.Point(1000, 575)
        Me.LBLTOTAL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLTOTAL.Name = "LBLTOTAL"
        Me.LBLTOTAL.Size = New System.Drawing.Size(127, 26)
        Me.LBLTOTAL.TabIndex = 32
        Me.LBLTOTAL.Text = "Procesando..."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(911, 577)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 27)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "TOTAL"
        '
        'LBLIVA
        '
        Me.LBLIVA.BackColor = System.Drawing.Color.Transparent
        Me.LBLIVA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLIVA.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIVA.ForeColor = System.Drawing.Color.Black
        Me.LBLIVA.Location = New System.Drawing.Point(1000, 549)
        Me.LBLIVA.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLIVA.Name = "LBLIVA"
        Me.LBLIVA.Size = New System.Drawing.Size(127, 26)
        Me.LBLIVA.TabIndex = 30
        Me.LBLIVA.Text = "Procesando..."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(933, 550)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 27)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "IVA"
        '
        'LBLSUB
        '
        Me.LBLSUB.BackColor = System.Drawing.Color.Transparent
        Me.LBLSUB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLSUB.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSUB.ForeColor = System.Drawing.Color.Black
        Me.LBLSUB.Location = New System.Drawing.Point(1000, 525)
        Me.LBLSUB.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLSUB.Name = "LBLSUB"
        Me.LBLSUB.Size = New System.Drawing.Size(127, 26)
        Me.LBLSUB.TabIndex = 28
        Me.LBLSUB.Text = "Procesando..."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(900, 526)
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
        Me.DtgProductos.Location = New System.Drawing.Point(0, 335)
        Me.DtgProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.DtgProductos.Name = "DtgProductos"
        Me.DtgProductos.RowHeadersVisible = False
        Me.DtgProductos.RowHeadersWidth = 51
        Me.DtgProductos.RowTemplate.Height = 24
        Me.DtgProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtgProductos.Size = New System.Drawing.Size(1184, 169)
        Me.DtgProductos.TabIndex = 26
        '
        'PROID
        '
        Me.PROID.HeaderText = "PROID"
        Me.PROID.MinimumWidth = 6
        Me.PROID.Name = "PROID"
        Me.PROID.Visible = False
        Me.PROID.Width = 125
        '
        'PROCLAVE
        '
        Me.PROCLAVE.HeaderText = "CLAVE"
        Me.PROCLAVE.MinimumWidth = 6
        Me.PROCLAVE.Name = "PROCLAVE"
        Me.PROCLAVE.Width = 80
        '
        'PRONOMBRE
        '
        Me.PRONOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PRONOMBRE.HeaderText = "PRODUCTO"
        Me.PRONOMBRE.MinimumWidth = 6
        Me.PRONOMBRE.Name = "PRONOMBRE"
        '
        'PROCANTIDAD
        '
        DataGridViewCellStyle10.Format = "N0"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.PROCANTIDAD.DefaultCellStyle = DataGridViewCellStyle10
        Me.PROCANTIDAD.HeaderText = "CANTIDAD"
        Me.PROCANTIDAD.MinimumWidth = 6
        Me.PROCANTIDAD.Name = "PROCANTIDAD"
        Me.PROCANTIDAD.Width = 75
        '
        'PROPRECIO
        '
        Me.PROPRECIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.PROPRECIO.DefaultCellStyle = DataGridViewCellStyle11
        Me.PROPRECIO.HeaderText = "PRECIO"
        Me.PROPRECIO.MinimumWidth = 6
        Me.PROPRECIO.Name = "PROPRECIO"
        Me.PROPRECIO.Width = 72
        '
        'PROSUBTOTAL
        '
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.PROSUBTOTAL.DefaultCellStyle = DataGridViewCellStyle12
        Me.PROSUBTOTAL.HeaderText = "TOTAL"
        Me.PROSUBTOTAL.MinimumWidth = 6
        Me.PROSUBTOTAL.Name = "PROSUBTOTAL"
        Me.PROSUBTOTAL.Width = 80
        '
        'GRUPO2
        '
        Me.GRUPO2.BackColor = System.Drawing.SystemColors.Control
        Me.GRUPO2.Controls.Add(Me.CMBEXISTENCIAS)
        Me.GRUPO2.Controls.Add(Me.Label2)
        Me.GRUPO2.Controls.Add(Me.CMBPRECIO)
        Me.GRUPO2.Controls.Add(Me.BtnQuitar)
        Me.GRUPO2.Controls.Add(Me.BtnAgregar)
        Me.GRUPO2.Controls.Add(Me.LblSubTotal)
        Me.GRUPO2.Controls.Add(Me.Label12)
        Me.GRUPO2.Controls.Add(Me.Label6)
        Me.GRUPO2.Controls.Add(Me.TxtCantidad)
        Me.GRUPO2.Controls.Add(Me.CMBPRODUCTO)
        Me.GRUPO2.Controls.Add(Me.Label10)
        Me.GRUPO2.Controls.Add(Me.Label9)
        Me.GRUPO2.Controls.Add(Me.CmbClave)
        Me.GRUPO2.Controls.Add(Me.LBLCLAVE)
        Me.GRUPO2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRUPO2.Location = New System.Drawing.Point(0, 158)
        Me.GRUPO2.Margin = New System.Windows.Forms.Padding(2)
        Me.GRUPO2.Name = "GRUPO2"
        Me.GRUPO2.Size = New System.Drawing.Size(1184, 173)
        Me.GRUPO2.TabIndex = 25
        '
        'CMBEXISTENCIAS
        '
        Me.CMBEXISTENCIAS.BackColor = System.Drawing.SystemColors.Window
        Me.CMBEXISTENCIAS.DataSource = Me.VISTAPRODUCTOSBindingSource
        Me.CMBEXISTENCIAS.DisplayMember = "PROEXISTENCIAS"
        Me.CMBEXISTENCIAS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CMBEXISTENCIAS.Enabled = False
        Me.CMBEXISTENCIAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBEXISTENCIAS.FormatString = "N0"
        Me.CMBEXISTENCIAS.FormattingEnabled = True
        Me.CMBEXISTENCIAS.Location = New System.Drawing.Point(100, 86)
        Me.CMBEXISTENCIAS.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBEXISTENCIAS.Name = "CMBEXISTENCIAS"
        Me.CMBEXISTENCIAS.Size = New System.Drawing.Size(52, 21)
        Me.CMBEXISTENCIAS.TabIndex = 21
        Me.CMBEXISTENCIAS.Tag = ""
        Me.CMBEXISTENCIAS.ValueMember = "PROID"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(7, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 27)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Existencias"
        '
        'CMBPRECIO
        '
        Me.CMBPRECIO.BackColor = System.Drawing.SystemColors.Window
        Me.CMBPRECIO.DataSource = Me.VISTAPRODUCTOSBindingSource
        Me.CMBPRECIO.DisplayMember = "PROPRECIO"
        Me.CMBPRECIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CMBPRECIO.Enabled = False
        Me.CMBPRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBPRECIO.FormattingEnabled = True
        Me.CMBPRECIO.Location = New System.Drawing.Point(281, 86)
        Me.CMBPRECIO.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBPRECIO.Name = "CMBPRECIO"
        Me.CMBPRECIO.Size = New System.Drawing.Size(92, 21)
        Me.CMBPRECIO.TabIndex = 17
        Me.CMBPRECIO.Tag = ""
        Me.CMBPRECIO.ValueMember = "PROID"
        '
        'BtnQuitar
        '
        Me.BtnQuitar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitar.Location = New System.Drawing.Point(1100, 128)
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
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.Location = New System.Drawing.Point(1000, 128)
        Me.BtnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(74, 33)
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
        Me.LblSubTotal.Location = New System.Drawing.Point(528, 83)
        Me.LblSubTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTotal.Name = "LblSubTotal"
        Me.LblSubTotal.Size = New System.Drawing.Size(92, 26)
        Me.LblSubTotal.TabIndex = 14
        Me.LblSubTotal.Text = "Procesando..."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(449, 84)
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
        Me.Label6.Location = New System.Drawing.Point(20, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 27)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cantidad"
        '
        'TxtCantidad
        '
        Me.TxtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCantidad.Location = New System.Drawing.Point(98, 137)
        Me.TxtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCantidad.Name = "TxtCantidad"
        Me.TxtCantidad.Size = New System.Drawing.Size(65, 26)
        Me.TxtCantidad.TabIndex = 11
        '
        'CMBPRODUCTO
        '
        Me.CMBPRODUCTO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CMBPRODUCTO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CMBPRODUCTO.BackColor = System.Drawing.SystemColors.Window
        Me.CMBPRODUCTO.DataSource = Me.VISTAPRODUCTOSBindingSource
        Me.CMBPRODUCTO.DisplayMember = "PRONOMBRE"
        Me.CMBPRODUCTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBPRODUCTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBPRODUCTO.FormattingEnabled = True
        Me.CMBPRODUCTO.Location = New System.Drawing.Point(96, 13)
        Me.CMBPRODUCTO.Margin = New System.Windows.Forms.Padding(2)
        Me.CMBPRODUCTO.Name = "CMBPRODUCTO"
        Me.CMBPRODUCTO.Size = New System.Drawing.Size(1088, 28)
        Me.CMBPRODUCTO.TabIndex = 9
        Me.CMBPRODUCTO.ValueMember = "PROID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(221, 84)
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
        Me.Label9.Location = New System.Drawing.Point(7, 14)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 27)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Producto"
        '
        'CmbClave
        '
        Me.CmbClave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbClave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbClave.BackColor = System.Drawing.SystemColors.Window
        Me.CmbClave.DataSource = Me.VISTAPRODUCTOSBindingSource
        Me.CmbClave.DisplayMember = "PROCLAVE"
        Me.CmbClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClave.FormattingEnabled = True
        Me.CmbClave.Location = New System.Drawing.Point(98, 14)
        Me.CmbClave.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbClave.Name = "CmbClave"
        Me.CmbClave.Size = New System.Drawing.Size(87, 21)
        Me.CmbClave.TabIndex = 8
        Me.CmbClave.ValueMember = "PROID"
        '
        'LBLCLAVE
        '
        Me.LBLCLAVE.AutoSize = True
        Me.LBLCLAVE.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCLAVE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBLCLAVE.Location = New System.Drawing.Point(9, 14)
        Me.LBLCLAVE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLCLAVE.Name = "LBLCLAVE"
        Me.LBLCLAVE.Size = New System.Drawing.Size(49, 27)
        Me.LBLCLAVE.TabIndex = 4
        Me.LBLCLAVE.Text = "Clave"
        '
        'LBLDETALLESPRODUCTO
        '
        Me.LBLDETALLESPRODUCTO.BackColor = System.Drawing.Color.Transparent
        Me.LBLDETALLESPRODUCTO.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBLDETALLESPRODUCTO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDETALLESPRODUCTO.Location = New System.Drawing.Point(0, 130)
        Me.LBLDETALLESPRODUCTO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLDETALLESPRODUCTO.Name = "LBLDETALLESPRODUCTO"
        Me.LBLDETALLESPRODUCTO.Size = New System.Drawing.Size(1184, 28)
        Me.LBLDETALLESPRODUCTO.TabIndex = 24
        Me.LBLDETALLESPRODUCTO.Text = "Datos del producto"
        Me.LBLDETALLESPRODUCTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(820, 39)
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
        Me.LBLUSUARIOACTUAL.AutoSize = True
        Me.LBLUSUARIOACTUAL.BackColor = System.Drawing.Color.Transparent
        Me.LBLUSUARIOACTUAL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBLUSUARIOACTUAL.Font = New System.Drawing.Font("Dubai", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSUARIOACTUAL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LBLUSUARIOACTUAL.Location = New System.Drawing.Point(894, 40)
        Me.LBLUSUARIOACTUAL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LBLUSUARIOACTUAL.Name = "LBLUSUARIOACTUAL"
        Me.LBLUSUARIOACTUAL.Size = New System.Drawing.Size(2, 26)
        Me.LBLUSUARIOACTUAL.TabIndex = 6
        '
        'CmbClientes
        '
        Me.CmbClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbClientes.BackColor = System.Drawing.SystemColors.Window
        Me.CmbClientes.DataSource = Me.VISTACLIENTESBindingSource
        Me.CmbClientes.DisplayMember = "Expr1"
        Me.CmbClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbClientes.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbClientes.FormattingEnabled = True
        Me.CmbClientes.Location = New System.Drawing.Point(77, 82)
        Me.CmbClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbClientes.Name = "CmbClientes"
        Me.CmbClientes.Size = New System.Drawing.Size(1107, 35)
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
        Me.GRUPO1.Size = New System.Drawing.Size(1184, 130)
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
        'FrmAltaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BTNPAGAR)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTENGANCHE As TextBox
    Friend WithEvents CmbClave As ComboBox
    Friend WithEvents LBLCLAVE As Label
    Friend WithEvents CMBEXISTENCIAS As ComboBox
    Friend WithEvents Label2 As Label
End Class
