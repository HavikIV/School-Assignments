<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRamainingTime
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRamainingTime))
        Me.timerseconds = New System.Windows.Forms.Timer(Me.components)
        Me.lblSecondsRemaining = New System.Windows.Forms.Label()
        Me.lblMintuesRemaining = New System.Windows.Forms.Label()
        Me.lblHoursRemaining = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SuspendLayout()
        '
        'timerseconds
        '
        Me.timerseconds.Interval = 1000
        '
        'lblSecondsRemaining
        '
        Me.lblSecondsRemaining.AutoSize = True
        Me.lblSecondsRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSecondsRemaining.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondsRemaining.Location = New System.Drawing.Point(178, 25)
        Me.lblSecondsRemaining.Name = "lblSecondsRemaining"
        Me.lblSecondsRemaining.Size = New System.Drawing.Size(2, 35)
        Me.lblSecondsRemaining.TabIndex = 0
        '
        'lblMintuesRemaining
        '
        Me.lblMintuesRemaining.AutoSize = True
        Me.lblMintuesRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMintuesRemaining.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMintuesRemaining.Location = New System.Drawing.Point(90, 25)
        Me.lblMintuesRemaining.Name = "lblMintuesRemaining"
        Me.lblMintuesRemaining.Size = New System.Drawing.Size(2, 35)
        Me.lblMintuesRemaining.TabIndex = 1
        '
        'lblHoursRemaining
        '
        Me.lblHoursRemaining.AutoSize = True
        Me.lblHoursRemaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblHoursRemaining.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursRemaining.Location = New System.Drawing.Point(12, 25)
        Me.lblHoursRemaining.Name = "lblHoursRemaining"
        Me.lblHoursRemaining.Size = New System.Drawing.Size(2, 35)
        Me.lblHoursRemaining.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = ":"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'frmRamainingTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(239, 87)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHoursRemaining)
        Me.Controls.Add(Me.lblMintuesRemaining)
        Me.Controls.Add(Me.lblSecondsRemaining)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmRamainingTime"
        Me.Text = "Time Remaining"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timerseconds As System.Windows.Forms.Timer
    Friend WithEvents lblSecondsRemaining As System.Windows.Forms.Label
    Friend WithEvents lblMintuesRemaining As System.Windows.Forms.Label
    Friend WithEvents lblHoursRemaining As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon

End Class
