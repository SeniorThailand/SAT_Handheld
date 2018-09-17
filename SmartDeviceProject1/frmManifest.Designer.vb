<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmManifest
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtLine1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLine2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLine3 = New System.Windows.Forms.TextBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tab1 = New System.Windows.Forms.TabPage
        Me.lblResult = New System.Windows.Forms.Label
        Me.tab2 = New System.Windows.Forms.TabPage
        Me.TabControl1.SuspendLayout()
        Me.tab1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(9, 9)
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
        Me.txtBarcode.Location = New System.Drawing.Point(59, 8)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(174, 19)
        Me.txtBarcode.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label5.Location = New System.Drawing.Point(9, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 18)
        Me.Label5.Text = "Line1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLine1
        '
        Me.txtLine1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtLine1.Location = New System.Drawing.Point(59, 37)
        Me.txtLine1.Name = "txtLine1"
        Me.txtLine1.Size = New System.Drawing.Size(174, 19)
        Me.txtLine1.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(9, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 18)
        Me.Label2.Text = "Line2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLine2
        '
        Me.txtLine2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtLine2.Location = New System.Drawing.Point(59, 62)
        Me.txtLine2.Name = "txtLine2"
        Me.txtLine2.Size = New System.Drawing.Size(174, 19)
        Me.txtLine2.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label3.Location = New System.Drawing.Point(9, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 18)
        Me.Label3.Text = "Line3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtLine3
        '
        Me.txtLine3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtLine3.Location = New System.Drawing.Point(59, 87)
        Me.txtLine3.Name = "txtLine3"
        Me.txtLine3.Size = New System.Drawing.Size(174, 19)
        Me.txtLine3.TabIndex = 18
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(161, 112)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 33)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "Cancel"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(59, 112)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 33)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab1)
        Me.TabControl1.Controls.Add(Me.tab2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(240, 188)
        Me.TabControl1.TabIndex = 22
        '
        'tab1
        '
        Me.tab1.Controls.Add(Me.lblResult)
        Me.tab1.Controls.Add(Me.txtBarcode)
        Me.tab1.Controls.Add(Me.btnSave)
        Me.tab1.Controls.Add(Me.Label1)
        Me.tab1.Controls.Add(Me.btnCancel)
        Me.tab1.Controls.Add(Me.txtLine1)
        Me.tab1.Controls.Add(Me.Label3)
        Me.tab1.Controls.Add(Me.Label5)
        Me.tab1.Controls.Add(Me.txtLine3)
        Me.tab1.Controls.Add(Me.txtLine2)
        Me.tab1.Controls.Add(Me.Label2)
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(240, 165)
        Me.tab1.Text = "Input"
        '
        'lblResult
        '
        Me.lblResult.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.lblResult.ForeColor = System.Drawing.Color.Black
        Me.lblResult.Location = New System.Drawing.Point(59, 148)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(174, 14)
        Me.lblResult.Text = "PROCESSING.."
        '
        'tab2
        '
        Me.tab2.Location = New System.Drawing.Point(0, 0)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(232, 162)
        Me.tab2.Text = "Output"
        '
        'frmManifest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TabControl1)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmManifest"
        Me.Text = "frmManifest"
        Me.TabControl1.ResumeLayout(False)
        Me.tab1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLine1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLine2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLine3 As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab1 As System.Windows.Forms.TabPage
    Friend WithEvents tab2 As System.Windows.Forms.TabPage
    Friend WithEvents lblResult As System.Windows.Forms.Label
End Class
