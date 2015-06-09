<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HallLights
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HallLights))
        Me.pbOn = New System.Windows.Forms.PictureBox()
        Me.pbOff = New System.Windows.Forms.PictureBox()
        Me.btnSwitch1 = New System.Windows.Forms.Button()
        Me.btnSwitch2 = New System.Windows.Forms.Button()
        CType(Me.pbOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbOff, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbOn
        '
        Me.pbOn.BackgroundImage = CType(resources.GetObject("pbOn.BackgroundImage"), System.Drawing.Image)
        Me.pbOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbOn.Location = New System.Drawing.Point(69, 39)
        Me.pbOn.Name = "pbOn"
        Me.pbOn.Size = New System.Drawing.Size(227, 290)
        Me.pbOn.TabIndex = 0
        Me.pbOn.TabStop = False
        '
        'pbOff
        '
        Me.pbOff.BackgroundImage = CType(resources.GetObject("pbOff.BackgroundImage"), System.Drawing.Image)
        Me.pbOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbOff.Location = New System.Drawing.Point(321, 39)
        Me.pbOff.Name = "pbOff"
        Me.pbOff.Size = New System.Drawing.Size(198, 290)
        Me.pbOff.TabIndex = 1
        Me.pbOff.TabStop = False
        Me.pbOff.Visible = False
        '
        'btnSwitch1
        '
        Me.btnSwitch1.Location = New System.Drawing.Point(116, 335)
        Me.btnSwitch1.Name = "btnSwitch1"
        Me.btnSwitch1.Size = New System.Drawing.Size(144, 59)
        Me.btnSwitch1.TabIndex = 2
        Me.btnSwitch1.Text = "ON"
        Me.btnSwitch1.UseVisualStyleBackColor = True
        '
        'btnSwitch2
        '
        Me.btnSwitch2.Location = New System.Drawing.Point(343, 335)
        Me.btnSwitch2.Name = "btnSwitch2"
        Me.btnSwitch2.Size = New System.Drawing.Size(144, 59)
        Me.btnSwitch2.TabIndex = 3
        Me.btnSwitch2.Text = "OFF"
        Me.btnSwitch2.UseVisualStyleBackColor = True
        '
        'HallLights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 508)
        Me.Controls.Add(Me.btnSwitch2)
        Me.Controls.Add(Me.btnSwitch1)
        Me.Controls.Add(Me.pbOff)
        Me.Controls.Add(Me.pbOn)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "HallLights"
        Me.Text = "Hall Lights"
        CType(Me.pbOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbOff, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbOn As System.Windows.Forms.PictureBox
    Friend WithEvents pbOff As System.Windows.Forms.PictureBox
    Friend WithEvents btnSwitch1 As System.Windows.Forms.Button
    Friend WithEvents btnSwitch2 As System.Windows.Forms.Button

End Class
