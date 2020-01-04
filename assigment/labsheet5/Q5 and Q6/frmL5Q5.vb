Public Class frmL5Q5

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim getdata As String = InputBox("enter name [space] makrs", "input marks")
        If getdata = "" Then Exit Sub

        lbmarks.Items.Add(getdata)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim avaragek As Single = 0
        Dim totalk As Single = 0

        For Each n As String In lbmarks.Items

            Dim tmp() As String = n.Split(" ")
            totalk += Val(tmp(1))

        Next
        avaragek = totalk / lbmarks.Items.Count
        txtavg.Text = avaragek
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
