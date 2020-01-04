Public Class frmL4Q5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim _day As Integer = Val(txtday.Text)

        Select Case _day
            Case 1
                lbld.Text = "Monday"

            Case 2
                lbld.Text = "tuesday"



            Case 3

                lbld.Text = "wednesday"
            Case 4

                lbld.Text = "thursday"


            Case 5
                lbld.Text = "friday"

            Case 6

                lbld.Text = "sataday"

            Case 7

                lbld.Text = "sunday"
            Case Else
                lbld.Text = "wrong input"
        End Select



    End Sub


End Class