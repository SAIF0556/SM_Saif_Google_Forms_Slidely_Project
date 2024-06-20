Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.IO
Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True ' To capture key presses
    End Sub

    Private Sub btnStartPause_Click(sender As Object, e As EventArgs) Handles btnStartPause.Click
        ToggleStopwatch()
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim newSubmission As New FormSubmission(txtName.Text, txtEmail.Text, txtPhone.Text, txtGitHub.Text)
        Dim stopwatchTime As String = stopwatch.Elapsed.ToString("hh\:mm\:ss")

        Dim httpClient As New HttpClient()
        Dim json As String = JsonConvert.SerializeObject(New With {
            Key .FullName = newSubmission.FullName,
            Key .EmailAddress = newSubmission.EmailAddress,
            Key .PhoneNumber = newSubmission.PhoneNumber,
            Key .GitHubLink = newSubmission.GitHubLink,
            Key .stopwatch_time = stopwatchTime
        })

        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        File.WriteAllText("C:/Users/Saif/Desktop/temp.txt", content.ReadAsStringAsync().Result)
        Dim response = Await httpClient.PostAsync("http://localhost:3000/submit", content)

        If response.IsSuccessStatusCode Then
            MessageBox.Show("Submission created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to create submission.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        Me.Close()
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.S
                    btnSubmit.PerformClick()
                Case Keys.T
                    ToggleStopwatch()
            End Select
        End If
    End Sub

    Private Sub ToggleStopwatch()
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            btnStartPause.Text = "Resume"
        Else
            stopwatch.Start()
            btnStartPause.Text = "Pause"
        End If
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub


    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set default text for buttons
        btnStartPause.Text = "Start"
        lblStopwatch.Text = "00:00:00"
    End Sub
End Class

' The renamed Submission class to avoid conflict
Public Class FormSubmission
    Public Property FullName As String
    Public Property EmailAddress As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String

    Public Sub New(fullName As String, emailAddress As String, phoneNumber As String, gitHubLink As String)
        Me.FullName = fullName
        Me.EmailAddress = emailAddress
        Me.PhoneNumber = phoneNumber
        Me.GitHubLink = gitHubLink
    End Sub
End Class
