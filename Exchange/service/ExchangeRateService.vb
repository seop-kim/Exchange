Public Class ExchangeRateService
    Private ReadOnly wc = New WebCrawling
    Public Shared Error_Date As New List(Of String)

    Public Sub AddRates(Docs As List(Of DocumentInfo))
        For i = 0 To Docs.Count - 1
            Dim Doc = Docs(i)

            If ExchangeRateRepository.IsDateSave(Doc.InfoReportDate) Or Error_Date.Contains(Doc.InfoReportDate) Then
                Continue For
            End If

            Dim rate = wc.GetExchangeRate(Doc.InfoReportDate)

            If rate = 0 Then
                Error_Date.Add(Doc.InfoReportDate)
                Continue For

            ElseIf rate = -1 Then
                MsgBox("웹 접근에 실패하였습니다. 관리자에게 문의해 주세요.")
                Exit For
            End If

            ExchangeRateRepository.AddRate(Doc.InfoReportDate, rate)
        Next

        If Not Error_Date.Count = 0 Then
            Print_Error_Msg()
        End If

    End Sub

    Public Sub CleanData()
        ExchangeRateRepository.ClearRate()
    End Sub

    Public Function GetRate(Doc As DocumentInfo) As Double
        Return ExchangeRateRepository.GetRate(Doc.InfoReportDate)
    End Function

    Private Sub Print_Error_Msg()
        Dim error_msg As String = "아래 날짜의 데이터를 불러올 수 없습니다."
        Error_Date.Sort()

        For i = 0 To Error_Date.Count - 1
            error_msg += Chr(10) + Chr(13) + Chr(10) + Chr(13) + "[ " + Error_Date(i) + " ]" + Find_Error_Date_Bl(Error_Date(i))
        Next
        MsgBox(error_msg,, "Get Date Error")
    End Sub

    Private Function Find_Error_Date_Bl(R_Date As String) As String
        Dim ItemsBl As String = ""
        Dim Item As New List(Of DocumentInfo)(DocumentRepository.GetDocs.Values)

        For i = 0 To Item.Count - 1
            If Item(i).InfoReportDate.Equals(R_Date) Then
                ItemsBl += Chr(10) + Chr(13) + "   " + Item(i).InfoBlNumber
            End If
        Next

        Return ItemsBl
    End Function
End Class
