Public Class Form3
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = Form1.TabControl1.SelectedTab.Text & " - Código fuente"
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim GuardarArchivo As New SaveFileDialog
        GuardarArchivo.FileName = ""
        GuardarArchivo.Filter = "Archivo de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*)"
        GuardarArchivo.Title = "Guardar"
        GuardarArchivo.ShowDialog()
        Try
            Dim Escribir As New System.IO.StreamWriter(GuardarArchivo.FileName)
            Escribir.Write(RichTextBox1.Text)
            Escribir.Close()
            MsgBox("Guardado.")
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub
End Class