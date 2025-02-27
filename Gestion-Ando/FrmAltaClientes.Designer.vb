<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaClientes
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
        Me.TXTCODIGO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTAPEPATERNO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXTAPEMATERNO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTCALLE = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTCOLONIIA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTCP = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTCIUDAD = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTESTADO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTTELEFONO = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTNOTAS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TXTRFC = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TXTREGIMEN = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TXTCFDI = New System.Windows.Forms.TextBox()
        Me.LBLCLIENTES = New System.Windows.Forms.Label()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.TXTCREDITO = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TXTCODIGO
        '
        Me.TXTCODIGO.Location = New System.Drawing.Point(146, 70)
        Me.TXTCODIGO.MaxLength = 10
        Me.TXTCODIGO.Name = "TXTCODIGO"
        Me.TXTCODIGO.Size = New System.Drawing.Size(288, 20)
        Me.TXTCODIGO.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 27)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(146, 97)
        Me.TXTNOMBRE.MaxLength = 100
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(288, 20)
        Me.TXTNOMBRE.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ape.Paterno"
        '
        'TXTAPEPATERNO
        '
        Me.TXTAPEPATERNO.Location = New System.Drawing.Point(146, 124)
        Me.TXTAPEPATERNO.MaxLength = 50
        Me.TXTAPEPATERNO.Name = "TXTAPEPATERNO"
        Me.TXTAPEPATERNO.Size = New System.Drawing.Size(288, 20)
        Me.TXTAPEPATERNO.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Ape.Materno"
        '
        'TXTAPEMATERNO
        '
        Me.TXTAPEMATERNO.Location = New System.Drawing.Point(146, 151)
        Me.TXTAPEMATERNO.MaxLength = 50
        Me.TXTAPEMATERNO.Name = "TXTAPEMATERNO"
        Me.TXTAPEMATERNO.Size = New System.Drawing.Size(288, 20)
        Me.TXTAPEMATERNO.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 27)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Calle y número"
        '
        'TXTCALLE
        '
        Me.TXTCALLE.Location = New System.Drawing.Point(146, 178)
        Me.TXTCALLE.MaxLength = 100
        Me.TXTCALLE.Name = "TXTCALLE"
        Me.TXTCALLE.Size = New System.Drawing.Size(288, 20)
        Me.TXTCALLE.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 27)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Colonia"
        '
        'TXTCOLONIIA
        '
        Me.TXTCOLONIIA.Location = New System.Drawing.Point(146, 205)
        Me.TXTCOLONIIA.MaxLength = 80
        Me.TXTCOLONIIA.Name = "TXTCOLONIIA"
        Me.TXTCOLONIIA.Size = New System.Drawing.Size(288, 20)
        Me.TXTCOLONIIA.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 27)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Código postal"
        '
        'TXTCP
        '
        Me.TXTCP.Location = New System.Drawing.Point(146, 232)
        Me.TXTCP.MaxLength = 5
        Me.TXTCP.Name = "TXTCP"
        Me.TXTCP.Size = New System.Drawing.Size(288, 20)
        Me.TXTCP.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 27)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Ciudad"
        '
        'TXTCIUDAD
        '
        Me.TXTCIUDAD.Location = New System.Drawing.Point(146, 259)
        Me.TXTCIUDAD.MaxLength = 50
        Me.TXTCIUDAD.Name = "TXTCIUDAD"
        Me.TXTCIUDAD.Size = New System.Drawing.Size(288, 20)
        Me.TXTCIUDAD.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 282)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 27)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Estado"
        '
        'TXTESTADO
        '
        Me.TXTESTADO.Location = New System.Drawing.Point(146, 286)
        Me.TXTESTADO.MaxLength = 30
        Me.TXTESTADO.Name = "TXTESTADO"
        Me.TXTESTADO.Size = New System.Drawing.Size(288, 20)
        Me.TXTESTADO.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(47, 309)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 27)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Teléfono"
        '
        'TXTTELEFONO
        '
        Me.TXTTELEFONO.Location = New System.Drawing.Point(146, 313)
        Me.TXTTELEFONO.MaxLength = 10
        Me.TXTTELEFONO.Name = "TXTTELEFONO"
        Me.TXTTELEFONO.Size = New System.Drawing.Size(288, 20)
        Me.TXTTELEFONO.TabIndex = 18
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(60, 336)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 27)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Notas"
        '
        'TXTNOTAS
        '
        Me.TXTNOTAS.Location = New System.Drawing.Point(146, 340)
        Me.TXTNOTAS.MaxLength = 255
        Me.TXTNOTAS.Name = "TXTNOTAS"
        Me.TXTNOTAS.Size = New System.Drawing.Size(288, 20)
        Me.TXTNOTAS.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(56, 363)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 27)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Crédito"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(74, 390)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 27)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "RFC"
        '
        'TXTRFC
        '
        Me.TXTRFC.Location = New System.Drawing.Point(146, 394)
        Me.TXTRFC.MaxLength = 20
        Me.TXTRFC.Name = "TXTRFC"
        Me.TXTRFC.Size = New System.Drawing.Size(288, 20)
        Me.TXTRFC.TabIndex = 24
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 417)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 27)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Régimen fiscal"
        '
        'TXTREGIMEN
        '
        Me.TXTREGIMEN.Location = New System.Drawing.Point(146, 421)
        Me.TXTREGIMEN.MaxLength = 100
        Me.TXTREGIMEN.Name = "TXTREGIMEN"
        Me.TXTREGIMEN.Size = New System.Drawing.Size(288, 20)
        Me.TXTREGIMEN.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(68, 444)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 27)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "CFDI"
        '
        'TXTCFDI
        '
        Me.TXTCFDI.Location = New System.Drawing.Point(146, 448)
        Me.TXTCFDI.MaxLength = 100
        Me.TXTCFDI.Name = "TXTCFDI"
        Me.TXTCFDI.Size = New System.Drawing.Size(288, 20)
        Me.TXTCFDI.TabIndex = 28
        '
        'LBLCLIENTES
        '
        Me.LBLCLIENTES.AutoSize = True
        Me.LBLCLIENTES.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLCLIENTES.Location = New System.Drawing.Point(140, 9)
        Me.LBLCLIENTES.Name = "LBLCLIENTES"
        Me.LBLCLIENTES.Size = New System.Drawing.Size(198, 32)
        Me.LBLCLIENTES.TabIndex = 30
        Me.LBLCLIENTES.Text = "Alta o modificar cliente"
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Location = New System.Drawing.Point(332, 538)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNCANCELAR.TabIndex = 33
        Me.BTNCANCELAR.Text = "Salir"
        Me.BTNCANCELAR.UseVisualStyleBackColor = True
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(180, 538)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNLIMPIAR.TabIndex = 32
        Me.BTNLIMPIAR.Text = "Limpiar"
        Me.BTNLIMPIAR.UseVisualStyleBackColor = True
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.Location = New System.Drawing.Point(27, 538)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNGUARDAR.TabIndex = 31
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'TXTCREDITO
        '
        Me.TXTCREDITO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TXTCREDITO.FormattingEnabled = True
        Me.TXTCREDITO.Items.AddRange(New Object() {"Acreditado", "No acreditado"})
        Me.TXTCREDITO.Location = New System.Drawing.Point(146, 366)
        Me.TXTCREDITO.Name = "TXTCREDITO"
        Me.TXTCREDITO.Size = New System.Drawing.Size(288, 21)
        Me.TXTCREDITO.TabIndex = 22
        '
        'FrmAltaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 621)
        Me.Controls.Add(Me.TXTCREDITO)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNLIMPIAR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.LBLCLIENTES)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TXTCFDI)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TXTREGIMEN)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TXTRFC)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXTNOTAS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TXTTELEFONO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TXTESTADO)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTCIUDAD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TXTCP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TXTCOLONIIA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TXTCALLE)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTAPEMATERNO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTAPEPATERNO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTCODIGO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAltaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAltaClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTCODIGO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTAPEPATERNO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TXTAPEMATERNO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTCALLE As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTCOLONIIA As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTCP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TXTCIUDAD As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTESTADO As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TXTTELEFONO As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TXTNOTAS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents TXTRFC As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TXTREGIMEN As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TXTCFDI As TextBox
    Friend WithEvents LBLCLIENTES As Label
    Friend WithEvents BTNCANCELAR As Button
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents TXTCREDITO As ComboBox
End Class
