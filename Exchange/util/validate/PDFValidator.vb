Public Class PDFValidator
    Private Const LOWER_PDF As String = ".pdf"
    Private Const UPPER_PDF As String = ".PDF"
    Private ErrorCount As Integer = 0
    Private ErrorMsg = "[파일 추가 오류]"

    Function File_Compare(ByVal Doc As DocumentInfo) As Boolean
        If DocumentRepository.GetDocs.ContainsKey(Doc.InfoBlNumber) Then ' 목록에 동일한 파일명이 존재할 경우 추가 불가
            ErrorMsg += (Chr(10) + Chr(13) + "'" + Doc.InfoFileName + "' : 중복 오류")
            ErrorCount += 1
            Return False
        End If
        Return True
    End Function

    Function File_Ext_PDF(ByVal path As String) As Boolean
        If Not (IO.Path.GetExtension(path).Equals(LOWER_PDF) Or IO.Path.GetExtension(path).Equals(UPPER_PDF)) Then ' PDF 형식의 파일인지 확인
            ErrorMsg += (Chr(10) + Chr(13) + "'" + IO.Path.GetFileName(path) + "'" + " : PDF 형식 오류")
            ErrorCount += 1
            Return False
        End If
        Return True
    End Function

    Function GetErrorMsg() As String
        Return ErrorMsg
    End Function

    Function IsError() As Boolean
        If ErrorCount > 0 Then
            Return True
        End If
        Return False
    End Function

    Function IsDouble(str As String) As Boolean
        Try
            Double.Parse(str)
        Catch ex As Exception
            MsgBox("실수만 입력이 가능합니다.",, "Type Error")
            Return False
        End Try

        Return True

    End Function
End Class
