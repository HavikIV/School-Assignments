<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CellPhoneForm
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
        Me.gbxPlanSelection = New System.Windows.Forms.GroupBox()
        Me.btnFamily = New System.Windows.Forms.Button()
        Me.btnIndividual = New System.Windows.Forms.Button()
        Me.lblFamily = New System.Windows.Forms.Label()
        Me.lblIndividual = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbxPlanSelection.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxPlanSelection
        '
        Me.gbxPlanSelection.Controls.Add(Me.btnFamily)
        Me.gbxPlanSelection.Controls.Add(Me.btnIndividual)
        Me.gbxPlanSelection.Controls.Add(Me.lblFamily)
        Me.gbxPlanSelection.Controls.Add(Me.lblIndividual)
        Me.gbxPlanSelection.Location = New System.Drawing.Point(12, 12)
        Me.gbxPlanSelection.Name = "gbxPlanSelection"
        Me.gbxPlanSelection.Size = New System.Drawing.Size(429, 186)
        Me.gbxPlanSelection.TabIndex = 0
        Me.gbxPlanSelection.TabStop = False
        Me.gbxPlanSelection.Text = "Select a Plan"
        '
        'btnFamily
        '
        Me.btnFamily.Location = New System.Drawing.Point(321, 117)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.Size = New System.Drawing.Size(81, 29)
        Me.btnFamily.TabIndex = 3
        Me.btnFamily.Text = "Family"
        Me.btnFamily.UseVisualStyleBackColor = True
        '
        'btnIndividual
        '
        Me.btnIndividual.Location = New System.Drawing.Point(321, 37)
        Me.btnIndividual.Name = "btnIndividual"
        Me.btnIndividual.Size = New System.Drawing.Size(81, 29)
        Me.btnIndividual.TabIndex = 2
        Me.btnIndividual.Text = "Individual"
        Me.btnIndividual.UseVisualStyleBackColor = True
        '
        'lblFamily
        '
        Me.lblFamily.Location = New System.Drawing.Point(28, 96)
        Me.lblFamily.Name = "lblFamily"
        Me.lblFamily.Size = New System.Drawing.Size(245, 76)
        Me.lblFamily.TabIndex = 1
        Me.lblFamily.Text = "The Family plan allows you to purchase mulitple cell phones of the same model, wi" & _
    "th each phone sharing one monthly package."
        '
        'lblIndividual
        '
        Me.lblIndividual.Location = New System.Drawing.Point(28, 22)
        Me.lblIndividual.Name = "lblIndividual"
        Me.lblIndividual.Size = New System.Drawing.Size(236, 63)
        Me.lblIndividual.TabIndex = 0
        Me.lblIndividual.Text = "The Individual plan provides one cell phone and a variety of monthly packages."
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(333, 211)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(81, 29)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'CellPhoneForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 252)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gbxPlanSelection)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CellPhoneForm"
        Me.Text = "Cell Phone Packages"
        Me.gbxPlanSelection.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxPlanSelection As System.Windows.Forms.GroupBox
    Friend WithEvents btnFamily As System.Windows.Forms.Button
    Friend WithEvents btnIndividual As System.Windows.Forms.Button
    Friend WithEvents lblFamily As System.Windows.Forms.Label
    Friend WithEvents lblIndividual As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
