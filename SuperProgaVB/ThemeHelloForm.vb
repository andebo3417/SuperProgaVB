Public Class ThemeHelloForm
    Private parent_ As Form1
    Public Sub New(parent_ As Form1)
        InitializeComponent()
        Me.parent_ = parent_
    End Sub

    Private Sub ThemeChoose_Click(sender As Object, e As EventArgs) Handles lblTheme9.Click, lblTheme8.Click, lblTheme7.Click, lblTheme6.Click, lblTheme5.Click, lblTheme4.Click, lblTheme3.Click, lblTheme2.Click, lblTheme13.Click, lblTheme12.Click, lblTheme11.Click, lblTheme10.Click, lblTheme1.Click
        Dim theme As String = DirectCast(sender, Label).Name
        Select Case theme
            Case "lblTheme1"
                parent_.openChildForm(New ExamForm("theme", "theme1"))
            Case "lblTheme2"
                parent_.openChildForm(New ExamForm("theme", "theme2"))
        End Select
    End Sub
End Class