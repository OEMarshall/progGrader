'Purpose: To automate the caluclations for student scores on projects
' Ochaun Marshall
' Date Created: 1/17/2018
' Last Modified: 4/30/2018

' ToDo:
'   Implement an Extra Credit form/ Methods

'   Different rubric for GP v.s. Prog assignment v.s. Prog II assignment
'   Settings - Have the option to change penalties in the Gui (Seprate Window)
'       -- Menu click event for it, Point breakdown window with cboBoxes
'   Have an option to change the rubric in Settings
'   Implement different programming rubrics for different courses
'   Submit to github
Public Class frmMain
    Private dblScore As Double = 25.0 ' Score for program 
    Private intDeductions As Integer = 0 ' Points taken off of program
    Private dblExtraCred As Double = 0 ' Extra credit
    Private intNumOfPrograms As Integer = 1 ' Number of programs in a project
    Private dblProgScoresArray(intNumOfPrograms) As Double ' Array holding scores
    Private intBtnCounter As Integer
    Public Enum Course ' Enum to set the course 
        'To be used for determining rubrics for programs
        Prog1 ' Honor's Computer Programming I
        Prog2 ' Honor's Computer Programming II
        AP ' AP Compputer Science A
        Principles ' AP Computer Science Principles
    End Enum
    Private currentCourse As Course

    'Private Property propCourse As Integer = -1 ' Prog1 = 0, Prog2 = 1, Ap = 2, Error = -1

    Public Sub setCourse(ByVal courseSetter As Course)
        currentCourse = courseSetter
    End Sub

    Public Function getCourse() As Course
        Return currentCourse
    End Function
    Public Sub changeScore(ByVal intScoreChange As Integer)
        dblScore = intScoreChange
    End Sub
    Public Sub changeScore(ByVal dblScoreChange As Double)
        dblScore = dblScoreChange
    End Sub
    Public Function getScore()
        Return dblScore
    End Function
    Public Sub addDeductions(ByVal intD As Integer)
        intDeductions += intD
    End Sub
    Public Sub addDeductions(ByVal dblD As Double)
        intDeductions += CInt(dblD)
    End Sub

    'PRE: All the checkboxes that apply to the program are checked
    ' and the number of programs has been determined
    Private Sub btnExecute_Click(sender As Object, e As EventArgs) Handles btnExecute.Click
        ' Static intBtnCounter As Integer
        ' Cant do this ^ anymore cause of scoping issue
        Dim dblMaxScore As Double
        If intBtnCounter = intNumOfPrograms Then

            progReset()
        End If
        progResetNumbers()
        chkBoxReasoning()
        ScoreCalc()
        perfectScore()
        negScoreCheck()
        maxScoreInit(dblMaxScore)

        Try
            dblProgScoresArray(intBtnCounter) = dblScore
        Catch ex As IndexOutOfRangeException
            MessageBox.Show("Error. Reset the program to prevent crashing!")
        End Try

        If intBtnCounter = (intNumOfPrograms - 1) Then
            txtComments.Text &= "Your total for all programs is " & totalScoreCalc() & " out of " & (intNumOfPrograms * dblMaxScore) & vbCrLf
            CopyText()
        End If
        intBtnCounter += 1


    End Sub
    ' Post: Text with scores and teacher comments is displayed in the textbox and copied onto the clipboard 

    Private Function negScoreCheck() As Double
        If dblScore < 0 Then
            Return 0.0
        End If
        Return dblScore
    End Function

    Private Sub progReset()
        txtComments.Text = "" ' Clear the textbox between runs
        progResetNumbers()
        frmPenalty.cboPenalty.Text = ""
        ReDim dblProgScoresArray(intNumOfPrograms)
        intBtnCounter = 0
    End Sub
    Private Sub progResetNumbers()
        ' resets only the numbers for everything
        dblExtraCred = 0
        intDeductions = 0
        dblScore = 25.0


    End Sub

    Private Sub maxScoreInit(ByRef dblMax As Double)
        If (currentCourse = Course.Prog1 Or currentCourse = Course.Prog2) Then
            dblMax = 25
            'Display:
            txtComments.Text &= "Your score for program " & (intBtnCounter + 1) &
                " is: " & dblScore & " out of " & dblMax & vbCrLf & vbCrLf

        ElseIf (currentCourse = Course.AP) Then
            dblMax = 5
            dblScore /= 5
            txtComments.Text &= "Your score for program " & (intBtnCounter + 1) &
               " is: " & dblScore & " out of " & dblMax & vbCrLf & vbCrLf

        End If
    End Sub
    Private Sub ScoreCalc()
        dblScore = dblScore - intDeductions + dblExtraCred
    End Sub
    Private Function perfectScore() As Boolean ' Returns true or false
        Dim rand As New System.Random
        Dim intRand As Integer = rand.Next(0, 18)
        If dblScore >= 25.0 Then
            Select Case intRand
                Case 0
                    txtComments.Text &= "Good Job! "
                Case 1
                    txtComments.Text &= "Good HEC! "
                Case 2
                    txtComments.Text &= "Way to go. "
                Case 3
                    txtComments.Text &= "Excellent. "
                Case 4
                    txtComments.Text &= "There is a good job in your future. "
                Case 5
                    txtComments.Text &= "Who could have done it better? "
                Case 6
                    txtComments.Text &= "Byron would be pleased. "
                Case 7
                    txtComments.Text &= "Mathmatical! "
                Case 8
                    txtComments.Text &= "Brilliant! "
                Case 9
                    txtComments.Text &= "Bravo! "
                Case 10
                    txtComments.Text &= "Amazing! "
                Case 11
                    txtComments.Text &= "Marvelous! "
                Case 12
                    txtComments.Text &= "This is exceptional work! "
                Case 13
                    txtComments.Text &= "Splendid! "
                Case 14
                    txtComments.Text &= "Well Done! "
                Case 15
                    txtComments.Text &= "Impressive. "
                Case 16
                    txtComments.Text &= "Eloquent. "
                Case 17
                    txtComments.Text &= "Creative. "
                Case 18
                    txtComments.Text &= "You've done well. "
                Case Else
                    txtComments.Text &= "Great work! "
            End Select
            Return True
        End If
        Return False
    End Function

    'Pre: All the checkboxes for a student's project is selected. 
    Private Sub chkBoxReasoning()
        ' These bunch of ifs look ugly but I can't afford to bypase any of these in a selectCase or ElseIf ladder
        If chkOnTime.Checked = False Then
            frmLate.ShowDialog()
        End If
        If chkAllFiles.Checked = False Then
            dblScore = 0
            intDeductions = 0
            frmMissing.ShowDialog()
            'txtComments.Text &= "Not all files are present, Code/Designer window .vb files may be missing, " &
            '  " or program is incomplete."
            'Return False
        End If

        If chkHonor.Checked = False Then
            intDeductions += 6
            'Return False
            txtComments.Text &= "You submitted code without the block comment a the top. You lost " & intDeductions & " because of it. "
        End If


        If chkOption.Checked = False Then
            intDeductions += 2
            txtComments.Text &= "Option Strict was turned off. "
        End If
        If chkComments.Checked = False Then
            intDeductions += 2
            txtComments.Text &= "There are no comments found in the body of your code. "
        End If
        If (chkHung.Checked) = False Then
            intDeductions += 3
            If (currentCourse = Course.AP Or currentCourse = Course.Prog2) Then
                frmNotation.ShowDialog()
                txtComments.Text &= frmNotation.Result & ". "

            Else
                txtComments.Text &= "You are missing the hungarian notation for your control(s)."
            End If
        End If

        If chkCompile.Checked = False Then
            intDeductions += 10
            txtComments.Text &= "Your code does not compile due to syntax errors. Come see me. "
        End If
        If chkInstructions.Checked = False Then
            frmPenalty.ShowDialog()
        End If
        If chkIdealCase.Checked = False Then
            intDeductions += 5
            txtComments.Text &= "Your code does not work as expected. "
        End If
        If chkDecimal.Checked = False Or chkNegative.Checked = False Then
            intDeductions += 2
            txtComments.Text &= "You did not prevent negative or decimal input. "
        End If
        If (chkTry.Checked = False) Then
            intDeductions += 2
            txtComments.Text &= "You did not use a Try ... Catch ... or a Try Parse to validate input. "
        End If
    End Sub
    ' Post: deduction points have increased
    ' Comments are listed in the textbox 

    Public Sub CopyText()
        ' Select all text in the text box.
        txtComments.SelectAll()
        ' Copy the contents of the control to the Clipboard.
        txtComments.Copy()
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        txtComments.Focus() ' Moves the cursor to the txtbox
        CopyText()
    End Sub

    Private Sub mnuSelectAll_Click(sender As Object, e As EventArgs) Handles mnuSelectAll.Click
        txtComments.Focus()
        txtComments.SelectAll()
    End Sub


    Private Sub mnuNumOfProg_Click(sender As Object, e As EventArgs) Handles mnuNumOfProg.Click
        If Int16.TryParse(InputBox("Enter How many Progams"), intNumOfPrograms) = False Then
            MessageBox.Show("You did not enter a valid integer.")
        Else
            lblStatus.Text = "Number of programs: " & intNumOfPrograms
            ReDim dblProgScoresArray(intNumOfPrograms)
        End If
    End Sub

    Private Sub mnuReset_Click(sender As Object, e As EventArgs) Handles mnuReset.Click
        progReset()
    End Sub

    Private Sub numProgChecker() ' Unfinished
        ' Not finished sub is supposed to be able to count the number of times the button has been clicked
        ' if it has exceeded that then give an error message before it spits out more txtBox text
        Static intBtnCounter As Integer = 1
        If intBtnCounter > intNumOfPrograms And MsgBox("You have exceeded the Number of Programs are you sure you want to continue?",
                   MsgBoxStyle.YesNo) = DialogResult.No Then
            intBtnCounter -= 1
            'GoTo Display
            ' Bad shortcut ^ for logic on how to get the btnCounter to work 
        End If

    End Sub
    ' Total scores 
    Private Function totalScoreCalc()
        Dim dblTotal As Double
        For Each Score In dblProgScoresArray
            dblTotal += Score
        Next
        Return dblTotal
    End Function


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentCourse = Course.Prog1
        If MessageBox.Show("Would you like to set the Number of Programs?",
                           "Number of Programs", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                intNumOfPrograms = CInt(InputBox("Enter the number of programs"))
                ReDim dblProgScoresArray(intNumOfPrograms)
                lblStatus.Text = "The number of programs: " & intNumOfPrograms
            Catch ex As Exception
                MessageBox.Show("You did not enter a number. Set it in the menu")
            End Try
        End If
    End Sub


    Private Sub mnuCourse_Click(sender As Object, e As EventArgs) Handles mnuCourse.Click
        'Not implemented yet.
    End Sub

    'PRE: Checkboxes 
    Private Sub btnPerfect_Click(sender As Object, e As EventArgs) Handles btnPerfect.Click
        chkComments.Checked = True
        chkAllFiles.Checked = True
        chkCompile.Checked = True
        chkDecimal.Checked = True
        chkOnTime.Checked = True
        chkHonor.Checked = True
        chkHung.Checked = True
        chkIdealCase.Checked = True
        chkInstructions.Checked = True
        chkNegative.Checked = True
        chkOnTime.Checked = True
        chkOption.Checked = True
        chkTry.Checked = True
    End Sub

    Private Sub ProgrammingIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammingIToolStripMenuItem.Click
        currentCourse = Course.Prog1
    End Sub

    Private Sub APCompSciAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles APCompSciAToolStripMenuItem.Click
        currentCourse = Course.AP
        chkHung.Text = "Proper Notation?" 'No hungarian notation for each course
        progReset()
    End Sub

    Private Sub ProgrammingIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammingIIToolStripMenuItem.Click
        currentCourse = Course.Prog2
        chkHung.Text = "Proper Notation?"
        progReset()
    End Sub

End Class
