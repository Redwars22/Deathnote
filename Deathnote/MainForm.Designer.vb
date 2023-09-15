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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(MainForm))
        MenuStrip1 = New MenuStrip()
        ArquivoToolStripMenuItem = New ToolStripMenuItem()
        AbrirToolStripMenuItem = New ToolStripMenuItem()
        SalvarToolStripMenuItem = New ToolStripMenuItem()
        NovoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        SairToolStripMenuItem = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        FonteToolStripMenuItem = New ToolStripMenuItem()
        CorDoTextoToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        DesfazerToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        ColarToolStripMenuItem = New ToolStripMenuItem()
        DeletarToolStripMenuItem = New ToolStripMenuItem()
        SelecionarTudoToolStripMenuItem = New ToolStripMenuItem()
        RecortarToolStripMenuItem = New ToolStripMenuItem()
        ExibirToolStripMenuItem = New ToolStripMenuItem()
        TemaToolStripMenuItem = New ToolStripMenuItem()
        ClaroToolStripMenuItem = New ToolStripMenuItem()
        EscuroToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        ZoomToolStripMenuItem = New ToolStripMenuItem()
        ZoomToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        BarraDeStatusToolStripMenuItem = New ToolStripMenuItem()
        InserirToolStripMenuItem = New ToolStripMenuItem()
        MarkdownToolStripMenuItem = New ToolStripMenuItem()
        TítuloToolStripMenuItem = New ToolStripMenuItem()
        HTMLToolStripMenuItem = New ToolStripMenuItem()
        ParágrafoToolStripMenuItem = New ToolStripMenuItem()
        AjudaToolStripMenuItem = New ToolStripMenuItem()
        SobreODeathnoteToolStripMenuItem = New ToolStripMenuItem()
        NotasDeVersãoToolStripMenuItem = New ToolStripMenuItem()
        DeathNoteEditor = New RichTextBox()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ColorDialog1 = New ColorDialog()
        FontDialog1 = New FontDialog()
        StatusStrip1 = New StatusStrip()
        OpenFileName = New ToolStripStatusLabel()
        WordCounter = New ToolStripStatusLabel()
        NotifyIcon1 = New NotifyIcon(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlDarkDark
        MenuStrip1.Items.AddRange(New ToolStripItem() {ArquivoToolStripMenuItem, EditarToolStripMenuItem, ExibirToolStripMenuItem, InserirToolStripMenuItem, AjudaToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.RenderMode = ToolStripRenderMode.System
        MenuStrip1.Size = New Size(696, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ArquivoToolStripMenuItem
        ' 
        ArquivoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AbrirToolStripMenuItem, SalvarToolStripMenuItem, NovoToolStripMenuItem, ToolStripSeparator1, SairToolStripMenuItem})
        ArquivoToolStripMenuItem.ForeColor = Color.White
        ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        ArquivoToolStripMenuItem.Size = New Size(61, 20)
        ArquivoToolStripMenuItem.Text = "Arquivo"
        ' 
        ' AbrirToolStripMenuItem
        ' 
        AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        AbrirToolStripMenuItem.Size = New Size(105, 22)
        AbrirToolStripMenuItem.Text = "Abrir"
        ' 
        ' SalvarToolStripMenuItem
        ' 
        SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        SalvarToolStripMenuItem.Size = New Size(105, 22)
        SalvarToolStripMenuItem.Text = "Salvar"
        ' 
        ' NovoToolStripMenuItem
        ' 
        NovoToolStripMenuItem.Enabled = False
        NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        NovoToolStripMenuItem.Size = New Size(105, 22)
        NovoToolStripMenuItem.Text = "Novo"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(102, 6)
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Enabled = False
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(105, 22)
        SairToolStripMenuItem.Text = "Sair"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FonteToolStripMenuItem, CorDoTextoToolStripMenuItem, ToolStripSeparator2, DesfazerToolStripMenuItem, ToolStripSeparator3, CopiarToolStripMenuItem, ColarToolStripMenuItem, DeletarToolStripMenuItem, SelecionarTudoToolStripMenuItem, RecortarToolStripMenuItem})
        EditarToolStripMenuItem.ForeColor = Color.White
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(49, 20)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' FonteToolStripMenuItem
        ' 
        FonteToolStripMenuItem.Name = "FonteToolStripMenuItem"
        FonteToolStripMenuItem.Size = New Size(180, 22)
        FonteToolStripMenuItem.Text = "Fonte"
        ' 
        ' CorDoTextoToolStripMenuItem
        ' 
        CorDoTextoToolStripMenuItem.Name = "CorDoTextoToolStripMenuItem"
        CorDoTextoToolStripMenuItem.Size = New Size(180, 22)
        CorDoTextoToolStripMenuItem.Text = "Cor do Texto"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(177, 6)
        ' 
        ' DesfazerToolStripMenuItem
        ' 
        DesfazerToolStripMenuItem.Name = "DesfazerToolStripMenuItem"
        DesfazerToolStripMenuItem.Size = New Size(180, 22)
        DesfazerToolStripMenuItem.Text = "Desfazer"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(177, 6)
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(180, 22)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' ColarToolStripMenuItem
        ' 
        ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        ColarToolStripMenuItem.Size = New Size(180, 22)
        ColarToolStripMenuItem.Text = "Colar"
        ' 
        ' DeletarToolStripMenuItem
        ' 
        DeletarToolStripMenuItem.Enabled = False
        DeletarToolStripMenuItem.Name = "DeletarToolStripMenuItem"
        DeletarToolStripMenuItem.Size = New Size(180, 22)
        DeletarToolStripMenuItem.Text = "Deletar"
        ' 
        ' SelecionarTudoToolStripMenuItem
        ' 
        SelecionarTudoToolStripMenuItem.Name = "SelecionarTudoToolStripMenuItem"
        SelecionarTudoToolStripMenuItem.Size = New Size(180, 22)
        SelecionarTudoToolStripMenuItem.Text = "Selecionar Tudo"
        ' 
        ' RecortarToolStripMenuItem
        ' 
        RecortarToolStripMenuItem.Enabled = False
        RecortarToolStripMenuItem.Name = "RecortarToolStripMenuItem"
        RecortarToolStripMenuItem.Size = New Size(180, 22)
        RecortarToolStripMenuItem.Text = "Recortar"
        ' 
        ' ExibirToolStripMenuItem
        ' 
        ExibirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TemaToolStripMenuItem, ToolStripSeparator4, ZoomToolStripMenuItem, ZoomToolStripMenuItem1, ToolStripSeparator5, BarraDeStatusToolStripMenuItem})
        ExibirToolStripMenuItem.ForeColor = Color.White
        ExibirToolStripMenuItem.Name = "ExibirToolStripMenuItem"
        ExibirToolStripMenuItem.Size = New Size(48, 20)
        ExibirToolStripMenuItem.Text = "Exibir"
        ' 
        ' TemaToolStripMenuItem
        ' 
        TemaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ClaroToolStripMenuItem, EscuroToolStripMenuItem})
        TemaToolStripMenuItem.Enabled = False
        TemaToolStripMenuItem.Name = "TemaToolStripMenuItem"
        TemaToolStripMenuItem.Size = New Size(152, 22)
        TemaToolStripMenuItem.Text = "Tema"
        ' 
        ' ClaroToolStripMenuItem
        ' 
        ClaroToolStripMenuItem.Name = "ClaroToolStripMenuItem"
        ClaroToolStripMenuItem.Size = New Size(109, 22)
        ClaroToolStripMenuItem.Text = "Claro"
        ' 
        ' EscuroToolStripMenuItem
        ' 
        EscuroToolStripMenuItem.Name = "EscuroToolStripMenuItem"
        EscuroToolStripMenuItem.Size = New Size(109, 22)
        EscuroToolStripMenuItem.Text = "Escuro"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(149, 6)
        ' 
        ' ZoomToolStripMenuItem
        ' 
        ZoomToolStripMenuItem.Enabled = False
        ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        ZoomToolStripMenuItem.Size = New Size(152, 22)
        ZoomToolStripMenuItem.Text = "Zoom +"
        ' 
        ' ZoomToolStripMenuItem1
        ' 
        ZoomToolStripMenuItem1.Enabled = False
        ZoomToolStripMenuItem1.Name = "ZoomToolStripMenuItem1"
        ZoomToolStripMenuItem1.Size = New Size(152, 22)
        ZoomToolStripMenuItem1.Text = "Zoom -"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(149, 6)
        ' 
        ' BarraDeStatusToolStripMenuItem
        ' 
        BarraDeStatusToolStripMenuItem.Name = "BarraDeStatusToolStripMenuItem"
        BarraDeStatusToolStripMenuItem.Size = New Size(152, 22)
        BarraDeStatusToolStripMenuItem.Text = "Barra de Status"
        ' 
        ' InserirToolStripMenuItem
        ' 
        InserirToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {MarkdownToolStripMenuItem, HTMLToolStripMenuItem})
        InserirToolStripMenuItem.ForeColor = Color.White
        InserirToolStripMenuItem.Name = "InserirToolStripMenuItem"
        InserirToolStripMenuItem.Size = New Size(51, 20)
        InserirToolStripMenuItem.Text = "Inserir"
        ' 
        ' MarkdownToolStripMenuItem
        ' 
        MarkdownToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {TítuloToolStripMenuItem})
        MarkdownToolStripMenuItem.Enabled = False
        MarkdownToolStripMenuItem.Name = "MarkdownToolStripMenuItem"
        MarkdownToolStripMenuItem.Size = New Size(131, 22)
        MarkdownToolStripMenuItem.Text = "Markdown"
        ' 
        ' TítuloToolStripMenuItem
        ' 
        TítuloToolStripMenuItem.Name = "TítuloToolStripMenuItem"
        TítuloToolStripMenuItem.Size = New Size(104, 22)
        TítuloToolStripMenuItem.Text = "Título"
        ' 
        ' HTMLToolStripMenuItem
        ' 
        HTMLToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ParágrafoToolStripMenuItem})
        HTMLToolStripMenuItem.Enabled = False
        HTMLToolStripMenuItem.Name = "HTMLToolStripMenuItem"
        HTMLToolStripMenuItem.Size = New Size(131, 22)
        HTMLToolStripMenuItem.Text = "HTML"
        ' 
        ' ParágrafoToolStripMenuItem
        ' 
        ParágrafoToolStripMenuItem.Name = "ParágrafoToolStripMenuItem"
        ParágrafoToolStripMenuItem.Size = New Size(125, 22)
        ParágrafoToolStripMenuItem.Text = "Parágrafo"
        ' 
        ' AjudaToolStripMenuItem
        ' 
        AjudaToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SobreODeathnoteToolStripMenuItem, NotasDeVersãoToolStripMenuItem})
        AjudaToolStripMenuItem.ForeColor = Color.White
        AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        AjudaToolStripMenuItem.Size = New Size(50, 20)
        AjudaToolStripMenuItem.Text = "Ajuda"
        ' 
        ' SobreODeathnoteToolStripMenuItem
        ' 
        SobreODeathnoteToolStripMenuItem.Name = "SobreODeathnoteToolStripMenuItem"
        SobreODeathnoteToolStripMenuItem.Size = New Size(172, 22)
        SobreODeathnoteToolStripMenuItem.Text = "Sobre o Deathnote"
        ' 
        ' NotasDeVersãoToolStripMenuItem
        ' 
        NotasDeVersãoToolStripMenuItem.Enabled = False
        NotasDeVersãoToolStripMenuItem.Name = "NotasDeVersãoToolStripMenuItem"
        NotasDeVersãoToolStripMenuItem.Size = New Size(172, 22)
        NotasDeVersãoToolStripMenuItem.Text = "Notas de Versão"
        ' 
        ' DeathNoteEditor
        ' 
        DeathNoteEditor.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DeathNoteEditor.BorderStyle = BorderStyle.None
        DeathNoteEditor.Dock = DockStyle.Fill
        DeathNoteEditor.Font = New Font("Liberation Mono", 12F, FontStyle.Regular, GraphicsUnit.Point)
        DeathNoteEditor.ForeColor = Color.White
        DeathNoteEditor.Location = New Point(0, 24)
        DeathNoteEditor.Name = "DeathNoteEditor"
        DeathNoteEditor.Size = New Size(696, 426)
        DeathNoteEditor.TabIndex = 1
        DeathNoteEditor.Text = ""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' SaveFileDialog1
        ' 
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = SystemColors.ControlDarkDark
        StatusStrip1.Items.AddRange(New ToolStripItem() {OpenFileName, WordCounter})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(696, 22)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' OpenFileName
        ' 
        OpenFileName.ForeColor = Color.DodgerBlue
        OpenFileName.Name = "OpenFileName"
        OpenFileName.Size = New Size(138, 17)
        OpenFileName.Text = "Nenhum Arquivo Aberto"
        ' 
        ' WordCounter
        ' 
        WordCounter.ForeColor = Color.Silver
        WordCounter.Name = "WordCounter"
        WordCounter.Size = New Size(59, 17)
        WordCounter.Text = "0 palavras"
        ' 
        ' NotifyIcon1
        ' 
        NotifyIcon1.Text = "NotifyIcon1"
        NotifyIcon1.Visible = True
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(696, 450)
        Controls.Add(StatusStrip1)
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
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
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
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents FonteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorDoTextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClaroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EscuroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarkdownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TítuloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HTMLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParágrafoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents OpenFileName As ToolStripStatusLabel
    Friend WithEvents WordCounter As ToolStripStatusLabel
    Friend WithEvents SobreODeathnoteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotasDeVersãoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DesfazerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeletarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarTudoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents BarraDeStatusToolStripMenuItem As ToolStripMenuItem
End Class
