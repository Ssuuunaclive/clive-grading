Public Class Form1

    Private Sub btnEvaluate_Click(sender As Object, e As EventArgs) Handles btnEvaluate.Click
        Dim marks As Integer = txtmarks.Text

        If marks >= 90 And marks <= 100 Then
            MessageBox.Show("Excellent")
        ElseIf marks >= 80 And marks <= 89 Then
            MessageBox.Show("Very Good")
        ElseIf marks >= 70 And marks <= 79 Then
            MessageBox.Show("Good")
        ElseIf marks >= 60 And marks <= 69 Then
            MessageBox.Show("Medium")
        ElseIf marks >= 50 And marks <= 59 Then
            MessageBox.Show("Pass")
        ElseIf marks >= 0 And marks <= 49 Then
            MessageBox.Show("Fail")
        ElseIf marks > 100 Then
            MessageBox.Show("wrong entry, please re-enter the mark")
        End If

    End Sub

End Class
