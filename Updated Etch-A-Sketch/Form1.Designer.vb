<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GraphPictureBox = New System.Windows.Forms.PictureBox()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.GraphButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWavefromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.Connect_Button = New System.Windows.Forms.Button()
        Me.COMPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.RadioGroupBox = New System.Windows.Forms.GroupBox()
        Me.MouseRadioButton = New System.Windows.Forms.RadioButton()
        Me.QBoardRadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.GraphPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        Me.RadioGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GraphPictureBox
        '
        Me.GraphPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraphPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GraphPictureBox.Location = New System.Drawing.Point(0, 19)
        Me.GraphPictureBox.Name = "GraphPictureBox"
        Me.GraphPictureBox.Size = New System.Drawing.Size(799, 289)
        Me.GraphPictureBox.TabIndex = 1
        Me.GraphPictureBox.TabStop = False
        '
        'ColorButton
        '
        Me.ColorButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColorButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.ColorButton.Location = New System.Drawing.Point(137, 25)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(122, 79)
        Me.ColorButton.TabIndex = 7
        Me.ColorButton.Text = "&Select Color"
        Me.ColorButton.UseVisualStyleBackColor = True
        '
        'GraphButton
        '
        Me.GraphButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraphButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.GraphButton.Location = New System.Drawing.Point(9, 25)
        Me.GraphButton.Name = "GraphButton"
        Me.GraphButton.Size = New System.Drawing.Size(122, 79)
        Me.GraphButton.TabIndex = 6
        Me.GraphButton.Text = "&GRAPH"
        Me.GraphButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.ExitButton.Location = New System.Drawing.Point(393, 25)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(122, 79)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Location = New System.Drawing.Point(0, 432)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(799, 22)
        Me.StatusStrip.TabIndex = 5
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupBox.Controls.Add(Me.ColorButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.GraphButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(278, 314)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(521, 115)
        Me.ButtonGroupBox.TabIndex = 5
        Me.ButtonGroupBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.ClearButton.Location = New System.Drawing.Point(265, 25)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(122, 79)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "&CLEAR"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(799, 36)
        Me.TopMenuStrip.TabIndex = 7
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 30)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(270, 34)
        Me.EXITToolStripMenuItem.Text = "&EXIT"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWavefromToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 30)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(242, 34)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        '
        'DrawWavefromToolStripMenuItem
        '
        Me.DrawWavefromToolStripMenuItem.Name = "DrawWavefromToolStripMenuItem"
        Me.DrawWavefromToolStripMenuItem.Size = New System.Drawing.Size(242, 34)
        Me.DrawWavefromToolStripMenuItem.Text = "Draw Wavefrom"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(242, 34)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 30)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'Connect_Button
        '
        Me.Connect_Button.BackColor = System.Drawing.Color.Green
        Me.Connect_Button.ForeColor = System.Drawing.Color.GhostWhite
        Me.Connect_Button.Location = New System.Drawing.Point(12, 383)
        Me.Connect_Button.Name = "Connect_Button"
        Me.Connect_Button.Size = New System.Drawing.Size(136, 35)
        Me.Connect_Button.TabIndex = 1
        Me.Connect_Button.Text = "Connect"
        Me.Connect_Button.UseVisualStyleBackColor = False
        '
        'COMPort_ComboBox
        '
        Me.COMPort_ComboBox.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.COMPort_ComboBox.FormattingEnabled = True
        Me.COMPort_ComboBox.Location = New System.Drawing.Point(12, 339)
        Me.COMPort_ComboBox.Name = "COMPort_ComboBox"
        Me.COMPort_ComboBox.Size = New System.Drawing.Size(133, 31)
        Me.COMPort_ComboBox.TabIndex = 0
        '
        'RadioGroupBox
        '
        Me.RadioGroupBox.Controls.Add(Me.QBoardRadioButton)
        Me.RadioGroupBox.Controls.Add(Me.MouseRadioButton)
        Me.RadioGroupBox.Font = New System.Drawing.Font("Consolas", 7.0!)
        Me.RadioGroupBox.Location = New System.Drawing.Point(154, 314)
        Me.RadioGroupBox.Name = "RadioGroupBox"
        Me.RadioGroupBox.Size = New System.Drawing.Size(118, 115)
        Me.RadioGroupBox.TabIndex = 2
        Me.RadioGroupBox.TabStop = False
        Me.RadioGroupBox.Text = "Drawing Mode"
        '
        'MouseRadioButton
        '
        Me.MouseRadioButton.AutoSize = True
        Me.MouseRadioButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.MouseRadioButton.Location = New System.Drawing.Point(6, 32)
        Me.MouseRadioButton.Name = "MouseRadioButton"
        Me.MouseRadioButton.Size = New System.Drawing.Size(90, 27)
        Me.MouseRadioButton.TabIndex = 3
        Me.MouseRadioButton.TabStop = True
        Me.MouseRadioButton.Text = "&Mouse"
        Me.MouseRadioButton.UseVisualStyleBackColor = True
        '
        'QBoardRadioButton
        '
        Me.QBoardRadioButton.AutoSize = True
        Me.QBoardRadioButton.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.QBoardRadioButton.Location = New System.Drawing.Point(6, 74)
        Me.QBoardRadioButton.Name = "QBoardRadioButton"
        Me.QBoardRadioButton.Size = New System.Drawing.Size(105, 26)
        Me.QBoardRadioButton.TabIndex = 4
        Me.QBoardRadioButton.TabStop = True
        Me.QBoardRadioButton.Text = "&Q@Board"
        Me.QBoardRadioButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 454)
        Me.Controls.Add(Me.RadioGroupBox)
        Me.Controls.Add(Me.Connect_Button)
        Me.Controls.Add(Me.COMPort_ComboBox)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.GraphPictureBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GraphPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        Me.RadioGroupBox.ResumeLayout(False)
        Me.RadioGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GraphPictureBox As PictureBox
    Friend WithEvents ColorButton As Button
    Friend WithEvents GraphButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearButton As Button
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWavefromToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents Connect_Button As Button
    Friend WithEvents COMPort_ComboBox As ComboBox
    Friend WithEvents RadioGroupBox As GroupBox
    Friend WithEvents QBoardRadioButton As RadioButton
    Friend WithEvents MouseRadioButton As RadioButton
End Class
