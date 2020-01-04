Public Class frmL2Q4

    Dim sex As String = vbNullString
    Dim ITknowledge As String = "NO"



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Name: " & txtname.Text & vbNewLine &
          "ID: " & txtID.Text & vbNewLine &
          "Sex: " & sex & vbNewLine &
         "Status: " & cmbst.Text & vbNewLine &
         "Piror IT knowledge: " & ITknowledge & vbNewLine &
        "Date OF Birth:" & dtpDOB.Value.Date & vbNewLine &
        "apply course: " & cmbcourse.Text & vbNewLine, MsgBoxStyle.Information)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbmale.CheckedChanged
        sex = "MALE"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rbfemale.CheckedChanged
        sex = "FEMALE"
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkitknowlage.CheckedChanged
        If chkitknowlage.CheckState = CheckState.Checked Then
            ITknowledge = "YES"
        Else
            ITknowledge = "NO"
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub


End Class