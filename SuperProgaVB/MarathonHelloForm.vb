Public Class MarathonHelloForm
    Private parent_ As Form1
    Public MarathonHelloForm(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        Private void BtnProceed_Click(Object sender, EventArgs e)
        {
            parent.openChildForm(New ExamForm("marathon"));
        }
End Class