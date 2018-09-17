Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.SqlTypes
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class frmIHCCheck
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dt2 As DataTable
    Dim qty As Integer
    Dim strJobSuffix As String = ""


    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                'dt.Rows.Clear()
                Dim strJob As String = ""
                Dim strSufOper As String = ""
                Dim strSuffix As String = 0
                Dim qty As Integer = 0
                Dim arrJobSuf As String()

                'arrBarcode = Split(txtBarcode2.Text, "-")
                If txtJob.Text = "" Then
                    arrJobSuf = Split(txtBarcode.Text, "-")
                    txtJob.Text = arrJobSuf(0)
                    txtSuffix.Text = arrJobSuf(1)
                    'nupQty.Value = arrJobSuf(2)

                    'Dim ws As New SATWebSV.SATWebSV
                    Dim ws As New SATWebSV.SATWebSV

                    qty = ws.getQtyIHC(txtJob.Text, txtSuffix.Text)

                    dt = InsertRowInTbl(txtJob.Text, txtSuffix.Text, qty)
                    dtgJob.DataSource = dt
                End If

                txtBarcode.Text = ""
                txtJob.Text = String.Empty
                txtSuffix.Text = String.Empty

            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        End If
    End Sub
    Public Function InsertRowInTbl(ByVal strJob As String, ByVal strSuffix As String, ByVal qty As Integer) As DataTable
        Dim row As DataRow() = dt.[Select]("Job='" & strJob & "' and Suffix='" & strSuffix & "'")
        If row.Length = 0 Then
            Dim tempRow As DataRow
            tempRow = dt.NewRow()

            tempRow("No") = dt.Rows.Count + 1
            tempRow("Job") = strJob
            tempRow("Suffix") = strSuffix
            tempRow("Qty") = qty
            tempRow("Sts") = "-"
            dt.Rows.Add(tempRow)
        End If
        Return dt
    End Function
    Public Sub CreateTable() 'creating table in the memory

        Me.dtgJob.TableStyles.Clear()
        dt = New DataTable("jobtbl") 'table name

        Dim tableStyle As New DataGridTableStyle()
        tableStyle.MappingName = dt.ToString

        'ds.Tables(0).Rows(0)(0).ToString()
        dt.Columns.Add("No") 'first column name
        dt.Columns.Add("Job") 'first column name
        dt.Columns.Add("Suffix") 'SecondColumn name
        dt.Columns.Add("Qty") 'SecondColumn name
        dt.Columns.Add("Sts") 'SecondColumn name

        Dim column As New DataGridTextBoxColumn()
        column.MappingName = "No"
        column.HeaderText = "No"
        'column.Width = 65
        column.Width = 20
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Job"
        column.HeaderText = "Job"
        'column.Width = 65
        column.Width = 80
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Suffix"
        column.HeaderText = "Suffix"
        'column.Width = 20
        column.Width = 30
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Qty"
        column.HeaderText = "Qty"
        'column.Width = 20
        column.Width = 30
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Sts"
        column.HeaderText = "Sts"
        'column.Width = 20
        column.Width = 30
        tableStyle.GridColumnStyles.Add(column)

        Me.dtgJob.TableStyles.Add(tableStyle)
    End Sub

    Private Sub frmIHCCheck_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CreateTable()
        txtBarcode.Focus()
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub
    Public Sub ClearData()
        txtBarcode.Text = String.Empty
        txtJob.Text = String.Empty
        txtSuffix.Text = String.Empty
        strJobSuffix = ""

        dt.Rows.Clear()
        txtBarcode.Focus()
    End Sub

    Private Sub nupQty_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nupQty.ValueChanged
        dtgJob(dtgJob.CurrentRowIndex, 3) = nupQty.Text
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim i As Integer
        Dim strJob As String
        Dim strSuffix As Integer
        Dim strResult As String = ""
        Dim qty As Integer
        Try

            For i = 0 To dt.Rows.Count - 1
                strResult = ""
                strJob = dtgJob.Item(i, 1).ToString
                strSuffix = dtgJob.Item(i, 2).ToString
                qty = dtgJob.Item(i, 3).ToString

                'MsgBox(strTrnNum & "," & strJob & "," & strSuffix)

                If strJob <> "" Then
                    Dim ws As New SATWebSV.SATWebSV
                    strResult = ws.insertIHCCheck(strJob, strSuffix, qty)
                End If

                If strResult = "SAVED" Then
                    'dtgJobItem.Item(i, 2) = "OK"
                    dtgJob(i, 4) = "OK"
                ElseIf strResult = "DUPLICATED" Then
                    dtgJob.Item(i, 4) = "DUP"
                ElseIf strResult = "Invalid CofC" Then
                    dtgJob.Item(i, 4) = "COC"
                Else
                    dtgJob.Item(i, 4) = "ERR"
                    MsgBox(strResult)
                End If
            Next i
            txtBarcode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            'Call ClearData()
        End Try

    End Sub
End Class