<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Race
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
        Me.lblNames = New System.Windows.Forms.Label()
        Me.lblR1 = New System.Windows.Forms.Label()
        Me.lblR2 = New System.Windows.Forms.Label()
        Me.lblR3 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblFinishTime = New System.Windows.Forms.Label()
        Me.txtName1 = New System.Windows.Forms.TextBox()
        Me.txtFinishTime1 = New System.Windows.Forms.TextBox()
        Me.txtName3 = New System.Windows.Forms.TextBox()
        Me.txtName2 = New System.Windows.Forms.TextBox()
        Me.txtFinishTime2 = New System.Windows.Forms.TextBox()
        Me.txtFinishTime3 = New System.Windows.Forms.TextBox()
        Me.grpRaceResults = New System.Windows.Forms.GroupBox()
        Me.lbl3rdPlace = New System.Windows.Forms.Label()
        Me.lbl2ndPlace = New System.Windows.Forms.Label()
        Me.lbl1stPlace = New System.Windows.Forms.Label()
        Me.lbl3rd = New System.Windows.Forms.Label()
        Me.lbl2nd = New System.Windows.Forms.Label()
        Me.lbl1st = New System.Windows.Forms.Label()
        Me.btnResults = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpRaceResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNames
        '
        Me.lblNames.Location = New System.Drawing.Point(12, 19)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(358, 26)
        Me.lblNames.TabIndex = 0
        Me.lblNames.Text = "Enter the three runner's names and finshing times."
        '
        'lblR1
        '
        Me.lblR1.AutoSize = True
        Me.lblR1.Location = New System.Drawing.Point(28, 98)
        Me.lblR1.Name = "lblR1"
        Me.lblR1.Size = New System.Drawing.Size(74, 18)
        Me.lblR1.TabIndex = 1
        Me.lblR1.Text = "Runner 1:"
        '
        'lblR2
        '
        Me.lblR2.AutoSize = True
        Me.lblR2.Location = New System.Drawing.Point(28, 131)
        Me.lblR2.Name = "lblR2"
        Me.lblR2.Size = New System.Drawing.Size(74, 18)
        Me.lblR2.TabIndex = 2
        Me.lblR2.Text = "Runner 2:"
        '
        'lblR3
        '
        Me.lblR3.AutoSize = True
        Me.lblR3.Location = New System.Drawing.Point(28, 165)
        Me.lblR3.Name = "lblR3"
        Me.lblR3.Size = New System.Drawing.Size(74, 18)
        Me.lblR3.TabIndex = 3
        Me.lblR3.Text = "Runner 3:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(128, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 18)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'lblFinishTime
        '
        Me.lblFinishTime.Location = New System.Drawing.Point(241, 45)
        Me.lblFinishTime.Name = "lblFinishTime"
        Me.lblFinishTime.Size = New System.Drawing.Size(113, 38)
        Me.lblFinishTime.TabIndex = 5
        Me.lblFinishTime.Text = "Finishing Time (in sceonds)"
        '
        'txtName1
        '
        Me.txtName1.Location = New System.Drawing.Point(131, 95)
        Me.txtName1.Name = "txtName1"
        Me.txtName1.Size = New System.Drawing.Size(100, 26)
        Me.txtName1.TabIndex = 6
        '
        'txtFinishTime1
        '
        Me.txtFinishTime1.Location = New System.Drawing.Point(254, 95)
        Me.txtFinishTime1.Name = "txtFinishTime1"
        Me.txtFinishTime1.Size = New System.Drawing.Size(100, 26)
        Me.txtFinishTime1.TabIndex = 7
        '
        'txtName3
        '
        Me.txtName3.Location = New System.Drawing.Point(131, 162)
        Me.txtName3.Name = "txtName3"
        Me.txtName3.Size = New System.Drawing.Size(100, 26)
        Me.txtName3.TabIndex = 10
        '
        'txtName2
        '
        Me.txtName2.Location = New System.Drawing.Point(131, 128)
        Me.txtName2.Name = "txtName2"
        Me.txtName2.Size = New System.Drawing.Size(100, 26)
        Me.txtName2.TabIndex = 8
        '
        'txtFinishTime2
        '
        Me.txtFinishTime2.Location = New System.Drawing.Point(254, 128)
        Me.txtFinishTime2.Name = "txtFinishTime2"
        Me.txtFinishTime2.Size = New System.Drawing.Size(100, 26)
        Me.txtFinishTime2.TabIndex = 9
        '
        'txtFinishTime3
        '
        Me.txtFinishTime3.Location = New System.Drawing.Point(254, 162)
        Me.txtFinishTime3.Name = "txtFinishTime3"
        Me.txtFinishTime3.Size = New System.Drawing.Size(100, 26)
        Me.txtFinishTime3.TabIndex = 11
        '
        'grpRaceResults
        '
        Me.grpRaceResults.Controls.Add(Me.lbl3rdPlace)
        Me.grpRaceResults.Controls.Add(Me.lbl2ndPlace)
        Me.grpRaceResults.Controls.Add(Me.lbl1stPlace)
        Me.grpRaceResults.Controls.Add(Me.lbl3rd)
        Me.grpRaceResults.Controls.Add(Me.lbl2nd)
        Me.grpRaceResults.Controls.Add(Me.lbl1st)
        Me.grpRaceResults.Location = New System.Drawing.Point(47, 210)
        Me.grpRaceResults.Name = "grpRaceResults"
        Me.grpRaceResults.Size = New System.Drawing.Size(265, 163)
        Me.grpRaceResults.TabIndex = 12
        Me.grpRaceResults.TabStop = False
        Me.grpRaceResults.Text = "Race Results"
        '
        'lbl3rdPlace
        '
        Me.lbl3rdPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl3rdPlace.Location = New System.Drawing.Point(130, 115)
        Me.lbl3rdPlace.Name = "lbl3rdPlace"
        Me.lbl3rdPlace.Size = New System.Drawing.Size(103, 28)
        Me.lbl3rdPlace.TabIndex = 5
        '
        'lbl2ndPlace
        '
        Me.lbl2ndPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl2ndPlace.Location = New System.Drawing.Point(130, 73)
        Me.lbl2ndPlace.Name = "lbl2ndPlace"
        Me.lbl2ndPlace.Size = New System.Drawing.Size(103, 28)
        Me.lbl2ndPlace.TabIndex = 4
        '
        'lbl1stPlace
        '
        Me.lbl1stPlace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl1stPlace.Location = New System.Drawing.Point(130, 32)
        Me.lbl1stPlace.Name = "lbl1stPlace"
        Me.lbl1stPlace.Size = New System.Drawing.Size(103, 28)
        Me.lbl1stPlace.TabIndex = 3
        '
        'lbl3rd
        '
        Me.lbl3rd.AutoSize = True
        Me.lbl3rd.Location = New System.Drawing.Point(36, 116)
        Me.lbl3rd.Name = "lbl3rd"
        Me.lbl3rd.Size = New System.Drawing.Size(79, 18)
        Me.lbl3rd.TabIndex = 2
        Me.lbl3rd.Text = "3rd Place:"
        '
        'lbl2nd
        '
        Me.lbl2nd.AutoSize = True
        Me.lbl2nd.Location = New System.Drawing.Point(33, 74)
        Me.lbl2nd.Name = "lbl2nd"
        Me.lbl2nd.Size = New System.Drawing.Size(82, 18)
        Me.lbl2nd.TabIndex = 1
        Me.lbl2nd.Text = "2nd Place:"
        '
        'lbl1st
        '
        Me.lbl1st.AutoSize = True
        Me.lbl1st.Location = New System.Drawing.Point(38, 32)
        Me.lbl1st.Name = "lbl1st"
        Me.lbl1st.Size = New System.Drawing.Size(77, 18)
        Me.lbl1st.TabIndex = 0
        Me.lbl1st.Text = "1st Place:"
        '
        'btnResults
        '
        Me.btnResults.Location = New System.Drawing.Point(47, 389)
        Me.btnResults.Name = "btnResults"
        Me.btnResults.Size = New System.Drawing.Size(82, 44)
        Me.btnResults.TabIndex = 13
        Me.btnResults.Text = "Calculate &Results"
        Me.btnResults.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(149, 389)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(82, 44)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(254, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(82, 44)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Race
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 463)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnResults)
        Me.Controls.Add(Me.grpRaceResults)
        Me.Controls.Add(Me.txtFinishTime3)
        Me.Controls.Add(Me.txtFinishTime2)
        Me.Controls.Add(Me.txtName2)
        Me.Controls.Add(Me.txtName3)
        Me.Controls.Add(Me.txtFinishTime1)
        Me.Controls.Add(Me.txtName1)
        Me.Controls.Add(Me.lblFinishTime)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblR3)
        Me.Controls.Add(Me.lblR2)
        Me.Controls.Add(Me.lblR1)
        Me.Controls.Add(Me.lblNames)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Race"
        Me.Text = "Race Results"
        Me.grpRaceResults.ResumeLayout(False)
        Me.grpRaceResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNames As System.Windows.Forms.Label
    Friend WithEvents lblR1 As System.Windows.Forms.Label
    Friend WithEvents lblR2 As System.Windows.Forms.Label
    Friend WithEvents lblR3 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblFinishTime As System.Windows.Forms.Label
    Friend WithEvents txtName1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishTime1 As System.Windows.Forms.TextBox
    Friend WithEvents txtName3 As System.Windows.Forms.TextBox
    Friend WithEvents txtName2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishTime2 As System.Windows.Forms.TextBox
    Friend WithEvents txtFinishTime3 As System.Windows.Forms.TextBox
    Friend WithEvents grpRaceResults As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3rdPlace As System.Windows.Forms.Label
    Friend WithEvents lbl2ndPlace As System.Windows.Forms.Label
    Friend WithEvents lbl1stPlace As System.Windows.Forms.Label
    Friend WithEvents lbl3rd As System.Windows.Forms.Label
    Friend WithEvents lbl2nd As System.Windows.Forms.Label
    Friend WithEvents lbl1st As System.Windows.Forms.Label
    Friend WithEvents btnResults As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
