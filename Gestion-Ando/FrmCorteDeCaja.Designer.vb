﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.ETIQUETAS = New System.Windows.Forms.GroupBox()
        Me.LBLGANANCIAS = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BTNHISTORIALCAJA = New System.Windows.Forms.Button()
        Me.BTNREPORTECAJA = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LBLNOTAS = New System.Windows.Forms.Label()
        Me.TXTSALDOREAL = New System.Windows.Forms.TextBox()
        Me.TXTNOTAS = New System.Windows.Forms.TextBox()
        Me.LBLSALDOREAL = New System.Windows.Forms.Label()
        Me.BTNABRIRCAJA = New System.Windows.Forms.Button()
        Me.BTNCERRARCAJA = New System.Windows.Forms.Button()
        Me.CAJABOTONES = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DATACORTECAJA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTACORTECAJABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ETIQUETAS.SuspendLayout()
        Me.CAJABOTONES.SuspendLayout()
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
        Me.LBLINGRESOS.Location = New System.Drawing.Point(280, 75)
        Me.LBLINGRESOS.Name = "LBLINGRESOS"
        Me.LBLINGRESOS.Size = New System.Drawing.Size(34, 32)
        Me.LBLINGRESOS.TabIndex = 10
        Me.LBLINGRESOS.Text = ". . ."
        '
        'LBLEGRESOS
        '
        Me.LBLEGRESOS.AutoSize = True
        Me.LBLEGRESOS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLEGRESOS.Location = New System.Drawing.Point(490, 75)
        Me.LBLEGRESOS.Name = "LBLEGRESOS"
        Me.LBLEGRESOS.Size = New System.Drawing.Size(34, 32)
        Me.LBLEGRESOS.TabIndex = 11
        Me.LBLEGRESOS.Text = ". . ."
        '
        'LBLSALDOFINAL
        '
        Me.LBLSALDOFINAL.AutoSize = True
        Me.LBLSALDOFINAL.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSALDOFINAL.Location = New System.Drawing.Point(700, 75)
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
        'ETIQUETAS
        '
        Me.ETIQUETAS.Controls.Add(Me.LBLGANANCIAS)
        Me.ETIQUETAS.Controls.Add(Me.Label8)
        Me.ETIQUETAS.Controls.Add(Me.Label4)
        Me.ETIQUETAS.Controls.Add(Me.Label2)
        Me.ETIQUETAS.Controls.Add(Me.Label3)
        Me.ETIQUETAS.Controls.Add(Me.LBLSALDOFINAL)
        Me.ETIQUETAS.Controls.Add(Me.Label5)
        Me.ETIQUETAS.Controls.Add(Me.LBLEGRESOS)
        Me.ETIQUETAS.Controls.Add(Me.LBLSALDOINICIAL)
        Me.ETIQUETAS.Controls.Add(Me.LBLINGRESOS)
        Me.ETIQUETAS.Location = New System.Drawing.Point(921, 464)
        Me.ETIQUETAS.Name = "ETIQUETAS"
        Me.ETIQUETAS.Size = New System.Drawing.Size(849, 321)
        Me.ETIQUETAS.TabIndex = 16
        Me.ETIQUETAS.TabStop = False
        '
        'LBLGANANCIAS
        '
        Me.LBLGANANCIAS.AutoSize = True
        Me.LBLGANANCIAS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLGANANCIAS.Location = New System.Drawing.Point(372, 225)
        Me.LBLGANANCIAS.Name = "LBLGANANCIAS"
        Me.LBLGANANCIAS.Size = New System.Drawing.Size(34, 32)
        Me.LBLGANANCIAS.TabIndex = 14
        Me.LBLGANANCIAS.Text = ". . ."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 32)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Ganancias del día"
        '
        'BTNHISTORIALCAJA
        '
        Me.BTNHISTORIALCAJA.AutoSize = True
        Me.BTNHISTORIALCAJA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNHISTORIALCAJA.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHISTORIALCAJA.Location = New System.Drawing.Point(497, 19)
        Me.BTNHISTORIALCAJA.Name = "BTNHISTORIALCAJA"
        Me.BTNHISTORIALCAJA.Size = New System.Drawing.Size(173, 42)
        Me.BTNHISTORIALCAJA.TabIndex = 19
        Me.BTNHISTORIALCAJA.Text = "Historial de cajas"
        Me.BTNHISTORIALCAJA.UseVisualStyleBackColor = True
        '
        'BTNREPORTECAJA
        '
        Me.BTNREPORTECAJA.AutoSize = True
        Me.BTNREPORTECAJA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTECAJA.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTECAJA.Location = New System.Drawing.Point(676, 19)
        Me.BTNREPORTECAJA.Name = "BTNREPORTECAJA"
        Me.BTNREPORTECAJA.Size = New System.Drawing.Size(147, 42)
        Me.BTNREPORTECAJA.TabIndex = 20
        Me.BTNREPORTECAJA.Text = "Reporte global"
        Me.BTNREPORTECAJA.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(511, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 18)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "* Opcional"
        '
        'LBLNOTAS
        '
        Me.LBLNOTAS.AutoSize = True
        Me.LBLNOTAS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNOTAS.Location = New System.Drawing.Point(565, 279)
        Me.LBLNOTAS.Name = "LBLNOTAS"
        Me.LBLNOTAS.Size = New System.Drawing.Size(120, 32)
        Me.LBLNOTAS.TabIndex = 14
        Me.LBLNOTAS.Text = "Notas de caja"
        '
        'TXTSALDOREAL
        '
        Me.TXTSALDOREAL.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSALDOREAL.Location = New System.Drawing.Point(691, 171)
        Me.TXTSALDOREAL.MaxLength = 10
        Me.TXTSALDOREAL.Name = "TXTSALDOREAL"
        Me.TXTSALDOREAL.Size = New System.Drawing.Size(265, 40)
        Me.TXTSALDOREAL.TabIndex = 12
        '
        'TXTNOTAS
        '
        Me.TXTNOTAS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOTAS.Location = New System.Drawing.Point(691, 271)
        Me.TXTNOTAS.MaxLength = 255
        Me.TXTNOTAS.Name = "TXTNOTAS"
        Me.TXTNOTAS.Size = New System.Drawing.Size(265, 40)
        Me.TXTNOTAS.TabIndex = 13
        '
        'LBLSALDOREAL
        '
        Me.LBLSALDOREAL.AutoSize = True
        Me.LBLSALDOREAL.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLSALDOREAL.Location = New System.Drawing.Point(558, 179)
        Me.LBLSALDOREAL.Name = "LBLSALDOREAL"
        Me.LBLSALDOREAL.Size = New System.Drawing.Size(126, 32)
        Me.LBLSALDOREAL.TabIndex = 18
        Me.LBLSALDOREAL.Text = "Dinero en caja"
        '
        'BTNABRIRCAJA
        '
        Me.BTNABRIRCAJA.AutoSize = True
        Me.BTNABRIRCAJA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNABRIRCAJA.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNABRIRCAJA.Location = New System.Drawing.Point(61, 19)
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
        Me.BTNCERRARCAJA.Location = New System.Drawing.Point(691, 19)
        Me.BTNCERRARCAJA.Name = "BTNCERRARCAJA"
        Me.BTNCERRARCAJA.Size = New System.Drawing.Size(141, 79)
        Me.BTNCERRARCAJA.TabIndex = 4
        Me.BTNCERRARCAJA.Text = "Cerrar caja"
        Me.BTNCERRARCAJA.UseVisualStyleBackColor = True
        '
        'CAJABOTONES
        '
        Me.CAJABOTONES.Controls.Add(Me.Label7)
        Me.CAJABOTONES.Controls.Add(Me.BTNCERRARCAJA)
        Me.CAJABOTONES.Controls.Add(Me.Label6)
        Me.CAJABOTONES.Controls.Add(Me.BTNABRIRCAJA)
        Me.CAJABOTONES.Controls.Add(Me.TXTSALDOREAL)
        Me.CAJABOTONES.Controls.Add(Me.LBLNOTAS)
        Me.CAJABOTONES.Controls.Add(Me.TXTNOTAS)
        Me.CAJABOTONES.Controls.Add(Me.LBLSALDOREAL)
        Me.CAJABOTONES.Location = New System.Drawing.Point(873, 85)
        Me.CAJABOTONES.Name = "CAJABOTONES"
        Me.CAJABOTONES.Size = New System.Drawing.Size(967, 358)
        Me.CAJABOTONES.TabIndex = 21
        Me.CAJABOTONES.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(620, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(212, 18)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "*Completa los campos antes de cerrar la caja"
        '
        'FrmCorteDeCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1886, 930)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTNREPORTECAJA)
        Me.Controls.Add(Me.BTNHISTORIALCAJA)
        Me.Controls.Add(Me.CMBUSUARIO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DATACORTECAJA)
        Me.Controls.Add(Me.ETIQUETAS)
        Me.Controls.Add(Me.CAJABOTONES)
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
        Me.CAJABOTONES.ResumeLayout(False)
        Me.CAJABOTONES.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DATACORTECAJA As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBUSUARIO As ComboBox
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
    Friend WithEvents ETIQUETAS As GroupBox
    Friend WithEvents BTNHISTORIALCAJA As Button
    Friend WithEvents BTNREPORTECAJA As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LBLNOTAS As Label
    Friend WithEvents TXTSALDOREAL As TextBox
    Friend WithEvents TXTNOTAS As TextBox
    Friend WithEvents LBLSALDOREAL As Label
    Friend WithEvents BTNABRIRCAJA As Button
    Friend WithEvents BTNCERRARCAJA As Button
    Friend WithEvents CAJABOTONES As GroupBox
    Friend WithEvents LBLGANANCIAS As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
End Class
