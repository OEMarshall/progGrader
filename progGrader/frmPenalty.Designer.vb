<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenalty
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
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.cboPenalty = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Location = New System.Drawing.Point(12, 9)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(84, 13)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Assign a penalty"
        '
        'cboPenalty
        '
        Me.cboPenalty.FormattingEnabled = True
        Me.cboPenalty.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboPenalty.Location = New System.Drawing.Point(102, 9)
        Me.cboPenalty.Name = "cboPenalty"
        Me.cboPenalty.Size = New System.Drawing.Size(170, 21)
        Me.cboPenalty.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 36)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Enter"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmPenalty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 60)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.cboPenalty)
        Me.Controls.Add(Me.lblPrompt)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPenalty"
        Me.Text = "Penalty Window"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPrompt As System.Windows.Forms.Label
    Friend WithEvents cboPenalty As System.Windows.Forms.ComboBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
