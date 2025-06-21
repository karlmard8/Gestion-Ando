Imports System.ComponentModel
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports Gestion_Ando.FrmPrincipal
Imports Google
Imports Microsoft.Extensions.Logging

Public Class FrmCorteDeCaja

    Private usuarioIDSeleccionado As Integer
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
            BTNREPORTECAJA.Visible = False
            BTNHISTORIALCAJA.Visible = False
        Else
            CMBUSUARIO.SelectedIndex = -1
        End If

    End Sub

    Dim corteIDVariable As Integer
    Public Sub CargarCorteCaja(ByVal DATACORTECAJA As DataGridView, ByVal usuarioID As Integer)
        Try
            If usuarioID = 0 Then Exit Sub 'Si el usuario no es válido, salir
            Dim query As String = "SELECT TOP 1 CORTEID FROM TBLCORTECAJA WHERE CAJAABIERTA = 1 AND USUID = @USUID ORDER BY FECHAINICIALCORTE DESC"

            Dim comando As New SqlClient.SqlCommand(query, Conexion)
            comando.Parameters.AddWithValue("@USUID", usuarioID)

            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
            End If

            Dim resultadoCorteID As Object = comando.ExecuteScalar()

            Conexion.Close()

            If resultadoCorteID IsNot DBNull.Value Then
                corteIDVariable = Convert.ToInt32(resultadoCorteID)
            Else
                corteIDVariable = -1 
                MsgBox("No hay corte de caja abierto para este usuario.", MsgBoxStyle.Exclamation, "Advertencia")
            End If

            Dim queryVentas As String = "SELECT  
                                        V.VENID AS 'No.Venta',
                                        V.VENFECHA AS Fecha,
                                        V.VENFORMA AS Venta,
                                        CASE WHEN V.VENFORMA = 'CONTADO' THEN 'N/A' ELSE CAST(V.VENMESES AS VARCHAR) END AS Pagos,  
                                        CASE WHEN V.VENFORMA = 'CONTADO' THEN 'N/A' ELSE CAST(VENENGANCHE AS VARCHAR) END AS Enganche,  
                                        V.VENTOTAL AS Total,V.VENGANANCIA AS Ganancia,
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
            DATACORTECAJA.Columns("Ganancia").DefaultCellStyle.Format = "C2"

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
        If TIPO = "Administrador" Then
            ETIQUETAS.Show()
        End If
        CAJABOTONES.Show()
        DATACORTECAJA.Size = New Size(811, 800)

        If CMBUSUARIO.SelectedValue IsNot Nothing AndAlso IsNumeric(CMBUSUARIO.SelectedValue) Then
            usuarioIDSeleccionado = Convert.ToInt32(CMBUSUARIO.SelectedValue)
            CargarCorteCaja(DATACORTECAJA, usuarioIDSeleccionado)

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

            'Calcular ingresos y egresos desde `DATACORTECAJA`
            Dim INGRESOS As Decimal = 0
            Dim EGRESOS As Decimal = 0

            Dim totalGanancias As Decimal = 0 ' Variable para acumular la suma de la columna "Ganancia"

            For Each row As DataGridViewRow In Me.DATACORTECAJA.Rows
                If Not row.IsNewRow AndAlso Not IsDBNull(row.Cells("Venta").Value) Then
                    Dim tipoVenta As String = row.Cells("Venta").Value.ToString()

                    Dim enganche As Decimal
                    Dim total As Decimal
                    Dim ganancia As Decimal

                    ' Intentar obtener valores de las celdas con seguridad
                    If Decimal.TryParse(row.Cells("Enganche").Value.ToString(), enganche) AndAlso tipoVenta = "Crédito" Then
                        INGRESOS += enganche
                    ElseIf Decimal.TryParse(row.Cells("Total").Value.ToString(), total) Then
                        If total < 0 Then
                            EGRESOS += Math.Abs(total)
                        Else
                            INGRESOS += total
                        End If
                    End If

                    If Decimal.TryParse(row.Cells("Ganancia").Value.ToString(), ganancia) Then
                        totalGanancias += ganancia
                    End If
                End If
            Next

            LBLGANANCIAS.Text = totalGanancias.ToString("C")

            LBLINGRESOS.Text = INGRESOS.ToString("C2")
            LBLEGRESOS.Text = EGRESOS.ToString("C2")

            Dim saldoFinal As Decimal = saldoInicial + INGRESOS - EGRESOS
            LBLSALDOFINAL.Text = saldoFinal.ToString("C2")
        End If
    End Sub

    Private Sub FrmCorteDeCaja_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        usuarioIDSeleccionado = If(CMBUSUARIO.SelectedValue IsNot Nothing, Convert.ToInt32(CMBUSUARIO.SelectedValue), 0)
    End Sub

    Private Sub BTNABRIRCAJA_Click(sender As Object, e As EventArgs) Handles BTNABRIRCAJA.Click
        If CMBUSUARIO.SelectedIndex < 0 Then
            MsgBox("Selecciona un usuario para abrir caja", MsgBoxStyle.Exclamation, "Advertencia")
            CMBUSUARIO.Focus()
            Return
        End If

        If corteIDVariable > 0 Then
            MsgBox("Ya hay una caja abierta para este usuario", MsgBoxStyle.Exclamation, "Advertencia")
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
        Etiqueta.Text = "Monto de caja inicial"
        Etiqueta.Location = New Point(105, 20)
        Etiqueta.AutoSize = True
        Etiqueta.Font = New Font("Dubai", 14, FontStyle.Bold)
        Etiqueta.BackColor = ColorFormulario

        Dim TXTDINERO As New TextBox()
        TXTDINERO.Location = New Point(115, 60)
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
        BTNGUARDAR.Location = New Point(140, 125)
        BTNGUARDAR.Size = New Size(100, 40)
        BTNGUARDAR.Font = New Font("Dubai", 14, FontStyle.Bold)
        BTNGUARDAR.BackColor = ColorBotones
        AddHandler BTNGUARDAR.Click, Sub(s, ea)
                                         If CMBUSUARIO.SelectedIndex <= -1 Then
                                             MsgBox("Seleccione un usuario para abrir caja", MsgBoxStyle.Exclamation, "Advertencia")
                                             Return

                                         Else
                                             If String.IsNullOrWhiteSpace(TXTDINERO.Text) Then
                                                 MsgBox("Ingrese el dinero en caja", MsgBoxStyle.Exclamation, "Advertencia")
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
                                                             CMBUSUARIO_SelectedIndexChanged(s, ea)
                                                         Else
                                                             MsgBox("Error de conexión", MsgBoxStyle.Critical, "Error")
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
                                              e2.SuppressKeyPress = True
                                              BTNGUARDAR.Focus()
                                          End If
                                      End Sub

        AbrirCaja.Controls.Add(Etiqueta)
        AbrirCaja.Controls.Add(TXTDINERO)
        AbrirCaja.Controls.Add(BTNGUARDAR)
        AbrirCaja.ShowDialog()
    End Sub


    Private Sub BTNCERRARCAJA_Click(sender As Object, e As EventArgs) Handles BTNCERRARCAJA.Click
        Try
            If CMBUSUARIO.SelectedIndex <= -1 Then
                MsgBox("Seleccione un usuario para cerrar caja", MsgBoxStyle.Exclamation, "Advertencia")
                CMBUSUARIO.Focus()
                Return
            End If

            Dim SALDOINICIAL As Decimal = Convert.ToDecimal(LBLSALDOINICIAL.Text.Replace("$", "").Replace(",", ""))
            If SALDOINICIAL = 0 Then
                MsgBox("No hay caja abierta para este usuario", MsgBoxStyle.Exclamation, "Advertencia")
                BTNABRIRCAJA.Focus()
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
            If String.IsNullOrEmpty(TXTSALDOREAL.Text) Then
                comando.Parameters.Add("@SALDOREAL", SqlDbType.Money).Value = 0
            Else
                comando.Parameters.Add("@SALDOREAL", SqlDbType.Money).Value = TXTSALDOREAL.Text
            End If
            comando.Parameters.Add("@SALDOFINAL", SqlDbType.Money).Value = Convert.ToDecimal(LBLSALDOFINAL.Text.Replace("$", "").Replace(",", ""))

            If String.IsNullOrWhiteSpace(TXTNOTAS.Text) Then
                comando.Parameters.Add("@NOTAS", SqlDbType.VarChar, 255).Value = ""
            Else
                comando.Parameters.Add("@NOTAS", SqlDbType.NVarChar).Value = TXTNOTAS.Text
            End If
            comando.Parameters.Add("@FECHAFINALCORTE", SqlDbType.DateTime).Value = fechaParametro
            comando.Parameters.Add("@CORTEGANANCIA", SqlDbType.Money).Value = LBLGANANCIAS.Text.Replace("$", "").Replace(",", "")

            comando.Parameters.Add("@RETORNO", SqlDbType.Bit).Direction = ParameterDirection.Output
            If Conectar() = True Then
                If comando.Parameters("@RETORNO").Value = "TRUE" Then
                    MsgBox("Caja cerrada correctamente", MsgBoxStyle.Information, "Confirmación")
                    CMBUSUARIO_SelectedIndexChanged(sender, e)
                Else
                    MsgBox("Error al cerrar la caja", MsgBoxStyle.Critical, "Error C1")
                End If
            End If
        Catch
            MsgBox("Error al cerrar la caja", MsgBoxStyle.Critical, "Error C2")
        End Try
    End Sub

    Public fechaParametro As DateTime
    Private Sub ActualizarFecha(sender As Object, e As EventArgs)
        fechaParametro = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
    End Sub

    Private Sub TXTSALDOREAL_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTSALDOREAL.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub BTNHISTORIALCAJA_Click(sender As Object, e As EventArgs) Handles BTNHISTORIALCAJA.Click
        ETIQUETAS.Hide()
        CAJABOTONES.Hide()
        CMBUSUARIO.SelectedIndex = -1
        DATACORTECAJA.DataSource = Nothing
        DATACORTECAJA.Size = New Size(1870, 800)

        StrSql = "SELECT * FROM VISTACORTECAJA WHERE CIERRE BETWEEN DATEADD(MONTH, -2, GETDATE()) AND GETDATE()"
        Dim comando As New SqlClient.SqlCommand(StrSql, Conexion)
        Dim adapter As New SqlClient.SqlDataAdapter(comando)
        Dim table As New DataTable()
        adapter.Fill(table)
        DATACORTECAJA.DataSource = table
        DATACORTECAJA.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DATACORTECAJA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        DATACORTECAJA.Columns("DINERO EN CAJA").DefaultCellStyle.Format = "C2"
        DATACORTECAJA.Columns("INGRESOS").DefaultCellStyle.Format = "C2"
        DATACORTECAJA.Columns("EGRESOS").DefaultCellStyle.Format = "C2"
        DATACORTECAJA.Columns("TOTAL DE CAJA").DefaultCellStyle.Format = "C2"
        DATACORTECAJA.Columns("DINERO REPORTADO").DefaultCellStyle.Format = "C2"
        DATACORTECAJA.Columns("NOTAS").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        DATACORTECAJA.Columns("NOTAS").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DATACORTECAJA.Columns("Ganancias del día").DefaultCellStyle.Format = "C2"
    End Sub

    Private Sub BTNREPORTECAJA_Click(sender As Object, e As EventArgs) Handles BTNREPORTECAJA.Click
        Dim rutaReporte As String
        Dim rutaBase As String = Application.StartupPath

        rutaReporte = System.IO.Path.Combine(rutaBase, "RPTCORTECAJA.rpt")


        ' Validar existencia del archivo de reporte
        If Not System.IO.File.Exists(rutaReporte) Then
            MessageBox.Show("No se encontró el archivo de reporte en la ruta especificada: " & rutaReporte, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Cargar el reporte
        Dim MANIFIESTO As New ReportDocument()
        MANIFIESTO.Load(rutaReporte)

        ' Configurar conexión a la base de datos
        Dim crConnInfo As New ConnectionInfo()
        With crConnInfo
            .ServerName = SERVIDOR
            .DatabaseName = BASEDATOS
            .UserID = USUARIO
            .Password = CONTRASEÑA
        End With

        ' Aplicar conexión a cada tabla del reporte
        Dim crDatabase As Database = MANIFIESTO.Database
        Dim crTables As Tables = crDatabase.Tables
        For Each crTable As Table In crTables
            Dim crLogOnInfo As TableLogOnInfo = crTable.LogOnInfo
            crLogOnInfo.ConnectionInfo = crConnInfo
            crTable.ApplyLogOnInfo(crLogOnInfo)
            MANIFIESTO.VerifyDatabase()
            MANIFIESTO.Refresh()
            ' Ajustar la ubicación de la tabla para evitar solicitud de credenciales
            crTable.Location = crConnInfo.DatabaseName & ".dbo." & crTable.Name
        Next

        ' Verificar y refrescar la base de datos
        MANIFIESTO.VerifyDatabase()
        MANIFIESTO.Refresh()

        ' Mostrar el reporte
        Dim MUESTRA As New FrmReportes()
        MUESTRA.Reportes.ReportSource = MANIFIESTO
        MUESTRA.Reportes.Refresh()
        MUESTRA.ShowDialog()
    End Sub
End Class