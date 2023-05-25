
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome

Public Class WebCrawling

    ' 크롤링 주소 생성
    Private Function CreatePath(reportDate As String) As String
        Dim reportDates = reportDate.Split("-")
        Dim path =
            "http://www.smbs.biz/ExRate/TodayExRate.jsp?StrSch_Year=" + reportDates(0) +
            "&StrSch_Month=" + reportDates(1) + "&StrSch_Day=" + reportDates(2) + "&StrSchFull=" + reportDates(0) + "." + reportDates(1) + "." + reportDates(2)
        Return path
    End Function

    ' 주소를 매개변수로 해당 주소로 접속하여 환율 정보를 가져온다.
    Public Function GetExchangeRate(reportDate As String) As Double
        Dim rate As String
        Dim driverService = ChromeDriverService.CreateDefaultService

        Dim chromeOptions = New ChromeOptions

        driverService.HideCommandPromptWindow = True ' Cmd Hide
        chromeOptions.AddArgument("headless") ' Web Hide

        Dim driver As ChromeDriver = New ChromeDriver(driverService, chromeOptions) ' Create Driver Object
        Dim path = CreatePath(reportDate)
        driver.Url() = path ' set path

        Try
            rate = driver.FindElement(By.Id("usd")).Text.Replace(",", "") ' Usd Element : usd

        Catch ex As Exception
            rate = "0"

        Finally
            driver.Close()

        End Try

        Return Double.Parse(rate)
    End Function
End Class
