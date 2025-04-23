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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim horaActual As DateTime = DateTime.Now
        LBLHORA.Text = horaActual.ToString("hh:mm:ss tt")
    End Sub

    Public Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Timer1.Interval = 1000 ' 1000 milisegundos = 1 segundo
        Timer1.Start()
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
        End If

    End Sub


    Public Sub ALERTADEUDORES()
        Dim DEUDAS As New DataTable()
        Dim TABLADEUDAS As New DataGridView()
        Dim DEUDORES As New Form

        DEUDORES.Text = "Deudas pendientes"
        DEUDORES.Size = New Size(615, 300)
        DEUDORES.StartPosition = FormStartPosition.CenterScreen
        DEUDORES.FormBorderStyle = FormBorderStyle.FixedSingle
        DEUDORES.MaximizeBox = False
        DEUDORES.MinimizeBox = False
        DEUDORES.BackColor = ColorFormulario
        DEUDORES.ShowIcon = False
        DEUDORES.ShowInTaskbar = False

        ' 🔥 Capturar la tecla ESC para cerrar el formulario
        DEUDORES.KeyPreview = True
        AddHandler DEUDORES.KeyDown, Sub(sender, e)
                                         If e.KeyCode = Keys.Escape Then
                                             DEUDORES.Close()
                                         End If
                                     End Sub

        Try
            StrSql = "SELECT  
                    TBLUSUARIOS.USUNOMBRE AS Cliente,  
                    TBLPAGOS.PAGMONTO AS 'A pagar',  
                    TBLPAGOS.PAGFECHA AS 'Fecha límite',  
                    DATEDIFF(DAY, GETDATE(), TBLPAGOS.PAGFECHA) AS 'Días restantes'  
                FROM TBLVENTAS  
                JOIN TBLUSUARIOS ON TBLVENTAS.USUID = TBLUSUARIOS.USUID  
                JOIN TBLPAGOS ON TBLVENTAS.VENID = TBLPAGOS.VENID  
                WHERE TBLVENTAS.VENEXISTE = 1  
                AND TBLVENTAS.VENFORMA = 'CRÉDITO'  
                AND DATEDIFF(DAY, GETDATE(), TBLPAGOS.PAGFECHA) BETWEEN 0 AND 3;"

            Using conexion As New SqlClient.SqlConnection("Server=" & SERVIDOR & ";Database=" & BASEDATOS & ";User Id=" & USUARIO & ";Password=" & CONTRASEÑA)
                conexion.Open()
                Dim comando As New SqlClient.SqlCommand(StrSql, conexion)
                Dim adaptador As New SqlClient.SqlDataAdapter(comando)
                adaptador.Fill(DEUDAS) ' 🔥 Llenar el `DataTable` con los resultados de SQL
                conexion.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener deudores: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' 🔹 Crear `DataGridView` para mostrar deudores

        TABLADEUDAS.DataSource = DEUDAS
        TABLADEUDAS.Size = New Size(599, 200)
        TABLADEUDAS.Location = New Point(0, 50)
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
        TABLADEUDAS.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        TABLADEUDAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        TABLADEUDAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

        ' 🔹 Agregar controles al formulario
        DEUDORES.Controls.Add(TABLADEUDAS)
        DEUDORES.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmInventario.Close()
        FrmUsuarios.Close()
        FrmVentas.Close()
        Dim CLIENTES As New FrmClientes
        idbusqueda = 0
        FrmClientes.TBLCLIENTESTableAdapter.Connection = Conexion
        FrmClientes.TBLCLIENTESTableAdapter.Fill(FrmClientes.MuebleAlexDataSet.TBLCLIENTES)
        FrmClientes.TopLevel = False
        PANELFRAMES.Controls.Add(FrmClientes)
        FrmClientes.Show()
        LBLOPCIONES.Text = "Clientes"
        LBLOPCIONES.Location = New Point(50, 40)
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        FrmClientes.Close()
        FrmInventario.Close()
        FrmUsuarios.Close()
        idbusqueda = 0
        FrmVentas.VISTAVENTASTableAdapter.Connection = Conexion
        FrmVentas.VISTAVENTASTableAdapter.Fill(FrmVentas.MuebleAlexDataSet.VISTAVENTAS)
        FrmVentas.TopLevel = False
        PANELFRAMES.Controls.Add(FrmVentas)
        FrmVentas.Show()
        FrmVentas.Location = New Point(540, 0)
        LBLOPCIONES.Text = "Ventas"
        LBLOPCIONES.Location = New Point(625, 40)
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        FrmClientes.Close()
        FrmUsuarios.Close()
        FrmVentas.Close()
        Dim INVENTARIO As New FrmInventario
        idbusqueda = 0
        FrmInventario.TBLPRODUCTOSTableAdapter.Connection = Conexion
        FrmInventario.TBLPRODUCTOSTableAdapter.Fill(FrmInventario.MuebleAlexDataSet.TBLPRODUCTOS)
        FrmInventario.TopLevel = False
        PANELFRAMES.Controls.Add(FrmInventario)
        FrmInventario.Show()
        LBLOPCIONES.Text = "Inventario"
        LBLOPCIONES.Location = New Point(50, 40)
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        FrmClientes.Close()
        FrmInventario.Close()
        FrmVentas.Close()
        Dim USUARIOS As New FrmUsuarios
        idbusqueda = 0
        FrmUsuarios.TBLUSUARIOSTableAdapter.Connection = Conexion
        Dim sql As String = "SELECT USUID, USUNOMBRE, USULOGIN, USUTIPO FROM TblUsuarios"
        Dim adapter As New SqlDataAdapter(sql, Conexion)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        FrmUsuarios.DATAUSUARIOS.DataSource = dt

        FrmUsuarios.TopLevel = False
        PANELFRAMES.Controls.Add(FrmUsuarios)
        FrmUsuarios.Location = New Point(575, 0)
        FrmUsuarios.Show()
        LBLOPCIONES.Text = "Usuarios"
        LBLOPCIONES.Location = New Point(625, 40)
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
            ' Code to completely stop the application
            Application.Exit()
        End If
    End Sub
    Private Sub BTNDEUDORES_Click(sender As Object, e As EventArgs) Handles BTNDEUDORES.Click
        ALERTADEUDORES()
    End Sub
End Class