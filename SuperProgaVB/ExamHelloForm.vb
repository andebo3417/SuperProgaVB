Public Class ExamHelloForm
    Private parent_ As Form1
    Public Sub New(parent_ As Form1)
        InitializeComponent()
        Me.parent_ = parent_
    End Sub

    Private Sub btnProceed_clicl(sender As Object, e As EventArgs) Handles btnProceed.Click
        parent_.openChildForm(New ExamForm("exam"))
    End Sub
End Class