<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmBilletMove
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
        Me.Item = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.dtgMove = New System.Windows.Forms.DataGrid
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblGuide = New System.Windows.Forms.Label
        Me.numQty = New System.Windows.Forms.NumericUpDown
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnMove = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtToLoc = New System.Windows.Forms.TextBox
        Me.txtFromLoc = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtWH = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtItem2 = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtBarcode2 = New System.Windows.Forms.TextBox
        Me.dtgCheck = New System.Windows.Forms.DataGrid
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 256)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Item)
        Me.TabPage1.Controls.Add(Me.txtItem)
        Me.TabPage1.Controls.Add(Me.dtgMove)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.lblGuide)
        Me.TabPage1.Controls.Add(Me.numQty)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnMove)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtToLoc)
        Me.TabPage1.Controls.Add(Me.txtFromLoc)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtWH)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtBarcode)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 233)
        Me.TabPage1.Text = "Main"
        '
        'Item
        '
        Me.Item.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Item.Location = New System.Drawing.Point(10, 53)
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(47, 20)
        Me.Item.Text = "Item"
        Me.Item.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(63, 51)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(105, 21)
        Me.txtItem.TabIndex = 32
        '
        'dtgMove
        '
        Me.dtgMove.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgMove.Location = New System.Drawing.Point(20, 115)
        Me.dtgMove.Name = "dtgMove"
        Me.dtgMove.Size = New System.Drawing.Size(205, 91)
        Me.dtgMove.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.Location = New System.Drawing.Point(7, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.Text = "GuideLoc"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblGuide
        '
        Me.lblGuide.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblGuide.BackColor = System.Drawing.Color.Black
        Me.lblGuide.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblGuide.ForeColor = System.Drawing.Color.Yellow
        Me.lblGuide.Location = New System.Drawing.Point(63, 29)
        Me.lblGuide.Name = "lblGuide"
        Me.lblGuide.Size = New System.Drawing.Size(162, 19)
        Me.lblGuide.Text = "N/A"
        Me.lblGuide.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'numQty
        '
        Me.numQty.BackColor = System.Drawing.Color.Yellow
        Me.numQty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.numQty.Location = New System.Drawing.Point(174, 69)
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(51, 22)
        Me.numQty.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(143, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 20)
        Me.Label7.Text = "Qty"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(156, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Cancel"
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(20, 208)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(71, 22)
        Me.btnMove.TabIndex = 14
        Me.btnMove.Text = "Move"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(136, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 20)
        Me.Label4.Text = "To"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtToLoc
        '
        Me.txtToLoc.BackColor = System.Drawing.Color.Yellow
        Me.txtToLoc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtToLoc.Location = New System.Drawing.Point(156, 94)
        Me.txtToLoc.Name = "txtToLoc"
        Me.txtToLoc.Size = New System.Drawing.Size(71, 19)
        Me.txtToLoc.TabIndex = 6
        '
        'txtFromLoc
        '
        Me.txtFromLoc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtFromLoc.Location = New System.Drawing.Point(63, 94)
        Me.txtFromLoc.Name = "txtFromLoc"
        Me.txtFromLoc.Size = New System.Drawing.Size(71, 19)
        Me.txtFromLoc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(7, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.Text = "Loc From"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtWH
        '
        Me.txtWH.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtWH.Location = New System.Drawing.Point(63, 73)
        Me.txtWH.Name = "txtWH"
        Me.txtWH.Size = New System.Drawing.Size(56, 19)
        Me.txtWH.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(20, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 20)
        Me.Label2.Text = "W/H"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(7, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.Text = "Barcode"
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode.Location = New System.Drawing.Point(63, 4)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(162, 21)
        Me.txtBarcode.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtItem2)
        Me.TabPage2.Controls.Add(Me.btnClear)
        Me.TabPage2.Controls.Add(Me.txtBarcode2)
        Me.TabPage2.Controls.Add(Me.dtgCheck)
        Me.TabPage2.Location = New System.Drawing.Point(0, 0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(240, 233)
        Me.TabPage2.Text = "Check"
        '
        'txtItem2
        '
        Me.txtItem2.Location = New System.Drawing.Point(7, 34)
        Me.txtItem2.Name = "txtItem2"
        Me.txtItem2.Size = New System.Drawing.Size(100, 21)
        Me.txtItem2.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(140, 32)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        '
        'txtBarcode2
        '
        Me.txtBarcode2.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode2.Location = New System.Drawing.Point(7, 8)
        Me.txtBarcode2.Name = "txtBarcode2"
        Me.txtBarcode2.Size = New System.Drawing.Size(210, 21)
        Me.txtBarcode2.TabIndex = 1
        '
        'dtgCheck
        '
        Me.dtgCheck.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgCheck.Location = New System.Drawing.Point(7, 61)
        Me.dtgCheck.Name = "dtgCheck"
        Me.dtgCheck.Size = New System.Drawing.Size(211, 169)
        Me.dtgCheck.TabIndex = 0
        '
        'frmBilletMove
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmBilletMove"
        Me.Text = "frmBilletMove"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtToLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtFromLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtWH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblGuide As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtgMove As System.Windows.Forms.DataGrid
    Friend WithEvents Item As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents dtgCheck As System.Windows.Forms.DataGrid
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtBarcode2 As System.Windows.Forms.TextBox
    Friend WithEvents txtItem2 As System.Windows.Forms.TextBox
End Class
