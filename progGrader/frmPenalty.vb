'Purpose: To automate the caluclations for student scores on projects
' Ochaun Marshall
' Date Created: 1/17/2018
' Last Modified: 1/17/2018
Public Class frmPenalty
    Private dblPenalty As Double

    Private Sub clearPenalty()
        dblPenalty = 0.0
    End Sub
    Public Function getPenalty() As Double
        Return dblPenalty
    End Function
    Private Sub cboPenalty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPenalty.SelectedIndexChanged
        If Double.TryParse(cboPenalty.Text, dblPenalty) = False Then
            MessageBox.Show("Error: Data is not a valid number!") ' Sets the penalty for deductions
        End If
    End Sub

    Private Sub cboPenalty_TextChanged(sender As Object, e As EventArgs) Handles cboPenalty.TextChanged
        If Me.Visible = True And Double.TryParse(cboPenalty.Text, dblPenalty) = False Then
            MessageBox.Show("Error: Data is not a valid number!") ' Sets the penalty for deductions
        End If
    End Sub

    Private Sub frmPenalty_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.addDeductions(CInt(Math.Round(Me.getPenalty)))
        frmMain.txtComments.Text &= "You lost " & CInt(Math.Round(Me.getPenalty)) &
            " pts because " & InputBox("Provide the reason for the deduction") & ". "
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class