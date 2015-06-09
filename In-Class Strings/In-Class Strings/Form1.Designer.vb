<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class strings
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Output:"
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(147, 95)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(101, 26)
        Me.lblOutput.TabIndex = 2
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(87, 166)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(81, 32)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(147, 39)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(101, 26)
        Me.txtInput.TabIndex = 4
        '
        'strings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 236)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "strings"
        Me.Text = "In-Class Strings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblOutput As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents txtInput As System.Windows.Forms.TextBox

End Class
