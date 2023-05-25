Imports org.apache.pdfbox.pdmodel
Imports org.apache.pdfbox.util

Public Class PdfObject
    Public Shared Function GetPdfContent(ByVal input As String) As String
        Dim doc As PDDocument = Nothing
        Try
            doc = PDDocument.load(input)
            Dim stripper As New PDFTextStripper()
            Return stripper.getText(doc)
        Finally
            If doc IsNot Nothing Then
                doc.close()
            End If
        End Try
    End Function
End Class
