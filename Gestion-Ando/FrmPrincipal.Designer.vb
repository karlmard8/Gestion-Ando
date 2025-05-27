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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuOpciones = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorteDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CotizacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PANELFRAMES = New System.Windows.Forms.Panel()
        Me.BTNDEUDORES = New System.Windows.Forms.Button()
        Me.LBLOPCIONES = New System.Windows.Forms.Label()
        Me.LBLLOGIN = New System.Windows.Forms.Label()
        Me.LBLHORA = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBLFECHA = New System.Windows.Forms.Label()
        Me.MenuOpciones.SuspendLayout()
        Me.PANELFRAMES.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuOpciones
        '
        Me.MenuOpciones.BackColor = System.Drawing.Color.White
        Me.MenuOpciones.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.CorteDeCajaToolStripMenuItem, Me.CotizacionesToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem})
        Me.MenuOpciones.Location = New System.Drawing.Point(0, 0)
        Me.MenuOpciones.Name = "MenuOpciones"
        Me.MenuOpciones.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuOpciones.Size = New System.Drawing.Size(1920, 38)
        Me.MenuOpciones.TabIndex = 0
        Me.MenuOpciones.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(98, 34)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(87, 34)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(118, 34)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'CorteDeCajaToolStripMenuItem
        '
        Me.CorteDeCajaToolStripMenuItem.Name = "CorteDeCajaToolStripMenuItem"
        Me.CorteDeCajaToolStripMenuItem.Size = New System.Drawing.Size(177, 34)
        Me.CorteDeCajaToolStripMenuItem.Text = "Abrir/Cerrar caja"
        '
        'CotizacionesToolStripMenuItem
        '
        Me.CotizacionesToolStripMenuItem.Name = "CotizacionesToolStripMenuItem"
        Me.CotizacionesToolStripMenuItem.Size = New System.Drawing.Size(142, 34)
        Me.CotizacionesToolStripMenuItem.Text = "Cotizaciones"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(104, 34)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(145, 34)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar sesión"
        '
        'PANELFRAMES
        '
        Me.PANELFRAMES.Controls.Add(Me.BTNDEUDORES)
        Me.PANELFRAMES.Location = New System.Drawing.Point(12, 45)
        Me.PANELFRAMES.Name = "PANELFRAMES"
        Me.PANELFRAMES.Size = New System.Drawing.Size(1896, 940)
        Me.PANELFRAMES.TabIndex = 1
        '
        'BTNDEUDORES
        '
        Me.BTNDEUDORES.AutoSize = True
        Me.BTNDEUDORES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNDEUDORES.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNDEUDORES.Location = New System.Drawing.Point(1757, 0)
        Me.BTNDEUDORES.Name = "BTNDEUDORES"
        Me.BTNDEUDORES.Size = New System.Drawing.Size(139, 42)
        Me.BTNDEUDORES.TabIndex = 0
        Me.BTNDEUDORES.Text = "Deudas del día"
        Me.BTNDEUDORES.UseVisualStyleBackColor = True
        '
        'LBLOPCIONES
        '
        Me.LBLOPCIONES.AutoSize = True
        Me.LBLOPCIONES.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOPCIONES.Location = New System.Drawing.Point(50, 40)
        Me.LBLOPCIONES.Name = "LBLOPCIONES"
        Me.LBLOPCIONES.Size = New System.Drawing.Size(0, 32)
        Me.LBLOPCIONES.TabIndex = 2
        '
        'LBLLOGIN
        '
        Me.LBLLOGIN.AutoSize = True
        Me.LBLLOGIN.BackColor = System.Drawing.Color.Transparent
        Me.LBLLOGIN.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLOGIN.Location = New System.Drawing.Point(895, 2)
        Me.LBLLOGIN.Name = "LBLLOGIN"
        Me.LBLLOGIN.Size = New System.Drawing.Size(37, 36)
        Me.LBLLOGIN.TabIndex = 21
        Me.LBLLOGIN.Text = ". . ."
        '
        'LBLHORA
        '
        Me.LBLHORA.AutoSize = True
        Me.LBLHORA.BackColor = System.Drawing.Color.Transparent
        Me.LBLHORA.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLHORA.Location = New System.Drawing.Point(1680, 2)
        Me.LBLHORA.Name = "LBLHORA"
        Me.LBLHORA.Size = New System.Drawing.Size(37, 36)
        Me.LBLHORA.TabIndex = 22
        Me.LBLHORA.Text = ". . ."
        '
        'Timer1
        '
        '
        'LBLFECHA
        '
        Me.LBLFECHA.AutoSize = True
        Me.LBLFECHA.BackColor = System.Drawing.Color.Transparent
        Me.LBLFECHA.Font = New System.Drawing.Font("Dubai", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLFECHA.Location = New System.Drawing.Point(1550, 2)
        Me.LBLFECHA.Name = "LBLFECHA"
        Me.LBLFECHA.Size = New System.Drawing.Size(37, 36)
        Me.LBLFECHA.TabIndex = 23
        Me.LBLFECHA.Text = ". . ."
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1920, 997)
        Me.Controls.Add(Me.LBLFECHA)
        Me.Controls.Add(Me.LBLHORA)
        Me.Controls.Add(Me.LBLLOGIN)
        Me.Controls.Add(Me.LBLOPCIONES)
        Me.Controls.Add(Me.PANELFRAMES)
        Me.Controls.Add(Me.MenuOpciones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(-10, 0)
        Me.MainMenuStrip = Me.MenuOpciones
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Gestion-Ando"
        Me.MenuOpciones.ResumeLayout(False)
        Me.MenuOpciones.PerformLayout()
        Me.PANELFRAMES.ResumeLayout(False)
        Me.PANELFRAMES.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuOpciones As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PANELFRAMES As Panel
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LBLOPCIONES As Label
    Friend WithEvents LBLLOGIN As Label
    Friend WithEvents LBLHORA As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LBLFECHA As Label
    Friend WithEvents BTNDEUDORES As Button
    Friend WithEvents CorteDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CotizacionesToolStripMenuItem As ToolStripMenuItem
End Class
