Public Class frmL4Q1





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtname.Text.ToUpper = "HNDIT" And txtpassword.Text = "dehiwala" Then
            lblmessege.Text = ""
            frmwelcome.ShowDialog()


        Else
            MsgBox("logging failed !")
            txtname.Clear()
            txtpassword.Clear()
            lblmessege.Text = "login failed"
        End If
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtname.Clear()
        txtpassword.Clear()
    End Sub


End Class
