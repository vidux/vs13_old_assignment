Public Class frmL6Q2

    Private Sub btnOK(sender As Object, e As EventArgs) Handles Button1.Click
        addNumberAndAddBlahBlah(Val(txtn1.Text), Val(txtn2.Text))
    End Sub


    Private Sub addNumberAndAddBlahBlah(n1 As Single, n2 As Single)
        txtdisplay.Text = "the sum of " & n1 & " and " & n2 & " is " & n1 + n2
    End Sub




End Class
