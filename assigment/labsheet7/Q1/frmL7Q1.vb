Public Class frmL7Q1
    Dim rbuttonval As Integer = 0
    Private Sub calform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim k As New cal

        k.setnumbers(2, 4)


    End Sub

    Private Sub rbadd_CheckedChanged(sender As Object, e As EventArgs) Handles rbadd.CheckedChanged
        rbuttonval = 1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        rbuttonval = 2
    End Sub

    Private Sub rbmul_CheckedChanged(sender As Object, e As EventArgs) Handles rbmul.CheckedChanged
        rbuttonval = 3
    End Sub

    Private Sub rbdevid_CheckedChanged(sender As Object, e As EventArgs) Handles rbdevid.CheckedChanged
        rbuttonval = 4
    End Sub

    Private Sub rbremind_CheckedChanged(sender As Object, e As EventArgs) Handles rbremind.CheckedChanged
        rbuttonval = 5
    End Sub

    Private Sub rbexponet_CheckedChanged(sender As Object, e As EventArgs) Handles rbexponet.CheckedChanged
        rbuttonval = 6
    End Sub

    Private Sub rbmin_CheckedChanged(sender As Object, e As EventArgs) Handles rbmin.CheckedChanged
        rbuttonval = 7
    End Sub

    Private Sub rbmax_CheckedChanged(sender As Object, e As EventArgs) Handles rbmax.CheckedChanged
        rbuttonval = 8
    End Sub

    Private Sub btncalcuate_Click(sender As Object, e As EventArgs) Handles btncalcuate.Click
        Dim calnumbers As New cal 'creating calnumber object using cal class

        calnumbers.setnumbers(Val(txtnumber1.Text), Val(txtnumber2.Text))


        Select Case rbuttonval
            Case 1
                txtresult.Text = calnumbers.Addtion
            Case 2
                txtresult.Text = calnumbers.subtraction
            Case 3
                txtresult.Text = calnumbers.Multiplication
            Case 4
                txtresult.Text = calnumbers.Devision
            Case 5
                txtresult.Text = calnumbers.Reminder
            Case 6
                txtresult.Text = calnumbers.exponent

            Case 7
                txtresult.Text = calnumbers.min

            Case 8
                txtresult.Text = calnumbers.max

            Case Else
                txtresult.Text = "not selected"


        End Select







    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
End Class


Public Class cal
   
    Protected result As Single
    Protected num1 As Single
    Protected num2 As Single


    Public Sub setnumbers(ByVal number1 As Single, ByVal number2 As Single)
        num1 = number1
        num2 = number2

    End Sub

    Public Function Addtion() As Single
        Return num1 + num2
    End Function


    Public Function subtraction() As Single
        Return num1 - num2
    End Function




    Public Function Multiplication() As Single
        Return num1 * num2
    End Function

    Public Function Devision() As Single
        Return num1 / num2
    End Function

    Public Function Reminder() As Single
        Return num1 Mod num2
    End Function


    Public Function exponent() As Single
        Return num1 ^ num2
    End Function

    Public Function min() As Single

        If num1 > num2 Then Return num2
        Return num1

    End Function

    Public Function max() As Single

        If num1 < num2 Then Return num2
        Return num1

    End Function


End Class