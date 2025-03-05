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
        Me.MenuOpciones = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CréditoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PANELFRAMES = New System.Windows.Forms.Panel()
        Me.LBLOPCIONES = New System.Windows.Forms.Label()
        Me.MenuOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuOpciones
        '
        Me.MenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.MenuOpciones.Name = "MenuOpciones"
        Me.MenuOpciones.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuOpciones.Size = New System.Drawing.Size(1440, 24)
        Me.MenuOpciones.TabIndex = 0
        Me.MenuOpciones.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.CréditoToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'CréditoToolStripMenuItem
        '
        Me.CréditoToolStripMenuItem.Name = "CréditoToolStripMenuItem"
        Me.CréditoToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CréditoToolStripMenuItem.Text = "Crédito"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VentasToolStripMenuItem1, Me.InventarioToolStripMenuItem1})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'InventarioToolStripMenuItem1
        '
        Me.InventarioToolStripMenuItem1.Name = "InventarioToolStripMenuItem1"
        Me.InventarioToolStripMenuItem1.Size = New System.Drawing.Size(127, 22)
        Me.InventarioToolStripMenuItem1.Text = "Inventario"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'PANELFRAMES
        '
        Me.PANELFRAMES.Location = New System.Drawing.Point(12, 45)
        Me.PANELFRAMES.Name = "PANELFRAMES"
        Me.PANELFRAMES.Size = New System.Drawing.Size(1860, 930)
        Me.PANELFRAMES.TabIndex = 1
        '
        'LBLOPCIONES
        '
        Me.LBLOPCIONES.AutoSize = True
        Me.LBLOPCIONES.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOPCIONES.Location = New System.Drawing.Point(50, 40)
        Me.LBLOPCIONES.Name = "LBLOPCIONES"
        Me.LBLOPCIONES.Size = New System.Drawing.Size(29, 27)
        Me.LBLOPCIONES.TabIndex = 2
        Me.LBLOPCIONES.Text = ". . ."
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1440, 859)
        Me.Controls.Add(Me.LBLOPCIONES)
        Me.Controls.Add(Me.PANELFRAMES)
        Me.Controls.Add(Me.MenuOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuOpciones
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestion-Ando"
        Me.MenuOpciones.ResumeLayout(False)
        Me.MenuOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuOpciones As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PANELFRAMES As Panel
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CréditoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBLOPCIONES As Label
End Class
