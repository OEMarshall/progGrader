<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMissing
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
        Me.grpMissing = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.radRenamed = New System.Windows.Forms.RadioButton()
        Me.radShortcut = New System.Windows.Forms.RadioButton()
        Me.radSolution = New System.Windows.Forms.RadioButton()
        Me.radCodeOnly = New System.Windows.Forms.RadioButton()
        Me.radPrograms = New System.Windows.Forms.RadioButton()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.grpMissing.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMissing
        '
        Me.grpMissing.Controls.Add(Me.radOther)
        Me.grpMissing.Controls.Add(Me.radPrograms)
        Me.grpMissing.Controls.Add(Me.radCodeOnly)
        Me.grpMissing.Controls.Add(Me.radSolution)
        Me.grpMissing.Controls.Add(Me.radShortcut)
        Me.grpMissing.Controls.Add(Me.radRenamed)
        Me.grpMissing.Location = New System.Drawing.Point(12, 12)
        Me.grpMissing.Name = "grpMissing"
        Me.grpMissing.Size = New System.Drawing.Size(198, 158)
        Me.grpMissing.TabIndex = 0
        Me.grpMissing.TabStop = False
        Me.grpMissing.Text = "Missing Files Reason"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(74, 206)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Enter"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'radRenamed
        '
        Me.radRenamed.AutoSize = True
        Me.radRenamed.Location = New System.Drawing.Point(6, 22)
        Me.radRenamed.Name = "radRenamed"
        Me.radRenamed.Size = New System.Drawing.Size(187, 17)
        Me.radRenamed.TabIndex = 1
        Me.radRenamed.TabStop = True
        Me.radRenamed.Text = "Renamed the Project/Solution File"
        Me.radRenamed.UseVisualStyleBackColor = True
        '
        'radShortcut
        '
        Me.radShortcut.AutoSize = True
        Me.radShortcut.Location = New System.Drawing.Point(6, 45)
        Me.radShortcut.Name = "radShortcut"
        Me.radShortcut.Size = New System.Drawing.Size(143, 17)
        Me.radShortcut.TabIndex = 2
        Me.radShortcut.TabStop = True
        Me.radShortcut.Text = "Submitted a Shortcut File"
        Me.radShortcut.UseVisualStyleBackColor = True
        '
        'radSolution
        '
        Me.radSolution.AutoSize = True
        Me.radSolution.Location = New System.Drawing.Point(6, 68)
        Me.radSolution.Name = "radSolution"
        Me.radSolution.Size = New System.Drawing.Size(149, 17)
        Me.radSolution.TabIndex = 3
        Me.radSolution.TabStop = True
        Me.radSolution.Text = "Only submitted solution file"
        Me.radSolution.UseVisualStyleBackColor = True
        '
        'radCodeOnly
        '
        Me.radCodeOnly.AutoSize = True
        Me.radCodeOnly.Location = New System.Drawing.Point(6, 90)
        Me.radCodeOnly.Name = "radCodeOnly"
        Me.radCodeOnly.Size = New System.Drawing.Size(119, 17)
        Me.radCodeOnly.TabIndex = 4
        Me.radCodeOnly.TabStop = True
        Me.radCodeOnly.Text = "Only submited Code"
        Me.radCodeOnly.UseVisualStyleBackColor = True
        '
        'radPrograms
        '
        Me.radPrograms.AutoSize = True
        Me.radPrograms.Location = New System.Drawing.Point(6, 113)
        Me.radPrograms.Name = "radPrograms"
        Me.radPrograms.Size = New System.Drawing.Size(148, 17)
        Me.radPrograms.TabIndex = 5
        Me.radPrograms.TabStop = True
        Me.radPrograms.Text = "Required Program Missing"
        Me.radPrograms.UseVisualStyleBackColor = True
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(6, 135)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(51, 17)
        Me.radOther.TabIndex = 6
        Me.radOther.TabStop = True
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'frmMissing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 241)
        Me.Controls.Add(Me.grpMissing)
        Me.Controls.Add(Me.btnExit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMissing"
        Me.Text = "frmMissing"
        Me.grpMissing.ResumeLayout(False)
        Me.grpMissing.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMissing As System.Windows.Forms.GroupBox
    Friend WithEvents radCodeOnly As System.Windows.Forms.RadioButton
    Friend WithEvents radSolution As System.Windows.Forms.RadioButton
    Friend WithEvents radShortcut As System.Windows.Forms.RadioButton
    Friend WithEvents radRenamed As System.Windows.Forms.RadioButton
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents radPrograms As System.Windows.Forms.RadioButton
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
End Class
