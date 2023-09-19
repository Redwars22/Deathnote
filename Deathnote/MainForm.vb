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
        'Dim welcome As String = "welcome.txt"
        'Dim content As String = System.IO.File.ReadAllText(welcome)
        'UpdateText(content)
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
        Await HTMLView.WebView21.EnsureCoreWebView2Async()
        Await HTMLView.WebView21.ExecuteScriptAsync("document.body.innerHTML = " + Chr(34) + src + Chr(34))
    End Sub

    Private Sub HandleHTMLWrapTag(tag As String)
        DeathNoteEditor.SelectedText = "<" + tag + ">" + DeathNoteEditor.SelectedText + "</" + tag + ">"
    End Sub

    Private Sub HandleAddHTMLSnippet(type As String)
        Dim snippet As String = ""

        If type = "img" Then
            snippet = "<img src=" & Chr(34) & Chr(34) & " alt=" & Chr(34) & Chr(34) & "/>"
        ElseIf type = "input" Then
            snippet = "<input type=" & Chr(34) & Chr(34) & "/>"
        ElseIf type = "link" Then
            snippet = "<a href=" & Chr(34) & Chr(34) & "></a>"
        ElseIf type = "button" Then
            snippet = "<button onclick=" & Chr(34) & Chr(34) & "></button>"
        ElseIf type = "link-css" Then
            snippet = "<link rel=" & Chr(34) & "stylesheet" & Chr(34) & "type=" & Chr(34) & "text/css" & Chr(34) & "href=" & Chr(34) & "styles.css" & Chr(34) & "/>"
        ElseIf type = "script" Then
            snippet = "<script></script>"
        ElseIf type = "script-ext" Then
            snippet = "<script src=" & Chr(34) & Chr(34) & ">"
        End If

        DeathNoteEditor.SelectedText = snippet
    End Sub

    Private Sub ParágrafoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParágrafoToolStripMenuItem.Click
        HandleHTMLWrapTag("p")
    End Sub

    Private Sub SpanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpanToolStripMenuItem.Click
        HandleHTMLWrapTag("span")
    End Sub

    Private Sub H1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H1ToolStripMenuItem.Click
        HandleHTMLWrapTag("h1")
    End Sub

    Private Sub H2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H2ToolStripMenuItem.Click
        HandleHTMLWrapTag("h2")
    End Sub

    Private Sub H3ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H3ToolStripMenuItem.Click
        HandleHTMLWrapTag("h3")
    End Sub

    Private Sub H4ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H4ToolStripMenuItem.Click
        HandleHTMLWrapTag("h4")
    End Sub

    Private Sub H5ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H5ToolStripMenuItem.Click
        HandleHTMLWrapTag("h5")
    End Sub

    Private Sub H6ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles H6ToolStripMenuItem.Click
        HandleHTMLWrapTag("h6")
    End Sub

    Private Sub DivToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DivToolStripMenuItem.Click
        HandleHTMLWrapTag("div")
    End Sub

    Private Sub InputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputToolStripMenuItem.Click
        HandleAddHTMLSnippet("input")
    End Sub

    Private Sub ImagemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImagemToolStripMenuItem.Click
        HandleAddHTMLSnippet("img")
    End Sub

    Private Sub LinkToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LinkToolStripMenuItem1.Click
        HandleAddHTMLSnippet("link")
    End Sub

    Private Sub BotãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BotãoToolStripMenuItem.Click
        HandleAddHTMLSnippet("button")
    End Sub

    Private Sub MainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MainToolStripMenuItem.Click
        HandleHTMLWrapTag("main")
    End Sub

    Private Sub HeaderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HeaderToolStripMenuItem.Click
        HandleHTMLWrapTag("header")
    End Sub

    Private Sub FolhaDeEstiloExternaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FolhaDeEstiloExternaToolStripMenuItem.Click
        HandleAddHTMLSnippet("link-css")
    End Sub

    Private Sub ScriptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptToolStripMenuItem.Click
        HandleAddHTMLSnippet("script")
    End Sub

    Private Sub ScriptExternoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScriptExternoToolStripMenuItem.Click
        HandleAddHTMLSnippet("script-ext")
    End Sub

    Private Sub QuebraDeLinhaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuebraDeLinhaToolStripMenuItem.Click
        If DeathNoteEditor.WordWrap Then
            DeathNoteEditor.WordWrap = False
            QuebraDeLinhaToolStripMenuItem.Checked = False
        Else
            DeathNoteEditor.WordWrap = True
            QuebraDeLinhaToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub HandleAddMarkdownSnippets(before As String, after As String)
        DeathNoteEditor.SelectedText = before + DeathNoteEditor.SelectedText + after
    End Sub

    Private Sub TítuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TítuloToolStripMenuItem.Click
        HandleAddMarkdownSnippets("# ", "")
    End Sub

    Private Sub SubtítuloNível1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubtítuloNível1ToolStripMenuItem.Click
        HandleAddMarkdownSnippets("## ", "")
    End Sub

    Private Sub SubtítuloNível2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SubtítuloNível2ToolStripMenuItem.Click
        HandleAddMarkdownSnippets("### ", "")
    End Sub

    Private Sub ItemDeListaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemDeListaToolStripMenuItem.Click
        HandleAddMarkdownSnippets("- ", "")
    End Sub

    Private Sub LinkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkToolStripMenuItem.Click
        HandleAddMarkdownSnippets("[", "](https://)")
    End Sub

    Private Sub CódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CódigoToolStripMenuItem.Click
        HandleAddMarkdownSnippets("`", "`")
    End Sub

    Private Sub CitaçãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CitaçãoToolStripMenuItem.Click
        HandleAddMarkdownSnippets("> ", "")
    End Sub

    Private Sub BlocoDeCódigoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlocoDeCódigoToolStripMenuItem.Click
        HandleAddMarkdownSnippets("```" + vbCrLf, vbCrLf + "```")
    End Sub

    Private Sub NegritoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NegritoToolStripMenuItem.Click
        HandleAddMarkdownSnippets("**", "**")
    End Sub

    Private Sub ItálicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItálicoToolStripMenuItem.Click
        HandleAddMarkdownSnippets("*", "*")
    End Sub

    Private Sub ItálicoENegritoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItálicoENegritoToolStripMenuItem.Click
        HandleAddMarkdownSnippets("***", "***")
    End Sub

    Private Sub LinhaHorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinhaHorizontalToolStripMenuItem.Click
        DeathNoteEditor.SelectedText = vbCrLf + "---" + vbCrLf
    End Sub

    Private Async Sub HandleWebView(url As String)
        HTMLView.Show()
        Await HTMLView.WebView21.EnsureCoreWebView2Async()
        HTMLView.WebView21.Source = "https://google.com"
    End Sub

    Private Sub NotasDeVersãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotasDeVersãoToolStripMenuItem.Click

    End Sub
End Class
