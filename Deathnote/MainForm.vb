Imports System.IO
Imports System.Drawing.Printing

Public Class MainForm
    Dim fileTypes As String = ""
    Dim clipboard As String
    Dim statusBarVisible As Boolean = True
    Dim theme As String

    Public Function CheckIfTextSavedBeforeExiting() As Boolean
        If DeathNoteEditor.Text <> "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub HandleTheme()
        If theme = "dark" Then
            EscuroToolStripMenuItem.Checked = True
            ClaroToolStripMenuItem.Checked = False
            DeathNoteEditor.BackColor = System.Drawing.SystemColors.ControlDarkDark
            DeathNoteEditor.ForeColor = Color.White
            StatusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
            StatusStrip1.ForeColor = Color.Silver
            MenuStrip1.BackColor = Color.FromArgb(64, 64, 64)
            MenuStrip1.ForeColor = Color.DarkGray
            Me.Opacity = 95
        Else
            EscuroToolStripMenuItem.Checked = False
            ClaroToolStripMenuItem.Checked = True
            DeathNoteEditor.BackColor = Color.LightGray
            DeathNoteEditor.ForeColor = Color.FromArgb(64, 64, 64)
            StatusStrip1.BackColor = Color.GhostWhite
            StatusStrip1.ForeColor = Color.DarkGray
            'MenuStrip1.BackColor = Color.GhostWhite
            'MenuStrip1.ForeColor = Color.DarkGray
            Me.Opacity = 100
        End If
    End Sub

    Public Sub HandleSave()
        'SaveFileDialog1.Filter = "Arquivo Deathnote (*.dth^)|*.dth^"'

        SaveFileDialog1.CheckFileExists = True
        SaveFileDialog1.CheckPathExists = True

        If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, DeathNoteEditor.Text, FileAccess.Write)
        End If
    End Sub

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
        theme = "dark"
        HandleTheme()

        If statusBarVisible Then
            BarraDeStatusToolStripMenuItem.Checked = statusBarVisible
        End If
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
        HandleSave()
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
        clipboard = DeathNoteEditor.SelectedText
        DeathNoteEditor.Text = DeathNoteEditor.Text.Remove(DeathNoteEditor.SelectedText, DeathNoteEditor.SelectionLength)
    End Sub

    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Clipboard = DeathNoteEditor.SelectedText
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub NovoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoToolStripMenuItem.Click
        Dim newWindow As New MainForm
        newWindow.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Dim checkBefore As Boolean = CheckIfTextSavedBeforeExiting()

        If checkBefore Then
            MsgBox("Você tem alterações que não foram salvas!", MsgBoxStyle.Question, "Ei, espera!")

            If MsgBoxResult.Yes Then
                HandleSave()
                Me.Close()
                Return
            End If
        End If

        Me.Close()
    End Sub

    Private Sub ClaroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClaroToolStripMenuItem.Click
        theme = "light"
        HandleTheme()
    End Sub

    Private Sub EscuroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscuroToolStripMenuItem.Click
        theme = "dark"
        HandleTheme()
    End Sub

    Private Sub ZoomToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem2.Click
        DeathNoteEditor.ZoomFactor = 2.0F
        ZoomToolStripMenuItem2.Checked = True
        NormalToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem3.Checked = False
    End Sub

    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        DeathNoteEditor.ZoomFactor = 1.0F
        ZoomToolStripMenuItem2.Checked = False
        NormalToolStripMenuItem.Checked = True
        ZoomToolStripMenuItem3.Checked = False
    End Sub

    Private Sub ZoomToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ZoomToolStripMenuItem3.Click
        DeathNoteEditor.ZoomFactor = 0.9F
        ZoomToolStripMenuItem2.Checked = False
        NormalToolStripMenuItem.Checked = False
        ZoomToolStripMenuItem3.Checked = True
    End Sub

    Private Sub SobreODeathnoteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SobreODeathnoteToolStripMenuItem.Click
        MsgBox("© 2023. AndrewNation. Todos os Direitos Reservados", MsgBoxStyle.Information, "Sobre o Deathnote para Windows")
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        DeathNoteEditor.Redo()
    End Sub

    Private Sub DeletarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeletarToolStripMenuItem.Click
        If DeathNoteEditor.SelectionLength > 0 Then
            DeathNoteEditor.Text = ""
        End If
    End Sub

    Private Sub DataEHoraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataEHoraToolStripMenuItem.Click
        DeathNoteEditor.SelectedText = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Async Sub PréviaHTMLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PréviaHTMLToolStripMenuItem.Click
        Dim src = DeathNoteEditor.Text
        HTMLView.Show()
        Await HTMLView.WebView21.ExecuteScriptAsync("document.body.innerHTML = '" + src + "'")
    End Sub
End Class
