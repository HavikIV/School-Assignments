<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumberOfTickets
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
        Me.btn10Tickets = New System.Windows.Forms.Button()
        Me.btn5Tickets = New System.Windows.Forms.Button()
        Me.btnOneTicket = New System.Windows.Forms.Button()
        Me.btnLuckyTicket = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn10Tickets
        '
        Me.btn10Tickets.Location = New System.Drawing.Point(63, 110)
        Me.btn10Tickets.Name = "btn10Tickets"
        Me.btn10Tickets.Size = New System.Drawing.Size(105, 43)
        Me.btn10Tickets.TabIndex = 7
        Me.btn10Tickets.Text = "10 Tickets"
        Me.btn10Tickets.UseVisualStyleBackColor = True
        '
        'btn5Tickets
        '
        Me.btn5Tickets.Location = New System.Drawing.Point(63, 61)
        Me.btn5Tickets.Name = "btn5Tickets"
        Me.btn5Tickets.Size = New System.Drawing.Size(105, 43)
        Me.btn5Tickets.TabIndex = 6
        Me.btn5Tickets.Text = "5 Tickets"
        Me.btn5Tickets.UseVisualStyleBackColor = True
        '
        'btnOneTicket
        '
        Me.btnOneTicket.Location = New System.Drawing.Point(63, 12)
        Me.btnOneTicket.Name = "btnOneTicket"
        Me.btnOneTicket.Size = New System.Drawing.Size(105, 43)
        Me.btnOneTicket.TabIndex = 5
        Me.btnOneTicket.Text = "1 Ticket"
        Me.btnOneTicket.UseVisualStyleBackColor = True
        '
        'btnLuckyTicket
        '
        Me.btnLuckyTicket.Location = New System.Drawing.Point(63, 159)
        Me.btnLuckyTicket.Name = "btnLuckyTicket"
        Me.btnLuckyTicket.Size = New System.Drawing.Size(105, 43)
        Me.btnLuckyTicket.TabIndex = 8
        Me.btnLuckyTicket.Text = "Lucky Ticket"
        Me.btnLuckyTicket.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(174, 203)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(65, 30)
        Me.btnHome.TabIndex = 9
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'frmNumberOfTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(247, 245)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnLuckyTicket)
        Me.Controls.Add(Me.btn10Tickets)
        Me.Controls.Add(Me.btn5Tickets)
        Me.Controls.Add(Me.btnOneTicket)
        Me.Name = "frmNumberOfTickets"
        Me.Text = "Number of Tickets"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn10Tickets As System.Windows.Forms.Button
    Friend WithEvents btn5Tickets As System.Windows.Forms.Button
    Friend WithEvents btnOneTicket As System.Windows.Forms.Button
    Friend WithEvents btnLuckyTicket As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
End Class
