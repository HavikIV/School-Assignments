<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLotteryTickets
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLotteryTickets))
        Me.btnSuperLotto = New System.Windows.Forms.Button()
        Me.btnMegaMillions = New System.Windows.Forms.Button()
        Me.btnPowerball = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSuperLotto
        '
        Me.btnSuperLotto.Image = CType(resources.GetObject("btnSuperLotto.Image"), System.Drawing.Image)
        Me.btnSuperLotto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSuperLotto.Location = New System.Drawing.Point(42, 12)
        Me.btnSuperLotto.Name = "btnSuperLotto"
        Me.btnSuperLotto.Size = New System.Drawing.Size(160, 51)
        Me.btnSuperLotto.TabIndex = 0
        Me.btnSuperLotto.UseVisualStyleBackColor = True
        '
        'btnMegaMillions
        '
        Me.btnMegaMillions.Image = CType(resources.GetObject("btnMegaMillions.Image"), System.Drawing.Image)
        Me.btnMegaMillions.Location = New System.Drawing.Point(42, 69)
        Me.btnMegaMillions.Name = "btnMegaMillions"
        Me.btnMegaMillions.Size = New System.Drawing.Size(160, 51)
        Me.btnMegaMillions.TabIndex = 2
        Me.btnMegaMillions.UseVisualStyleBackColor = True
        '
        'btnPowerball
        '
        Me.btnPowerball.Image = CType(resources.GetObject("btnPowerball.Image"), System.Drawing.Image)
        Me.btnPowerball.Location = New System.Drawing.Point(42, 126)
        Me.btnPowerball.Name = "btnPowerball"
        Me.btnPowerball.Size = New System.Drawing.Size(160, 51)
        Me.btnPowerball.TabIndex = 4
        Me.btnPowerball.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(159, 193)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmLotteryTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 245)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPowerball)
        Me.Controls.Add(Me.btnMegaMillions)
        Me.Controls.Add(Me.btnSuperLotto)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLotteryTickets"
        Me.Text = "Lottery Tickets"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSuperLotto As System.Windows.Forms.Button
    Friend WithEvents btnMegaMillions As System.Windows.Forms.Button
    Friend WithEvents btnPowerball As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
