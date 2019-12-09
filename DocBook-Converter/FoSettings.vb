Public Class FoSettings
    ' DocBook
    Public l10n_gentext_default_language As String

    ' Body
    Public body_start_indent As Integer

    ' TOC
    Public autotoc_label_separator As String

    ' Chapter
    Public chapter_autolabel As String

    ' Section
    Public section_autolabel As Boolean


    Public xref_with_number_and_title As Boolean


    Public Sub New()
    End Sub

    Public Function save(INpath As String) As Integer
        Dim retval As Integer = 0

        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)
        Dim fileWriter As IO.StreamWriter

        Try
            fileWriter = My.Computer.FileSystem.OpenTextFileWriter(INpath, False)
            x.Serialize(fileWriter, Me)
            fileWriter.Close()
        Catch
            retval = -1
        End Try

        Return retval
    End Function

    Public Function load(INpath As String) As Integer
        Dim retval As Integer = 0

        Dim IFoSettings As New FoSettings()
        Dim x As New Xml.Serialization.XmlSerializer(Me.GetType)

        If (My.Computer.FileSystem.FileExists(INpath)) Then
            ' FOsettings file exists, read values
            Using fs As New IO.FileStream(INpath, IO.FileMode.Open)
                IFoSettings = x.Deserialize(fs)
            End Using
        Else
            ' FOsettings file does not exist
            retval = -1
        End If

        ' DocBook
        Me.l10n_gentext_default_language = IFoSettings.l10n_gentext_default_language

        ' Body
        Me.body_start_indent = IFoSettings.body_start_indent

        ' TOC
        Me.autotoc_label_separator = IFoSettings.autotoc_label_separator

        ' Chapter
        Me.chapter_autolabel = IFoSettings.chapter_autolabel

        ' Section
        Me.section_autolabel = IFoSettings.section_autolabel


        Me.xref_with_number_and_title = IFoSettings.xref_with_number_and_title


        Return retval
    End Function
End Class
