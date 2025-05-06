Imports System.Data.SqlClient

Public Class FrmCorteDeCaja
    Private Sub FrmCorteDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTACORTECAJA' Puede moverla o quitarla según sea necesario.
        'Me.VISTACORTECAJATableAdapter.Connection = Conexion
        'Me.VISTACORTECAJATableAdapter.Fill(Me.MuebleAlexDataSet.VISTACORTECAJA)


        EstiloBotones.CambiarColorBotones(Me)
        Me.BackColor = ColorFormulario
        DATACORTECAJA.BackgroundColor = ColorFormulario
        DATACORTECAJA.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATACORTECAJA.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)

        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.VISTAUSUARIOS' Puede moverla o quitarla según sea necesario.
        Me.VISTAUSUARIOSTableAdapter.Connection = Conexion
        Me.VISTAUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAUSUARIOS)

        CargarCorteCaja(DATACORTECAJA, CMBUSUARIO)
    End Sub

    Public Sub CargarCorteCaja(ByVal DATACORTECAJA As DataGridView, ByVal cmbUsuario As ComboBox)
        Try
            ' Obtener el valor seleccionado en el ComboBox
            Dim USUID As Integer = Convert.ToInt32(cmbUsuario.SelectedValue)

            ' Definir la consulta con parámetro @USUID
            Dim query As String = "SELECT VENID AS 'No.Venta', VENFECHA AS Fecha, VENFORMA AS Venta, USUNOMBRE AS Vendedor, VENTOTAL AS Total  
                               FROM TBLVENTAS  
                               JOIN TBLUSUARIOS ON TBLVENTAS.USUID = TBLUSUARIOS.USUID  
                               WHERE VENEXISTE = 1 AND TBLUSUARIOS.USUID = @USUID"

            ' Crear el comando SQL
            Dim comando As New SqlClient.SqlCommand(query, Conexion)
            comando.Parameters.AddWithValue("@USUID", USUID) ' Asignar parámetro desde ComboBox

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
End Class