<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sorting
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
        Me.txtNum1 = New System.Windows.Forms.TextBox()
        Me.txtNum2 = New System.Windows.Forms.TextBox()
        Me.txtNum3 = New System.Windows.Forms.TextBox()
        Me.txtNum4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSortedList = New System.Windows.Forms.Label()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNum1
        '
        Me.txtNum1.Location = New System.Drawing.Point(214, 42)
        Me.txtNum1.Name = "txtNum1"
        Me.txtNum1.Size = New System.Drawing.Size(100, 26)
        Me.txtNum1.TabIndex = 0
        '
        'txtNum2
        '
        Me.txtNum2.Location = New System.Drawing.Point(214, 96)
        Me.txtNum2.Name = "txtNum2"
        Me.txtNum2.Size = New System.Drawing.Size(100, 26)
        Me.txtNum2.TabIndex = 1
        '
        'txtNum3
        '
        Me.txtNum3.Location = New System.Drawing.Point(214, 151)
        Me.txtNum3.Name = "txtNum3"
        Me.txtNum3.Size = New System.Drawing.Size(100, 26)
        Me.txtNum3.TabIndex = 2
        '
        'txtNum4
        '
        Me.txtNum4.Location = New System.Drawing.Point(214, 205)
        Me.txtNum4.Name = "txtNum4"
        Me.txtNum4.Size = New System.Drawing.Size(100, 26)
        Me.txtNum4.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter the First Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(191, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter the Second Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter the Third Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(186, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Enter The Fourth Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Sorted List:"
        '
        'lblSortedList
        '
        Me.lblSortedList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSortedList.Location = New System.Drawing.Point(163, 265)
        Me.lblSortedList.Name = "lblSortedList"
        Me.lblSortedList.Size = New System.Drawing.Size(151, 28)
        Me.lblSortedList.TabIndex = 9
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(109, 319)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(89, 38)
        Me.btnSort.TabIndex = 10
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'Sorting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 381)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lblSortedList)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum4)
        Me.Controls.Add(Me.txtNum3)
        Me.Controls.Add(Me.txtNum2)
        Me.Controls.Add(Me.txtNum1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Sorting"
        Me.Text = "Sorting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNum1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNum4 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSortedList As System.Windows.Forms.Label
    Friend WithEvents btnSort As System.Windows.Forms.Button

End Class
