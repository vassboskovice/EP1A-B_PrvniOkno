Public Class Form1
  Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    Close()
  End Sub

  Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    Dim a, b As Double

    If IsNumeric(TextBox1.Text) And IsNumeric(TextBox2.Text) Then
      a = TextBox1.Text
      b = TextBox2.Text
      Label3.Text = $"{a} + {b} = {a + b}"
    End If


  End Sub

  Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    If IsNumeric(TextBox1.Text) Then
      TextBox1.BackColor = Color.White
    Else
      TextBox1.BackColor = Color.Salmon
    End If
  End Sub

  Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    If IsNumeric(TextBox2.Text) Then
      TextBox2.BackColor = Color.White
    Else
      TextBox2.BackColor = Color.Salmon
    End If
  End Sub
End Class
