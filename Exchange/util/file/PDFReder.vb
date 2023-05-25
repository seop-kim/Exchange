Public Class PDFReder
    Public Shared Function ContentToObject(Path As String) As DocumentInfo
        Dim Content As String = PdfObject.GetPdfContent(Path)
        Dim Doc As DocumentInfo = New DocumentInfo

        ' BL Number 추출
        Dim BL_Number As String =
            Content.Substring(
                Content.IndexOf("징수형태") + 6, 30).Split(" ")(0)

        ' 신고일 추출
        Dim Report_Date As String =
            Content.Substring(
                    Content.IndexOf("전자인보이스 제출번호") + 15, 30
        ).Split(" ")(1).Replace("/", "-")

        ' $금액 String 추출
        Dim Report_Price_Str As String =
        Content.Substring(
            Content.IndexOf("결제방법)") + 5, 20).Split(" ")(1).Split("-")(2).Replace(",", "")

        ' 금액 String to Double
        Dim Report_Price As Double = Double.Parse(Report_Price_Str)

        Doc.InfoBlNumber = BL_Number
        Doc.InfoReportDate = Report_Date
        Doc.InfoPrice = Report_Price
        Doc.InfoFilePath = Path
        Doc.InfoFileName = System.IO.Path.GetFileName(Doc.InfoFilePath)

        Return Doc
    End Function
End Class
