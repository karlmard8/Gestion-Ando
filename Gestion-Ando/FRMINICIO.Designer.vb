﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMINICIO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMINICIO))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNWHATSAPP = New System.Windows.Forms.PictureBox()
        Me.BTNGMAIL = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.BTNWHATSAPP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNGMAIL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(473, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(406, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido a Gestion-Ando"
        '
        'BTNWHATSAPP
        '
        Me.BTNWHATSAPP.BackgroundImage = CType(resources.GetObject("BTNWHATSAPP.BackgroundImage"), System.Drawing.Image)
        Me.BTNWHATSAPP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNWHATSAPP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNWHATSAPP.Location = New System.Drawing.Point(228, 392)
        Me.BTNWHATSAPP.Name = "BTNWHATSAPP"
        Me.BTNWHATSAPP.Size = New System.Drawing.Size(248, 172)
        Me.BTNWHATSAPP.TabIndex = 1
        Me.BTNWHATSAPP.TabStop = False
        '
        'BTNGMAIL
        '
        Me.BTNGMAIL.BackgroundImage = CType(resources.GetObject("BTNGMAIL.BackgroundImage"), System.Drawing.Image)
        Me.BTNGMAIL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BTNGMAIL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGMAIL.Location = New System.Drawing.Point(864, 392)
        Me.BTNGMAIL.Name = "BTNGMAIL"
        Me.BTNGMAIL.Size = New System.Drawing.Size(248, 172)
        Me.BTNGMAIL.TabIndex = 2
        Me.BTNGMAIL.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(521, 331)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 55)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Medios de contacto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 567)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 55)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Whatsapp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(937, 567)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 55)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Gmail"
        '
        'FRMINICIO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 692)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BTNGMAIL)
        Me.Controls.Add(Me.BTNWHATSAPP)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMINICIO"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.BTNWHATSAPP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNGMAIL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BTNWHATSAPP As PictureBox
    Friend WithEvents BTNGMAIL As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
