# SM_Saif_Google_Forms

# Frontend for Form Submission Management System

This repository contains the frontend implementation for a Form Submission Management System. It provides a user interface built with Visual Basic for handling form submissions including creation, viewing, updating, and deleting submissions via RESTful APIs provided by a backend server.

## Features

- **Create New Submission**: Allows users to enter Name, Email, Phone Number, GitHub link, and start/stop a stopwatch to time submissions.
- **View Submissions**: Allows users to navigate through existing submissions, view details, and move between submissions using pagination.
- **Edit Submission**: Provides an option to edit existing submissions, including updating Name, Email, Phone Number, GitHub link, and stopwatch time.
- **Delete Submission**: Allows users to delete unwanted submissions from the system.

## Technologies Used

- **Visual Basic**: Programming language used for building the Windows desktop application.
- **RESTful APIs**: Backend APIs built with Node.js and Express to manage form submissions.
- **JSON**: Data format used for communication with the backend and storing form submission data.
- **HttpClient**: Used for making HTTP requests to interact with backend APIs.

## Project Structure

The project structure in Visual Basic typically includes:

frontend
├── Form1.vb # Main form for navigating to View Submissions and Create New Submission forms
├── ViewSubmissionsForm.vb # Form for viewing existing submissions and navigating through them
└── CreateSubmissionForm.vb # Form for creating new submissions and interacting with the stopwatch



## Getting Started

To get the frontend application up and running locally, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/frontend.git
   cd frontend
Open the project in Visual Studio:
Open the .sln file in Visual Studio to load the project.

Build and Run:
Build the project using Visual Studio and run the application. Ensure the backend server is also running locally.

Use the Application:

Click on View Submissions to navigate through existing submissions.
Click on Create New Submission to enter new submissions and interact with the stopwatch.
Usage


Keyboard Shortcuts
Ctrl + V: Opens the View Submissions form.
Ctrl + N: Opens the Create New Submission form.
Ctrl + P: Navigates to the previous submission in the View Submissions form.
Ctrl + S: Submits the form in the Create New Submission form.
Notes
Ensure the backend server is running at http://localhost:3000 to interact with the APIs properly.
Adjust the backend API URLs in the frontend code if the backend server is running on a different port or host.
