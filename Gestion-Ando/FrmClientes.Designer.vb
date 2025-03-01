<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientes
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
        Me.DATACLIENTES = New System.Windows.Forms.DataGridView()
        Me.CLIID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLINOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIAPEPATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIAPEMATERNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIDIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICOLONIA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICIUDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIESTADO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLITELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICOMENTARIOS = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIHISTORIALCREDITICIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIRFC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIREGIMENFISCAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLICFDI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIEXISTE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TBLCLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.TBLCLIENTESTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.TBLCLIENTESTableAdapter()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DATACLIENTES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DATACLIENTES
        '
        Me.DATACLIENTES.AllowUserToAddRows = False
        Me.DATACLIENTES.AllowUserToDeleteRows = False
        Me.DATACLIENTES.AllowUserToOrderColumns = True
        Me.DATACLIENTES.AutoGenerateColumns = False
        Me.DATACLIENTES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATACLIENTES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CLIID, Me.CLICODIGO, Me.CLINOMBRE, Me.CLIAPEPATERNO, Me.CLIAPEMATERNO, Me.CLIDIRECCION, Me.CLICOLONIA, Me.CLICP, Me.CLICIUDAD, Me.CLIESTADO, Me.CLITELEFONO, Me.CLICOMENTARIOS, Me.CLIHISTORIALCREDITICIO, Me.CLIRFC, Me.CLIREGIMENFISCAL, Me.CLICFDI, Me.CLIEXISTE})
        Me.DATACLIENTES.DataSource = Me.TBLCLIENTESBindingSource
        Me.DATACLIENTES.Location = New System.Drawing.Point(12, 92)
        Me.DATACLIENTES.Name = "DATACLIENTES"
        Me.DATACLIENTES.ReadOnly = True
        Me.DATACLIENTES.RowHeadersVisible = False
        Me.DATACLIENTES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATACLIENTES.Size = New System.Drawing.Size(1830, 720)
        Me.DATACLIENTES.TabIndex = 0
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
        Me.CLICODIGO.HeaderText = "Código de cliente"
        Me.CLICODIGO.Name = "CLICODIGO"
        Me.CLICODIGO.ReadOnly = True
        Me.CLICODIGO.Visible = False
        '
        'CLINOMBRE
        '
        Me.CLINOMBRE.DataPropertyName = "CLINOMBRE"
        Me.CLINOMBRE.HeaderText = "Nombre"
        Me.CLINOMBRE.Name = "CLINOMBRE"
        Me.CLINOMBRE.ReadOnly = True
        Me.CLINOMBRE.Width = 150
        '
        'CLIAPEPATERNO
        '
        Me.CLIAPEPATERNO.DataPropertyName = "CLIAPEPATERNO"
        Me.CLIAPEPATERNO.HeaderText = "Apellido paterno"
        Me.CLIAPEPATERNO.Name = "CLIAPEPATERNO"
        Me.CLIAPEPATERNO.ReadOnly = True
        Me.CLIAPEPATERNO.Width = 150
        '
        'CLIAPEMATERNO
        '
        Me.CLIAPEMATERNO.DataPropertyName = "CLIAPEMATERNO"
        Me.CLIAPEMATERNO.HeaderText = "Apellido materno"
        Me.CLIAPEMATERNO.Name = "CLIAPEMATERNO"
        Me.CLIAPEMATERNO.ReadOnly = True
        Me.CLIAPEMATERNO.Width = 150
        '
        'CLIDIRECCION
        '
        Me.CLIDIRECCION.DataPropertyName = "CLIDIRECCION"
        Me.CLIDIRECCION.HeaderText = "Calle y número"
        Me.CLIDIRECCION.Name = "CLIDIRECCION"
        Me.CLIDIRECCION.ReadOnly = True
        Me.CLIDIRECCION.Width = 150
        '
        'CLICOLONIA
        '
        Me.CLICOLONIA.DataPropertyName = "CLICOLONIA"
        Me.CLICOLONIA.HeaderText = "Colonia"
        Me.CLICOLONIA.Name = "CLICOLONIA"
        Me.CLICOLONIA.ReadOnly = True
        '
        'CLICP
        '
        Me.CLICP.DataPropertyName = "CLICP"
        Me.CLICP.HeaderText = "Código postal"
        Me.CLICP.Name = "CLICP"
        Me.CLICP.ReadOnly = True
        '
        'CLICIUDAD
        '
        Me.CLICIUDAD.DataPropertyName = "CLICIUDAD"
        Me.CLICIUDAD.HeaderText = "Ciudad"
        Me.CLICIUDAD.Name = "CLICIUDAD"
        Me.CLICIUDAD.ReadOnly = True
        Me.CLICIUDAD.Width = 120
        '
        'CLIESTADO
        '
        Me.CLIESTADO.DataPropertyName = "CLIESTADO"
        Me.CLIESTADO.HeaderText = "Estado"
        Me.CLIESTADO.Name = "CLIESTADO"
        Me.CLIESTADO.ReadOnly = True
        Me.CLIESTADO.Width = 120
        '
        'CLITELEFONO
        '
        Me.CLITELEFONO.DataPropertyName = "CLITELEFONO"
        Me.CLITELEFONO.HeaderText = "Teléfono"
        Me.CLITELEFONO.Name = "CLITELEFONO"
        Me.CLITELEFONO.ReadOnly = True
        Me.CLITELEFONO.Width = 120
        '
        'CLICOMENTARIOS
        '
        Me.CLICOMENTARIOS.DataPropertyName = "CLICOMENTARIOS"
        Me.CLICOMENTARIOS.HeaderText = "Nota"
        Me.CLICOMENTARIOS.Name = "CLICOMENTARIOS"
        Me.CLICOMENTARIOS.ReadOnly = True
        Me.CLICOMENTARIOS.Width = 197
        '
        'CLIHISTORIALCREDITICIO
        '
        Me.CLIHISTORIALCREDITICIO.DataPropertyName = "CLIHISTORIALCREDITO"
        Me.CLIHISTORIALCREDITICIO.HeaderText = "Historial crediticio"
        Me.CLIHISTORIALCREDITICIO.Name = "CLIHISTORIALCREDITICIO"
        Me.CLIHISTORIALCREDITICIO.ReadOnly = True
        Me.CLIHISTORIALCREDITICIO.Width = 120
        '
        'CLIRFC
        '
        Me.CLIRFC.DataPropertyName = "CLIRFC"
        Me.CLIRFC.HeaderText = "RFC"
        Me.CLIRFC.Name = "CLIRFC"
        Me.CLIRFC.ReadOnly = True
        '
        'CLIREGIMENFISCAL
        '
        Me.CLIREGIMENFISCAL.DataPropertyName = "CLIREGIMENFISCAL"
        Me.CLIREGIMENFISCAL.HeaderText = "Régimen fiscal"
        Me.CLIREGIMENFISCAL.Name = "CLIREGIMENFISCAL"
        Me.CLIREGIMENFISCAL.ReadOnly = True
        Me.CLIREGIMENFISCAL.Width = 150
        '
        'CLICFDI
        '
        Me.CLICFDI.DataPropertyName = "CLICFDI"
        Me.CLICFDI.HeaderText = "CFDI"
        Me.CLICFDI.Name = "CLICFDI"
        Me.CLICFDI.ReadOnly = True
        '
        'CLIEXISTE
        '
        Me.CLIEXISTE.DataPropertyName = "CLIEXISTE"
        Me.CLIEXISTE.HeaderText = "CLIEXISTE"
        Me.CLIEXISTE.Name = "CLIEXISTE"
        Me.CLIEXISTE.ReadOnly = True
        Me.CLIEXISTE.Visible = False
        '
        'TBLCLIENTESBindingSource
        '
        Me.TBLCLIENTESBindingSource.DataMember = "TBLCLIENTES"
        Me.TBLCLIENTESBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLCLIENTESTableAdapter
        '
        Me.TBLCLIENTESTableAdapter.ClearBeforeFill = True
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(1710, 856)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNELIMINAR.TabIndex = 3
        Me.BTNELIMINAR.Text = "Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(1310, 856)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(132, 54)
        Me.BTNNUEVO.TabIndex = 1
        Me.BTNNUEVO.Text = "Nuevo"
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEDITAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDITAR.Location = New System.Drawing.Point(1509, 856)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNEDITAR.TabIndex = 2
        Me.BTNEDITAR.Text = "Editar"
        Me.BTNEDITAR.UseVisualStyleBackColor = True
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Location = New System.Drawing.Point(118, 30)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(927, 20)
        Me.TXTBUSCAR.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 27)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1052, 53)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1860, 930)
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
        CType(Me.TBLCLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CLIID As DataGridViewTextBoxColumn
    Friend WithEvents CLICODIGO As DataGridViewTextBoxColumn
    Friend WithEvents CLINOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents CLIAPEPATERNO As DataGridViewTextBoxColumn
    Friend WithEvents CLIAPEMATERNO As DataGridViewTextBoxColumn
    Friend WithEvents CLIDIRECCION As DataGridViewTextBoxColumn
    Friend WithEvents CLICOLONIA As DataGridViewTextBoxColumn
    Friend WithEvents CLICP As DataGridViewTextBoxColumn
    Friend WithEvents CLICIUDAD As DataGridViewTextBoxColumn
    Friend WithEvents CLIESTADO As DataGridViewTextBoxColumn
    Friend WithEvents CLITELEFONO As DataGridViewTextBoxColumn
    Friend WithEvents CLICOMENTARIOS As DataGridViewTextBoxColumn
    Friend WithEvents CLIHISTORIALCREDITICIO As DataGridViewTextBoxColumn
    Friend WithEvents CLIRFC As DataGridViewTextBoxColumn
    Friend WithEvents CLIREGIMENFISCAL As DataGridViewTextBoxColumn
    Friend WithEvents CLICFDI As DataGridViewTextBoxColumn
    Friend WithEvents CLIEXISTE As DataGridViewCheckBoxColumn
End Class
