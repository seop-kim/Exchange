Public Class Calculator
    Private ERS As ExchangeRateService = New ExchangeRateService
    Private Const Coit_Commission As Double = 0.3
    Public Function cal(Doc As DocumentInfo) As String()
        Dim Result(2) As String

        Dim R_Price = Doc.InfoPrice
        Dim Ex_Rate = ERS.GetRate(Doc) + Coit_Commission

        Console.WriteLine("R_Price : " + R_Price.ToString("#,###.00"))
        Console.WriteLine("Ex_Rate : " + Ex_Rate.ToString("#,###.00"))

        Result(0) = "$" + R_Price.ToString("#,###.00") + " X " + "@" + Ex_Rate.ToString("#,###.00")

        Dim Cal_Result As Integer = R_Price * Ex_Rate

        Result(1) = "\ " + Cal_Result.ToString("#,###")

        Return Result
    End Function


End Class
