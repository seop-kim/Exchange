Public Class ExchangeRateRepository
    Private Shared Rate = New Dictionary(Of String, Double)

    Public Shared Function GetRate(Report_Date As String) As Double
        Return Rate(Report_Date)
    End Function

    Public Shared Sub AddRate(R_Date As String, price As Double)
        Rate.Add(R_Date, price)
    End Sub

    Public Shared Sub ClearRate()
        Rate.Clear()
    End Sub

    Public Shared Function IsDateSave(R_Date As String) As Boolean
        If Rate.ContainsKey(R_Date) Then
            Return True
        End If

        Return False
    End Function
End Class
