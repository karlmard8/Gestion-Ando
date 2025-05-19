Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Gestion_Ando.FrmPrincipal
Imports Google
Imports Microsoft.Extensions.Logging

Public Class FrmCorteDeCaja

    Private usuarioIDSeleccionado As Integer 'Guardar el ID antes de cerrar
    Private Sub FrmCorteDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstiloBotones.CambiarColorBotones(Me)
        Me.BackColor = ColorFormulario
        DATACORTECAJA.BackgroundColor = ColorFormulario
        DATACORTECAJA.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATACORTECAJA.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)

        ' Cargar datos en el ComboBox
        Me.VISTAUSUARIOSTableAdapter.Connection = Conexion
        Me.VISTAUSUARIOSTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAUSUARIOS)

        AddHandler FrmPrincipal.Timer1.Tick, AddressOf ActualizarFecha
        FrmPrincipal.Timer1.Interval = 1000
        FrmPrincipal.Timer1.Start()

        If TIPO = "Operativo" Then
            CMBUSUARIO.Text = USUARIOACTUAL
            CMBUSUARIO.Enabled = False
            ETIQUETAS.Visible = False
        Else
            CMBUSUARIO.SelectedIndex = -1
        End If
    End Sub

    Dim corteIDVariable As Integer
    Public Sub CargarCorteCaja(ByVal DATACORTECAJA As DataGridView, ByVal usuarioID As Integer)
        Try
            If usuarioID = 0 Then Exit Sub 'Si el usuario no es válido, salir

            'Consulta SQL para extraer el CorteID
            Dim query As String = "SELECT TOP 1 CORTEID FROM TBLCORTECAJA WHERE CAJAABIERTA = 1 AND USUID = @USUID ORDER BY FECHAINICIALCORTE DESC"

            ' Crear el comando SQL
            Dim comando As New SqlClient.SqlCommand(query, Conexion)
            comando.Parameters.AddWithValue("@USUID", usuarioID)

            'Abre la conexión si está cerrada
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
            End If

            'Extraer el CorteID
            Dim resultadoCorteID As Object = comando.ExecuteScalar()

            'Cierra la conexión después de usarla
            Conexion.Close()

            If resultadoCorteID IsNot DBNull.Value Then
                corteIDVariable = Convert.ToInt32(resultadoCorteID)
            Else
                corteIDVariable = -1 'Si no hay caja abierta, asignar un valor por defecto
                MsgBox("No hay corte de caja abierto para este usuario.", MsgBoxStyle.Exclamation, "Advertencia")
            End If

            ' Adaptador de datos y tabla para el DataGridView
            Dim queryVentas As String = "SELECT  
                                        V.VENID AS 'No.Venta',
                                        V.VENFECHA AS Fecha,
                                        V.VENFORMA AS Venta,
                                        CASE WHEN V.VENFORMA = 'CONTADO' THEN 'N/A' ELSE CAST(V.VENMESES AS VARCHAR) END AS Pagos,  
                                        CASE WHEN V.VENFORMA = 'CONTADO' THEN 'N/A' ELSE CAST(VENENGANCHE AS VARCHAR) END AS Enganche,  
                                        V.VENTOTAL AS Total,
                                        (SELECT TOP 1 CORTEID FROM TBLCORTECAJA WHERE CAJAABIERTA = 1 AND USUID = @USUID ORDER BY FECHAINICIALCORTE DESC) AS CorteID  
                                    FROM TBLVENTAS AS V
                                    WHERE V.VENFECHA BETWEEN  
                                        (SELECT MIN(FECHAINICIALCORTE) FROM TBLCORTECAJA WHERE CAJAABIERTA = 1 AND USUID = @USUID)  
                                        AND GETDATE()
                                    AND EXISTS (  
                                        SELECT 1 FROM TBLCORTECAJA WHERE CAJAABIERTA = 1 AND USUID = @USUID  
                                    )
                                    AND V.USUID = @USUID
                                    ORDER BY V.VENID DESC;"

            Dim comandoVentas As New SqlClient.SqlCommand(queryVentas, Conexion)
            comandoVentas.Parameters.AddWithValue("@USUID", usuarioID)

            Dim adapter As New SqlClient.SqlDataAdapter(comandoVentas)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Asignar la tabla como origen de datos del DataGridView
            DATACORTECAJA.DataSource = table

            'Ajustes de presentación del DataGridView
            DATACORTECAJA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            DATACORTECAJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            DATACORTECAJA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DATACORTECAJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            DATACORTECAJA.Columns("No.Venta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            DATACORTECAJA.Columns("No.Venta").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            DATACORTECAJA.Columns("Venta").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            DATACORTECAJA.Columns("Pagos").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            DATACORTECAJA.Columns("Enganche").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            DATACORTECAJA.Columns("Fecha").AutoSizeMode = DataGridViewAutoSizeColumnsMode.AllCells
            DATACORTECAJA.Columns("Total").DefaultCellStyle.Format = "C2"
            DATACORTECAJA.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            DATACORTECAJA.Columns("Enganche").DefaultCellStyle.Format = "C2"
            DATACORTECAJA.Columns("CorteID").Visible = False

            If DATACORTECAJA.Rows.Count <= 0 Then
                DATACORTECAJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            End If

        Catch ex As SqlException
            MsgBox("Error en la consulta SQL: " & ex.Message, MsgBoxStyle.Critical, "Error de Base de Datos")
        Catch ex As Exception
            MsgBox("Error inesperado: " & ex.Message, MsgBoxStyle.Critical, "Error General")
        End Try
    End Sub

    Private Sub CMBUSUARIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBUSUARIO.SelectedIndexChanged
        If CMBUSUARIO.SelectedValue IsNot Nothing AndAlso IsNumeric(CMBUSUARIO.SelectedValue) Then
            usuarioIDSeleccionado = Convert.ToInt32(CMBUSUARIO.SelectedValue)
            CargarCorteCaja(DATACORTECAJA, usuarioIDSeleccionado)

            ' Consulta saldo inicial en la base de datos
            StrSql = "SALDOINICIALCAJA"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = usuarioIDSeleccionado
            comando.Parameters.Add("@SaldoInicial", SqlDbType.Money).Direction = ParameterDirection.Output

            Dim saldoInicial As Decimal = 0
            If Conectar() = True Then
                saldoInicial = If(IsDBNull(comando.Parameters("@SaldoInicial").Value), 0, Convert.ToDecimal(comando.Parameters("@SaldoInicial").Value))
                LBLSALDOINICIAL.Text = saldoInicial.ToString("C2") 'Formato moneda
            End If

            'Calcular ingresos desde `DATACORTECAJA`
            Dim INGRESOS As Decimal = 0
            For Each row As DataGridViewRow In Me.DATACORTECAJA.Rows
                If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("Venta").Value) Then
                    Dim tipoVenta As String = row.Cells("Venta").Value.ToString()

                    If tipoVenta = "Crédito" AndAlso Not IsDBNull(row.Cells("Enganche").Value) Then

                        INGRESOS += Convert.ToDecimal(row.Cells("Enganche").Value)
                    ElseIf Not IsDBNull(row.Cells("Total").Value) Then

                        INGRESOS += Convert.ToDecimal(row.Cells("Total").Value)
                    End If
                End If
            Next

            LBLINGRESOS.Text = INGRESOS.ToString("C2")

            'Asignar ingresos y egresos con formato correcto
            LBLINGRESOS.Text = INGRESOS.ToString("C2")
            LBLEGRESOS.Text = 0.ToString("C2")

            'Calcular saldo final correctamente sin errores de conversión
            Dim saldoFinal As Decimal = saldoInicial + INGRESOS
            LBLSALDOFINAL.Text = saldoFinal.ToString("C2")
        End If
    End Sub

    Private Sub FrmCorteDeCaja_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        usuarioIDSeleccionado = If(CMBUSUARIO.SelectedValue IsNot Nothing, Convert.ToInt32(CMBUSUARIO.SelectedValue), 0)
    End Sub

    Private Sub BTNABRIRCAJA_Click(sender As Object, e As EventArgs) Handles BTNABRIRCAJA.Click
        If DATACORTECAJA.Rows.Count > 0 OrElse LBLSALDOINICIAL.Text <> "$0.00" Then
            MsgBox("Ya hay una caja abierta para este usuario", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Dim AbrirCaja As New Form()
        AbrirCaja.Text = "Apertura de caja"
        AbrirCaja.Size = New Size(400, 250)
        AbrirCaja.StartPosition = FormStartPosition.CenterScreen
        AbrirCaja.BackColor = ColorFormulario
        AbrirCaja.FormBorderStyle = FormBorderStyle.FixedToolWindow
        AbrirCaja.ShowInTaskbar = False

        AbrirCaja.KeyPreview = True
        AddHandler AbrirCaja.KeyDown, Sub(s, e2)
                                          If e2.KeyCode = Keys.Escape Then
                                              AbrirCaja.Close()
                                          End If
                                      End Sub

        Dim Etiqueta As New Label()
        Etiqueta.Text = "Dinero en caja"
        Etiqueta.Location = New Point(20, 20)
        Etiqueta.AutoSize = True
        Etiqueta.Font = New Font("Dubai", 14, FontStyle.Bold)
        Etiqueta.BackColor = ColorFormulario

        Dim TXTDINERO As New TextBox()
        TXTDINERO.Location = New Point(180, 20)
        TXTDINERO.Size = New Size(150, 50)
        TXTDINERO.Font = New Font("Dubai", 12)
        TXTDINERO.MaxLength = 10

        AddHandler TXTDINERO.KeyPress, Sub(s, e2)
                                           If Not Char.IsDigit(e2.KeyChar) AndAlso e2.KeyChar <> ControlChars.Back Then
                                               e2.Handled = True
                                           End If
                                       End Sub

        Dim BTNGUARDAR As New Button()
        BTNGUARDAR.Cursor = Cursors.Hand
        BTNGUARDAR.Text = "Abrir caja"
        BTNGUARDAR.Location = New Point(140, 120)
        BTNGUARDAR.Size = New Size(100, 40)
        BTNGUARDAR.Font = New Font("Dubai", 14, FontStyle.Bold)
        BTNGUARDAR.BackColor = ColorBotones
        AddHandler BTNGUARDAR.Click, Sub(s, ea)
                                         If CMBUSUARIO.SelectedIndex <= -1 Then
                                             MsgBox("Seleccione un usuario para abrir caja", MsgBoxStyle.Critical, "Error")
                                             Return

                                         Else
                                             If String.IsNullOrWhiteSpace(TXTDINERO.Text) Then
                                                 MsgBox("Ingrese el dinero en caja", MsgBoxStyle.Critical, "Error")
                                                 TXTDINERO.Focus()
                                                 Return

                                             Else

                                                 Try
                                                     StrSql = "ALTACORTECAJA"
                                                     comando = New SqlClient.SqlCommand(StrSql, Conexion)
                                                     comando.CommandType = CommandType.StoredProcedure
                                                     comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = CMBUSUARIO.SelectedValue
                                                     comando.Parameters.Add("@SALDOINICIAL", SqlDbType.Money).Value = Convert.ToDecimal(TXTDINERO.Text)
                                                     comando.Parameters.Add("@FECHAINICIALCORTE", SqlDbType.DateTime).Value = fechaParametro
                                                     comando.Parameters.Add("@RETORNO", SqlDbType.Bit).Direction = ParameterDirection.Output
                                                     If Conectar() = True Then
                                                         If comando.Parameters("@RETORNO").Value = "TRUE" Then
                                                             MsgBox("Caja abierta correctamente", MsgBoxStyle.Information, "Éxito")
                                                             AbrirCaja.Close()
                                                             CMBUSUARIO.Focus()
                                                         Else
                                                             MsgBox("Error al abrir la caja", MsgBoxStyle.Critical, "Error")
                                                         End If
                                                     End If

                                                 Catch
                                                     MsgBox("Error al abrir la caja", MsgBoxStyle.Critical, "Error")
                                                 End Try

                                             End If
                                         End If
                                     End Sub

        AddHandler TXTDINERO.KeyDown, Sub(s, e2)
                                          If e2.KeyCode = Keys.Enter Then
                                              e2.SuppressKeyPress = True 'Evita el sonido de "ding"
                                              BTNGUARDAR.Focus() 'Mueve el foco al botón
                                          End If
                                      End Sub

        AbrirCaja.Controls.Add(Etiqueta)
        AbrirCaja.Controls.Add(TXTDINERO)
        AbrirCaja.Controls.Add(BTNGUARDAR)
        AbrirCaja.ShowDialog()
    End Sub


    Private Sub BTNCERRARCAJA_Click(sender As Object, e As EventArgs) Handles BTNCERRARCAJA.Click
        If CMBUSUARIO.SelectedIndex <= -1 Then
            MsgBox("Seleccione un usuario para cerrar caja", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Dim SALDOINICIAL As Decimal = Convert.ToDecimal(LBLSALDOINICIAL.Text.Replace("$", "").Replace(",", ""))
        If SALDOINICIAL = 0 Then
            MsgBox("No hay caja abierta para este usuario", MsgBoxStyle.Critical, "Error")
            Return
        End If

        Dim CONFIRMARACION As DialogResult = MsgBox("¿Está seguro de cerrar la caja?", MsgBoxStyle.YesNo, "Confirmación")
        If CONFIRMARACION = DialogResult.No Then
            Return
        End If

        StrSql = "CERRARCORTECAJA"
        comando = New SqlClient.SqlCommand(StrSql, Conexion)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add("@CorteID", SqlDbType.BigInt).Value = corteIDVariable
        comando.Parameters.Add("@SALDOINGRESADO", SqlDbType.Money).Value = Convert.ToDecimal(LBLINGRESOS.Text.Replace("$", "").Replace(",", ""))
        comando.Parameters.Add("@SALDOEGRESADO", SqlDbType.Money).Value = Convert.ToDecimal(LBLEGRESOS.Text.Replace("$", "").Replace(",", ""))
        comando.Parameters.Add("@SALDOFINAL", SqlDbType.Money).Value = Convert.ToDecimal(LBLSALDOFINAL.Text.Replace("$", "").Replace(",", ""))
        comando.Parameters.Add("@SALDOREAL", SqlDbType.Money).Value = TXTSALDOREAL.Text
        If String.IsNullOrWhiteSpace(TXTNOTAS.Text) Then
                comando.Parameters.Add("@NOTAS", SqlDbType.VarChar, 255).Value = ""
            Else
                comando.Parameters.Add("@NOTAS", SqlDbType.NVarChar).Value = TXTNOTAS.Text
            End If
        comando.Parameters.Add("@FECHAFINALCORTE", SqlDbType.DateTime).Value = fechaParametro
        comando.Parameters.Add("@RETORNO", SqlDbType.Bit).Direction = ParameterDirection.Output
        If Conectar() = True Then
            If comando.Parameters("@RETORNO").Value = "TRUE" Then
                MsgBox("Caja cerrada correctamente", MsgBoxStyle.Information, "Éxito")
                CargarCorteCaja(DATACORTECAJA, usuarioIDSeleccionado)
            Else
                MsgBox("Error al cerrar la caja", MsgBoxStyle.Critical, "Error")
            End If
        End If

    End Sub

    Public fechaParametro As DateTime

    Private Sub ActualizarFecha(sender As Object, e As EventArgs)
        fechaParametro = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
    End Sub

    Private Sub TXTSALDOREAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSALDOREAL.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True ' 🔥 Bloquear la entrada si no es un número
        End If
    End Sub
End Class