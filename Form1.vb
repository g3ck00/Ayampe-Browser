Public Class Form1
    Dim Li() As String
    Public Sub CreateNuPe(ByVal Url As String, ByVal TabControl As TabControl)
        Dim NuPe As New TabPage
        Dim NuNa As New TabWebKitBrowser
        NuNa.Tag = NuPe
        NuPe.Tag = NuNa
        TabControl.TabPages.Add(NuPe)
        NuNa.Navigate(Url)
        NuPe.Controls.Add(NuNa)
        NuNa.Dock = DockStyle.Fill
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreateNuPe("https://www.google.com/", TabControl1)
        ReDim Preserve Li(10)
        ListBox1.Items.Add("https://www.google.com/")
        ListBox1.Items.Add("http://www.")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
        ListBox1.Items.Add("")
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim PeSe As TabWebKitBrowser = Me.TabControl1.SelectedTab.Tag
        PeSe.GoBack()
    End Sub
    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        If ListBox1.Items.Count = 0 Then Exit Sub 'sino hay elementos salimos
        TextBox1.Text = ListBox1.Items.Item(TabControl1.SelectedIndex)
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim PeSe As TabWebKitBrowser = Me.TabControl1.SelectedTab.Tag()
            PeSe.Navigate(TextBox1.Text)
            Dim Ur As Byte
            Ur = TabControl1.SelectedIndex
            Select Case Ur
                Case 0
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 1
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 2
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 3
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 4
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 5
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 6
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 7
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 8
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
                Case 9
                    PeSe.Navigate(Trim(TextBox1.Text))
                    ListBox1.Items.Item(Ur) = Trim(TextBox1.Text)
            End Select
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim PeSe As TabWebKitBrowser = Me.TabControl1.SelectedTab.Tag
        PeSe.GoForward()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim PeSe As TabWebKitBrowser = Me.TabControl1.SelectedTab.Tag
        PeSe.Reload()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Try
            Dim SelectedTab As TabWebKitBrowser = Me.TabControl1.SelectedTab.Tag
            Me.Text = SelectedTab.DocumentTitle
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.CreateNuPe("", Me.TabControl1)
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If Not TabControl1.TabPages.Count = 1 Then
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            TabControl1.SelectTab(TabControl1.TabPages.Count - 1)
        End If
    End Sub
    Private Sub NuevaPestañaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaPestañaToolStripMenuItem.Click
        Me.CreateNuPe("", Me.TabControl1)
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        CreateNuPe("http://proyectoayampe.wordpress.com/", TabControl1)
    End Sub
    Private Sub CódigoFuenteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CódigoFuenteToolStripMenuItem1.Click
        Try
            Dim So As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(TextBox1.Text)
            Dim Re As System.Net.HttpWebResponse = So.GetResponse()
            Form3.Show()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(Re.GetResponseStream())
            Dim Cf As String = sr.ReadToEnd()
            Form3.RichTextBox1.Text = Cf
        Catch ex As Exception
            Me.Label1.Text = "!"
            Me.Label1.ForeColor = Color.Red
        End Try
        Return
    End Sub
    Private Sub SalirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem1.Click
        Me.Close()
    End Sub
    Private Sub NuevaPestañaToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaPestañaToolStripMenuItem2.Click
        Me.CreateNuPe("", Me.TabControl1)
    End Sub
    Private Sub VistaPreviaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaPreviaToolStripMenuItem.Click
        Dim PeSe As TabWebKitBrowser = Me.TabControl1.SelectedTab.Tag
        PeSe.ShowPrintPreviewDialog()
    End Sub
    Private Sub AcercaDeToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem2.Click
        Form2.Show()
    End Sub
    Private Sub ContribuirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContribuirToolStripMenuItem1.Click
        Me.CreateNuPe("http://proyectoayampe.wordpress.com/contribuye/", Me.TabControl1)
    End Sub
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub NuevaVentanaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevaVentanaToolStripMenuItem1.Click
        Dim NuVe As New Form1
        NuVe.Show()
    End Sub
    Private Sub VoluntariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VoluntariosToolStripMenuItem1.Click
        Dialog1.Show()
    End Sub
    Private Sub ImprimirEstaPáginaToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirEstaPáginaToolStripMenuItem.Click
        Dim PeSe As TabWebKitBrowser = Me.TabControl1.SelectedTab.Tag
        PeSe.ShowPrintDialog()
    End Sub
End Class
Public Class TabWebKitBrowser
    Inherits WebKit.WebKitBrowser
    Dim Li() As String
    Private Sub WebKitBrowser_DocumentCompleted(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles Me.DocumentCompleted
        Form1.Text = Me.DocumentTitle
        Dim Pe As TabPage = Me.Tag
        Pe.Text = Me.DocumentTitle
        Form1.Label1.Text = "✓"
        Form1.Label1.ForeColor = Color.Black()
        If Me.CanGoBack = True Then
            Form1.Button1.Enabled = True
        Else
            Form1.Button1.Enabled = False
        End If
        If Me.CanGoForward = True Then
            Form1.Button2.Enabled = True
        Else
            Form1.Button2.Enabled = False
        End If
        Try
            Form1.TextBox1.Text = Me.Url.AbsoluteUri
        Catch ex As Exception
        End Try
    End Sub
    Private Sub WebKitBrowser_Error(ByVal sender As Object, ByVal e As WebKit.WebKitBrowserErrorEventArgs) Handles Me.Error
        If My.Computer.Network.IsAvailable = False Then
            Form1.Text = "Ayampe"
            Dim Pe As TabPage = Me.Tag
            Pe.Text = Me.DocumentTitle
            Form1.Label1.Text = "!"
            Form1.Label1.ForeColor = Color.Red
        End If
    End Sub
    Private Sub WebKitBrowser_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles Me.Navigating
        Form1.Label1.Text = "∞"
        Form1.Label1.ForeColor = Color.Black()
    End Sub
End Class