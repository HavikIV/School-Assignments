<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Me.lblStore1 = New System.Windows.Forms.Label()
        Me.lblStore2 = New System.Windows.Forms.Label()
        Me.lblStore3 = New System.Windows.Forms.Label()
        Me.lblStore4 = New System.Windows.Forms.Label()
        Me.lblStore5 = New System.Windows.Forms.Label()
        Me.txtStore1 = New System.Windows.Forms.TextBox()
        Me.txtStore2 = New System.Windows.Forms.TextBox()
        Me.txtStore3 = New System.Windows.Forms.TextBox()
        Me.txtStore4 = New System.Windows.Forms.TextBox()
        Me.txtStore5 = New System.Windows.Forms.TextBox()
        Me.lbxChart = New System.Windows.Forms.ListBox()
        Me.btnChart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblStore1
        '
        Me.lblStore1.AutoSize = True
        Me.lblStore1.Location = New System.Drawing.Point(28, 28)
        Me.lblStore1.Name = "lblStore1"
        Me.lblStore1.Size = New System.Drawing.Size(63, 18)
        Me.lblStore1.TabIndex = 0
        Me.lblStore1.Text = "Store 1:"
        '
        'lblStore2
        '
        Me.lblStore2.AutoSize = True
        Me.lblStore2.Location = New System.Drawing.Point(28, 60)
        Me.lblStore2.Name = "lblStore2"
        Me.lblStore2.Size = New System.Drawing.Size(63, 18)
        Me.lblStore2.TabIndex = 1
        Me.lblStore2.Text = "Store 2:"
        '
        'lblStore3
        '
        Me.lblStore3.AutoSize = True
        Me.lblStore3.Location = New System.Drawing.Point(28, 92)
        Me.lblStore3.Name = "lblStore3"
        Me.lblStore3.Size = New System.Drawing.Size(63, 18)
        Me.lblStore3.TabIndex = 2
        Me.lblStore3.Text = "Store 3:"
        '
        'lblStore4
        '
        Me.lblStore4.AutoSize = True
        Me.lblStore4.Location = New System.Drawing.Point(28, 124)
        Me.lblStore4.Name = "lblStore4"
        Me.lblStore4.Size = New System.Drawing.Size(63, 18)
        Me.lblStore4.TabIndex = 3
        Me.lblStore4.Text = "Store 4:"
        '
        'lblStore5
        '
        Me.lblStore5.AutoSize = True
        Me.lblStore5.Location = New System.Drawing.Point(28, 156)
        Me.lblStore5.Name = "lblStore5"
        Me.lblStore5.Size = New System.Drawing.Size(63, 18)
        Me.lblStore5.TabIndex = 4
        Me.lblStore5.Text = "Store 5:"
        '
        'txtStore1
        '
        Me.txtStore1.Location = New System.Drawing.Point(205, 25)
        Me.txtStore1.Name = "txtStore1"
        Me.txtStore1.Size = New System.Drawing.Size(100, 26)
        Me.txtStore1.TabIndex = 5
        '
        'txtStore2
        '
        Me.txtStore2.Location = New System.Drawing.Point(205, 57)
        Me.txtStore2.Name = "txtStore2"
        Me.txtStore2.Size = New System.Drawing.Size(100, 26)
        Me.txtStore2.TabIndex = 6
        '
        'txtStore3
        '
        Me.txtStore3.Location = New System.Drawing.Point(205, 89)
        Me.txtStore3.Name = "txtStore3"
        Me.txtStore3.Size = New System.Drawing.Size(100, 26)
        Me.txtStore3.TabIndex = 7
        '
        'txtStore4
        '
        Me.txtStore4.Location = New System.Drawing.Point(205, 121)
        Me.txtStore4.Name = "txtStore4"
        Me.txtStore4.Size = New System.Drawing.Size(100, 26)
        Me.txtStore4.TabIndex = 8
        '
        'txtStore5
        '
        Me.txtStore5.Location = New System.Drawing.Point(205, 153)
        Me.txtStore5.Name = "txtStore5"
        Me.txtStore5.Size = New System.Drawing.Size(100, 26)
        Me.txtStore5.TabIndex = 9
        '
        'lbxChart
        '
        Me.lbxChart.FormattingEnabled = True
        Me.lbxChart.ItemHeight = 18
        Me.lbxChart.Location = New System.Drawing.Point(31, 25)
        Me.lbxChart.Name = "lbxChart"
        Me.lbxChart.Size = New System.Drawing.Size(274, 148)
        Me.lbxChart.TabIndex = 10
        Me.lbxChart.Visible = False
        '
        'btnChart
        '
        Me.btnChart.Location = New System.Drawing.Point(31, 196)
        Me.btnChart.Name = "btnChart"
        Me.btnChart.Size = New System.Drawing.Size(122, 44)
        Me.btnChart.TabIndex = 11
        Me.btnChart.Text = "Display Chart"
        Me.btnChart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(181, 196)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 44)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnChart)
        Me.Controls.Add(Me.lbxChart)
        Me.Controls.Add(Me.txtStore5)
        Me.Controls.Add(Me.txtStore4)
        Me.Controls.Add(Me.txtStore3)
        Me.Controls.Add(Me.txtStore2)
        Me.Controls.Add(Me.txtStore1)
        Me.Controls.Add(Me.lblStore5)
        Me.Controls.Add(Me.lblStore4)
        Me.Controls.Add(Me.lblStore3)
        Me.Controls.Add(Me.lblStore2)
        Me.Controls.Add(Me.lblStore1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Sales"
        Me.Text = "Store Sales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStore1 As System.Windows.Forms.Label
    Friend WithEvents lblStore2 As System.Windows.Forms.Label
    Friend WithEvents lblStore3 As System.Windows.Forms.Label
    Friend WithEvents lblStore4 As System.Windows.Forms.Label
    Friend WithEvents lblStore5 As System.Windows.Forms.Label
    Friend WithEvents txtStore1 As System.Windows.Forms.TextBox
    Friend WithEvents txtStore2 As System.Windows.Forms.TextBox
    Friend WithEvents txtStore3 As System.Windows.Forms.TextBox
    Friend WithEvents txtStore4 As System.Windows.Forms.TextBox
    Friend WithEvents txtStore5 As System.Windows.Forms.TextBox
    Friend WithEvents lbxChart As System.Windows.Forms.ListBox
    Friend WithEvents btnChart As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
