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
        Me.TXTNOTAS = New System.Windows.Forms.TextBox()
        Me.LBLNOTAS = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ETIQUETAS = New System.Windows.Forms.GroupBox()
        Me.TXTSALDOREAL = New System.Windows.Forms.TextBox()
        Me.LBLSALDOREAL = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DATACORTECAJA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTACORTECAJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ETIQUETAS.SuspendLayout()
        Me.SuspendLayout()
        '
        'DATACORTECAJA
        '
        Me.DATACORTECAJA.AllowUserToAddRows = False
        Me.DATACORTECAJA.AllowUserToDeleteRows = False
        Me.DATACORTECAJA.AllowUserToResizeColumns = False
        Me.DATACORTECAJA.AllowUserToResizeRows = False
        Me.DATACORTECAJA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DATACORTECAJA.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DATACORTECAJA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DATACORTECAJA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATACORTECAJA.Location = New System.Drawing.Point(12, 85)
        Me.DATACORTECAJA.MultiSelect = False
        Me.DATACORTECAJA.Name = "DATACORTECAJA"
        Me.DATACORTECAJA.ReadOnly = True
        Me.DATACORTECAJA.RowHeadersVisible = False
        Me.DATACORTECAJA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATACORTECAJA.Size = New System.Drawing.Size(811, 800)
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
        Me.Label1.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 32)
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
        Me.CMBUSUARIO.Location = New System.Drawing.Point(161, 21)
        Me.CMBUSUARIO.Name = "CMBUSUARIO"
        Me.CMBUSUARIO.Size = New System.Drawing.Size(321, 35)
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
        Me.BTNABRIRCAJA.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNABRIRCAJA.Location = New System.Drawing.Point(962, 85)
        Me.BTNABRIRCAJA.Name = "BTNABRIRCAJA"
        Me.BTNABRIRCAJA.Size = New System.Drawing.Size(141, 79)
        Me.BTNABRIRCAJA.TabIndex = 3
        Me.BTNABRIRCAJA.Text = "Abrir caja"
        Me.BTNABRIRCAJA.UseVisualStyleBackColor = True
        '
        'BTNCERRARCAJA
        '
        Me.BTNCERRARCAJA.AutoSize = True
        Me.BTNCERRARCAJA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCERRARCAJA.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCERRARCAJA.Location = New System.Drawing.Point(1592, 85)
        Me.BTNCERRARCAJA.Name = "BTNCERRARCAJA"
        Me.BTNCERRARCAJA.Size = New System.Drawing.Size(141, 79)
        Me.BTNCERRARCAJA.TabIndex = 4
        Me.BTNCERRARCAJA.Text = "Cerrar caja"
        Me.BTNCERRARCAJA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 32)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Saldo inicial de caja"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(256, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 32)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ingresos a caja"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(469, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Egresos de caja"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(662, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Saldo final de caja"
        '
        'LBLSALDOINICIAL
        '
        Me.LBLSALDOINICIAL.AutoSize = True
        Me.LBLSALDOINICIAL.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSALDOINICIAL.Location = New System.Drawing.Point(67, 75)
        Me.LBLSALDOINICIAL.Name = "LBLSALDOINICIAL"
        Me.LBLSALDOINICIAL.Size = New System.Drawing.Size(34, 32)
        Me.LBLSALDOINICIAL.TabIndex = 9
        Me.LBLSALDOINICIAL.Text = ". . ."
        '
        'LBLINGRESOS
        '
        Me.LBLINGRESOS.AutoSize = True
        Me.LBLINGRESOS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLINGRESOS.Location = New System.Drawing.Point(267, 75)
        Me.LBLINGRESOS.Name = "LBLINGRESOS"
        Me.LBLINGRESOS.Size = New System.Drawing.Size(34, 32)
        Me.LBLINGRESOS.TabIndex = 10
        Me.LBLINGRESOS.Text = ". . ."
        '
        'LBLEGRESOS
        '
        Me.LBLEGRESOS.AutoSize = True
        Me.LBLEGRESOS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEGRESOS.Location = New System.Drawing.Point(507, 75)
        Me.LBLEGRESOS.Name = "LBLEGRESOS"
        Me.LBLEGRESOS.Size = New System.Drawing.Size(34, 32)
        Me.LBLEGRESOS.TabIndex = 11
        Me.LBLEGRESOS.Text = ". . ."
        '
        'LBLSALDOFINAL
        '
        Me.LBLSALDOFINAL.AutoSize = True
        Me.LBLSALDOFINAL.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSALDOFINAL.Location = New System.Drawing.Point(673, 75)
        Me.LBLSALDOFINAL.Name = "LBLSALDOFINAL"
        Me.LBLSALDOFINAL.Size = New System.Drawing.Size(34, 32)
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
        'TXTNOTAS
        '
        Me.TXTNOTAS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOTAS.Location = New System.Drawing.Point(1592, 272)
        Me.TXTNOTAS.MaxLength = 255
        Me.TXTNOTAS.Name = "TXTNOTAS"
        Me.TXTNOTAS.Size = New System.Drawing.Size(265, 40)
        Me.TXTNOTAS.TabIndex = 13
        '
        'LBLNOTAS
        '
        Me.LBLNOTAS.AutoSize = True
        Me.LBLNOTAS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNOTAS.Location = New System.Drawing.Point(1466, 280)
        Me.LBLNOTAS.Name = "LBLNOTAS"
        Me.LBLNOTAS.Size = New System.Drawing.Size(120, 32)
        Me.LBLNOTAS.TabIndex = 14
        Me.LBLNOTAS.Text = "Notas de caja"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1412, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "* Opcional"
        '
        'ETIQUETAS
        '
        Me.ETIQUETAS.Controls.Add(Me.Label4)
        Me.ETIQUETAS.Controls.Add(Me.Label2)
        Me.ETIQUETAS.Controls.Add(Me.Label3)
        Me.ETIQUETAS.Controls.Add(Me.LBLSALDOFINAL)
        Me.ETIQUETAS.Controls.Add(Me.Label5)
        Me.ETIQUETAS.Controls.Add(Me.LBLEGRESOS)
        Me.ETIQUETAS.Controls.Add(Me.LBLSALDOINICIAL)
        Me.ETIQUETAS.Controls.Add(Me.LBLINGRESOS)
        Me.ETIQUETAS.Location = New System.Drawing.Point(910, 465)
        Me.ETIQUETAS.Name = "ETIQUETAS"
        Me.ETIQUETAS.Size = New System.Drawing.Size(849, 131)
        Me.ETIQUETAS.TabIndex = 16
        Me.ETIQUETAS.TabStop = False
        '
        'TXTSALDOREAL
        '
        Me.TXTSALDOREAL.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSALDOREAL.Location = New System.Drawing.Point(1037, 272)
        Me.TXTSALDOREAL.MaxLength = 10
        Me.TXTSALDOREAL.Name = "TXTSALDOREAL"
        Me.TXTSALDOREAL.Size = New System.Drawing.Size(265, 40)
        Me.TXTSALDOREAL.TabIndex = 12
        '
        'LBLSALDOREAL
        '
        Me.LBLSALDOREAL.AutoSize = True
        Me.LBLSALDOREAL.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSALDOREAL.Location = New System.Drawing.Point(904, 280)
        Me.LBLSALDOREAL.Name = "LBLSALDOREAL"
        Me.LBLSALDOREAL.Size = New System.Drawing.Size(126, 32)
        Me.LBLSALDOREAL.TabIndex = 18
        Me.LBLSALDOREAL.Text = "Dinero en caja"
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(497, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 42)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Reporte de usuario"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(676, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(147, 42)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Reporte global"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FrmCorteDeCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1886, 930)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LBLSALDOREAL)
        Me.Controls.Add(Me.TXTSALDOREAL)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LBLNOTAS)
        Me.Controls.Add(Me.TXTNOTAS)
        Me.Controls.Add(Me.BTNCERRARCAJA)
        Me.Controls.Add(Me.BTNABRIRCAJA)
        Me.Controls.Add(Me.CMBUSUARIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DATACORTECAJA)
        Me.Controls.Add(Me.ETIQUETAS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCorteDeCaja"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DATACORTECAJA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTACORTECAJABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ETIQUETAS.ResumeLayout(False)
        Me.ETIQUETAS.PerformLayout()
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
    Friend WithEvents TXTNOTAS As TextBox
    Friend WithEvents LBLNOTAS As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ETIQUETAS As GroupBox
    Friend WithEvents TXTSALDOREAL As TextBox
    Friend WithEvents LBLSALDOREAL As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
