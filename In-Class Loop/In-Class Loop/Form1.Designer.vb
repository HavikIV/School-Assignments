<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multi
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
        Me.rtbMulti = New System.Windows.Forms.RichTextBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'rtbMulti
        '
        Me.rtbMulti.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbMulti.Location = New System.Drawing.Point(12, 12)
        Me.rtbMulti.Name = "rtbMulti"
        Me.rtbMulti.Size = New System.Drawing.Size(478, 274)
        Me.rtbMulti.TabIndex = 4
        Me.rtbMulti.Text = ""
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(-1, 381)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(501, 23)
        Me.lblError.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(28, 344)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(95, 34)
        Me.btnGo.TabIndex = 1
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(202, 344)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 34)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(371, 344)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(95, 34)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(50, 308)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(171, 20)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Enter a Number (1-12):"
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(287, 305)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 26)
        Me.txtNumber.TabIndex = 0
        Me.txtNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Multi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 407)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.rtbMulti)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Multi"
        Me.Text = "Multiplication Tables"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbMulti As System.Windows.Forms.RichTextBox
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox

End Class
