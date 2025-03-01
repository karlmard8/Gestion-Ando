Imports System.Data.SqlClient

Public Class FrmUsuarios
    Dim ALTAUSUARIO As New FrmAltaUsuarios
    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTBUSCAR.Focus()
        Me.TBLUSUARIOSTableAdapter.Connection = Conexion
        Me.TBLUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLUSUARIOS)

    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLUSUARIOSBindingSource.Filter = "USUNOMBRE LIKE '*" & Me.TXTBUSCAR.Text & "*'"
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        ALTAUSUARIO.TXTTIPO.SelectedIndex = -1
        ALTAUSUARIO.LBLUSUARIOS.Text = "Alta de usuarios"
        For Each CTRL As Control In ALTAUSUARIO.Controls
            If TypeOf CTRL Is TextBox Then
                DirectCast(CTRL, TextBox).Clear()
            End If
        Next
        idbusqueda = 0

        If ALTAUSUARIO.ShowDialog() = DialogResult.OK Then
            Me.TBLUSUARIOSTableAdapter.Connection = Conexion
            Me.TBLUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLUSUARIOS)
        End If

    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        StrSql = "ELIMINARUSUARIOS"
        comando = New SqlClient.SqlCommand(StrSql, Conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = Me.DATAUSUARIOS.CurrentRow.Cells("USUID").Value

        If Conectar() = True Then
            Me.TBLUSUARIOSTableAdapter.Connection = Conexion
            Me.TBLUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLUSUARIOS)
            MsgBox("Usuario eliminado", MsgBoxStyle.Information, "Confirmación")
        End If

    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        ALTAUSUARIO.LBLUSUARIOS.Text = "Editar perfil de usuario"
        If DATAUSUARIOS.RowCount > 0 Then
            idbusqueda = DATAUSUARIOS.CurrentRow.Cells("USUID").Value
            ALTAUSUARIO.TXTNOMBRE.Text = DATAUSUARIOS.CurrentRow.Cells("USUNOMBRE").Value
            ALTAUSUARIO.TXTLOGIN.Text = DATAUSUARIOS.CurrentRow.Cells("USULOGIN").Value
            ALTAUSUARIO.TXTCLAVE.Text = DATAUSUARIOS.CurrentRow.Cells("USUCLAVE").Value
            ALTAUSUARIO.TXTTIPO.Text = DATAUSUARIOS.CurrentRow.Cells("USUTIPO").Value

            If ALTAUSUARIO.ShowDialog = DialogResult.OK Then
                Me.TBLUSUARIOSTableAdapter.Connection = Conexion
                Me.TBLUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLUSUARIOS)
            End If
        End If
    End Sub
End Class