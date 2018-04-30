Public Class frmNotation
    Property Result As String ' Custom Property for form output
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Select Case True
            Case radCamel.Checked
                Result &= "You forgot Camel Casing for one or more of your instance varibles/objects/fields"
            Case radInterface.Checked
                Result &= "You forgot to put an i for one or more of your interfaces"
            Case radStatic.Checked
                Result &= "You forgot to put an _ for one or more of your static varibles"
            Case radOther.Checked
                Result &= InputBox("Enter in what the student got wrong. Don't worry about punctuation")
            Case Else
        End Select
        Close()
    End Sub
End Class