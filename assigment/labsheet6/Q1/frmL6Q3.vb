Public Class frmL6Q3

    Private Function CalArea(_len As Single, _width As Single) As Single
        Dim areas As Single = _len * _width
        Return areas


    End Function

    Private Sub btndis_Click(sender As Object, e As EventArgs) Handles btndis.Click

        txtarea.Text = CalArea(Val(txtlen.Text), Val(txtwid.Text))
    End Sub
End Class
