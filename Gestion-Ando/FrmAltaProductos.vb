Public Class FrmAltaProductos
    Private Sub FrmAltaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numericUpDown As New NumericUpDown()
        numericUpDown.Location = New Point(151, 121)
        numericUpDown.Minimum = -10
        numericUpDown.Maximum = 100
        numericUpDown.TabIndex = 4
        Me.Controls.Add(numericUpDown)
    End Sub

    Private Sub BTNCANCELAR_Click(sender As Object, e As EventArgs) Handles BTNCANCELAR.Click
        Me.Close()
    End Sub

    Private Sub BTNLIMPIAR_Click(sender As Object, e As EventArgs) Handles BTNLIMPIAR.Click
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is NumericUpDown Then
                DirectCast(control, NumericUpDown).Value = 0
            End If
        Next
        TXTCLAVE.Focus()
    End Sub
End Class