<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.txtNumbers = New System.Windows.Forms.TextBox()
        Me.btnAddition = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnMultiplication = New System.Windows.Forms.Button()
        Me.btnDivision = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNumbers
        '
        Me.txtNumbers.Location = New System.Drawing.Point(12, 36)
        Me.txtNumbers.Name = "txtNumbers"
        Me.txtNumbers.Size = New System.Drawing.Size(206, 26)
        Me.txtNumbers.TabIndex = 0
        Me.txtNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAddition
        '
        Me.btnAddition.Location = New System.Drawing.Point(12, 77)
        Me.btnAddition.Name = "btnAddition"
        Me.btnAddition.Size = New System.Drawing.Size(47, 32)
        Me.btnAddition.TabIndex = 2
        Me.btnAddition.Text = "+"
        Me.btnAddition.UseVisualStyleBackColor = True
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Location = New System.Drawing.Point(65, 77)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(47, 32)
        Me.btnSubtraction.TabIndex = 3
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'btnMultiplication
        '
        Me.btnMultiplication.Location = New System.Drawing.Point(118, 77)
        Me.btnMultiplication.Name = "btnMultiplication"
        Me.btnMultiplication.Size = New System.Drawing.Size(47, 32)
        Me.btnMultiplication.TabIndex = 4
        Me.btnMultiplication.Text = "*"
        Me.btnMultiplication.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.Location = New System.Drawing.Point(171, 77)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(47, 32)
        Me.btnDivision.TabIndex = 5
        Me.btnDivision.Text = "/"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Location = New System.Drawing.Point(188, 9)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(17, 18)
        Me.lblAnswer.TabIndex = 5
        Me.lblAnswer.Text = "?"
        Me.lblAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 127)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnMultiplication)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnAddition)
        Me.Controls.Add(Me.txtNumbers)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumbers As System.Windows.Forms.TextBox
    Friend WithEvents btnAddition As System.Windows.Forms.Button
    Friend WithEvents btnSubtraction As System.Windows.Forms.Button
    Friend WithEvents btnMultiplication As System.Windows.Forms.Button
    Friend WithEvents btnDivision As System.Windows.Forms.Button
    Friend WithEvents lblAnswer As System.Windows.Forms.Label

End Class
