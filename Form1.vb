Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Opacity = 0.95
        CenterToParent()
    End Sub

    Private Function sqroot(ByRef x As Single) As Double
        x = x ^ 0.5
        sqroot = x
    End Function

    Private Function sqrootl(ByVal y As Single) As Double
        y = y ^ 0.5
        sqrootl = y
    End Function

    Private Sub btnByRef_Click(sender As Object, e As EventArgs) Handles btnByRef.Click
        Dim number As Single
        number = Val(txtNumber.Text)
        MsgBox(sqroot(number), , "ByRef")
        MsgBox("Value of Number is " & number, , "ByRef")
    End Sub

    Private Sub btnByVal_Click(sender As Object, e As EventArgs) Handles btnByVal.Click
        Dim number As Single
        number = Val(txtNumber.Text)
        MsgBox(sqrootl(number), , "ByVal")
        MsgBox("Value of Number is " & number, , "ByVal")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
