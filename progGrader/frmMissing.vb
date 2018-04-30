' Purpose: Seperate window for students that submit incomplete/inaccessible files
' Ochaun Marshall
' Date Created: 1/23/18
' Date Modified: 1/24/18

'ToDo: 

'   Create a button click event that checks which radio button is selected (Select Case)
'       Change the text for the txtBox in frmMain
'       Change the dblscore if needed 

Public Class frmMissing
    '   Missing files has one of the following categories - (Seperate form for this with radiobuttons)
    '       The student ...
    '       Renamed the project file to something that won't compile 
    '       Submitted a shortcut file instead of the actual directory
    '       Submitted solution file without code
    '       Submitted code without submission file or directories
    '       Failed to submit one or more of the required programs
    '       Some other reason 

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmMain.txtComments.Text &= "You recived a score of " & frmMain.getScore & " because "
        Select Case True
            Case radRenamed.Checked
                frmMain.txtComments.Text &= "you changed the name of the project file to something that is too long. " &
                    "Do not put spaces in your program names. "
            Case radShortcut.Checked
                frmMain.txtComments.Text &= "you accidently submitted a shortcut file instead of the root directory. "
            Case radSolution.Checked
                frmMain.txtComments.Text &= "you only submitted the solution file. You need to resubmit with all the files present. "
            Case radCodeOnly.Checked
                frmMain.txtComments.Text &= "you submitted the .vb files only. You need to resubmit with all the files present. "
            Case radPrograms.Checked
                frmMain.txtComments.Text &= "you are missing  one or more of the required programs. "
            Case radOther.Checked
                frmMain.txtComments.Text &= InputBox("For what reason are they missing something?", "Other Missing Window")
            Case Else
                MsgBox("Error. Select an option before hitting enter!")
        End Select
        Me.Close()
    End Sub
End Class