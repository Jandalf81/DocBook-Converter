<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txt_DocBook = New System.Windows.Forms.TextBox()
        Me.btn_SelectDocBook = New System.Windows.Forms.Button()
        Me.grp_Settings = New System.Windows.Forms.GroupBox()
        Me.grp_Log = New System.Windows.Forms.GroupBox()
        Me.txt_Log = New System.Windows.Forms.TextBox()
        Me.btn_Convert = New System.Windows.Forms.Button()
        Me.chk_Section_Autolabel = New System.Windows.Forms.CheckBox()
        Me.chk_xref_with_number_and_title = New System.Windows.Forms.CheckBox()
        Me.nud_body_start_indent = New System.Windows.Forms.NumericUpDown()
        Me.lbl_body_start_indent = New System.Windows.Forms.Label()
        Me.grp_Settings.SuspendLayout()
        Me.grp_Log.SuspendLayout()
        CType(Me.nud_body_start_indent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_DocBook
        '
        Me.txt_DocBook.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_DocBook.Location = New System.Drawing.Point(151, 12)
        Me.txt_DocBook.Name = "txt_DocBook"
        Me.txt_DocBook.ReadOnly = True
        Me.txt_DocBook.Size = New System.Drawing.Size(620, 20)
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
        'grp_Settings
        '
        Me.grp_Settings.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Settings.Controls.Add(Me.lbl_body_start_indent)
        Me.grp_Settings.Controls.Add(Me.nud_body_start_indent)
        Me.grp_Settings.Controls.Add(Me.chk_xref_with_number_and_title)
        Me.grp_Settings.Controls.Add(Me.chk_Section_Autolabel)
        Me.grp_Settings.Location = New System.Drawing.Point(12, 38)
        Me.grp_Settings.Name = "grp_Settings"
        Me.grp_Settings.Size = New System.Drawing.Size(759, 106)
        Me.grp_Settings.TabIndex = 2
        Me.grp_Settings.TabStop = False
        Me.grp_Settings.Text = "Settings"
        '
        'grp_Log
        '
        Me.grp_Log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Log.Controls.Add(Me.txt_Log)
        Me.grp_Log.Location = New System.Drawing.Point(12, 204)
        Me.grp_Log.Name = "grp_Log"
        Me.grp_Log.Size = New System.Drawing.Size(759, 192)
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
        Me.txt_Log.Size = New System.Drawing.Size(747, 167)
        Me.txt_Log.TabIndex = 0
        Me.txt_Log.WordWrap = False
        '
        'btn_Convert
        '
        Me.btn_Convert.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Convert.Location = New System.Drawing.Point(12, 150)
        Me.btn_Convert.Name = "btn_Convert"
        Me.btn_Convert.Size = New System.Drawing.Size(759, 48)
        Me.btn_Convert.TabIndex = 4
        Me.btn_Convert.Text = "Convert"
        Me.btn_Convert.UseVisualStyleBackColor = True
        '
        'chk_Section_Autolabel
        '
        Me.chk_Section_Autolabel.AutoSize = True
        Me.chk_Section_Autolabel.Location = New System.Drawing.Point(6, 19)
        Me.chk_Section_Autolabel.Name = "chk_Section_Autolabel"
        Me.chk_Section_Autolabel.Size = New System.Drawing.Size(106, 17)
        Me.chk_Section_Autolabel.TabIndex = 0
        Me.chk_Section_Autolabel.Text = "section.autolabel"
        Me.chk_Section_Autolabel.UseVisualStyleBackColor = True
        '
        'chk_xref_with_number_and_title
        '
        Me.chk_xref_with_number_and_title.AutoSize = True
        Me.chk_xref_with_number_and_title.Location = New System.Drawing.Point(6, 42)
        Me.chk_xref_with_number_and_title.Name = "chk_xref_with_number_and_title"
        Me.chk_xref_with_number_and_title.Size = New System.Drawing.Size(143, 17)
        Me.chk_xref_with_number_and_title.TabIndex = 1
        Me.chk_xref_with_number_and_title.Text = "xref.with.number.and.title"
        Me.chk_xref_with_number_and_title.UseVisualStyleBackColor = True
        '
        'nud_body_start_indent
        '
        Me.nud_body_start_indent.Location = New System.Drawing.Point(6, 66)
        Me.nud_body_start_indent.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        Me.nud_body_start_indent.Name = "nud_body_start_indent"
        Me.nud_body_start_indent.Size = New System.Drawing.Size(38, 20)
        Me.nud_body_start_indent.TabIndex = 2
        '
        'lbl_body_start_indent
        '
        Me.lbl_body_start_indent.AutoSize = True
        Me.lbl_body_start_indent.Location = New System.Drawing.Point(50, 68)
        Me.lbl_body_start_indent.Name = "lbl_body_start_indent"
        Me.lbl_body_start_indent.Size = New System.Drawing.Size(85, 13)
        Me.lbl_body_start_indent.TabIndex = 3
        Me.lbl_body_start_indent.Text = "body.start.indent"
        '
        'frm_Main
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 408)
        Me.Controls.Add(Me.btn_Convert)
        Me.Controls.Add(Me.grp_Log)
        Me.Controls.Add(Me.grp_Settings)
        Me.Controls.Add(Me.btn_SelectDocBook)
        Me.Controls.Add(Me.txt_DocBook)
        Me.Name = "frm_Main"
        Me.Text = "DocBook Converter"
        Me.grp_Settings.ResumeLayout(False)
        Me.grp_Settings.PerformLayout()
        Me.grp_Log.ResumeLayout(False)
        Me.grp_Log.PerformLayout()
        CType(Me.nud_body_start_indent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_DocBook As TextBox
    Friend WithEvents btn_SelectDocBook As Button
    Friend WithEvents grp_Settings As GroupBox
    Friend WithEvents grp_Log As GroupBox
    Friend WithEvents txt_Log As TextBox
    Friend WithEvents btn_Convert As Button
    Friend WithEvents lbl_body_start_indent As Label
    Friend WithEvents nud_body_start_indent As NumericUpDown
    Friend WithEvents chk_xref_with_number_and_title As CheckBox
    Friend WithEvents chk_Section_Autolabel As CheckBox
End Class
