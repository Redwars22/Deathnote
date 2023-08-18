<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        MenuStrip1 = New MenuStrip()
        ArquivoToolStripMenuItem = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        ExibirToolStripMenuItem = New ToolStripMenuItem()
        InserirToolStripMenuItem = New ToolStripMenuItem()
        AjudaToolStripMenuItem = New ToolStripMenuItem()
        DeathNoteEditor = New RichTextBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.WindowFrame
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArquivoToolStripMenuItem, EditarToolStripMenuItem, ExibirToolStripMenuItem, InserirToolStripMenuItem, AjudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(696, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArquivoToolStripMenuItem
        ' 
        ArquivoToolStripMenuItem.ForeColor = Color.White
        ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        ArquivoToolStripMenuItem.Size = New Size(61, 20)
        ArquivoToolStripMenuItem.Text = "Arquivo"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.ForeColor = Color.White
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(49, 20)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' ExibirToolStripMenuItem
        ' 
        ExibirToolStripMenuItem.ForeColor = Color.White
        ExibirToolStripMenuItem.Name = "ExibirToolStripMenuItem"
        ExibirToolStripMenuItem.Size = New Size(48, 20)
        ExibirToolStripMenuItem.Text = "Exibir"
        ' 
        ' InserirToolStripMenuItem
        ' 
        InserirToolStripMenuItem.ForeColor = Color.White
        InserirToolStripMenuItem.Name = "InserirToolStripMenuItem"
        InserirToolStripMenuItem.Size = New Size(51, 20)
        InserirToolStripMenuItem.Text = "Inserir"
        ' 
        ' AjudaToolStripMenuItem
        ' 
        AjudaToolStripMenuItem.ForeColor = Color.White
        AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        AjudaToolStripMenuItem.Size = New Size(50, 20)
        AjudaToolStripMenuItem.Text = "Ajuda"
        ' 
        ' DeathNoteEditor
        ' 
        DeathNoteEditor.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DeathNoteEditor.Dock = DockStyle.Fill
        DeathNoteEditor.Font = New Font("Liberation Mono", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DeathNoteEditor.ForeColor = Color.White
        DeathNoteEditor.Location = New Point(0, 24)
        DeathNoteEditor.Name = "DeathNoteEditor"
        DeathNoteEditor.Size = New Size(696, 426)
        DeathNoteEditor.TabIndex = 1
        DeathNoteEditor.Text = ""
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(696, 450)
        Controls.Add(DeathNoteEditor)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        Opacity = 0.95R
        StartPosition = FormStartPosition.CenterScreen
        Text = "Deathnote"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExibirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InserirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeathNoteEditor As RichTextBox
End Class
