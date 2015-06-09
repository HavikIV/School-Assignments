<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Weather
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
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.txtTemperture = New System.Windows.Forms.TextBox()
        Me.lblItIs = New System.Windows.Forms.Label()
        Me.lblReply = New System.Windows.Forms.Label()
        Me.btnReply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTemperature
        '
        Me.lblTemperature.AutoSize = True
        Me.lblTemperature.Location = New System.Drawing.Point(13, 24)
        Me.lblTemperature.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(99, 18)
        Me.lblTemperature.TabIndex = 0
        Me.lblTemperature.Text = "Temperature:"
        '
        'txtTemperture
        '
        Me.txtTemperture.Location = New System.Drawing.Point(142, 21)
        Me.txtTemperture.Name = "txtTemperture"
        Me.txtTemperture.Size = New System.Drawing.Size(67, 26)
        Me.txtTemperture.TabIndex = 1
        '
        'lblItIs
        '
        Me.lblItIs.AutoSize = True
        Me.lblItIs.Location = New System.Drawing.Point(13, 79)
        Me.lblItIs.Name = "lblItIs"
        Me.lblItIs.Size = New System.Drawing.Size(34, 18)
        Me.lblItIs.TabIndex = 2
        Me.lblItIs.Text = "It Is:"
        '
        'lblReply
        '
        Me.lblReply.AutoSize = True
        Me.lblReply.Location = New System.Drawing.Point(95, 79)
        Me.lblReply.Name = "lblReply"
        Me.lblReply.Size = New System.Drawing.Size(17, 18)
        Me.lblReply.TabIndex = 3
        Me.lblReply.Text = "?"
        '
        'btnReply
        '
        Me.btnReply.Location = New System.Drawing.Point(25, 120)
        Me.btnReply.Name = "btnReply"
        Me.btnReply.Size = New System.Drawing.Size(193, 38)
        Me.btnReply.TabIndex = 4
        Me.btnReply.Text = "How's The Weather"
        Me.btnReply.UseVisualStyleBackColor = True
        '
        'Weather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 185)
        Me.Controls.Add(Me.btnReply)
        Me.Controls.Add(Me.lblReply)
        Me.Controls.Add(Me.lblItIs)
        Me.Controls.Add(Me.txtTemperture)
        Me.Controls.Add(Me.lblTemperature)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Weather"
        Me.Text = "Weather"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents txtTemperture As System.Windows.Forms.TextBox
    Friend WithEvents lblItIs As System.Windows.Forms.Label
    Friend WithEvents lblReply As System.Windows.Forms.Label
    Friend WithEvents btnReply As System.Windows.Forms.Button

End Class
