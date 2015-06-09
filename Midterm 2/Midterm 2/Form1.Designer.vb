<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Midterm
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
        Me.lblTestScore = New System.Windows.Forms.Label()
        Me.txtTestScore = New System.Windows.Forms.TextBox()
        Me.lstTestScores = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSum1 = New System.Windows.Forms.Label()
        Me.lblSum2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTestScore
        '
        Me.lblTestScore.AutoSize = True
        Me.lblTestScore.Location = New System.Drawing.Point(12, 29)
        Me.lblTestScore.Name = "lblTestScore"
        Me.lblTestScore.Size = New System.Drawing.Size(152, 18)
        Me.lblTestScore.TabIndex = 0
        Me.lblTestScore.Text = "Enter the Test Score:"
        '
        'txtTestScore
        '
        Me.txtTestScore.Location = New System.Drawing.Point(170, 26)
        Me.txtTestScore.Name = "txtTestScore"
        Me.txtTestScore.Size = New System.Drawing.Size(100, 26)
        Me.txtTestScore.TabIndex = 1
        '
        'lstTestScores
        '
        Me.lstTestScores.FormattingEnabled = True
        Me.lstTestScores.ItemHeight = 18
        Me.lstTestScores.Location = New System.Drawing.Point(12, 102)
        Me.lstTestScores.Name = "lstTestScores"
        Me.lstTestScores.Size = New System.Drawing.Size(152, 184)
        Me.lstTestScores.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(181, 104)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(79, 39)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(181, 149)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(79, 39)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSum
        '
        Me.btnSum.Location = New System.Drawing.Point(181, 194)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(79, 39)
        Me.btnSum.TabIndex = 5
        Me.btnSum.Text = "Sum"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(181, 239)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(79, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSum1
        '
        Me.lblSum1.AutoSize = True
        Me.lblSum1.Location = New System.Drawing.Point(12, 67)
        Me.lblSum1.Name = "lblSum1"
        Me.lblSum1.Size = New System.Drawing.Size(80, 18)
        Me.lblSum1.TabIndex = 7
        Me.lblSum1.Text = "Total Sum:"
        '
        'lblSum2
        '
        Me.lblSum2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSum2.Location = New System.Drawing.Point(170, 66)
        Me.lblSum2.Name = "lblSum2"
        Me.lblSum2.Size = New System.Drawing.Size(100, 26)
        Me.lblSum2.TabIndex = 8
        '
        'Midterm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 293)
        Me.Controls.Add(Me.lblSum2)
        Me.Controls.Add(Me.lblSum1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstTestScores)
        Me.Controls.Add(Me.txtTestScore)
        Me.Controls.Add(Me.lblTestScore)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Midterm"
        Me.Text = "Midterm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTestScore As System.Windows.Forms.Label
    Friend WithEvents txtTestScore As System.Windows.Forms.TextBox
    Friend WithEvents lstTestScores As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSum As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblSum1 As System.Windows.Forms.Label
    Friend WithEvents lblSum2 As System.Windows.Forms.Label

End Class
