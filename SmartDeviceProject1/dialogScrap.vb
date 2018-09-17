Imports System.Data

Public Class dialogScrap
    Dim ds As DataSet
    Dim dsf As DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmUnpost.strScrap = cboReasonCode.ValueMember.ToString
        frmUnpost.strCause = cboFaultCode.ValueMember.ToString
        frmUnpost.strFeature = txtFeatureCode.ToString
        Me.Close()
    End Sub

    Private Sub dialogScrap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CreateReason()
    End Sub
    Private Sub CreateReason()
        Dim rs As New SATWebSV.SATWebSV
        ds = New DataSet
        ds = rs.selectReason()
        'For i = 0 To ds.Tables(0).Rows.Count - 1
        '    cboReasonCode.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
        '    Me.cboReasonCode.ValueMember = cboReasonCode.Items.Add(ds.Tables(0).Rows(i)(0).ToString())
        'Next i

        '--------------------------------------
        cboReasonCode.DataSource = ds.Tables(0)
        cboReasonCode.ValueMember = "reason_code"
        cboReasonCode.DisplayMember = "description"


        dsf = New DataSet
        dsf = rs.selectFaultCode()

        cboFaultCode.DataSource = dsf.Tables(0)
        cboFaultCode.ValueMember = "cause_code"
        cboFaultCode.DisplayMember = "description"
    End Sub
End Class