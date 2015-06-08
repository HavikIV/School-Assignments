<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FamilyForm
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
        Me.gbxTotals = New System.Windows.Forms.GroupBox()
        Me.lblMonthlyCharge = New System.Windows.Forms.Label()
        Me.lblMonthly = New System.Windows.Forms.Label()
        Me.lblPackCharge = New System.Windows.Forms.Label()
        Me.lblPCharge = New System.Windows.Forms.Label()
        Me.lblOptions = New System.Windows.Forms.Label()
        Me.lblOp = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPhoneTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblTaxs = New System.Windows.Forms.Label()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.gbxPackage = New System.Windows.Forms.GroupBox()
        Me.rdbUnlimted = New System.Windows.Forms.RadioButton()
        Me.rdb1500Minutes = New System.Windows.Forms.RadioButton()
        Me.rdb800Minutes = New System.Windows.Forms.RadioButton()
        Me.gbxOptions = New System.Windows.Forms.GroupBox()
        Me.cbxText = New System.Windows.Forms.CheckBox()
        Me.cbxEmail = New System.Windows.Forms.CheckBox()
        Me.gbxPhone = New System.Windows.Forms.GroupBox()
        Me.rdb200 = New System.Windows.Forms.RadioButton()
        Me.rdbM110 = New System.Windows.Forms.RadioButton()
        Me.rdbM100 = New System.Windows.Forms.RadioButton()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.txtPhones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbxTotals.SuspendLayout()
        Me.gbxPackage.SuspendLayout()
        Me.gbxOptions.SuspendLayout()
        Me.gbxPhone.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbxTotals
        '
        Me.gbxTotals.Controls.Add(Me.lblMonthlyCharge)
        Me.gbxTotals.Controls.Add(Me.lblMonthly)
        Me.gbxTotals.Controls.Add(Me.lblPackCharge)
        Me.gbxTotals.Controls.Add(Me.lblPCharge)
        Me.gbxTotals.Controls.Add(Me.lblOptions)
        Me.gbxTotals.Controls.Add(Me.lblOp)
        Me.gbxTotals.Controls.Add(Me.lblTotal)
        Me.gbxTotals.Controls.Add(Me.lblPhoneTotal)
        Me.gbxTotals.Controls.Add(Me.lblTax)
        Me.gbxTotals.Controls.Add(Me.lblTaxs)
        Me.gbxTotals.Controls.Add(Me.lblSubtotal)
        Me.gbxTotals.Controls.Add(Me.lblPhone)
        Me.gbxTotals.Location = New System.Drawing.Point(218, 170)
        Me.gbxTotals.Name = "gbxTotals"
        Me.gbxTotals.Size = New System.Drawing.Size(241, 239)
        Me.gbxTotals.TabIndex = 11
        Me.gbxTotals.TabStop = False
        Me.gbxTotals.Text = "Totals"
        '
        'lblMonthlyCharge
        '
        Me.lblMonthlyCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMonthlyCharge.Location = New System.Drawing.Point(149, 199)
        Me.lblMonthlyCharge.Name = "lblMonthlyCharge"
        Me.lblMonthlyCharge.Size = New System.Drawing.Size(72, 26)
        Me.lblMonthlyCharge.TabIndex = 11
        Me.lblMonthlyCharge.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMonthly
        '
        Me.lblMonthly.Location = New System.Drawing.Point(44, 190)
        Me.lblMonthly.Name = "lblMonthly"
        Me.lblMonthly.Size = New System.Drawing.Size(99, 40)
        Me.lblMonthly.TabIndex = 10
        Me.lblMonthly.Text = "Total Monthly         Charge:"
        '
        'lblPackCharge
        '
        Me.lblPackCharge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPackCharge.Location = New System.Drawing.Point(149, 164)
        Me.lblPackCharge.Name = "lblPackCharge"
        Me.lblPackCharge.Size = New System.Drawing.Size(72, 26)
        Me.lblPackCharge.TabIndex = 9
        Me.lblPackCharge.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPCharge
        '
        Me.lblPCharge.AutoSize = True
        Me.lblPCharge.Location = New System.Drawing.Point(12, 165)
        Me.lblPCharge.Name = "lblPCharge"
        Me.lblPCharge.Size = New System.Drawing.Size(131, 18)
        Me.lblPCharge.TabIndex = 8
        Me.lblPCharge.Text = "Package Charge:"
        '
        'lblOptions
        '
        Me.lblOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOptions.Location = New System.Drawing.Point(149, 126)
        Me.lblOptions.Name = "lblOptions"
        Me.lblOptions.Size = New System.Drawing.Size(72, 26)
        Me.lblOptions.TabIndex = 7
        Me.lblOptions.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblOp
        '
        Me.lblOp.AutoSize = True
        Me.lblOp.Location = New System.Drawing.Point(77, 127)
        Me.lblOp.Name = "lblOp"
        Me.lblOp.Size = New System.Drawing.Size(66, 18)
        Me.lblOp.TabIndex = 6
        Me.lblOp.Text = "Options:"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(149, 91)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(72, 26)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPhoneTotal
        '
        Me.lblPhoneTotal.AutoSize = True
        Me.lblPhoneTotal.Location = New System.Drawing.Point(50, 92)
        Me.lblPhoneTotal.Name = "lblPhoneTotal"
        Me.lblPhoneTotal.Size = New System.Drawing.Size(93, 18)
        Me.lblPhoneTotal.TabIndex = 4
        Me.lblPhoneTotal.Text = "Phone Total:"
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(149, 54)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(72, 26)
        Me.lblTax.TabIndex = 3
        Me.lblTax.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTaxs
        '
        Me.lblTaxs.AutoSize = True
        Me.lblTaxs.Location = New System.Drawing.Point(108, 55)
        Me.lblTaxs.Name = "lblTaxs"
        Me.lblTaxs.Size = New System.Drawing.Size(35, 18)
        Me.lblTaxs.TabIndex = 2
        Me.lblTaxs.Text = "Tax:"
        '
        'lblSubtotal
        '
        Me.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubtotal.Location = New System.Drawing.Point(149, 21)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(72, 26)
        Me.lblSubtotal.TabIndex = 1
        Me.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(25, 23)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(118, 18)
        Me.lblPhone.TabIndex = 0
        Me.lblPhone.Text = "Phone Subtotal:"
        '
        'gbxPackage
        '
        Me.gbxPackage.Controls.Add(Me.rdbUnlimted)
        Me.gbxPackage.Controls.Add(Me.rdb1500Minutes)
        Me.gbxPackage.Controls.Add(Me.rdb800Minutes)
        Me.gbxPackage.Location = New System.Drawing.Point(218, 50)
        Me.gbxPackage.Name = "gbxPackage"
        Me.gbxPackage.Size = New System.Drawing.Size(241, 114)
        Me.gbxPackage.TabIndex = 10
        Me.gbxPackage.TabStop = False
        Me.gbxPackage.Text = "Select a Package"
        '
        'rdbUnlimted
        '
        Me.rdbUnlimted.AutoSize = True
        Me.rdbUnlimted.Location = New System.Drawing.Point(28, 78)
        Me.rdbUnlimted.Name = "rdbUnlimted"
        Me.rdbUnlimted.Size = New System.Drawing.Size(145, 22)
        Me.rdbUnlimted.TabIndex = 2
        Me.rdbUnlimted.TabStop = True
        Me.rdbUnlimted.Text = "Unlimted Minutes"
        Me.rdbUnlimted.UseVisualStyleBackColor = True
        '
        'rdb1500Minutes
        '
        Me.rdb1500Minutes.AutoSize = True
        Me.rdb1500Minutes.Location = New System.Drawing.Point(28, 50)
        Me.rdb1500Minutes.Name = "rdb1500Minutes"
        Me.rdb1500Minutes.Size = New System.Drawing.Size(162, 22)
        Me.rdb1500Minutes.TabIndex = 1
        Me.rdb1500Minutes.TabStop = True
        Me.rdb1500Minutes.Text = "1500Minutes/Month"
        Me.rdb1500Minutes.UseVisualStyleBackColor = True
        '
        'rdb800Minutes
        '
        Me.rdb800Minutes.AutoSize = True
        Me.rdb800Minutes.Checked = True
        Me.rdb800Minutes.Location = New System.Drawing.Point(28, 22)
        Me.rdb800Minutes.Name = "rdb800Minutes"
        Me.rdb800Minutes.Size = New System.Drawing.Size(157, 22)
        Me.rdb800Minutes.TabIndex = 0
        Me.rdb800Minutes.TabStop = True
        Me.rdb800Minutes.Text = "800 Mintues/Month"
        Me.rdb800Minutes.UseVisualStyleBackColor = True
        '
        'gbxOptions
        '
        Me.gbxOptions.Controls.Add(Me.cbxText)
        Me.gbxOptions.Controls.Add(Me.cbxEmail)
        Me.gbxOptions.Location = New System.Drawing.Point(12, 170)
        Me.gbxOptions.Name = "gbxOptions"
        Me.gbxOptions.Size = New System.Drawing.Size(200, 100)
        Me.gbxOptions.TabIndex = 9
        Me.gbxOptions.TabStop = False
        Me.gbxOptions.Text = "Select Options"
        '
        'cbxText
        '
        Me.cbxText.AutoSize = True
        Me.cbxText.Location = New System.Drawing.Point(17, 62)
        Me.cbxText.Name = "cbxText"
        Me.cbxText.Size = New System.Drawing.Size(131, 22)
        Me.cbxText.TabIndex = 1
        Me.cbxText.Text = "Text Messages"
        Me.cbxText.UseVisualStyleBackColor = True
        '
        'cbxEmail
        '
        Me.cbxEmail.AutoSize = True
        Me.cbxEmail.Location = New System.Drawing.Point(17, 25)
        Me.cbxEmail.Name = "cbxEmail"
        Me.cbxEmail.Size = New System.Drawing.Size(67, 22)
        Me.cbxEmail.TabIndex = 0
        Me.cbxEmail.Text = "Email"
        Me.cbxEmail.UseVisualStyleBackColor = True
        '
        'gbxPhone
        '
        Me.gbxPhone.Controls.Add(Me.rdb200)
        Me.gbxPhone.Controls.Add(Me.rdbM110)
        Me.gbxPhone.Controls.Add(Me.rdbM100)
        Me.gbxPhone.Location = New System.Drawing.Point(12, 47)
        Me.gbxPhone.Name = "gbxPhone"
        Me.gbxPhone.Size = New System.Drawing.Size(200, 117)
        Me.gbxPhone.TabIndex = 8
        Me.gbxPhone.TabStop = False
        Me.gbxPhone.Text = "Select a Phone"
        '
        'rdb200
        '
        Me.rdb200.AutoSize = True
        Me.rdb200.Location = New System.Drawing.Point(17, 81)
        Me.rdb200.Name = "rdb200"
        Me.rdb200.Size = New System.Drawing.Size(100, 22)
        Me.rdb200.TabIndex = 2
        Me.rdb200.TabStop = True
        Me.rdb200.Text = "Model 200"
        Me.rdb200.UseVisualStyleBackColor = True
        '
        'rdbM110
        '
        Me.rdbM110.AutoSize = True
        Me.rdbM110.Location = New System.Drawing.Point(17, 53)
        Me.rdbM110.Name = "rdbM110"
        Me.rdbM110.Size = New System.Drawing.Size(99, 22)
        Me.rdbM110.TabIndex = 1
        Me.rdbM110.TabStop = True
        Me.rdbM110.Text = "Model 110"
        Me.rdbM110.UseVisualStyleBackColor = True
        '
        'rdbM100
        '
        Me.rdbM100.AutoSize = True
        Me.rdbM100.Checked = True
        Me.rdbM100.Location = New System.Drawing.Point(17, 25)
        Me.rdbM100.Name = "rdbM100"
        Me.rdbM100.Size = New System.Drawing.Size(100, 22)
        Me.rdbM100.TabIndex = 0
        Me.rdbM100.TabStop = True
        Me.rdbM100.Text = "Model 100"
        Me.rdbM100.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(29, 355)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 29)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(29, 305)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(100, 29)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(26, 18)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(141, 18)
        Me.lblNumber.TabIndex = 12
        Me.lblNumber.Text = "Number of Phones:"
        '
        'txtPhones
        '
        Me.txtPhones.Location = New System.Drawing.Point(183, 15)
        Me.txtPhones.Name = "txtPhones"
        Me.txtPhones.Size = New System.Drawing.Size(53, 26)
        Me.txtPhones.TabIndex = 13
        Me.txtPhones.Text = "2"
        Me.txtPhones.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(262, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Minimum of two phones."
        '
        'FamilyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 418)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPhones)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.gbxTotals)
        Me.Controls.Add(Me.gbxPackage)
        Me.Controls.Add(Me.gbxOptions)
        Me.Controls.Add(Me.gbxPhone)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FamilyForm"
        Me.Text = "Family Plan"
        Me.gbxTotals.ResumeLayout(False)
        Me.gbxTotals.PerformLayout()
        Me.gbxPackage.ResumeLayout(False)
        Me.gbxPackage.PerformLayout()
        Me.gbxOptions.ResumeLayout(False)
        Me.gbxOptions.PerformLayout()
        Me.gbxPhone.ResumeLayout(False)
        Me.gbxPhone.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbxTotals As System.Windows.Forms.GroupBox
    Friend WithEvents lblMonthlyCharge As System.Windows.Forms.Label
    Friend WithEvents lblMonthly As System.Windows.Forms.Label
    Friend WithEvents lblPackCharge As System.Windows.Forms.Label
    Friend WithEvents lblPCharge As System.Windows.Forms.Label
    Friend WithEvents lblOptions As System.Windows.Forms.Label
    Friend WithEvents lblOp As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPhoneTotal As System.Windows.Forms.Label
    Friend WithEvents lblTax As System.Windows.Forms.Label
    Friend WithEvents lblTaxs As System.Windows.Forms.Label
    Friend WithEvents lblSubtotal As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents gbxPackage As System.Windows.Forms.GroupBox
    Friend WithEvents rdbUnlimted As System.Windows.Forms.RadioButton
    Friend WithEvents rdb1500Minutes As System.Windows.Forms.RadioButton
    Friend WithEvents rdb800Minutes As System.Windows.Forms.RadioButton
    Friend WithEvents gbxOptions As System.Windows.Forms.GroupBox
    Friend WithEvents cbxText As System.Windows.Forms.CheckBox
    Friend WithEvents cbxEmail As System.Windows.Forms.CheckBox
    Friend WithEvents gbxPhone As System.Windows.Forms.GroupBox
    Friend WithEvents rdb200 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbM110 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbM100 As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents txtPhones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
