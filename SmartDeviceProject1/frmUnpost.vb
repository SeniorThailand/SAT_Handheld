Imports System.Data

Public Class frmUnpost
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim qty As Integer
    Dim currQty As Integer
    Public strScrap As String = ""
    Public strCause As String = ""
    Public strFeature As String = ""
    Public fsrp As dialogScrap

    Private Sub frmTest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CreateTable()
        'Call CreateReason()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            If numQtyScrap.Value + numQtyComplete.Value > numQtyMove.Value Then
                MsgBox("Please check qty", MsgBoxStyle.Question, "Warning")
                Exit Sub
            End If

            If numQtyScrap.Value > 0 Then
                fsrp = New dialogScrap
                fsrp.ShowDialog()
                strScrap = fsrp.cboReasonCode.SelectedValue.ToString
                strCause = fsrp.cboFaultCode.SelectedValue.ToString
                strFeature = fsrp.txtFeatureCode.Text.ToString
                fsrp.Dispose()
            End If

            Dim strResult As String
            Dim ws As New SATWebSV.SATWebSV

            'Validate Data
            If ValidateData() = True Then
                If currQty >= (CInt(numQtyComplete.Value) + CInt(numQtyScrap.Value)) Then
                    strResult = ws.insertJobTrans_rev1(txtJob.Text, txtSuffix.Text, txtOper.Text, CInt(numQtyComplete.Value), CInt(numQtyScrap.Value), strScrap, strCause, strFeature)
                    'strResult = ws.insertJobTrans_test(txtJob.Text, txtSuffix.Text, txtOper.Text, CInt(numQtyComplete.Value), CInt(numQtyScrap.Value), strScrap, strCause)
                End If
            End If

            lblSts.Text = strResult
            If strResult = "Complete" Then
                lblSts.ForeColor = Color.GreenYellow
                lblSts.BackColor = Color.Black
            ElseIf strResult = "Incomplete" Then
                lblSts.ForeColor = Color.Red
                lblSts.BackColor = Color.Black
            Else
                lblSts.ForeColor = Color.White
                lblSts.BackColor = Color.Red
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Call ClearData()
        txtJobOper.Focus()
    End Sub
    Public Function ValidateData() As Boolean
        If txtJob.Text.Trim = Nothing Or txtSuffix.Text.Trim = Nothing Or txtOper.Text.Trim = Nothing Then
            MessageBox.Show("Please scan into first text box")
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub CreateReason()
        Dim rs As New SATWebSV.SATWebSV
        ds = New DataSet
        ds = rs.selectReason()
        For i = 0 To ds.Tables(0).Rows.Count - 1
            cboReason.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
        Next i
        'cboReason.Enabled = False
    End Sub
    Public Sub CreateTable() 'creating table in the memory
        Me.dgName.TableStyles.Clear()
        dt = New DataTable("mytbl") 'table name

        Dim tableStyle As New DataGridTableStyle()
        tableStyle.MappingName = dt.ToString

        'ds.Tables(0).Rows(0)(0).ToString()
        dt.Columns.Add("Job") 'first column name
        dt.Columns.Add("Suffix") 'SecondColumn name
        dt.Columns.Add("Op") 'SecondColumn name
        dt.Columns.Add("QtyR") 'SecondColumn name
        dt.Columns.Add("QtyS") 'SecondColumn name

        Dim column As New DataGridTextBoxColumn()
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
        column.MappingName = "Op"
        column.HeaderText = "Op"
        'column.Width = 25
        column.Width = 35
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "QtyR"
        column.HeaderText = "QtyR"
        'column.Width = 30
        column.Width = 40
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "QtyS"
        column.HeaderText = "QtyS"
        'column.Width = 30
        column.Width = 40
        tableStyle.GridColumnStyles.Add(column)

        Me.dgName.TableStyles.Add(tableStyle)
    End Sub

    Public Function InsertRowInTbl(ByVal JobCol As String, ByVal SuffixCol As String, ByVal OperCol As String, _
            ByVal qtyRel As Integer, ByVal qtyScrap As Integer) As DataTable
        'Dim row As DataRow() = dt.[Select]("job='" & JobCol & "' and suffix='" & SuffixCol & "' and oper_num='" & OperCol & "'")
        'If row.Length = 0 Then
        Dim tempRow As DataRow
        tempRow = dt.NewRow()
        tempRow("Job") = JobCol
        tempRow("Suffix") = CInt(SuffixCol)
        tempRow("Op") = CInt(OperCol)
        tempRow("QtyR") = CInt(qtyRel)
        tempRow("QtyS") = CInt(qtyScrap)
        dt.Rows.Add(tempRow)
        'End If
        Return dt
    End Function

    Private Sub txtJobOper_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJobOper.KeyPress
        If e.KeyChar = Chr(13) Then
            Call getQty()
        End If
    End Sub
    Private Sub getQty()
        Try
            lblSts.Text = "Ready"
            lblSts.ForeColor = Color.White

            numQtyComplete.Value = 0
            numQtyScrap.Value = 0
            numQtyMove.Value = 0

            Dim strJob As String = ""
            Dim suffix As Integer = 0
            Dim Oper As Integer = 0
            Dim arrBarCode() As String

            Dim strSufOper As String = ""

            strJob = Mid(txtJobOper.Text, 1, 10)
            strSufOper = Replace(txtJobOper.Text, strJob & "-", "")

            'getQty
            arrBarCode = Split(strSufOper, "-")
            If arrBarCode.Length = 2 Then
                txtJob.Text = strJob
                txtSuffix.Text = CInt(arrBarCode(0))
                txtOper.Text = CInt(arrBarCode(1))

                Dim ws As New SATWebSV.SATWebSV
                qty = ws.selectQty_rev1(txtJob.Text, txtSuffix.Text, txtOper.Text)
                'qty = ws.selectQty_rev2(txtJob.Text, txtSuffix.Text, txtOper.Text)

                txtJobOper.Text = String.Empty
                If qty = 0 Then
                    MsgBox(strJob & " is invalid", MsgBoxStyle.Information, "Warning")
                    ClearData()
                    txtJobOper.Focus()
                ElseIf qty = -1 Then
                    MsgBox("Please do by sequence", MsgBoxStyle.Information, "Warning")
                    ClearData()
                    txtJobOper.Focus()
                ElseIf qty = -2 Then
                    MsgBox("This oper has duplicated", MsgBoxStyle.Information, "Warning")
                    ClearData()
                    txtJobOper.Focus()
                Else
                    currQty = qty
                    numQtyComplete.Value = qty
                    numQtyMove.Value = numQtyComplete.Value
                    btnSave.Focus()
                End If

            Else
                ClearData()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click, TabControl1.GotFocus
        Call ClearData()
        If TabControl1.SelectedIndex = 0 Then
            txtJobOper.Focus()
        Else
            txtBarcode2.Focus()
        End If
    End Sub
    Private Sub ClearData()
        txtJobOper.Text = String.Empty
        txtJob.Text = String.Empty
        txtSuffix.Text = String.Empty
        txtOper.Text = String.Empty
        numQtyComplete.Value = 0
        numQtyScrap.Value = 0
        numQtyMove.Value = 0
        currQty = 0
        'dgName = Nothing

    End Sub
    Private Sub txtBarcode2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode2.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                dt.Rows.Clear()
                Dim arrBarcode() As String
                Dim strJob As String = ""
                Dim strSuffix As String = 0
                Dim strSufOper As String

                strJob = Mid(txtBarcode2.Text, 1, 10)
                strSufOper = Replace(txtBarcode2.Text, strJob & "-", "")

                arrBarcode = Split(strSufOper, "-")
                strSuffix = arrBarcode(0)

                If strJob <> "" Then
                    Dim ws As New SATWebSV.SATWebSV
                    ds = New DataSet
                    ds = ws.selectData(strJob, CInt(strSuffix))
                    'ds = ws.selectData_rev4(strJob, CInt(strSuffix))

                    '    dt = InsertRowInTbl(txtJob.Text, txtSuffix.Text, txtOper.Text)

                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        dt = InsertRowInTbl(ds.Tables(0).Rows(i)(0).ToString(), _
                            ds.Tables(0).Rows(i)(1).ToString(), _
                            ds.Tables(0).Rows(i)(2).ToString(), _
                            ds.Tables(0).Rows(i)(3), _
                            ds.Tables(0).Rows(i)(4))
                    Next i
                    dgName.DataSource = dt
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

    Private Sub numQtyScrap_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numQtyScrap.KeyPress
        If numQtyScrap.Value >= 0 Then
            numQtyComplete.Value = numQtyMove.Value - numQtyScrap.Value
            'cboReason.Enabled = True
        Else
            'cboReason.Enabled = False
            cboReason.Text = ""
        End If
    End Sub

    Private Sub numQtyComplete_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numQtyComplete.KeyPress
        If numQtyComplete.Value >= 0 Then
            numQtyScrap.Value = numQtyMove.Value - numQtyComplete.Value
            'cboReason.Enabled = True
        Else
            'cboReason.Enabled = False
            cboReason.Text = ""
        End If
    End Sub

    Private Sub txtJobOper_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJobOper.TextChanged

    End Sub

    Private Sub txtBarcode2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode2.TextChanged

    End Sub
End Class