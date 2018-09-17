<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class dialogScrap
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboReasonCode = New System.Windows.Forms.ComboBox
        Me.cboFaultCode = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFeatureCode = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OK"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(30, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 18)
        Me.Label1.Text = "Enter Scrap code"
        '
        'cboReasonCode
        '
        Me.cboReasonCode.Location = New System.Drawing.Point(30, 24)
        Me.cboReasonCode.Name = "cboReasonCode"
        Me.cboReasonCode.Size = New System.Drawing.Size(176, 22)
        Me.cboReasonCode.TabIndex = 3
        '
        'cboFaultCode
        '
        Me.cboFaultCode.Location = New System.Drawing.Point(30, 79)
        Me.cboFaultCode.Name = "cboFaultCode"
        Me.cboFaultCode.Size = New System.Drawing.Size(176, 22)
        Me.cboFaultCode.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(30, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 18)
        Me.Label2.Text = "Enter Fault code"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(30, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 18)
        Me.Label3.Text = "Enter Feature Code"
        '
        'txtFeatureCode
        '
        Me.txtFeatureCode.Location = New System.Drawing.Point(30, 139)
        Me.txtFeatureCode.Name = "txtFeatureCode"
        Me.txtFeatureCode.Size = New System.Drawing.Size(176, 21)
        Me.txtFeatureCode.TabIndex = 10
        '
        'dialogScrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.txtFeatureCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboFaultCode)
        Me.Controls.Add(Me.cboReasonCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Menu = Me.mainMenu1
        Me.Name = "dialogScrap"
        Me.Text = "dialogScrap"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboReasonCode As System.Windows.Forms.ComboBox
    Friend WithEvents cboFaultCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFeatureCode As System.Windows.Forms.TextBox
End Class
