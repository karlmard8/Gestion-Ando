﻿Imports System.ComponentModel

Public Class FrmDetallesVentas
    Private Sub FrmDetallesVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorFormulario
        DATADETALLEVENTA.BackgroundColor = ColorFormulario
        DATADETALLEVENTA.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATADETALLEVENTA.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)
        Me.KeyPreview = True
        DATAPAGOS.BackgroundColor = ColorFormulario
        DATAPAGOS.DefaultCellStyle.Font = New Font("Dubai", 12)
        DATAPAGOS.ColumnHeadersDefaultCellStyle.Font = New Font("Dubai", 12)

        EstiloBotones.CambiarColorBotones(Me)
        If FrmVentas.contado = "True" Then
            BTNABONO.Visible = False
            Me.Size = New Size(920, 336)
        Else
            BTNABONO.Visible = True
            Me.Size = New Size(920, 710)
        End If
    End Sub
    Public Sub FrmDetallesVentas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub BTNABONO_Click(sender As Object, e As EventArgs) Handles BTNABONO.Click
        If idbusqueda = 0 Then
            StrSql = "PAGOCREDITO"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = DATAPAGOS.CurrentRow.Cells("VENID").Value
            comando.Parameters.Add("@PAGID", SqlDbType.BigInt).Value = DATAPAGOS.CurrentRow.Cells("PAGID").Value
            comando.Parameters.Add("@RETORNO", SqlDbType.Bit).Direction = ParameterDirection.Output

            If Conectar() = True Then
                If comando.Parameters("@RETORNO").Value = "1" Then
                    MsgBox("Pago realizado", MsgBoxStyle.Information, "Confirmación")

                End If
            End If
        End If
        Try
            Using Conexion As New SqlClient.SqlConnection("server=" & SERVIDOR & "; database=" & BASEDATOS & "; uid=" & USUARIO & "; pwd=" & CONTRASEÑA & ";")
                Conexion.Open()

                Dim comando As New SqlClient.SqlCommand("DETALLESDEPAGOS", Conexion)
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Add("@VENID", SqlDbType.BigInt).Value = DATAPAGOS.CurrentRow.Cells("VENID").Value

                Dim adaptador As New SqlClient.SqlDataAdapter(comando)
                Dim tabla As New DataTable()
                adaptador.Fill(tabla)

                ' Asignar los datos actualizados al DataGridView
                DATAPAGOS.DataSource = tabla
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al actualizar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        FrmVentas.CargarDatos()
    End Sub

End Class