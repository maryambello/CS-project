Public Class Tutorial
    Private Sub Tutorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        Dim newForm As New QA
        newForm.ShowDialog()
    End Sub

    Private Sub btnEvents_MouseHover(sender As Object, e As EventArgs) Handles btnEvents.MouseHover
        btnEvents.Text = "START THE TUTORIAL"
    End Sub
End Class