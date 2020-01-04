Public Class frmL1Q3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtname.BackColor = Color.Orange
        txtmName.BackColor = Color.Orange
        txtLname.BackColor = Color.Orange
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtname.TextAlign = HorizontalAlignment.Left
        txtmName.TextAlign = HorizontalAlignment.Left
        txtLname.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtname.TextAlign = HorizontalAlignment.Right
        txtmName.TextAlign = HorizontalAlignment.Right
        txtLname.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtname.Clear()
        txtmName.Clear()
        txtLname.Clear()





    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
