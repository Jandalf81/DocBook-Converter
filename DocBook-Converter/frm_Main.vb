Public Class frm_Main
    Public myDocBook As DocBook
    Public myFoSettings As FoSettings

#Region "Form"
    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        myFoSettings = New FoSettings()

        grp_Settings.Enabled = False
        btn_Convert.Enabled = False
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

        grp_Settings.Enabled = True
        btn_Convert.Enabled = True
    End Sub
#End Region

#Region "GUI elements"
    Private Sub btn_SelectDocBook_Click(sender As Object, e As EventArgs) Handles btn_SelectDocBook.Click
        Dim ofd As New OpenFileDialog()

        With ofd
            .Multiselect = False
            .Title = "Select DocBook XML file"
            '.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .InitialDirectory = "H:\DMI\DocBook\Beispiele\Intro to DocBook"
            .Filter = "DocBook XML|*.xml"
        End With

        If (ofd.ShowDialog() = DialogResult.OK) Then
            txt_DocBook.Text = ofd.FileName

            myDocBook = New DocBook(ofd.FileName)

            grp_Settings.Enabled = True
            btn_Convert.Enabled = True
        End If
    End Sub

    Private Sub btn_Convert_Click(sender As Object, e As EventArgs) Handles btn_Convert.Click
        If (myDocBook.validate() > 0) Then
            If (MsgBox("Are you sure you want to continue?", MsgBoxStyle.YesNo) = DialogResult.No) Then
                log("Conversion canceled by user")
                Exit Sub
            End If
        End If

        myDocBook.convertXmlToFo(myFoSettings)
        myDocBook.convertFoToPDF()
    End Sub
#End Region
End Class
