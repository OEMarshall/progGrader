<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpStep1 = New System.Windows.Forms.GroupBox()
        Me.chkOnTime = New System.Windows.Forms.CheckBox()
        Me.chkAllFiles = New System.Windows.Forms.CheckBox()
        Me.chkHonor = New System.Windows.Forms.CheckBox()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.grpStep2 = New System.Windows.Forms.GroupBox()
        Me.chkHung = New System.Windows.Forms.CheckBox()
        Me.chkComments = New System.Windows.Forms.CheckBox()
        Me.chkOption = New System.Windows.Forms.CheckBox()
        Me.grpStep3 = New System.Windows.Forms.GroupBox()
        Me.chkInstructions = New System.Windows.Forms.CheckBox()
        Me.chkCompile = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTry = New System.Windows.Forms.CheckBox()
        Me.chkDecimal = New System.Windows.Forms.CheckBox()
        Me.chkNegative = New System.Windows.Forms.CheckBox()
        Me.chkIdealCase = New System.Windows.Forms.CheckBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.mnuStripMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSelectAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReset = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNumOfProg = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCourse = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammingIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APCompSciAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammingIIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.btnPerfect = New System.Windows.Forms.Button()
        Me.btnMissing = New System.Windows.Forms.Button()
        Me.chkAPScale = New System.Windows.Forms.CheckBox()
        Me.grpStep1.SuspendLayout()
        Me.grpStep2.SuspendLayout()
        Me.grpStep3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.mnuStripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStep1
        '
        Me.grpStep1.Controls.Add(Me.chkOnTime)
        Me.grpStep1.Controls.Add(Me.chkAllFiles)
        Me.grpStep1.Controls.Add(Me.chkHonor)
        Me.grpStep1.Location = New System.Drawing.Point(12, 27)
        Me.grpStep1.Name = "grpStep1"
        Me.grpStep1.Size = New System.Drawing.Size(95, 105)
        Me.grpStep1.TabIndex = 0
        Me.grpStep1.TabStop = False
        Me.grpStep1.Text = "Step 1"
        '
        'chkOnTime
        '
        Me.chkOnTime.AutoSize = True
        Me.chkOnTime.Location = New System.Drawing.Point(3, 76)
        Me.chkOnTime.Name = "chkOnTime"
        Me.chkOnTime.Size = New System.Drawing.Size(68, 17)
        Me.chkOnTime.TabIndex = 3
        Me.chkOnTime.Text = "On time?"
        Me.chkOnTime.UseVisualStyleBackColor = True
        '
        'chkAllFiles
        '
        Me.chkAllFiles.AutoSize = True
        Me.chkAllFiles.Location = New System.Drawing.Point(3, 53)
        Me.chkAllFiles.Name = "chkAllFiles"
        Me.chkAllFiles.Size = New System.Drawing.Size(94, 17)
        Me.chkAllFiles.TabIndex = 2
        Me.chkAllFiles.Text = "All files/folders"
        Me.chkAllFiles.UseVisualStyleBackColor = True
        '
        'chkHonor
        '
        Me.chkHonor.AutoSize = True
        Me.chkHonor.Location = New System.Drawing.Point(3, 30)
        Me.chkHonor.Name = "chkHonor"
        Me.chkHonor.Size = New System.Drawing.Size(83, 17)
        Me.chkHonor.TabIndex = 1
        Me.chkHonor.Text = "Honor Code"
        Me.chkHonor.UseVisualStyleBackColor = True
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(12, 339)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(260, 23)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'grpStep2
        '
        Me.grpStep2.Controls.Add(Me.chkHung)
        Me.grpStep2.Controls.Add(Me.chkComments)
        Me.grpStep2.Controls.Add(Me.chkOption)
        Me.grpStep2.Location = New System.Drawing.Point(115, 27)
        Me.grpStep2.Name = "grpStep2"
        Me.grpStep2.Size = New System.Drawing.Size(160, 105)
        Me.grpStep2.TabIndex = 5
        Me.grpStep2.TabStop = False
        Me.grpStep2.Text = "Step 2"
        '
        'chkHung
        '
        Me.chkHung.AutoSize = True
        Me.chkHung.Location = New System.Drawing.Point(6, 62)
        Me.chkHung.Name = "chkHung"
        Me.chkHung.Size = New System.Drawing.Size(124, 17)
        Me.chkHung.TabIndex = 3
        Me.chkHung.Text = "Hungarian Notation?"
        Me.chkHung.UseVisualStyleBackColor = True
        '
        'chkComments
        '
        Me.chkComments.AutoSize = True
        Me.chkComments.Location = New System.Drawing.Point(6, 39)
        Me.chkComments.Name = "chkComments"
        Me.chkComments.Size = New System.Drawing.Size(81, 17)
        Me.chkComments.TabIndex = 2
        Me.chkComments.Text = "Comments?"
        Me.chkComments.UseVisualStyleBackColor = True
        '
        'chkOption
        '
        Me.chkOption.AutoSize = True
        Me.chkOption.Location = New System.Drawing.Point(6, 16)
        Me.chkOption.Name = "chkOption"
        Me.chkOption.Size = New System.Drawing.Size(103, 17)
        Me.chkOption.TabIndex = 0
        Me.chkOption.Text = "Option strict on?"
        Me.chkOption.UseVisualStyleBackColor = True
        '
        'grpStep3
        '
        Me.grpStep3.Controls.Add(Me.chkInstructions)
        Me.grpStep3.Controls.Add(Me.chkCompile)
        Me.grpStep3.Location = New System.Drawing.Point(12, 135)
        Me.grpStep3.Name = "grpStep3"
        Me.grpStep3.Size = New System.Drawing.Size(145, 70)
        Me.grpStep3.TabIndex = 6
        Me.grpStep3.TabStop = False
        Me.grpStep3.Text = "Step 3"
        '
        'chkInstructions
        '
        Me.chkInstructions.AutoSize = True
        Me.chkInstructions.Location = New System.Drawing.Point(3, 39)
        Me.chkInstructions.Name = "chkInstructions"
        Me.chkInstructions.Size = New System.Drawing.Size(118, 17)
        Me.chkInstructions.TabIndex = 1
        Me.chkInstructions.Text = "Follow instructions?"
        Me.chkInstructions.UseVisualStyleBackColor = True
        '
        'chkCompile
        '
        Me.chkCompile.AutoSize = True
        Me.chkCompile.Location = New System.Drawing.Point(3, 16)
        Me.chkCompile.Name = "chkCompile"
        Me.chkCompile.Size = New System.Drawing.Size(69, 17)
        Me.chkCompile.TabIndex = 0
        Me.chkCompile.Text = "Compile?"
        Me.chkCompile.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTry)
        Me.GroupBox1.Controls.Add(Me.chkDecimal)
        Me.GroupBox1.Controls.Add(Me.chkNegative)
        Me.GroupBox1.Controls.Add(Me.chkIdealCase)
        Me.GroupBox1.Location = New System.Drawing.Point(163, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(110, 124)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 4 "
        '
        'chkTry
        '
        Me.chkTry.AutoSize = True
        Me.chkTry.Location = New System.Drawing.Point(6, 85)
        Me.chkTry.Name = "chkTry"
        Me.chkTry.Size = New System.Drawing.Size(74, 30)
        Me.chkTry.TabIndex = 3
        Me.chkTry.Text = "TryCatch/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TryParse"
        Me.chkTry.UseVisualStyleBackColor = True
        '
        'chkDecimal
        '
        Me.chkDecimal.AutoSize = True
        Me.chkDecimal.Location = New System.Drawing.Point(6, 62)
        Me.chkDecimal.Name = "chkDecimal"
        Me.chkDecimal.Size = New System.Drawing.Size(64, 17)
        Me.chkDecimal.TabIndex = 2
        Me.chkDecimal.Text = "Decimal"
        Me.chkDecimal.UseVisualStyleBackColor = True
        '
        'chkNegative
        '
        Me.chkNegative.AutoSize = True
        Me.chkNegative.Location = New System.Drawing.Point(6, 39)
        Me.chkNegative.Name = "chkNegative"
        Me.chkNegative.Size = New System.Drawing.Size(69, 17)
        Me.chkNegative.TabIndex = 1
        Me.chkNegative.Text = "Negative"
        Me.chkNegative.UseVisualStyleBackColor = True
        '
        'chkIdealCase
        '
        Me.chkIdealCase.AutoSize = True
        Me.chkIdealCase.Location = New System.Drawing.Point(6, 16)
        Me.chkIdealCase.Name = "chkIdealCase"
        Me.chkIdealCase.Size = New System.Drawing.Size(76, 17)
        Me.chkIdealCase.TabIndex = 0
        Me.chkIdealCase.Text = "Ideal Case"
        Me.chkIdealCase.UseVisualStyleBackColor = True
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(12, 213)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(145, 100)
        Me.txtComments.TabIndex = 8
        '
        'mnuStripMain
        '
        Me.mnuStripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSettings})
        Me.mnuStripMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuStripMain.Name = "mnuStripMain"
        Me.mnuStripMain.Size = New System.Drawing.Size(284, 24)
        Me.mnuStripMain.TabIndex = 9
        Me.mnuStripMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSelectAll, Me.mnuCopy, Me.mnuReset})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuSelectAll
        '
        Me.mnuSelectAll.Name = "mnuSelectAll"
        Me.mnuSelectAll.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.mnuSelectAll.Size = New System.Drawing.Size(185, 22)
        Me.mnuSelectAll.Text = "Select All"
        '
        'mnuCopy
        '
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCopy.Size = New System.Drawing.Size(185, 22)
        Me.mnuCopy.Text = "Copy"
        '
        'mnuReset
        '
        Me.mnuReset.Name = "mnuReset"
        Me.mnuReset.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuReset.Size = New System.Drawing.Size(185, 22)
        Me.mnuReset.Text = "New Student"
        '
        'mnuSettings
        '
        Me.mnuSettings.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNumOfProg, Me.mnuCourse})
        Me.mnuSettings.Name = "mnuSettings"
        Me.mnuSettings.Size = New System.Drawing.Size(61, 20)
        Me.mnuSettings.Text = "Settings"
        '
        'mnuNumOfProg
        '
        Me.mnuNumOfProg.Name = "mnuNumOfProg"
        Me.mnuNumOfProg.Size = New System.Drawing.Size(188, 22)
        Me.mnuNumOfProg.Text = "Number Of Programs"
        '
        'mnuCourse
        '
        Me.mnuCourse.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgrammingIToolStripMenuItem, Me.APCompSciAToolStripMenuItem, Me.ProgrammingIIToolStripMenuItem})
        Me.mnuCourse.Name = "mnuCourse"
        Me.mnuCourse.Size = New System.Drawing.Size(188, 22)
        Me.mnuCourse.Text = "Course"
        '
        'ProgrammingIToolStripMenuItem
        '
        Me.ProgrammingIToolStripMenuItem.Name = "ProgrammingIToolStripMenuItem"
        Me.ProgrammingIToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProgrammingIToolStripMenuItem.Text = "Programming I"
        '
        'APCompSciAToolStripMenuItem
        '
        Me.APCompSciAToolStripMenuItem.Name = "APCompSciAToolStripMenuItem"
        Me.APCompSciAToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.APCompSciAToolStripMenuItem.Text = "AP Comp Sci A"
        '
        'ProgrammingIIToolStripMenuItem
        '
        Me.ProgrammingIIToolStripMenuItem.Name = "ProgrammingIIToolStripMenuItem"
        Me.ProgrammingIIToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProgrammingIIToolStripMenuItem.Text = "Programming II"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(166, 262)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(100, 51)
        Me.lblStatus.TabIndex = 4
        '
        'btnPerfect
        '
        Me.btnPerfect.Location = New System.Drawing.Point(39, 368)
        Me.btnPerfect.Name = "btnPerfect"
        Me.btnPerfect.Size = New System.Drawing.Size(59, 23)
        Me.btnPerfect.TabIndex = 10
        Me.btnPerfect.Text = "100%"
        Me.btnPerfect.UseVisualStyleBackColor = True
        '
        'btnMissing
        '
        Me.btnMissing.Location = New System.Drawing.Point(185, 368)
        Me.btnMissing.Name = "btnMissing"
        Me.btnMissing.Size = New System.Drawing.Size(53, 23)
        Me.btnMissing.TabIndex = 11
        Me.btnMissing.Text = "0%"
        Me.btnMissing.UseVisualStyleBackColor = True
        '
        'chkAPScale
        '
        Me.chkAPScale.AutoSize = True
        Me.chkAPScale.Location = New System.Drawing.Point(169, 296)
        Me.chkAPScale.Name = "chkAPScale"
        Me.chkAPScale.Size = New System.Drawing.Size(78, 17)
        Me.chkAPScale.TabIndex = 12
        Me.chkAPScale.Text = "AP Scaling"
        Me.chkAPScale.UseVisualStyleBackColor = True
        Me.chkAPScale.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 396)
        Me.Controls.Add(Me.chkAPScale)
        Me.Controls.Add(Me.btnMissing)
        Me.Controls.Add(Me.btnPerfect)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpStep3)
        Me.Controls.Add(Me.grpStep2)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.grpStep1)
        Me.Controls.Add(Me.mnuStripMain)
        Me.MainMenuStrip = Me.mnuStripMain
        Me.Name = "frmMain"
        Me.Text = "Prog Grader Beta 1.0"
        Me.grpStep1.ResumeLayout(False)
        Me.grpStep1.PerformLayout()
        Me.grpStep2.ResumeLayout(False)
        Me.grpStep2.PerformLayout()
        Me.grpStep3.ResumeLayout(False)
        Me.grpStep3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mnuStripMain.ResumeLayout(False)
        Me.mnuStripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpStep1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkHonor As System.Windows.Forms.CheckBox
    Friend WithEvents chkOnTime As System.Windows.Forms.CheckBox
    Friend WithEvents chkAllFiles As System.Windows.Forms.CheckBox
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents grpStep2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkComments As System.Windows.Forms.CheckBox
    Friend WithEvents chkOption As System.Windows.Forms.CheckBox
    Friend WithEvents grpStep3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkInstructions As System.Windows.Forms.CheckBox
    Friend WithEvents chkCompile As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkDecimal As System.Windows.Forms.CheckBox
    Friend WithEvents chkNegative As System.Windows.Forms.CheckBox
    Friend WithEvents chkIdealCase As System.Windows.Forms.CheckBox
    Friend WithEvents chkTry As System.Windows.Forms.CheckBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents chkHung As System.Windows.Forms.CheckBox
    Friend WithEvents mnuStripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSelectAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCopy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuReset As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNumOfProg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCourse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnPerfect As System.Windows.Forms.Button
    Friend WithEvents btnMissing As System.Windows.Forms.Button
    Friend WithEvents ProgrammingIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APCompSciAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgrammingIIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkAPScale As System.Windows.Forms.CheckBox

End Class
