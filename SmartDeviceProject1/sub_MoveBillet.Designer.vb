<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class sub_MoveBillet
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
        Me.btnPrintLabel = New System.Windows.Forms.Button
        Me.btnMoveBillet = New System.Windows.Forms.Button
        Me.btnPrintDirect = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnPrintLabel
        '
        Me.btnPrintLabel.Location = New System.Drawing.Point(31, 19)
        Me.btnPrintLabel.Name = "btnPrintLabel"
        Me.btnPrintLabel.Size = New System.Drawing.Size(162, 29)
        Me.btnPrintLabel.TabIndex = 0
        Me.btnPrintLabel.Text = "Print Label"
        '
        'btnMoveBillet
        '
        Me.btnMoveBillet.Location = New System.Drawing.Point(31, 59)
        Me.btnMoveBillet.Name = "btnMoveBillet"
        Me.btnMoveBillet.Size = New System.Drawing.Size(162, 28)
        Me.btnMoveBillet.TabIndex = 1
        Me.btnMoveBillet.Text = "Move Billet"
        '
        'btnPrintDirect
        '
        Me.btnPrintDirect.BackColor = System.Drawing.Color.Yellow
        Me.btnPrintDirect.Location = New System.Drawing.Point(31, 109)
        Me.btnPrintDirect.Name = "btnPrintDirect"
        Me.btnPrintDirect.Size = New System.Drawing.Size(162, 28)
        Me.btnPrintDirect.TabIndex = 2
        Me.btnPrintDirect.Text = "Print Direct"
        '
        'sub_MoveBillet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnPrintDirect)
        Me.Controls.Add(Me.btnMoveBillet)
        Me.Controls.Add(Me.btnPrintLabel)
        Me.Menu = Me.mainMenu1
        Me.Name = "sub_MoveBillet"
        Me.Text = "Move Billet Group"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPrintLabel As System.Windows.Forms.Button
    Friend WithEvents btnMoveBillet As System.Windows.Forms.Button
    Friend WithEvents btnPrintDirect As System.Windows.Forms.Button
End Class
