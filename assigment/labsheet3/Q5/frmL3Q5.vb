Public Class frmL3Q5



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim read As String
        Try
            read = My.Computer.FileSystem.ReadAllText(txtfield.Text)
            txtfiled.Text = read
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim showstr As String = vbNullString
            Dim totalsal As Single = 0.0

            For Each liness As String In txtfiled.Text.Split(vbNewLine)
                Dim person() As String = liness.Split("$")
                showstr &= person(0).Trim(vbTab) & "'s salary is " & person(1)
                totalsal += Val(person(1))
            Next
            MsgBox(showstr & vbNewLine & "total salary: $" & totalsal, MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub


End Class