Public Class FrmClientes
    Dim NUEVO As New FrmAltaClientes
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        Me.DATACLIENTES.BackgroundColor = ColorFormulario
        BTNNUEVO.BackColor = ColorBotones
        BTNEDITAR.BackColor = ColorBotones
        BTNELIMINAR.BackColor = ColorBotones
        BTNREPORTE.BackColor = ColorBotones
        TXTBUSCAR.Focus()
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLCLIENTES' Puede moverla o quitarla según sea necesario..
        Me.TBLCLIENTESTableAdapter.Connection = Conexion
        Me.TBLCLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.TBLCLIENTES)
        If TIPO = "Operativo" Then
            BTNEDITAR.Enabled = False
            BTNELIMINAR.Enabled = False
        End If
        AddHandler BTNELIMINAR.MouseEnter, AddressOf Button1_MouseEnter
        AddHandler BTNELIMINAR.MouseLeave, AddressOf Button1_MouseLeave
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
        ' Cambiar el color del botón a rojo cuando el cursor pasa por encima
        BTNELIMINAR.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        ' Restaurar el color original del botón cuando el cursor sale del botón
        BTNELIMINAR.BackColor = ColorBotones
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        NUEVO.TXTCREDITO.SelectedIndex = -1
        NUEVO.LBLCLIENTES.Text = "Registro de clientes"
        NUEVO.LBLCLIENTES.Location = New Point(160, 15)
        For Each control As Control In NUEVO.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is NumericUpDown Then
                DirectCast(control, NumericUpDown).Value = 0
            End If
        Next
        idbusqueda = 0
        If NUEVO.ShowDialog = DialogResult.OK Then
            Me.TBLCLIENTESTableAdapter.Connection = Conexion
            Me.TBLCLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.TBLCLIENTES)
        End If
        TXTBUSCAR.Focus()
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLCLIENTESBindingSource.Filter = "CLINOMBRE LIKE '*" & TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        NUEVO.LBLCLIENTES.Text = "Editar registro de cliente"
        NUEVO.LBLCLIENTES.Location = New Point(155, 15)
        If DATACLIENTES.RowCount > 0 Then
            idbusqueda = DATACLIENTES.CurrentRow.Cells("CLIID").Value
            NUEVO.TXTCODIGO.Text = DATACLIENTES.CurrentRow.Cells("CLICODIGO").Value
            NUEVO.TXTNOMBRE.Text = DATACLIENTES.CurrentRow.Cells("CLINOMBRE").Value
            NUEVO.TXTAPEMATERNO.Text = DATACLIENTES.CurrentRow.Cells("CLIAPEPATERNO").Value
            NUEVO.TXTAPEPATERNO.Text = DATACLIENTES.CurrentRow.Cells("CLIAPEMATERNO").Value
            NUEVO.TXTCALLE.Text = DATACLIENTES.CurrentRow.Cells("CLIDIRECCION").Value
            NUEVO.TXTCOLONIIA.Text = DATACLIENTES.CurrentRow.Cells("CLICOLONIA").Value
            NUEVO.TXTCP.Text = DATACLIENTES.CurrentRow.Cells("CLICP").Value
            NUEVO.TXTCIUDAD.Text = DATACLIENTES.CurrentRow.Cells("CLICIUDAD").Value
            NUEVO.TXTESTADO.Text = DATACLIENTES.CurrentRow.Cells("CLIESTADO").Value
            NUEVO.TXTTELEFONO.Text = DATACLIENTES.CurrentRow.Cells("CLITELEFONO").Value
            NUEVO.TXTNOTAS.Text = DATACLIENTES.CurrentRow.Cells("CLICOMENTARIOS").Value
            NUEVO.TXTCREDITO.Text = DATACLIENTES.CurrentRow.Cells("CLIHISTORIALCREDITICIO").Value
            NUEVO.TXTRFC.Text = DATACLIENTES.CurrentRow.Cells("CLIRFC").Value
            NUEVO.TXTREGIMEN.Text = DATACLIENTES.CurrentRow.Cells("CLIREGIMENFISCAL").Value
            NUEVO.TXTCFDI.Text = DATACLIENTES.CurrentRow.Cells("CLICFDI").Value

            If NUEVO.ShowDialog = DialogResult.OK Then
                Me.TBLCLIENTESTableAdapter.Connection = Conexion
                Me.TBLCLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.TBLCLIENTES)
            End If
        End If
        TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim CONFIRMAR = MsgBox("¿Eliminar cliente?", MsgBoxStyle.YesNo, "Confirmación")
        If CONFIRMAR = MsgBoxResult.Yes Then
            StrSql = "ELIMINARCLIENTES"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@CLIID", SqlDbType.BigInt).Value = Me.DATACLIENTES.CurrentRow.Cells("CLIID").Value

            If Conectar() = True Then
                Me.TBLCLIENTESTableAdapter.Connection = Conexion
                Me.TBLCLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.TBLCLIENTES)
                MsgBox("Cliente eliminado", MsgBoxStyle.Information, "Confirmación")
            End If
        End If
        TXTBUSCAR.Focus()
    End Sub

    Private Sub DATACLIENTES_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DATACLIENTES.CellFormatting
        ' Ejemplo de condición para cambiar el color de una celda específica
        If e.ColumnIndex = 1 AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() = "ValorEspecífico" Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Red
        End If
    End Sub
End Class