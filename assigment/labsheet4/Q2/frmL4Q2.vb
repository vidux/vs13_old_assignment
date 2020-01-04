Public Class frmL4Q2



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = txtgetchar.Text


        If str.ToUpper = "A" Then
            txtgetchar.Text = "A, My name is Amal"

        ElseIf str.ToUpper = "B" Then
            txtgetchar.Text = "B, My name is Bandara"


        ElseIf str.ToUpper = "C" Then
            txtgetchar.Text = "C, My name is Chamara"


        ElseIf str.ToUpper = "D" Then
            txtgetchar.Text = "D, My name is Dinash"
        Else
            txtgetchar.Text = "character not found"


        End If





    End Sub


End Class