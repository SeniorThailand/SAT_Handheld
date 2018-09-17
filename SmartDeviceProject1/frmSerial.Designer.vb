<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmSerial
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
        Me.components = New System.ComponentModel.Container
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.InputPanel1 = New Microsoft.WindowsCE.Forms.InputPanel(Me.components)
        Me.dtgSerial = New System.Windows.Forms.DataGrid
        Me.txtSerialBarcode = New System.Windows.Forms.TextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblQtyRemain = New System.Windows.Forms.Label
        Me.chkPrint = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCofC = New System.Windows.Forms.TextBox
        Me.txtTO = New System.Windows.Forms.TextBox
        Me.btnRemove = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSBox = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(20, 203)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 24)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(170, 7)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(52, 41)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        '
        'dtgSerial
        '
        Me.dtgSerial.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgSerial.Location = New System.Drawing.Point(19, 99)
        Me.dtgSerial.Name = "dtgSerial"
        Me.dtgSerial.Size = New System.Drawing.Size(203, 98)
        Me.dtgSerial.TabIndex = 12
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 253)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lblQtyRemain)
        Me.TabPage1.Controls.Add(Me.chkPrint)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.txtCofC)
        Me.TabPage1.Controls.Add(Me.txtTO)
        Me.TabPage1.Controls.Add(Me.btnRemove)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtSBox)
        Me.TabPage1.Controls.Add(Me.txtSerialBarcode)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.dtgSerial)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 230)
        Me.TabPage1.Text = "Serial"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(17, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 14)
        Me.Label2.Text = "CofC"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(84, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.Text = "Qty Remain"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblQtyRemain
        '
        Me.lblQtyRemain.ForeColor = System.Drawing.Color.Red
        Me.lblQtyRemain.Location = New System.Drawing.Point(97, 213)
        Me.lblQtyRemain.Name = "lblQtyRemain"
        Me.lblQtyRemain.Size = New System.Drawing.Size(46, 16)
        Me.lblQtyRemain.Text = "xxx"
        Me.lblQtyRemain.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'chkPrint
        '
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.Location = New System.Drawing.Point(170, 52)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(63, 20)
        Me.chkPrint.TabIndex = 39
        Me.chkPrint.Text = "Print"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 21)
        Me.Label1.Text = "TO Num"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtCofC
        '
        Me.txtCofC.BackColor = System.Drawing.Color.White
        Me.txtCofC.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtCofC.Location = New System.Drawing.Point(64, 74)
        Me.txtCofC.Name = "txtCofC"
        Me.txtCofC.Size = New System.Drawing.Size(158, 19)
        Me.txtCofC.TabIndex = 37
        '
        'txtTO
        '
        Me.txtTO.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtTO.Location = New System.Drawing.Point(64, 32)
        Me.txtTO.Name = "txtTO"
        Me.txtTO.Size = New System.Drawing.Size(100, 19)
        Me.txtTO.TabIndex = 36
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(160, 203)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(62, 24)
        Me.btnRemove.TabIndex = 34
        Me.btnRemove.Text = "Remove"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(35, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 18)
        Me.Label4.Text = "Box"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtSBox
        '
        Me.txtSBox.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtSBox.Location = New System.Drawing.Point(64, 53)
        Me.txtSBox.Name = "txtSBox"
        Me.txtSBox.Size = New System.Drawing.Size(100, 19)
        Me.txtSBox.TabIndex = 33
        '
        'frmSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmSerial"
        Me.Text = "Packing System"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents InputPanel1 As Microsoft.WindowsCE.Forms.InputPanel
    Friend WithEvents dtgSerial As System.Windows.Forms.DataGrid
    Friend WithEvents txtSerialBarcode As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSBox As System.Windows.Forms.TextBox
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCofC As System.Windows.Forms.TextBox
    Friend WithEvents txtTO As System.Windows.Forms.TextBox
    Friend WithEvents chkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents lblQtyRemain As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
