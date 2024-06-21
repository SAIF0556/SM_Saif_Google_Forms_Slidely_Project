<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHub = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStartPause = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerUpdate = New System.Windows.Forms.Timer(Me.components)
        Me.lblStopwatch = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtEmail
        '
        Me.txtEmail.AccessibleName = "inpEmail"
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(441, 112)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(219, 26)
        Me.txtEmail.TabIndex = 23
        '
        'txtPhone
        '
        Me.txtPhone.AccessibleName = "inpPhone"
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(441, 160)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(219, 26)
        Me.txtPhone.TabIndex = 22
        '
        'txtGitHub
        '
        Me.txtGitHub.AccessibleName = "inpGithubLink"
        Me.txtGitHub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGitHub.Location = New System.Drawing.Point(441, 205)
        Me.txtGitHub.Name = "txtGitHub"
        Me.txtGitHub.Size = New System.Drawing.Size(219, 26)
        Me.txtGitHub.TabIndex = 21
        '
        'txtName
        '
        Me.txtName.AccessibleName = "inpName"
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(441, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(219, 26)
        Me.txtName.TabIndex = 19
        '
        'btnSubmit
        '
        Me.btnSubmit.AccessibleName = "btnNext"
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(162, 332)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(498, 35)
        Me.btnSubmit.TabIndex = 18
        Me.btnSubmit.Text = "SUBMIT ( CTRL + S )"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnStartPause
        '
        Me.btnStartPause.AccessibleName = "btnPrev"
        Me.btnStartPause.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnStartPause.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartPause.Location = New System.Drawing.Point(162, 268)
        Me.btnStartPause.Name = "btnStartPause"
        Me.btnStartPause.Size = New System.Drawing.Size(281, 37)
        Me.btnStartPause.TabIndex = 17
        Me.btnStartPause.Text = "TOGGLE STOP WATCH ( CTRL + T )"
        Me.btnStartPause.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(158, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Github Link For Task 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(158, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Phone Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(158, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "E-mail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Name"
        '
        'lblStopwatch
        '
        Me.lblStopwatch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStopwatch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStopwatch.Location = New System.Drawing.Point(476, 268)
        Me.lblStopwatch.Name = "lblStopwatch"
        Me.lblStopwatch.Size = New System.Drawing.Size(157, 37)
        Me.lblStopwatch.TabIndex = 24
        Me.lblStopwatch.Text = "Stop Watch"
        Me.lblStopwatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(158, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(502, 23)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "SM Saif, Slidely Task- 2 - Create Submission "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreateSubmissionForm
        '
        Me.AccessibleName = "CreateSubmissionForm"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblStopwatch)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtGitHub)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStartPause)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStartPause As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents timerUpdate As Timer
    Friend WithEvents Label6 As Label
End Class
