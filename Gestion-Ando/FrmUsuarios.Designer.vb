﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarios
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
        Me.DATAUSUARIOS = New System.Windows.Forms.DataGridView()
        Me.USUID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUNOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USULOGIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUCLAVE = New System.Windows.Forms.DataGridViewImageColumn()
        Me.USUTIPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USUEXISTE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.VISTAUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MuebleAlexDataSet = New Gestion_Ando.MuebleAlexDataSet()
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNEDITAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.TBLUSUARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBLUSUARIOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.TBLUSUARIOSTableAdapter()
        Me.VISTAUSUARIOSTableAdapter = New Gestion_Ando.MuebleAlexDataSetTableAdapters.VISTAUSUARIOSTableAdapter()
        CType(Me.DATAUSUARIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VISTAUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DATAUSUARIOS
        '
        Me.DATAUSUARIOS.AllowUserToAddRows = False
        Me.DATAUSUARIOS.AllowUserToDeleteRows = False
        Me.DATAUSUARIOS.AutoGenerateColumns = False
        Me.DATAUSUARIOS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DATAUSUARIOS.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.DATAUSUARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAUSUARIOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.USUID, Me.USUNOMBRE, Me.USULOGIN, Me.USUCLAVE, Me.USUTIPO, Me.USUEXISTE})
        Me.DATAUSUARIOS.DataSource = Me.VISTAUSUARIOSBindingSource
        Me.DATAUSUARIOS.Location = New System.Drawing.Point(12, 92)
        Me.DATAUSUARIOS.MultiSelect = False
        Me.DATAUSUARIOS.Name = "DATAUSUARIOS"
        Me.DATAUSUARIOS.ReadOnly = True
        Me.DATAUSUARIOS.RowHeadersVisible = False
        Me.DATAUSUARIOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATAUSUARIOS.Size = New System.Drawing.Size(704, 720)
        Me.DATAUSUARIOS.TabIndex = 0
        Me.DATAUSUARIOS.TabStop = False
        '
        'USUID
        '
        Me.USUID.DataPropertyName = "USUID"
        Me.USUID.HeaderText = "USUID"
        Me.USUID.Name = "USUID"
        Me.USUID.ReadOnly = True
        Me.USUID.Visible = False
        '
        'USUNOMBRE
        '
        Me.USUNOMBRE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.USUNOMBRE.DataPropertyName = "USUNOMBRE"
        Me.USUNOMBRE.HeaderText = "Usuario"
        Me.USUNOMBRE.Name = "USUNOMBRE"
        Me.USUNOMBRE.ReadOnly = True
        '
        'USULOGIN
        '
        Me.USULOGIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.USULOGIN.DataPropertyName = "USULOGIN"
        Me.USULOGIN.HeaderText = "Login"
        Me.USULOGIN.Name = "USULOGIN"
        Me.USULOGIN.ReadOnly = True
        Me.USULOGIN.Width = 58
        '
        'USUCLAVE
        '
        Me.USUCLAVE.DataPropertyName = "USUCLAVE"
        Me.USUCLAVE.HeaderText = "USUCLAVE"
        Me.USUCLAVE.Name = "USUCLAVE"
        Me.USUCLAVE.ReadOnly = True
        Me.USUCLAVE.Visible = False
        '
        'USUTIPO
        '
        Me.USUTIPO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.USUTIPO.DataPropertyName = "USUTIPO"
        Me.USUTIPO.HeaderText = "Tipo de usuario"
        Me.USUTIPO.Name = "USUTIPO"
        Me.USUTIPO.ReadOnly = True
        Me.USUTIPO.Width = 97
        '
        'USUEXISTE
        '
        Me.USUEXISTE.DataPropertyName = "USUEXISTE"
        Me.USUEXISTE.HeaderText = "USUEXISTE"
        Me.USUEXISTE.Name = "USUEXISTE"
        Me.USUEXISTE.ReadOnly = True
        Me.USUEXISTE.Visible = False
        '
        'VISTAUSUARIOSBindingSource
        '
        Me.VISTAUSUARIOSBindingSource.DataMember = "VISTAUSUARIOS"
        Me.VISTAUSUARIOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'MuebleAlexDataSet
        '
        Me.MuebleAlexDataSet.DataSetName = "MuebleAlexDataSet"
        Me.MuebleAlexDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBUSCAR.Location = New System.Drawing.Point(118, 30)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(575, 29)
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
        Me.PictureBox1.Size = New System.Drawing.Size(704, 62)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'BTNEDITAR
        '
        Me.BTNEDITAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEDITAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEDITAR.Location = New System.Drawing.Point(383, 855)
        Me.BTNEDITAR.Name = "BTNEDITAR"
        Me.BTNEDITAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNEDITAR.TabIndex = 13
        Me.BTNEDITAR.Text = "Editar"
        Me.BTNEDITAR.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(184, 855)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(132, 54)
        Me.BTNNUEVO.TabIndex = 12
        Me.BTNNUEVO.Text = "Nuevo"
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNELIMINAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNELIMINAR.Location = New System.Drawing.Point(584, 855)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(132, 54)
        Me.BTNELIMINAR.TabIndex = 14
        Me.BTNELIMINAR.Text = "Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = True
        '
        'TBLUSUARIOSBindingSource
        '
        Me.TBLUSUARIOSBindingSource.DataMember = "TBLUSUARIOS"
        Me.TBLUSUARIOSBindingSource.DataSource = Me.MuebleAlexDataSet
        '
        'TBLUSUARIOSTableAdapter
        '
        Me.TBLUSUARIOSTableAdapter.ClearBeforeFill = True
        '
        'VISTAUSUARIOSTableAdapter
        '
        Me.VISTAUSUARIOSTableAdapter.ClearBeforeFill = True
        '
        'FrmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 930)
        Me.Controls.Add(Me.BTNEDITAR)
        Me.Controls.Add(Me.BTNNUEVO)
        Me.Controls.Add(Me.BTNELIMINAR)
        Me.Controls.Add(Me.TXTBUSCAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DATAUSUARIOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUsuarios"
        CType(Me.DATAUSUARIOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VISTAUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MuebleAlexDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLUSUARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DATAUSUARIOS As DataGridView
    Friend WithEvents TXTBUSCAR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MuebleAlexDataSet As MuebleAlexDataSet
    Friend WithEvents TBLUSUARIOSBindingSource As BindingSource
    Friend WithEvents TBLUSUARIOSTableAdapter As MuebleAlexDataSetTableAdapters.TBLUSUARIOSTableAdapter
    Friend WithEvents BTNEDITAR As Button
    Friend WithEvents BTNNUEVO As Button
    Friend WithEvents BTNELIMINAR As Button
    Friend WithEvents VISTAUSUARIOSBindingSource As BindingSource
    Friend WithEvents VISTAUSUARIOSTableAdapter As MuebleAlexDataSetTableAdapters.VISTAUSUARIOSTableAdapter
    Friend WithEvents USUID As DataGridViewTextBoxColumn
    Friend WithEvents USUNOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents USULOGIN As DataGridViewTextBoxColumn
    Friend WithEvents USUCLAVE As DataGridViewImageColumn
    Friend WithEvents USUTIPO As DataGridViewTextBoxColumn
    Friend WithEvents USUEXISTE As DataGridViewCheckBoxColumn
End Class
