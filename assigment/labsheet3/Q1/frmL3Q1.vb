Public Class frmL3Q1





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub

    Private Sub btncomput_Click(sender As Object, e As EventArgs) Handles btncomput.Click
        Dim num1 As Single = 3
        Dim num2 As Single = 2


        lbdisplay.Items.Add("sum is " & num1 + num2)
        lbdisplay.Items.Add("subtraction is " & num1 + num2)
        lbdisplay.Items.Add("division is " & num1 + num2)
        lbdisplay.Items.Add("multiplication is " & num1 + num2)
        lbdisplay.Items.Add(num1 & " to the power " & num2 & " is " & num1 ^ num2)



    End Sub


End Class
