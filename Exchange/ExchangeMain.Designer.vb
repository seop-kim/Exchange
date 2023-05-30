<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExchangeMain
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ExchangeMain))
        Me.fileDraw = New System.Windows.Forms.Button()
        Me.saveSetting = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.autoSaveSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.autoSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.beforeSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.savePathSet = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoSavePath = New System.Windows.Forms.ToolStripMenuItem()
        Me.세부설정ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.fileModify = New System.Windows.Forms.Button()
        Me.FileListBox = New System.Windows.Forms.ListBox()
        Me.fileClear = New System.Windows.Forms.Button()
        Me.fileDel = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.saveSetting.SuspendLayout()
        Me.SuspendLayout()
        '
        'fileDraw
        '
        Me.fileDraw.BackColor = System.Drawing.SystemColors.HighlightText
        Me.fileDraw.ContextMenuStrip = Me.saveSetting
        Me.fileDraw.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileDraw.Font = New System.Drawing.Font("나눔고딕", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.fileDraw.Location = New System.Drawing.Point(121, 159)
        Me.fileDraw.Name = "fileDraw"
        Me.fileDraw.Size = New System.Drawing.Size(131, 49)
        Me.fileDraw.TabIndex = 15
        Me.fileDraw.Text = "실행"
        Me.fileDraw.UseVisualStyleBackColor = False
        '
        'saveSetting
        '
        Me.saveSetting.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.autoSaveSet, Me.savePathSet, Me.GoSavePath, Me.세부설정ToolStripMenuItem})
        Me.saveSetting.Name = "saveSetting"
        Me.saveSetting.Size = New System.Drawing.Size(183, 92)
        '
        'autoSaveSet
        '
        Me.autoSaveSet.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.autoSave, Me.beforeSave})
        Me.autoSaveSet.Name = "autoSaveSet"
        Me.autoSaveSet.Size = New System.Drawing.Size(182, 22)
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
        Me.savePathSet.Size = New System.Drawing.Size(182, 22)
        Me.savePathSet.Text = "저장 경로 설정"
        '
        'GoSavePath
        '
        Me.GoSavePath.Name = "GoSavePath"
        Me.GoSavePath.Size = New System.Drawing.Size(182, 22)
        Me.GoSavePath.Text = "현재 저장 경로 보기"
        '
        '세부설정ToolStripMenuItem
        '
        Me.세부설정ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FeeToolStripMenuItem})
        Me.세부설정ToolStripMenuItem.Name = "세부설정ToolStripMenuItem"
        Me.세부설정ToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.세부설정ToolStripMenuItem.Text = "세부 설정"
        '
        'FeeToolStripMenuItem
        '
        Me.FeeToolStripMenuItem.Name = "FeeToolStripMenuItem"
        Me.FeeToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.FeeToolStripMenuItem.Text = "Fee"
        '
        'fileModify
        '
        Me.fileModify.BackColor = System.Drawing.SystemColors.HighlightText
        Me.fileModify.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileModify.Font = New System.Drawing.Font("나눔고딕", 8.249999!)
        Me.fileModify.Location = New System.Drawing.Point(1, 159)
        Me.fileModify.Name = "fileModify"
        Me.fileModify.Size = New System.Drawing.Size(40, 49)
        Me.fileModify.TabIndex = 14
        Me.fileModify.Text = "수정"
        Me.fileModify.UseVisualStyleBackColor = False
        '
        'FileListBox
        '
        Me.FileListBox.AllowDrop = True
        Me.FileListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FileListBox.ColumnWidth = 1
        Me.FileListBox.Cursor = System.Windows.Forms.Cursors.Default
        Me.FileListBox.Font = New System.Drawing.Font("나눔고딕", 9.0!)
        Me.FileListBox.FormattingEnabled = True
        Me.FileListBox.HorizontalScrollbar = True
        Me.FileListBox.ItemHeight = 14
        Me.FileListBox.Location = New System.Drawing.Point(-1, 0)
        Me.FileListBox.Name = "FileListBox"
        Me.FileListBox.Size = New System.Drawing.Size(256, 154)
        Me.FileListBox.TabIndex = 1
        '
        'fileClear
        '
        Me.fileClear.BackColor = System.Drawing.SystemColors.HighlightText
        Me.fileClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileClear.Font = New System.Drawing.Font("나눔고딕", 8.249999!)
        Me.fileClear.Location = New System.Drawing.Point(81, 159)
        Me.fileClear.Name = "fileClear"
        Me.fileClear.Size = New System.Drawing.Size(40, 49)
        Me.fileClear.TabIndex = 12
        Me.fileClear.Text = "전체삭제"
        Me.fileClear.UseVisualStyleBackColor = False
        '
        'fileDel
        '
        Me.fileDel.BackColor = System.Drawing.SystemColors.HighlightText
        Me.fileDel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.fileDel.Font = New System.Drawing.Font("나눔고딕", 8.249999!)
        Me.fileDel.Location = New System.Drawing.Point(41, 159)
        Me.fileDel.Name = "fileDel"
        Me.fileDel.Size = New System.Drawing.Size(40, 49)
        Me.fileDel.TabIndex = 11
        Me.fileDel.Text = "삭제"
        Me.fileDel.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(261, 50)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ExchangeMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(344, 210)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fileDraw)
        Me.Controls.Add(Me.fileModify)
        Me.Controls.Add(Me.FileListBox)
        Me.Controls.Add(Me.fileClear)
        Me.Controls.Add(Me.fileDel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ExchangeMain"
        Me.Text = "수입면장자동화"
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
    Friend WithEvents GoSavePath As ToolStripMenuItem
    Friend WithEvents 세부설정ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
End Class
