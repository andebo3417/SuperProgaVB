<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExamHelloForm
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
        Me.panelHello = New System.Windows.Forms.Panel()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.RtbHello = New System.Windows.Forms.RichTextBox()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.panelHello.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelHello
        '
        Me.panelHello.BackColor = System.Drawing.SystemColors.Control
        Me.panelHello.Controls.Add(Me.btnProceed)
        Me.panelHello.Controls.Add(Me.RtbHello)
        Me.panelHello.Controls.Add(Me.pictureBox2)
        Me.panelHello.Location = New System.Drawing.Point(0, 0)
        Me.panelHello.Name = "panelHello"
        Me.panelHello.Size = New System.Drawing.Size(1037, 612)
        Me.panelHello.TabIndex = 10
        '
        'btnProceed
        '
        Me.btnProceed.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnProceed.FlatAppearance.BorderSize = 0
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnProceed.Image = Global.SuperProgaVB.My.Resources.Resources.quit
        Me.btnProceed.Location = New System.Drawing.Point(744, 485)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(194, 64)
        Me.btnProceed.TabIndex = 3
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProceed.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'RtbHello
        '
        Me.RtbHello.BackColor = System.Drawing.Color.DodgerBlue
        Me.RtbHello.Location = New System.Drawing.Point(33, 32)
        Me.RtbHello.Name = "RtbHello"
        Me.RtbHello.Size = New System.Drawing.Size(452, 517)
        Me.RtbHello.TabIndex = 1
        Me.RtbHello.Text = ""
        '
        'pictureBox2
        '
        Me.pictureBox2.BackgroundImage = Global.SuperProgaVB.My.Resources.Resources.exam
        Me.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox2.Location = New System.Drawing.Point(525, 32)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(67, 65)
        Me.pictureBox2.TabIndex = 0
        Me.pictureBox2.TabStop = False
        '
        'ExamHelloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 612)
        Me.Controls.Add(Me.panelHello)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ExamHelloForm"
        Me.Text = "ExamHelloForm"
        Me.panelHello.ResumeLayout(False)
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents panelHello As Panel
    Private WithEvents RtbHello As RichTextBox
    Private WithEvents pictureBox2 As PictureBox
    Private WithEvents btnProceed As Button
End Class
