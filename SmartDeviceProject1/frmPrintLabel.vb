Public Class frmPrintLabel

    Private Sub txtBarcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress

        If e.KeyChar = Chr(13) Then

            Try

                Dim strPO As String = ""
                Dim strLine As String = ""
                Dim qty As Integer

                Dim arrBarcode As String()

                arrBarcode = Split(txtBarcode.Text, ".")
                If UBound(arrBarcode) = 2 Then
                    strPO = arrBarcode(0)
                    strLine = arrBarcode(1)
                    qty = arrBarcode(2)

                    txtPO.Text = strPO
                    txtPOLine.Text = strLine
                    numQty.Value = qty

                    'End If

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

            Call ws.PrintLabelBillet(txtPO.Text, txtPOLine.Text, numQty.Value)

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
        txtPO.Text = ""
        txtPOLine.Text = ""
        numQty.Value = 0
        txtBarcode.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call ClearData()
    End Sub

    Private Sub txtBarcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarcode.TextChanged

    End Sub
End Class