Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        CenterToParent()
        Me.BackColor = Color.Beige

        MsgBox("2 + 3 = " & 2 + 3 & "  and 2 - 3 = " & 2 - 3,, "Result")

        'MsgBox("2 - 3 = " & 2 - 3,, "Result")

        MsgBox("2 / 3 = " & 2 / 3,, "Result")

        MsgBox("2 * 3 = " & 2 * 3,, "Result")
    End Sub
End Class
