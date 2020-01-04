Public Class frmL5Q3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim n As Integer = txtnum.Text
            Dim fac As Integer = 1

            For k As Integer = 1 To n
                fac *= k
            Next


            txtfac.Text = fac
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
