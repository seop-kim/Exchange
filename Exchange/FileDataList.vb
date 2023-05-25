Public Class FileDataList
    Private DicDocs As Dictionary(Of String, DocumentInfo) = DocumentRepository.GetDocs
    Private Docs As List(Of DocumentInfo) = New List(Of DocumentInfo)(DicDocs.Values)

    Private DatePicker As DateTimePicker

    Private rowIndex As Integer
    Private columnIndex As Integer

    Private Sub FileDataList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatePicker = DateTimePicker1
        DatePicker.Format = DateTimePickerFormat.Custom
        DatePicker.CustomFormat = "yyyy-MM-dd"

        setDataGridViewColumn()

        For index = 0 To DicDocs.Count - 1
            Dim Doc As DocumentInfo = DocumentRepository.FindDocName(Docs(index).InfoBlNumber)
            ReportGirdView.Rows.Add(Doc.InfoBlNumber, "$ " + Doc.InfoPrice.ToString("#,###.00"), Doc.InfoReportDate)
        Next
    End Sub

    ' Data Grid View 클릭 시
    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReportGirdView.CellClick
        rowIndex = e.RowIndex
        columnIndex = e.ColumnIndex

        ' Report Date 클릭 시
        If e.ColumnIndex = 2 And Not DicDocs.Count = 0 And Not e.RowIndex = -1 Then
            DatePicker.Value = Docs(e.RowIndex).InfoReportDate
            Dim dgv As DataGridView = ReportGirdView

            dgv.Controls.Add(DatePicker)

            Dim rect As Rectangle = dgv.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
            DatePicker.Size = New Size(rect.Width, rect.Top)
            DatePicker.Location = New Point(rect.Right, rect.Top - 22)

            ' DateTimePicker 포커스 및 드롭다운
            DatePicker.Show()
            DatePicker.Focus()
            SendKeys.Send("{F4}")
        End If
    End Sub

    ' Price 편집 시작
    Private Sub Price_Text_Edit_Start(sender As Object, e As DataGridViewCellCancelEventArgs) Handles ReportGirdView.CellBeginEdit
        SendKeys.Send("^(A)")
    End Sub

    ' Price 편집 종료
    Private Sub Price_Text_Edit_End(sender As Object, e As DataGridViewCellEventArgs) Handles ReportGirdView.CellEndEdit
    End Sub

    ' Price 금액 변동 시
    Private Sub DataGridView_Price_Update(sender As Object, e As DataGridViewCellEventArgs) Handles ReportGirdView.CellValueChanged
        Dim DocValidate As PDFValidator = New PDFValidator
        Dim inputStr As String = ReportGirdView.Item(e.ColumnIndex, e.RowIndex).Value
        If e.ColumnIndex = 1 And Not DicDocs.Count = 0 And Not e.RowIndex = -1 Then
            Dim Doc = Docs(e.RowIndex)
            Dim isDouble = DocValidate.IsDouble(inputStr.Replace("$", ""))

            If Not isDouble Then
                ReportGirdView.Item(e.ColumnIndex, e.RowIndex).Value = "$ " + Doc.InfoPrice.ToString("#,###.00")
                Return
            End If

            Doc.InfoPrice = Double.Parse(ReportGirdView.Item(e.ColumnIndex, e.RowIndex).Value.ToString.Replace("$", ""))
            ReportGirdView.Item(e.ColumnIndex, e.RowIndex).Value = "$ " + Doc.InfoPrice.ToString("#,###.00")
        End If
    End Sub

    ' 목록에서 BL 더블클릭 시 상세페이지 띄우기 (미구현)
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReportGirdView.CellDoubleClick
        If e.ColumnIndex = 0 And Not DicDocs.Count = 0 And Not e.RowIndex = -1 Then
            MsgBox("미구현" + Chr(13) + Chr(10) + "상세페이지 예정")
        End If
    End Sub

    ' Report Date 가 변경될 경우 docs 객체 내 변경 값 적용
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim changeDate As String = DatePicker.Value

        If Not Docs(rowIndex).InfoReportDate.Equals(changeDate) Then
            ReportGirdView.CurrentCell.Value = DatePicker.Text
            Docs(rowIndex).InfoReportDate = changeDate
        End If

        DatePicker.Hide()

        columnIndex = ReportGirdView.CurrentCell.ColumnIndex
        rowIndex = ReportGirdView.CurrentCell.RowIndex
        ReportGirdView.CurrentCell = ReportGirdView(columnIndex, rowIndex)

    End Sub

    ' Enter 클릭 시 현재 행에 머물기
    ' ? 텍스트 편집 뒤 엔터를 누르면 다음 행으로 넘어가는데 이거 싫다.
    Private Sub Press_Enter(sender As Object, e As KeyEventArgs) Handles ReportGirdView.KeyDown
        If e.KeyData = Keys.Enter Then
            columnIndex = ReportGirdView.CurrentCell.ColumnIndex
            rowIndex = ReportGirdView.CurrentCell.RowIndex
            ReportGirdView.CurrentCell = ReportGirdView(columnIndex, rowIndex)
            e.Handled = True
        End If
    End Sub

    ' 돌아가기 클릭
    Private Sub Back_Btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Close()
        ExchangeMain.Show()
    End Sub

    ' Set DataGridView Column
    Private Sub setDataGridViewColumn()
        ReportGirdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ReportGirdView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        ' Set Font Type
        ReportGirdView.Font = New Font("나눔고딕", 9, FontStyle.Regular)

        ' Set Column size
        ReportGirdView.ColumnCount = 3

        ' Set Column Name
        ReportGirdView.Columns(0).Name = "BL Number"
        ReportGirdView.Columns(1).Name = "Price ($)"
        ReportGirdView.Columns(2).Name = "Report Date"

        ' Set first column readOnly
        ReportGirdView.Columns(0).ReadOnly = True
        ReportGirdView.Columns(2).ReadOnly = True

        ' Set Limit Sort 
        ReportGirdView.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        ReportGirdView.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        ReportGirdView.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    ' Scroll 발생 시 DateTimePicker Hide
    Private Sub DataGridView1_Scroll() Handles ReportGirdView.Scroll
        DatePicker.Hide()
    End Sub

    ' 달력이 꺼지면 DateTimePicker Hide
    Private Sub DateTimePicker_drop_close() Handles DateTimePicker1.CloseUp
        DatePicker.Hide()
    End Sub

    ' 달력을 누르면 DateTimePicker Hide
    Private Sub DateTimePicker_Click() Handles DateTimePicker1.Click
        DatePicker.Hide()
    End Sub

    Private Sub ReportGirdView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReportGirdView.CellContentClick

    End Sub
End Class