<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLearnBox
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
        Me.lblMonument = New System.Windows.Forms.Label
        Me.lblCapital = New System.Windows.Forms.Label
        Me.lblHead = New System.Windows.Forms.Label
        Me.lblCountry = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblMonument
        '
        Me.lblMonument.Location = New System.Drawing.Point(159, 72)
        Me.lblMonument.Name = "lblMonument"
        Me.lblMonument.Size = New System.Drawing.Size(165, 54)
        Me.lblMonument.TabIndex = 0
        '
        'lblCapital
        '
        Me.lblCapital.Location = New System.Drawing.Point(159, 141)
        Me.lblCapital.Name = "lblCapital"
        Me.lblCapital.Size = New System.Drawing.Size(165, 54)
        Me.lblCapital.TabIndex = 1
        '
        'lblHead
        '
        Me.lblHead.Location = New System.Drawing.Point(145, 231)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(165, 54)
        Me.lblHead.TabIndex = 2
        '
        'lblCountry
        '
        Me.lblCountry.Location = New System.Drawing.Point(159, 18)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(165, 54)
        Me.lblCountry.TabIndex = 3
        '
        'frmLearnBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 342)
        Me.Controls.Add(Me.lblCountry)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.lblCapital)
        Me.Controls.Add(Me.lblMonument)
        Me.Name = "frmLearnBox"
        Me.Text = "frmLearnBox"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblMonument As System.Windows.Forms.Label
    Friend WithEvents lblCapital As System.Windows.Forms.Label
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents lblCountry As System.Windows.Forms.Label
End Class
