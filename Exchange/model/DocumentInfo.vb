Public Class DocumentInfo
    Private blNumber As String
    Private fileName As String
    Private filePath As String
    Private reportDate As String
    Private price As Double

    Property InfoBlNumber As String
        Get
            Return Me.blNumber
        End Get
        Set(value As String)
            Me.blNumber = value
        End Set
    End Property

    Property InfoFileName As String
        Get
            Return Me.fileName
        End Get
        Set(value As String)
            Me.fileName = value
        End Set
    End Property

    Property InfoFilePath As String
        Get
            Return Me.filePath
        End Get
        Set(value As String)
            Me.filePath = value
        End Set
    End Property

    Property InfoReportDate As String
        Get
            Return Me.reportDate
        End Get
        Set(value As String)
            Me.reportDate = value
        End Set
    End Property

    Property InfoPrice As Double
        Get
            Return Me.price
        End Get
        Set(value As Double)
            Me.price = value
        End Set
    End Property

    Public Sub Print_doc()
        Console.WriteLine("=====================================" + Chr(13) + Chr(10) + "blNumber : " + blNumber + Chr(13) + Chr(10) + "fileName : " + fileName + Chr(13) + Chr(10) + "filePath : " + filePath + Chr(13) + Chr(10) + "reportDate : " + reportDate + Chr(13) + Chr(10) + "price : " + price.ToString("F"))
    End Sub

End Class
