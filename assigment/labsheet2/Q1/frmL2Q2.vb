Public Class frmL2Q2

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtDisplay.Clear()
        txtName.Clear()
        txtName.Enabled = True
        btnwel.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnwel.Click
        txtName.Enabled = False
        btnwel.Enabled = False
        txtDisplay.Text = "Hello " & txtName.Text & ", welcome to the world of .net"

    End Sub

End Class