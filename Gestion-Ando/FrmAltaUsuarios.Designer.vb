<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaUsuarios
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
        Me.LBLUSUARIOS = New System.Windows.Forms.Label()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTLOGIN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCLAVE = New System.Windows.Forms.TextBox()
        Me.TXTTIPO = New System.Windows.Forms.ComboBox()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.TXTCONFIRMAR = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLUSUARIOS
        '
        Me.LBLUSUARIOS.AutoSize = True
        Me.LBLUSUARIOS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLUSUARIOS.Location = New System.Drawing.Point(135, 9)
        Me.LBLUSUARIOS.Name = "LBLUSUARIOS"
        Me.LBLUSUARIOS.Size = New System.Drawing.Size(34, 32)
        Me.LBLUSUARIOS.TabIndex = 48
        Me.LBLUSUARIOS.Text = ". . ."
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.Location = New System.Drawing.Point(33, 270)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNGUARDAR.TabIndex = 45
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Location = New System.Drawing.Point(338, 270)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNCANCELAR.TabIndex = 47
        Me.BTNCANCELAR.Text = "Salir"
        Me.BTNCANCELAR.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 27)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Tipo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 27)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Contraseña"
        '
        'TXTLOGIN
        '
        Me.TXTLOGIN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLOGIN.Location = New System.Drawing.Point(151, 100)
        Me.TXTLOGIN.MaxLength = 10
        Me.TXTLOGIN.Name = "TXTLOGIN"
        Me.TXTLOGIN.Size = New System.Drawing.Size(289, 26)
        Me.TXTLOGIN.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 27)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Login"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMBRE.Location = New System.Drawing.Point(151, 68)
        Me.TXTNOMBRE.MaxLength = 80
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(289, 26)
        Me.TXTNOMBRE.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(54, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 27)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Nombre"
        '
        'TXTCLAVE
        '
        Me.TXTCLAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCLAVE.Location = New System.Drawing.Point(151, 132)
        Me.TXTCLAVE.MaxLength = 10
        Me.TXTCLAVE.Name = "TXTCLAVE"
        Me.TXTCLAVE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTCLAVE.Size = New System.Drawing.Size(289, 26)
        Me.TXTCLAVE.TabIndex = 42
        '
        'TXTTIPO
        '
        Me.TXTTIPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXTTIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTIPO.FormattingEnabled = True
        Me.TXTTIPO.Items.AddRange(New Object() {"Administrador", "Operativo"})
        Me.TXTTIPO.Location = New System.Drawing.Point(151, 213)
        Me.TXTTIPO.Name = "TXTTIPO"
        Me.TXTTIPO.Size = New System.Drawing.Size(289, 28)
        Me.TXTTIPO.TabIndex = 43
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLIMPIAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(188, 270)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNLIMPIAR.TabIndex = 46
        Me.BTNLIMPIAR.Text = "Limpiar"
        Me.BTNLIMPIAR.UseVisualStyleBackColor = True
        '
        'TXTCONFIRMAR
        '
        Me.TXTCONFIRMAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCONFIRMAR.Location = New System.Drawing.Point(151, 172)
        Me.TXTCONFIRMAR.MaxLength = 10
        Me.TXTCONFIRMAR.Name = "TXTCONFIRMAR"
        Me.TXTCONFIRMAR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXTCONFIRMAR.Size = New System.Drawing.Size(289, 26)
        Me.TXTCONFIRMAR.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 62)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Confirmar contraseña"
        '
        'FrmAltaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 350)
        Me.Controls.Add(Me.TXTCONFIRMAR)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTNLIMPIAR)
        Me.Controls.Add(Me.TXTTIPO)
        Me.Controls.Add(Me.TXTCLAVE)
        Me.Controls.Add(Me.LBLUSUARIOS)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTLOGIN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAltaUsuarios"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAltaUsuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLUSUARIOS As Label
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents BTNCANCELAR As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTLOGIN As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTCLAVE As TextBox
    Friend WithEvents TXTTIPO As ComboBox
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents TXTCONFIRMAR As TextBox
    Friend WithEvents Label5 As Label
End Class
