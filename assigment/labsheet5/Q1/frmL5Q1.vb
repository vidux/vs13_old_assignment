Public Class frmL5Q1

    Private Sub btngo_Click(sender As Object, e As EventArgs) Handles btngo.Click
        Try
            Dim st, ed As Integer
            Dim multip As Single


            st = Val(txtstart.Text)
            ed = Val(txtend.Text)
            multip = Val(txtmul.Text)


            For run As Integer = st To ed
                lbmul.Items.Add(run & " Times " & multip & " = " & run * multip)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lbmul.Items.Clear()
    End Sub
End Class
