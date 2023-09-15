Imports System.IO
Imports System.Drawing.Printing

Public Class MainForm
    Dim fileTypes As String = ""
    Dim clipboard As String
    Dim statusBarVisible As Boolean = True

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

        If statusBarVisible Then
            BarraDeStatusToolStripMenuItem.Checked = statusBarVisible
        End If
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
                OpenFileName.Text = OpenFileDialog1.FileName
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

        WordCounter.Text = wordcount.ToString() + " " + str
    End Sub

    Private Sub DeathNoteEditor_TextChanged(sender As Object, e As EventArgs) Handles DeathNoteEditor.TextChanged
        UpdateWordCount(DeathNoteEditor.Text)
    End Sub

    Private Sub AjudaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjudaToolStripMenuItem.Click
        MsgBox("© 2023. AndrewNation. Todos os Direitos Reservados", MsgBoxStyle.Information, "Sobre o Deathnote para Windows")
    End Sub

    Private Sub SelecionarTudoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarTudoToolStripMenuItem.Click
        DeathNoteEditor.SelectAll()
    End Sub

    Private Sub DesfazerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesfazerToolStripMenuItem.Click
        DeathNoteEditor.Undo()
    End Sub

    Private Sub BarraDeStatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarraDeStatusToolStripMenuItem.Click
        If statusBarVisible Then
            statusBarVisible = False
        Else
            statusBarVisible = True
        End If

        BarraDeStatusToolStripMenuItem.Checked = statusBarVisible
        StatusStrip1.Visible = statusBarVisible
    End Sub

    Private Sub ColarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColarToolStripMenuItem.Click
        If clipboard IsNot "" Then
            DeathNoteEditor.Text += clipboard
            clipboard = ""
            Return
        End If

        DeathNoteEditor.Paste()
    End Sub

    Private Sub RecortarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecortarToolStripMenuItem.Click
        'Clipboard = DeathNoteEditor.SelectedText
        'DeathNoteEditor.Text = DeathNoteEditor.Text.Remove(DeathNoteEditor.SelectedText, DeathNoteEditor.SelectionLength)
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Clipboard = DeathNoteEditor.SelectedText
    End Sub
End Class
