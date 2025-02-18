<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PANELFRAMES = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1920, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem1, Me.InventarioToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'InventarioToolStripMenuItem1
        '
        Me.InventarioToolStripMenuItem1.Name = "InventarioToolStripMenuItem1"
        Me.InventarioToolStripMenuItem1.Size = New System.Drawing.Size(158, 26)
        Me.InventarioToolStripMenuItem1.Text = "Inventario"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'PANELFRAMES
        '
        Me.PANELFRAMES.Location = New System.Drawing.Point(16, 55)
        Me.PANELFRAMES.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PANELFRAMES.Name = "PANELFRAMES"
        Me.PANELFRAMES.Size = New System.Drawing.Size(2480, 1145)
        Me.PANELFRAMES.TabIndex = 1
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1920, 1051)
        Me.Controls.Add(Me.PANELFRAMES)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestion-Ando"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PANELFRAMES As Panel
End Class
