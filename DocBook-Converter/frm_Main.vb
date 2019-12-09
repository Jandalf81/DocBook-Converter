Public Class frm_Main
    Public myDocBook As DocBook
    Public myFOsettings As FoSettings

#Region "Form"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        myFOsettings = New FoSettings()

        grp_PDF_Settings.Enabled = False
        btn_PDF_Convert.Enabled = False

        sst_Strip_lbl_Status.Text = "Waiting for DocBook XML file..."
    End Sub

    Private Sub frm_Main_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub frm_Main_DragDrop(sender As Object, e As DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)

        If files.Count() > 1 Then
            MsgBox("Please drop only one DocBook simultaneously")
            Exit Sub
        End If

        If IO.Path.GetExtension(files(0).ToString) <> ".xml" Then
            MsgBox("Please drop only DocBooks in XML format")
            Exit Sub
        End If

        txt_DocBook.Text = files(0).ToString

        myDocBook = New DocBook(files(0).ToString)

        ' load FOsettings from file next to DocBook
        Select Case myFOsettings.load(IO.Path.GetDirectoryName(myDocBook.Path) & "\.FOsettings")
            Case 0
                sst_Strip_lbl_Status.Text = "Found and loaded .FOsettings file"

                FOsettings2GUI()
            Case -1
                sst_Strip_lbl_Status.Text = "No .FOsettings file found"
        End Select


        grp_PDF_Settings.Enabled = True
        btn_PDF_Convert.Enabled = True
    End Sub
#End Region

#Region "GUI elements"
    Private Sub btn_SelectDocBook_Click(sender As Object, e As EventArgs) Handles btn_SelectDocBook.Click
        Dim ofd As New OpenFileDialog()

        With ofd
            .Multiselect = False
            .Title = "Select DocBook XML file"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            '.InitialDirectory = "H:\DMI\DocBook\Beispiele\Intro to DocBook"
            .Filter = "DocBook XML|*.xml"
        End With

        If (ofd.ShowDialog() = DialogResult.OK) Then
            txt_DocBook.Text = ofd.FileName

            myDocBook = New DocBook(ofd.FileName)

            ' load FOsettings from file next to DocBook
            Select Case myFOsettings.load(IO.Path.GetDirectoryName(myDocBook.Path) & "\.FOsettings")
                Case 0
                    sst_Strip_lbl_Status.Text = "Found and loaded .FOsettings file"

                    FOsettings2GUI()
                Case -1
                    sst_Strip_lbl_Status.Text = "No .FOsettings file found"
            End Select

            grp_PDF_Settings.Enabled = True
            btn_PDF_Convert.Enabled = True
        End If
    End Sub

#Region "tab page PDF"
    Private Sub btn_PDF_Convert_Click(sender As Object, e As EventArgs) Handles btn_PDF_Convert.Click
        If (myDocBook.validate() > 0) Then
            If (MsgBox("Are you sure you want to continue?", MsgBoxStyle.YesNo) = DialogResult.No) Then
                log("Conversion canceled by user")
                Exit Sub
            End If
        End If

        ' read settings from tab page into myFoSettings
        GUI2FOsettings()

        ' save FOsettings into file next to DocBook
        Select Case myFOsettings.save(IO.Path.GetDirectoryName(myDocBook.Path) & "\.FOsettings")
            Case 0
                sst_Strip_lbl_Status.Text = "Saved .FOsettings file"
            Case -1
                sst_Strip_lbl_Status.Text = "Error while saving .FOsettings file"
        End Select

        myDocBook.convertXMLtoFO(myFOsettings)
        myDocBook.convertFOtoPDF()
    End Sub
#End Region

#End Region

#Region "functions"
    Private Sub GUI2FOsettings()
        ' Document
        myFOsettings.l10n_gentext_default_language = cmb_PDF_Settings_Document_Language.SelectedItem

        ' Body
        myFOsettings.body_start_indent = nud_body_start_indent.Value

        ' TOC
        myFOsettings.autotoc_label_separator = txt_PDF_Settings_TOC_LabelSeparator.Text

        ' Chapter
        Select Case cmb_PDF_Settings_Chapter_Autolabel.SelectedIndex
            Case 0
                myFOsettings.chapter_autolabel = "0"
            Case 1
                myFOsettings.chapter_autolabel = "1"
            Case 2
                myFOsettings.chapter_autolabel = "A"
            Case 3
                myFOsettings.chapter_autolabel = "a"
            Case 4
                myFOsettings.chapter_autolabel = "I"
            Case 5
                myFOsettings.chapter_autolabel = "i"
        End Select

        ' Section
        myFOsettings.section_autolabel = chk_Section_Autolabel.Checked


        myFOsettings.xref_with_number_and_title = chk_xref_with_number_and_title.Checked
    End Sub

    Private Sub FOsettings2GUI()
        ' Document
        cmb_PDF_Settings_Document_Language.SelectedItem = myFOsettings.l10n_gentext_default_language

        ' Body
        nud_body_start_indent.Value = myFOsettings.body_start_indent

        ' TOC
        txt_PDF_Settings_TOC_LabelSeparator.Text = myFOsettings.autotoc_label_separator

        ' Chapter
        Select Case myFOsettings.chapter_autolabel
            Case "0"
                cmb_PDF_Settings_Chapter_Autolabel.SelectedIndex = 0
            Case "1"
                cmb_PDF_Settings_Chapter_Autolabel.SelectedIndex = 1
            Case "A"
                cmb_PDF_Settings_Chapter_Autolabel.SelectedIndex = 2
            Case "a"
                cmb_PDF_Settings_Chapter_Autolabel.SelectedIndex = 3
            Case "I"
                cmb_PDF_Settings_Chapter_Autolabel.SelectedIndex = 4
            Case "i"
                cmb_PDF_Settings_Chapter_Autolabel.SelectedIndex = 5
        End Select

        ' Section
        chk_Section_Autolabel.Checked = myFOsettings.section_autolabel


        chk_xref_with_number_and_title.Checked = myFOsettings.xref_with_number_and_title
    End Sub
#End Region
End Class
