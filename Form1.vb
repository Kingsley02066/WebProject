Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim Username As String = txtUsername.Text
        Dim Password As String = txtPassword.Text
        If Username = "admin" And Password = "level300" Then
            DashboardForm.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim open As New OpenFileDialog

        open.Filter = "Image Files|.jpg;.jpeg;.png;.bmp"

        If open.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open.FileName)

        ElseIf PictureBox1.Image Is Nothing Then
            MessageBox.Show("Please load your photo before logging in")
            Exit Sub
        End If



    End Sub
End Class