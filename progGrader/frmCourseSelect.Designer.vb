<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCourses = New System.Windows.Forms.GroupBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.radProg2 = New System.Windows.Forms.RadioButton()
        Me.radAP = New System.Windows.Forms.RadioButton()
        Me.radProg1 = New System.Windows.Forms.RadioButton()
        Me.grpCourses.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCourses
        '
        Me.grpCourses.Controls.Add(Me.radProg2)
        Me.grpCourses.Controls.Add(Me.radAP)
        Me.grpCourses.Controls.Add(Me.radProg1)
        Me.grpCourses.Location = New System.Drawing.Point(22, 29)
        Me.grpCourses.Name = "grpCourses"
        Me.grpCourses.Size = New System.Drawing.Size(353, 73)
        Me.grpCourses.TabIndex = 1
        Me.grpCourses.TabStop = False
        Me.grpCourses.Text = "Select the course you are grading for"
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(352, 108)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 3
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'radProg2
        '
        Me.radProg2.AutoSize = True
        Me.radProg2.Location = New System.Drawing.Point(257, 31)
        Me.radProg2.Name = "radProg2"
        Me.radProg2.Size = New System.Drawing.Size(95, 17)
        Me.radProg2.TabIndex = 2
        Me.radProg2.TabStop = True
        Me.radProg2.Text = "Programming II"
        Me.radProg2.UseVisualStyleBackColor = True
        '
        'radAP
        '
        Me.radAP.AutoSize = True
        Me.radAP.Location = New System.Drawing.Point(134, 31)
        Me.radAP.Name = "radAP"
        Me.radAP.Size = New System.Drawing.Size(111, 17)
        Me.radAP.TabIndex = 1
        Me.radAP.TabStop = True
        Me.radAP.Text = "AP Comp Science"
        Me.radAP.UseVisualStyleBackColor = True
        '
        'radProg1
        '
        Me.radProg1.AutoSize = True
        Me.radProg1.Location = New System.Drawing.Point(6, 31)
        Me.radProg1.Name = "radProg1"
        Me.radProg1.Size = New System.Drawing.Size(92, 17)
        Me.radProg1.TabIndex = 0
        Me.radProg1.TabStop = True
        Me.radProg1.Text = "Programming I"
        Me.radProg1.UseVisualStyleBackColor = True
        '
        'frmCourseSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 141)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.grpCourses)
        Me.Name = "frmCourseSelect"
        Me.Text = "frmCourseSelect"
        Me.grpCourses.ResumeLayout(False)
        Me.grpCourses.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCourses As System.Windows.Forms.GroupBox
    Friend WithEvents radProg1 As System.Windows.Forms.RadioButton
    Friend WithEvents radProg2 As System.Windows.Forms.RadioButton
    Friend WithEvents radAP As System.Windows.Forms.RadioButton
    Friend WithEvents btnEnter As System.Windows.Forms.Button
End Class
