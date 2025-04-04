Imports System.Data.SqlClient

Public Class FrmUsuarios
    Dim ALTAUSUARIO As New FrmAltaUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTAUSUARIOS' Puede moverla o quitarla según sea necesario.


        Me.BackColor = ColorFormulario
        BTNNUEVO.BackColor = ColorBotones
        BTNEDITAR.BackColor = ColorBotones
        BTNELIMINAR.BackColor = ColorBotones
        Me.DATAUSUARIOS.BackgroundColor = ColorFormulario
        TXTBUSCAR.Focus()
        Me.TBLUSUARIOSTableAdapter.Connection = Conexion
        Dim sql As String = "SELECT * FROM VISTAUSUARIOS"
        Dim adapter As New SqlDataAdapter(sql, Conexion)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        DATAUSUARIOS.DataSource = dt

        AddHandler BTNELIMINAR.MouseEnter, AddressOf Button1_MouseEnter
        AddHandler BTNELIMINAR.MouseLeave, AddressOf Button1_MouseLeave
        DATAUSUARIOS.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAUSUARIOS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
        ' Cambiar el color del botón a rojo cuando el cursor pasa por encima
        BTNELIMINAR.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        ' Restaurar el color original del botón cuando el cursor sale del botón
        BTNELIMINAR.BackColor = ColorBotones
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLUSUARIOSBindingSource.Filter = "USUNOMBRE LIKE '*" & Me.TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        ALTAUSUARIO.TXTTIPO.SelectedIndex = -1
        ALTAUSUARIO.LBLUSUARIOS.Text = "Alta de usuarios"
        ALTAUSUARIO.LBLUSUARIOS.Location = New Point(175, 9)
        For Each CTRL As Control In ALTAUSUARIO.Controls
            If TypeOf CTRL Is TextBox Then
                DirectCast(CTRL, TextBox).Clear()
            End If
        Next
        idbusqueda = 0

        If ALTAUSUARIO.ShowDialog() = DialogResult.OK Then
            Me.TBLUSUARIOSTableAdapter.Connection = Conexion
            Dim sql As String = "SELECT * FROM VISTAUSUARIOS"
            Dim adapter As New SqlDataAdapter(sql, Conexion)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            DATAUSUARIOS.DataSource = dt
        End If
        ME.TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim ELIMINAR = MsgBox("¿Eliminar usuario?", MsgBoxStyle.YesNo, "Advertencia")
        If ELIMINAR = DialogResult.Yes Then
            StrSql = "ELIMINARUSUARIOS"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = Me.DATAUSUARIOS.CurrentRow.Cells("USUID").Value

            If Conectar() = True Then
                Me.TBLUSUARIOSTableAdapter.Connection = Conexion
                Dim sql As String = "SELECT * FROM VISTAUSUARIOS"
                Dim adapter As New SqlDataAdapter(sql, Conexion)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DATAUSUARIOS.DataSource = dt
                MsgBox("Usuario eliminado", MsgBoxStyle.Information, "Confirmación")
            End If
        End If
        Me.TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        ALTAUSUARIO.LBLUSUARIOS.Text = "Editar perfil de usuario"
        ALTAUSUARIO.LBLUSUARIOS.Location = New Point(155, 9)
        If DATAUSUARIOS.RowCount > 0 Then
            idbusqueda = DATAUSUARIOS.CurrentRow.Cells("USUID").Value
            ALTAUSUARIO.TXTNOMBRE.Text = DATAUSUARIOS.CurrentRow.Cells("USUNOMBRE").Value
            ALTAUSUARIO.TXTLOGIN.Text = DATAUSUARIOS.CurrentRow.Cells("USULOGIN").Value
            'ALTAUSUARIO.TXTCLAVE.Text = DATAUSUARIOS.CurrentRow.Cells("USUCLAVE").Value
            ALTAUSUARIO.TXTTIPO.Text = DATAUSUARIOS.CurrentRow.Cells("USUTIPO").Value

            If ALTAUSUARIO.ShowDialog = DialogResult.OK Then
                Me.TBLUSUARIOSTableAdapter.Connection = Conexion
                Dim sql As String = "SELECT * FROM VISTAUSUARIOS"
                Dim adapter As New SqlDataAdapter(sql, Conexion)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                DATAUSUARIOS.DataSource = dt
            End If
        End If
        Me.TXTBUSCAR.Focus()

    End Sub
End Class