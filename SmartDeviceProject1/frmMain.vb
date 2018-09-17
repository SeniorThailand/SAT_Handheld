Public Class frmMain
    'LIVE
    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTranfer.Click
        Dim f As New frmTransfer
        f.Show()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure to exit?", "Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private ReadOnly VK_OFF As Byte = &HDF
    Private ReadOnly KEYEVENTF_KEYUP As Byte = &H2

    <System.Runtime.InteropServices.DllImport("coredll.dll", SetLastError:=True)> _
    Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    End Sub

    Private Sub btnShutdown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShutdown.Click
        Dim f As New frmSerial
        f.Show()
        'If MessageBox.Show("Are you sure to shutdown?", "Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
        '    Call keybd_event(VK_OFF, 0, 0, 0)
        '    Call keybd_event(VK_OFF, 0, KEYEVENTF_KEYUP, 0)
        'End If
    End Sub

    Private Sub btnTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnposted.Click
        Dim f As New frmUnpost
        f.Show()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMoveLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveLoc.Click
        Dim f As New frmMoveLoc
        f.Show()
    End Sub

    Private Sub btnPicking_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPicking.Click
        Dim f As New frmPicking
        f.Show()
    End Sub

    Private Sub btnMiscIssue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMiscIssue.Click
        Dim f As New frmMiscIssue
        f.Show()
    End Sub

    Private Sub btnMoveBillet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveBillet.Click
        'Dim f As New sub_MoveBillet
        'f.Show()
        Dim ws As New SATWebSV.SATWebSV
        ws.closeConnection()

    End Sub

End Class
