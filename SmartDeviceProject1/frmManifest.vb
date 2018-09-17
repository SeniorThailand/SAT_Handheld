Public Class frmManifest

    Private Sub txtJobOper_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub txtJobOper_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBarcode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call addToBox()
        End If
    End Sub

    Private Sub addToBox()
        Try
            Dim strBarcode As String
            Dim arrBarcode As String()

            strBarcode = txtBarcode.Text


            If txtLine1.Text = "" Then
                arrBarcode = Split(strBarcode, "/")
                If arrBarcode.Length = 4 Then
                    txtLine1.Text = strBarcode
                Else
                    txtLine1.Text = ""
                    txtLine2.Text = ""
                    txtLine3.Text = ""
                End If
                lblResult.Text = "PROCESSING.."
                lblResult.ForeColor = Color.Black
                txtBarcode.Focus()
            ElseIf txtLine2.Text = "" And txtLine1.Text <> "" Then
                arrBarcode = Split(strBarcode, "/")
                If arrBarcode.Length = 4 Then
                    txtLine2.Text = strBarcode
                Else
                    txtLine2.Text = ""
                End If
                txtBarcode.Focus()
            ElseIf txtLine3.Text = "" And txtLine1.Text <> "" And txtLine2.Text <> "" Then
                arrBarcode = Split(strBarcode, "/")
                If arrBarcode.Length = 1 Then
                    txtLine3.Text = strBarcode
                Else
                    txtLine3.Text = ""
                End If
                btnSave.Focus()
            End If

            txtBarcode.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub clearData()
        txtBarcode.Text = ""
        txtLine1.Text = ""
        txtLine2.Text = ""
        txtLine3.Text = ""
        txtBarcode.Focus()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call clearData()
        Beep()
        Beep()
        Beep()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try

            Dim strResult As String
            Dim ws As New SATWebSV.SATWebSV

            'Validate Data
            If ValidateData() = True Then
                Dim arrText1 As String()
                Dim arrText2 As String()
                Dim arrText3 As String()

                arrText1 = Split(txtLine1.Text, "/")
                arrText2 = Split(txtLine2.Text, "/")
                arrText3 = Split(txtLine3.Text, "/")

                strResult = ws.insertManifest(arrText1(0), arrText1(1), arrText1(2), arrText1(3), arrText2(0), arrText2(1), arrText2(2), arrText2(3), arrText3(0))

                Call clearData()
                lblResult.Text = strResult
                If strResult = "SAVED" Then
                    lblResult.ForeColor = Color.Green
                Else
                    lblResult.ForeColor = Color.Red
                End If

                'MsgBox(strResult, MsgBoxStyle.Information, "SAT inform")
            Else
                Call clearData()
                MsgBox("EMPTY BOX", MsgBoxStyle.Critical, "SAT inform")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Public Function ValidateData() As Boolean
        If Trim(txtLine1.Text) = "" Or Trim(txtLine2.Text) = "" Or Trim(txtLine3.Text = "") Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub frmManifest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBarcode.Focus()
    End Sub

End Class