Public Class frmL4Q4


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Val(txtenteredtime.Text) >= 24 Then
            MsgBox("wrong input")
            Exit Sub
        End If

        If Val(txtenteredtime.Text) >= 19 Then
            lbldisplay.Text = "Good Night"

        ElseIf Val(txtenteredtime.Text) >= 15 Then
            lbldisplay.Text = "Good eviening"

        ElseIf Val(txtenteredtime.Text) >= 12 Then
            lbldisplay.Text = "Good afternoon"

        ElseIf Val(txtenteredtime.Text) >= 2 Then
            lbldisplay.Text = "Good morning"

        Else
            lbldisplay.Text = "Mid night"

        End If

    End Sub


    Private Sub tm1_Tick(sender As Object, e As EventArgs) Handles tm1.Tick
        lblactime.Text = "actual time: " & DateTime.Now.ToString
        txtyear.Text = Now.Date.Year
        txtmonth.Text = Now.Date.Month
        txtday.Text = Now.Date.Day


        lblhr.Text = "Hour: " & DateTime.Now.Hour
        lblminu.Text = "Minitues: " & DateTime.Now.Minute
        lblsec.Text = "Seconds: " & DateTime.Now.Second
    End Sub
End Class