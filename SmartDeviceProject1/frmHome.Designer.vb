<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmHome
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
        Me.dgName = New System.Windows.Forms.DataGrid
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtItem = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.nudQty = New System.Windows.Forms.NumericUpDown
        Me.btnInsert = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtLine = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'dgName
        '
        Me.dgName.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.dgName.Location = New System.Drawing.Point(16, 88)
        Me.dgName.Name = "dgName"
        Me.dgName.Size = New System.Drawing.Size(205, 126)
        Me.dgName.TabIndex = 0
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(17, 228)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(48, 24)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(73, 228)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(42, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit"
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(122, 229)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(44, 21)
        Me.btnDel.TabIndex = 3
        Me.btnDel.Text = "Del"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(173, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(47, 21)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(58, 9)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(108, 21)
        Me.txtItem.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.Text = "Item"
        '
        'nudQty
        '
        Me.nudQty.Location = New System.Drawing.Point(58, 61)
        Me.nudQty.Name = "nudQty"
        Me.nudQty.Size = New System.Drawing.Size(69, 22)
        Me.nudQty.TabIndex = 7
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(173, 10)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(48, 19)
        Me.btnInsert.TabIndex = 8
        Me.btnInsert.Text = "Insert"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 20)
        Me.Label2.Text = "Qty"
        '
        'txtLine
        '
        Me.txtLine.Location = New System.Drawing.Point(57, 35)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.Size = New System.Drawing.Size(109, 21)
        Me.txtLine.TabIndex = 10
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(173, 37)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(46, 18)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtLine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.nudQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgName)
        Me.Menu = Me.mainMenu1
        Me.Name = "frmHome"
        Me.Text = "frmHome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgName As System.Windows.Forms.DataGrid
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudQty As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtLine As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
