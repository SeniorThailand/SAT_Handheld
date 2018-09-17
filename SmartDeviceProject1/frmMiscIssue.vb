Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.SqlTypes
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class frmMiscIssue
    Dim ds As DataSet
    Dim dsf As DataSet

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                'dt.Rows.Clear()

                Dim strBarcode As String = ""
                Dim arrCode As String()
                Dim arrlot As String()

                If txtItem.Text = "" Then
                    arrCode = Split(txtBarcode.Text, ",")

                    Dim ws As New SATWebSV.SATWebSV
                    ds = New DataSet
                    ds = ws.getChemLastestLot(arrCode(0), arrCode(1))

                    txtItem.Text = arrCode(0)
                    txtNextLot.Text = ds.Tables(0).Rows(0)(0).ToString()
                    txtLoc.Text = ds.Tables(0).Rows(0)(1).ToString()
                    nudQty.Value = ds.Tables(0).Rows(0)(2).ToString()
                    lblUM.Text = ds.Tables(0).Rows(0)(3).ToString()
                    txtExpDate.Text = ds.Tables(0).Rows(0)(4).ToString()
                    txtWhse.Text = ds.Tables(0).Rows(0)(5).ToString()

                    txtBarcode.Text = ""
                    txtBarcode.Focus()
                    Exit Sub
                End If

                If txtNextLot.Text <> "" And txtThisLot.Text = "" Then
                    arrlot = Split(txtBarcode.Text, ",")
                    txtThisLot.Text = arrlot(1)
                    If txtNextLot.Text = txtThisLot.Text Then
                        btnProcess.Focus()
                    Else
                        txtThisLot.Text = ""
                        txtBarcode.Focus()
                    End If

                End If

                txtBarcode.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        End If
    End Sub

    Private Sub btnProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcess.Click
        If txtNextLot.Text = txtThisLot.Text Then
            Try
                If txtItem.Text <> "" And txtLoc.Text <> "" And nudQty.Value <> 0 And nudQty.Text <> "" Then

                    Dim ws As New SATWebSV.SATWebSV
                    Dim strResult As String
                    If nudQty.Text > 0 Then

                        strResult = ws.SAT_MiscIssue(txtItem.Text, nupMiscQty.Value, txtWhse.Text, txtLoc.Text, txtThisLot.Text, cboReasonCode.ValueMember.ToString)

                        Call clearData()
                    Else
                        strResult = "Please complete information"
                    End If
                    If strResult = "0" Then
                        strResult = "Completed"
                    End If
                    MsgBox(strResult, MsgBoxStyle.Information, "Result")
                    txtBarcode.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        Else
            MsgBox("Lot is incorrect", MsgBoxStyle.Critical, "Result")
        End If
    End Sub
    Private Sub clearData()
        txtItem.Text = ""
        txtNextLot.Text = ""
        txtThisLot.Text = ""
        txtWhse.Text = ""
        txtLoc.Text = ""
        nudQty.Value = 0
        nupMiscQty.Value = 0
        txtExpDate.Text = ""
        txtBarcode.Text = ""

        txtBarcode.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call clearData()
    End Sub

    Private Sub CreateReason()
        Dim rs As New SATWebSV.SATWebSV
        ds = New DataSet
        ds = rs.selectMiscIssueReason()
        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    cboReasonCode.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
        '    Me.cboReasonCode.ValueMember = cboReasonCode.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
        'Next i

        '--------------------------------------
        cboReasonCode.DataSource = ds.Tables(0)
        cboReasonCode.ValueMember = "reason_code"
        cboReasonCode.DisplayMember = "description"

    End Sub

    Private Sub TabPage1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub frmMiscIssue_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CreateReason()
    End Sub
End Class