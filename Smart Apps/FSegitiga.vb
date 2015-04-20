Public Class FSegitiga
    Dim a, b, c, t, h As Single
    Public Function dec()
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        t = TextBox4.Text
        h = 1 / 2 * a * t
        TextBox5.Text = h
        Label10.Text = "Luas"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call dec()
        h = a + b + c
        TextBox5.Text = h
        Label10.Text = "Keliling"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result1 As DialogResult = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo)
        If result1 = Windows.Forms.DialogResult.OK Then
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            Label10.Text = "Hasil"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Label7.Text = "a"
        Else
            Label7.Text = TextBox1.Text
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Label8.Text = "b"
        Else
            Label8.Text = TextBox2.Text
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Label9.Text = "c"
        Else
            Label9.Text = TextBox3.Text
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            Label6.Text = "t"
        Else
            Label6.Text = TextBox4.Text
        End If
    End Sub
End Class