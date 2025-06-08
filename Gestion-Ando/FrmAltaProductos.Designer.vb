<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAltaProductos
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
        Me.PRODIMAGEN = New System.Windows.Forms.PictureBox()
        Me.BTNCARGARIMG = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SPINNER = New System.Windows.Forms.NumericUpDown()
        Me.TXTCOSTO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PRODIMAGEN, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPINNER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave"
        '
        'TXTCLAVE
        '
        Me.TXTCLAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCLAVE.Location = New System.Drawing.Point(156, 68)
        Me.TXTCLAVE.MaxLength = 10
        Me.TXTCLAVE.Name = "TXTCLAVE"
        Me.TXTCLAVE.Size = New System.Drawing.Size(289, 26)
        Me.TXTCLAVE.TabIndex = 1
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMBRE.Location = New System.Drawing.Point(156, 100)
        Me.TXTNOMBRE.MaxLength = 255
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(289, 26)
        Me.TXTNOMBRE.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 27)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Existencia"
        '
        'TXTPRECIO
        '
        Me.TXTPRECIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRECIO.Location = New System.Drawing.Point(156, 197)
        Me.TXTPRECIO.MaxLength = 14
        Me.TXTPRECIO.Name = "TXTPRECIO"
        Me.TXTPRECIO.Size = New System.Drawing.Size(289, 26)
        Me.TXTPRECIO.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 27)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Precio de venta"
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNGUARDAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNGUARDAR.Location = New System.Drawing.Point(33, 271)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNGUARDAR.TabIndex = 34
        Me.BTNGUARDAR.Text = "Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNLIMPIAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(186, 271)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNLIMPIAR.TabIndex = 35
        Me.BTNLIMPIAR.Text = "Limpiar"
        Me.BTNLIMPIAR.UseVisualStyleBackColor = True
        '
        'BTNCANCELAR
        '
        Me.BTNCANCELAR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCELAR.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCELAR.Location = New System.Drawing.Point(338, 271)
        Me.BTNCANCELAR.Name = "BTNCANCELAR"
        Me.BTNCANCELAR.Size = New System.Drawing.Size(102, 47)
        Me.BTNCANCELAR.TabIndex = 36
        Me.BTNCANCELAR.Text = "Salir"
        Me.BTNCANCELAR.UseVisualStyleBackColor = True
        '
        'LBLPRODUCTOS
        '
        Me.LBLPRODUCTOS.AutoSize = True
        Me.LBLPRODUCTOS.Font = New System.Drawing.Font("Dubai", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLPRODUCTOS.Location = New System.Drawing.Point(167, 9)
        Me.LBLPRODUCTOS.Name = "LBLPRODUCTOS"
        Me.LBLPRODUCTOS.Size = New System.Drawing.Size(34, 32)
        Me.LBLPRODUCTOS.TabIndex = 37
        Me.LBLPRODUCTOS.Text = ". . ."
        '
        'PRODIMAGEN
        '
        Me.PRODIMAGEN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PRODIMAGEN.Cursor = System.Windows.Forms.Cursors.Default
        Me.PRODIMAGEN.Location = New System.Drawing.Point(471, 68)
        Me.PRODIMAGEN.Name = "PRODIMAGEN"
        Me.PRODIMAGEN.Size = New System.Drawing.Size(116, 98)
        Me.PRODIMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PRODIMAGEN.TabIndex = 39
        Me.PRODIMAGEN.TabStop = False
        '
        'BTNCARGARIMG
        '
        Me.BTNCARGARIMG.AutoSize = True
        Me.BTNCARGARIMG.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCARGARIMG.Font = New System.Drawing.Font("Dubai", 8.249999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCARGARIMG.Location = New System.Drawing.Point(503, 172)
        Me.BTNCARGARIMG.Name = "BTNCARGARIMG"
        Me.BTNCARGARIMG.Size = New System.Drawing.Size(48, 28)
        Me.BTNCARGARIMG.TabIndex = 8
        Me.BTNCARGARIMG.Text = "Cargar"
        Me.BTNCARGARIMG.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Dubai", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(499, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Fotografía"
        '
        'SPINNER
        '
        Me.SPINNER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SPINNER.Location = New System.Drawing.Point(156, 133)
        Me.SPINNER.Name = "SPINNER"
        Me.SPINNER.Size = New System.Drawing.Size(289, 26)
        Me.SPINNER.TabIndex = 38
        '
        'TXTCOSTO
        '
        Me.TXTCOSTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCOSTO.Location = New System.Drawing.Point(156, 165)
        Me.TXTCOSTO.MaxLength = 14
        Me.TXTCOSTO.Name = "TXTCOSTO"
        Me.TXTCOSTO.Size = New System.Drawing.Size(289, 26)
        Me.TXTCOSTO.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(72, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 27)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Costo"
        '
        'FrmAltaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 349)
        Me.Controls.Add(Me.TXTCOSTO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SPINNER)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTNCARGARIMG)
        Me.Controls.Add(Me.PRODIMAGEN)
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
        Me.Controls.Add(Me.LBLPRODUCTOS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAltaProductos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAltaProductos"
        CType(Me.PRODIMAGEN, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PRODIMAGEN As PictureBox
    Friend WithEvents BTNCARGARIMG As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SPINNER As NumericUpDown
    Friend WithEvents TXTCOSTO As TextBox
    Friend WithEvents Label6 As Label
End Class
