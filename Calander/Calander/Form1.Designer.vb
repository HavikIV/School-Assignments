<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MetricConversion
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
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtKilos = New System.Windows.Forms.TextBox()
        Me.txtCenti = New System.Windows.Forms.TextBox()
        Me.lblKilograms = New System.Windows.Forms.Label()
        Me.lblCentimeters = New System.Windows.Forms.Label()
        Me.lblPoundAnswer = New System.Windows.Forms.Label()
        Me.lblPoundResult = New System.Windows.Forms.Label()
        Me.lblFeetAnswer = New System.Windows.Forms.Label()
        Me.lblFeetResult = New System.Windows.Forms.Label()
        Me.lblInchesAnswer = New System.Windows.Forms.Label()
        Me.lblInchesResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(75, 285)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(103, 36)
        Me.btnGo.TabIndex = 0
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtKilos
        '
        Me.txtKilos.Location = New System.Drawing.Point(148, 32)
        Me.txtKilos.Name = "txtKilos"
        Me.txtKilos.Size = New System.Drawing.Size(100, 26)
        Me.txtKilos.TabIndex = 1
        '
        'txtCenti
        '
        Me.txtCenti.Location = New System.Drawing.Point(148, 94)
        Me.txtCenti.Name = "txtCenti"
        Me.txtCenti.Size = New System.Drawing.Size(100, 26)
        Me.txtCenti.TabIndex = 2
        '
        'lblKilograms
        '
        Me.lblKilograms.AutoSize = True
        Me.lblKilograms.Location = New System.Drawing.Point(41, 38)
        Me.lblKilograms.Name = "lblKilograms"
        Me.lblKilograms.Size = New System.Drawing.Size(73, 20)
        Me.lblKilograms.TabIndex = 3
        Me.lblKilograms.Text = "Kilograms:"
        '
        'lblCentimeters
        '
        Me.lblCentimeters.AutoSize = True
        Me.lblCentimeters.Location = New System.Drawing.Point(41, 97)
        Me.lblCentimeters.Name = "lblCentimeters"
        Me.lblCentimeters.Size = New System.Drawing.Size(84, 20)
        Me.lblCentimeters.TabIndex = 4
        Me.lblCentimeters.Text = "Centimeters:"
        '
        'lblPoundAnswer
        '
        Me.lblPoundAnswer.AutoSize = True
        Me.lblPoundAnswer.Location = New System.Drawing.Point(41, 169)
        Me.lblPoundAnswer.Name = "lblPoundAnswer"
        Me.lblPoundAnswer.Size = New System.Drawing.Size(59, 20)
        Me.lblPoundAnswer.TabIndex = 5
        Me.lblPoundAnswer.Text = "Pounds:"
        '
        'lblPoundResult
        '
        Me.lblPoundResult.AutoSize = True
        Me.lblPoundResult.Location = New System.Drawing.Point(144, 169)
        Me.lblPoundResult.Name = "lblPoundResult"
        Me.lblPoundResult.Size = New System.Drawing.Size(16, 20)
        Me.lblPoundResult.TabIndex = 6
        Me.lblPoundResult.Text = "?"
        '
        'lblFeetAnswer
        '
        Me.lblFeetAnswer.AutoSize = True
        Me.lblFeetAnswer.Location = New System.Drawing.Point(41, 213)
        Me.lblFeetAnswer.Name = "lblFeetAnswer"
        Me.lblFeetAnswer.Size = New System.Drawing.Size(40, 20)
        Me.lblFeetAnswer.TabIndex = 7
        Me.lblFeetAnswer.Text = "Feet:"
        '
        'lblFeetResult
        '
        Me.lblFeetResult.AutoSize = True
        Me.lblFeetResult.Location = New System.Drawing.Point(87, 213)
        Me.lblFeetResult.Name = "lblFeetResult"
        Me.lblFeetResult.Size = New System.Drawing.Size(16, 20)
        Me.lblFeetResult.TabIndex = 8
        Me.lblFeetResult.Text = "?"
        '
        'lblInchesAnswer
        '
        Me.lblInchesAnswer.AutoSize = True
        Me.lblInchesAnswer.Location = New System.Drawing.Point(144, 213)
        Me.lblInchesAnswer.Name = "lblInchesAnswer"
        Me.lblInchesAnswer.Size = New System.Drawing.Size(52, 20)
        Me.lblInchesAnswer.TabIndex = 9
        Me.lblInchesAnswer.Text = "Inches:"
        '
        'lblInchesResults
        '
        Me.lblInchesResults.AutoSize = True
        Me.lblInchesResults.Location = New System.Drawing.Point(199, 213)
        Me.lblInchesResults.Name = "lblInchesResults"
        Me.lblInchesResults.Size = New System.Drawing.Size(16, 20)
        Me.lblInchesResults.TabIndex = 10
        Me.lblInchesResults.Text = "?"
        '
        'MetricConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 376)
        Me.Controls.Add(Me.lblInchesResults)
        Me.Controls.Add(Me.lblInchesAnswer)
        Me.Controls.Add(Me.lblFeetResult)
        Me.Controls.Add(Me.lblFeetAnswer)
        Me.Controls.Add(Me.lblPoundResult)
        Me.Controls.Add(Me.lblPoundAnswer)
        Me.Controls.Add(Me.lblCentimeters)
        Me.Controls.Add(Me.lblKilograms)
        Me.Controls.Add(Me.txtCenti)
        Me.Controls.Add(Me.txtKilos)
        Me.Controls.Add(Me.btnGo)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MetricConversion"
        Me.Text = "Metric Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtKilos As System.Windows.Forms.TextBox
    Friend WithEvents txtCenti As System.Windows.Forms.TextBox
    Friend WithEvents lblKilograms As System.Windows.Forms.Label
    Friend WithEvents lblCentimeters As System.Windows.Forms.Label
    Friend WithEvents lblPoundAnswer As System.Windows.Forms.Label
    Friend WithEvents lblPoundResult As System.Windows.Forms.Label
    Friend WithEvents lblFeetAnswer As System.Windows.Forms.Label
    Friend WithEvents lblFeetResult As System.Windows.Forms.Label
    Friend WithEvents lblInchesAnswer As System.Windows.Forms.Label
    Friend WithEvents lblInchesResults As System.Windows.Forms.Label

End Class
