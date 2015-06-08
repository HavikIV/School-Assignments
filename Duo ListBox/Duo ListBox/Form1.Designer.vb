<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DuoLists
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
        Me.lstLeft = New System.Windows.Forms.ListBox()
        Me.lstRight = New System.Windows.Forms.ListBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstLeft
        '
        Me.lstLeft.FormattingEnabled = True
        Me.lstLeft.ItemHeight = 18
        Me.lstLeft.Location = New System.Drawing.Point(28, 79)
        Me.lstLeft.Name = "lstLeft"
        Me.lstLeft.Size = New System.Drawing.Size(121, 148)
        Me.lstLeft.TabIndex = 0
        '
        'lstRight
        '
        Me.lstRight.FormattingEnabled = True
        Me.lstRight.ItemHeight = 18
        Me.lstRight.Location = New System.Drawing.Point(253, 79)
        Me.lstRight.Name = "lstRight"
        Me.lstRight.Size = New System.Drawing.Size(121, 148)
        Me.lstRight.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(211, 14)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(63, 37)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(280, 14)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(63, 37)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(349, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(63, 37)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(170, 95)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(63, 37)
        Me.btnRight.TabIndex = 5
        Me.btnRight.Text = "--->"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(170, 154)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(63, 37)
        Me.btnLeft.TabIndex = 6
        Me.btnLeft.Text = "<---"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(25, 23)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(90, 18)
        Me.lblItem.TabIndex = 7
        Me.lblItem.Text = "Item to Add:"
        '
        'txtItem
        '
        Me.txtItem.Location = New System.Drawing.Point(117, 20)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(88, 26)
        Me.txtItem.TabIndex = 8
        '
        'DuoLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 270)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lstRight)
        Me.Controls.Add(Me.lstLeft)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "DuoLists"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstLeft As System.Windows.Forms.ListBox
    Friend WithEvents lstRight As System.Windows.Forms.ListBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox

End Class
