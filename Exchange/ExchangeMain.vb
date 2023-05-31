Imports System.IO
Imports org.apache.pdfbox

Public Class ExchangeMain
    Private DocValidate As PDFValidator
    ' ListBox로 PDF 드래그 드랍
    Private Sub AddFileList_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles FileListBox.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        DocValidate = New PDFValidator
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
    Private Sub FileClear_Click(sender As Object, e As EventArgs) Handles fileClear.Click
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
    Private Sub FileModify_Click(sender As Object, e As EventArgs) Handles fileModify.Click
        If FileListBox.Items.Count = 0 Then
            MsgBox("추가된 파일이 없습니다.",, "Error")
            Return
        End If

        Me.Hide()
        FileDataList.Show()
    End Sub

    ' 파일 삭제 클릭 이벤트
    Private Sub FileDel_Click(sender As Object, e As EventArgs) Handles fileDel.Click
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



    ' 실행 클릭 이벤트
    Private Sub FileDraw_Click(sender As Object, e As EventArgs) Handles fileDraw.Click
        If FileListBox.Items.Count = 0 Then
            MsgBox("추가된 파일이 없습니다.",, "Error")
            Return
        End If
        Dim draw As New DrawFunction

        If My.Settings.isSaveAuto Then
            draw.run()
        Else
            Dim saveFilePath As New DialogResult
            Dim savePath As New FolderBrowserDialog
            saveFilePath = savePath.ShowDialog

            If Not (saveFilePath = DialogResult.OK) Then
                Return
            End If

            draw.run(savePath.SelectedPath)
        End If

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

    Private Sub BeforeSave_Click(sender As Object, e As EventArgs) Handles beforeSave.Click
        beforeSave.Enabled = False
        autoSave.Checked = False
        beforeSave.Checked = True
        autoSave.Enabled = True
        My.Settings.isSaveAuto = False
        My.Settings.Save()
    End Sub

    ' 저장경로 설정
    Private Sub SavePathSet_Click(sender As Object, e As EventArgs) Handles savePathSet.Click
        Dim saveFilePath As New DialogResult
        Dim savePath As New FolderBrowserDialog
        saveFilePath = savePath.ShowDialog

        If Not (saveFilePath = DialogResult.OK) Then
            Return
        End If

        My.Settings.SavePath = savePath.SelectedPath
    End Sub

    ' 저장경로 보기
    Private Sub GoSavePath_Click(sender As Object, e As EventArgs) Handles GoSavePath.Click
        System.Diagnostics.Process.Start(My.Settings.SavePath)
    End Sub

    Private Sub FeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FeeToolStripMenuItem.Click
        Fee.Show()
    End Sub

    Private Sub FileAdd_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SettingBtn_Click(sender As Object, e As EventArgs)
        ContextMenuStrip.Show()
    End Sub
End Class