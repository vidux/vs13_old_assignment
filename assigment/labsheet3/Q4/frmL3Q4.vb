Public Class frmL3Q4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnteam.Click
        txtTeam.Text = InputBox("Enter name of the team", "Input team")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btngame.Click
        txtwon.Text = InputBox("Enter games Won", "Input won")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnlost.Click
        txtlost.Text = InputBox("Enter games lost", "Input lost")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnwinprecent.Click
        Dim n As Single = 100 - ((Val(txtlost.Text) / Val(txtwon.Text)) * 100)



        MsgBox(txtTeam.Text & " Won the " & n & " percent of games", MsgBoxStyle.Information)




    End Sub


    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtlost.Clear()
        txtTeam.Clear()
        txtwon.Clear()
    End Sub

    Private Sub btnext_Click(sender As Object, e As EventArgs) Handles btnext.Click
        End
    End Sub
End Class