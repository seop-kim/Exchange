Imports System.IO
Imports org.apache.pdfbox.pdmodel
Imports org.apache.pdfbox.pdmodel.edit
Imports org.apache.pdfbox.pdmodel.font

Public Class PDFDraw
    Private er_service = New ExchangeRateService

    Public Sub Draw(Doc As DocumentInfo)
        Dim rate As Double = er_service.GetRate(Doc)

        Dim Pdf_Doc As PDDocument = PDDocument.load(Doc.InfoFilePath)
        Dim page As PDPage = Pdf_Doc.getDocumentCatalog().getAllPages.get(0)

        Dim contentStream As PDPageContentStream = New PDPageContentStream(Pdf_Doc, page, True, True)

        'Dim customFont As PDTrueTypeFont = PDTrueTypeFont.loadTTF(Pdf_Doc, New java.io.File("D:\project\git\ExchangePro\ExchangePro\Resources\font\malgun.ttf"))
        '(Pdf_Doc, fontStream)

        Dim font As PDType1Font = PDType1Font.ZAPF_DINGBATS

        contentStream.beginText()

        contentStream.setFont(font, 10)
        contentStream.setNonStrokingColor(255, 0, 0)

        contentStream.moveTextPositionByAmount(190, 200)
        contentStream.drawString("$55,640 X @1,324.50")

        contentStream.moveTextPositionByAmount(0, -20)
        contentStream.drawString("\ 73,695.180")

        contentStream.endText()
        contentStream.close()
        Pdf_Doc.save(My.Settings.SavePath + "/" + Doc.InfoFileName)
        Pdf_Doc.close()
    End Sub
End Class
