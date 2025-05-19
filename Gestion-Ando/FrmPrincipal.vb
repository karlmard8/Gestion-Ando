Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FrmPrincipal
    Public Class CustomMenuRenderer
        Inherits ToolStripProfessionalRenderer

        Protected Overrides Sub OnRenderMenuItemBackground(e As ToolStripItemRenderEventArgs)
            MyBase.OnRenderMenuItemBackground(e)

            ' Dibujar manualmente el texto del elemento de menú
            DrawMenuItemText(e)
        End Sub

        Protected Overrides Sub OnRenderItemText(e As ToolStripItemTextRenderEventArgs)
            ' Evitar que el texto predeterminado se dibuje
        End Sub

        Private Sub DrawMenuItemText(e As ToolStripItemRenderEventArgs)
            ' Definir el color del texto según si el ítem está seleccionado
            Dim textColor As Color = If(e.Item.Selected, Color.Black, Color.White)

            ' Crear un pincel para el texto
            Using textBrush As New SolidBrush(textColor)
                ' Definir el rectángulo de dibujo
                Dim textRect As Rectangle = New Rectangle(e.Item.ContentRectangle.X, e.Item.ContentRectangle.Y, e.Item.ContentRectangle.Width, e.Item.ContentRectangle.Height)

                ' Dibujar el texto del elemento de menú
                e.Graphics.DrawString(e.Item.Text, e.Item.Font, textBrush, textRect, StringFormat.GenericDefault)
            End Using ' Liberar automáticamente el recurso del pincel
        End Sub
    End Class


    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HTCAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Private Shared Function ReleaseCapture() As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As IntPtr) As IntPtr
    End Function
    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_NCLBUTTONDOWN AndAlso m.WParam.ToInt32() = HTCAPTION Then
            Return
        End If
        MyBase.WndProc(m)
    End Sub

    Public Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' 🔹 Cada segundo verifica la hora
        AddHandler Timer1.Tick, AddressOf VerificarHora
        Timer1.Start()


        Me.BackColor = ColorFormulario
        Me.MenuOpciones.BackColor = ColorMenuStrip
        BTNDEUDORES.BackColor = ColorBotones

        LBLFECHA.BackColor = ColorMenuStrip
        LBLFECHA.ForeColor = Color.White
        LBLHORA.BackColor = ColorMenuStrip
        LBLHORA.ForeColor = Color.White
        LBLLOGIN.BackColor = ColorMenuStrip
        LBLLOGIN.ForeColor = Color.White
        FECHA = Today.Date.ToString("dd/MM/yyyy")
        LBLFECHA.Text = FECHA

        LBLLOGIN.Text = "Bienvenido " + FrmLogin.TXTLOGIN.Text.ToUpper()
        StrSql = "INICIARSESION"
        comando = New SqlClient.SqlCommand(StrSql, Conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@USULOGIN", SqlDbType.VarChar, 10).Value = FrmLogin.TXTLOGIN.Text
        comando.Parameters.Add("@USUCLAVE", SqlDbType.VarChar, 10).Value = FrmLogin.TXTCONTRASEÑA.Text
        comando.Parameters.Add("@RETORNO", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output
        comando.Parameters.Add("@RETORNO2", SqlDbType.VarChar, 60).Direction = ParameterDirection.Output
        comando.Parameters.Add("@RETORNO3", SqlDbType.BigInt).Direction = ParameterDirection.Output

        If Conectar() = True Then
            If comando.Parameters("@RETORNO").Value = "Administrador" Then
                TIPO = "Administrador"
                Me.MenuOpciones.Items(3).Visible = True
            Else
                TIPO = "Operativo"
                Me.MenuOpciones.Items(3).Visible = False
            End If
        End If
        Dim renderer As New CustomMenuRenderer()
        USUARIOACTUAL = comando.Parameters("@RETORNO2").Value
        IDUSUARIOACTUAL = comando.Parameters("@RETORNO3").Value
        ' Asignar el renderizador personalizado al MenuStrip
        MenuOpciones.Renderer = renderer

        If TIPOPRODUCTO = "CLASE" Then
            BTNDEUDORES.Visible = False
            MenuOpciones.Items(4).Visible = False
        End If

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim horaActual As DateTime = DateTime.Now
        LBLHORA.Text = horaActual.ToString("hh:mm:ss tt")
    End Sub

    Public Class FrmTiempo
        Public WithEvents Timer1 As New Timer()
    End Class

    Dim mensajeMostradoHoy As Boolean = False
    Private Sub VerificarHora(sender As Object, e As EventArgs)
        Dim horaObjetivo As TimeSpan = New TimeSpan(12, 25, 0) ' 🔥 Hora específica
        Dim horaActual As TimeSpan = DateTime.Now.TimeOfDay ' 🔹 Obtener la hora actual

        ' 🔥 Mostrar el mensaje solo una vez cuando sea exactamente la hora
        If horaActual.Hours = horaObjetivo.Hours AndAlso horaActual.Minutes = horaObjetivo.Minutes AndAlso Not mensajeMostradoHoy Then
            mensajeMostradoHoy = True ' 🔥 Marcar el mensaje como mostrado para evitar repetición
            MessageBox.Show("¡Es hora de cerrar la caja!", "Alerta de horario", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' 🔥 Reiniciar la bandera al inicio del día
        If horaActual.Hours = 0 AndAlso horaActual.Minutes = 0 Then
            mensajeMostradoHoy = False ' 🔹 Permitir que se muestre nuevamente al día siguiente
        End If
    End Sub


    Public Sub ALERTADEUDORES()
        Dim DEUDAS As New DataTable()
        Dim TABLADEUDAS As New DataGridView()
        Dim FRMDEUDORES As New Form

        FRMDEUDORES.Text = "Deudas pendientes"
        FRMDEUDORES.Size = New Size(750, 350)
        FRMDEUDORES.StartPosition = FormStartPosition.CenterScreen
        FRMDEUDORES.FormBorderStyle = FormBorderStyle.FixedSingle
        FRMDEUDORES.MaximizeBox = False
        FRMDEUDORES.MinimizeBox = False
        FRMDEUDORES.BackColor = ColorFormulario
        FRMDEUDORES.ShowIcon = False
        FRMDEUDORES.ShowInTaskbar = False

        ' 🔥 Capturar la tecla ESC para cerrar el formulario
        FRMDEUDORES.KeyPreview = True
        AddHandler FRMDEUDORES.KeyDown, Sub(sender, e)
                                            If e.KeyCode = Keys.Escape Then
                                                FRMDEUDORES.Close()
                                            End If
                                        End Sub

        Try
            StrSql = "SELECT  
                        TBLVENTAS.VENID AS 'No.Venta',
                        TBLUSUARIOS.USUNOMBRE AS Cliente,  
                        TBLPAGOS.PAGMONTO AS 'A pagar',  
                        TBLPAGOS.PAGFECHA AS 'Fecha límite',  
                        DATEDIFF(DAY, GETDATE(), TBLPAGOS.PAGFECHA) AS 'Días restantes'  
                    FROM TBLVENTAS  
                    JOIN TBLUSUARIOS ON TBLVENTAS.USUID = TBLUSUARIOS.USUID  
                    JOIN TBLPAGOS ON TBLVENTAS.VENID = TBLPAGOS.VENID  
                    WHERE TBLVENTAS.VENEXISTE = 1  
                    AND TBLVENTAS.VENFORMA = 'CRÉDITO'  
                    AND DATEDIFF(DAY, GETDATE(), TBLPAGOS.PAGFECHA) BETWEEN 0 AND 3  
                    ORDER BY TBLVENTAS.VENID DESC;;"

            Using conexion As New SqlClient.SqlConnection("Server=" & SERVIDOR & ";Database=" & BASEDATOS & ";User Id=" & USUARIO & ";Password=" & CONTRASEÑA)
                conexion.Open()
                Dim comando As New SqlClient.SqlCommand(StrSql, conexion)
                Dim adaptador As New SqlClient.SqlDataAdapter(comando)
                adaptador.Fill(DEUDAS) 'Llenar el `DataTable` con los resultados de SQL
                conexion.Close()
            End Using

            TABLADEUDAS.DataSource = DEUDAS

            For Each col As DataGridViewColumn In TABLADEUDAS.Columns
                Debug.Print(col.Name)
            Next

            TABLADEUDAS.Size = New Size(733, 300)
            TABLADEUDAS.Location = New Point(0, 0)
            TABLADEUDAS.BackgroundColor = ColorFormulario
            TABLADEUDAS.RowHeadersVisible = False
            TABLADEUDAS.DefaultCellStyle.Font = New Font("Dubai", 12)
            TABLADEUDAS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
            TABLADEUDAS.MultiSelect = False
            TABLADEUDAS.AllowUserToAddRows = False
            TABLADEUDAS.AllowUserToDeleteRows = False
            TABLADEUDAS.AllowUserToOrderColumns = False
            TABLADEUDAS.AllowUserToResizeColumns = False
            TABLADEUDAS.AllowUserToResizeRows = False
            TABLADEUDAS.ReadOnly = True
            TABLADEUDAS.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            TABLADEUDAS.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            TABLADEUDAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            TABLADEUDAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells


        Catch ex As Exception
            MessageBox.Show("Error al obtener deudores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


        AddHandler TABLADEUDAS.DataBindingComplete, Sub(sender, e)
                                                        If TABLADEUDAS.Columns.Count > 0 Then
                                                            TABLADEUDAS.Columns("A pagar").DefaultCellStyle.Format = "C2"
                                                            TABLADEUDAS.Columns("No.Venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                                                            TABLADEUDAS.Columns("Fecha límite").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                                                            TABLADEUDAS.Columns("Días restantes").AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                                                        End If
                                                    End Sub

        ' 🔹 Agregar controles al formulario

        Application.DoEvents() ' 🔥 Deja que la UI procese los cambios antes de continuar
        TABLADEUDAS.Refresh() ' 🔥 Refresca el `DataGridView` para cargar las columnas correctamente

        FRMDEUDORES.Controls.Add(TABLADEUDAS)
        FRMDEUDORES.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmInventario.Close()
        FrmUsuarios.Close()
        FrmVentas.Close()
        FrmCorteDeCaja.Close()
        Dim CLIENTES As New FrmClientes
        idbusqueda = 0
        FrmClientes.TBLCLIENTESTableAdapter.Connection = Conexion
        FrmClientes.TBLCLIENTESTableAdapter.Fill(FrmClientes.MuebleAlexDataSet.TBLCLIENTES)
        FrmClientes.TopLevel = False
        PANELFRAMES.Controls.Add(FrmClientes)
        FrmClientes.Show()
        LBLOPCIONES.Visible = True
        LBLOPCIONES.Text = "Clientes"
        LBLOPCIONES.Location = New Point(50, 40)
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        FrmClientes.Close()
        FrmInventario.Close()
        FrmUsuarios.Close()
        FrmCorteDeCaja.Close()
        idbusqueda = 0
        FrmVentas.VISTAVENTASTableAdapter.Connection = Conexion
        FrmVentas.VISTAVENTASTableAdapter.Fill(FrmVentas.MuebleAlexDataSet.VISTAVENTAS)
        FrmVentas.TopLevel = False
        PANELFRAMES.Controls.Add(FrmVentas)
        FrmVentas.Show()
        FrmVentas.Location = New Point(380, 0)
        LBLOPCIONES.Visible = True
        LBLOPCIONES.Text = "Ventas"
        LBLOPCIONES.Location = New Point(430, 38)
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        FrmClientes.Close()
        FrmUsuarios.Close()
        FrmVentas.Close()
        FrmCorteDeCaja.Close()
        Dim INVENTARIO As New FrmInventario
        idbusqueda = 0
        FrmInventario.TBLPRODUCTOSTableAdapter.Connection = Conexion
        FrmInventario.TBLPRODUCTOSTableAdapter.Fill(FrmInventario.MuebleAlexDataSet.TBLPRODUCTOS)
        FrmInventario.TopLevel = False
        PANELFRAMES.Controls.Add(FrmInventario)
        FrmInventario.Show()
        LBLOPCIONES.Visible = True
        LBLOPCIONES.Text = "Inventario"
        LBLOPCIONES.Location = New Point(50, 40)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FrmClientes.Close()
        FrmInventario.Close()
        FrmVentas.Close()
        FrmCorteDeCaja.Close()
        idbusqueda = 0
        FrmUsuarios.TBLUSUARIOSTableAdapter.Connection = Conexion
        Dim sql As String = "SELECT USUID, USUNOMBRE, USULOGIN, USUTIPO FROM TblUsuarios WHERE USUEXISTE=1"
        Dim adapter As New SqlDataAdapter(sql, Conexion)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        FrmUsuarios.DATAUSUARIOS.DataSource = dt

        FrmUsuarios.TopLevel = False
        PANELFRAMES.Controls.Add(FrmUsuarios)
        FrmUsuarios.Location = New Point(575, 0)
        FrmUsuarios.Show()
        LBLOPCIONES.Visible = True
        LBLOPCIONES.Text = "Usuarios"
        LBLOPCIONES.Location = New Point(625, 40)
    End Sub

    Private Sub CorteDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorteDeCajaToolStripMenuItem.Click
        FrmClientes.Close()
        FrmInventario.Close()
        FrmVentas.Close()
        FrmUsuarios.Close()

        FrmCorteDeCaja.TopLevel = False
        PANELFRAMES.Controls.Add(FrmCorteDeCaja)
        FrmCorteDeCaja.Show()
        LBLOPCIONES.Visible = False
    End Sub

    Private isLoggingOut As Boolean = False

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim CONFIRMACION As DialogResult
        CONFIRMACION = MessageBox.Show("¿Cerrar sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If CONFIRMACION = DialogResult.Yes Then
            isLoggingOut = True
            Me.Close()
            FrmLogin.Show()
            FrmLogin.TXTLOGIN.Text = String.Empty
            FrmLogin.TXTCONTRASEÑA.Text = String.Empty
            FrmLogin.TXTLOGIN.Focus()
        Else

        End If


    End Sub

    Private Sub FrmPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Not isLoggingOut Then
            Dim respuesta As DialogResult = MessageBox.Show("¿Está seguro de que desea cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = DialogResult.No Then
                e.Cancel = True
            Else
                Application.Exit()
            End If
        End If
    End Sub
    Private Sub BTNDEUDORES_Click(sender As Object, e As EventArgs) Handles BTNDEUDORES.Click
        ALERTADEUDORES()
    End Sub
End Class