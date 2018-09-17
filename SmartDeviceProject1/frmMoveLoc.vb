Imports System.Data
Public Class frmMoveLoc
    Dim ds As New DataSet
    Dim dt As DataTable
    Dim dt2 As DataTable
    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = Chr(13) Then

            Try

                'dt.Rows.Clear()

                Dim strJob As String = ""
                Dim strSuffix As String = 0
                Dim strLoc As String = ""
                Dim strSufQty As String
                Dim arrBarCode() As String

                'arrBarcode = Split(txtBarcode2.Text, "-")
                If txtJob.Text = "" Then
                    'Check scan from IHC------------------------
                    arrBarCode = Split(txtBarcode.Text, "-")
                    If arrBarCode.Length = 3 Then
                        strJob = Mid(txtBarcode.Text, 1, 10)
                        strSufQty = Replace(txtBarcode.Text, strJob & "-", "")
                        'getQty
                        arrBarCode = Split(strSufQty, "-")
                        If arrBarCode.Length = 2 Then
                            If txtFrom.Text = "" Then
                                txtJob.Text = strJob
                                txtSuffix.Text = CInt(arrBarCode(0))

                                Dim ws As New SATWebSV.SATWebSV
                                ds = New DataSet
                                ds = ws.getQtyBeforeMove(strJob, CInt(strSuffix))

                                If ds.Tables(0).Rows.Count > 0 Then
                                    txtWhse.Text = ds.Tables(0).Rows(0)(0).ToString()
                                    txtItem.Text = ds.Tables(0).Rows(0)(1).ToString()
                                    txtLot.Text = ds.Tables(0).Rows(0)(2).ToString()
                                    txtFrom.Text = ds.Tables(0).Rows(0)(3).ToString()
                                    'txtTo.Text = ds.Tables(0).Rows(0)(4).ToString()
                                    nudQty.Text = CInt(ds.Tables(0).Rows(0)(5).ToString())
                                Else
                                    MsgBox("No data!", MsgBoxStyle.Critical, "Warning")
                                End If

                                txtTo.Focus()
                                ds.Dispose()
                                ws.Dispose()

                            End If

                        ElseIf arrBarCode.Length = 1 Then
                            txtJob.Text = strJob
                            txtSuffix.Text = CInt(arrBarCode(0))
                            nudQty.Text = 0
                            txtFrom.Focus()
                        End If
                    Else
                        'Check scan from 2D barcode
                        arrBarCode = Split(txtBarcode.Text, ",")
                        If arrBarCode.Length = 3 Then
                            Dim strItem As String = arrBarCode(0)
                            Dim strLot As String = arrBarCode(1)

                            Dim ws As New SATWebSV.SATWebSV
                            ds = New DataSet
                            ds = ws.getJobFromItemLot(arrBarCode(0), arrBarCode(1))

                            txtJob.Text = ds.Tables(0).Rows(0)(0).ToString()
                            txtSuffix.Text = ds.Tables(0).Rows(0)(1).ToString()
                            ds.Dispose()

                            ds = New DataSet
                            ds = ws.getQtyBeforeMove(txtJob.Text, CInt(txtSuffix.Text))

                            txtWhse.Text = ds.Tables(0).Rows(0)(0).ToString()
                            txtItem.Text = ds.Tables(0).Rows(0)(1).ToString()
                            txtLot.Text = ds.Tables(0).Rows(0)(2).ToString()
                            txtFrom.Text = ds.Tables(0).Rows(0)(3).ToString()
                            'txtTo.Text = ds.Tables(0).Rows(0)(4).ToString()
                            nudQty.Text = CInt(ds.Tables(0).Rows(0)(5).ToString())
                            txtTo.Focus()
                            ds.Dispose()

                        End If
                    End If

                End If
                txtBarcode.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        End If
    End Sub
    Private Sub TabPage1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage1.GotFocus
        txtBarcode.Focus()
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If txtFrom.Text <> txtTo.Text Then
            Try
                If txtJob.Text <> "" And txtSuffix.Text <> "" And txtFrom.Text <> "" And txtTo.Text <> "" And nudQty.Text <> "" Then
                    Dim ws As New SATWebSV.SATWebSV
                    Dim strResult As String
                    If nudQty.Text > 0 Then
                        If txtTo.Text = "STOCK-PACKING" Then
                            ws.PrintLabelAEPacking(txtJob.Text, txtSuffix.Text)
                        End If

                        strResult = ws.MovePackingLocation(txtItem.Text, txtLot.Text, txtWhse.Text, txtWhse.Text, txtFrom.Text, txtTo.Text, nudQty.Text)

                        Call clearBox()
                    Else
                        strResult = "Please fill in Qty"
                    End If

                    MsgBox(strResult, MsgBoxStyle.Information, "Result")
                    txtBarcode.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        Else
            MsgBox("Same Location", MsgBoxStyle.Critical, "Result")
        End If
    End Sub

    Private Sub txtCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCancel.Click
        Call clearBox()
    End Sub
    Private Sub clearBox()
        txtJob.Text = ""
        txtSuffix.Text = ""
        nudQty.Text = ""
        txtFrom.Text = ""
        txtTo.Text = ""
        txtWhse.Text = ""
        txtItem.Text = ""
        txtLot.Text = ""

        txtBarcode.Text = ""

        txtBarcode.Focus()
    End Sub

    Private Sub txtBarcode2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode2.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                dt2.Rows.Clear()
                Dim strJob As String = ""
                Dim strSuffix As String = ""
                Dim strCurLoc As String = ""
                Dim strToLoc As String = ""

                Dim arrBarcode As String()

                arrBarcode = Split(txtBarcode2.Text, "-")
                'If txtItem.Text = "" Then
                strJob = arrBarcode(0)
                strSuffix = arrBarcode(1)

                '-------------
                Dim ws As New SATWebSV.SATWebSV
                ds = New DataSet
                '------------------
                If strJob <> "" Then

                    ds = New DataSet
                    ds = ws.selectDataJobItem(strJob, strSuffix)
                    'ds = ws.selectData_rev4(strJob, CInt(strSuffix))

                    '    dt = InsertRowInTbl(txtJob.Text, txtSuffix.Text, txtOper.Text)

                    For i = 0 To ds.Tables(0).Rows.Count - 1
                        dt2 = InsertRowInTbl2(ds.Tables(0).Rows(i)(0).ToString(), _
                            ds.Tables(0).Rows(i)(1).ToString(), _
                            ds.Tables(0).Rows(i)(2).ToString(), _
                            ds.Tables(0).Rows(i)(3).ToString())
                    Next i
                    dtgCheck.DataSource = dt2
                    txtBarcode2.Text = String.Empty
                    txtBarcode2.Focus()
                Else
                    txtBarcode2.Text = String.Empty
                    Call clearBox()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                Call clearBox()
            End Try
        End If
    End Sub
    Public Sub CreateTable2() 'creating table in the memory
        Me.dtgCheck.TableStyles.Clear()
        dt2 = New DataTable("mytbl") 'table name

        Dim tableStyle As New DataGridTableStyle()
        tableStyle.MappingName = dt2.ToString

        'ds.Tables(0).Rows(0)(0).ToString()
        dt2.Columns.Add("WH") 'first column name
        dt2.Columns.Add("Loc") 'SecondColumn name
        dt2.Columns.Add("Lot") 'SecondColumn name
        dt2.Columns.Add("Qty") 'SecondColumn name

        Dim column As New DataGridTextBoxColumn()
        column.MappingName = "WH"
        column.HeaderText = "WH"
        'column.Width = 65
        column.Width = 30
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Loc"
        column.HeaderText = "Loc"
        'column.Width = 20
        column.Width = 60
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Lot"
        column.HeaderText = "Lot"
        'column.Width = 25
        column.Width = 90
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Qty"
        column.HeaderText = "Qty"
        'column.Width = 25
        column.Width = 20
        tableStyle.GridColumnStyles.Add(column)

        Me.dtgCheck.TableStyles.Add(tableStyle)
    End Sub
    Public Function InsertRowInTbl2(ByVal strMain As String, ByVal strLoc As String, ByVal strLot As String, ByVal qty As Integer) As DataTable
        'Dim row As DataRow() = dt.[Select]("job='" & JobCol & "' and suffix='" & SuffixCol & "' and oper_num='" & OperCol & "'")
        'If row.Length = 0 Then
        Dim tempRow As DataRow
        tempRow = dt2.NewRow()
        tempRow("WH") = strMain
        tempRow("Loc") = strLoc
        tempRow("Lot") = strLot
        tempRow("Qty") = qty
        dt2.Rows.Add(tempRow)
        'End If
        Return dt2
    End Function

    Private Sub frmMoveLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CreateTable2()
        txtBarcode.Focus()
    End Sub


    Private Sub txtFrom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFrom.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                txtTo.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub txtTo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTo.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                btnMove.Focus()
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub TabPage2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabPage2.GotFocus
        txtBarcode2.Focus()
    End Sub

    Private Sub nudQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudQty.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                txtFrom.Focus()

            Catch ex As Exception

            End Try
        End If
    End Sub


    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class