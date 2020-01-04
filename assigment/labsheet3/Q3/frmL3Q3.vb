Public Class frmL3Q3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        txttotal.Text = "total is " & Val(txtmark1.Text) + Val(txtmark2.Text) + Val(txtmark3.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtavg.Text = "avg is " & (Val(txtmark1.Text) + Val(txtmark2.Text) + Val(txtmark3.Text)) / 3
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtavg.Clear()
        txtmark1.Clear()
        txtmark2.Clear()
        txtmark3.Clear()
        txttotal.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub


End Class