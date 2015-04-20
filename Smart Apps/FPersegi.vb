Public Class FPersegi
    Dim s, h As Single
    Public Function dec()
        s = TextBox1.Text
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            Label6.Text = "S"
            Label7.Text = "S"
            Label8.Text = "S"
            Label9.Text = "S"
        Else
            Label6.Text = TextBox1.Text
            Label7.Text = TextBox1.Text
            Label8.Text = TextBox1.Text
            Label9.Text = TextBox1.Text
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call dec()
        h = s * s
        TextBox2.Text = h
        Label5.Text = "Luas"

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Call dec()
        h = 4 * s
        TextBox2.Text = h
        Label5.Text = "Keliling"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result1 As DialogResult = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result1 = Windows.Forms.DialogResult.Yes Then
            TextBox1.Text = ""
            TextBox2.Text = ""
            Label5.Text = "Hasil"
            Label6.Text = "S"
            Label7.Text = "S"
            Label8.Text = "S"
            Label9.Text = "S"
        End If
    End Sub
End Class