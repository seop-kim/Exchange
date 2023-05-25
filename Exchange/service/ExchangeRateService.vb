Public Class ExchangeRateService
    Private wc = New WebCrawling

    Public Sub AddRates(Docs As List(Of DocumentInfo))
        For i = 0 To Docs.Count - 1
            Dim Doc = Docs(i)

            If ExchangeRateRepository.IsDateSave(Doc.InfoReportDate) Then
                Continue For
            End If

            Dim path = wc.CreatePath(Doc.InfoReportDate)
            Dim rate = wc.GetExchangeRate(path)

            ExchangeRateRepository.AddRate(Doc.InfoReportDate, rate)
        Next
    End Sub

    Public Sub CleanData()
        ExchangeRateRepository.ClearRate()
    End Sub

    Public Function GetRate(Doc As DocumentInfo) As Double
        Return ExchangeRateRepository.GetRate(Doc.InfoReportDate)
    End Function

End Class
