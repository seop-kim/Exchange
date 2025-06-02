Imports System.Drawing.Text
Imports System.Drawing
Imports System.IO
Imports System.Runtime.InteropServices
Imports java.awt
Imports org.apache.pdfbox.pdmodel
Imports org.apache.pdfbox.pdmodel.edit
Imports org.apache.pdfbox.pdmodel.font
Imports org.apache.fontbox.ttf

Public Class PDFDraw
    Private er_service = New ExchangeRateService
    Private Cal As Calculator = New Calculator

    Private Const PDF As String = ".pdf"
    Public Sub Draw(Doc As DocumentInfo)
        If ExchangeRateService.Error_Date.Contains(Doc.InfoReportDate) Then
            Return
        End If
        Dim Result() = Cal.cal(Doc)
        Dim rate As Double = er_service.GetRate(Doc)

        Dim Pdf_Doc As PDDocument = PDDocument.load(Doc.InfoFilePath)
        Dim page As PDPage = Pdf_Doc.getDocumentCatalog().getAllPages.get(0)

        Dim contentStream As PDPageContentStream = New PDPageContentStream(Pdf_Doc, page, True, True)

        Dim fontFileBytes() As Byte = My.Resources.malgun

        ' Code Reference : https://stackoverflow.com/questions/61960884/how-to-get-path-of-resource-file
        'Save the bytesarray to a real file (you can change the save path)
        File.WriteAllBytes(Application.StartupPath & "\malgun.ttf", fontFileBytes)

        'Create a fileinfo object that will have the FilePath of your help file
        Dim fontFileInfo = New FileInfo(Application.StartupPath & "\malgun.ttf")

        ' Resources dir 내 malgun.ttf 사용
        Dim customFont As PDTrueTypeFont = PDTrueTypeFont.loadTTF(Pdf_Doc, New java.io.File(fontFileInfo.ToString))

        contentStream.beginText()

        contentStream.setFont(customFont, 10)
        contentStream.setNonStrokingColor(255, 0, 0)

        contentStream.moveTextPositionByAmount(190, 200)
        contentStream.drawString(Result(0))

        contentStream.moveTextPositionByAmount(0, -20)
        contentStream.drawString(Result(1))

        contentStream.endText()
        contentStream.close()
        Pdf_Doc.save(My.Settings.SavePath + "/" + Doc.InfoBlNumber + PDF)
        Pdf_Doc.close()

        DocumentRepository.DelDoc(Doc.InfoBlNumber)
        ExchangeMain.FileListBox.Items.Remove(Doc.InfoBlNumber)
    End Sub

    Public Sub Draw(Doc As DocumentInfo, savePath As String)
        If ExchangeRateService.Error_Date.Contains(Doc.InfoReportDate) Then
            Return
        End If
        Dim Result() = Cal.cal(Doc)
        Dim rate As Double = er_service.GetRate(Doc)

        Dim Pdf_Doc As PDDocument = PDDocument.load(Doc.InfoFilePath)
        Dim page As PDPage = Pdf_Doc.getDocumentCatalog().getAllPages.get(0)

        Dim contentStream As PDPageContentStream = New PDPageContentStream(Pdf_Doc, page, True, True)

        Dim fontFileBytes() As Byte = My.Resources.malgun

        ' Code Reference : https://stackoverflow.com/questions/61960884/how-to-get-path-of-resource-file
        'Save the bytesarray to a real file (you can change the save path)
        File.WriteAllBytes(Application.StartupPath & "\malgun.ttf", fontFileBytes)

        'Create a fileinfo object that will have the FilePath of your help file
        Dim fontFileInfo = New FileInfo(Application.StartupPath & "\malgun.ttf")

        ' Resources dir 내 malgun.ttf 사용
        Dim customFont As PDTrueTypeFont = PDTrueTypeFont.loadTTF(Pdf_Doc, New java.io.File(fontFileInfo.ToString))

        contentStream.beginText()

        contentStream.setFont(customFont, 10)
        contentStream.setNonStrokingColor(255, 0, 0)

        contentStream.moveTextPositionByAmount(190, 200)
        contentStream.drawString(Result(0))

        contentStream.moveTextPositionByAmount(0, -20)
        contentStream.drawString(Result(1))

        contentStream.endText()
        contentStream.close()
        Pdf_Doc.save(savePath + "/" + Doc.InfoBlNumber + PDF)
        Pdf_Doc.close()

        DocumentRepository.DelDoc(Doc.InfoBlNumber)
        ExchangeMain.FileListBox.Items.Remove(Doc.InfoBlNumber)
    End Sub
End Class
