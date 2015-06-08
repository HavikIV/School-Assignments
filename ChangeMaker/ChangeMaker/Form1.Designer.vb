<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeMaker
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
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblQuartersChange = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblDimesChange = New System.Windows.Forms.Label()
        Me.lblNickelsChange = New System.Windows.Forms.Label()
        Me.lblPenniesChange = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblDollars = New System.Windows.Forms.Label()
        Me.lblDollarChange = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtChange
        '
        Me.txtChange.Location = New System.Drawing.Point(267, 12)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(100, 26)
        Me.txtChange.TabIndex = 0
        Me.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Location = New System.Drawing.Point(12, 15)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(180, 20)
        Me.lblChange.TabIndex = 1
        Me.lblChange.Text = "Enter the Amount of Change:"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Location = New System.Drawing.Point(12, 80)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(63, 20)
        Me.lblQuarters.TabIndex = 2
        Me.lblQuarters.Text = "Quarters:"
        '
        'lblQuartersChange
        '
        Me.lblQuartersChange.AutoSize = True
        Me.lblQuartersChange.Location = New System.Drawing.Point(318, 80)
        Me.lblQuartersChange.Name = "lblQuartersChange"
        Me.lblQuartersChange.Size = New System.Drawing.Size(16, 20)
        Me.lblQuartersChange.TabIndex = 3
        Me.lblQuartersChange.Text = "?"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Location = New System.Drawing.Point(12, 110)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(51, 20)
        Me.lblDimes.TabIndex = 4
        Me.lblDimes.Text = "Dimes:"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Location = New System.Drawing.Point(12, 140)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(57, 20)
        Me.lblNickels.TabIndex = 5
        Me.lblNickels.Text = "Nickels:"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Location = New System.Drawing.Point(12, 170)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(62, 20)
        Me.lblPennies.TabIndex = 6
        Me.lblPennies.Text = "Pennies:"
        '
        'lblDimesChange
        '
        Me.lblDimesChange.AutoSize = True
        Me.lblDimesChange.Location = New System.Drawing.Point(318, 110)
        Me.lblDimesChange.Name = "lblDimesChange"
        Me.lblDimesChange.Size = New System.Drawing.Size(16, 20)
        Me.lblDimesChange.TabIndex = 7
        Me.lblDimesChange.Text = "?"
        '
        'lblNickelsChange
        '
        Me.lblNickelsChange.AutoSize = True
        Me.lblNickelsChange.Location = New System.Drawing.Point(318, 140)
        Me.lblNickelsChange.Name = "lblNickelsChange"
        Me.lblNickelsChange.Size = New System.Drawing.Size(16, 20)
        Me.lblNickelsChange.TabIndex = 8
        Me.lblNickelsChange.Text = "?"
        '
        'lblPenniesChange
        '
        Me.lblPenniesChange.AutoSize = True
        Me.lblPenniesChange.Location = New System.Drawing.Point(318, 170)
        Me.lblPenniesChange.Name = "lblPenniesChange"
        Me.lblPenniesChange.Size = New System.Drawing.Size(16, 20)
        Me.lblPenniesChange.TabIndex = 9
        Me.lblPenniesChange.Text = "?"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(116, 220)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(134, 49)
        Me.btnCalculate.TabIndex = 10
        Me.btnCalculate.Text = "Calculate Change"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblDollars
        '
        Me.lblDollars.AutoSize = True
        Me.lblDollars.Location = New System.Drawing.Point(12, 50)
        Me.lblDollars.Name = "lblDollars"
        Me.lblDollars.Size = New System.Drawing.Size(54, 20)
        Me.lblDollars.TabIndex = 11
        Me.lblDollars.Text = "Dollars:"
        '
        'lblDollarChange
        '
        Me.lblDollarChange.AutoSize = True
        Me.lblDollarChange.Location = New System.Drawing.Point(318, 50)
        Me.lblDollarChange.Name = "lblDollarChange"
        Me.lblDollarChange.Size = New System.Drawing.Size(16, 20)
        Me.lblDollarChange.TabIndex = 12
        Me.lblDollarChange.Text = "?"
        '
        'ChangeMaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 300)
        Me.Controls.Add(Me.lblDollarChange)
        Me.Controls.Add(Me.lblDollars)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblPenniesChange)
        Me.Controls.Add(Me.lblNickelsChange)
        Me.Controls.Add(Me.lblDimesChange)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblQuartersChange)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.txtChange)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ChangeMaker"
        Me.Text = "Change Maker 2014"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtChange As System.Windows.Forms.TextBox
    Friend WithEvents lblChange As System.Windows.Forms.Label
    Friend WithEvents lblQuarters As System.Windows.Forms.Label
    Friend WithEvents lblQuartersChange As System.Windows.Forms.Label
    Friend WithEvents lblDimes As System.Windows.Forms.Label
    Friend WithEvents lblNickels As System.Windows.Forms.Label
    Friend WithEvents lblPennies As System.Windows.Forms.Label
    Friend WithEvents lblDimesChange As System.Windows.Forms.Label
    Friend WithEvents lblNickelsChange As System.Windows.Forms.Label
    Friend WithEvents lblPenniesChange As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblDollars As System.Windows.Forms.Label
    Friend WithEvents lblDollarChange As System.Windows.Forms.Label

End Class
