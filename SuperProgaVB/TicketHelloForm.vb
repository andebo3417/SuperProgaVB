Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window

Public Class TicketHelloForm
    Private parent_ As Form1

    Public Sub New(parent_ As Form1)
        InitializeComponent()
        Me.parent_ = parent_
    End Sub

    Private Sub TicketChoose_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim number As String = DirectCast(sender, Button).Text
        parent_.openChildForm(New ExamForm("ticket", number))
    End Sub
End Class