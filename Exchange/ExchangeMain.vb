Public Class ExchangeMain
    Private DocValidate As PDFValidator
    ' ListBox로 PDF 드래그 드랍
    Private Sub AddFileList_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles FileListBox.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        DocValidate = New PDFValidator

        Console.WriteLine("Files Count : " + files.Length.ToString)

        For i = 0 To files.Length - 1
            If Not DocValidate.File_Ext_PDF(files(i)) Then
                Continue For
            End If

            Dim Doc As DocumentInfo = PDFReder.ContentToObject(files(i))

            If Not DocValidate.File_Compare(Doc) Then
                Continue For
            End If

            DocumentRepository.AddDoc(Doc)
            FileListBox.Items.Add(Doc.InfoBlNumber)
        Next

        If DocValidate.IsError Then
            MsgBox(DocValidate.GetErrorMsg(),, "Error")
        End If
    End Sub

    ' 드래그 드랍 이벤트
    Private Sub AddFileList_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles FileListBox.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    ' 초기화 버튼 클릭 이벤트
    Private Sub fileClear_Click(sender As Object, e As EventArgs) Handles fileClear.Click
        If FileListBox.Items.Count = 0 Then
            MsgBox("추가된 파일이 없습니다.",, "Error")
            Return
        End If

        Dim answer = MsgBox("등록된 문서를 모두 삭제하시겠습니까?", vbOKCancel, "선택")
        If answer = 1 Then
            DocumentRepository.ClearDoc()
            FileListBox.Items.Clear()
        End If
    End Sub

    ' 수정 클릭 이벤트
    Private Sub fileModify_Click(sender As Object, e As EventArgs) Handles fileModify.Click
        If FileListBox.Items.Count = 0 Then
            MsgBox("추가된 파일이 없습니다.",, "Error")
            Return
        End If

        Me.Hide()
        FileDataList.Show()
    End Sub

    ' 파일 삭제 클릭 이벤트
    Private Sub fileDel_Click(sender As Object, e As EventArgs) Handles fileDel.Click
        If FileListBox.Items.Count = 0 Then
            MsgBox("추가된 파일이 없습니다.",, "Error")
            Return
        End If
        Dim selectItem As Integer = FileListBox.SelectedIndex
        Dim answer = MsgBox("'" + FileListBox.Items(selectItem) + "' 문서를 삭제하시겠습니까?", vbOKCancel, "선택")

        If answer = 1 Then
            DocumentRepository.DelDoc(FileListBox.Items(selectItem))
            FileListBox.Items.RemoveAt(selectItem)
        End If
    End Sub


    Private Sub testBtn2_Click(sender As Object, e As EventArgs) Handles testBtn2.Click
        Dim DicDocs As Dictionary(Of String, DocumentInfo) = DocumentRepository.GetDocs
        Dim Docs As List(Of DocumentInfo) = New List(Of DocumentInfo)(DicDocs.Values)

        For i = 0 To Docs.Count - 1
            Docs(i).Print_doc()
        Next
    End Sub

    Private Sub TestDraw_Click(sender As Object, e As EventArgs) Handles TestDraw.Click
        Dim draw = New PDFDraw
        Dim ers = New ExchangeRateService

        Dim DicDocs As Dictionary(Of String, DocumentInfo) = DocumentRepository.GetDocs
        Dim Docs As List(Of DocumentInfo) = New List(Of DocumentInfo)(DicDocs.Values)

        ers.AddRates(Docs)

        For i = 0 To Docs.Count - 1
            draw.Draw(Docs(i))
        Next
    End Sub



    Private Sub ExchangeProMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form_Load_Set()
    End Sub

    Private Sub Form_Load_Set()
        Dim checkAutoSave As Boolean = My.Settings.isSaveAuto
        If checkAutoSave Then
            autoSave.Enabled = False
            beforeSave.Checked = False
            autoSave.Checked = True
            beforeSave.Enabled = True
        Else
            beforeSave.Enabled = False
            autoSave.Checked = False
            beforeSave.Checked = True
            autoSave.Enabled = True
        End If

        If My.Settings.SavePath.Equals("") Then
            My.Settings.SavePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            My.Settings.Save()
        End If
    End Sub

    Private Sub AutoSave_Click(sender As Object, e As EventArgs) Handles autoSave.Click
        autoSave.Enabled = False
        beforeSave.Checked = False
        autoSave.Checked = True
        beforeSave.Enabled = True
        My.Settings.isSaveAuto = True
        My.Settings.Save()
    End Sub

    Private Sub beforeSave_Click(sender As Object, e As EventArgs) Handles beforeSave.Click
        beforeSave.Enabled = False
        autoSave.Checked = False
        beforeSave.Checked = True
        autoSave.Enabled = True
        My.Settings.isSaveAuto = False
        My.Settings.Save()
    End Sub

    Private Sub savePathSet_Click(sender As Object, e As EventArgs) Handles savePathSet.Click

    End Sub

    Private Sub fontTest_Click(sender As Object, e As EventArgs) Handles fontTest.Click
        'Dim font As PrivateFontCollection = New PrivateFontCollection
        'Font.AddFontFile("malgun.ttf")




    End Sub

    Private Sub FileListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileListBox.SelectedIndexChanged

    End Sub
End Class