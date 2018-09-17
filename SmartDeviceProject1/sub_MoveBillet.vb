Public Class sub_MoveBillet

    Private Sub btnMoveBillet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveBillet.Click
        Dim f As New frmBilletMove
        f.Show()
    End Sub

    Private Sub btnPrintLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintLabel.Click
        Dim f As New frmPrintLabel
        f.Show()
    End Sub

    Private Sub btnPrintDirect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintDirect.Click
        Dim f As New frmPrintDirect
        f.Show()
    End Sub
End Class