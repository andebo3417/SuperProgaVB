<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timerExam = New System.Windows.Forms.Timer(Me.components)
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnEndExam = New System.Windows.Forms.Button()
        Me.btnShowBye = New System.Windows.Forms.Button()
        Me.labelTime = New System.Windows.Forms.Label()
        Me.btnHideBye = New System.Windows.Forms.Button()
        Me.labelNoAnswer = New System.Windows.Forms.Label()
        Me.labelWrong = New System.Windows.Forms.Label()
        Me.labelRight = New System.Windows.Forms.Label()
        Me.labelAll = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lblNa = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblbW = New System.Windows.Forms.Label()
        Me.labelResult = New System.Windows.Forms.Label()
        Me.panelBye = New System.Windows.Forms.Panel()
        Me.btnAnswer4 = New System.Windows.Forms.Button()
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.btnAnswer1 = New System.Windows.Forms.Button()
        Me.RtbQuestion = New System.Windows.Forms.RichTextBox()
        Me.panelQuiz = New System.Windows.Forms.Panel()
        Me.pBoxImage = New System.Windows.Forms.PictureBox()
        Me.panelBye.SuspendLayout()
        Me.panelQuiz.SuspendLayout()
        CType(Me.pBoxImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerExam
        '
        Me.timerExam.Interval = 1000
        '
        'btnNext
        '
        Me.btnNext.BackgroundImage = Global.SuperProgaVB.My.Resources.Resources.right_arrow
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Location = New System.Drawing.Point(965, 550)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(60, 50)
        Me.btnNext.TabIndex = 7
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.BackgroundImage = Global.SuperProgaVB.My.Resources.Resources.left_arrow
        Me.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrev.Enabled = False
        Me.btnPrev.FlatAppearance.BorderSize = 0
        Me.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrev.Location = New System.Drawing.Point(12, 549)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(60, 50)
        Me.btnPrev.TabIndex = 6
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnEndExam
        '
        Me.btnEndExam.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEndExam.FlatAppearance.BorderSize = 0
        Me.btnEndExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnEndExam.Location = New System.Drawing.Point(831, 12)
        Me.btnEndExam.Name = "btnEndExam"
        Me.btnEndExam.Size = New System.Drawing.Size(194, 64)
        Me.btnEndExam.TabIndex = 12
        Me.btnEndExam.Text = "Завершить тестирование"
        Me.btnEndExam.UseVisualStyleBackColor = False
        '
        'btnShowBye
        '
        Me.btnShowBye.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnShowBye.FlatAppearance.BorderSize = 0
        Me.btnShowBye.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowBye.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnShowBye.Location = New System.Drawing.Point(831, 93)
        Me.btnShowBye.Name = "btnShowBye"
        Me.btnShowBye.Size = New System.Drawing.Size(194, 64)
        Me.btnShowBye.TabIndex = 11
        Me.btnShowBye.Text = "Показать результаты"
        Me.btnShowBye.UseVisualStyleBackColor = False
        Me.btnShowBye.Visible = False
        '
        'labelTime
        '
        Me.labelTime.AutoSize = True
        Me.labelTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelTime.Location = New System.Drawing.Point(12, 30)
        Me.labelTime.Name = "labelTime"
        Me.labelTime.Size = New System.Drawing.Size(66, 26)
        Me.labelTime.TabIndex = 10
        Me.labelTime.Text = "20:00"
        Me.labelTime.Visible = False
        '
        'btnHideBye
        '
        Me.btnHideBye.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnHideBye.FlatAppearance.BorderSize = 0
        Me.btnHideBye.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHideBye.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnHideBye.Location = New System.Drawing.Point(52, 338)
        Me.btnHideBye.Name = "btnHideBye"
        Me.btnHideBye.Size = New System.Drawing.Size(291, 49)
        Me.btnHideBye.TabIndex = 9
        Me.btnHideBye.Text = "Показать вопросы"
        Me.btnHideBye.UseVisualStyleBackColor = False
        '
        'labelNoAnswer
        '
        Me.labelNoAnswer.AutoSize = True
        Me.labelNoAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelNoAnswer.ForeColor = System.Drawing.Color.Snow
        Me.labelNoAnswer.Location = New System.Drawing.Point(320, 287)
        Me.labelNoAnswer.Name = "labelNoAnswer"
        Me.labelNoAnswer.Size = New System.Drawing.Size(24, 26)
        Me.labelNoAnswer.TabIndex = 8
        Me.labelNoAnswer.Text = "0"
        '
        'labelWrong
        '
        Me.labelWrong.AutoSize = True
        Me.labelWrong.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelWrong.ForeColor = System.Drawing.Color.DarkRed
        Me.labelWrong.Location = New System.Drawing.Point(320, 249)
        Me.labelWrong.Name = "labelWrong"
        Me.labelWrong.Size = New System.Drawing.Size(24, 26)
        Me.labelWrong.TabIndex = 7
        Me.labelWrong.Text = "0"
        '
        'labelRight
        '
        Me.labelRight.AutoSize = True
        Me.labelRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelRight.ForeColor = System.Drawing.Color.SeaGreen
        Me.labelRight.Location = New System.Drawing.Point(320, 209)
        Me.labelRight.Name = "labelRight"
        Me.labelRight.Size = New System.Drawing.Size(24, 26)
        Me.labelRight.TabIndex = 6
        Me.labelRight.Text = "0"
        '
        'labelAll
        '
        Me.labelAll.AutoSize = True
        Me.labelAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.labelAll.Location = New System.Drawing.Point(320, 166)
        Me.labelAll.Name = "labelAll"
        Me.labelAll.Size = New System.Drawing.Size(24, 26)
        Me.labelAll.TabIndex = 5
        Me.labelAll.Text = "0"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.Location = New System.Drawing.Point(47, 166)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(183, 26)
        Me.label1.TabIndex = 4
        Me.label1.Text = "Всего вопросов: "
        '
        'lblNa
        '
        Me.lblNa.AutoSize = True
        Me.lblNa.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblNa.Location = New System.Drawing.Point(47, 287)
        Me.lblNa.Name = "lblNa"
        Me.lblNa.Size = New System.Drawing.Size(252, 26)
        Me.lblNa.TabIndex = 3
        Me.lblNa.Text = "Вопросов не отвечено: "
        '
        'lblR
        '
        Me.lblR.AutoSize = True
        Me.lblR.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblR.Location = New System.Drawing.Point(47, 209)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(238, 26)
        Me.lblR.TabIndex = 2
        Me.lblR.Text = "Правильных ответов: "
        '
        'lblbW
        '
        Me.lblbW.AutoSize = True
        Me.lblbW.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblbW.Location = New System.Drawing.Point(47, 249)
        Me.lblbW.Name = "lblbW"
        Me.lblbW.Size = New System.Drawing.Size(215, 26)
        Me.lblbW.TabIndex = 1
        Me.lblbW.Text = "Ошибок допущено: "
        '
        'labelResult
        '
        Me.labelResult.AutoSize = True
        Me.labelResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.labelResult.Location = New System.Drawing.Point(45, 84)
        Me.labelResult.Name = "labelResult"
        Me.labelResult.Size = New System.Drawing.Size(260, 37)
        Me.labelResult.TabIndex = 0
        Me.labelResult.Text = "Экзамен не сдан"
        '
        'panelBye
        '
        Me.panelBye.BackColor = System.Drawing.SystemColors.ControlDark
        Me.panelBye.Controls.Add(Me.btnHideBye)
        Me.panelBye.Controls.Add(Me.labelNoAnswer)
        Me.panelBye.Controls.Add(Me.labelWrong)
        Me.panelBye.Controls.Add(Me.labelRight)
        Me.panelBye.Controls.Add(Me.labelAll)
        Me.panelBye.Controls.Add(Me.label1)
        Me.panelBye.Controls.Add(Me.lblNa)
        Me.panelBye.Controls.Add(Me.lblR)
        Me.panelBye.Controls.Add(Me.lblbW)
        Me.panelBye.Controls.Add(Me.labelResult)
        Me.panelBye.Location = New System.Drawing.Point(46, 79)
        Me.panelBye.Name = "panelBye"
        Me.panelBye.Size = New System.Drawing.Size(187, 397)
        Me.panelBye.TabIndex = 11
        Me.panelBye.Visible = False
        '
        'btnAnswer4
        '
        Me.btnAnswer4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAnswer4.FlatAppearance.BorderSize = 0
        Me.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer4.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAnswer4.Location = New System.Drawing.Point(562, 460)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(304, 61)
        Me.btnAnswer4.TabIndex = 5
        Me.btnAnswer4.Text = "Answer4"
        Me.btnAnswer4.UseVisualStyleBackColor = False
        '
        'btnAnswer3
        '
        Me.btnAnswer3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAnswer3.FlatAppearance.BorderSize = 0
        Me.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer3.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAnswer3.Location = New System.Drawing.Point(239, 460)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(304, 61)
        Me.btnAnswer3.TabIndex = 4
        Me.btnAnswer3.Text = "Answer3"
        Me.btnAnswer3.UseVisualStyleBackColor = False
        '
        'btnAnswer2
        '
        Me.btnAnswer2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAnswer2.FlatAppearance.BorderSize = 0
        Me.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer2.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAnswer2.Location = New System.Drawing.Point(562, 393)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(304, 61)
        Me.btnAnswer2.TabIndex = 3
        Me.btnAnswer2.Text = "Answer2"
        Me.btnAnswer2.UseVisualStyleBackColor = False
        '
        'btnAnswer1
        '
        Me.btnAnswer1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAnswer1.FlatAppearance.BorderSize = 0
        Me.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnswer1.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnAnswer1.Location = New System.Drawing.Point(239, 393)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(304, 61)
        Me.btnAnswer1.TabIndex = 2
        Me.btnAnswer1.Text = "Answer1"
        Me.btnAnswer1.UseVisualStyleBackColor = False
        '
        'RtbQuestion
        '
        Me.RtbQuestion.BackColor = System.Drawing.SystemColors.Control
        Me.RtbQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RtbQuestion.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RtbQuestion.Location = New System.Drawing.Point(12, 316)
        Me.RtbQuestion.Name = "RtbQuestion"
        Me.RtbQuestion.Size = New System.Drawing.Size(1013, 58)
        Me.RtbQuestion.TabIndex = 1
        Me.RtbQuestion.Text = "В каком случае водитель совершит вынужденную остановку?"
        '
        'panelQuiz
        '
        Me.panelQuiz.BackColor = System.Drawing.SystemColors.Control
        Me.panelQuiz.Controls.Add(Me.panelBye)
        Me.panelQuiz.Controls.Add(Me.btnNext)
        Me.panelQuiz.Controls.Add(Me.btnPrev)
        Me.panelQuiz.Controls.Add(Me.btnAnswer4)
        Me.panelQuiz.Controls.Add(Me.btnAnswer3)
        Me.panelQuiz.Controls.Add(Me.btnAnswer2)
        Me.panelQuiz.Controls.Add(Me.btnAnswer1)
        Me.panelQuiz.Controls.Add(Me.RtbQuestion)
        Me.panelQuiz.Controls.Add(Me.pBoxImage)
        Me.panelQuiz.Controls.Add(Me.btnEndExam)
        Me.panelQuiz.Controls.Add(Me.btnShowBye)
        Me.panelQuiz.Controls.Add(Me.labelTime)
        Me.panelQuiz.Location = New System.Drawing.Point(0, 0)
        Me.panelQuiz.Name = "panelQuiz"
        Me.panelQuiz.Size = New System.Drawing.Size(1037, 612)
        Me.panelQuiz.TabIndex = 9
        '
        'pBoxImage
        '
        Me.pBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pBoxImage.Location = New System.Drawing.Point(363, 30)
        Me.pBoxImage.Name = "pBoxImage"
        Me.pBoxImage.Size = New System.Drawing.Size(321, 228)
        Me.pBoxImage.TabIndex = 0
        Me.pBoxImage.TabStop = False
        '
        'ExamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 612)
        Me.Controls.Add(Me.panelQuiz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamForm"
        Me.Text = "ExamForm"
        Me.panelBye.ResumeLayout(False)
        Me.panelBye.PerformLayout()
        Me.panelQuiz.ResumeLayout(False)
        Me.panelQuiz.PerformLayout()
        CType(Me.pBoxImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents timerExam As Timer
    Private WithEvents btnNext As Button
    Private WithEvents btnPrev As Button
    Private WithEvents pBoxImage As PictureBox
    Private WithEvents btnEndExam As Button
    Private WithEvents btnShowBye As Button
    Private WithEvents labelTime As Label
    Private WithEvents btnHideBye As Button
    Private WithEvents labelNoAnswer As Label
    Private WithEvents labelWrong As Label
    Private WithEvents labelRight As Label
    Private WithEvents labelAll As Label
    Private WithEvents label1 As Label
    Private WithEvents lblNa As Label
    Private WithEvents lblR As Label
    Private WithEvents lblbW As Label
    Private WithEvents labelResult As Label
    Private WithEvents panelBye As Panel
    Private WithEvents btnAnswer4 As Button
    Private WithEvents btnAnswer3 As Button
    Private WithEvents btnAnswer2 As Button
    Private WithEvents btnAnswer1 As Button
    Private WithEvents RtbQuestion As RichTextBox
    Private WithEvents panelQuiz As Panel
End Class
