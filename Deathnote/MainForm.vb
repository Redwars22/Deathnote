Imports System.IO

Public Class MainForm
    Dim fileTypes As String = ""

    Private Sub UpdateText(text As String)
        DeathNoteEditor.Text = text
    End Sub
    Private Sub LoadWelcomeText()
        Dim welcome As String = "welcome.txt"
        Dim content As String = System.IO.File.ReadAllText(welcome)
        UpdateText(content)
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWelcomeText()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        Dim fileReader As System.IO.StreamReader

        'OpenFileDialog1.Filter = "Arquivo Deathnote (*.dth^)|*.txt^"'
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.Title = "Escolha um arquivo"

        If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Try
                OpenFileDialog1.OpenFile()
                fileReader = System.IO.File.OpenText(OpenFileDialog1.FileName)
                DeathNoteEditor.Text = fileReader.ReadToEnd()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
        End If
    End Sub

    Private Sub SalvarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalvarToolStripMenuItem.Click
        'SaveFileDialog1.Filter = "Arquivo Deathnote (*.dth^)|*.dth^"'

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, DeathNoteEditor.Text, FileAccess.Write)
        End If
    End Sub

    Private Sub FonteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FonteToolStripMenuItem.Click
        FontDialog1.ShowDialog()

        DeathNoteEditor.Font = FontDialog1.Font()
    End Sub

    Private Sub CorDoTextoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorDoTextoToolStripMenuItem.Click
        ColorDialog1.ShowDialog()

        DeathNoteEditor.ForeColor = ColorDialog1.Color()
    End Sub

    Private Sub UpdateWordCount(text As String)
        Static rex As New System.Text.RegularExpressions.Regex("\b", System.Text.RegularExpressions.RegexOptions.Compiled Or System.Text.RegularExpressions.RegexOptions.Multiline)
        Dim wordcount As Integer = (rex.Matches(DeathNoteEditor.Text).Count / 2)
        Dim str As String

        If Not wordcount = 1 Then
            str = "palavras"
        Else
            str = "palavra"
        End If

        WordCounter.Text = wordcount.ToString() + str
    End Sub

    Private Sub DeathNoteEditor_TextChanged(sender As Object, e As EventArgs) Handles DeathNoteEditor.TextChanged
        UpdateWordCount(DeathNoteEditor.Text)
    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click
        MsgBox("aaa", MsgBoxStyle.Information, "Sobre o Deathnote")
    End Sub
End Class
