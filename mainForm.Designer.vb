﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnViewSubmission = New System.Windows.Forms.Button()
        Me.btnCreateNewSubmission = New System.Windows.Forms.Button()
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnViewSubmission
        '
        Me.btnViewSubmission.AccessibleDescription = ""
        Me.btnViewSubmission.AccessibleName = "btnViewSubmissionsForm"
        Me.btnViewSubmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.btnViewSubmission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewSubmission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnViewSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSubmission.Location = New System.Drawing.Point(139, 184)
        Me.btnViewSubmission.Name = "btnViewSubmission"
        Me.btnViewSubmission.Size = New System.Drawing.Size(535, 50)
        Me.btnViewSubmission.TabIndex = 0
        Me.btnViewSubmission.Text = "VIEW SUBMISSIONS ( CTRL + V )"
        Me.btnViewSubmission.UseVisualStyleBackColor = False
        '
        'btnCreateNewSubmission
        '
        Me.btnCreateNewSubmission.AccessibleName = "btnCreateSubmissionForm"
        Me.btnCreateNewSubmission.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCreateNewSubmission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateNewSubmission.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewSubmission.Location = New System.Drawing.Point(139, 257)
        Me.btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        Me.btnCreateNewSubmission.Size = New System.Drawing.Size(535, 50)
        Me.btnCreateNewSubmission.TabIndex = 1
        Me.btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION ( CTRL + N )"
        Me.btnCreateNewSubmission.UseVisualStyleBackColor = False
        '
        'lblProjectName
        '
        Me.lblProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.Location = New System.Drawing.Point(136, 102)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(538, 61)
        Me.lblProjectName.TabIndex = 2
        Me.lblProjectName.Text = "SM Saif, Slidely Task- 2 -  Slidely Forms App"
        Me.lblProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AccessibleName = "mainForm"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblProjectName)
        Me.Controls.Add(Me.btnCreateNewSubmission)
        Me.Controls.Add(Me.btnViewSubmission)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnViewSubmission As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents lblProjectName As Label
End Class
