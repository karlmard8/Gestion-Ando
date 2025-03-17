Imports System.ComponentModel
Imports System.Security.Cryptography

Public Class FrmAltaVentas
    Private Sub FrmAltaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONEXION PARA VISTAPRODUCTOS
        Me.VISTAPRODUCTOSTableAdapter.Connection = Conexion
        Me.VISTAPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.VISTAPRODUCTOS)
        'CONEXION PARA VISTACLIENTES
        Me.VISTACLIENTESTableAdapter.Connection = Conexion
        Me.VISTACLIENTESTableAdapter.Fill(Me.MuebleAlexDataSet.VISTACLIENTES)

        Me.BackColor = ColorFormulario
        GRUPO1.BackColor = ColorFormulario
        GRUPO2.BackColor = ColorFormulario
        BtnAgregar.BackColor = ColorBotones
        BtnQuitar.BackColor = ColorBotones
        BTNPAGAR.BackColor = ColorBotones
        LBLUSUARIOACTUAL.Text = USUARIOACTUAL
        CmbClientes.SelectedValue = 0
        CmbClave.SelectedValue = -1
        CmbClave.Enabled = False
        CMBPRODUCTO.SelectedValue = -1
        CMBPRECIO.SelectedValue = 0
        TXTMESES.Enabled = False
        TXTPAGO.Enabled = False
        TXTENGANCHE.Enabled = False
        RBCONTADO.Checked = False
        RBCREDITO.Checked = False
        CMBPRECIO.FormatString = "C2"
    End Sub
    Private Sub FrmAltaVentas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Text = "Procesando..."
            End If
        Next
        LBLSUB.Text = "Procesando..."
        LBLIVA.Text = "Procesando..."
        LBLTOTAL.Text = "Procesando..."
        CmbClientes.Focus()
        TXTPAGO.Text = String.Empty
        DtgProductos.Rows.Clear()

    End Sub

    Private Sub CMBPRECIO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPRECIO.SelectedIndexChanged
        Me.LblSubTotal.Text = Val(TxtCantidad.Text) * Val(CMBPRECIO.Text)
        TxtCantidad.Text = String.Empty

    End Sub

    Private Sub TxtCantidad_GotFocus(sender As Object, e As EventArgs) Handles TxtCantidad.GotFocus
        CMBPRECIO.FormatString = ""
    End Sub

    Private Sub TxtCantidad_TextChanged(sender As Object, e As EventArgs) Handles TxtCantidad.TextChanged
        Dim SUBTOTAL = Val(TxtCantidad.Text) * Val(CMBPRECIO.Text)
        Me.LblSubTotal.Text = SUBTOTAL.ToString("C2")
    End Sub

    Private Sub CMBPRODUCTO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBPRODUCTO.SelectedIndexChanged
        TxtCantidad.Enabled = False
        If CMBPRODUCTO.SelectedIndex >= 0 Then
            TxtCantidad.Enabled = True
        End If
    End Sub



    Private Sub RBCREDITO_CheckedChanged(sender As Object, e As EventArgs) Handles RBCREDITO.CheckedChanged
        TXTMESES.Enabled = True
        TXTENGANCHE.Enabled = True
        TXTMESES.Focus()
        TXTPAGO.Enabled = False
        TXTPAGO.Text = String.Empty
        TXTCAMBIO.Text = "N/A"
    End Sub

    Private Sub RBCONTADO_CheckedChanged(sender As Object, e As EventArgs) Handles RBCONTADO.CheckedChanged
        TXTCAMBIO.Text = "Procesando..."
        TXTPAGO.Enabled = True
        TXTPAGO.Focus()
        TXTMESES.Enabled = False
        TXTENGANCHE.Enabled = False
    End Sub

    Private Sub BTNPAGAR_Click(sender As Object, e As EventArgs) Handles BTNPAGAR.Click
        If Me.CmbClientes.SelectedValue > 0 Then
            If (Me.DtgProductos.RowCount > 0) Then
                If RBCONTADO.Checked = True Then
                    If Val(Me.TXTPAGO.Text) >= Val(Me.LBLTOTAL.Text) Then
                        StrSql = "ALTAVENTA"
                        comando = New SqlClient.SqlCommand(StrSql, Conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.Add("@VENFECHA", SqlDbType.Date).Value = FECHA
                        comando.Parameters.Add("@VENTOTAL", SqlDbType.Money).Value = Me.LBLTOTAL.Text
                        comando.Parameters.Add("@VENFORMA", SqlDbType.VarChar, 10).Value = "Contado"
                        comando.Parameters.Add("@VENMESES", SqlDbType.Int).Value = 0
                        If TXTENGANCHE.Text = String.Empty Then
                            comando.Parameters.Add("@VENENGANCHE", SqlDbType.Money).Value = 0
                        End If
                        comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = IDUSUARIOACTUAL
                        comando.Parameters.Add("@CLIID", SqlDbType.BigInt).Value = Me.CmbClientes.SelectedValue
                        comando.Parameters.Add("@RETORNO", SqlDbType.BigInt).Direction = ParameterDirection.Output
                        If Conectar() = True Then
                            Dim VENID As Long = comando.Parameters("@RETORNO").Value
                            For REC = 0 To Me.DtgProductos.RowCount - 1
                                StrSql = "ALTADETVENTA"
                                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                                comando.CommandType = CommandType.StoredProcedure
                                comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = VENID
                                comando.Parameters.Add("@PROID", SqlDbType.BigInt).Value = Me.DtgProductos.Rows(REC).Cells("PROID").Value
                                comando.Parameters.Add("@DETCANTIDAD", SqlDbType.Int).Value = Me.DtgProductos.Rows(REC).Cells("PROCANTIDAD").Value
                                comando.Parameters.Add("DETPRECIO", SqlDbType.Money).Value = Me.DtgProductos.Rows(REC).Cells("PROPRECIO").Value
                                comando.Parameters.Add("DETSUBTOTAL", SqlDbType.Money).Value = Me.DtgProductos.Rows(REC).Cells("PROSUBTOTAL").Value
                                Conectar()
                            Next
                            MsgBox("Venta exitosa", MsgBoxStyle.Information, "Confirmación")
                            DialogResult = DialogResult.OK
                            Me.Close()
                        End If
                    Else
                        MsgBox("Dinero faltante", MsgBoxStyle.Critical, "error")
                    End If
                Else
                    If Val(Me.TXTMESES.Text) > 0 Then
                        StrSql = "ALTAVENTA"
                        comando = New SqlClient.SqlCommand(StrSql, Conexion)
                        comando.CommandType = CommandType.StoredProcedure
                        comando.Parameters.Add("@VENFECHA", SqlDbType.Date).Value = FECHA
                        comando.Parameters.Add("@VENTOTAL", SqlDbType.Money).Value = Me.LBLTOTAL.Text
                        comando.Parameters.Add("@VENFORMA", SqlDbType.VarChar, 10).Value = "Crédito"
                        comando.Parameters.Add("@VENMESES", SqlDbType.Int).Value = Me.TXTMESES.Text
                        comando.Parameters.Add("@VENENGANCHE", SqlDbType.Money).Value = Me.TXTENGANCHE.Text
                        comando.Parameters.Add("@USUID", SqlDbType.BigInt).Value = IDUSUARIOACTUAL
                        comando.Parameters.Add("@CLIID", SqlDbType.BigInt).Value = Me.CmbClientes.SelectedValue
                        comando.Parameters.Add("@RETORNO", SqlDbType.BigInt).Direction = ParameterDirection.Output
                        If Conectar() = True Then
                            Dim VENID As Long
                            VENID = comando.Parameters("@RETORNO").Value
                            For REC = 0 To Me.DtgProductos.RowCount - 1
                                StrSql = "ALTADETVENTA"
                                comando = New SqlClient.SqlCommand(StrSql, Conexion)
                                comando.CommandType = CommandType.StoredProcedure
                                comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = VENID
                                comando.Parameters.Add("@PROID", SqlDbType.BigInt).Value = Me.DtgProductos.Rows(REC).Cells("PROID").Value
                                comando.Parameters.Add("@DETCANTIDAD", SqlDbType.Int).Value = Me.DtgProductos.Rows(REC).Cells("PROCANTIDAD").Value
                                comando.Parameters.Add("DETPRECIO", SqlDbType.Money).Value = Me.DtgProductos.Rows(REC).Cells("PROPRECIO").Value
                                comando.Parameters.Add("DETSUBTOTAL", SqlDbType.Money).Value = Me.DtgProductos.Rows(REC).Cells("PROSUBTOTAL").Value
                                Conectar()
                            Next
                            DialogResult = DialogResult.OK
                            MsgBox("Venta exitosa", MsgBoxStyle.Information, "Confirmación")
                            Me.Close()
                        End If
                    Else
                        MsgBox("Ingresa los meses a pagar", MsgBoxStyle.Critical, "error")
                    End If
                End If
            Else
                MsgBox("Ingresa un producto", MsgBoxStyle.Critical, "error")
                Me.CMBPRODUCTO.Focus()
            End If
        Else
            MsgBox("Ingresa un cliente para continuar", MsgBoxStyle.Critical, "error")
            Me.CmbClientes.Focus()
        End If

    End Sub

    Private Sub TxtPago_TextChanged(sender As Object, e As EventArgs) Handles TXTPAGO.TextChanged
        If Val(Me.TXTPAGO.Text) < Val(Me.LBLTOTAL.Text) Then
            Me.TXTCAMBIO.Text = 0.ToString("C2")
        Else
            Me.TXTCAMBIO.Text = (Val(Me.TXTPAGO.Text) - Val(Me.LBLTOTAL.Text)).ToString("C2")
        End If
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If CMBPRODUCTO.Text = String.Empty Then
            CMBPRODUCTO.Focus()
        ElseIf TxtCantidad.Text = String.Empty Then
            TxtCantidad.Focus()
        Else
            Dim SUBT As Integer = (Me.LblSubTotal.Text).ToString
            Me.DtgProductos.Rows.Add(Me.CmbClave.SelectedValue, Me.CmbClave.Text, Me.CMBPRODUCTO.Text, Me.TxtCantidad.Text, Me.CMBPRECIO.Text, SUBT)
            Dim SUBTOT As Integer = (Val(Me.LBLSUB.Text) + SUBT).ToString("F2")
            Me.LBLSUB.Text = SUBTOT
            Me.CmbClave.SelectedValue = 0
            Me.CMBPRECIO.SelectedValue = 0
            Me.CMBPRODUCTO.SelectedValue = 0
            Dim IVA = 0.16
            Dim IVAAPLI = IVA * SUBTOT
            LBLIVA.Text = IVAAPLI.ToString("C2")
            LBLTOTAL.Text = Val(LBLSUB.Text)
            CMBPRODUCTO.Focus()
            LblSubTotal.Text = "Procesando..."
            CMBPRECIO.FormatString = "C2"
            CMBPRECIO.Text = String.Empty
        End If
    End Sub

    Private Sub BtnQuitar_Click(sender As Object, e As EventArgs) Handles BtnQuitar.Click
        LBLSUB.Text = Val(LBLSUB.Text) - Val(DtgProductos.CurrentRow.Cells("PROSUBTOTAL").Value)
        LBLTOTAL.Text = Val(LBLTOTAL.Text) + Val(LBLIVA.Text)
        LBLIVA.Text = Val(LBLIVA.Text)
        Dim SUBTOTAL As Double = Val(LBLSUB.Text)
        LBLIVA.Text = IVA(SUBTOTAL).ToString("F2")
        Me.LBLTOTAL.Text = Val(Me.LBLSUB.Text) + Val(Me.LBLIVA.Text)
        DtgProductos.Rows.Remove(DtgProductos.CurrentRow)
    End Sub

    Private Function IVA(SUBTOTAL As Double) As Double
        Dim RESULTADO As Double
        RESULTADO = SUBTOTAL * 0.16
        Return RESULTADO
    End Function

    Private Sub TXTENGANCHE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTENGANCHE.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub TxtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCantidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub

    Private Sub TXTPAGO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPAGO.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Si no es un número ni una tecla de control, cancela el evento KeyPress
            e.Handled = True
        End If
    End Sub
End Class