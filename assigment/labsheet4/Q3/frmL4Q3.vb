Public Class frmL4Q3



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim markss As Single = txtmarks.Text
        Dim grades As String = vbNullString


        If markss >= 85 Then
            grades = "A+"

        ElseIf markss >= 75 Then
            grades = "A"

        ElseIf markss >= 70 Then
            grades = "A-"

        ElseIf markss >= 65 Then
            grades = "B+"

        ElseIf markss >= 60 Then
            grades = "B"

        ElseIf markss >= 55 Then
            grades = "B-"
        ElseIf markss < 55 Then
            grades = "C"

        Else
            grades = "Non"

        End If



        txtgrade.Text = grades

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim marks As Single = txtmarks.Text
        Dim grades As String = vbNullString
        Select Case marks

            Case 85 To 100
                grades = "A+"
            Case 75 To 84
                grades = "A"
            Case 70 To 74
                grades = "A-"
            Case 65 To 69
                grades = "B+"

            Case 60 To 64
                grades = "B"
            Case 55 To 59
                grades = "B-"

            Case 0 To 54

                grades = "C"




        End Select



        txtgrade.Text = grades

    End Sub


End Class