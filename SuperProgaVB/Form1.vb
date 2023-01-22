Public Class Form1
    Private MenuIsOpen As Boolean = False
    Private Shadows activeForm As Form

    Public Sub New()

        InitializeComponent()
        Question.createList()
    End Sub

    'Menu show/hide
    Private Async Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        Dim expectation As Boolean = False

        If MenuIsOpen = True Then
            While Not expectation And panelMainMenu.Size.Width > 52
                expectation = True
                Await Task.Delay(1)
                panelMainMenu.Size = New Size(panelMainMenu.Size.Width - panelMainMenu.Size.Width / 6 - 1, panelMainMenu.Size.Height)
                expectation = False
            End While
            MenuIsOpen = False
        Else
            While Not expectation And panelMainMenu.Size.Width < 160
                expectation = True
                Await Task.Delay(1)
                panelMainMenu.Size = New Size(panelMainMenu.Size.Width + (160 - panelMainMenu.Size.Width) / 5 + 1, panelMainMenu.Size.Height)
                expectation = False
            End While
            MenuIsOpen = True
        End If
    End Sub

    'Inner form show
    Public Sub openChildForm(ChildForm As Form)
        If Not activeForm Is Nothing Then
            activeForm.Close()
        End If
        activeForm = ChildForm
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill
        panelInnerForm.Controls.Add(ChildForm)
        panelInnerForm.Tag = ChildForm
        ChildForm.BringToFront()
        ChildForm.Show()
        activeForm = ChildForm
    End Sub

    Private Sub OpenExamForm(sender As Object, e As EventArgs) Handles btnExam.Click
        openChildForm(New ExamHelloForm(Me))
    End Sub

    Private Sub OpenTicketForm(sender As Object, e As EventArgs) Handles btnTicket.Click
        'openChildForm(New TicketHelloForm(Me))
    End Sub

    Private Sub OpenThemeForm(sender As Object, e As EventArgs) Handles btnTheme.Click
        'openChildForm(New ThemeHelloForm(Me))
    End Sub

    Private Sub OpenMarathonForm(sender As Object, e As EventArgs) Handles btnMarathon.Click
        'openChildForm(New MarathonHelloForm(Me))
    End Sub

    Private Sub OpenTheoryForm(sender As Object, e As EventArgs) Handles btnTheory.Click

        openChildForm(New TheoryForm())
    End Sub
End Class
