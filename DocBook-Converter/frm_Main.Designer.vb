<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txt_DocBook = New System.Windows.Forms.TextBox()
        Me.btn_SelectDocBook = New System.Windows.Forms.Button()
        Me.grp_Log = New System.Windows.Forms.GroupBox()
        Me.txt_Log = New System.Windows.Forms.TextBox()
        Me.tab_TargetFormat = New System.Windows.Forms.TabControl()
        Me.tabpage_PDF = New System.Windows.Forms.TabPage()
        Me.btn_PDF_Convert = New System.Windows.Forms.Button()
        Me.grp_PDF_Settings = New System.Windows.Forms.GroupBox()
        Me.grp_PDF_Settings_Document = New System.Windows.Forms.GroupBox()
        Me.cmb_PDF_Settings_Document_Language = New System.Windows.Forms.ComboBox()
        Me.lbl_PDF_Settings_Document_Language = New System.Windows.Forms.Label()
        Me.grp_PDF_Settings_TOC = New System.Windows.Forms.GroupBox()
        Me.lbl_PDF_Settings_TOC_LabelSeparator = New System.Windows.Forms.Label()
        Me.txt_PDF_Settings_TOC_LabelSeparator = New System.Windows.Forms.TextBox()
        Me.grp_PDF_Settings_Section = New System.Windows.Forms.GroupBox()
        Me.chk_Section_Autolabel = New System.Windows.Forms.CheckBox()
        Me.grp_PDF_Settings_Body = New System.Windows.Forms.GroupBox()
        Me.lbl_body_start_indent = New System.Windows.Forms.Label()
        Me.nud_body_start_indent = New System.Windows.Forms.NumericUpDown()
        Me.grp_PDF_Settings_Chapter = New System.Windows.Forms.GroupBox()
        Me.lbl_PDF_Settings_Chapter_Autolabel = New System.Windows.Forms.Label()
        Me.cmb_PDF_Settings_Chapter_Autolabel = New System.Windows.Forms.ComboBox()
        Me.chk_xref_with_number_and_title = New System.Windows.Forms.CheckBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.sst_Strip = New System.Windows.Forms.StatusStrip()
        Me.sst_Strip_lbl_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grp_Log.SuspendLayout()
        Me.tab_TargetFormat.SuspendLayout()
        Me.tabpage_PDF.SuspendLayout()
        Me.grp_PDF_Settings.SuspendLayout()
        Me.grp_PDF_Settings_Document.SuspendLayout()
        Me.grp_PDF_Settings_TOC.SuspendLayout()
        Me.grp_PDF_Settings_Section.SuspendLayout()
        Me.grp_PDF_Settings_Body.SuspendLayout()
        CType(Me.nud_body_start_indent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_PDF_Settings_Chapter.SuspendLayout()
        Me.sst_Strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_DocBook
        '
        Me.txt_DocBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocBook.Location = New System.Drawing.Point(151, 12)
        Me.txt_DocBook.Name = "txt_DocBook"
        Me.txt_DocBook.ReadOnly = True
        Me.txt_DocBook.Size = New System.Drawing.Size(771, 20)
        Me.txt_DocBook.TabIndex = 0
        '
        'btn_SelectDocBook
        '
        Me.btn_SelectDocBook.Location = New System.Drawing.Point(12, 10)
        Me.btn_SelectDocBook.Name = "btn_SelectDocBook"
        Me.btn_SelectDocBook.Size = New System.Drawing.Size(133, 23)
        Me.btn_SelectDocBook.TabIndex = 1
        Me.btn_SelectDocBook.Text = "select DocBook file"
        Me.btn_SelectDocBook.UseVisualStyleBackColor = True
        '
        'grp_Log
        '
        Me.grp_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Log.Controls.Add(Me.txt_Log)
        Me.grp_Log.Location = New System.Drawing.Point(12, 438)
        Me.grp_Log.Name = "grp_Log"
        Me.grp_Log.Size = New System.Drawing.Size(910, 332)
        Me.grp_Log.TabIndex = 3
        Me.grp_Log.TabStop = False
        Me.grp_Log.Text = "Log"
        '
        'txt_Log
        '
        Me.txt_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Log.Location = New System.Drawing.Point(6, 19)
        Me.txt_Log.Multiline = True
        Me.txt_Log.Name = "txt_Log"
        Me.txt_Log.ReadOnly = True
        Me.txt_Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Log.Size = New System.Drawing.Size(898, 307)
        Me.txt_Log.TabIndex = 0
        Me.txt_Log.WordWrap = False
        '
        'tab_TargetFormat
        '
        Me.tab_TargetFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_TargetFormat.Controls.Add(Me.tabpage_PDF)
        Me.tab_TargetFormat.Controls.Add(Me.TabPage2)
        Me.tab_TargetFormat.Location = New System.Drawing.Point(12, 39)
        Me.tab_TargetFormat.Name = "tab_TargetFormat"
        Me.tab_TargetFormat.SelectedIndex = 0
        Me.tab_TargetFormat.Size = New System.Drawing.Size(910, 393)
        Me.tab_TargetFormat.TabIndex = 5
        '
        'tabpage_PDF
        '
        Me.tabpage_PDF.Controls.Add(Me.btn_PDF_Convert)
        Me.tabpage_PDF.Controls.Add(Me.grp_PDF_Settings)
        Me.tabpage_PDF.Location = New System.Drawing.Point(4, 22)
        Me.tabpage_PDF.Name = "tabpage_PDF"
        Me.tabpage_PDF.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_PDF.Size = New System.Drawing.Size(902, 367)
        Me.tabpage_PDF.TabIndex = 0
        Me.tabpage_PDF.Text = "PDF"
        Me.tabpage_PDF.UseVisualStyleBackColor = True
        '
        'btn_PDF_Convert
        '
        Me.btn_PDF_Convert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_PDF_Convert.Location = New System.Drawing.Point(6, 313)
        Me.btn_PDF_Convert.Name = "btn_PDF_Convert"
        Me.btn_PDF_Convert.Size = New System.Drawing.Size(890, 48)
        Me.btn_PDF_Convert.TabIndex = 6
        Me.btn_PDF_Convert.Text = "Convert to PDF"
        Me.btn_PDF_Convert.UseVisualStyleBackColor = True
        '
        'grp_PDF_Settings
        '
        Me.grp_PDF_Settings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_PDF_Settings.Controls.Add(Me.grp_PDF_Settings_Document)
        Me.grp_PDF_Settings.Controls.Add(Me.grp_PDF_Settings_TOC)
        Me.grp_PDF_Settings.Controls.Add(Me.grp_PDF_Settings_Section)
        Me.grp_PDF_Settings.Controls.Add(Me.grp_PDF_Settings_Body)
        Me.grp_PDF_Settings.Controls.Add(Me.grp_PDF_Settings_Chapter)
        Me.grp_PDF_Settings.Controls.Add(Me.chk_xref_with_number_and_title)
        Me.grp_PDF_Settings.Location = New System.Drawing.Point(6, 6)
        Me.grp_PDF_Settings.Name = "grp_PDF_Settings"
        Me.grp_PDF_Settings.Size = New System.Drawing.Size(890, 301)
        Me.grp_PDF_Settings.TabIndex = 5
        Me.grp_PDF_Settings.TabStop = False
        Me.grp_PDF_Settings.Text = "Settings"
        '
        'grp_PDF_Settings_Document
        '
        Me.grp_PDF_Settings_Document.Controls.Add(Me.cmb_PDF_Settings_Document_Language)
        Me.grp_PDF_Settings_Document.Controls.Add(Me.lbl_PDF_Settings_Document_Language)
        Me.grp_PDF_Settings_Document.Location = New System.Drawing.Point(6, 19)
        Me.grp_PDF_Settings_Document.Name = "grp_PDF_Settings_Document"
        Me.grp_PDF_Settings_Document.Size = New System.Drawing.Size(171, 100)
        Me.grp_PDF_Settings_Document.TabIndex = 8
        Me.grp_PDF_Settings_Document.TabStop = False
        Me.grp_PDF_Settings_Document.Text = "Document"
        '
        'cmb_PDF_Settings_Document_Language
        '
        Me.cmb_PDF_Settings_Document_Language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PDF_Settings_Document_Language.FormattingEnabled = True
        Me.cmb_PDF_Settings_Document_Language.Items.AddRange(New Object() {"de", "en"})
        Me.cmb_PDF_Settings_Document_Language.Location = New System.Drawing.Point(99, 13)
        Me.cmb_PDF_Settings_Document_Language.Name = "cmb_PDF_Settings_Document_Language"
        Me.cmb_PDF_Settings_Document_Language.Size = New System.Drawing.Size(66, 21)
        Me.cmb_PDF_Settings_Document_Language.TabIndex = 1
        '
        'lbl_PDF_Settings_Document_Language
        '
        Me.lbl_PDF_Settings_Document_Language.AutoSize = True
        Me.lbl_PDF_Settings_Document_Language.Location = New System.Drawing.Point(6, 16)
        Me.lbl_PDF_Settings_Document_Language.Name = "lbl_PDF_Settings_Document_Language"
        Me.lbl_PDF_Settings_Document_Language.Size = New System.Drawing.Size(55, 13)
        Me.lbl_PDF_Settings_Document_Language.TabIndex = 0
        Me.lbl_PDF_Settings_Document_Language.Text = "Language"
        '
        'grp_PDF_Settings_TOC
        '
        Me.grp_PDF_Settings_TOC.Controls.Add(Me.lbl_PDF_Settings_TOC_LabelSeparator)
        Me.grp_PDF_Settings_TOC.Controls.Add(Me.txt_PDF_Settings_TOC_LabelSeparator)
        Me.grp_PDF_Settings_TOC.Location = New System.Drawing.Point(359, 19)
        Me.grp_PDF_Settings_TOC.Name = "grp_PDF_Settings_TOC"
        Me.grp_PDF_Settings_TOC.Size = New System.Drawing.Size(171, 100)
        Me.grp_PDF_Settings_TOC.TabIndex = 7
        Me.grp_PDF_Settings_TOC.TabStop = False
        Me.grp_PDF_Settings_TOC.Text = "TOC"
        '
        'lbl_PDF_Settings_TOC_LabelSeparator
        '
        Me.lbl_PDF_Settings_TOC_LabelSeparator.AutoSize = True
        Me.lbl_PDF_Settings_TOC_LabelSeparator.Location = New System.Drawing.Point(6, 16)
        Me.lbl_PDF_Settings_TOC_LabelSeparator.Name = "lbl_PDF_Settings_TOC_LabelSeparator"
        Me.lbl_PDF_Settings_TOC_LabelSeparator.Size = New System.Drawing.Size(82, 13)
        Me.lbl_PDF_Settings_TOC_LabelSeparator.TabIndex = 1
        Me.lbl_PDF_Settings_TOC_LabelSeparator.Text = "Label Separator"
        '
        'txt_PDF_Settings_TOC_LabelSeparator
        '
        Me.txt_PDF_Settings_TOC_LabelSeparator.Location = New System.Drawing.Point(135, 13)
        Me.txt_PDF_Settings_TOC_LabelSeparator.MaxLength = 2
        Me.txt_PDF_Settings_TOC_LabelSeparator.Name = "txt_PDF_Settings_TOC_LabelSeparator"
        Me.txt_PDF_Settings_TOC_LabelSeparator.Size = New System.Drawing.Size(30, 20)
        Me.txt_PDF_Settings_TOC_LabelSeparator.TabIndex = 0
        '
        'grp_PDF_Settings_Section
        '
        Me.grp_PDF_Settings_Section.Controls.Add(Me.chk_Section_Autolabel)
        Me.grp_PDF_Settings_Section.Location = New System.Drawing.Point(713, 19)
        Me.grp_PDF_Settings_Section.Name = "grp_PDF_Settings_Section"
        Me.grp_PDF_Settings_Section.Size = New System.Drawing.Size(171, 100)
        Me.grp_PDF_Settings_Section.TabIndex = 6
        Me.grp_PDF_Settings_Section.TabStop = False
        Me.grp_PDF_Settings_Section.Text = "Section"
        '
        'chk_Section_Autolabel
        '
        Me.chk_Section_Autolabel.AutoSize = True
        Me.chk_Section_Autolabel.Location = New System.Drawing.Point(6, 15)
        Me.chk_Section_Autolabel.Name = "chk_Section_Autolabel"
        Me.chk_Section_Autolabel.Size = New System.Drawing.Size(106, 17)
        Me.chk_Section_Autolabel.TabIndex = 1
        Me.chk_Section_Autolabel.Text = "section.autolabel"
        Me.chk_Section_Autolabel.UseVisualStyleBackColor = True
        '
        'grp_PDF_Settings_Body
        '
        Me.grp_PDF_Settings_Body.Controls.Add(Me.lbl_body_start_indent)
        Me.grp_PDF_Settings_Body.Controls.Add(Me.nud_body_start_indent)
        Me.grp_PDF_Settings_Body.Location = New System.Drawing.Point(183, 19)
        Me.grp_PDF_Settings_Body.Name = "grp_PDF_Settings_Body"
        Me.grp_PDF_Settings_Body.Size = New System.Drawing.Size(171, 100)
        Me.grp_PDF_Settings_Body.TabIndex = 5
        Me.grp_PDF_Settings_Body.TabStop = False
        Me.grp_PDF_Settings_Body.Text = "Body"
        '
        'lbl_body_start_indent
        '
        Me.lbl_body_start_indent.AutoSize = True
        Me.lbl_body_start_indent.Location = New System.Drawing.Point(50, 16)
        Me.lbl_body_start_indent.Name = "lbl_body_start_indent"
        Me.lbl_body_start_indent.Size = New System.Drawing.Size(85, 13)
        Me.lbl_body_start_indent.TabIndex = 5
        Me.lbl_body_start_indent.Text = "body.start.indent"
        '
        'nud_body_start_indent
        '
        Me.nud_body_start_indent.Location = New System.Drawing.Point(6, 14)
        Me.nud_body_start_indent.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nud_body_start_indent.Name = "nud_body_start_indent"
        Me.nud_body_start_indent.Size = New System.Drawing.Size(38, 20)
        Me.nud_body_start_indent.TabIndex = 4
        '
        'grp_PDF_Settings_Chapter
        '
        Me.grp_PDF_Settings_Chapter.Controls.Add(Me.lbl_PDF_Settings_Chapter_Autolabel)
        Me.grp_PDF_Settings_Chapter.Controls.Add(Me.cmb_PDF_Settings_Chapter_Autolabel)
        Me.grp_PDF_Settings_Chapter.Location = New System.Drawing.Point(536, 19)
        Me.grp_PDF_Settings_Chapter.Name = "grp_PDF_Settings_Chapter"
        Me.grp_PDF_Settings_Chapter.Size = New System.Drawing.Size(171, 100)
        Me.grp_PDF_Settings_Chapter.TabIndex = 4
        Me.grp_PDF_Settings_Chapter.TabStop = False
        Me.grp_PDF_Settings_Chapter.Text = "Chapter"
        '
        'lbl_PDF_Settings_Chapter_Autolabel
        '
        Me.lbl_PDF_Settings_Chapter_Autolabel.AutoSize = True
        Me.lbl_PDF_Settings_Chapter_Autolabel.Location = New System.Drawing.Point(6, 16)
        Me.lbl_PDF_Settings_Chapter_Autolabel.Name = "lbl_PDF_Settings_Chapter_Autolabel"
        Me.lbl_PDF_Settings_Chapter_Autolabel.Size = New System.Drawing.Size(51, 13)
        Me.lbl_PDF_Settings_Chapter_Autolabel.TabIndex = 1
        Me.lbl_PDF_Settings_Chapter_Autolabel.Text = "Autolabel"
        '
        'cmb_PDF_Settings_Chapter_Autolabel
        '
        Me.cmb_PDF_Settings_Chapter_Autolabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PDF_Settings_Chapter_Autolabel.FormattingEnabled = True
        Me.cmb_PDF_Settings_Chapter_Autolabel.Items.AddRange(New Object() {"none", "1, 2, 3, ...", "A, B, C, ...", "a, b, c, ...", "I, II, III, ...", "i, ii, iii, ..."})
        Me.cmb_PDF_Settings_Chapter_Autolabel.Location = New System.Drawing.Point(72, 13)
        Me.cmb_PDF_Settings_Chapter_Autolabel.Name = "cmb_PDF_Settings_Chapter_Autolabel"
        Me.cmb_PDF_Settings_Chapter_Autolabel.Size = New System.Drawing.Size(93, 21)
        Me.cmb_PDF_Settings_Chapter_Autolabel.TabIndex = 0
        '
        'chk_xref_with_number_and_title
        '
        Me.chk_xref_with_number_and_title.AutoSize = True
        Me.chk_xref_with_number_and_title.Location = New System.Drawing.Point(6, 151)
        Me.chk_xref_with_number_and_title.Name = "chk_xref_with_number_and_title"
        Me.chk_xref_with_number_and_title.Size = New System.Drawing.Size(143, 17)
        Me.chk_xref_with_number_and_title.TabIndex = 1
        Me.chk_xref_with_number_and_title.Text = "xref.with.number.and.title"
        Me.chk_xref_with_number_and_title.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(978, 367)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'sst_Strip
        '
        Me.sst_Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sst_Strip_lbl_Status})
        Me.sst_Strip.Location = New System.Drawing.Point(0, 773)
        Me.sst_Strip.Name = "sst_Strip"
        Me.sst_Strip.Size = New System.Drawing.Size(934, 22)
        Me.sst_Strip.TabIndex = 6
        Me.sst_Strip.Text = "StatusStrip1"
        '
        'sst_Strip_lbl_Status
        '
        Me.sst_Strip_lbl_Status.Name = "sst_Strip_lbl_Status"
        Me.sst_Strip_lbl_Status.Size = New System.Drawing.Size(119, 17)
        Me.sst_Strip_lbl_Status.Text = "ToolStripStatusLabel1"
        '
        'frm_Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 795)
        Me.Controls.Add(Me.sst_Strip)
        Me.Controls.Add(Me.tab_TargetFormat)
        Me.Controls.Add(Me.grp_Log)
        Me.Controls.Add(Me.btn_SelectDocBook)
        Me.Controls.Add(Me.txt_DocBook)
        Me.Name = "frm_Main"
        Me.Text = "DocBook Converter"
        Me.grp_Log.ResumeLayout(False)
        Me.grp_Log.PerformLayout()
        Me.tab_TargetFormat.ResumeLayout(False)
        Me.tabpage_PDF.ResumeLayout(False)
        Me.grp_PDF_Settings.ResumeLayout(False)
        Me.grp_PDF_Settings.PerformLayout()
        Me.grp_PDF_Settings_Document.ResumeLayout(False)
        Me.grp_PDF_Settings_Document.PerformLayout()
        Me.grp_PDF_Settings_TOC.ResumeLayout(False)
        Me.grp_PDF_Settings_TOC.PerformLayout()
        Me.grp_PDF_Settings_Section.ResumeLayout(False)
        Me.grp_PDF_Settings_Section.PerformLayout()
        Me.grp_PDF_Settings_Body.ResumeLayout(False)
        Me.grp_PDF_Settings_Body.PerformLayout()
        CType(Me.nud_body_start_indent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_PDF_Settings_Chapter.ResumeLayout(False)
        Me.grp_PDF_Settings_Chapter.PerformLayout()
        Me.sst_Strip.ResumeLayout(False)
        Me.sst_Strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_DocBook As TextBox
    Friend WithEvents btn_SelectDocBook As Button
    Friend WithEvents grp_Log As GroupBox
    Friend WithEvents txt_Log As TextBox
    Friend WithEvents tab_TargetFormat As TabControl
    Friend WithEvents tabpage_PDF As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_PDF_Convert As Button
    Friend WithEvents grp_PDF_Settings As GroupBox
    Friend WithEvents chk_xref_with_number_and_title As CheckBox
    Friend WithEvents sst_Strip As StatusStrip
    Friend WithEvents sst_Strip_lbl_Status As ToolStripStatusLabel
    Friend WithEvents grp_PDF_Settings_Chapter As GroupBox
    Friend WithEvents lbl_PDF_Settings_Chapter_Autolabel As Label
    Friend WithEvents cmb_PDF_Settings_Chapter_Autolabel As ComboBox
    Friend WithEvents grp_PDF_Settings_TOC As GroupBox
    Friend WithEvents lbl_PDF_Settings_TOC_LabelSeparator As Label
    Friend WithEvents txt_PDF_Settings_TOC_LabelSeparator As TextBox
    Friend WithEvents grp_PDF_Settings_Section As GroupBox
    Friend WithEvents chk_Section_Autolabel As CheckBox
    Friend WithEvents grp_PDF_Settings_Body As GroupBox
    Friend WithEvents lbl_body_start_indent As Label
    Friend WithEvents nud_body_start_indent As NumericUpDown
    Friend WithEvents grp_PDF_Settings_Document As GroupBox
    Friend WithEvents cmb_PDF_Settings_Document_Language As ComboBox
    Friend WithEvents lbl_PDF_Settings_Document_Language As Label
End Class
