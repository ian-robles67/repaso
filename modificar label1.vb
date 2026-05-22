Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Brr brr patapim brr brr patapim chimpancini bananini tung tung tung sahur"
        Label1.ForeColor = Color.Red
        Label1.BackColor = Color.Purple
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = "kar kir kur kar kar kar kur kur kur"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Label1.Visible = True Then
            Label1.Visible = False
            Button1.Visible = False
        ElseIf Label1.Visible = False Then
            Label1.Visible = True
            Button1.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = Label1.Text & " Tung"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label1.Text = Label1.Text & " Sahur"
    End Sub
End Class
