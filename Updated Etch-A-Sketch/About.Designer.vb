<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Me.AboutLabel = New System.Windows.Forms.Label()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AboutLabel
        '
        Me.AboutLabel.Font = New System.Drawing.Font("Consolas", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutLabel.Location = New System.Drawing.Point(12, 9)
        Me.AboutLabel.Name = "AboutLabel"
        Me.AboutLabel.Size = New System.Drawing.Size(767, 429)
        Me.AboutLabel.TabIndex = 2
        Me.AboutLabel.Text = "Updated Etch-A-Sketch" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "By: Jason Permann" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fall 2025" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.AboutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(587, 338)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(192, 100)
        Me.ReturnButton.TabIndex = 3
        Me.ReturnButton.Text = "Return"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.AboutLabel)
        Me.Name = "About"
        Me.Text = "About"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AboutLabel As Label
    Friend WithEvents ReturnButton As Button
End Class
