Public Class button
    Dim score As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score = score + 1
        Label1.Text = score
    End Sub
End Class
