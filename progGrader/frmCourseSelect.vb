
Public Class frmCourseSelect


    Dim courseSetter As frmMain.Course
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        If (radAP.Checked) Then
            courseSetter = frmMain.Course.AP
            frmMain.setCourse(courseSetter)
        ElseIf (radProg1.Checked) Then
            courseSetter = frmMain.Course.Prog1
            frmMain.setCourse(courseSetter)

        ElseIf (radProg2.Checked) Then
            courseSetter = frmMain.Course.Prog2
            frmMain.setCourse(courseSetter)
        Else
            MessageBox.Show("Error! Please select an option")
        End If
    End Sub


    Private Sub frmCourseSelect_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        btnEnter_Click(sender, e)
    End Sub
End Class