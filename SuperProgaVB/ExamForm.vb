Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class ExamForm
    Private questions As Question()
    Private answers As Integer()
    Private curQuestion As Integer
    Private QuizMode As String = "exam"
    Private isChecking As Boolean = False
    Private mistakes As Integer = 0
    Private theme As String
    Private ticket As Integer

    Private minutes As Integer
    Private seconds As Integer

    Public Sub New(mode As String)
        InitializeComponent()
        RtbQuestion.BorderStyle = BorderStyle.None
        QuizMode = mode
        questions = createList()
        answers = New Integer(questions.Length - 1) {}
        curQuestion = 0
        showQuestion(questions(curQuestion))
        If mode = "exam" Then
            minutes = 20
            seconds = 0
            timerExam.Enabled = True
            labelTime.Visible = True
            updateTimer()
        End If
    End Sub

    Public Sub New(mode As String, theme As String)
        InitializeComponent()
        RtbQuestion.BorderStyle = BorderStyle.None
        QuizMode = mode
        Me.theme = theme
        questions = createList()
        answers = New Integer(questions.Length) {}
        curQuestion = 0
        showQuestion(questions(curQuestion))
    End Sub

    Public Sub New(mode As String, ticket As Integer)
        InitializeComponent()
        RtbQuestion.BorderStyle = BorderStyle.None
        QuizMode = mode
        questions = createList()
        answers = New Integer(questions.Length) {}
        curQuestion = 0
        showQuestion(questions(curQuestion))
        If mode = "ticket" Then
            Me.ticket = ticket
            minutes = 20
            seconds = 0
            timerExam.Enabled = True
            labelTime.Visible = True
            updateTimer()
        End If
    End Sub

    Private Function createList() As Question()
        Dim questions As Question()
        If QuizMode = "exam" Then
            questions = Question.getFive(Question.themes(0))
            'questions = Question.getFive(Question.themes(1))
            'questions = Question.getFive(Question.themes(2))
            'questions = Question.getFive(Question.themes(3))
        End If
        If QuizMode = "theme" Then
            questions = Question.createListByTheme(Me.theme)
        End If
        If QuizMode = "ticket" Then
            questions = Question.getTicket(ticket)
        End If
        If QuizMode = "marathon" Then
            questions = Question.getAll()
        End If

        Return questions
    End Function

    Private Sub showQuestion(question As Question)
        Dim path As String
        Dim answerVars As String() = question.answers.Split(";")
        If question.hasImg = True Then
            path = "assets\images\" & question.id & ".jpg"
            pBoxImage.BackgroundImage = New Bitmap(Bitmap.FromFile(path))
        Else
            pBoxImage.BackgroundImage = Global.SuperProgaVB.My.Resources.no_image
        End If
        RtbQuestion.Text = question.quest
        btnAnswer1.Text = answerVars(0)
        btnAnswer2.Text = answerVars(1)
        btnAnswer3.Text = answerVars(2)
        btnAnswer4.Text = answerVars(3)

        If isChecking = False Then
            clearButtons()
            enableBtns()
            If (answers(curQuestion) <> 0) Then
                paintGivenAns(answers(curQuestion))
                disableBtns()
            End If
        Else
            disableBtns()
            clearButtons()
            Select Case questions(curQuestion).rightAnswer
                Case 1
                    btnAnswer1.BackColor = Color.Green
                Case 2
                    btnAnswer2.BackColor = Color.Green
                Case 3
                    btnAnswer3.BackColor = Color.Green
                Case 4
                    btnAnswer4.BackColor = Color.Green
            End Select
            If questions(curQuestion).rightAnswer <> answers(curQuestion) And answers(curQuestion) <> 0 Then
                Select Case answers(curQuestion)
                    Case 1
                        btnAnswer1.BackColor = Color.Red
                    Case 2
                        btnAnswer2.BackColor = Color.Red
                    Case 3
                        btnAnswer3.BackColor = Color.Red
                    Case 4
                        btnAnswer4.BackColor = Color.Red
                End Select
            End If
        End If
    End Sub

    'Private OpenTicketForm(sender As Object, e As EventArgs) Handles btnTicket.Click

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        curQuestion = curQuestion + 1
        showQuestion(questions(curQuestion))
        If curQuestion = questions.Length - 1 Then btnNext.Enabled = False
        If curQuestion > 0 Then btnPrev.Enabled = True
    End Sub

    Private Sub BtnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        curQuestion = curQuestion - 1
        showQuestion(questions(curQuestion))
        If curQuestion = 0 Then btnPrev.Enabled = False
        If curQuestion < questions.Length - 1 Then btnNext.Enabled = True

    End Sub

    Private Sub BtnGiveAnswer(sender As Object, e As EventArgs) Handles btnAnswer1.Click, btnAnswer2.Click, btnAnswer3.Click, btnAnswer4.Click
        Dim ans As Integer = Integer.Parse(DirectCast(sender, Button).Name(DirectCast(sender, Button).Name.Length - 1).ToString())
        answers(curQuestion) = ans
        paintGivenAns(ans)
        disableBtns()

        If ans <> questions(curQuestion).rightAnswer Then
            mistakes = mistakes + 1
            If QuizMode = "exam" Then
                If mistakes < 2 Then
                    For Each themeCluster As String() In Question.themes
                        If (themeCluster.Contains(questions(curQuestion).theme)) Then
                            questions = questions.Concat(Question.getFive(questions, themeCluster)).ToArray()
                            answers = answers.Concat(New Integer(4) {}).ToArray()
                        End If
                    Next
                Else endExam()
                End If
            End If
        End If
    End Sub

    Private Sub BtnCheckAnswers(sender As Object, e As EventArgs) Handles btnEndExam.Click
        endExam()
    End Sub

    Private Sub clearButtons()
        btnAnswer1.BackColor = SystemColors.ActiveCaption
        btnAnswer2.BackColor = SystemColors.ActiveCaption
        btnAnswer3.BackColor = SystemColors.ActiveCaption
        btnAnswer4.BackColor = SystemColors.ActiveCaption
    End Sub

    Private Sub paintGivenAns(answer As Integer)
        clearButtons()
        Select Case answer
            Case 1
                btnAnswer1.BackColor = Color.Yellow
            Case 2
                btnAnswer2.BackColor = Color.Yellow
            Case 3
                btnAnswer3.BackColor = Color.Yellow
            Case 4
                btnAnswer4.BackColor = Color.Yellow
        End Select
    End Sub

    Private Sub disableBtns()
        btnAnswer1.Enabled = False
        btnAnswer2.Enabled = False
        btnAnswer3.Enabled = False
        btnAnswer4.Enabled = False
    End Sub

    Private Sub enableBtns()
        btnAnswer1.Enabled = True
        btnAnswer2.Enabled = True
        btnAnswer3.Enabled = True
        btnAnswer4.Enabled = True
    End Sub

    Private Sub updateTimer()
        Dim min As String
        Dim sec As String

        If minutes > 9 Then
            min = minutes.ToString()
        Else
            min = "0" + minutes.ToString()
        End If

        If seconds > 9 Then
            sec = seconds.ToString()
        Else
            sec = "0" + seconds.ToString()
        End If
    End Sub

    Private Sub endExam()
        Dim noAnswer As Integer = 0
        isChecking = True
        showQuestion(questions(curQuestion))
        timerExam.Stop()
        For Each var As Integer In answers
            If var = 0 Then noAnswer = noAnswer + 1
        Next
        labelAll.Text = questions.Length.ToString()
        labelWrong.Text = mistakes.ToString()
        labelNoAnswer.Text = noAnswer.ToString()
        labelRight.Text = (questions.Length - mistakes - noAnswer).ToString()
        panelBye.Visible = True
        panelBye.Location = New Point(0, 0)
        panelBye.Size = New Size(1037, 612)
        panelBye.BringToFront()
        btnShowBye.Visible = True
        btnEndExam.Enabled = False
    End Sub

    Private Sub TimerExam_Tick(sender As Object, e As EventArgs)
        Dim time As String = ""
        If seconds = 0 Then
            seconds = 59
            minutes = minutes - 1
        Else seconds = seconds - 1
        End If
        updateTimer()
        If time = "00:00" Then endExam()
    End Sub

    Private Sub BtnHideBye_Click(sender As Object, e As EventArgs) Handles btnHideBye.Click
        panelBye.Visible = False
    End Sub
    Private Sub BtnShowBye_Click(sender As Object, e As EventArgs) Handles btnShowBye.Click
        panelBye.Visible = True
    End Sub
End Class