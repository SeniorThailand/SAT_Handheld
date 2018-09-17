<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPicking
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
        Me.txtFromLoc = New System.Windows.Forms.TextBox
        Me.txtToLoc = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTWH = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFWH = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLot = New System.Windows.Forms.TextBox
        Me.nudQty = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSerialBarcode = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnMove = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.txtFromLoc)
        Me.TabPage1.Controls.Add(Me.txtToLoc)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtLot)
        Me.TabPage1.Controls.Add(Me.nudQty)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtItem)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtSerialBarcode)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.btnMove)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 230)
        Me.TabPage1.Text = "Serial"
        '
        'txtFromLoc
        '
        Me.txtFromLoc.BackColor = System.Drawing.Color.Yellow
        Me.txtFromLoc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtFromLoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtFromLoc.Location = New System.Drawing.Point(50, 80)
        Me.txtFromLoc.Name = "txtFromLoc"
        Me.txtFromLoc.Size = New System.Drawing.Size(80, 19)
        Me.txtFromLoc.TabIndex = 56
        '
        'txtToLoc
        '
        Me.txtToLoc.BackColor = System.Drawing.Color.Beige
        Me.txtToLoc.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtToLoc.Location = New System.Drawing.Point(149, 80)
        Me.txtToLoc.Name = "txtToLoc"
        Me.txtToLoc.ReadOnly = True
        Me.txtToLoc.Size = New System.Drawing.Size(87, 19)
        Me.txtToLoc.TabIndex = 53
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(3, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 21)
        Me.Label5.Text = "Loc"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTWH)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtFWH)
        Me.Panel1.Location = New System.Drawing.Point(22, 133)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(201, 50)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 13)
        Me.Label6.Text = "From WH"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTWH
        '
        Me.txtTWH.BackColor = System.Drawing.Color.Yellow
        Me.txtTWH.Location = New System.Drawing.Point(102, 18)
        Me.txtTWH.Name = "txtTWH"
        Me.txtTWH.Size = New System.Drawing.Size(92, 21)
        Me.txtTWH.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(104, 2)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.Text = "To WH"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFWH
        '
        Me.txtFWH.BackColor = System.Drawing.Color.Yellow
        Me.txtFWH.Location = New System.Drawing.Point(5, 18)
        Me.txtFWH.Name = "txtFWH"
        Me.txtFWH.Size = New System.Drawing.Size(87, 21)
        Me.txtFWH.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(5, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.Text = "Lot"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLot
        '
        Me.txtLot.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtLot.Location = New System.Drawing.Point(50, 55)
        Me.txtLot.Name = "txtLot"
        Me.txtLot.Size = New System.Drawing.Size(114, 19)
        Me.txtLot.TabIndex = 45
        '
        'nudQty
        '
        Me.nudQty.Location = New System.Drawing.Point(50, 105)
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New System.Drawing.Size(69, 22)
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
        Me.Label4.Location = New System.Drawing.Point(22, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 18)
        Me.Label4.Text = "Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSerialBarcode
        '
        Me.txtSerialBarcode.BackColor = System.Drawing.Color.Lime
        Me.txtSerialBarcode.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtSerialBarcode.ForeColor = System.Drawing.Color.Black
        Me.txtSerialBarcode.Location = New System.Drawing.Point(20, 7)
        Me.txtSerialBarcode.Name = "txtSerialBarcode"
        Me.txtSerialBarcode.Size = New System.Drawing.Size(144, 19)
        Me.txtSerialBarcode.TabIndex = 13
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(27, 189)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 24)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        '
        'btnMove
        '
        Me.btnMove.Location = New System.Drawing.Point(170, 7)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(52, 46)
        Me.btnMove.TabIndex = 8
        Me.btnMove.Text = "Move"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(124, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.Text = "To"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmPicking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmPicking"
        Me.Text = "Picking & Move Warehouse"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSerialBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents nudQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLot As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtFWH As System.Windows.Forms.TextBox
    Friend WithEvents txtTWH As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFromLoc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtToLoc As System.Windows.Forms.TextBox
End Class
