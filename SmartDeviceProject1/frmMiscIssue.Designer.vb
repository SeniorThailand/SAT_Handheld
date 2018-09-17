<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMiscIssue
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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboReasonCode = New System.Windows.Forms.ComboBox
        Me.txtExpDate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.nupMiscQty = New System.Windows.Forms.NumericUpDown
        Me.txtWhse = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblUM = New System.Windows.Forms.Label
        Me.txtLoc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtThisLot = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtNextLot = New System.Windows.Forms.TextBox
        Me.nudQty = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnProcess = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 253)
        Me.TabControl1.TabIndex = 16
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.cboReasonCode)
        Me.TabPage1.Controls.Add(Me.txtExpDate)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.nupMiscQty)
        Me.TabPage1.Controls.Add(Me.txtWhse)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.lblUM)
        Me.TabPage1.Controls.Add(Me.txtLoc)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.nudQty)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtItem)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtBarcode)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.btnProcess)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 230)
        Me.TabPage1.Text = "MiscIssue"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label9.Location = New System.Drawing.Point(11, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 16)
        Me.Label9.Text = "Reason"
        '
        'cboReasonCode
        '
        Me.cboReasonCode.Location = New System.Drawing.Point(62, 124)
        Me.cboReasonCode.Name = "cboReasonCode"
        Me.cboReasonCode.Size = New System.Drawing.Size(171, 22)
        Me.cboReasonCode.TabIndex = 89
        '
        'txtExpDate
        '
        Me.txtExpDate.Enabled = False
        Me.txtExpDate.Location = New System.Drawing.Point(145, 199)
        Me.txtExpDate.Name = "txtExpDate"
        Me.txtExpDate.Size = New System.Drawing.Size(88, 21)
        Me.txtExpDate.TabIndex = 80
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.Location = New System.Drawing.Point(136, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 18)
        Me.Label8.Text = "U/M"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(3, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.Text = "Misc Qty"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'nupMiscQty
        '
        Me.nupMiscQty.BackColor = System.Drawing.Color.Yellow
        Me.nupMiscQty.Location = New System.Drawing.Point(62, 100)
        Me.nupMiscQty.Name = "nupMiscQty"
        Me.nupMiscQty.Size = New System.Drawing.Size(68, 22)
        Me.nupMiscQty.TabIndex = 73
        '
        'txtWhse
        '
        Me.txtWhse.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtWhse.Enabled = False
        Me.txtWhse.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtWhse.Location = New System.Drawing.Point(170, 53)
        Me.txtWhse.Name = "txtWhse"
        Me.txtWhse.Size = New System.Drawing.Size(63, 19)
        Me.txtWhse.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(84, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.Text = "Exp. Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblUM
        '
        Me.lblUM.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.lblUM.Location = New System.Drawing.Point(136, 81)
        Me.lblUM.Name = "lblUM"
        Me.lblUM.Size = New System.Drawing.Size(28, 18)
        Me.lblUM.Text = "U/M"
        '
        'txtLoc
        '
        Me.txtLoc.BackColor = System.Drawing.Color.White
        Me.txtLoc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtLoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtLoc.Location = New System.Drawing.Point(50, 53)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(114, 19)
        Me.txtLoc.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(3, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 21)
        Me.Label5.Text = "Loc"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtThisLot)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtNextLot)
        Me.Panel1.Location = New System.Drawing.Point(22, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 45)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.Text = "Next Lot"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtThisLot
        '
        Me.txtThisLot.BackColor = System.Drawing.Color.Yellow
        Me.txtThisLot.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtThisLot.Location = New System.Drawing.Point(102, 18)
        Me.txtThisLot.Name = "txtThisLot"
        Me.txtThisLot.Size = New System.Drawing.Size(92, 19)
        Me.txtThisLot.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(104, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.Text = "This Lot"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNextLot
        '
        Me.txtNextLot.BackColor = System.Drawing.Color.Yellow
        Me.txtNextLot.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtNextLot.Location = New System.Drawing.Point(5, 18)
        Me.txtNextLot.Name = "txtNextLot"
        Me.txtNextLot.Size = New System.Drawing.Size(87, 19)
        Me.txtNextLot.TabIndex = 5
        '
        'nudQty
        '
        Me.nudQty.BackColor = System.Drawing.Color.Gainsboro
        Me.nudQty.Location = New System.Drawing.Point(62, 75)
        Me.nudQty.Name = "nudQty"
        Me.nudQty.ReadOnly = True
        Me.nudQty.Size = New System.Drawing.Size(68, 22)
        Me.nudQty.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(6, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 21)
        Me.Label1.Text = "Item"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtItem.Location = New System.Drawing.Point(50, 32)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(114, 19)
        Me.txtItem.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(6, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.Text = "Curr Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtBarcode.ForeColor = System.Drawing.Color.Black
        Me.txtBarcode.Location = New System.Drawing.Point(20, 7)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(144, 19)
        Me.txtBarcode.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(22, 196)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 24)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(170, 7)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(63, 44)
        Me.btnProcess.TabIndex = 8
        Me.btnProcess.Text = "Process"
        '
        'frmMiscIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmMiscIssue"
        Me.Text = "frmMiscIssue"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtThisLot As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNextLot As System.Windows.Forms.TextBox
    Friend WithEvents nudQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnProcess As System.Windows.Forms.Button
    Friend WithEvents lblUM As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtWhse As System.Windows.Forms.TextBox
    Friend WithEvents nupMiscQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtExpDate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboReasonCode As System.Windows.Forms.ComboBox
End Class
