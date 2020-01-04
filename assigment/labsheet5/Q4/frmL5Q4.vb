Public Class frmL5Q4

    Dim teamlist() As String = New String() {"sri lanka", "india", "nepal", "england"}


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblwt.Text = teamlist(ComboBox1.Text - 1)
    End Sub
End Class
