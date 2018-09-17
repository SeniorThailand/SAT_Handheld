<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmTransfer
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
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.InputPanel1 = New Microsoft.WindowsCE.Forms.InputPanel(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.txtTO = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtgJobItem = New System.Windows.Forms.DataGrid
        Me.btnRemove = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.chkPrint = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtBox = New System.Windows.Forms.TextBox
        Me.nupQty = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBarcode2 = New System.Windows.Forms.TextBox
        Me.dtgName = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnClear3 = New System.Windows.Forms.Button
        Me.lblPrint = New System.Windows.Forms.Label
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBarcode3 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTO3 = New System.Windows.Forms.TextBox
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(179, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(53, 40)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "SAVE"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(7, 160)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 20)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "CLEAR"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(7, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.Text = "Barcode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtBarcode.ForeColor = System.Drawing.Color.Black
        Me.txtBarcode.Location = New System.Drawing.Point(51, 4)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(125, 19)
        Me.txtBarcode.TabIndex = 11
        '
        'txtTO
        '
        Me.txtTO.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtTO.Location = New System.Drawing.Point(51, 25)
        Me.txtTO.Name = "txtTO"
        Me.txtTO.Size = New System.Drawing.Size(71, 19)
        Me.txtTO.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(8, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 18)
        Me.Label2.Text = "TO No."
        '
        'dtgJobItem
        '
        Me.dtgJobItem.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgJobItem.Location = New System.Drawing.Point(7, 50)
        Me.dtgJobItem.Name = "dtgJobItem"
        Me.dtgJobItem.Size = New System.Drawing.Size(225, 102)
        Me.dtgJobItem.TabIndex = 18
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(168, 158)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(64, 20)
        Me.btnRemove.TabIndex = 22
        Me.btnRemove.Text = "REMOVE"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 230)
        Me.TabControl1.TabIndex = 25
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.chkPrint)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtBox)
        Me.TabPage1.Controls.Add(Me.nupQty)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnRemove)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.dtgJobItem)
        Me.TabPage1.Controls.Add(Me.txtBarcode)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtTO)
        Me.TabPage1.Location = New System.Drawing.Point(0, 0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(240, 207)
        Me.TabPage1.Text = "Transfer"
        '
        'chkPrint
        '
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.Location = New System.Drawing.Point(7, 185)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(100, 20)
        Me.chkPrint.TabIndex = 35
        Me.chkPrint.Text = "Print"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(124, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 18)
        Me.Label4.Text = "Box"
        '
        'txtBox
        '
        Me.txtBox.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtBox.Location = New System.Drawing.Point(148, 25)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(28, 19)
        Me.txtBox.TabIndex = 31
        '
        'nupQty
        '
        Me.nupQty.BackColor = System.Drawing.Color.Yellow
        Me.nupQty.Location = New System.Drawing.Point(108, 158)
        Me.nupQty.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nupQty.Name = "nupQty"
        Me.nupQty.Size = New System.Drawing.Size(54, 22)
        Me.nupQty.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(76, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.Text = "Qty"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtBarcode2)
        Me.TabPage2.Controls.Add(Me.dtgName)
        Me.TabPage2.Location = New System.Drawing.Point(0, 0)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(232, 204)
        Me.TabPage2.Text = "History"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(14, 8)
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
        Me.txtBarcode2.Location = New System.Drawing.Point(64, 7)
        Me.txtBarcode2.Name = "txtBarcode2"
        Me.txtBarcode2.Size = New System.Drawing.Size(163, 19)
        Me.txtBarcode2.TabIndex = 7
        '
        'dtgName
        '
        Me.dtgName.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgName.Font = New System.Drawing.Font("Tahoma", 7.0!, System.Drawing.FontStyle.Regular)
        Me.dtgName.Location = New System.Drawing.Point(13, 38)
        Me.dtgName.Name = "dtgName"
        Me.dtgName.Size = New System.Drawing.Size(214, 147)
        Me.dtgName.TabIndex = 6
        Me.dtgName.TableStyles.Add(Me.DataGridTableStyle1)
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnClear3)
        Me.TabPage3.Controls.Add(Me.lblPrint)
        Me.TabPage3.Controls.Add(Me.btnPrint)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.txtBarcode3)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.txtTO3)
        Me.TabPage3.Location = New System.Drawing.Point(0, 0)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(232, 204)
        Me.TabPage3.Text = "PrintTag"
        '
        'btnClear3
        '
        Me.btnClear3.Location = New System.Drawing.Point(179, 53)
        Me.btnClear3.Name = "btnClear3"
        Me.btnClear3.Size = New System.Drawing.Size(52, 31)
        Me.btnClear3.TabIndex = 29
        Me.btnClear3.Text = "Clear"
        '
        'lblPrint
        '
        Me.lblPrint.Font = New System.Drawing.Font("Tahoma", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrint.Location = New System.Drawing.Point(20, 89)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(212, 50)
        Me.lblPrint.Text = "Stand by"
        Me.lblPrint.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(179, 7)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(53, 40)
        Me.btnPrint.TabIndex = 26
        Me.btnPrint.Text = "PRINT"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(9, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 18)
        Me.Label5.Text = "Barcode"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBarcode3
        '
        Me.txtBarcode3.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtBarcode3.ForeColor = System.Drawing.Color.Black
        Me.txtBarcode3.Location = New System.Drawing.Point(53, 7)
        Me.txtBarcode3.Name = "txtBarcode3"
        Me.txtBarcode3.Size = New System.Drawing.Size(125, 19)
        Me.txtBarcode3.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(10, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 18)
        Me.Label6.Text = "TO No."
        '
        'txtTO3
        '
        Me.txtTO3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtTO3.Location = New System.Drawing.Point(53, 28)
        Me.txtTO3.Name = "txtTO3"
        Me.txtTO3.Size = New System.Drawing.Size(125, 19)
        Me.txtTO3.TabIndex = 23
        '
        'frmTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmTransfer"
        Me.Text = "SAT-TOI V1.1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents InputPanel1 As Microsoft.WindowsCE.Forms.InputPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents txtTO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtgJobItem As System.Windows.Forms.DataGrid
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode2 As System.Windows.Forms.TextBox
    Friend WithEvents dtgName As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents nupQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBox As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTO3 As System.Windows.Forms.TextBox
    Friend WithEvents lblPrint As System.Windows.Forms.Label
    Friend WithEvents btnClear3 As System.Windows.Forms.Button
    Friend WithEvents chkPrint As System.Windows.Forms.CheckBox
End Class
