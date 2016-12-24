Public Class Form2
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.CreateNuPe("http://proyectoayampe.wordpress.com/", Form1.TabControl1)
    End Sub
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form1.CreateNuPe("https://www.youtube.com/watch?v=2Z4m4lnjxkY", Form1.TabControl1)
    End Sub
End Class