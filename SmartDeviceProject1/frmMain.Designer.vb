<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.btnTranfer = New System.Windows.Forms.Button
        Me.btnShutdown = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnUnposted = New System.Windows.Forms.Button
        Me.ptbLoco = New System.Windows.Forms.PictureBox
        Me.btnMoveLoc = New System.Windows.Forms.Button
        Me.btnPicking = New System.Windows.Forms.Button
        Me.btnMoveBillet = New System.Windows.Forms.Button
        Me.btnMiscIssue = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnTranfer
        '
        Me.btnTranfer.Location = New System.Drawing.Point(28, 87)
        Me.btnTranfer.Name = "btnTranfer"
        Me.btnTranfer.Size = New System.Drawing.Size(86, 27)
        Me.btnTranfer.TabIndex = 1
        Me.btnTranfer.Text = "Transfer"
        '
        'btnShutdown
        '
        Me.btnShutdown.Location = New System.Drawing.Point(28, 120)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(175, 24)
        Me.btnShutdown.TabIndex = 8
        Me.btnShutdown.Text = "Final Packing"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(79, 212)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 25)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        '
        'btnUnposted
        '
        Me.btnUnposted.Location = New System.Drawing.Point(28, 46)
        Me.btnUnposted.Name = "btnUnposted"
        Me.btnUnposted.Size = New System.Drawing.Size(175, 35)
        Me.btnUnposted.TabIndex = 0
        Me.btnUnposted.Text = "Unposted Job Transactions"
        '
        'ptbLoco
        '
        Me.ptbLoco.Image = CType(resources.GetObject("ptbLoco.Image"), System.Drawing.Image)
        Me.ptbLoco.Location = New System.Drawing.Point(28, 3)
        Me.ptbLoco.Name = "ptbLoco"
        Me.ptbLoco.Size = New System.Drawing.Size(175, 37)
        Me.ptbLoco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'btnMoveLoc
        '
        Me.btnMoveLoc.Location = New System.Drawing.Point(28, 148)
        Me.btnMoveLoc.Name = "btnMoveLoc"
        Me.btnMoveLoc.Size = New System.Drawing.Size(96, 27)
        Me.btnMoveLoc.TabIndex = 10
        Me.btnMoveLoc.Text = "Move Location"
        '
        'btnPicking
        '
        Me.btnPicking.Location = New System.Drawing.Point(130, 148)
        Me.btnPicking.Name = "btnPicking"
        Me.btnPicking.Size = New System.Drawing.Size(72, 27)
        Me.btnPicking.TabIndex = 12
        Me.btnPicking.Text = "Picking"
        '
        'btnMoveBillet
        '
        Me.btnMoveBillet.Location = New System.Drawing.Point(120, 87)
        Me.btnMoveBillet.Name = "btnMoveBillet"
        Me.btnMoveBillet.Size = New System.Drawing.Size(82, 27)
        Me.btnMoveBillet.TabIndex = 14
        Me.btnMoveBillet.Text = "Move Billet"
        '
        'btnMiscIssue
        '
        Me.btnMiscIssue.Location = New System.Drawing.Point(27, 179)
        Me.btnMiscIssue.Name = "btnMiscIssue"
        Me.btnMiscIssue.Size = New System.Drawing.Size(96, 27)
        Me.btnMiscIssue.TabIndex = 16
        Me.btnMiscIssue.Text = "Misc Issue"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnMiscIssue)
        Me.Controls.Add(Me.btnMoveBillet)
        Me.Controls.Add(Me.btnPicking)
        Me.Controls.Add(Me.btnMoveLoc)
        Me.Controls.Add(Me.ptbLoco)
        Me.Controls.Add(Me.btnUnposted)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShutdown)
        Me.Controls.Add(Me.btnTranfer)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmMain"
        Me.Text = "SAT-UPJT (LIVE) V.1.5"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnTranfer As System.Windows.Forms.Button
    Friend WithEvents btnShutdown As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnUnposted As System.Windows.Forms.Button
    Friend WithEvents ptbLoco As System.Windows.Forms.PictureBox
    Friend WithEvents btnMoveLoc As System.Windows.Forms.Button
    Friend WithEvents btnPicking As System.Windows.Forms.Button
    Friend WithEvents btnMoveBillet As System.Windows.Forms.Button
    Friend WithEvents btnMiscIssue As System.Windows.Forms.Button

End Class
