<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TheaterRevenue
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
        Me.gbxAdultTickets = New System.Windows.Forms.GroupBox()
        Me.txtAdultSold = New System.Windows.Forms.TextBox()
        Me.txtAdultPrice = New System.Windows.Forms.TextBox()
        Me.lblAdultSold = New System.Windows.Forms.Label()
        Me.lblAdultPrice = New System.Windows.Forms.Label()
        Me.gbxChildTickets = New System.Windows.Forms.GroupBox()
        Me.txtChildSold = New System.Windows.Forms.TextBox()
        Me.txtChildPrice = New System.Windows.Forms.TextBox()
        Me.lblChildSold = New System.Windows.Forms.Label()
        Me.lblChildPrice = New System.Windows.Forms.Label()
        Me.gbxGrossRevenue = New System.Windows.Forms.GroupBox()
        Me.lblTotalSales2 = New System.Windows.Forms.Label()
        Me.lblChildSales2 = New System.Windows.Forms.Label()
        Me.lblAdultSales2 = New System.Windows.Forms.Label()
        Me.lblTotalSales = New System.Windows.Forms.Label()
        Me.lblChildSales = New System.Windows.Forms.Label()
        Me.lblAdultSales = New System.Windows.Forms.Label()
        Me.gbxNetRevenue = New System.Windows.Forms.GroupBox()
        Me.lblNetTotal = New System.Windows.Forms.Label()
        Me.lblNetTotal2 = New System.Windows.Forms.Label()
        Me.lblNetChild2 = New System.Windows.Forms.Label()
        Me.lblNetAdult2 = New System.Windows.Forms.Label()
        Me.lblNetChild = New System.Windows.Forms.Label()
        Me.lblNetAdult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblError = New System.Windows.Forms.Label()
        Me.gbxAdultTickets.SuspendLayout()
        Me.gbxChildTickets.SuspendLayout()
        Me.gbxGrossRevenue.SuspendLayout()
        Me.gbxNetRevenue.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxAdultTickets
        '
        Me.gbxAdultTickets.Controls.Add(Me.txtAdultSold)
        Me.gbxAdultTickets.Controls.Add(Me.txtAdultPrice)
        Me.gbxAdultTickets.Controls.Add(Me.lblAdultSold)
        Me.gbxAdultTickets.Controls.Add(Me.lblAdultPrice)
        Me.gbxAdultTickets.Location = New System.Drawing.Point(12, 12)
        Me.gbxAdultTickets.Name = "gbxAdultTickets"
        Me.gbxAdultTickets.Size = New System.Drawing.Size(324, 129)
        Me.gbxAdultTickets.TabIndex = 0
        Me.gbxAdultTickets.TabStop = False
        Me.gbxAdultTickets.Text = "Adult Ticket Sales"
        '
        'txtAdultSold
        '
        Me.txtAdultSold.Location = New System.Drawing.Point(162, 82)
        Me.txtAdultSold.Name = "txtAdultSold"
        Me.txtAdultSold.Size = New System.Drawing.Size(140, 26)
        Me.txtAdultSold.TabIndex = 3
        Me.txtAdultSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAdultPrice
        '
        Me.txtAdultPrice.Location = New System.Drawing.Point(162, 40)
        Me.txtAdultPrice.Name = "txtAdultPrice"
        Me.txtAdultPrice.Size = New System.Drawing.Size(140, 26)
        Me.txtAdultPrice.TabIndex = 2
        Me.txtAdultPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAdultSold
        '
        Me.lblAdultSold.AutoSize = True
        Me.lblAdultSold.Location = New System.Drawing.Point(59, 85)
        Me.lblAdultSold.Name = "lblAdultSold"
        Me.lblAdultSold.Size = New System.Drawing.Size(97, 18)
        Me.lblAdultSold.TabIndex = 1
        Me.lblAdultSold.Text = "Tickets Sold:"
        '
        'lblAdultPrice
        '
        Me.lblAdultPrice.AutoSize = True
        Me.lblAdultPrice.Location = New System.Drawing.Point(35, 43)
        Me.lblAdultPrice.Name = "lblAdultPrice"
        Me.lblAdultPrice.Size = New System.Drawing.Size(121, 18)
        Me.lblAdultPrice.TabIndex = 0
        Me.lblAdultPrice.Text = "Price per Ticket:"
        '
        'gbxChildTickets
        '
        Me.gbxChildTickets.Controls.Add(Me.txtChildSold)
        Me.gbxChildTickets.Controls.Add(Me.txtChildPrice)
        Me.gbxChildTickets.Controls.Add(Me.lblChildSold)
        Me.gbxChildTickets.Controls.Add(Me.lblChildPrice)
        Me.gbxChildTickets.Location = New System.Drawing.Point(365, 12)
        Me.gbxChildTickets.Name = "gbxChildTickets"
        Me.gbxChildTickets.Size = New System.Drawing.Size(324, 129)
        Me.gbxChildTickets.TabIndex = 1
        Me.gbxChildTickets.TabStop = False
        Me.gbxChildTickets.Text = "Child Ticket Sales"
        '
        'txtChildSold
        '
        Me.txtChildSold.Location = New System.Drawing.Point(162, 82)
        Me.txtChildSold.Name = "txtChildSold"
        Me.txtChildSold.Size = New System.Drawing.Size(143, 26)
        Me.txtChildSold.TabIndex = 3
        Me.txtChildSold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtChildPrice
        '
        Me.txtChildPrice.Location = New System.Drawing.Point(162, 40)
        Me.txtChildPrice.Name = "txtChildPrice"
        Me.txtChildPrice.Size = New System.Drawing.Size(143, 26)
        Me.txtChildPrice.TabIndex = 2
        Me.txtChildPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblChildSold
        '
        Me.lblChildSold.AutoSize = True
        Me.lblChildSold.Location = New System.Drawing.Point(51, 85)
        Me.lblChildSold.Name = "lblChildSold"
        Me.lblChildSold.Size = New System.Drawing.Size(97, 18)
        Me.lblChildSold.TabIndex = 1
        Me.lblChildSold.Text = "Tickets Sold:"
        '
        'lblChildPrice
        '
        Me.lblChildPrice.AutoSize = True
        Me.lblChildPrice.Location = New System.Drawing.Point(27, 43)
        Me.lblChildPrice.Name = "lblChildPrice"
        Me.lblChildPrice.Size = New System.Drawing.Size(121, 18)
        Me.lblChildPrice.TabIndex = 0
        Me.lblChildPrice.Text = "Price per Ticket:"
        '
        'gbxGrossRevenue
        '
        Me.gbxGrossRevenue.Controls.Add(Me.lblTotalSales2)
        Me.gbxGrossRevenue.Controls.Add(Me.lblChildSales2)
        Me.gbxGrossRevenue.Controls.Add(Me.lblAdultSales2)
        Me.gbxGrossRevenue.Controls.Add(Me.lblTotalSales)
        Me.gbxGrossRevenue.Controls.Add(Me.lblChildSales)
        Me.gbxGrossRevenue.Controls.Add(Me.lblAdultSales)
        Me.gbxGrossRevenue.Location = New System.Drawing.Point(12, 147)
        Me.gbxGrossRevenue.Name = "gbxGrossRevenue"
        Me.gbxGrossRevenue.Size = New System.Drawing.Size(324, 162)
        Me.gbxGrossRevenue.TabIndex = 2
        Me.gbxGrossRevenue.TabStop = False
        Me.gbxGrossRevenue.Text = "Gross Ticket Revenue"
        '
        'lblTotalSales2
        '
        Me.lblTotalSales2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalSales2.Location = New System.Drawing.Point(177, 111)
        Me.lblTotalSales2.Name = "lblTotalSales2"
        Me.lblTotalSales2.Size = New System.Drawing.Size(125, 30)
        Me.lblTotalSales2.TabIndex = 7
        Me.lblTotalSales2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblChildSales2
        '
        Me.lblChildSales2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblChildSales2.Location = New System.Drawing.Point(177, 72)
        Me.lblChildSales2.Name = "lblChildSales2"
        Me.lblChildSales2.Size = New System.Drawing.Size(125, 30)
        Me.lblChildSales2.TabIndex = 6
        Me.lblChildSales2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAdultSales2
        '
        Me.lblAdultSales2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAdultSales2.Location = New System.Drawing.Point(177, 31)
        Me.lblAdultSales2.Name = "lblAdultSales2"
        Me.lblAdultSales2.Size = New System.Drawing.Size(125, 30)
        Me.lblAdultSales2.TabIndex = 4
        Me.lblAdultSales2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalSales
        '
        Me.lblTotalSales.Location = New System.Drawing.Point(10, 105)
        Me.lblTotalSales.Name = "lblTotalSales"
        Me.lblTotalSales.Size = New System.Drawing.Size(161, 48)
        Me.lblTotalSales.TabIndex = 2
        Me.lblTotalSales.Text = "Total Gross Revenue           for Ticket Sales:"
        '
        'lblChildSales
        '
        Me.lblChildSales.AutoSize = True
        Me.lblChildSales.Location = New System.Drawing.Point(34, 72)
        Me.lblChildSales.Name = "lblChildSales"
        Me.lblChildSales.Size = New System.Drawing.Size(137, 18)
        Me.lblChildSales.TabIndex = 1
        Me.lblChildSales.Text = "Child Ticket Sales:"
        '
        'lblAdultSales
        '
        Me.lblAdultSales.AutoSize = True
        Me.lblAdultSales.Location = New System.Drawing.Point(35, 37)
        Me.lblAdultSales.Name = "lblAdultSales"
        Me.lblAdultSales.Size = New System.Drawing.Size(136, 18)
        Me.lblAdultSales.TabIndex = 0
        Me.lblAdultSales.Text = "Adult Ticket Sales:"
        '
        'gbxNetRevenue
        '
        Me.gbxNetRevenue.Controls.Add(Me.lblNetTotal)
        Me.gbxNetRevenue.Controls.Add(Me.lblNetTotal2)
        Me.gbxNetRevenue.Controls.Add(Me.lblNetChild2)
        Me.gbxNetRevenue.Controls.Add(Me.lblNetAdult2)
        Me.gbxNetRevenue.Controls.Add(Me.lblNetChild)
        Me.gbxNetRevenue.Controls.Add(Me.lblNetAdult)
        Me.gbxNetRevenue.Location = New System.Drawing.Point(365, 147)
        Me.gbxNetRevenue.Name = "gbxNetRevenue"
        Me.gbxNetRevenue.Size = New System.Drawing.Size(324, 162)
        Me.gbxNetRevenue.TabIndex = 3
        Me.gbxNetRevenue.TabStop = False
        Me.gbxNetRevenue.Text = "Net Ticket Revenue"
        '
        'lblNetTotal
        '
        Me.lblNetTotal.Location = New System.Drawing.Point(20, 105)
        Me.lblNetTotal.Name = "lblNetTotal"
        Me.lblNetTotal.Size = New System.Drawing.Size(157, 36)
        Me.lblNetTotal.TabIndex = 11
        Me.lblNetTotal.Text = "Total Net Revenue           for Ticket Sales:"
        '
        'lblNetTotal2
        '
        Me.lblNetTotal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetTotal2.Location = New System.Drawing.Point(180, 111)
        Me.lblNetTotal2.Name = "lblNetTotal2"
        Me.lblNetTotal2.Size = New System.Drawing.Size(125, 30)
        Me.lblNetTotal2.TabIndex = 10
        Me.lblNetTotal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetChild2
        '
        Me.lblNetChild2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetChild2.Location = New System.Drawing.Point(180, 72)
        Me.lblNetChild2.Name = "lblNetChild2"
        Me.lblNetChild2.Size = New System.Drawing.Size(125, 30)
        Me.lblNetChild2.TabIndex = 9
        Me.lblNetChild2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetAdult2
        '
        Me.lblNetAdult2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNetAdult2.Location = New System.Drawing.Point(180, 31)
        Me.lblNetAdult2.Name = "lblNetAdult2"
        Me.lblNetAdult2.Size = New System.Drawing.Size(125, 30)
        Me.lblNetAdult2.TabIndex = 8
        Me.lblNetAdult2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNetChild
        '
        Me.lblNetChild.AutoSize = True
        Me.lblNetChild.Location = New System.Drawing.Point(19, 72)
        Me.lblNetChild.Name = "lblNetChild"
        Me.lblNetChild.Size = New System.Drawing.Size(137, 18)
        Me.lblNetChild.TabIndex = 1
        Me.lblNetChild.Text = "Child Ticket Sales:"
        '
        'lblNetAdult
        '
        Me.lblNetAdult.AutoSize = True
        Me.lblNetAdult.Location = New System.Drawing.Point(20, 37)
        Me.lblNetAdult.Name = "lblNetAdult"
        Me.lblNetAdult.Size = New System.Drawing.Size(136, 18)
        Me.lblNetAdult.TabIndex = 0
        Me.lblNetAdult.Text = "Adult Ticket Sales:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(89, 330)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(200, 34)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate Ticket Revenue"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(344, 330)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(109, 34)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(518, 330)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(109, 34)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblError
        '
        Me.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblError.Location = New System.Drawing.Point(0, 367)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(704, 32)
        Me.lblError.TabIndex = 7
        '
        'TheaterRevenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(703, 397)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.gbxNetRevenue)
        Me.Controls.Add(Me.gbxGrossRevenue)
        Me.Controls.Add(Me.gbxChildTickets)
        Me.Controls.Add(Me.gbxAdultTickets)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TheaterRevenue"
        Me.Text = "Movie Revenues"
        Me.gbxAdultTickets.ResumeLayout(False)
        Me.gbxAdultTickets.PerformLayout()
        Me.gbxChildTickets.ResumeLayout(False)
        Me.gbxChildTickets.PerformLayout()
        Me.gbxGrossRevenue.ResumeLayout(False)
        Me.gbxGrossRevenue.PerformLayout()
        Me.gbxNetRevenue.ResumeLayout(False)
        Me.gbxNetRevenue.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxAdultTickets As System.Windows.Forms.GroupBox
    Friend WithEvents txtAdultSold As System.Windows.Forms.TextBox
    Friend WithEvents txtAdultPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblAdultSold As System.Windows.Forms.Label
    Friend WithEvents lblAdultPrice As System.Windows.Forms.Label
    Friend WithEvents gbxChildTickets As System.Windows.Forms.GroupBox
    Friend WithEvents txtChildSold As System.Windows.Forms.TextBox
    Friend WithEvents txtChildPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblChildSold As System.Windows.Forms.Label
    Friend WithEvents lblChildPrice As System.Windows.Forms.Label
    Friend WithEvents gbxGrossRevenue As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalSales2 As System.Windows.Forms.Label
    Friend WithEvents lblChildSales2 As System.Windows.Forms.Label
    Friend WithEvents lblAdultSales2 As System.Windows.Forms.Label
    Friend WithEvents lblTotalSales As System.Windows.Forms.Label
    Friend WithEvents lblChildSales As System.Windows.Forms.Label
    Friend WithEvents lblAdultSales As System.Windows.Forms.Label
    Friend WithEvents gbxNetRevenue As System.Windows.Forms.GroupBox
    Friend WithEvents lblNetChild As System.Windows.Forms.Label
    Friend WithEvents lblNetAdult As System.Windows.Forms.Label
    Friend WithEvents lblNetTotal2 As System.Windows.Forms.Label
    Friend WithEvents lblNetChild2 As System.Windows.Forms.Label
    Friend WithEvents lblNetAdult2 As System.Windows.Forms.Label
    Friend WithEvents lblNetTotal As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lblError As System.Windows.Forms.Label

End Class
