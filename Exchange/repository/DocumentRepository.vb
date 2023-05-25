Public Class DocumentRepository

    Private Shared Docs As Dictionary(Of String, DocumentInfo) = New Dictionary(Of String, DocumentInfo)

    Public Shared Function GetDocs() As Dictionary(Of String, DocumentInfo)
        Return Docs
    End Function

    Public Shared Sub AddDoc(Doc As DocumentInfo)
        Docs.Add(Doc.InfoBlNumber, Doc)
    End Sub

    Public Shared Sub UpdateDoc(Doc As DocumentInfo)
        Dim FindDoc As DocumentInfo = Docs(Doc.InfoBlNumber)
        Docs(Doc.InfoBlNumber) = Doc
    End Sub

    Public Shared Function FindDocName(ByVal BlNumber As String) As DocumentInfo
        Return Docs(BlNumber)
    End Function

    Public Shared Sub DelDoc(ByVal BlNumber As String)
        Docs.Remove(BlNumber)
    End Sub

    Public Shared Sub ClearDoc()
        Docs.Clear()
    End Sub








End Class
