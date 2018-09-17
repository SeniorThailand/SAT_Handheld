Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.SqlTypes
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Common


Public Class frmTransfer
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dt2 As DataTable
    Dim qty As Integer
    Dim strTrnNum As String = ""


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim i As Integer
        Dim strTrnNum As String
        Dim strBox As String
        Dim strJob As String
        Dim strSuffix As Integer
        Dim strResult As String = ""
        Dim qty As Integer
        Try

            For i = 0 To dt.Rows.Count - 1
                strResult = ""
                strTrnNum = txtTO.Text
                strBox = txtBox.Text
                strJob = dtgJobItem.Item(i, 1).ToString
                strSuffix = dtgJobItem.Item(i, 2).ToString
                qty = dtgJobItem.Item(i, 3).ToString

                'MsgBox(strTrnNum & "," & strJob & "," & strSuffix)

                If strJob <> "" Then
                    Dim ws As New SATWebSV.SATWebSV
                    strResult = ws.insertTrnItem(strTrnNum, strBox, strJob, CInt(strSuffix), qty, chkPrint.Checked)
                End If

                If strResult = "Completed" Then
                    'dtgJobItem.Item(i, 2) = "OK"
                    dtgJobItem(i, 4) = "OK"
                ElseIf strResult = "Dupplicated" Then
                    dtgJobItem.Item(i, 4) = "DUP"
                ElseIf strResult = "Invalid CofC" Then
                    dtgJobItem.Item(i, 4) = "COC"
                Else
                    dtgJobItem.Item(i, 4) = "ERR"
                    MsgBox(strResult)
                End If
            Next i
            txtBarcode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call ClearData()
        End Try

    End Sub

    Public Sub CreateTable() 'creating table in the memory

        Me.dtgJobItem.TableStyles.Clear()
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

        Me.dtgJobItem.TableStyles.Add(tableStyle)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtBarcode.Text = String.Empty
        txtTO.Text = String.Empty
        txtBox.Text = String.Empty
        strTrnNum = ""

        dt.Rows.Clear()
        dt2.Rows.Clear()
        txtBarcode.Focus()

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
    Public Function InsertRowInTbl3(ByVal strJob As String, ByVal strSuffix As String, ByVal qty As Integer) As DataTable
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
    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                'dt.Rows.Clear()

                Dim strJob As String = ""
                Dim strSufOper As String = ""
                Dim strSuffix As String = 0
                Dim qty As Integer = 0
                Dim arrSufOper As String()


                'arrBarcode = Split(txtBarcode2.Text, "-")
                If txtTO.Text = "" Then
                    strTrnNum = Mid(txtBarcode.Text, 1, 10)

                    Dim ws As New SATWebSV.SATWebSV
                    If ws.TranferExits(strTrnNum) > 0 Then
                        Dim strCust As String
                        strCust = ws.TranferCheckCust(strTrnNum)

                        If strCust = "RR-USD" Or strCust = "EU-GBP" Or strCust = "JALUXUS" _
                            Or strCust = "RR-GBP" Then
                            txtBox.Text = ""
                        Else
                            txtBox.Text = "0"
                        End If

                        txtTO.Text = strTrnNum
                    Else
                        MessageBox.Show("Invalid TO No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                        txtTO.Text = ""
                        txtBarcode.Focus()
                    End If
                Else
                    If txtBox.Text = "" Then
                        Dim ws As New SATWebSV.SATWebSV
                        Dim strCust As String
                        strCust = ws.TranferCheckCust(strTrnNum)

                        If strCust = "RR-USD" Or strCust = "EU-GBP" Or strCust = "JALUXUS" _
                          Or strCust = "EU-GBP" Then
                            txtBox.Text = txtBarcode.Text
                        Else
                            txtBox.Text = "0"
                        End If

                        txtBarcode.Text = ""
                        Exit Sub
                    End If

                    strJob = Mid(txtBarcode.Text, 1, 10)
                    strSufOper = Replace(txtBarcode.Text, strJob & "-", "")

                    arrSufOper = Split(strSufOper, "-")

                    strSuffix = arrSufOper(0)
                    If UBound(arrSufOper) = 1 Then
                        If txtBox.Text <> "0" Then 'RR-USD , RR-GBP set qty to 0
                            qty = 0
                        Else
                            qty = arrSufOper(1)
                        End If

                    End If

                    dt = InsertRowInTbl(strJob, strSuffix, qty)
                    dtgJobItem.DataSource = dt
                End If

                txtBarcode.Text = ""

            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        End If
    End Sub

    Private Sub frmTransfer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CreateTable()
        Call CreateTable2()
        TabPage1.Focus()
        txtBarcode.Focus()
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dt.Rows.Count > 0 Then
            dt.Rows.RemoveAt(dtgJobItem.CurrentRowIndex)
        End If
        txtBarcode.Focus()
    End Sub

    Private Sub txtBarcode2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode2.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                dt2.Rows.Clear()
                'Dim arrBarcode() As String
                Dim strTrnNum As String = ""

                'arrBarcode = Split(txtBarcode2.Text, "-")
                strTrnNum = Mid(txtBarcode2.Text, 1, 10)


                If strTrnNum <> "" Then
                    Dim ws As New SATWebSV.SATWebSV
                    ds = New DataSet
                    ds = ws.selectDataTO(strTrnNum)


                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        dt2 = InsertRowInTbl(ds.Tables(0).Rows(i)(0), _
                            ds.Tables(0).Rows(i)(1).ToString(), _
                            ds.Tables(0).Rows(i)(2).ToString(), _
                            ds.Tables(0).Rows(i)(4).ToString(), _
                            ds.Tables(0).Rows(i)(5))
                    Next i

                    dtgName.DataSource = dt2

                
                    txtBarcode2.Text = String.Empty
                    txtBarcode2.Focus()
                Else
                    txtBarcode2.Text = String.Empty
                    Call ClearData()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Call ClearData()
            End Try
        End If
    End Sub
    Public Function InsertRowInTbl(ByVal no As Integer, ByVal strSts As String, ByVal strJob As String, _
        ByVal strCoC As String, ByVal qty As Integer) As DataTable
        'Dim row As DataRow() = dt.[Select]("job='" & JobCol & "' and suffix='" & SuffixCol & "' and oper_num='" & OperCol & "'")
        'If row.Length = 0 Then
        Dim tempRow As DataRow
        tempRow = dt2.NewRow()
        tempRow("No") = CInt(no)
        tempRow("Sts") = strSts
        tempRow("Job") = strJob
        tempRow("Coc") = strCoC
        tempRow("Qty") = CInt(qty)
        dt2.Rows.Add(tempRow)
        'End If
        Return dt2
    End Function
    Private Sub ClearData()
        txtBarcode.Text = String.Empty
        txtBarcode2.Text = String.Empty

        'dgName = Nothing
    End Sub
    Public Sub CreateTable2() 'creating table in the memory
        Me.dtgName.TableStyles.Clear()
        dt2 = New DataTable("mytbl2") 'table name

        Dim tableStyle As New DataGridTableStyle()
        tableStyle.MappingName = dt2.ToString
        '------------

        'ds.Tables(0).Rows(0)(0).ToString()
        dt2.Columns.Add("No") 'first column name
        dt2.Columns.Add("Sts") 'SecondColumn name
        dt2.Columns.Add("Job") 'SecondColumn name
        dt2.Columns.Add("Coc") 'SecondColumn name
        dt2.Columns.Add("Qty") 'SecondColumn name

        Dim column As New DataGridTextBoxColumn()
        column.MappingName = "No"
        column.HeaderText = "No"
        'column.Width = 65
        column.Width = 15
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Sts"
        column.HeaderText = "Sts"
        'column.Width = 20
        column.Width = 15
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Job"
        column.HeaderText = "Job"
        'column.Width = 25
        column.Width = 60

        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Coc"
        column.HeaderText = "Coc"
        'column.Width = 30
        column.Width = 70
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Qty"
        column.HeaderText = "Qty"
        'column.Width = 30
        column.Width = 15
        tableStyle.GridColumnStyles.Add(column)

        Me.dtgName.TableStyles.Add(tableStyle)
    End Sub

    Private Sub TabPage2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.Click
        txtBarcode2.Focus()
    End Sub

    Private Sub TabPage1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.Click
        txtBarcode.Focus()
    End Sub
    Private Sub TabPage3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage3.Click
        txtBarcode3.Focus()
    End Sub
    Private Sub dtgJobItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtgJobItem.Click
        Try
            nupQty.Text = dtgJobItem(dtgJobItem.CurrentRowIndex, 3).ToString
        Catch ex As Exception
        End Try
    End Sub


    Private Sub nupQty_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nupQty.ValueChanged
        dtgJobItem(dtgJobItem.CurrentRowIndex, 3) = nupQty.Text
    End Sub

    Private Sub txtBarcode3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode3.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                If txtTO3.Text = "" Then
                    strTrnNum = Mid(txtBarcode3.Text, 1, 10)

                    Dim ws As New SATWebSV.SATWebSV
                    If ws.TranferExits(strTrnNum) > 0 Then
                        txtTO3.Text = strTrnNum
                        lblPrint.Text = "Ready"
                        lblPrint.ForeColor = Color.Green
                        btnPrint.Focus()
                    Else
                        MessageBox.Show("Invalid TO No.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button1)
                        txtTO3.Text = ""
                        lblPrint.Text = "Stand by"
                        lblPrint.ForeColor = Color.Black
                        txtBarcode3.Focus()
                    End If
                End If
                txtBarcode3.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try

        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            If txtTO3.Text <> "" Then
                lblPrint.Text = "Printing.."
                Application.DoEvents()
                lblPrint.ForeColor = Color.Green

                Dim ws As New SATWebSV.SATWebSV
                ws.PrintLable(txtTO3.Text)


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        lblPrint.Text = "Ready"
        lblPrint.ForeColor = Color.Green
        txtTO3.Text = ""
        txtBarcode3.Focus()
    End Sub
    Private Sub btnClear3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear3.Click
        txtBarcode3.Text = ""
        txtTO3.Text = ""
        txtBarcode3.Focus()
    End Sub

    Private Sub dtgJobItem_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtgJobItem.CurrentCellChanged

    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class
