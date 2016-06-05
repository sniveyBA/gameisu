<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLevel1
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.radOne = New System.Windows.Forms.RadioButton()
        Me.radTwo = New System.Windows.Forms.RadioButton()
        Me.radThree = New System.Windows.Forms.RadioButton()
        Me.radFour = New System.Windows.Forms.RadioButton()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(109, 143)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(39, 13)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Label1"
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(107, 320)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 1
        Me.btn1.Text = "Guess!"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'radOne
        '
        Me.radOne.AutoSize = True
        Me.radOne.Location = New System.Drawing.Point(112, 389)
        Me.radOne.Name = "radOne"
        Me.radOne.Size = New System.Drawing.Size(14, 13)
        Me.radOne.TabIndex = 5
        Me.radOne.UseVisualStyleBackColor = True
        '
        'radTwo
        '
        Me.radTwo.Location = New System.Drawing.Point(246, 387)
        Me.radTwo.Name = "radTwo"
        Me.radTwo.Size = New System.Drawing.Size(90, 17)
        Me.radTwo.TabIndex = 6
        Me.radTwo.UseVisualStyleBackColor = True
        '
        'radThree
        '
        Me.radThree.AutoSize = True
        Me.radThree.Location = New System.Drawing.Point(387, 389)
        Me.radThree.Name = "radThree"
        Me.radThree.Size = New System.Drawing.Size(14, 13)
        Me.radThree.TabIndex = 7
        Me.radThree.UseVisualStyleBackColor = True
        '
        'radFour
        '
        Me.radFour.AutoSize = True
        Me.radFour.Location = New System.Drawing.Point(539, 389)
        Me.radFour.Name = "radFour"
        Me.radFour.Size = New System.Drawing.Size(14, 13)
        Me.radFour.TabIndex = 8
        Me.radFour.UseVisualStyleBackColor = True
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.Location = New System.Drawing.Point(577, 143)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(0, 13)
        Me.lblCounter.TabIndex = 9
        '
        'frmLevel1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 521)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.radFour)
        Me.Controls.Add(Me.radThree)
        Me.Controls.Add(Me.radTwo)
        Me.Controls.Add(Me.radOne)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "frmLevel1"
        Me.Text = "Level 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents radOne As System.Windows.Forms.RadioButton
    Friend WithEvents radTwo As System.Windows.Forms.RadioButton
    Friend WithEvents radThree As System.Windows.Forms.RadioButton
    Friend WithEvents radFour As System.Windows.Forms.RadioButton
    Friend WithEvents lblCounter As System.Windows.Forms.Label
End Class
