Imports System.Data.SqlClient

Public Class FrmUsuarios
    Dim ALTAUSUARIO As New FrmAltaUsuarios
    Private conexionLocal As New SqlConnection("server=" & SERVIDOR & "; database=" & BASEDATOS & "; uid=" & USUARIO & "; pwd=" & CONTRASEÑA & "; Application Name=SqlDependencyClient; MultipleActiveResultSets=True;")
    Private dependencia As SqlDependency ' << Variable de clase
    Private formularioCerrado As Boolean = False


    Private Sub FrmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        BTNNUEVO.BackColor = ColorBotones
        BTNEDITAR.BackColor = ColorBotones
        BTNELIMINAR.BackColor = ColorBotones
        Me.DATAUSUARIOS.BackgroundColor = ColorFormulario
        TXTBUSCAR.Focus()


        ' Iniciar SqlDependency
        Try
            SqlDependency.Stop(conexionLocal.ConnectionString)
            SqlDependency.Start(conexionLocal.ConnectionString)
            IniciarEscucha()
        Catch ex As Exception
            MessageBox.Show("Error al iniciar SqlDependency: " & ex.Message)
        End Try

        AddHandler BTNELIMINAR.MouseEnter, AddressOf Button1_MouseEnter
        AddHandler BTNELIMINAR.MouseLeave, AddressOf Button1_MouseLeave
        DATAUSUARIOS.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAUSUARIOS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
    End Sub

    Private Sub IniciarEscucha()
        Try
            Dim comando As New SqlCommand("SELECT USUID, USUNOMBRE, USULOGIN, USUTIPO FROM VISTAUSUARIOS", conexionLocal)
            dependencia = New SqlDependency(comando)
            AddHandler dependencia.OnChange, AddressOf AlCambiarDatos

            If conexionLocal.State = ConnectionState.Closed Then conexionLocal.Open()
            Dim dtNuevo As New DataTable()
            dtNuevo.Load(comando.ExecuteReader())
            conexionLocal.Close()

            ' Obtener el DataTable actual
            Dim dtActual As DataTable = TryCast(DATAUSUARIOS.DataSource, DataTable)

            If dtActual Is Nothing Then
                ' Primera vez, asignar directamente
                DATAUSUARIOS.DataSource = dtNuevo
            Else
                ' Sincronizar filas
                SincronizarFilas(dtActual, dtNuevo)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al escuchar cambios: " & ex.Message)
        End Try
    End Sub


    Private Sub AlCambiarDatos(sender As Object, e As SqlNotificationEventArgs)
        If formularioCerrado OrElse Me.IsDisposed Then
            Exit Sub
        End If

        If InvokeRequired Then
            If Not formularioCerrado AndAlso Not Me.IsDisposed Then
                Try
                    Invoke(New MethodInvoker(AddressOf IniciarEscucha))
                Catch ex As ObjectDisposedException
                    ' El formulario fue cerrado mientras se intentaba invocar, ignorar
                End Try
            End If
        Else
            If Not formularioCerrado AndAlso Not Me.IsDisposed Then
                IniciarEscucha()
            End If
        End If
    End Sub


    Private Sub FrmUsuarios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        formularioCerrado = True ' <-- Esto evita que se invoque innecesariamente
        Try
            If dependencia IsNot Nothing Then
                RemoveHandler dependencia.OnChange, AddressOf AlCambiarDatos
                dependencia = Nothing
            End If
            SqlDependency.Stop(conexionLocal.ConnectionString)
        Catch ex As Exception
            MsgBox("Error al cerrar SqlDependency: " & ex.Message)
        End Try
    End Sub


    Private Function FilasIguales(f1 As DataRow, f2 As DataRow) As Boolean
        Return f1("USUNOMBRE").ToString() = f2("USUNOMBRE").ToString() AndAlso
           f1("USULOGIN").ToString() = f2("USULOGIN").ToString() AndAlso
           f1("USUTIPO").ToString() = f2("USUTIPO").ToString()
    End Function

    Private Sub SincronizarFilas(dtActual As DataTable, dtNuevo As DataTable)
        ' Convertir a diccionarios por clave USUID
        Dim dictActual = dtActual.AsEnumerable().ToDictionary(Function(r) r.Field(Of Long)("USUID"))
        Dim dictNuevo = dtNuevo.AsEnumerable().ToDictionary(Function(r) r.Field(Of Long)("USUID"))

        ' 1. Actualizar o agregar filas
        For Each filaNueva In dictNuevo.Values
            Dim id = filaNueva.Field(Of Long)("USUID")

            If dictActual.ContainsKey(id) Then
                ' Comparar y actualizar solo si cambió algo
                Dim filaExistente = dictActual(id)
                If Not FilasIguales(filaExistente, filaNueva) Then
                    filaExistente("USUNOMBRE") = filaNueva("USUNOMBRE")
                    filaExistente("USULOGIN") = filaNueva("USULOGIN")
                    filaExistente("USUTIPO") = filaNueva("USUTIPO")
                End If
            Else
                ' Fila nueva
                dtActual.ImportRow(filaNueva)
            End If
        Next

        ' 2. Eliminar filas que ya no existen
        For Each id In dictActual.Keys.Except(dictNuevo.Keys).ToList()
            Dim fila = dictActual(id)
            dtActual.Rows.Remove(fila)
        Next
    End Sub


    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
        BTNELIMINAR.BackColor = Color.Red
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        BTNELIMINAR.BackColor = ColorBotones
    End Sub

    Private Sub TXTBUSCAR_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLUSUARIOSBindingSource.Filter = "USUNOMBRE LIKE '" & Me.TXTBUSCAR.Text & "'"
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        ALTAUSUARIO.TXTTIPO.SelectedIndex = -1
        ALTAUSUARIO.LBLUSUARIOS.Text = "Alta de usuarios"
        ALTAUSUARIO.LBLUSUARIOS.Location = New Point(175, 9)
        For Each CTRL As Control In ALTAUSUARIO.Controls
            If TypeOf CTRL Is TextBox Then DirectCast(CTRL, TextBox).Clear()
        Next
        idbusqueda = 0

        If ALTAUSUARIO.ShowDialog() = DialogResult.OK Then
            IniciarEscucha()
        End If
        TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim ELIMINAR = MsgBox("¿Eliminar usuario?", MsgBoxStyle.YesNo, "Advertencia")
        If ELIMINAR = DialogResult.Yes Then
            StrSql = "ELIMINARUSUARIOS"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = Me.DATAUSUARIOS.CurrentRow.Cells("USUID").Value

            If Conectar() = True Then
                comando.ExecuteNonQuery()
                IniciarEscucha()
                MsgBox("Usuario eliminado", MsgBoxStyle.Information, "Confirmación")
            End If
        End If
        TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        ALTAUSUARIO.LBLUSUARIOS.Text = "Editar perfil de usuario"
        ALTAUSUARIO.LBLUSUARIOS.Location = New Point(155, 9)

        If DATAUSUARIOS.RowCount > 0 Then
            idbusqueda = DATAUSUARIOS.CurrentRow.Cells("USUID").Value
            ALTAUSUARIO.TXTNOMBRE.Text = DATAUSUARIOS.CurrentRow.Cells("USUNOMBRE").Value
            ALTAUSUARIO.TXTLOGIN.Text = DATAUSUARIOS.CurrentRow.Cells("USULOGIN").Value
            ALTAUSUARIO.TXTTIPO.Text = DATAUSUARIOS.CurrentRow.Cells("USUTIPO").Value

            If ALTAUSUARIO.ShowDialog = DialogResult.OK Then
                IniciarEscucha()
            End If
        End If
        TXTBUSCAR.Focus()
    End Sub
End Class