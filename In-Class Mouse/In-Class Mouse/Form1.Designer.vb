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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblX = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BrushToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstRed = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstBlack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstYellow = New System.Windows.Forms.ToolStripMenuItem()
        Me.SizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Color = New System.Windows.Forms.GroupBox()
        Me.rbYellow = New System.Windows.Forms.RadioButton()
        Me.rbBlack = New System.Windows.Forms.RadioButton()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.grbSize = New System.Windows.Forms.GroupBox()
        Me.rb18 = New System.Windows.Forms.RadioButton()
        Me.rb16 = New System.Windows.Forms.RadioButton()
        Me.rb12 = New System.Windows.Forms.RadioButton()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Color.SuspendLayout()
        Me.grbSize.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(12, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(402, 247)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X-Coordinate:"
        '
        'lblX
        '
        Me.lblX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblX.Location = New System.Drawing.Point(124, 313)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(61, 24)
        Me.lblX.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(217, 314)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Y-Coordinate:"
        '
        'lblY
        '
        Me.lblY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblY.Location = New System.Drawing.Point(326, 313)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(61, 24)
        Me.lblY.TabIndex = 4
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.BrushToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(643, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BrushToolStripMenuItem
        '
        Me.BrushToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.SizeToolStripMenuItem})
        Me.BrushToolStripMenuItem.Name = "BrushToolStripMenuItem"
        Me.BrushToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.BrushToolStripMenuItem.Text = "Brush"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mstRed, Me.mstBlack, Me.mstYellow})
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'mstRed
        '
        Me.mstRed.Name = "mstRed"
        Me.mstRed.Size = New System.Drawing.Size(152, 22)
        Me.mstRed.Text = "Red"
        '
        'mstBlack
        '
        Me.mstBlack.Checked = True
        Me.mstBlack.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mstBlack.Name = "mstBlack"
        Me.mstBlack.Size = New System.Drawing.Size(152, 22)
        Me.mstBlack.Text = "Black"
        '
        'mstYellow
        '
        Me.mstYellow.Name = "mstYellow"
        Me.mstYellow.Size = New System.Drawing.Size(152, 22)
        Me.mstYellow.Text = "Yellow"
        '
        'SizeToolStripMenuItem
        '
        Me.SizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi12, Me.tsmi16, Me.tsmi18})
        Me.SizeToolStripMenuItem.Name = "SizeToolStripMenuItem"
        Me.SizeToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SizeToolStripMenuItem.Text = "Size"
        '
        'tsmi12
        '
        Me.tsmi12.Checked = True
        Me.tsmi12.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsmi12.Name = "tsmi12"
        Me.tsmi12.Size = New System.Drawing.Size(152, 22)
        Me.tsmi12.Text = "12"
        '
        'tsmi16
        '
        Me.tsmi16.Name = "tsmi16"
        Me.tsmi16.Size = New System.Drawing.Size(152, 22)
        Me.tsmi16.Text = "16"
        '
        'tsmi18
        '
        Me.tsmi18.Name = "tsmi18"
        Me.tsmi18.Size = New System.Drawing.Size(152, 22)
        Me.tsmi18.Text = "18"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(436, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 39)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Color
        '
        Me.Color.Controls.Add(Me.rbYellow)
        Me.Color.Controls.Add(Me.rbBlack)
        Me.Color.Controls.Add(Me.rbRed)
        Me.Color.Location = New System.Drawing.Point(436, 41)
        Me.Color.Name = "Color"
        Me.Color.Size = New System.Drawing.Size(98, 118)
        Me.Color.TabIndex = 7
        Me.Color.TabStop = False
        Me.Color.Text = "Color"
        '
        'rbYellow
        '
        Me.rbYellow.AutoSize = True
        Me.rbYellow.Location = New System.Drawing.Point(14, 83)
        Me.rbYellow.Name = "rbYellow"
        Me.rbYellow.Size = New System.Drawing.Size(69, 22)
        Me.rbYellow.TabIndex = 2
        Me.rbYellow.Text = "Yellow"
        Me.rbYellow.UseVisualStyleBackColor = True
        '
        'rbBlack
        '
        Me.rbBlack.AutoSize = True
        Me.rbBlack.Checked = True
        Me.rbBlack.Location = New System.Drawing.Point(13, 55)
        Me.rbBlack.Name = "rbBlack"
        Me.rbBlack.Size = New System.Drawing.Size(65, 22)
        Me.rbBlack.TabIndex = 1
        Me.rbBlack.TabStop = True
        Me.rbBlack.Text = "Black"
        Me.rbBlack.UseVisualStyleBackColor = True
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(14, 27)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(55, 22)
        Me.rbRed.TabIndex = 0
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'grbSize
        '
        Me.grbSize.Controls.Add(Me.rb18)
        Me.grbSize.Controls.Add(Me.rb16)
        Me.grbSize.Controls.Add(Me.rb12)
        Me.grbSize.Location = New System.Drawing.Point(540, 41)
        Me.grbSize.Name = "grbSize"
        Me.grbSize.Size = New System.Drawing.Size(98, 118)
        Me.grbSize.TabIndex = 8
        Me.grbSize.TabStop = False
        Me.grbSize.Text = "Size"
        '
        'rb18
        '
        Me.rb18.AutoSize = True
        Me.rb18.Location = New System.Drawing.Point(13, 83)
        Me.rb18.Name = "rb18"
        Me.rb18.Size = New System.Drawing.Size(44, 22)
        Me.rb18.TabIndex = 2
        Me.rb18.Text = "18"
        Me.rb18.UseVisualStyleBackColor = True
        '
        'rb16
        '
        Me.rb16.AutoSize = True
        Me.rb16.Location = New System.Drawing.Point(13, 55)
        Me.rb16.Name = "rb16"
        Me.rb16.Size = New System.Drawing.Size(44, 22)
        Me.rb16.TabIndex = 1
        Me.rb16.Text = "16"
        Me.rb16.UseVisualStyleBackColor = True
        '
        'rb12
        '
        Me.rb12.AutoSize = True
        Me.rb12.Checked = True
        Me.rb12.Location = New System.Drawing.Point(13, 27)
        Me.rb12.Name = "rb12"
        Me.rb12.Size = New System.Drawing.Size(44, 22)
        Me.rb12.TabIndex = 0
        Me.rb12.TabStop = True
        Me.rb12.Text = "12"
        Me.rb12.UseVisualStyleBackColor = True
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(436, 249)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 39)
        Me.btnChange.TabIndex = 9
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 363)
        Me.Controls.Add(Me.btnChange)
        Me.Controls.Add(Me.grbSize)
        Me.Controls.Add(Me.Color)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Color.ResumeLayout(False)
        Me.Color.PerformLayout()
        Me.grbSize.ResumeLayout(False)
        Me.grbSize.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblX As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblY As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BrushToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mstRed As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mstBlack As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mstYellow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi18 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Color As System.Windows.Forms.GroupBox
    Friend WithEvents rbYellow As System.Windows.Forms.RadioButton
    Friend WithEvents rbBlack As System.Windows.Forms.RadioButton
    Friend WithEvents rbRed As System.Windows.Forms.RadioButton
    Friend WithEvents grbSize As System.Windows.Forms.GroupBox
    Friend WithEvents rb18 As System.Windows.Forms.RadioButton
    Friend WithEvents rb16 As System.Windows.Forms.RadioButton
    Friend WithEvents rb12 As System.Windows.Forms.RadioButton
    Friend WithEvents btnChange As System.Windows.Forms.Button

End Class
