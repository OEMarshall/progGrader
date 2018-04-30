<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotation
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
        Me.grpNotation = New System.Windows.Forms.GroupBox()
        Me.radPascal = New System.Windows.Forms.RadioButton()
        Me.radCamel = New System.Windows.Forms.RadioButton()
        Me.radInterface = New System.Windows.Forms.RadioButton()
        Me.radStatic = New System.Windows.Forms.RadioButton()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpNotation.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpNotation
        '
        Me.grpNotation.Controls.Add(Me.radOther)
        Me.grpNotation.Controls.Add(Me.radStatic)
        Me.grpNotation.Controls.Add(Me.radInterface)
        Me.grpNotation.Controls.Add(Me.radCamel)
        Me.grpNotation.Controls.Add(Me.radPascal)
        Me.grpNotation.Location = New System.Drawing.Point(12, 23)
        Me.grpNotation.Name = "grpNotation"
        Me.grpNotation.Size = New System.Drawing.Size(200, 142)
        Me.grpNotation.TabIndex = 0
        Me.grpNotation.TabStop = False
        Me.grpNotation.Text = "Errors in Notation"
        '
        'radPascal
        '
        Me.radPascal.AutoSize = True
        Me.radPascal.Checked = True
        Me.radPascal.Location = New System.Drawing.Point(3, 16)
        Me.radPascal.Name = "radPascal"
        Me.radPascal.Size = New System.Drawing.Size(117, 17)
        Me.radPascal.TabIndex = 0
        Me.radPascal.TabStop = True
        Me.radPascal.Text = "Forgot Pascal Case"
        Me.radPascal.UseVisualStyleBackColor = True
        '
        'radCamel
        '
        Me.radCamel.AutoSize = True
        Me.radCamel.Location = New System.Drawing.Point(3, 39)
        Me.radCamel.Name = "radCamel"
        Me.radCamel.Size = New System.Drawing.Size(122, 17)
        Me.radCamel.TabIndex = 1
        Me.radCamel.Text = "Forgot Camel Casing"
        Me.radCamel.UseVisualStyleBackColor = True
        '
        'radInterface
        '
        Me.radInterface.AutoSize = True
        Me.radInterface.Location = New System.Drawing.Point(3, 62)
        Me.radInterface.Name = "radInterface"
        Me.radInterface.Size = New System.Drawing.Size(120, 17)
        Me.radInterface.TabIndex = 2
        Me.radInterface.Text = "Forgot I for interface"
        Me.radInterface.UseVisualStyleBackColor = True
        '
        'radStatic
        '
        Me.radStatic.AutoSize = True
        Me.radStatic.Location = New System.Drawing.Point(3, 85)
        Me.radStatic.Name = "radStatic"
        Me.radStatic.Size = New System.Drawing.Size(150, 17)
        Me.radStatic.TabIndex = 3
        Me.radStatic.Text = "Forgot _ for static methods"
        Me.radStatic.UseVisualStyleBackColor = True
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(3, 108)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(51, 17)
        Me.radOther.TabIndex = 4
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(98, 171)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Select"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmNotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grpNotation)
        Me.Name = "frmNotation"
        Me.Text = "frmNotation"
        Me.grpNotation.ResumeLayout(False)
        Me.grpNotation.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpNotation As System.Windows.Forms.GroupBox
    Friend WithEvents radStatic As System.Windows.Forms.RadioButton
    Friend WithEvents radInterface As System.Windows.Forms.RadioButton
    Friend WithEvents radCamel As System.Windows.Forms.RadioButton
    Friend WithEvents radPascal As System.Windows.Forms.RadioButton
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
