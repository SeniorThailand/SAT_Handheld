<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmIHCCheck
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
        Me.dtgJob = New System.Windows.Forms.DataGrid
        Me.txtJob = New System.Windows.Forms.TextBox
        Me.txtSuffix = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.nupQty = New System.Windows.Forms.NumericUpDown
        Me.btnClear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtBarcode
        '
        Me.txtBarcode.BackColor = System.Drawing.Color.Lime
        Me.txtBarcode.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtBarcode.Location = New System.Drawing.Point(12, 3)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(212, 19)
        Me.txtBarcode.TabIndex = 0
        '
        'dtgJob
        '
        Me.dtgJob.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dtgJob.Location = New System.Drawing.Point(12, 90)
        Me.dtgJob.Name = "dtgJob"
        Me.dtgJob.Size = New System.Drawing.Size(212, 143)
        Me.dtgJob.TabIndex = 13
        '
        'txtJob
        '
        Me.txtJob.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtJob.Location = New System.Drawing.Point(47, 28)
        Me.txtJob.Name = "txtJob"
        Me.txtJob.Size = New System.Drawing.Size(111, 19)
        Me.txtJob.TabIndex = 14
        '
        'txtSuffix
        '
        Me.txtSuffix.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.txtSuffix.Location = New System.Drawing.Point(164, 28)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(60, 19)
        Me.txtSuffix.TabIndex = 16
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(164, 53)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 31)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label1.Location = New System.Drawing.Point(21, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 15)
        Me.Label1.Text = "Qty"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(21, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 18)
        Me.Label2.Text = "Job"
        '
        'nupQty
        '
        Me.nupQty.BackColor = System.Drawing.Color.Yellow
        Me.nupQty.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular)
        Me.nupQty.Location = New System.Drawing.Point(47, 53)
        Me.nupQty.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nupQty.Name = "nupQty"
        Me.nupQty.Size = New System.Drawing.Size(64, 20)
        Me.nupQty.TabIndex = 28
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(86, 239)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 20)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "CLEAR"
        '
        'frmIHCCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.nupQty)
        Me.Controls.Add(Me.txtJob)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtSuffix)
        Me.Controls.Add(Me.dtgJob)
        Me.Controls.Add(Me.txtBarcode)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmIHCCheck"
        Me.Text = "frmIHCCheck"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents dtgJob As System.Windows.Forms.DataGrid
    Friend WithEvents txtJob As System.Windows.Forms.TextBox
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nupQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnClear As System.Windows.Forms.Button
End Class
