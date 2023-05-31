
Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Edge


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
        Dim driverService As EdgeDriverService
        Dim chromeOptions As EdgeOptions
        Try
            driverService = EdgeDriverService.CreateDefaultService
            chromeOptions = New EdgeOptions()
            driverService.HideCommandPromptWindow = True ' Cmd Hide
            chromeOptions.AddArgument("headless") ' Web Hide

        Catch ex As Exception
            Return -1
        End Try

        MsgBox("driver 객체 선언 전")
        Dim driver As EdgeDriver
        MsgBox("driver 객체 선언 후")

        MsgBox("driver 객체 생성 전")
        driver = New EdgeDriver(driverService, chromeOptions) ' Create Driver Object
        MsgBox("driver 객체 생성 후")

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
