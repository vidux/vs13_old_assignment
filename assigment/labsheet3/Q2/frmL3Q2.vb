Public Class frmL3Q2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncompute.Click
        Dim speed, time_elsped, distence As Double
        speed = Val(txtspeed.Text)
        time_elsped = Val(txttime.Text)
        distence = speed * time_elsped


        lbdisplay.Items.Add("speed= " & speed)
        lbdisplay.Items.Add("time elapsed= " & time_elsped)
        lbdisplay.Items.Add("distance= " & distence)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
End Class