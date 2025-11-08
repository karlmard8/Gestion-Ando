Public Class FrmClientes
    Dim NUEVO As New FrmAltaClientes
    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTACLIENTESPRINCIPAL' Puede moverla o quitarla según sea necesario.
        Me.VISTACLIENTESPRINCIPALTableAdapter.Connection = Conexion
        Me.VISTACLIENTESPRINCIPALTableAdapter.Fill(Me.MuebleAlexDataSet.VISTACLIENTESPRINCIPAL)
        Me.BackColor = ColorFormulario
        Me.DATACLIENTES.BackgroundColor = ColorFormulario
        EstiloBotones.CambiarColorBotones(Me)

        CMBFILTRO.SelectedIndex = 0
        CMBFILTRO.BackColor = ColorFormulario
        TXTBUSCAR.Focus()
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLCLIENTES' Puede moverla o quitarla según sea necesario..
        Me.TBLCLIENTESTableAdapter.Connection = Conexion
        Me.TBLCLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.TBLCLIENTES)
        If TIPO = "Operativo" Then
            BTNEDITAR.Enabled = False
            BTNELIMINAR.Enabled = False
        End If

        DATACLIENTES.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATACLIENTES.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
        AddHandler BTNELIMINAR.MouseEnter, AddressOf BTNELIMINAR_MouseEnter
        AddHandler BTNELIMINAR.MouseLeave, AddressOf BTNELIMINAR_MouseLeave
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
        BTNELIMINAR.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
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
            Me.VISTACLIENTESPRINCIPALTableAdapter.Connection = Conexion
            Me.VISTACLIENTESPRINCIPALTableAdapter.Fill(Me.MuebleAlexDataSet.VISTACLIENTESPRINCIPAL)
        End If
        TXTBUSCAR.Focus()
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Dim textoFiltrado As String = TXTBUSCAR.Text.Replace("'", "''")
        Me.VISTACLIENTESPRINCIPALBindingSource1.Filter = CMBFILTRO.SelectedItem.ToString() & " LIKE '*" & textoFiltrado & "*'"
    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        NUEVO.LBLCLIENTES.Text = "Editar registro de cliente"
        NUEVO.LBLCLIENTES.Location = New Point(155, 15)

        If DATACLIENTES.RowCount = 0 OrElse DATACLIENTES.CurrentRow Is Nothing Then Return

        Dim fila As DataGridViewRow = DATACLIENTES.CurrentRow

        ' Usar la función del módulo para obtener valores seguros
        idbusqueda = ObtenerValorCelda(fila, "CLIID")
        NUEVO.TXTCODIGO.Text = ObtenerValorCelda(fila, "CLICODIGO")

        ' Asignar a cajas de texto
        NUEVO.TXTNOMBRE.Text = ObtenerValorCelda(fila, "CLINOMBRE")
        NUEVO.TXTAPEPATERNO.Text = ObtenerValorCelda(fila, "CLIAPEPATERNO")
        NUEVO.TXTAPEMATERNO.Text = ObtenerValorCelda(fila, "CLIAPEMATERNO")
        NUEVO.TXTCALLE.Text = ObtenerValorCelda(fila, "CLIDIRECCION")
        NUEVO.TXTCOLONIIA.Text = ObtenerValorCelda(fila, "CLICOLONIA")
        NUEVO.TXTCP.Text = ObtenerValorCelda(fila, "CLICP")
        NUEVO.TXTCIUDAD.Text = ObtenerValorCelda(fila, "CLICIUDAD")
        NUEVO.TXTESTADO.Text = ObtenerValorCelda(fila, "CLIESTADO")
        NUEVO.TXTTELEFONO.Text = ObtenerValorCelda(fila, "CLITELEFONO")
        NUEVO.TXTCORREO.Text = ObtenerValorCelda(fila, "CLICORREO")
        NUEVO.TXTNOTAS.Text = ObtenerValorCelda(fila, "CLICOMENTARIOS")
        Dim credito As String = ObtenerValorCelda(fila, "CLIHISTORIALCREDITICIO")
        If String.IsNullOrWhiteSpace(credito) Then
            NUEVO.TXTCREDITO.SelectedIndex = -1
        Else
            NUEVO.TXTCREDITO.Text = credito
        End If

        NUEVO.TXTRFC.Text = ObtenerValorCelda(fila, "CLIRFC")
        NUEVO.TXTREGIMEN.Text = ObtenerValorCelda(fila, "CLIREGIMENFISCAL")
        NUEVO.TXTCFDI.Text = ObtenerValorCelda(fila, "CLICFDI")

        ' Recargar datos si se guardó
        If NUEVO.ShowDialog = DialogResult.OK Then
            Me.VISTACLIENTESPRINCIPALTableAdapter.Connection = Conexion
            Me.VISTACLIENTESPRINCIPALTableAdapter.Fill(Me.MuebleAlexDataSet.VISTACLIENTESPRINCIPAL)
        End If

        TXTBUSCAR.Focus()
    End Sub


    Private Sub BTNELIMINAR_MouseEnter(sender As Object, e As EventArgs)
        BTNELIMINAR.BackColor = Color.Red
    End Sub

    Private Sub BTNELIMINAR_MouseLeave(sender As Object, e As EventArgs)
        BTNELIMINAR.BackColor = ColorBotones
    End Sub
    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        If DATACLIENTES.RowCount <= 0 Then
            MsgBox("No hay clientes para eliminar", MsgBoxStyle.Exclamation, "Advertencia")

        Else
            Dim CONFIRMAR = MsgBox("¿Eliminar cliente?", MsgBoxStyle.YesNo, "Confirmación")
            If CONFIRMAR = MsgBoxResult.Yes Then
                StrSql = "ELIMINARCLIENTES"
                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@CLIID", SqlDbType.BigInt).Value = Me.DATACLIENTES.CurrentRow.Cells("CLIID").Value

                If Conectar() = True Then
                    Me.VISTACLIENTESPRINCIPALTableAdapter.Connection = Conexion
                    Me.VISTACLIENTESPRINCIPALTableAdapter.Fill(Me.MuebleAlexDataSet.VISTACLIENTESPRINCIPAL)
                    MsgBox("Cliente eliminado", MsgBoxStyle.Information, "Confirmación")
                End If
            End If
            TXTBUSCAR.Focus()
        End If
    End Sub

    Private Sub DATACLIENTES_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DATACLIENTES.CellFormatting
        ' Ejemplo de condición para cambiar el color de una celda específica
        If e.ColumnIndex = 1 AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() = "ValorEspecífico" Then
            e.CellStyle.BackColor = Color.Yellow
            e.CellStyle.ForeColor = Color.Red
        End If
    End Sub

    Private Sub CMBFILTRO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBFILTRO.SelectedIndexChanged
        TXTBUSCAR_TextChanged(sender, e)
    End Sub
End Class