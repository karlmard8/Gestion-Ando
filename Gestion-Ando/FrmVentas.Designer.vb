﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVentas
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
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.DATAVENTAS = New System.Windows.Forms.DataGridView()
        Me.TXTBUSCAR = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BTNREPORTE = New System.Windows.Forms.Button()
        CType(Me.DATAVENTAS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.BackColor = System.Drawing.SystemColors.HighlightText
        Me.BTNNUEVO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNUEVO.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNUEVO.Location = New System.Drawing.Point(583, 855)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(132, 54)
        Me.BTNNUEVO.TabIndex = 5
        Me.BTNNUEVO.Text = "Nuevo"
        Me.BTNNUEVO.UseVisualStyleBackColor = False
        '
        'DATAVENTAS
        '
        Me.DATAVENTAS.AllowUserToAddRows = False
        Me.DATAVENTAS.AllowUserToDeleteRows = False
        Me.DATAVENTAS.AllowUserToOrderColumns = True
        Me.DATAVENTAS.BackgroundColor = System.Drawing.Color.White
        Me.DATAVENTAS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.DATAVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATAVENTAS.GridColor = System.Drawing.SystemColors.Control
        Me.DATAVENTAS.Location = New System.Drawing.Point(12, 92)
        Me.DATAVENTAS.Name = "DATAVENTAS"
        Me.DATAVENTAS.ReadOnly = True
        Me.DATAVENTAS.RowHeadersVisible = False
        Me.DATAVENTAS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DATAVENTAS.Size = New System.Drawing.Size(704, 720)
        Me.DATAVENTAS.TabIndex = 4
        '
        'TXTBUSCAR
        '
        Me.TXTBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBUSCAR.Location = New System.Drawing.Point(115, 28)
        Me.TXTBUSCAR.Name = "TXTBUSCAR"
        Me.TXTBUSCAR.Size = New System.Drawing.Size(385, 22)
        Me.TXTBUSCAR.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 27)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(503, 53)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'BTNREPORTE
        '
        Me.BTNREPORTE.AutoSize = True
        Me.BTNREPORTE.BackColor = System.Drawing.Color.White
        Me.BTNREPORTE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNREPORTE.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNREPORTE.Location = New System.Drawing.Point(583, 41)
        Me.BTNREPORTE.Name = "BTNREPORTE"
        Me.BTNREPORTE.Size = New System.Drawing.Size(133, 45)
        Me.BTNREPORTE.TabIndex = 18
        Me.BTNREPORTE.Text = "Generar reporte"
        Me.BTNREPORTE.UseVisualStyleBackColor = False
        '
        'FrmVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 930)
        Me.Controls.Add(Me.BTNREPORTE)
        Me.Controls.Add(Me.TXTBUSCAR)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNNUEVO)
        Me.Controls.Add(Me.DATAVENTAS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmVentas"
        Me.Text = "FrmVentas"
        CType(Me.DATAVENTAS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNNUEVO As Button
    Friend WithEvents DATAVENTAS As DataGridView
    Friend WithEvents TXTBUSCAR As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BTNREPORTE As Button
End Class
