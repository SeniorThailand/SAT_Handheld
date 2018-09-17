Imports System.Data
Public Class frmBilletMove
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dt2 As DataTable
    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        Dim strWH As String
        Dim Num As Integer
        Dim strSugLoc As String
        If e.KeyChar = Chr(13) Then

            Try

                Dim strItem As String = ""
                Dim strLot As String = ""
                Dim strCurLoc As String = ""
                Dim strToLoc As String = ""

                Dim arrBarcode As String()

                If Microsoft.VisualBasic.Left(txtBarcode.Text, 2) = "BR" Then
                    txtToLoc.Text = txtBarcode.Text
                    txtBarcode.Text = ""
                    txtBarcode.Focus()
                    Exit Sub
                End If


                arrBarcode = Split(txtBarcode.Text, ".")
                If UBound(arrBarcode) = 2 Then
                    strItem = arrBarcode(0)
                    strLot = arrBarcode(1)
                    Num = arrBarcode(2)
                    numQty.Value = 1
                Else
                    MsgBox("Incorrect Data", MsgBoxStyle.OkOnly)
                    Exit Sub
                End If

                If txtItem.Text = "" Then
                    '-------------
                    Dim ws As New SATWebSV.SATWebSV
                    ds = New DataSet
                    ds = ws.getQtyMove1(strItem, strLot)
                    '------------------

                    If ds.Tables(0).Rows.Count > 0 Then
                        strWH = ds.Tables(0).Rows(0)(0).ToString

                        strCurLoc = ds.Tables(0).Rows(0)(2).ToString
                        strSugLoc = ds.Tables(0).Rows(0)(3).ToString

                        lblGuide.Text = strSugLoc
                        txtItem.Text = strItem
                        txtWH.Text = strWH
                        txtFromLoc.Text = strCurLoc

                        dt = InsertRowInTbl(strLot, Num)
                        dtgMove.DataSource = dt

                    End If
                Else
                    If strItem = txtItem.Text Then
                        dt = InsertRowInTbl(strLot, Num)
                        dtgMove.DataSource = dt
                    Else
                        Call ClearData()
                    End If

                End If
                'End If
                txtBarcode.Text = ""
                txtBarcode.Focus()

            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        End If
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        'Try
        '    If numQty.Value = 0 Then
        '        MsgBox("Please check qty", MsgBoxStyle.Question, "Warning")
        '        Exit Sub
        '    End If

        '    Dim strResult As String = ""
        '    Dim ws As New SATWebSV.SATWebSV

        '    'Validate Data

        '    strResult = ws.MoveBillet(txtItem.Text, txtLot.Text, txtFromLoc.Text, txtToLoc.Text, CInt(numQty.Value))

        '    MsgBox(strResult, MsgBoxStyle.Information)

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    txtBarcode.Focus()
        '    Exit Sub
        'End Try

        Dim strResult As String = ""
        Dim ws As New SATWebSV.SATWebSV

        Dim strLot As String
        Dim Qty As Integer

        Dim i As Integer
        Try

            For i = 0 To dt.Rows.Count - 1
                strResult = ""
                strLot = dtgMove.Item(i, 1).ToString
                Qty = numQty.Value
                'Qty = dtgMove.Item(i, 2).ToString

                'MsgBox(strTrnNum & "," & strJob & "," & strSuffix)

                If txtItem.Text <> "" Then
                    strResult = ws.MoveBillet(txtItem.Text, strLot, txtFromLoc.Text, txtToLoc.Text, CInt(Qty))
                End If

                If strResult = "Moved successful" Then
                    dtgMove(i, 3) = "OK"
                Else
                    dtgMove.Item(i, 3) = "ERR"
                    'MsgBox(strResult)
                End If
            Next i
            txtBarcode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call ClearData()
        End Try
        'Call ClearData()
        txtBarcode.Focus()
    End Sub
    Private Sub ClearData()
        txtBarcode.Text = ""
        txtItem.Text = ""
        txtFromLoc.Text = ""
        txtToLoc.Text = ""
        txtWH.Text = ""
        numQty.Value = 0
        lblGuide.Text = "N/A"

        dt.Rows.Clear()

        'dt2.Rows.Clear()
        txtBarcode.Focus()

    End Sub

    Public Sub CreateTable() 'creating table in the memory

        Me.dtgMove.TableStyles.Clear()
        dt = New DataTable("jobtbl") 'table name

        Dim tableStyle As New DataGridTableStyle()
        tableStyle.MappingName = dt.ToString

        'ds.Tables(0).Rows(0)(0).ToString()
        dt.Columns.Add("No") 'first column name
        dt.Columns.Add("Lot") 'SecondColumn name
        dt.Columns.Add("Num") 'SecondColumn name
        dt.Columns.Add("Sts") 'SecondColumn name

        Dim column As New DataGridTextBoxColumn()
        column.MappingName = "No"
        column.HeaderText = "No"
        'column.Width = 65
        column.Width = 20
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Lot"
        column.HeaderText = "Lot"
        'column.Width = 20
        column.Width = 100
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Num"
        column.HeaderText = "Num"
        'column.Width = 20
        column.Width = 25
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Sts"
        column.HeaderText = "Sts"
        'column.Width = 20
        column.Width = 20
        tableStyle.GridColumnStyles.Add(column)

        Me.dtgMove.TableStyles.Add(tableStyle)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call ClearData()
    End Sub

    Public Function InsertRowInTbl(ByVal strLot As String, ByVal Num As Integer) As DataTable
        Dim row As DataRow() = dt.[Select]("Lot='" & strLot & "' and Num='" & Num & "'")
        If row.Length = 0 Then
            Dim tempRow As DataRow
            tempRow = dt.NewRow()

            tempRow("No") = dt.Rows.Count + 1
            tempRow("Lot") = strLot
            tempRow("Num") = Num
            tempRow("Sts") = "-"
            dt.Rows.Add(tempRow)
        End If
        Return dt
    End Function

    Private Sub frmBilletMove_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CreateTable()
        Call CreateTable2()
        TabPage1.Focus()
        txtBarcode.Focus()
    End Sub

    Private Sub txtBarcode2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode2.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                dt2.Rows.Clear()
                Dim strItem As String = ""
                Dim strLot As String = ""
                Dim strCurLoc As String = ""
                Dim strToLoc As String = ""

                Dim arrBarcode As String()

                arrBarcode = Split(txtBarcode2.Text, ".")
                'If txtItem.Text = "" Then
                strItem = arrBarcode(0)

                txtItem2.Text = strItem
                '-------------
                Dim ws As New SATWebSV.SATWebSV
                ds = New DataSet
                '------------------
                If strItem <> "" Then

                    ds = New DataSet
                    ds = ws.selectDataBillet(strItem)

                    'ds = ws.selectData_rev4(strJob, CInt(strSuffix))

                    '    dt = InsertRowInTbl(txtJob.Text, txtSuffix.Text, txtOper.Text)

                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        dt2 = InsertRowInTbl2(ds.Tables(0).Rows(i)(0).ToString(), _
                            ds.Tables(0).Rows(i)(1).ToString(), _
                            ds.Tables(0).Rows(i)(2).ToString())
                    Next i
                    dtgCheck.DataSource = dt2
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
    Public Function InsertRowInTbl2(ByVal strMain As String, ByVal strLoc As String, ByVal qty As Integer) As DataTable
        'Dim row As DataRow() = dt.[Select]("job='" & JobCol & "' and suffix='" & SuffixCol & "' and oper_num='" & OperCol & "'")
        'If row.Length = 0 Then
        Dim tempRow As DataRow
        tempRow = dt2.NewRow()
        tempRow("WH") = strMain
        tempRow("Loc") = strLoc
        tempRow("QtyOH") = qty
        dt2.Rows.Add(tempRow)
        'End If
        Return dt2
    End Function
    Public Sub CreateTable2() 'creating table in the memory
        Me.dtgCheck.TableStyles.Clear()
        dt2 = New DataTable("mytbl") 'table name

        Dim tableStyle As New DataGridTableStyle()
        tableStyle.MappingName = dt2.ToString

        'ds.Tables(0).Rows(0)(0).ToString()
        dt2.Columns.Add("WH") 'first column name
        dt2.Columns.Add("Loc") 'SecondColumn name
        dt2.Columns.Add("QtyOH") 'SecondColumn name

        Dim column As New DataGridTextBoxColumn()
        column.MappingName = "WH"
        column.HeaderText = "WH"
        'column.Width = 65
        column.Width = 40
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Loc"
        column.HeaderText = "Loc"
        'column.Width = 20
        column.Width = 80
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "QtyOH"
        column.HeaderText = "QtyOH"
        'column.Width = 25
        column.Width = 40
        tableStyle.GridColumnStyles.Add(column)

        Me.dtgCheck.TableStyles.Add(tableStyle)
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'dt2.Rows.Clear()
    End Sub

    Private Sub txtBarcode2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode2.TextChanged

    End Sub
End Class