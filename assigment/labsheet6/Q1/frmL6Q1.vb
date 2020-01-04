Public Class frmL6Q1

    Private Sub btnOK(sender As Object, e As EventArgs) Handles Button1.Click
        addNumberAndAddBlahBlah(Val(txtn1.Text), Val(txtn2.Text))
    End Sub


    Private Sub addNumberAndAddBlahBlah(n1 As Single, n2 As Single)
        txtdisplay.Text = "This program display a sentence" & vbNewLine &
        "identifying two numbers and their sum" & vbNewLine & vbNewLine & "the sum of " &
        n1 & " and " & n2 & " is " & n1 + n2
    End Sub

    Private Sub btnclr(sender As Object, e As EventArgs) Handles Button2.Click
        txtdisplay.Clear()
        txtn1.Clear()
        txtn2.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class
