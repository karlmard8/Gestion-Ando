<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportes
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
        Me.Reportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'Reportes
        '
        Me.Reportes.ActiveViewIndex = -1
        Me.Reportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Reportes.Cursor = System.Windows.Forms.Cursors.Default
        Me.Reportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Reportes.Location = New System.Drawing.Point(0, 0)
        Me.Reportes.Name = "Reportes"
        Me.Reportes.ShowCloseButton = False
        Me.Reportes.ShowCopyButton = False
        Me.Reportes.ShowGroupTreeButton = False
        Me.Reportes.ShowLogo = False
        Me.Reportes.ShowParameterPanelButton = False
        Me.Reportes.ShowRefreshButton = False
        Me.Reportes.ShowTextSearchButton = False
        Me.Reportes.Size = New System.Drawing.Size(784, 761)
        Me.Reportes.TabIndex = 0
        Me.Reportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmReportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 761)
        Me.Controls.Add(Me.Reportes)
        Me.Name = "FrmReportes"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Reportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
