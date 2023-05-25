Public Class DrawFunction
    Public Sub run()
        Dim draw = New PDFDraw
        Dim ers = New ExchangeRateService

        Dim DicDocs As Dictionary(Of String, DocumentInfo) = DocumentRepository.GetDocs
        Dim Docs As List(Of DocumentInfo) = New List(Of DocumentInfo)(DicDocs.Values)

        ers.AddRates(Docs)

        For i = 0 To Docs.Count - 1
            draw.Draw(Docs(i))
        Next
    End Sub

    Public Sub run(savePath As String)
        Dim draw = New PDFDraw
        Dim ers = New ExchangeRateService

        Dim DicDocs As Dictionary(Of String, DocumentInfo) = DocumentRepository.GetDocs
        Dim Docs As List(Of DocumentInfo) = New List(Of DocumentInfo)(DicDocs.Values)

        ers.AddRates(Docs)

        For i = 0 To Docs.Count - 1
            draw.Draw(Docs(i), savePath)
        Next
    End Sub
End Class
