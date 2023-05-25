<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileDataList
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ReportGirdView = New System.Windows.Forms.DataGridView()
        Me.back_btn = New System.Windows.Forms.Button()
        CType(Me.ReportGirdView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(309, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 6
        Me.DateTimePicker1.Visible = False
        '
        'ReportGirdView
        '
        Me.ReportGirdView.AllowUserToAddRows = False
        Me.ReportGirdView.AllowUserToDeleteRows = False
        Me.ReportGirdView.AllowUserToResizeColumns = False
        Me.ReportGirdView.AllowUserToResizeRows = False
        Me.ReportGirdView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.ReportGirdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReportGirdView.Location = New System.Drawing.Point(-2, 1)
        Me.ReportGirdView.MultiSelect = False
        Me.ReportGirdView.Name = "ReportGirdView"
        Me.ReportGirdView.RowTemplate.Height = 23
        Me.ReportGirdView.Size = New System.Drawing.Size(522, 248)
        Me.ReportGirdView.TabIndex = 5
        Me.ReportGirdView.TabStop = False
        '
        'back_btn
        '
        Me.back_btn.Location = New System.Drawing.Point(-10, 249)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(536, 23)
        Me.back_btn.TabIndex = 4
        Me.back_btn.Text = "돌아가기"
        Me.back_btn.UseVisualStyleBackColor = True
        '
        'FileDataList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(516, 272)
        Me.ControlBox = False
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ReportGirdView)
        Me.Controls.Add(Me.back_btn)
        Me.MaximizeBox = False
        Me.Name = "FileDataList"
        Me.Text = "FileDataList"
        CType(Me.ReportGirdView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ReportGirdView As DataGridView
    Friend WithEvents back_btn As Button
End Class
