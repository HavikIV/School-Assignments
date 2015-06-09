<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloWorld
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
        Me.Hello_World = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Hello_World
        '
        Me.Hello_World.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hello_World.Location = New System.Drawing.Point(17, 267)
        Me.Hello_World.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Hello_World.Name = "Hello_World"
        Me.Hello_World.Size = New System.Drawing.Size(492, 84)
        Me.Hello_World.TabIndex = 0
        Me.Hello_World.Text = "Click Me!"
        Me.Hello_World.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(14, 16)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(0, 24)
        Me.lblOutput.TabIndex = 1
        '
        'HelloWorld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 365)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.Hello_World)
        Me.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "HelloWorld"
        Me.Text = "Hello World!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Hello_World As System.Windows.Forms.Button
    Friend WithEvents lblOutput As System.Windows.Forms.Label

End Class
