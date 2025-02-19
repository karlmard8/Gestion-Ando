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
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        FrmClientes.Close()
        FrmInventario.Close()
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
        FrmUsuarios.Location = New Point(520, 0)
        FrmUsuarios.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim resultado As DialogResult = MessageBox.Show("¿Deseas cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Application.Restart()
        End If
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1920, 1040)
    End Sub
End Class