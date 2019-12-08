Public Class DocBook
    Private _Path As String

    Private Shared processOutput As System.Text.StringBuilder = Nothing

    Public Property Path As String
        Get
            Return _Path
        End Get
        Set(value As String)
            _Path = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(INpath As String)
        Me.Path = INpath
    End Sub

    Public Function validate() As Integer
        Dim retval As Integer = 0

        processOutput = New System.Text.StringBuilder()

        log("Validating " & Me.Path & "...")

        Dim xsd As String = My.Application.Info.DirectoryPath + "\xsd\docbook.xsd"

        Dim xmlstarlet As New Process()
        With xmlstarlet
            .StartInfo.FileName = My.Application.Info.DirectoryPath + "\xmlstarlet\xml.exe"
            .StartInfo.Arguments = "val --err --xsd """ & xsd & """ """ & Me.Path & """"
            .StartInfo.RedirectStandardOutput = True
            .StartInfo.RedirectStandardError = True
            .StartInfo.CreateNoWindow = True
            .StartInfo.UseShellExecute = False
        End With

        log(vbTab & "CMD: " & xmlstarlet.StartInfo.FileName & " " & xmlstarlet.StartInfo.Arguments)

        AddHandler xmlstarlet.OutputDataReceived, AddressOf OutputHandler
        AddHandler xmlstarlet.ErrorDataReceived, AddressOf OutputHandler

        xmlstarlet.Start()
        xmlstarlet.BeginOutputReadLine()
        xmlstarlet.BeginErrorReadLine()
        xmlstarlet.WaitForExit()

        If xmlstarlet.ExitCode = 0 Then
            log(vbTab & "Validation finished OK")
        Else
            log(vbTab & "Validation finished with ERRORS (ExitCode " & xmlstarlet.ExitCode & ")" & vbCrLf & "--------------------" & vbCrLf & processOutput.ToString() & "--------------------")
            retval = xmlstarlet.ExitCode
        End If

        xmlstarlet.Close()
        xmlstarlet.Dispose()

        Return retval
    End Function

    Public Function convertXmlToFo(INFoSettings As FoSettings) As Integer
        Dim retval As Integer = 0

        log("Converting " & Me.Path & " to FO...")

        Dim stylesheets As String = My.Application.Info.DirectoryPath + "\stylesheets\fo\docbook.xsl"
        Dim filepath As String = IO.Path.GetDirectoryName(Me.Path) & "\"
        Dim filename As String = IO.Path.GetFileNameWithoutExtension(Me.Path)
        Dim fileext As String = IO.Path.GetExtension(Me.Path)

        Dim xsltproc As New Process()
        With xsltproc
            .StartInfo.FileName = My.Application.Info.DirectoryPath + "\xsltproc\xsltproc.exe"
            .StartInfo.Arguments = "--xinclude --nonet --output """ & filepath & filename & ".fo"" """ & stylesheets & """ """ & Me.Path & """"
            .StartInfo.CreateNoWindow = True
            .StartInfo.UseShellExecute = False
        End With

        ' TODO add to ARGUMENTS: --stringparam section.autolabel 1 --stringparam xref.with.number.and.title 0 --stringparam body.start.indent 0mm

        log(vbTab & "CMD: " & xsltproc.StartInfo.FileName & " " & xsltproc.StartInfo.Arguments)

        xsltproc.Start()
        xsltproc.WaitForExit()

        If xsltproc.ExitCode = 0 Then
            log(vbTab & "Converting to FO finished OK")
        Else
            log(vbTab & "Converting to FO finished with ERRORS (ExitCode " & xsltproc.ExitCode & ")")
            retval = xsltproc.ExitCode
        End If

        xsltproc.Close()
        xsltproc.Dispose()

        Return retval
    End Function

    Public Function convertFoToPDF() As Integer
        Dim retval As Integer = 0

        Dim filepath As String = IO.Path.GetDirectoryName(Me.Path) & "\"
        Dim filename As String = IO.Path.GetFileNameWithoutExtension(Me.Path)

        log("Converting " & filepath & filename & ".fo to PDF...")

        Dim fop As New Process()
        With fop
            .StartInfo.FileName = My.Application.Info.DirectoryPath + "\fop\fop.bat"
            .StartInfo.Arguments = "-fo """ & filepath & filename & ".fo"" -pdf """ & filepath & filename & ".pdf"""
            .StartInfo.CreateNoWindow = True
            .StartInfo.UseShellExecute = False
        End With

        log(vbTab & "CMD: " & fop.StartInfo.FileName & " " & fop.StartInfo.Arguments)

        fop.Start()
        fop.WaitForExit()

        If fop.ExitCode = 0 Then
            log(vbTab & "Converting to PDF finished OK")
        Else
            log(vbTab & "Converting to PDF finished with ERRORS (ExitCode " & fop.ExitCode & ")")
            retval = fop.ExitCode
        End If

        fop.Close()
        fop.Dispose()

        Return retval
    End Function

    Private Sub OutputHandler(sendingProcess As Object, outLine As DataReceivedEventArgs)
        ' Collect the sort command output.
        If Not String.IsNullOrEmpty(outLine.Data) Then
            ' Add the text to the collected output.
            processOutput.AppendLine(outLine.Data)
        End If
    End Sub
End Class
