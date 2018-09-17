Imports System.Data
Imports System.Data.SqlServerCe
Imports System.Data.SqlTypes
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class frmSerial
    Dim dt As DataTable
    Dim strID As String = ""

    Public Property _strID() As String
        Get
            Return strID
        End Get
        Set(ByVal value As String)
            strID = value
        End Set
    End Property

    Private Sub frmEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CreateTable()
        txtSerialBarcode.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If CInt(lblQtyRemain.Text) < CInt(dtgSerial.CurrentRowIndex + 1) Then
            MsgBox(CInt(lblQtyRemain.Text) & " - not match - " & CInt(dtgSerial.CurrentRowIndex + 1))
            Exit Sub
        End If

        Dim cnt, i, q As Integer

        Dim strLot As String = ""
        Dim strItem As String = ""
        Dim strSerial As String = ""
        Dim strResult As String
        Dim strSerialTot As String = ""
        Dim qty As Integer
        Dim cur_Item As String = ""
        Dim cur_lot As String = ""

        Dim arrSN() As String
        Dim arrLot() As String
        Dim arrQty() As Integer
        Dim arrSerial() As String
        Dim lotQty As Integer = 0
        Dim lotEA As Integer = 0

        Dim j As Integer = 0
        Dim k As Integer = 0
        Dim qtyLot As Integer = 0
        q = 0
        Try
            'count lot
            ReDim arrLot(25)
            For cnt = 0 To dt.Rows.Count - 1

                strLot = dtgSerial.Item(cnt, 1).ToString

                If cur_lot <> strLot Then

                    cur_lot = strLot
                    For j = 0 To UBound(arrLot)
                        If strLot = arrLot(j) Then
                            Exit For
                        End If
                    Next j

                    If j = arrLot.Length Then
                        arrLot(lotQty) = strLot
                        lotQty = lotQty + 1
                    End If
                End If

            Next cnt

            ReDim arrQty(lotQty - 1)
            ReDim arrSerial(lotQty - 1)

            '------------------
            For cnt = 0 To lotQty - 1
                k = 0
                lotEA = 0
                ReDim arrSN(dt.Rows.Count - 1)
                For i = 0 To dt.Rows.Count - 1
                    strResult = ""
                    strLot = dtgSerial.Item(i, 1).ToString
                    strItem = dtgSerial.Item(i, 2).ToString
                    strSerial = dtgSerial.Item(i, 3).ToString

                    If cur_Item = "" Then
                        cur_Item = strItem
                        cur_lot = strLot
                    End If

                    'MsgBox(strTrnNum & "," & strJob & "," & strSuffix)
                    If cur_Item = strItem Then

                        'Next lot
                        If strLot = arrLot(cnt) Then
                            arrSN(k) = Microsoft.VisualBasic.Right("00" & strSerial, 2)
                            dtgSerial(i, 4) = "OK"
                            lotEA = lotEA + 1
                        Else
                            arrSN(k) = "99"

                        End If
                        k = k + 1
                        '--------------------------
                    Else
                        dtgSerial(i, 4) = "ERR"
                        MsgBox("Incorrect item,1 Box should have 1 part", MsgBoxStyle.Critical, "Warning")
                        Exit Sub
                    End If
                Next i
                If i = dt.Rows.Count Then
                    'arrLot(q) = cur_lot
                    'arrQty(q) = lotEA
                    Array.Sort(arrSN)
                    For j = 0 To lotEA - 1
                        If j = 0 Then
                            strSerialTot = "-" & arrSN(j)
                        Else
                            strSerialTot = strSerialTot + ",-" + arrSN(j)
                        End If
                    Next j
                    arrSerial(cnt) = strSerialTot
                    arrQty(cnt) = lotEA
                End If
            Next cnt


            If strLot <> "" Then
                Dim ws As New SATWebSV.SATWebSV
                For i = 0 To lotQty - 1
                    strResult = ws.insertSerial(Trim(txtTO.Text), Trim(txtSBox.Text), Trim(txtCofC.Text), Trim(cur_Item), Trim(arrLot(i)), arrQty(i), arrSerial(i))
                Next i
                If Microsoft.VisualBasic.Left(strResult, 9) = "Completed" Then

                    Dim strResult1 As String = "xxx"

                    If chkPrint.Checked = True Then
                        Dim pResult As String
                        pResult = ws.PrintCofCToReport("", "", txtCofC.Text, txtCofC.Text, "", "", "Q", "SA")

                        MsgBox(pResult & " and Printing...", MsgBoxStyle.Information, "Warning")
                    Else
                        MsgBox(strResult, MsgBoxStyle.Information, "Warning")
                    End If

                    txtSBox.Text = String.Empty
                    txtCofC.Text = String.Empty
                    dt.Rows.Clear()
                Else
                    MsgBox(strResult, MsgBoxStyle.Critical, "Warning")
                End If

            End If

            txtSerialBarcode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
            Call ClearData()
        End Try


    End Sub
    Private Sub ClearData()
        txtSerialBarcode.Text = String.Empty

        'dgName = Nothing
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtSerialBarcode.Text = String.Empty
        txtTO.Text = String.Empty
        txtCofC.Text = String.Empty
        txtSBox.Text = String.Empty

        dt.Rows.Clear()

        txtSerialBarcode.Focus()
    End Sub


    Private Sub txtName_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.InputPanel1.Enabled = True
    End Sub

    Private Sub txtEmail_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.InputPanel1.Enabled = True
    End Sub

    Private Sub txtSerialBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerialBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            Try

                'dt.Rows.Clear()

                Dim strBarcode As String = ""
                Dim arrCode As String()
                Dim arrlot As String()

                Dim strItem As String
                Dim strLotSerial As String
                Dim strLot As String
                Dim strSerial As String

                If txtTO.Text = "" Then
                    txtTO.Text = Microsoft.VisualBasic.Left(txtSerialBarcode.Text, 10)
                    txtSerialBarcode.Text = ""
                    txtSerialBarcode.Focus()
                    Exit Sub
                End If
                If txtTO.Text <> "" And txtSBox.Text = "" Then
                    txtSBox.Text = Microsoft.VisualBasic.Left(txtSerialBarcode.Text, 20)
                    txtSerialBarcode.Text = ""
                    txtSerialBarcode.Focus()
                    Exit Sub
                End If
                'If chkCofC.Checked Then
                If txtTO.Text <> "" And txtSBox.Text <> "" And txtCofC.Text = "" Then
                    txtCofC.Text = Microsoft.VisualBasic.Left(txtSerialBarcode.Text, 15)
                    txtSerialBarcode.Text = ""
                    txtSerialBarcode.Focus()
                    Exit Sub
                End If
                'End If


                strBarcode = txtSerialBarcode.Text
                arrCode = Split(strBarcode, " ")
                'JALUXUS
                If UBound(arrCode) = 3 Then
                    strLotSerial = arrCode(2)
                    strItem = arrCode(3)

                    arrlot = Split(strLotSerial, "-")
                    strLot = Microsoft.VisualBasic.Right(arrlot(0), 4)
                    strSerial = Replace(arrlot(1), Microsoft.VisualBasic.Right(arrlot(1), 3), "")

                    dt = InsertRowInTbl(strLot, strItem, strSerial)
                    dtgSerial.DataSource = dt

                    dtgSerial.CurrentRowIndex = dt.Rows.Count - 1
                    dtgSerial.Select(dtgSerial.CurrentRowIndex)
                Else
                    arrCode = Split(strBarcode, ",")
                    'MTU
                    If UBound(arrCode) = 1 Then
                        strLotSerial = arrCode(1)
                        strItem = arrCode(0)

                        arrlot = Split(strLotSerial, "-")
                        strLot = Microsoft.VisualBasic.Right(arrlot(0), 4)
                        strSerial = arrlot(1)

                        dt = InsertRowInTbl(strLot, strItem, strSerial)
                        dtgSerial.DataSource = dt

                        dtgSerial.CurrentRowIndex = dt.Rows.Count - 1
                        dtgSerial.Select(dtgSerial.CurrentRowIndex)
                    End If
                End If

                txtSerialBarcode.Text = ""
            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        End If
    End Sub

    Public Function InsertRowInTbl(ByVal strLot As String, ByVal strItem As String, ByVal strSerial As String) As DataTable
        Dim row As DataRow() = dt.[Select]("Batch='" & strLot & "' and Item='" & strItem & "' and SN='" & strSerial & "'")
        If row.Length = 0 Then
            Dim tempRow As DataRow
            tempRow = dt.NewRow()

            tempRow("No") = dt.Rows.Count + 1
            tempRow("Batch") = strLot
            tempRow("Item") = strItem
            tempRow("SN") = strSerial
            tempRow("Sts") = "-"
            dt.Rows.Add(tempRow)

            If dt.Rows.Count = 1 Then
                Dim strResult As String = ""
                Dim ws As New SATWebSV.SATWebSV
                strResult = ws.TrnItemQtyRemain(Trim(txtTO.Text), Trim(strItem), Trim(txtCofC.Text))
                lblQtyRemain.Text = strResult
            End If
        End If
        Return dt
    End Function

    Public Sub CreateTable() 'creating table in the memory

        Me.dtgSerial.TableStyles.Clear()
        dt = New DataTable("jobtbl") 'table name

        Dim tableStyle As New DataGridTableStyle()
        tableStyle.MappingName = dt.ToString

        'ds.Tables(0).Rows(0)(0).ToString()
        dt.Columns.Add("No") 'first column name
        dt.Columns.Add("Batch") 'first column name
        dt.Columns.Add("Item") 'SecondColumn name
        dt.Columns.Add("SN") 'SecondColumn name
        dt.Columns.Add("Sts") 'SecondColumn name

        Dim column As New DataGridTextBoxColumn()
        column.MappingName = "No"
        column.HeaderText = "No"
        column.Width = 20
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Batch"
        column.HeaderText = "Batch"
        column.Width = 40
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Item"
        column.HeaderText = "Item"
        column.Width = 55
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "SN"
        column.HeaderText = "SN"
        column.Width = 24
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "Sts"
        column.HeaderText = "Sts"
        column.Width = 26
        tableStyle.GridColumnStyles.Add(column)

        Me.dtgSerial.TableStyles.Add(tableStyle)
    End Sub

    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click
        If dt.Rows.Count > 0 Then
            dt.Rows.RemoveAt(dtgSerial.CurrentRowIndex)
        End If
        txtSerialBarcode.Focus()
    End Sub

    'Private Sub chkCofC_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If chkCofC.Checked Then
    '        txtCofC.ReadOnly = True
    '        txtCofC.ForeColor = Color.Gray
    '    Else
    '        txtCofC.ReadOnly = False
    '        txtCofC.ForeColor = Color.White
    '    End If
    'End Sub

    Private Sub txtSerialBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSerialBarcode.TextChanged

    End Sub

    Private Sub txtTO_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTO.TextChanged

    End Sub

    Private Sub txtCofC_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCofC.TextChanged

    End Sub
End Class