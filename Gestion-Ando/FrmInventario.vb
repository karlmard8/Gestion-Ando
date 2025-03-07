﻿Imports System.IO

Public Class FrmInventario
    Dim ALTAINVENTARIO As New FrmAltaProductos
    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTBUSCAR.Focus()
        'TODO: esta línea de código carga datos en la tabla 'MuebleAlexDataSet.TBLPRODUCTOS' Puede moverla o quitarla según sea necesario.
        Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
        Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
        ALTAINVENTARIO.TXTCLAVE.Focus()
        If TIPO = "Operativo" Then
            BTNEDITAR.Enabled = False
            BTNELIMINAR.Enabled = False
        End If
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        BANDERA = "NUEVO"
        ALTAINVENTARIO.LBLPRODUCTOS.Text = "Registro de producto"
        ALTAINVENTARIO.LBLPRODUCTOS.Location = New Point(160, 9)

        For Each control As Control In ALTAINVENTARIO.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Clear()
            ElseIf TypeOf control Is NumericUpDown Then
                DirectCast(control, NumericUpDown).Value = 0
            End If
        Next
        idbusqueda = 0
        If ALTAINVENTARIO.ShowDialog = DialogResult.OK Then
            Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
            Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
        End If

        TXTBUSCAR.Focus()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TXTBUSCAR.TextChanged
        Me.TBLPRODUCTOSBindingSource.Filter = "PRONOMBRE LIKE '*" & TXTBUSCAR.Text & "*'"
    End Sub

    Public Property rutaImagen As String
    Public Property BANDERA As String
    Private Sub BTNEDITAR_Click(sender As Object, e As EventArgs) Handles BTNEDITAR.Click
        ALTAINVENTARIO.LBLPRODUCTOS.Text = "Editar inforación de producto"
        ALTAINVENTARIO.LBLPRODUCTOS.Location = New Point(128, 9)

        If DATAINVENTARIO.RowCount > 0 Then
            idbusqueda = DATAINVENTARIO.CurrentRow.Cells("PROID").Value
            ALTAINVENTARIO.TXTCLAVE.Text = DATAINVENTARIO.CurrentRow.Cells("PROCLAVE").Value
            ALTAINVENTARIO.TXTNOMBRE.Text = DATAINVENTARIO.CurrentRow.Cells("PRONOMBRE").Value
            ALTAINVENTARIO.SPINNER.Value = DATAINVENTARIO.CurrentRow.Cells("PROEXISTENCIAS").Value
            ALTAINVENTARIO.TXTPRECIO.Text = Convert.ToInt32(DATAINVENTARIO.CurrentRow.Cells("PROPRECIO").Value).ToString()
            'ALTAINVENTARIO.PRODIMAGEN = CStr(DATAINVENTARIO.CurrentRow.Cells("PROIMAGEN").Value)

            'CODIGO PARA CARGAR LA IMAGEN DE UN REGISTRO EXISTENTE
            Try
                ' Obtener la ruta de la imagen desde la celda del DataGridView
                rutaImagen = CStr(DATAINVENTARIO.CurrentRow.Cells("PROIMAGEN").Value)

                ' Verificar que la ruta no esté vacía o nula
                If Not String.IsNullOrEmpty(rutaImagen) AndAlso File.Exists(rutaImagen) Then
                    ' Cargar la imagen desde la ruta
                    Dim imagen As Image = Image.FromFile(rutaImagen)

                    ' Asignar la imagen al PictureBox
                    ALTAINVENTARIO.PRODIMAGEN.Image = imagen
                    BANDERA = "EDITAR"

                End If
            Catch ex As Exception
                MessageBox.Show("Error al cargar la imagen: " & ex.Message)
            End Try

            If ALTAINVENTARIO.ShowDialog = DialogResult.OK Then
                Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
                Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
            End If
        End If
        TXTBUSCAR.Focus()
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        Dim CONFIRMAR = MsgBox("¿Eliminar producto?", MsgBoxStyle.YesNo, "Confirmación")
        If CONFIRMAR = MsgBoxResult.Yes Then
            StrSql = "ELIMINARPRODUCTOS"
            comando = New SqlClient.SqlCommand(StrSql, Conexion)
            comando.CommandType = CommandType.StoredProcedure
            comando.Parameters.Add("@PROID", SqlDbType.BigInt).Value = Me.DATAINVENTARIO.CurrentRow.Cells("PROID").Value

            If Conectar() = True Then
                Me.TBLPRODUCTOSTableAdapter.Connection = Conexion
                Me.TBLPRODUCTOSTableAdapter.Fill(Me.MuebleAlexDataSet.TBLPRODUCTOS)
                MsgBox("Producto eliminado", MsgBoxStyle.Information, "Conformación")
            End If
        End If
        TXTBUSCAR.Focus()
    End Sub
End Class