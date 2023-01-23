Public Class TheoryForm
    Public Sub New()
        InitializeComponent()
        panelTheory.Location = New Point(0, 0)
    End Sub

    Private Sub Label_Click(sender As Object, e As EventArgs) Handles label9.Click, label8.Click, label7.Click, label6.Click, label5.Click, label4.Click, label3.Click, label28.Click, label27.Click, label25.Click, label24.Click, label23.Click, label22.Click, label21.Click, label20.Click, label2.Click, label19.Click, label18.Click, label17.Click, label16.Click, label15.Click, label14.Click, label13.Click, label12.Click, label11.Click, label10.Click

        Dim number As String = DirectCast(sender, Label).Text(0).ToString() + DirectCast(sender, Label).Text(1)
        If number(1) = "."c Then number = number.Remove(1, 1)
        rtbTheory.Text = Question.theoryList(Integer.Parse(number) - 1).theory
        panelTheory.Visible = True
        panelTheory.BringToFront()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        panelTheory.Visible = False
        panelPars.BringToFront()
    End Sub
End Class