Imports System.Data

Public Class frmPrintDirect
    Dim ds As New DataSet
    Private Sub txtBarcode_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then

            Try

                Dim strItem As String = ""
                Dim strLot As String = ""
                Dim qty As Integer

                Dim arrBarcode As String()

                arrBarcode = Split(txtBarcode.Text, ".")
                If UBound(arrBarcode) = 2 Then
                    strItem = arrBarcode(0)
                    strLot = arrBarcode(1)
                    qty = arrBarcode(2)

                    txtItem.Text = strItem
                    cboLot.Text = strLot
                    numQty.Value = qty

                End If

                txtBarcode.Text = ""
                txtBarcode.Focus()

            Catch ex As Exception
                MsgBox(ex.Message)
                'Call ClearData()
            End Try
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim strResult As String = ""
        Dim ws As New SATWebSV.SATWebSV

        Try

            Call ws.PrintLabelBilletDirect(txtItem.Text, cboLot.Text, numQty.Value)

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
        cboLot.Items.Clear()
        numQty.Value = 0
        txtBarcode.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub
    Private Sub getLot()
        ds.Tables.Clear()
        cboLot.Items.Clear()
        Dim rs As New SATWebSV.SATWebSV
        ds = New DataSet
        ds = rs.selectLot(txtItem.Text)
        For i = 0 To ds.Tables(0).Rows.Count - 1
            cboLot.Items.Add(ds.Tables(0).Rows(i)(1).ToString())
        Next i
        'cboReason.Enabled = False
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        If txtItem.Text <> "" Then
            Call getLot()
        End If
    End Sub

    Private Sub cboLot_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboLot.KeyDown
        If txtItem.Text <> "" Then
            Call getLot()
        End If
    End Sub

    Private Sub cboLot_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboLot.SelectedIndexChanged
        numQty.Value = ds.Tables(0).Rows(cboLot.SelectedIndex)(2).ToString()
    End Sub
End Class