Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decInt As Integer

        ' Convert variables
        decInt = CInt(txtInput.Text)

        ' Convert and display result
        If decInt = 1 Then
            lblResult.Text = "I"

        ElseIf decInt = 2 Then
            lblResult.Text = "II"

        ElseIf decInt = 3 Then
            lblResult.Text = "III"

        ElseIf decInt = 4 Then
            lblResult.Text = "IV"

        ElseIf decInt = 5 Then
            lblResult.Text = "V"

        ElseIf decInt = 6 Then
            lblResult.Text = "VI"

        ElseIf decInt = 7 Then
            lblResult.Text = "VII"

        ElseIf decInt = 8 Then
            lblResult.Text = "VIII"

        ElseIf decInt = 9 Then
            lblResult.Text = "IX"

        ElseIf decInt = 10 Then
            lblResult.Text = "X"
        End If
    End Sub
End Class
