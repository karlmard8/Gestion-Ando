Imports System.Data.SqlClient

Public Class FrmCorteDeCaja
    Private Sub FrmCorteDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTACORTECAJA' Puede moverla o quitarla según sea necesario.
        Me.VISTACORTECAJATableAdapter.Connection = Conexion
        Me.VISTACORTECAJATableAdapter.Fill(Me.MuebleAlexDataSet.VISTACORTECAJA)


        EstiloBotones.CambiarColorBotones(Me)
        Me.BackColor = ColorFormulario
        DATACORTECAJA.BackgroundColor = ColorFormulario
        DATACORTECAJA.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATACORTECAJA.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)

        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTAUSUARIOS' Puede moverla o quitarla según sea necesario.
        Me.VISTAUSUARIOSTableAdapter.Connection = Conexion
        Me.VISTAUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAUSUARIOS)

        ' CargarCorteCaja(DATACORTECAJA, CMBUSUARIO)
    End Sub

    Public Sub CargarCorteCaja(ByVal DATACORTECAJA As DataGridView, ByVal cmbUsuario As ComboBox)
        Try
            ' Obtener el valor seleccionado en el ComboBox
            Dim USUID As Integer = Convert.ToInt32(cmbUsuario.SelectedValue)

            ' Definir la consulta con parámetro @USUID
            Dim query As String = "SELECT *
                               FROM VISTACORTECAJA   
                               WHERE VENDEDOR = @USUNOMBRE "

            ' Crear el comando SQL
            Dim comando As New SqlClient.SqlCommand(query, Conexion)
            comando.Parameters.AddWithValue("@USUNOMBRE", cmbUsuario.Text) ' Asignar parámetro desde ComboBox

            ' Adaptador de datos y tabla
            Dim adapter As New SqlClient.SqlDataAdapter(comando)
            Dim table As New DataTable()

            ' Llenar la tabla con los resultados de la consulta
            adapter.Fill(table)

            ' Asignar la tabla como origen de datos del DataGridView
            DATACORTECAJA.DataSource = table

            ' 🔥 Ajustar filas y encabezados automáticamente después de cargar los datos
            DATACORTECAJA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DATACORTECAJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            DATACORTECAJA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Catch ex As Exception
            MsgBox("Error al cargar los datos: " & ex.Message, MsgBoxStyle.Critical, "Error de conexión")
        End Try
    End Sub

    Private Sub CMBUSUARIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBUSUARIO.SelectedIndexChanged
        CargarCorteCaja(DATACORTECAJA, CMBUSUARIO)
    End Sub

    Private Sub BTNABRIRCAJA_Click(sender As Object, e As EventArgs) Handles BTNABRIRCAJA.Click
        Dim AbrirCaja As New Form()
        AbrirCaja.Text = "Apertura de caja"
        AbrirCaja.Size = New Size(500, 300)
        AbrirCaja.StartPosition = FormStartPosition.CenterScreen
        AbrirCaja.BackColor = ColorFormulario
        AbrirCaja.FormBorderStyle = FormBorderStyle.FixedToolWindow

        Dim Etiqueta As New Label()
        Etiqueta.Text = "Dinero en caja"
        Etiqueta.Location = New Point(20, 20)
        Etiqueta.AutoSize = True
        Etiqueta.Font = New Font("Dubai", 14, FontStyle.Bold)
        Etiqueta.BackColor = ColorFormulario

        Dim TXTDINERO As New TextBox()
        TXTDINERO.Location = New Point(150, 20)
        TXTDINERO.Size = New Size(50, 30)
        TXTDINERO.Font = New Font("Dubai", 12)


        Dim BTNGUARDAR As New Button()
        BTNGUARDAR.Text = "Aceptar"
        BTNGUARDAR.Location = New Point(20, 100)
        BTNGUARDAR.AutoSize = True
        BTNGUARDAR.Font = New Font("Dubai", 12, FontStyle.Bold)
        BTNGUARDAR.BackColor = ColorBotones
        AddHandler BTNGUARDAR.Click, Sub(s, ea)
                                         MsgBox("Caja abierta con éxito", MsgBoxStyle.Information, "Éxito")
                                     End Sub



        AbrirCaja.Controls.Add(Etiqueta)
        AbrirCaja.Controls.Add(TXTDINERO)
        AbrirCaja.Controls.Add(BTNGUARDAR)
        AbrirCaja.ShowDialog()
    End Sub
End Class