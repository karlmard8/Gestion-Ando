Imports System.Data.SqlClient

Public Class FrmUsuarios
    Dim ALTAUSUARIO As New FrmAltaUsuarios
    Dim tablaOriginal As DataTable
    Public MENSAJE As Boolean = False


    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        EstiloBotones.CambiarColorBotones(Me)
        Me.DATAUSUARIOS.BackgroundColor = ColorFormulario
        TXTBUSCAR.Focus()

        ' Cargar la tabla completa y almacenarla en la variable global
        CargarDatos()
        AplicarFormatoDataGridView()
        AddHandler BTNELIMINAR.MouseEnter, AddressOf BTNELIMINAR_MouseEnter
        AddHandler BTNELIMINAR.MouseLeave, AddressOf BTNELIMINAR_MouseLeave
    End Sub
    Private Sub BTNELIMINAR_MouseEnter(sender As Object, e As EventArgs)
        ' Cambiar el color del botón a rojo cuando el cursor pasa por encima
        BTNELIMINAR.BackColor = Color.Red
    End Sub

    Private Sub BTNELIMINAR_MouseLeave(sender As Object, e As EventArgs)
        ' Restaurar el color original del botón cuando el cursor sale del botón
        BTNELIMINAR.BackColor = ColorBotones
    End Sub
    Private Sub CargarDatos()
        Dim cadenaConexion As String = "server=" & SERVIDOR & "; database=" & BASEDATOS & "; uid=" & USUARIO & "; pwd=" & CONTRASEÑA & ";"
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT * FROM VISTAUSUARIOS"
        Dim adapter As New SqlDataAdapter(sql, conexion)
        Dim dt As New DataTable()

        Try
            conexion.Open()
            adapter.Fill(dt)

            ' Guardar una copia de la tabla original para restauración
            tablaOriginal = dt.Copy()

            DATAUSUARIOS.DataSource = tablaOriginal
        Catch ex As Exception
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexion.Close()
        End Try
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        If tablaOriginal IsNot Nothing Then
            If TXTBUSCAR.Text.Trim() = "" Then
                ' Restaurar la tabla completa
                DATAUSUARIOS.DataSource = tablaOriginal.Copy()
            Else
                ' Filtrar solo si hay texto
                Dim resultado = tablaOriginal.Select("USUNOMBRE LIKE '%" & TXTBUSCAR.Text & "%'")
                If resultado.Length > 0 Then
                    DATAUSUARIOS.DataSource = resultado.CopyToDataTable()
                Else
                    DATAUSUARIOS.DataSource = tablaOriginal.Clone() ' Mostrar tabla vacía si no hay resultados
                End If
            End If

            ' 🔹 Restaurar ajustes visuales después de cambiar la fuente de datos
            AplicarFormatoDataGridView()
        End If
    End Sub
    Private Sub AplicarFormatoDataGridView()
        DATAUSUARIOS.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAUSUARIOS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
        DATAUSUARIOS.BackgroundColor = ColorFormulario
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
        Me.TXTBUSCAR.Focus()
        MENSAJE = False
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click

        If DATAUSUARIOS.RowCount <= 0 Then
            MsgBox("No hay clientes para eliminar", MsgBoxStyle.Critical, "Advertencia")

        Else
            If DATAUSUARIOS.CurrentRow.Cells("USUNOMBRE").Value = USUARIOACTUAL Then
                MsgBox("No puedes eliminar el usuario actual", MsgBoxStyle.Critical, "Advertencia")
            Else
                Dim ELIMINAR = MsgBox("¿Eliminar usuario?", MsgBoxStyle.YesNo, "Confirmación")
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
            End If
        End If
    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        MENSAJE = True
        If DATAUSUARIOS.CurrentRow.Cells("USUNOMBRE").Value <> USUARIOACTUAL Then
            MsgBox("No puedes modificar este perfil de usuario", MsgBoxStyle.Critical, "Advertencia")
        Else
            ALTAUSUARIO.LBLUSUARIOS.Text = "Editar perfil de usuario"

            ALTAUSUARIO.LBLUSUARIOS.Location = New Point(155, 9)
            If DATAUSUARIOS.RowCount > 0 Then
                idbusqueda = DATAUSUARIOS.CurrentRow.Cells("USUID").Value
                ALTAUSUARIO.TXTNOMBRE.Text = DATAUSUARIOS.CurrentRow.Cells("USUNOMBRE").Value
                ALTAUSUARIO.TXTLOGIN.Text = DATAUSUARIOS.CurrentRow.Cells("USULOGIN").Value
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
        End If


    End Sub
End Class