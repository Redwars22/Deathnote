Imports System.IO

Public Class MainForm
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
End Class
