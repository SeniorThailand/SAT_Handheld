<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmPrintDirect
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
        Me.numQty = New System.Windows.Forms.NumericUpDown
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.btnFind = New System.Windows.Forms.Button
        Me.cboLot = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'numQty
        '
        Me.numQty.Location = New System.Drawing.Point(63, 94)
        Me.numQty.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.numQty.Name = "numQty"
        Me.numQty.Size = New System.Drawing.Size(100, 22)
        Me.numQty.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label4.Location = New System.Drawing.Point(7, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 20)
        Me.Label4.Text = "Qty"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(7, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.Text = "Lot"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(7, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 20)
        Me.Label2.Text = "Item"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(63, 40)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(100, 21)
        Me.txtItem.TabIndex = 19
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(147, 123)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(78, 34)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(63, 123)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(78, 34)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "Print"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.Text = "Barcode"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode.Location = New System.Drawing.Point(63, 13)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(162, 21)
        Me.txtBarcode.TabIndex = 16
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(169, 41)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(39, 20)
        Me.btnFind.TabIndex = 26
        Me.btnFind.Text = "Find"
        '
        'cboLot
        '
        Me.cboLot.Location = New System.Drawing.Point(63, 68)
        Me.cboLot.Name = "cboLot"
        Me.cboLot.Size = New System.Drawing.Size(130, 22)
        Me.cboLot.TabIndex = 27
        '
        'frmPrintDirect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.cboLot)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.numQty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmPrintDirect"
        Me.Text = "frmPrintDirect"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents numQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents cboLot As System.Windows.Forms.ComboBox
End Class
