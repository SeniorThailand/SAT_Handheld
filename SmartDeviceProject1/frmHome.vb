Imports System.Data
Imports System.Data.SqlTypes
Imports System.Drawing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data.Common

Public Class frmHome
    ' By http://www.thaicreate.com (mr.win)'
    Private Sub frmHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call BindDataGrid()
        Call CreateTable()
    End Sub

    Private Sub BindDataGrid()

        Dim myConnection As SqlConnection
        Dim dt As New DataTable
        Dim Adapter As System.Data.SqlClient.SqlDataAdapter
        'myConnection = New SqlCeConnection("Data Source =" _
        '    + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase) + "\AppDatabase1.sdf;"))

        myConnection = New SqlConnection("Data Source=192.168.1.9,1433;Initial Catalog=WSEA_TST_App;User ID=sa;Password=cvFijwvmu22")

        'myConnection = New System.Data.SqlClient.SqlConnection("Provider=SQLOLEDB.1;Password=P@ssw0rd;Persist Security Info=True;User ID=sa;Initial Catalog=WSEA_CRP_App;Data Source=THSATITSV001")
        myConnection.Open()
        Dim myCommand As SqlCommand = myConnection.CreateCommand()
        myCommand.CommandText = "select * from dbo.jobtran where job = 'WSEA136330' order by oper_num"
        myCommand.CommandType = CommandType.Text

        Adapter = New SqlDataAdapter(myCommand)
        Adapter.Fill(dt)

        myConnection.Close()

        Dim tableStyle As New DataGridTableStyle()
        tableStyle.MappingName = dt.TableName


        Dim column As New DataGridTextBoxColumn()
        column.MappingName = "job"
        column.HeaderText = "job"
        column.Width = 30
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.MappingName = "qty_complete"
        column.HeaderText = "qty_complete"
        column.Width = 80
        tableStyle.GridColumnStyles.Add(column)

        column = New DataGridTextBoxColumn()
        column.Width = 40
        column.MappingName = "oper_num"
        column.HeaderText = "oper_num"
        tableStyle.GridColumnStyles.Add(column)

        Me.dgName.DataSource = dt

        Me.dgName.TableStyles.Clear()
        Me.dgName.TableStyles.Add(tableStyle)

        dt = Nothing

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim f As New frmTransfer
        f.Show()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim f As New frmSerial
        f._strID = Me.dgName(Me.dgName.CurrentRowIndex, 0)
        f.Show()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click

        If MessageBox.Show("Are you sure to delete?", "Confirm.", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

            Dim strID As String = Me.dgName(Me.dgName.CurrentRowIndex, 0)

            Dim myConnection As SqlConnection
            myConnection = New SqlConnection("Data Source=192.168.1.9,1433;Initial Catalog=ITTEST-APP;User ID=sa;Password=cvFijwvmu22")

            'myConnection = New SqlCeConnection("Data Source =" _
            '    + (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly.GetName.CodeBase) + "\AppDatabase1.sdf;"))
            myConnection.Open()
            Dim myCommand As SqlCommand = myConnection.CreateCommand()
            myCommand.CommandText = "DELETE FROM testItem WHERE item = '" & strID & "'"
            myCommand.CommandType = CommandType.Text
            myCommand.ExecuteNonQuery()
            myConnection.Close()
            MessageBox.Show("Delete Successfully")

            BindDataGrid()
        End If

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim f As New frmMain
        f.Show()
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        txtLine.Focus()
      
    End Sub
    Dim dt As New DataTable
    Public Function InsertRowInTbl(ByVal FirstColumn As String, ByVal SecondColumn As String) As DataTable

        Dim row As DataRow() = dt.[Select]("Description='" & FirstColumn & "' and Qty='" & SecondColumn & "'")
        If row.Length = 0 Then
            Dim tempRow As DataRow
            tempRow = dt.NewRow()
            tempRow("Description") = FirstColumn
            tempRow("Qty") = SecondColumn
            dt.Rows.Add(tempRow)
        End If
        Return dt
    End Function
    Public Sub CreateTable() 'creating table in the memory
        dt = New DataTable("mytbl") 'table name
        dt.Columns.Add("Description") 'first column name
        dt.Columns.Add("Qty") 'SecondColumn name
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.InsertRowInTbl(txtLine.Text, nudQty.Value)
        dgName.DataSource = dt
    End Sub
End Class