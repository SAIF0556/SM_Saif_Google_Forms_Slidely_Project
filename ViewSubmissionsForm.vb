Imports System.Net.Http
Imports Newtonsoft.Json



Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private totalSubmissions As Integer = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        Me.KeyPreview = True
        ' Add any initialization after the InitializeComponent() call.
        InitializeSubmissions()
    End Sub

    Private Async Sub InitializeSubmissions()
        totalSubmissions = Await GetTotalSubmissions()
        DisplaySubmission()
    End Sub

    Private Async Function GetTotalSubmissions() As Task(Of Integer)
        Dim httpClient As New HttpClient()
        Dim response = Await httpClient.GetAsync("http://localhost:3000/read?index=-1")

        If response.IsSuccessStatusCode Then
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()
            Dim submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(responseBody)
            Return submissions.Count
        Else
            MessageBox.Show($"Failed to load submissions. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End If
    End Function

    Private Async Sub DisplaySubmission()
        If totalSubmissions = 0 Then
            MessageBox.Show("No submissions available.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim httpClient As New HttpClient()
        Dim response = Await httpClient.GetAsync($"http://localhost:3000/read?index={currentIndex}")

        If response.IsSuccessStatusCode Then
            Dim responseBody As String = Await response.Content.ReadAsStringAsync()

            ' Log response for debugging
            System.IO.File.WriteAllText("C:/Users/Saif/Desktop/response.txt", responseBody)

            Dim submissionResponse = JsonConvert.DeserializeObject(Of SubmissionResponse)(responseBody)

            ' Check if submissionResponse is not null and contains the expected data
            If submissionResponse IsNot Nothing AndAlso submissionResponse.submission IsNot Nothing Then
                Dim submission = submissionResponse.submission
                txtName.Text = submission.FullName
                txtEmail.Text = submission.EmailAddress
                txtPhone.Text = submission.PhoneNumber
                txtGitHub.Text = submission.GitHubLink
                txtStopwatch.Text = submission.stopwatch_time



            Else
                MessageBox.Show("Invalid submission data received.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show($"Failed to load submission. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            DisplaySubmission()
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control Then
            Select Case e.KeyCode
                Case Keys.P
                    btnPrevious.PerformClick()
                Case Keys.N
                    btnNext.PerformClick()
            End Select
        End If
    End Sub

    Private Class SubmissionResponse
        Public Property submission As Submission
    End Class
End Class


Public Class Submission
    Public Property FullName As String
    Public Property EmailAddress As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property stopwatch_time As String ' Include the stopwatch_time property if needed

    Public Sub New(fullName As String, emailAddress As String, phoneNumber As String, gitHubLink As String, Optional stopwatchTime As String = "")
        Me.FullName = fullName
        Me.EmailAddress = emailAddress
        Me.PhoneNumber = phoneNumber
        Me.GitHubLink = gitHubLink
        Me.stopwatch_time = stopwatchTime
    End Sub
End Class
