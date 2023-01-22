<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.panelMainMenu = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnTheory = New System.Windows.Forms.Button()
        Me.btnMarathon = New System.Windows.Forms.Button()
        Me.btnTheme = New System.Windows.Forms.Button()
        Me.btnTicket = New System.Windows.Forms.Button()
        Me.btnExam = New System.Windows.Forms.Button()
        Me.panelInnerForm = New System.Windows.Forms.Panel()
        Me.panelMainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelMainMenu
        '
        Me.panelMainMenu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panelMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.panelMainMenu.Controls.Add(Me.btnMenu)
        Me.panelMainMenu.Controls.Add(Me.btnTheory)
        Me.panelMainMenu.Controls.Add(Me.btnMarathon)
        Me.panelMainMenu.Controls.Add(Me.btnTheme)
        Me.panelMainMenu.Controls.Add(Me.btnTicket)
        Me.panelMainMenu.Controls.Add(Me.btnExam)
        Me.panelMainMenu.Location = New System.Drawing.Point(-1, -1)
        Me.panelMainMenu.Name = "panelMainMenu"
        Me.panelMainMenu.Size = New System.Drawing.Size(52, 612)
        Me.panelMainMenu.TabIndex = 2
        '
        'btnMenu
        '
        Me.btnMenu.FlatAppearance.BorderSize = 0
        Me.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMenu.Image = Global.SuperProgaVB.My.Resources.Resources.menu
        Me.btnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.Location = New System.Drawing.Point(0, 0)
        Me.btnMenu.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(55, 51)
        Me.btnMenu.TabIndex = 11
        Me.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMenu.UseVisualStyleBackColor = True
        '
        'btnTheory
        '
        Me.btnTheory.FlatAppearance.BorderSize = 0
        Me.btnTheory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTheory.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTheory.Image = Global.SuperProgaVB.My.Resources.Resources.theory
        Me.btnTheory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTheory.Location = New System.Drawing.Point(0, 561)
        Me.btnTheory.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTheory.Name = "btnTheory"
        Me.btnTheory.Size = New System.Drawing.Size(160, 51)
        Me.btnTheory.TabIndex = 10
        Me.btnTheory.Text = "Теория"
        Me.btnTheory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTheory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTheory.UseVisualStyleBackColor = True
        '
        'btnMarathon
        '
        Me.btnMarathon.FlatAppearance.BorderSize = 0
        Me.btnMarathon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnMarathon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarathon.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnMarathon.Image = Global.SuperProgaVB.My.Resources.Resources.marathon
        Me.btnMarathon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarathon.Location = New System.Drawing.Point(0, 218)
        Me.btnMarathon.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMarathon.Name = "btnMarathon"
        Me.btnMarathon.Size = New System.Drawing.Size(160, 51)
        Me.btnMarathon.TabIndex = 9
        Me.btnMarathon.Text = "Марафон"
        Me.btnMarathon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMarathon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMarathon.UseVisualStyleBackColor = True
        '
        'btnTheme
        '
        Me.btnTheme.FlatAppearance.BorderSize = 0
        Me.btnTheme.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTheme.Image = Global.SuperProgaVB.My.Resources.Resources.theme
        Me.btnTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTheme.Location = New System.Drawing.Point(0, 167)
        Me.btnTheme.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTheme.Name = "btnTheme"
        Me.btnTheme.Size = New System.Drawing.Size(160, 51)
        Me.btnTheme.TabIndex = 8
        Me.btnTheme.Text = "По темам"
        Me.btnTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTheme.UseVisualStyleBackColor = True
        '
        'btnTicket
        '
        Me.btnTicket.FlatAppearance.BorderSize = 0
        Me.btnTicket.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTicket.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnTicket.Image = Global.SuperProgaVB.My.Resources.Resources.ticket
        Me.btnTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTicket.Location = New System.Drawing.Point(0, 116)
        Me.btnTicket.Margin = New System.Windows.Forms.Padding(0)
        Me.btnTicket.Name = "btnTicket"
        Me.btnTicket.Size = New System.Drawing.Size(160, 51)
        Me.btnTicket.TabIndex = 7
        Me.btnTicket.Text = "Билеты"
        Me.btnTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTicket.UseVisualStyleBackColor = True
        '
        'btnExam
        '
        Me.btnExam.FlatAppearance.BorderSize = 0
        Me.btnExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExam.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnExam.Image = Global.SuperProgaVB.My.Resources.Resources.exam
        Me.btnExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExam.Location = New System.Drawing.Point(0, 65)
        Me.btnExam.Margin = New System.Windows.Forms.Padding(0)
        Me.btnExam.Name = "btnExam"
        Me.btnExam.Size = New System.Drawing.Size(160, 51)
        Me.btnExam.TabIndex = 6
        Me.btnExam.Text = "Экзамен"
        Me.btnExam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnExam.UseVisualStyleBackColor = True
        '
        'panelInnerForm
        '
        Me.panelInnerForm.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelInnerForm.BackColor = System.Drawing.Color.RoyalBlue
        Me.panelInnerForm.Location = New System.Drawing.Point(42, -1)
        Me.panelInnerForm.Name = "panelInnerForm"
        Me.panelInnerForm.Size = New System.Drawing.Size(1044, 612)
        Me.panelInnerForm.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 611)
        Me.Controls.Add(Me.panelMainMenu)
        Me.Controls.Add(Me.panelInnerForm)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.panelMainMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panelMainMenu As Panel
    Private WithEvents btnMenu As Button
    Private WithEvents btnTheory As Button
    Private WithEvents btnMarathon As Button
    Private WithEvents btnTheme As Button
    Private WithEvents btnTicket As Button
    Private WithEvents btnExam As Button
    Private WithEvents panelInnerForm As Panel
End Class
