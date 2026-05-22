Public Class Form1
    Dim activo
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        activo = TextBox1
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        activo = TextBox2
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        activo.Text = activo.Text & "6"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        activo.Text = activo.Text & "7"
    End Sub

    Private Sub Sumar_Click(sender As Object, e As EventArgs) Handles Sumar.Click
        Dim Numero1 = Double.Parse(TextBox1.Text)
        Dim Numero2 = Double.Parse(TextBox2.Text)
        Dim Resultado = Numero1 + Numero2


        Label1.Text = Resultado
        Resultado.ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Numero1 = Double.Parse(TextBox1.Text)
        Dim Numero2 = Double.Parse(TextBox2.Text)
        Dim Resultado = Numero1 - Numero2


        Label1.Text = Resultado
        Resultado.ToString()
    End Sub
End Class
