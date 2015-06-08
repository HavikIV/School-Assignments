<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User_Menu
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
        Me.lstbxAllUsers = New System.Windows.Forms.ListBox()
        Me.lblAllUsers = New System.Windows.Forms.Label()
        Me.btnSetTimer = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstbxAllUsers
        '
        Me.lstbxAllUsers.FormattingEnabled = True
        Me.lstbxAllUsers.ItemHeight = 18
        Me.lstbxAllUsers.Location = New System.Drawing.Point(12, 30)
        Me.lstbxAllUsers.Name = "lstbxAllUsers"
        Me.lstbxAllUsers.Size = New System.Drawing.Size(158, 184)
        Me.lstbxAllUsers.TabIndex = 0
        '
        'lblAllUsers
        '
        Me.lblAllUsers.AutoSize = True
        Me.lblAllUsers.Location = New System.Drawing.Point(12, 9)
        Me.lblAllUsers.Name = "lblAllUsers"
        Me.lblAllUsers.Size = New System.Drawing.Size(74, 18)
        Me.lblAllUsers.TabIndex = 1
        Me.lblAllUsers.Text = "All Users:"
        '
        'btnSetTimer
        '
        Me.btnSetTimer.Location = New System.Drawing.Point(192, 30)
        Me.btnSetTimer.Name = "btnSetTimer"
        Me.btnSetTimer.Size = New System.Drawing.Size(115, 32)
        Me.btnSetTimer.TabIndex = 2
        Me.btnSetTimer.Text = "Set Timer"
        Me.btnSetTimer.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(192, 68)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(115, 32)
        Me.btnAdmin.TabIndex = 4
        Me.btnAdmin.Text = "Set As Admin"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(192, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(192, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(192, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'User_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 234)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnSetTimer)
        Me.Controls.Add(Me.lblAllUsers)
        Me.Controls.Add(Me.lstbxAllUsers)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "User_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstbxAllUsers As System.Windows.Forms.ListBox
    Friend WithEvents lblAllUsers As System.Windows.Forms.Label
    Friend WithEvents btnSetTimer As System.Windows.Forms.Button
    Friend WithEvents btnAdmin As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
