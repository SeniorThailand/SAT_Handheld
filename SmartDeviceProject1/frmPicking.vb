Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.SqlTypes
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class frmPicking
    Dim dt As DataTable
    Dim ds As New DataSet

    Private Sub txtSerialBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerialBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                'dt.Rows.Clear()

                Dim strBarcode As String = ""
                Dim arrCode As String()

                If txtItem.Text = "" Then
                    arrCode = Split(txtSerialBarcode.Text, ",")
                    If UBound(arrCode) = 2 Then
                        txtItem.Text = arrCode(0)
                        txtLot.Text = arrCode(1)

                    End If
                    txtFromLoc.Text = ""
                    txtSerialBarcode.Text = ""
                    txtSerialBarcode.Focus()
                    Exit Sub
                End If

                If txtFromLoc.Text = "" Then
                    txtFromLoc.Text = txtSerialBarcode.Text

                    txtSerialBarcode.Text = ""
                    txtSerialBarcode.Focus()

                End If

                'Get information.
                If txtItem.Text <> "" And txtLot.Text <> "" And txtFromLoc.Text <> "" Then

                    If txtFWH.Text = "" And txtTWH.Text = "" Then
                        Dim ws As New SATWebSV.SATWebSV
                        ds = New DataSet
                        ds = ws.getQtyBeforeMoveWH(txtItem.Text, txtLot.Text, txtFromLoc.Text)

                        If ds.Tables(0).Rows.Count > 0 Then
                            txtItem.Text = ds.Tables(0).Rows(0)(0).ToString()
                            txtLot.Text = ds.Tables(0).Rows(0)(1).ToString()
                            txtFWH.Text = ds.Tables(0).Rows(0)(2).ToString()
                            txtTWH.Text = ds.Tables(0).Rows(0)(3).ToString()
                            'txtFromLoc.Text = ds.Tables(0).Rows(0)(4).ToString()
                            txtToLoc.Text = ds.Tables(0).Rows(0)(5).ToString()
                            nudQty.Text = CInt(ds.Tables(0).Rows(0)(6).ToString())
                        Else
                            MsgBox("There is no Qty in location!")
                            Call clearData()
                        End If
                        txtSerialBarcode.Text = ""
                        txtSerialBarcode.Focus()
                        Exit Sub

                    End If

                Else
                    MsgBox("There is no item in location!")
                    txtFromLoc.Text = ""
                    txtSerialBarcode.Focus()
                    Exit Sub
                End If

                ds.Dispose()
                txtSerialBarcode.Text = ""
                btnMove.Focus()

            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        End If
    End Sub

    Private Sub frmPicking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSerialBarcode.Focus()
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If txtFWH.Text <> txtTWH.Text Then
            Try
                If txtItem.Text <> "" And txtLot.Text <> "" And txtFromLoc.Text <> "" And txtToLoc.Text <> "" _
                    And nudQty.Value <> 0 And nudQty.Text <> "" Then

                    Dim ws As New SATWebSV.SATWebSV
                    Dim strResult As String
                    If nudQty.Text > 0 Then

                        strResult = ws.MovePackingLocation(txtItem.Text, txtLot.Text, txtFWH.Text, txtTWH.Text, txtFromLoc.Text, txtToLoc.Text, nudQty.Value)

                        Call clearData()
                    Else
                        strResult = "Please fill in Qty"
                    End If

                    MsgBox(strResult, MsgBoxStyle.Information, "Result")
                    txtSerialBarcode.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MsgBox("Same Location", MsgBoxStyle.Critical, "Result")
        End If

    End Sub
    Private Sub clearData()
        txtItem.Text = ""
        txtLot.Text = ""
        txtFWH.Text = ""
        txtTWH.Text = ""
        txtFromLoc.Text = ""
        txtToLoc.Text = ""
        nudQty.Value = 0

        txtSerialBarcode.Focus()
    End Sub

    Private Sub txtSerialBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerialBarcode.TextChanged

    End Sub
End Class