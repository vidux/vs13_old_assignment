Public Class frmL2Q3


    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        txtdispaly.Text = Val(txtnumber1.Text) + Val(txtnumber2.Text)
    End Sub

    Private Sub btnminus_Click(sender As Object, e As EventArgs) Handles btnminus.Click
        txtdispaly.Text = Val(txtnumber1.Text) - Val(txtnumber2.Text)
    End Sub

    Private Sub btnmul_Click(sender As Object, e As EventArgs) Handles btnmul.Click
        txtdispaly.Text = Val(txtnumber1.Text) * Val(txtnumber2.Text)
    End Sub

    Private Sub btndev_Click(sender As Object, e As EventArgs) Handles btndev.Click
        txtdispaly.Text = Val(txtnumber1.Text) / Val(txtnumber2.Text)
    End Sub

    Private Sub btnmod_Click(sender As Object, e As EventArgs) Handles btnmod.Click
        txtdispaly.Text = Val(txtnumber1.Text) Mod Val(txtnumber2.Text)

    End Sub

    Private Sub btnpow_Click(sender As Object, e As EventArgs) Handles btnpow.Click
        txtdispaly.Text = Val(txtnumber1.Text) ^ Val(txtnumber2.Text)
    End Sub

    Private Sub btnclr_Click(sender As Object, e As EventArgs) Handles btnclr.Click
        txtnumber1.Clear()
        txtnumber2.Clear()
        txtdispaly.Clear()

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End

    End Sub



End Class