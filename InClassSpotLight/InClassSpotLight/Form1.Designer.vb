<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spotlight
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbRedLight = New System.Windows.Forms.RadioButton()
        Me.rbYellowLight = New System.Windows.Forms.RadioButton()
        Me.rbGreenLight = New System.Windows.Forms.RadioButton()
        Me.cbPolice = New System.Windows.Forms.CheckBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblAdvice = New System.Windows.Forms.Label()
        Me.lblAdviceResult = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbPolice)
        Me.GroupBox1.Controls.Add(Me.rbGreenLight)
        Me.GroupBox1.Controls.Add(Me.rbYellowLight)
        Me.GroupBox1.Controls.Add(Me.rbRedLight)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAdviceResult)
        Me.GroupBox2.Controls.Add(Me.lblAdvice)
        Me.GroupBox2.Controls.Add(Me.btnStart)
        Me.GroupBox2.Location = New System.Drawing.Point(161, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 151)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'rbRedLight
        '
        Me.rbRedLight.AutoSize = True
        Me.rbRedLight.Checked = True
        Me.rbRedLight.ForeColor = System.Drawing.Color.Red
        Me.rbRedLight.Location = New System.Drawing.Point(6, 25)
        Me.rbRedLight.Name = "rbRedLight"
        Me.rbRedLight.Size = New System.Drawing.Size(60, 22)
        Me.rbRedLight.TabIndex = 0
        Me.rbRedLight.TabStop = True
        Me.rbRedLight.Text = "RED"
        Me.rbRedLight.UseVisualStyleBackColor = True
        '
        'rbYellowLight
        '
        Me.rbYellowLight.AutoSize = True
        Me.rbYellowLight.ForeColor = System.Drawing.Color.Yellow
        Me.rbYellowLight.Location = New System.Drawing.Point(6, 53)
        Me.rbYellowLight.Name = "rbYellowLight"
        Me.rbYellowLight.Size = New System.Drawing.Size(91, 22)
        Me.rbYellowLight.TabIndex = 1
        Me.rbYellowLight.Text = "YELLOW"
        Me.rbYellowLight.UseVisualStyleBackColor = True
        '
        'rbGreenLight
        '
        Me.rbGreenLight.AutoSize = True
        Me.rbGreenLight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbGreenLight.Location = New System.Drawing.Point(6, 81)
        Me.rbGreenLight.Name = "rbGreenLight"
        Me.rbGreenLight.Size = New System.Drawing.Size(82, 22)
        Me.rbGreenLight.TabIndex = 2
        Me.rbGreenLight.Text = "GREEN"
        Me.rbGreenLight.UseVisualStyleBackColor = True
        '
        'cbPolice
        '
        Me.cbPolice.AutoSize = True
        Me.cbPolice.Location = New System.Drawing.Point(6, 120)
        Me.cbPolice.Name = "cbPolice"
        Me.cbPolice.Size = New System.Drawing.Size(129, 22)
        Me.cbPolice.TabIndex = 3
        Me.cbPolice.Text = "Police Present"
        Me.cbPolice.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(75, 81)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(119, 41)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblAdvice
        '
        Me.lblAdvice.AutoSize = True
        Me.lblAdvice.Location = New System.Drawing.Point(9, 29)
        Me.lblAdvice.Name = "lblAdvice"
        Me.lblAdvice.Size = New System.Drawing.Size(60, 18)
        Me.lblAdvice.TabIndex = 1
        Me.lblAdvice.Text = "Advice:"
        '
        'lblAdviceResult
        '
        Me.lblAdviceResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdviceResult.Location = New System.Drawing.Point(75, 26)
        Me.lblAdviceResult.Name = "lblAdviceResult"
        Me.lblAdviceResult.Size = New System.Drawing.Size(265, 28)
        Me.lblAdviceResult.TabIndex = 2
        '
        'Spotlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 174)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Spotlight"
        Me.Text = "Spotlight"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbPolice As System.Windows.Forms.CheckBox
    Friend WithEvents rbGreenLight As System.Windows.Forms.RadioButton
    Friend WithEvents rbYellowLight As System.Windows.Forms.RadioButton
    Friend WithEvents rbRedLight As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAdviceResult As System.Windows.Forms.Label
    Friend WithEvents lblAdvice As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button

End Class
