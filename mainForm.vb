Public Class Form1
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True ' To capture key presses
    End Sub

    Private Sub btnViewSubmission_Click(sender As Object, e As EventArgs) Handles btnViewSubmission.Click
        ' Open the View Submissions Form
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.ShowDialog()
    End Sub

    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        ' Open the Create Submission Form
        Dim createForm As New CreateSubmissionForm()
        createForm.ShowDialog()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.V
                    btnViewSubmission.PerformClick()
                Case Keys.N
                    btnCreateNewSubmission.PerformClick()
            End Select
        End If
    End Sub
End Class
