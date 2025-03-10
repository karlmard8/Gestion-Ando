Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class FrmPrincipal

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

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = colorDurazno
        Me.MenuOpciones.BackColor = colorGrisClaro
        LBLFECHA.Text = Today.Date
        Timer1.Interval = 1000 ' 1000 milisegundos = 1 segundo
        Timer1.Start()
        LBLLOGIN.Text = "Bienvenido " + FrmLogin.TXTLOGIN.Text.ToUpper()
        StrSql = "INICIARSESION"
        comando = New SqlClient.SqlCommand(StrSql, Conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@USULOGIN", SqlDbType.VarChar, 10).Value = FrmLogin.TXTLOGIN.Text
        comando.Parameters.Add("@USUCLAVE", SqlDbType.VarChar, 10).Value = FrmLogin.TXTCONTRASEÑA.Text
        comando.Parameters.Add("@RETORNO", SqlDbType.VarChar, 15).Direction = ParameterDirection.Output

        If Conectar() = True Then
            If comando.Parameters("@RETORNO").Value = "Administrador" Then
                TIPO = "Administrador"
                Me.MenuOpciones.Items(4).Visible = True
            Else

                TIPO = "Operativo"
                Me.MenuOpciones.Items(4).Visible = False
            End If
        End If
        Me.Size = New Size(1930, 1040)
    End Sub


    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        FrmInventario.Close()
        FrmUsuarios.Close()

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

        LBLOPCIONES.Text = "Ventas"
        LBLOPCIONES.Location = New Point(50, 40)
    End Sub

    Private Sub InventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioToolStripMenuItem.Click
        FrmClientes.Close()
        FrmUsuarios.Close()
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
        Dim USUARIOS As New FrmUsuarios
        idbusqueda = 0
        FrmUsuarios.TBLUSUARIOSTableAdapter.Connection = Conexion
        FrmUsuarios.TBLUSUARIOSTableAdapter.Fill(FrmUsuarios.MuebleAlexDataSet.TBLUSUARIOS)
        FrmUsuarios.TopLevel = False
        PANELFRAMES.Controls.Add(FrmUsuarios)
        FrmUsuarios.Location = New Point(575, 0)
        FrmUsuarios.Show()
        LBLOPCIONES.Text = "Usuarios"
        LBLOPCIONES.Location = New Point(625, 40)
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Close()
        FrmLogin.Show()
        FrmLogin.TXTLOGIN.Text = String.Empty
        FrmLogin.TXTCONTRASEÑA.Text = String.Empty
        FrmLogin.TXTLOGIN.Focus()
    End Sub


End Class