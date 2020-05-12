<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CFrmRoot
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
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me._txb1 = New System.Windows.Forms.TextBox()
        Me._btn1 = New System.Windows.Forms.Button()
        Me._btn2 = New System.Windows.Forms.Button()
        Me._lbl1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_txb1
        '
        Me._txb1.Font = New System.Drawing.Font("맑은 고딕", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me._txb1.Location = New System.Drawing.Point(12, 12)
        Me._txb1.Multiline = True
        Me._txb1.Name = "_txb1"
        Me._txb1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me._txb1.Size = New System.Drawing.Size(736, 160)
        Me._txb1.TabIndex = 1
        Me._txb1.WordWrap = False
        '
        '_btn1
        '
        Me._btn1.Location = New System.Drawing.Point(408, 265)
        Me._btn1.Name = "_btn1"
        Me._btn1.Size = New System.Drawing.Size(340, 23)
        Me._btn1.TabIndex = 8
        Me._btn1.TabStop = False
        Me._btn1.Text = "▼▼▼ Stamp and Copy to Clipboard (CTRL+E)"
        Me._btn1.UseVisualStyleBackColor = True
        '
        '_btn2
        '
        Me._btn2.Location = New System.Drawing.Point(12, 265)
        Me._btn2.Name = "_btn2"
        Me._btn2.Size = New System.Drawing.Size(170, 23)
        Me._btn2.TabIndex = 10
        Me._btn2.TabStop = False
        Me._btn2.Text = "▼▼▼ Reset (CTRL+R)"
        Me._btn2.UseVisualStyleBackColor = True
        '
        '_lbl1
        '
        Me._lbl1.Font = New System.Drawing.Font("맑은 고딕", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me._lbl1.Location = New System.Drawing.Point(12, 175)
        Me._lbl1.Name = "_lbl1"
        Me._lbl1.Size = New System.Drawing.Size(736, 80)
        Me._lbl1.TabIndex = 11
        '
        'CFrmRoot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 300)
        Me.Controls.Add(Me._lbl1)
        Me.Controls.Add(Me._btn2)
        Me.Controls.Add(Me._btn1)
        Me.Controls.Add(Me._txb1)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "CFrmRoot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _txb1 As System.Windows.Forms.TextBox
    Friend WithEvents _btn1 As System.Windows.Forms.Button
    Friend WithEvents _btn2 As System.Windows.Forms.Button
    Friend WithEvents _lbl1 As System.Windows.Forms.Label

End Class
