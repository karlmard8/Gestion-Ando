<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Me.DATACLIENTES = New System.Windows.Forms.DataGridView()
        Me.CLINOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIAPEPATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIAPEMATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clientes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIDIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIColonia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICiudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLITelEfono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIHISTORIALCREDITICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICORREO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIRFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIREGIMENFISCAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICFDI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICOMENTARIOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VISTACLIENTESPRINCIPALBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CLIIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CMBFILTRO = New System.Windows.Forms.ComboBox()
        Me.TBLCLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLCLIENTESTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.TBLCLIENTESTableAdapter()
        Me.VISTACLIENTESPRINCIPALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VISTACLIENTESPRINCIPALTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTACLIENTESPRINCIPALTableAdapter()
        CType(Me.DATACLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTACLIENTESPRINCIPALBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTACLIENTESPRINCIPALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DATACLIENTES
        '
        Me.DATACLIENTES.AllowUserToAddRows = False
        Me.DATACLIENTES.AllowUserToDeleteRows = False
        Me.DATACLIENTES.AllowUserToResizeColumns = False
        Me.DATACLIENTES.AllowUserToResizeRows = False
        Me.DATACLIENTES.AutoGenerateColumns = False
        Me.DATACLIENTES.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DATACLIENTES.BackgroundColor = System.Drawing.Color.White
        Me.DATACLIENTES.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DATACLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATACLIENTES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLINOMBRE, Me.CLIAPEPATERNO, Me.CLIAPEMATERNO, Me.CLIID, Me.CLICODIGO, Me.Clientes, Me.CLIDIRECCION, Me.CLIColonia, Me.CLICP, Me.CLICiudad, Me.CLIEstado, Me.CLITelEfono, Me.CLIHISTORIALCREDITICIO, Me.CLICORREO, Me.CLIRFC, Me.CLIREGIMENFISCAL, Me.CLICFDI, Me.CLICOMENTARIOS})
        Me.DATACLIENTES.DataSource = Me.VISTACLIENTESPRINCIPALBindingSource1
        Me.DATACLIENTES.GridColor = System.Drawing.SystemColors.Control
        Me.DATACLIENTES.Location = New System.Drawing.Point(12, 92)
        Me.DATACLIENTES.MultiSelect = False
        Me.DATACLIENTES.Name = "DATACLIENTES"
        Me.DATACLIENTES.ReadOnly = True
        Me.DATACLIENTES.RowHeadersVisible = False
        Me.DATACLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATACLIENTES.Size = New System.Drawing.Size(1862, 720)
        Me.DATACLIENTES.TabIndex = 0
        Me.DATACLIENTES.TabStop = False
        '
        'CLINOMBRE
        '
        Me.CLINOMBRE.DataPropertyName = "CLINOMBRE"
        Me.CLINOMBRE.HeaderText = "CLINOMBRE"
        Me.CLINOMBRE.Name = "CLINOMBRE"
        Me.CLINOMBRE.ReadOnly = True
        Me.CLINOMBRE.Visible = False
        '
        'CLIAPEPATERNO
        '
        Me.CLIAPEPATERNO.DataPropertyName = "CLIAPEPATERNO"
        Me.CLIAPEPATERNO.HeaderText = "CLIAPEPATERNO"
        Me.CLIAPEPATERNO.Name = "CLIAPEPATERNO"
        Me.CLIAPEPATERNO.ReadOnly = True
        Me.CLIAPEPATERNO.Visible = False
        '
        'CLIAPEMATERNO
        '
        Me.CLIAPEMATERNO.DataPropertyName = "CLIAPEMATERNO"
        Me.CLIAPEMATERNO.HeaderText = "CLIAPEMATERNO"
        Me.CLIAPEMATERNO.Name = "CLIAPEMATERNO"
        Me.CLIAPEMATERNO.ReadOnly = True
        Me.CLIAPEMATERNO.Visible = False
        '
        'CLIID
        '
        Me.CLIID.DataPropertyName = "CLIID"
        Me.CLIID.HeaderText = "CLIID"
        Me.CLIID.Name = "CLIID"
        Me.CLIID.ReadOnly = True
        Me.CLIID.Visible = False
        '
        'CLICODIGO
        '
        Me.CLICODIGO.DataPropertyName = "CLICODIGO"
        Me.CLICODIGO.HeaderText = "CLICODIGO"
        Me.CLICODIGO.Name = "CLICODIGO"
        Me.CLICODIGO.ReadOnly = True
        Me.CLICODIGO.Visible = False
        '
        'Clientes
        '
        Me.Clientes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Clientes.DataPropertyName = "Cliente"
        Me.Clientes.HeaderText = "Cliente"
        Me.Clientes.Name = "Clientes"
        Me.Clientes.ReadOnly = True
        Me.Clientes.Width = 64
        '
        'CLIDIRECCION
        '
        Me.CLIDIRECCION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CLIDIRECCION.DataPropertyName = "Calle y número"
        Me.CLIDIRECCION.HeaderText = "Calle y número"
        Me.CLIDIRECCION.Name = "CLIDIRECCION"
        Me.CLIDIRECCION.ReadOnly = True
        Me.CLIDIRECCION.Width = 160
        '
        'CLIColonia
        '
        Me.CLIColonia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CLIColonia.DataPropertyName = "Colonia"
        Me.CLIColonia.HeaderText = "Colonia"
        Me.CLIColonia.Name = "CLIColonia"
        Me.CLIColonia.ReadOnly = True
        '
        'CLICP
        '
        Me.CLICP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.CLICP.DataPropertyName = "Código postal"
        Me.CLICP.HeaderText = "Código postal"
        Me.CLICP.Name = "CLICP"
        Me.CLICP.ReadOnly = True
        Me.CLICP.Width = 96
        '
        'CLICiudad
        '
        Me.CLICiudad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLICiudad.DataPropertyName = "Ciudad"
        Me.CLICiudad.HeaderText = "Ciudad"
        Me.CLICiudad.Name = "CLICiudad"
        Me.CLICiudad.ReadOnly = True
        Me.CLICiudad.Width = 65
        '
        'CLIEstado
        '
        Me.CLIEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLIEstado.DataPropertyName = "Estado"
        Me.CLIEstado.HeaderText = "Estado"
        Me.CLIEstado.Name = "CLIEstado"
        Me.CLIEstado.ReadOnly = True
        Me.CLIEstado.Width = 65
        '
        'CLITelEfono
        '
        Me.CLITelEfono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CLITelEfono.DataPropertyName = "Teléfono"
        Me.CLITelEfono.HeaderText = "Teléfono"
        Me.CLITelEfono.Name = "CLITelEfono"
        Me.CLITelEfono.ReadOnly = True
        Me.CLITelEfono.Width = 74
        '
        'CLIHISTORIALCREDITICIO
        '
        Me.CLIHISTORIALCREDITICIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CLIHISTORIALCREDITICIO.DataPropertyName = "Crédito"
        Me.CLIHISTORIALCREDITICIO.HeaderText = "Crédito"
        Me.CLIHISTORIALCREDITICIO.Name = "CLIHISTORIALCREDITICIO"
        Me.CLIHISTORIALCREDITICIO.ReadOnly = True
        Me.CLIHISTORIALCREDITICIO.Width = 65
        '
        'CLICORREO
        '
        Me.CLICORREO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.CLICORREO.DataPropertyName = "Correo"
        Me.CLICORREO.HeaderText = "Correo"
        Me.CLICORREO.Name = "CLICORREO"
        Me.CLICORREO.ReadOnly = True
        Me.CLICORREO.Width = 63
        '
        'CLIRFC
        '
        Me.CLIRFC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.CLIRFC.DataPropertyName = "RFC"
        Me.CLIRFC.HeaderText = "RFC"
        Me.CLIRFC.Name = "CLIRFC"
        Me.CLIRFC.ReadOnly = True
        Me.CLIRFC.Width = 53
        '
        'CLIREGIMENFISCAL
        '
        Me.CLIREGIMENFISCAL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CLIREGIMENFISCAL.DataPropertyName = "Régimen fiscal"
        Me.CLIREGIMENFISCAL.HeaderText = "Régimen fiscal"
        Me.CLIREGIMENFISCAL.Name = "CLIREGIMENFISCAL"
        Me.CLIREGIMENFISCAL.ReadOnly = True
        Me.CLIREGIMENFISCAL.Width = 150
        '
        'CLICFDI
        '
        Me.CLICFDI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CLICFDI.DataPropertyName = "Uso de CFDI"
        Me.CLICFDI.HeaderText = "Uso de CFDI"
        Me.CLICFDI.Name = "CLICFDI"
        Me.CLICFDI.ReadOnly = True
        Me.CLICFDI.Width = 150
        '
        'CLICOMENTARIOS
        '
        Me.CLICOMENTARIOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CLICOMENTARIOS.DataPropertyName = "Notas"
        Me.CLICOMENTARIOS.HeaderText = "Notas"
        Me.CLICOMENTARIOS.Name = "CLICOMENTARIOS"
        Me.CLICOMENTARIOS.ReadOnly = True
        '
        'VISTACLIENTESPRINCIPALBindingSource1
        '
        Me.VISTACLIENTESPRINCIPALBindingSource1.DataMember = "VISTACLIENTESPRINCIPAL"
        Me.VISTACLIENTESPRINCIPALBindingSource1.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(1741, 852)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.Text = "Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = False
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(1341, 852)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(132, 54)
        Me.BTNNUEVO.TabIndex = 1
        Me.BTNNUEVO.Text = "Nuevo"
        Me.BTNNUEVO.UseVisualStyleBackColor = False
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BTNEDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEDITAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDITAR.Location = New System.Drawing.Point(1540, 852)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNEDITAR.TabIndex = 2
        Me.BTNEDITAR.Text = "Editar"
        Me.BTNEDITAR.UseVisualStyleBackColor = False
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBUSCAR.Location = New System.Drawing.Point(111, 30)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(651, 29)
        Me.TXTBUSCAR.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 32)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1052, 62)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'CLIIDDataGridViewTextBoxColumn
        '
        Me.CLIIDDataGridViewTextBoxColumn.DataPropertyName = "CLIID"
        Me.CLIIDDataGridViewTextBoxColumn.HeaderText = "CLIID"
        Me.CLIIDDataGridViewTextBoxColumn.Name = "CLIIDDataGridViewTextBoxColumn"
        Me.CLIIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIIDDataGridViewTextBoxColumn.Visible = False
        '
        'Cliente
        '
        Me.Cliente.DataPropertyName = "Cliente"
        Me.Cliente.HeaderText = "Cliente"
        Me.Cliente.Name = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(795, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 32)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Filtrar por"
        '
        'CMBFILTRO
        '
        Me.CMBFILTRO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBFILTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBFILTRO.FormattingEnabled = True
        Me.CMBFILTRO.Items.AddRange(New Object() {"Cliente", "Colonia", "Ciudad"})
        Me.CMBFILTRO.Location = New System.Drawing.Point(896, 30)
        Me.CMBFILTRO.Name = "CMBFILTRO"
        Me.CMBFILTRO.Size = New System.Drawing.Size(121, 28)
        Me.CMBFILTRO.TabIndex = 15
        '
        'TBLCLIENTESBindingSource
        '
        Me.TBLCLIENTESBindingSource.DataMember = "TBLCLIENTES"
        Me.TBLCLIENTESBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'TBLCLIENTESTableAdapter
        '
        Me.TBLCLIENTESTableAdapter.ClearBeforeFill = True
        '
        'VISTACLIENTESPRINCIPALBindingSource
        '
        Me.VISTACLIENTESPRINCIPALBindingSource.DataMember = "VISTACLIENTESPRINCIPAL"
        Me.VISTACLIENTESPRINCIPALBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'VISTACLIENTESPRINCIPALTableAdapter
        '
        Me.VISTACLIENTESPRINCIPALTableAdapter.ClearBeforeFill = True
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1886, 930)
        Me.Controls.Add(Me.CMBFILTRO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTBUSCAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNEDITAR)
        Me.Controls.Add(Me.BTNNUEVO)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.DATACLIENTES)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmClientes"
        Me.Text = "FrmClientes"
        CType(Me.DATACLIENTES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTACLIENTESPRINCIPALBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTACLIENTESPRINCIPALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DATACLIENTES As DataGridView
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents TBLCLIENTESBindingSource As BindingSource
    Friend WithEvents TBLCLIENTESTableAdapter As MuebleAlexDataSetTableAdapters.TBLCLIENTESTableAdapter
    Friend WithEvents BTNELIMINAR As Button
    Friend WithEvents BTNNUEVO As Button
    Friend WithEvents BTNEDITAR As Button
    Friend WithEvents TXTBUSCAR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents VISTACLIENTESPRINCIPALBindingSource As BindingSource
    Friend WithEvents VISTACLIENTESPRINCIPALTableAdapter As MuebleAlexDataSetTableAdapters.VISTACLIENTESPRINCIPALTableAdapter
    Friend WithEvents VISTACLIENTESPRINCIPALBindingSource1 As BindingSource
    Friend WithEvents CLIIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents CMBFILTRO As ComboBox
    Friend WithEvents CLINOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CLIAPEPATERNO As DataGridViewTextBoxColumn
    Friend WithEvents CLIAPEMATERNO As DataGridViewTextBoxColumn
    Friend WithEvents CLIID As DataGridViewTextBoxColumn
    Friend WithEvents CLICODIGO As DataGridViewTextBoxColumn
    Friend WithEvents Clientes As DataGridViewTextBoxColumn
    Friend WithEvents CLIDIRECCION As DataGridViewTextBoxColumn
    Friend WithEvents CLIColonia As DataGridViewTextBoxColumn
    Friend WithEvents CLICP As DataGridViewTextBoxColumn
    Friend WithEvents CLICiudad As DataGridViewTextBoxColumn
    Friend WithEvents CLIEstado As DataGridViewTextBoxColumn
    Friend WithEvents CLITelEfono As DataGridViewTextBoxColumn
    Friend WithEvents CLIHISTORIALCREDITICIO As DataGridViewTextBoxColumn
    Friend WithEvents CLICORREO As DataGridViewTextBoxColumn
    Friend WithEvents CLIRFC As DataGridViewTextBoxColumn
    Friend WithEvents CLIREGIMENFISCAL As DataGridViewTextBoxColumn
    Friend WithEvents CLICFDI As DataGridViewTextBoxColumn
    Friend WithEvents CLICOMENTARIOS As DataGridViewTextBoxColumn
End Class
