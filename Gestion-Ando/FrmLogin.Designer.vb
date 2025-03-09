<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TXTLOGIN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTCONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.BTNENTRAR = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXTLOGIN
        '
        Me.TXTLOGIN.Location = New System.Drawing.Point(105, 158)
        Me.TXTLOGIN.Name = "TXTLOGIN"
        Me.TXTLOGIN.Size = New System.Drawing.Size(216, 20)
        Me.TXTLOGIN.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'TXTCONTRASEÑA
        '
        Me.TXTCONTRASEÑA.Location = New System.Drawing.Point(105, 208)
        Me.TXTCONTRASEÑA.Name = "TXTCONTRASEÑA"
        Me.TXTCONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTCONTRASEÑA.Size = New System.Drawing.Size(216, 20)
        Me.TXTCONTRASEÑA.TabIndex = 2
        '
        'BTNENTRAR
        '
        Me.BTNENTRAR.AutoSize = True
        Me.BTNENTRAR.BackColor = System.Drawing.Color.Snow
        Me.BTNENTRAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNENTRAR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BTNENTRAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNENTRAR.Location = New System.Drawing.Point(0, 264)
        Me.BTNENTRAR.Name = "BTNENTRAR"
        Me.BTNENTRAR.Size = New System.Drawing.Size(354, 37)
        Me.BTNENTRAR.TabIndex = 4
        Me.BTNENTRAR.Text = "Entrar"
        Me.BTNENTRAR.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gestion_Ando.My.Resources.Resources.Imagen_de_WhatsApp_2025_03_05_a_las_12_26_40_68235b6c
        Me.PictureBox1.Location = New System.Drawing.Point(27, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 301)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BTNENTRAR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTCONTRASEÑA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTLOGIN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTLOGIN As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTCONTRASEÑA As TextBox
    Friend WithEvents BTNENTRAR As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
