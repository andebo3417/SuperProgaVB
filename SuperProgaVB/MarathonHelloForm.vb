Public Class MarathonHelloForm

    Private parent_ As Form1

    Public Sub New(parent_ As Form1)
        InitializeComponent()
        Me.parent_ = parent_
    End Sub

    Private Sub BtnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        parent_.openChildForm(New ExamForm("marathon"))
    End Sub
End Class