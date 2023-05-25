Public Class Calculator
    Private ERS As ExchangeRateService = New ExchangeRateService
    Private Coit_Commission As Double = Double.Parse(My.Settings.fee)
    Public Function cal(Doc As DocumentInfo) As String()
        Dim Result(2) As String

        Dim R_Price = Doc.InfoPrice
        Dim Ex_Rate = ERS.GetRate(Doc) + Coit_Commission

        Result(0) = "$" + R_Price.ToString("#,###.00") + " X " + "@" + Ex_Rate.ToString("#,###.00")

        Dim Cal_Result As Double = R_Price * Ex_Rate
        Math.Round(Cal_Result, 0)

        Result(1) = "\ " + Cal_Result.ToString("#,###")

        Return Result
    End Function


End Class
