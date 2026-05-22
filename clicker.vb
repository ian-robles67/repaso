Public Class Form1
    Dim valor As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        valor += 1
        Label1.Text = valor.ToString()
    End Sub
End Class
