<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExchangeMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.fileDraw = New System.Windows.Forms.Button()
        Me.saveSetting = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.autoSaveSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.autoSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.beforeSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.savePathSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.fileModify = New System.Windows.Forms.Button()
        Me.FileListBox = New System.Windows.Forms.ListBox()
        Me.fileClear = New System.Windows.Forms.Button()
        Me.fileDel = New System.Windows.Forms.Button()
        Me.fileAdd = New System.Windows.Forms.Button()
        Me.fontTest = New System.Windows.Forms.Button()
        Me.TestDraw = New System.Windows.Forms.Button()
        Me.testBtn2 = New System.Windows.Forms.Button()
        Me.testBtn = New System.Windows.Forms.Button()
        Me.saveSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'fileDraw
        '
        Me.fileDraw.ContextMenuStrip = Me.saveSetting
        Me.fileDraw.Font = New System.Drawing.Font("나눔고딕", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.fileDraw.Location = New System.Drawing.Point(163, 159)
        Me.fileDraw.Name = "fileDraw"
        Me.fileDraw.Size = New System.Drawing.Size(94, 49)
        Me.fileDraw.TabIndex = 15
        Me.fileDraw.Text = "실행"
        Me.fileDraw.UseVisualStyleBackColor = True
        '
        'saveSetting
        '
        Me.saveSetting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.autoSaveSet, Me.savePathSet})
        Me.saveSetting.Name = "saveSetting"
        Me.saveSetting.Size = New System.Drawing.Size(155, 48)
        '
        'autoSaveSet
        '
        Me.autoSaveSet.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.autoSave, Me.beforeSave})
        Me.autoSaveSet.Name = "autoSaveSet"
        Me.autoSaveSet.Size = New System.Drawing.Size(154, 22)
        Me.autoSaveSet.Text = "자동 저장 설정"
        '
        'autoSave
        '
        Me.autoSave.Checked = True
        Me.autoSave.CheckOnClick = True
        Me.autoSave.CheckState = System.Windows.Forms.CheckState.Checked
        Me.autoSave.Name = "autoSave"
        Me.autoSave.Size = New System.Drawing.Size(170, 22)
        Me.autoSave.Text = "자동 저장"
        '
        'beforeSave
        '
        Me.beforeSave.CheckOnClick = True
        Me.beforeSave.Name = "beforeSave"
        Me.beforeSave.Size = New System.Drawing.Size(170, 22)
        Me.beforeSave.Text = "저장 시 항상 묻기"
        '
        'savePathSet
        '
        Me.savePathSet.Name = "savePathSet"
        Me.savePathSet.Size = New System.Drawing.Size(154, 22)
        Me.savePathSet.Text = "저장 경로 설정"
        '
        'fileModify
        '
        Me.fileModify.Font = New System.Drawing.Font("나눔고딕", 8.249999!)
        Me.fileModify.Location = New System.Drawing.Point(82, 159)
        Me.fileModify.Name = "fileModify"
        Me.fileModify.Size = New System.Drawing.Size(76, 23)
        Me.fileModify.TabIndex = 14
        Me.fileModify.Text = "수정"
        Me.fileModify.UseVisualStyleBackColor = True
        '
        'FileListBox
        '
        Me.FileListBox.AllowDrop = True
        Me.FileListBox.Font = New System.Drawing.Font("나눔고딕", 9.0!)
        Me.FileListBox.FormattingEnabled = True
        Me.FileListBox.HorizontalScrollbar = True
        Me.FileListBox.ItemHeight = 14
        Me.FileListBox.Location = New System.Drawing.Point(1, 0)
        Me.FileListBox.Name = "FileListBox"
        Me.FileListBox.Size = New System.Drawing.Size(256, 158)
        Me.FileListBox.TabIndex = 13
        '
        'fileClear
        '
        Me.fileClear.Font = New System.Drawing.Font("나눔고딕", 8.249999!)
        Me.fileClear.Location = New System.Drawing.Point(82, 185)
        Me.fileClear.Name = "fileClear"
        Me.fileClear.Size = New System.Drawing.Size(76, 23)
        Me.fileClear.TabIndex = 12
        Me.fileClear.Text = "전체삭제"
        Me.fileClear.UseVisualStyleBackColor = True
        '
        'fileDel
        '
        Me.fileDel.Font = New System.Drawing.Font("나눔고딕", 8.249999!)
        Me.fileDel.Location = New System.Drawing.Point(1, 185)
        Me.fileDel.Name = "fileDel"
        Me.fileDel.Size = New System.Drawing.Size(76, 23)
        Me.fileDel.TabIndex = 11
        Me.fileDel.Text = "삭제"
        Me.fileDel.UseVisualStyleBackColor = True
        '
        'fileAdd
        '
        Me.fileAdd.Font = New System.Drawing.Font("나눔고딕", 8.249999!)
        Me.fileAdd.Location = New System.Drawing.Point(1, 159)
        Me.fileAdd.Name = "fileAdd"
        Me.fileAdd.Size = New System.Drawing.Size(76, 23)
        Me.fileAdd.TabIndex = 10
        Me.fileAdd.Text = "추가"
        Me.fileAdd.UseVisualStyleBackColor = True
        '
        'fontTest
        '
        Me.fontTest.Location = New System.Drawing.Point(268, 89)
        Me.fontTest.Name = "fontTest"
        Me.fontTest.Size = New System.Drawing.Size(204, 23)
        Me.fontTest.TabIndex = 19
        Me.fontTest.Text = "fontTest"
        Me.fontTest.UseVisualStyleBackColor = True
        '
        'TestDraw
        '
        Me.TestDraw.Location = New System.Drawing.Point(268, 60)
        Me.TestDraw.Name = "TestDraw"
        Me.TestDraw.Size = New System.Drawing.Size(204, 23)
        Me.TestDraw.TabIndex = 18
        Me.TestDraw.Text = "TestDraw"
        Me.TestDraw.UseVisualStyleBackColor = True
        '
        'testBtn2
        '
        Me.testBtn2.Location = New System.Drawing.Point(268, 31)
        Me.testBtn2.Name = "testBtn2"
        Me.testBtn2.Size = New System.Drawing.Size(204, 23)
        Me.testBtn2.TabIndex = 17
        Me.testBtn2.Text = "test data reding"
        Me.testBtn2.UseVisualStyleBackColor = True
        '
        'testBtn
        '
        Me.testBtn.Location = New System.Drawing.Point(267, 0)
        Me.testBtn.Name = "testBtn"
        Me.testBtn.Size = New System.Drawing.Size(206, 24)
        Me.testBtn.TabIndex = 16
        Me.testBtn.Text = "test data init"
        Me.testBtn.UseVisualStyleBackColor = True
        '
        'ExchangeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(472, 210)
        Me.Controls.Add(Me.fileDraw)
        Me.Controls.Add(Me.fileModify)
        Me.Controls.Add(Me.FileListBox)
        Me.Controls.Add(Me.fileClear)
        Me.Controls.Add(Me.fileDel)
        Me.Controls.Add(Me.fileAdd)
        Me.Controls.Add(Me.fontTest)
        Me.Controls.Add(Me.TestDraw)
        Me.Controls.Add(Me.testBtn2)
        Me.Controls.Add(Me.testBtn)
        Me.MaximizeBox = False
        Me.Name = "ExchangeMain"
        Me.Text = "ExchangeMain"
        Me.saveSetting.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents fileDraw As Button
    Friend WithEvents saveSetting As ContextMenuStrip
    Friend WithEvents autoSaveSet As ToolStripMenuItem
    Friend WithEvents autoSave As ToolStripMenuItem
    Friend WithEvents beforeSave As ToolStripMenuItem
    Friend WithEvents savePathSet As ToolStripMenuItem
    Friend WithEvents fileModify As Button
    Friend WithEvents FileListBox As ListBox
    Friend WithEvents fileClear As Button
    Friend WithEvents fileDel As Button
    Friend WithEvents fileAdd As Button
    Friend WithEvents fontTest As Button
    Friend WithEvents TestDraw As Button
    Friend WithEvents testBtn2 As Button
    Friend WithEvents testBtn As Button
End Class
