<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAltaProductos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTCLAVE = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTPRECIO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.BTNCANCELAR = New System.Windows.Forms.Button()
        Me.LBLPRODUCTOS = New System.Windows.Forms.Label()
        Me.SPINNER = New System.Windows.Forms.NumericUpDown()
        CType(Me.SPINNER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave"
        '
        'TXTCLAVE
        '
        Me.TXTCLAVE.Location = New System.Drawing.Point(151, 68)
        Me.TXTCLAVE.MaxLength = 10
        Me.TXTCLAVE.Name = "TXTCLAVE"
        Me.TXTCLAVE.Size = New System.Drawing.Size(289, 20)
        Me.TXTCLAVE.TabIndex = 1
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(151, 94)
        Me.TXTNOMBRE.MaxLength = 255
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(289, 20)
        Me.TXTNOMBRE.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Existencia"
        '
        'TXTPRECIO
        '
        Me.TXTPRECIO.Location = New System.Drawing.Point(151, 146)
        Me.TXTPRECIO.Name = "TXTPRECIO"
        Me.TXTPRECIO.Size = New System.Drawing.Size(289, 20)
        Me.TXTPRECIO.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(67, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.Location = New System.Drawing.Point(33, 208)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNGUARDAR.TabIndex = 34
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(186, 208)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNLIMPIAR.TabIndex = 35
        Me.BTNLIMPIAR.Text = "Limpiar"
        Me.BTNLIMPIAR.UseVisualStyleBackColor = True
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Location = New System.Drawing.Point(338, 208)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNCANCELAR.TabIndex = 36
        Me.BTNCANCELAR.Text = "Cancelar"
        Me.BTNCANCELAR.UseVisualStyleBackColor = True
        '
        'LBLPRODUCTOS
        '
        Me.LBLPRODUCTOS.AutoSize = True
        Me.LBLPRODUCTOS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPRODUCTOS.Location = New System.Drawing.Point(135, 9)
        Me.LBLPRODUCTOS.Name = "LBLPRODUCTOS"
        Me.LBLPRODUCTOS.Size = New System.Drawing.Size(0, 32)
        Me.LBLPRODUCTOS.TabIndex = 37
        '
        'SPINNER
        '
        Me.SPINNER.Location = New System.Drawing.Point(151, 120)
        Me.SPINNER.Name = "SPINNER"
        Me.SPINNER.Size = New System.Drawing.Size(289, 20)
        Me.SPINNER.TabIndex = 38
        '
        'FrmAltaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 283)
        Me.Controls.Add(Me.SPINNER)
        Me.Controls.Add(Me.LBLPRODUCTOS)
        Me.Controls.Add(Me.BTNGUARDAR)
        Me.Controls.Add(Me.BTNLIMPIAR)
        Me.Controls.Add(Me.BTNCANCELAR)
        Me.Controls.Add(Me.TXTPRECIO)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXTCLAVE)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAltaProductos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAltaProductos"
        CType(Me.SPINNER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TXTCLAVE As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTPRECIO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents BTNCANCELAR As Button
    Friend WithEvents LBLPRODUCTOS As Label
    Friend WithEvents SPINNER As NumericUpDown
End Class
