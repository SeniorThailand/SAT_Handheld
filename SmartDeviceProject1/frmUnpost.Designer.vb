<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmUnpost
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.txtJobOper = New System.Windows.Forms.TextBox
        Me.dgName = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.numQtyComplete = New System.Windows.Forms.NumericUpDown
        Me.numQtyMove = New System.Windows.Forms.NumericUpDown
        Me.numQtyScrap = New System.Windows.Forms.NumericUpDown
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtJob = New System.Windows.Forms.TextBox
        Me.txtSuffix = New System.Windows.Forms.TextBox
        Me.txtOper = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblSts = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tabInput = New System.Windows.Forms.TabPage
        Me.tabDetail = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBarcode2 = New System.Windows.Forms.TextBox
        Me.cboReason = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabInput.SuspendLayout()
        Me.tabDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtJobOper
        '
        Me.txtJobOper.BackColor = System.Drawing.Color.Lime
        Me.txtJobOper.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtJobOper.ForeColor = System.Drawing.Color.Black
        Me.txtJobOper.Location = New System.Drawing.Point(57, 10)
        Me.txtJobOper.Name = "txtJobOper"
        Me.txtJobOper.Size = New System.Drawing.Size(154, 19)
        Me.txtJobOper.TabIndex = 0
        '
        'dgName
        '
        Me.dgName.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgName.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.dgName.Location = New System.Drawing.Point(7, 28)
        Me.dgName.Name = "dgName"
        Me.dgName.Size = New System.Drawing.Size(214, 130)
        Me.dgName.TabIndex = 3
        Me.dgName.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(138, 107)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(73, 41)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(7, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.Text = "Barcode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(3, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 19)
        Me.Label2.Text = "Complete"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(8, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 19)
        Me.Label3.Text = "Scrap"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(8, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 19)
        Me.Label4.Text = "Move"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'numQtyComplete
        '
        Me.numQtyComplete.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.numQtyComplete.BackColor = System.Drawing.Color.Yellow
        Me.numQtyComplete.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.numQtyComplete.Location = New System.Drawing.Point(51, 8)
        Me.numQtyComplete.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numQtyComplete.Name = "numQtyComplete"
        Me.numQtyComplete.Size = New System.Drawing.Size(74, 19)
        Me.numQtyComplete.TabIndex = 15
        '
        'numQtyMove
        '
        Me.numQtyMove.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.numQtyMove.BackColor = System.Drawing.Color.Yellow
        Me.numQtyMove.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.numQtyMove.Location = New System.Drawing.Point(51, 51)
        Me.numQtyMove.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numQtyMove.Name = "numQtyMove"
        Me.numQtyMove.ReadOnly = True
        Me.numQtyMove.Size = New System.Drawing.Size(74, 19)
        Me.numQtyMove.TabIndex = 16
        '
        'numQtyScrap
        '
        Me.numQtyScrap.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.numQtyScrap.BackColor = System.Drawing.Color.Yellow
        Me.numQtyScrap.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.numQtyScrap.Location = New System.Drawing.Point(51, 29)
        Me.numQtyScrap.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.numQtyScrap.Name = "numQtyScrap"
        Me.numQtyScrap.Size = New System.Drawing.Size(74, 19)
        Me.numQtyScrap.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.numQtyMove)
        Me.Panel1.Controls.Add(Me.numQtyScrap)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.numQtyComplete)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(7, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 77)
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(138, 85)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 19)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        '
        'txtJob
        '
        Me.txtJob.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtJob.Location = New System.Drawing.Point(57, 31)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Size = New System.Drawing.Size(116, 19)
        Me.txtJob.TabIndex = 9
        '
        'txtSuffix
        '
        Me.txtSuffix.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtSuffix.Location = New System.Drawing.Point(175, 31)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(36, 19)
        Me.txtSuffix.TabIndex = 10
        '
        'txtOper
        '
        Me.txtOper.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtOper.Location = New System.Drawing.Point(57, 52)
        Me.txtOper.Name = "txtOper"
        Me.txtOper.Size = New System.Drawing.Size(45, 19)
        Me.txtOper.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(7, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.Text = "IHC No"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(7, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 18)
        Me.Label6.Text = "Oper"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSts
        '
        Me.lblSts.BackColor = System.Drawing.Color.Black
        Me.lblSts.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lblSts.ForeColor = System.Drawing.Color.White
        Me.lblSts.Location = New System.Drawing.Point(108, 54)
        Me.lblSts.Name = "lblSts"
        Me.lblSts.Size = New System.Drawing.Size(102, 17)
        Me.lblSts.Text = "Ready"
        Me.lblSts.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabInput)
        Me.TabControl1.Controls.Add(Me.tabDetail)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 198)
        Me.TabControl1.TabIndex = 15
        '
        'tabInput
        '
        Me.tabInput.Controls.Add(Me.Label1)
        Me.tabInput.Controls.Add(Me.lblSts)
        Me.tabInput.Controls.Add(Me.txtJobOper)
        Me.tabInput.Controls.Add(Me.Label6)
        Me.tabInput.Controls.Add(Me.btnSave)
        Me.tabInput.Controls.Add(Me.Label5)
        Me.tabInput.Controls.Add(Me.Panel1)
        Me.tabInput.Controls.Add(Me.txtOper)
        Me.tabInput.Controls.Add(Me.btnClear)
        Me.tabInput.Controls.Add(Me.txtSuffix)
        Me.tabInput.Controls.Add(Me.txtJob)
        Me.tabInput.Location = New System.Drawing.Point(0, 0)
        Me.tabInput.Name = "tabInput"
        Me.tabInput.Size = New System.Drawing.Size(240, 175)
        Me.tabInput.Text = "Unpost"
        '
        'tabDetail
        '
        Me.tabDetail.Controls.Add(Me.Label7)
        Me.tabDetail.Controls.Add(Me.txtBarcode2)
        Me.tabDetail.Controls.Add(Me.dgName)
        Me.tabDetail.Location = New System.Drawing.Point(0, 0)
        Me.tabDetail.Name = "tabDetail"
        Me.tabDetail.Size = New System.Drawing.Size(232, 172)
        Me.tabDetail.Text = "Detail"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(8, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.Text = "Barcode"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBarcode2
        '
        Me.txtBarcode2.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtBarcode2.ForeColor = System.Drawing.Color.Black
        Me.txtBarcode2.Location = New System.Drawing.Point(58, 7)
        Me.txtBarcode2.Name = "txtBarcode2"
        Me.txtBarcode2.Size = New System.Drawing.Size(163, 19)
        Me.txtBarcode2.TabIndex = 4
        '
        'cboReason
        '
        Me.cboReason.Enabled = False
        Me.cboReason.Location = New System.Drawing.Point(15, 226)
        Me.cboReason.Name = "cboReason"
        Me.cboReason.Size = New System.Drawing.Size(61, 22)
        Me.cboReason.TabIndex = 16
        Me.cboReason.Visible = False
        '
        'frmUnpost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.cboReason)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmUnpost"
        Me.Text = "SAT-Unposted Job V1.1"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabInput.ResumeLayout(False)
        Me.tabDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtJobOper As System.Windows.Forms.TextBox
    Friend WithEvents dgName As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents numQtyComplete As System.Windows.Forms.NumericUpDown
    Friend WithEvents numQtyMove As System.Windows.Forms.NumericUpDown
    Friend WithEvents numQtyScrap As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtJob As System.Windows.Forms.TextBox
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents txtOper As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSts As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabInput As System.Windows.Forms.TabPage
    Friend WithEvents tabDetail As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode2 As System.Windows.Forms.TextBox
    Friend WithEvents cboReason As System.Windows.Forms.ComboBox
End Class
