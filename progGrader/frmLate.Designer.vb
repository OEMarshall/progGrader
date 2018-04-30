<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLate
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
        Me.grpLate = New System.Windows.Forms.GroupBox()
        Me.radDay4 = New System.Windows.Forms.RadioButton()
        Me.radDay3 = New System.Windows.Forms.RadioButton()
        Me.radDay2 = New System.Windows.Forms.RadioButton()
        Me.radDay1 = New System.Windows.Forms.RadioButton()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpLate.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpLate
        '
        Me.grpLate.Controls.Add(Me.radDay4)
        Me.grpLate.Controls.Add(Me.radDay3)
        Me.grpLate.Controls.Add(Me.radDay2)
        Me.grpLate.Controls.Add(Me.radDay1)
        Me.grpLate.Location = New System.Drawing.Point(12, 12)
        Me.grpLate.Name = "grpLate"
        Me.grpLate.Size = New System.Drawing.Size(103, 125)
        Me.grpLate.TabIndex = 1
        Me.grpLate.TabStop = False
        Me.grpLate.Text = "How late is it?"
        '
        'radDay4
        '
        Me.radDay4.AutoSize = True
        Me.radDay4.Location = New System.Drawing.Point(15, 94)
        Me.radDay4.Name = "radDay4"
        Me.radDay4.Size = New System.Drawing.Size(58, 17)
        Me.radDay4.TabIndex = 3
        Me.radDay4.Text = "4 Days"
        Me.radDay4.UseVisualStyleBackColor = True
        '
        'radDay3
        '
        Me.radDay3.AutoSize = True
        Me.radDay3.Location = New System.Drawing.Point(15, 71)
        Me.radDay3.Name = "radDay3"
        Me.radDay3.Size = New System.Drawing.Size(58, 17)
        Me.radDay3.TabIndex = 2
        Me.radDay3.Text = "3 Days"
        Me.radDay3.UseVisualStyleBackColor = True
        '
        'radDay2
        '
        Me.radDay2.AutoSize = True
        Me.radDay2.Location = New System.Drawing.Point(15, 48)
        Me.radDay2.Name = "radDay2"
        Me.radDay2.Size = New System.Drawing.Size(58, 17)
        Me.radDay2.TabIndex = 1
        Me.radDay2.Text = "2 Days"
        Me.radDay2.UseVisualStyleBackColor = True
        '
        'radDay1
        '
        Me.radDay1.AutoSize = True
        Me.radDay1.Checked = True
        Me.radDay1.Location = New System.Drawing.Point(15, 25)
        Me.radDay1.Name = "radDay1"
        Me.radDay1.Size = New System.Drawing.Size(53, 17)
        Me.radDay1.TabIndex = 0
        Me.radDay1.TabStop = True
        Me.radDay1.Text = "1 Day"
        Me.radDay1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(135, 60)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Enter"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 181)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpLate)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLate"
        Me.Text = "Late Window"
        Me.TopMost = True
        Me.grpLate.ResumeLayout(False)
        Me.grpLate.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpLate As System.Windows.Forms.GroupBox
    Friend WithEvents radDay4 As System.Windows.Forms.RadioButton
    Friend WithEvents radDay3 As System.Windows.Forms.RadioButton
    Friend WithEvents radDay2 As System.Windows.Forms.RadioButton
    Friend WithEvents radDay1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
