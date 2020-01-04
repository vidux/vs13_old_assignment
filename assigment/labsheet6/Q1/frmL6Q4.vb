Public Class frmL6Q4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        addFiveByval(txtoriN1.Text, txtoriN2.Text)


    End Sub

    Private Sub addFiveByval(ByVal n1 As Single, ByVal n2 As Single)
        n1 = n1 + 5
        n2 = n2 + 5

        txtBvN1.Text = n1
        txtBvN2.Text = n2
    End Sub


    Private Sub addFiveByref(ByRef n1 As Single, ByRef n2 As Single)

        n1 = n1 + 5
        n2 = n2 + 5

        txtBrN1.Text = n1
        txtBrN2.Text = n2

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        addFiveByref(txtoriN1.Text, txtoriN2.Text)
    End Sub
End Class
