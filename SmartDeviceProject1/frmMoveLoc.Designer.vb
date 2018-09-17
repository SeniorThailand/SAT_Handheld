<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMoveLoc
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
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtLot = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtWhse = New System.Windows.Forms.TextBox
        Me.nudQty = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCancel = New System.Windows.Forms.Button
        Me.txtSuffix = New System.Windows.Forms.TextBox
        Me.btnMove = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtJob = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtItem2 = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtBarcode2 = New System.Windows.Forms.TextBox
        Me.dtgCheck = New System.Windows.Forms.DataGrid
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode.Location = New System.Drawing.Point(70, 7)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(158, 21)
        Me.txtBarcode.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 242)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtLot)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtItem)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtWhse)
        Me.TabPage1.Controls.Add(Me.nudQty)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtCancel)
        Me.TabPage1.Controls.Add(Me.txtSuffix)
        Me.TabPage1.Controls.Add(Me.btnMove)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtJob)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtBarcode)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 219)
        Me.TabPage1.Text = "Move Location"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(11, 202)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(223, 15)
        Me.Label8.Text = "*Label will be printed at STOCK-PACKING"
        '
        'txtLot
        '
        Me.txtLot.Location = New System.Drawing.Point(178, 88)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(50, 21)
        Me.txtLot.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(7, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 21)
        Me.Label7.Text = "Item"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(70, 88)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(104, 21)
        Me.txtItem.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(138, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.Text = "Whse"
        '
        'txtWhse
        '
        Me.txtWhse.Location = New System.Drawing.Point(178, 61)
        Me.txtWhse.Name = "txtWhse"
        Me.txtWhse.Size = New System.Drawing.Size(50, 21)
        Me.txtWhse.TabIndex = 27
        '
        'nudQty
        '
        Me.nudQty.Location = New System.Drawing.Point(70, 58)
        Me.nudQty.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New System.Drawing.Size(63, 22)
        Me.nudQty.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 21)
        Me.Label5.Text = "Qty"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCancel
        '
        Me.txtCancel.Location = New System.Drawing.Point(126, 163)
        Me.txtCancel.Name = "txtCancel"
        Me.txtCancel.Size = New System.Drawing.Size(68, 35)
        Me.txtCancel.TabIndex = 14
        Me.txtCancel.Text = "Cancel"
        '
        'txtSuffix
        '
        Me.txtSuffix.Location = New System.Drawing.Point(187, 34)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(41, 21)
        Me.txtSuffix.TabIndex = 10
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(48, 163)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(72, 35)
        Me.btnMove.TabIndex = 6
        Me.btnMove.Text = "Process"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.Text = "Job"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtJob
        '
        Me.txtJob.Location = New System.Drawing.Point(70, 34)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Size = New System.Drawing.Size(111, 21)
        Me.txtJob.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.Text = "Barcode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtFrom)
        Me.Panel1.Controls.Add(Me.txtTo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(7, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 47)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(29, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.Text = "From"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFrom
        '
        Me.txtFrom.BackColor = System.Drawing.Color.Yellow
        Me.txtFrom.Location = New System.Drawing.Point(4, 18)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(109, 21)
        Me.txtFrom.TabIndex = 5
        '
        'txtTo
        '
        Me.txtTo.BackColor = System.Drawing.Color.Yellow
        Me.txtTo.Location = New System.Drawing.Point(119, 18)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(108, 21)
        Me.txtTo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(125, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.Text = "To"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtItem2)
        Me.TabPage2.Controls.Add(Me.btnClear)
        Me.TabPage2.Controls.Add(Me.txtBarcode2)
        Me.TabPage2.Controls.Add(Me.dtgCheck)
        Me.TabPage2.Location = New System.Drawing.Point(0, 0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(232, 216)
        Me.TabPage2.Text = "Check"
        '
        'txtItem2
        '
        Me.txtItem2.Location = New System.Drawing.Point(15, 33)
        Me.txtItem2.Name = "txtItem2"
        Me.txtItem2.Size = New System.Drawing.Size(100, 21)
        Me.txtItem2.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(148, 31)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        '
        'txtBarcode2
        '
        Me.txtBarcode2.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode2.Location = New System.Drawing.Point(15, 7)
        Me.txtBarcode2.Name = "txtBarcode2"
        Me.txtBarcode2.Size = New System.Drawing.Size(210, 21)
        Me.txtBarcode2.TabIndex = 5
        '
        'dtgCheck
        '
        Me.dtgCheck.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgCheck.Location = New System.Drawing.Point(15, 60)
        Me.dtgCheck.Name = "dtgCheck"
        Me.dtgCheck.Size = New System.Drawing.Size(211, 153)
        Me.dtgCheck.TabIndex = 4
        '
        'frmMoveLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmMoveLoc"
        Me.Text = "Move Location"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtJob As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtCancel As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtItem2 As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtBarcode2 As System.Windows.Forms.TextBox
    Friend WithEvents dtgCheck As System.Windows.Forms.DataGrid
    Friend WithEvents nudQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtWhse As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
