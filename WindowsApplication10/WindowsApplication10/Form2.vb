Public Class form2
    Public I, z As Double
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        I = Double.Parse(TextBox1.Text)
        z = Double.Parse(TextBox2.Text)
        If RadioButton1.Checked = True Then
            TextBox3.Text = (I Mod z).ToString
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = (I ^ z).Tostring
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = System.Math.Sqrt(I).ToString
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = System.Math.Abs(I).ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

End Class