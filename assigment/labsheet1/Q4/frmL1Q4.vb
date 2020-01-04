Public Class frmL1Q4
    Dim gender As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label3.Click, Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click


        Dim Sitems As String = ""
        For Each n As String In lbintrasts.SelectedItems
            Sitems &= vbNewLine & n
        Next


        MsgBox("First name: " & txtFirstName.Text & vbNewLine & "Gender: " & gender & vbNewLine & "Instrested in: " & Sitems & vbNewLine & "City: " & cboCity.Text, MsgBoxStyle.Information)
    End Sub

    Private Sub radMale_CheckedChanged(sender As Object, e As EventArgs) Handles radMale.CheckedChanged
        gender = "Male"
    End Sub

    Private Sub radfemale_CheckedChanged(sender As Object, e As EventArgs) Handles radfemale.CheckedChanged
        gender = "Female"
    End Sub


End Class