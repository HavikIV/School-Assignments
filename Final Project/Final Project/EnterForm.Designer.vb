<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterForm
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
        Me.txtString = New System.Windows.Forms.TextBox()
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtString
        '
        Me.txtString.Location = New System.Drawing.Point(126, 33)
        Me.txtString.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtString.Name = "txtString"
        Me.txtString.Size = New System.Drawing.Size(190, 26)
        Me.txtString.TabIndex = 0
        '
        'btnOkay
        '
        Me.btnOkay.Location = New System.Drawing.Point(337, 32)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(90, 26)
        Me.btnOkay.TabIndex = 1
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter a String:"
        '
        'EnterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 90)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.txtString)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "EnterForm"
        Me.Text = "Enter a String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtString As System.Windows.Forms.TextBox
    Friend WithEvents btnOkay As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
