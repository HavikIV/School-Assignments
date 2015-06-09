<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblWebAddress = New System.Windows.Forms.Label()
        Me.txtWebAddress = New System.Windows.Forms.TextBox()
        Me.btnGO = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.btnGoBack = New System.Windows.Forms.Button()
        Me.btnHomepage = New System.Windows.Forms.Button()
        Me.btnGoForward = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblWebAddress
        '
        Me.lblWebAddress.AutoSize = True
        Me.lblWebAddress.Location = New System.Drawing.Point(409, 15)
        Me.lblWebAddress.Name = "lblWebAddress"
        Me.lblWebAddress.Size = New System.Drawing.Size(109, 20)
        Me.lblWebAddress.TabIndex = 0
        Me.lblWebAddress.Text = "Web Address:"
        '
        'txtWebAddress
        '
        Me.txtWebAddress.Location = New System.Drawing.Point(524, 15)
        Me.txtWebAddress.Name = "txtWebAddress"
        Me.txtWebAddress.Size = New System.Drawing.Size(776, 26)
        Me.txtWebAddress.TabIndex = 1
        '
        'btnGO
        '
        Me.btnGO.Location = New System.Drawing.Point(1306, 8)
        Me.btnGO.Name = "btnGO"
        Me.btnGO.Size = New System.Drawing.Size(83, 34)
        Me.btnGO.TabIndex = 2
        Me.btnGO.Text = "Go"
        Me.btnGO.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(-2, 52)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1403, 812)
        Me.WebBrowser1.TabIndex = 3
        '
        'btnGoBack
        '
        Me.btnGoBack.Location = New System.Drawing.Point(118, 8)
        Me.btnGoBack.Name = "btnGoBack"
        Me.btnGoBack.Size = New System.Drawing.Size(84, 34)
        Me.btnGoBack.TabIndex = 4
        Me.btnGoBack.Text = "Go Back"
        Me.btnGoBack.UseVisualStyleBackColor = True
        '
        'btnHomepage
        '
        Me.btnHomepage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHomepage.Location = New System.Drawing.Point(15, 8)
        Me.btnHomepage.Name = "btnHomepage"
        Me.btnHomepage.Size = New System.Drawing.Size(97, 34)
        Me.btnHomepage.TabIndex = 5
        Me.btnHomepage.Text = "Homepage"
        Me.btnHomepage.UseVisualStyleBackColor = True
        '
        'btnGoForward
        '
        Me.btnGoForward.Location = New System.Drawing.Point(208, 8)
        Me.btnGoForward.Name = "btnGoForward"
        Me.btnGoForward.Size = New System.Drawing.Size(103, 34)
        Me.btnGoForward.TabIndex = 6
        Me.btnGoForward.Text = "Go Forward"
        Me.btnGoForward.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(317, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(86, 34)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1401, 876)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnGoForward)
        Me.Controls.Add(Me.btnHomepage)
        Me.Controls.Add(Me.btnGoBack)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnGO)
        Me.Controls.Add(Me.txtWebAddress)
        Me.Controls.Add(Me.lblWebAddress)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Web Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWebAddress As System.Windows.Forms.Label
    Friend WithEvents txtWebAddress As System.Windows.Forms.TextBox
    Friend WithEvents btnGO As System.Windows.Forms.Button
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents btnGoBack As System.Windows.Forms.Button
    Friend WithEvents btnHomepage As System.Windows.Forms.Button
    Friend WithEvents btnGoForward As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button

End Class
