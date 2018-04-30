' Purpose: A seprate dialog box for suggesting how late something is
' Ochaun Marshall
' Date created: 1/17/18
' Date modified: 4/25/18
Public Class frmLate

    Private Sub frmLate_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ' After everything is done set the score to the penalty value 
        Dim strDays As String
        If frmMain.getCourse = frmMain.Course.AP Then
            Select Case True
                Case radDay1.Checked
                    frmMain.changeScore(18.75)
                    strDays = "1"
                Case radDay2.Checked
                    frmMain.changeScore(12.5)
                    strDays = "2"
                Case radDay3.Checked
                    strDays = "3"
                    frmMain.changeScore(6.25)
                Case radDay4.Checked
                    strDays = "4 or more"
                    frmMain.changeScore(0)

            End Select

        Else
            Select Case True
                Case radDay1.Checked
                    frmMain.changeScore(20)
                    strDays = "1"
                Case radDay2.Checked
                    frmMain.changeScore(15)
                    strDays = "2"
                Case radDay3.Checked
                    strDays = "3"
                    frmMain.changeScore(10)
                Case radDay4.Checked
                    strDays = "4 or more"
                    frmMain.changeScore(5)

            End Select
        End If

        frmMain.txtComments.Text &= "Your assignment is late by " & strDays & " School Day(s). "
    End Sub

    Private Sub frmLate_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (radDay1.Checked Or radDay2.Checked Or radDay3.Checked Or radDay4.Checked) = False Then
            'If the user forgets to check a radio button prevent the code from exiting
            If MessageBox.Show("Are you sure you want to quit? You forgot to select a button", "Late exit window",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class