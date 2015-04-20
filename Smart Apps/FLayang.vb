Public Class FLayang
    Dim d1, d2, s1, s2, h As Single
    Public Function dec()
        s1 = TextBox3.Text
        s2 = TextBox4.Text
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        d1 = TextBox1.Text
        d2 = TextBox2.Text
        h = 1 / 2 * d1 * d2
        TextBox5.Text = h
        Label10.Text = "Luas"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call dec()
        h = 2 * s1 + 2 * s2
        TextBox5.Text = h
        Label10.Text = "Keliling"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result1 As DialogResult = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result1 = Windows.Forms.DialogResult.Yes Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            Label10.Text = "Hasil"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Label7.Text = "d1"
        Else
            Label7.Text = TextBox1.Text
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Label8.Text = "d2"
        Else
            Label8.Text = TextBox2.Text
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            Label6.Text = "s1"
        Else
            Label6.Text = TextBox3.Text
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "" Then
            Label9.Text = "s2"
        Else
            Label9.Text = TextBox4.Text
        End If
    End Sub
End Class