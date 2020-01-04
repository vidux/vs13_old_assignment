Public Class frmL5Q7
    Dim studentList(2) As String
    Private Sub eix_Click(sender As Object, e As EventArgs) Handles eix.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        For count As Integer = 0 To 2


            studentList(count) = InputBox(count + 1 & " student's enter name:", "input data") & vbTab & InputBox(count + 1 & " student's enter address:", "input data") & vbTab & InputBox(count + 1 & " student's enter age:", "input data")


        Next



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbldisplay.Items.Add(" ")
        For Each std As String In studentList
            lbldisplay.Items.Add(std)
        Next
    End Sub
End Class
