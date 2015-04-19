Public Class FPersegiPanjang
    Dim p, l, h As Single
    Public Function dec()
        p = TextBox1.Text
        l = TextBox2.Text
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Label6.Text = "l"
            Label7.Text = "p"
            Label8.Text = "l"
            Label9.Text = "p"
        Else
            Label6.Text = TextBox2.Text
            Label7.Text = TextBox1.Text
            Label8.Text = TextBox2.Text
            Label9.Text = TextBox1.Text
        End If
    End Sub
    

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            Label6.Text = "l"
            Label7.Text = "p"
            Label8.Text = "l"
            Label9.Text = "p"
        Else
            Label6.Text = TextBox2.Text
            Label7.Text = TextBox1.Text
            Label8.Text = TextBox2.Text
            Label9.Text = TextBox1.Text
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call dec()
        h = p * l
        TextBox3.Text = h
        Label10.Text = "Luas"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call dec()
        h = 2 * (p * l)
        TextBox3.Text = h
        Label10.Text = "Keliling"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result1 As DialogResult = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result1 = Windows.Forms.DialogResult.Yes Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            Label10.Text = "Hasil"
            Label6.Text = "l"
            Label7.Text = "p"
            Label8.Text = "l"
            Label9.Text = "p"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class