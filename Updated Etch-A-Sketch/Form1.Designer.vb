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
        Me.QBoardRadioButton = New System.Windows.Forms.RadioButton()
        Me.MouseRadioButton = New System.Windows.Forms.RadioButton()
        Me.ReadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.XHighTextBox = New System.Windows.Forms.TextBox()
        Me.XLowTextBox = New System.Windows.Forms.TextBox()
        Me.YHighTextBox = New System.Windows.Forms.TextBox()
        Me.YLowTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentTextBox = New System.Windows.Forms.TextBox()
        Me.CommandTimer = New System.Windows.Forms.Timer(Me.components)
        Me.XFinalTextBox = New System.Windows.Forms.TextBox()
        Me.YFinalTextBox = New System.Windows.Forms.TextBox()
        Me.XHighLabel = New System.Windows.Forms.Label()
        Me.XLowLabel = New System.Windows.Forms.Label()
        Me.XFinalLabel = New System.Windows.Forms.Label()
        Me.YHighLabel = New System.Windows.Forms.Label()
        Me.YLowLabel = New System.Windows.Forms.Label()
        Me.YFianlLabel = New System.Windows.Forms.Label()
        Me.CurrentDataLabel = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.GraphPictureBox.Size = New System.Drawing.Size(1328, 602)
        Me.GraphPictureBox.TabIndex = 1
        Me.GraphPictureBox.TabStop = False
        '
        'ColorButton
        '
        Me.ColorButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColorButton.BackColor = System.Drawing.SystemColors.Info
        Me.ColorButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.ColorButton.Location = New System.Drawing.Point(137, 25)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(122, 79)
        Me.ColorButton.TabIndex = 7
        Me.ColorButton.Text = "&Select Color"
        Me.ToolTip.SetToolTip(Me.ColorButton, "Open color select window")
        Me.ColorButton.UseVisualStyleBackColor = False
        '
        'GraphButton
        '
        Me.GraphButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GraphButton.BackColor = System.Drawing.Color.Tan
        Me.GraphButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.GraphButton.Location = New System.Drawing.Point(9, 25)
        Me.GraphButton.Name = "GraphButton"
        Me.GraphButton.Size = New System.Drawing.Size(122, 79)
        Me.GraphButton.TabIndex = 6
        Me.GraphButton.Text = "&GRAPH"
        Me.ToolTip.SetToolTip(Me.GraphButton, "Graph Sine,Cosine,Tangent waveform")
        Me.GraphButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExitButton.BackColor = System.Drawing.Color.Firebrick
        Me.ExitButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.ExitButton.ForeColor = System.Drawing.Color.Gainsboro
        Me.ExitButton.Location = New System.Drawing.Point(393, 25)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(122, 79)
        Me.ExitButton.TabIndex = 9
        Me.ExitButton.Text = "&EXIT"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Close program")
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupBox.Controls.Add(Me.ColorButton)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.GraphButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(807, 627)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(521, 115)
        Me.ButtonGroupBox.TabIndex = 5
        Me.ButtonGroupBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClearButton.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClearButton.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.ClearButton.Location = New System.Drawing.Point(265, 25)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(122, 79)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "&CLEAR"
        Me.ToolTip.SetToolTip(Me.ClearButton, "Clear the drawing area")
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Size = New System.Drawing.Size(1328, 33)
        Me.TopMenuStrip.TabIndex = 7
        Me.TopMenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EXITToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(54, 29)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(148, 34)
        Me.EXITToolStripMenuItem.Text = "&EXIT"
        Me.EXITToolStripMenuItem.ToolTipText = "Close Program"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWavefromToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(58, 29)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(242, 34)
        Me.SelectColorToolStripMenuItem.Text = "Select Color"
        Me.SelectColorToolStripMenuItem.ToolTipText = "Open color select window"
        '
        'DrawWavefromToolStripMenuItem
        '
        Me.DrawWavefromToolStripMenuItem.Name = "DrawWavefromToolStripMenuItem"
        Me.DrawWavefromToolStripMenuItem.Size = New System.Drawing.Size(242, 34)
        Me.DrawWavefromToolStripMenuItem.Text = "Draw Wavefrom"
        Me.DrawWavefromToolStripMenuItem.ToolTipText = "Graph Sine,Cosine,Tangent waveform"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(242, 34)
        Me.ClearToolStripMenuItem.Text = "Clear"
        Me.ClearToolStripMenuItem.ToolTipText = "Clear the drawing area"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(65, 29)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(164, 34)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "Open the About Form"
        '
        'SerialPort
        '
        '
        'Connect_Button
        '
        Me.Connect_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Connect_Button.BackColor = System.Drawing.Color.Green
        Me.Connect_Button.ForeColor = System.Drawing.Color.GhostWhite
        Me.Connect_Button.Location = New System.Drawing.Point(12, 696)
        Me.Connect_Button.Name = "Connect_Button"
        Me.Connect_Button.Size = New System.Drawing.Size(136, 35)
        Me.Connect_Button.TabIndex = 1
        Me.Connect_Button.Text = "Connect"
        Me.ToolTip.SetToolTip(Me.Connect_Button, "Connect to COM port")
        Me.Connect_Button.UseVisualStyleBackColor = False
        '
        'COMPort_ComboBox
        '
        Me.COMPort_ComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.COMPort_ComboBox.Font = New System.Drawing.Font("Consolas", 10.0!)
        Me.COMPort_ComboBox.FormattingEnabled = True
        Me.COMPort_ComboBox.Location = New System.Drawing.Point(15, 650)
        Me.COMPort_ComboBox.Name = "COMPort_ComboBox"
        Me.COMPort_ComboBox.Size = New System.Drawing.Size(133, 31)
        Me.COMPort_ComboBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.COMPort_ComboBox, "Drop Down menu for COM port")
        '
        'RadioGroupBox
        '
        Me.RadioGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioGroupBox.Controls.Add(Me.QBoardRadioButton)
        Me.RadioGroupBox.Controls.Add(Me.MouseRadioButton)
        Me.RadioGroupBox.Font = New System.Drawing.Font("Consolas", 7.0!)
        Me.RadioGroupBox.Location = New System.Drawing.Point(683, 627)
        Me.RadioGroupBox.Name = "RadioGroupBox"
        Me.RadioGroupBox.Size = New System.Drawing.Size(118, 115)
        Me.RadioGroupBox.TabIndex = 2
        Me.RadioGroupBox.TabStop = False
        Me.RadioGroupBox.Text = "Drawing Mode"
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
        Me.ToolTip.SetToolTip(Me.QBoardRadioButton, "Enable Q@Board drawing mode")
        Me.QBoardRadioButton.UseVisualStyleBackColor = True
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
        Me.ToolTip.SetToolTip(Me.MouseRadioButton, "Enable Mouse drawing mode")
        Me.MouseRadioButton.UseVisualStyleBackColor = True
        '
        'ReadTimer
        '
        Me.ReadTimer.Interval = 500
        '
        'XHighTextBox
        '
        Me.XHighTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XHighTextBox.Location = New System.Drawing.Point(343, 652)
        Me.XHighTextBox.Name = "XHighTextBox"
        Me.XHighTextBox.Size = New System.Drawing.Size(104, 26)
        Me.XHighTextBox.TabIndex = 8
        Me.XHighTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.XHighTextBox, "High byte of X")
        '
        'XLowTextBox
        '
        Me.XLowTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XLowTextBox.Location = New System.Drawing.Point(466, 654)
        Me.XLowTextBox.Name = "XLowTextBox"
        Me.XLowTextBox.Size = New System.Drawing.Size(99, 26)
        Me.XLowTextBox.TabIndex = 9
        Me.XLowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.XLowTextBox, "Low byte of X")
        '
        'YHighTextBox
        '
        Me.YHighTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YHighTextBox.Location = New System.Drawing.Point(343, 716)
        Me.YHighTextBox.Name = "YHighTextBox"
        Me.YHighTextBox.Size = New System.Drawing.Size(104, 26)
        Me.YHighTextBox.TabIndex = 10
        Me.YHighTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.YHighTextBox, "High byte of Y")
        '
        'YLowTextBox
        '
        Me.YLowTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YLowTextBox.Location = New System.Drawing.Point(466, 716)
        Me.YLowTextBox.Name = "YLowTextBox"
        Me.YLowTextBox.Size = New System.Drawing.Size(99, 26)
        Me.YLowTextBox.TabIndex = 11
        Me.YLowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.YLowTextBox, "Low byte of Y")
        '
        'CurrentTextBox
        '
        Me.CurrentTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CurrentTextBox.Location = New System.Drawing.Point(174, 652)
        Me.CurrentTextBox.Name = "CurrentTextBox"
        Me.CurrentTextBox.Size = New System.Drawing.Size(118, 26)
        Me.CurrentTextBox.TabIndex = 12
        Me.CurrentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.CurrentTextBox, "All data read from Q@Board")
        '
        'CommandTimer
        '
        Me.CommandTimer.Interval = 1000
        '
        'XFinalTextBox
        '
        Me.XFinalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XFinalTextBox.Location = New System.Drawing.Point(589, 654)
        Me.XFinalTextBox.Name = "XFinalTextBox"
        Me.XFinalTextBox.Size = New System.Drawing.Size(72, 26)
        Me.XFinalTextBox.TabIndex = 13
        Me.XFinalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.XFinalTextBox, "Final X value")
        '
        'YFinalTextBox
        '
        Me.YFinalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YFinalTextBox.Location = New System.Drawing.Point(589, 716)
        Me.YFinalTextBox.Name = "YFinalTextBox"
        Me.YFinalTextBox.Size = New System.Drawing.Size(72, 26)
        Me.YFinalTextBox.TabIndex = 14
        Me.YFinalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip.SetToolTip(Me.YFinalTextBox, "Final Y value")
        '
        'XHighLabel
        '
        Me.XHighLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XHighLabel.AutoSize = True
        Me.XHighLabel.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.XHighLabel.Location = New System.Drawing.Point(339, 633)
        Me.XHighLabel.Name = "XHighLabel"
        Me.XHighLabel.Size = New System.Drawing.Size(108, 19)
        Me.XHighLabel.TabIndex = 15
        Me.XHighLabel.Text = "X High Byte"
        '
        'XLowLabel
        '
        Me.XLowLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XLowLabel.AutoSize = True
        Me.XLowLabel.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.XLowLabel.Location = New System.Drawing.Point(466, 633)
        Me.XLowLabel.Name = "XLowLabel"
        Me.XLowLabel.Size = New System.Drawing.Size(99, 19)
        Me.XLowLabel.TabIndex = 16
        Me.XLowLabel.Text = "X Low Byte"
        '
        'XFinalLabel
        '
        Me.XFinalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XFinalLabel.AutoSize = True
        Me.XFinalLabel.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.XFinalLabel.Location = New System.Drawing.Point(589, 633)
        Me.XFinalLabel.Name = "XFinalLabel"
        Me.XFinalLabel.Size = New System.Drawing.Size(72, 19)
        Me.XFinalLabel.TabIndex = 17
        Me.XFinalLabel.Text = "X Value"
        '
        'YHighLabel
        '
        Me.YHighLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YHighLabel.AutoSize = True
        Me.YHighLabel.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.YHighLabel.Location = New System.Drawing.Point(339, 693)
        Me.YHighLabel.Name = "YHighLabel"
        Me.YHighLabel.Size = New System.Drawing.Size(108, 19)
        Me.YHighLabel.TabIndex = 18
        Me.YHighLabel.Text = "Y High Byte"
        '
        'YLowLabel
        '
        Me.YLowLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YLowLabel.AutoSize = True
        Me.YLowLabel.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.YLowLabel.Location = New System.Drawing.Point(466, 696)
        Me.YLowLabel.Name = "YLowLabel"
        Me.YLowLabel.Size = New System.Drawing.Size(99, 19)
        Me.YLowLabel.TabIndex = 19
        Me.YLowLabel.Text = "Y Low Byte"
        '
        'YFianlLabel
        '
        Me.YFianlLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.YFianlLabel.AutoSize = True
        Me.YFianlLabel.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.YFianlLabel.Location = New System.Drawing.Point(585, 696)
        Me.YFianlLabel.Name = "YFianlLabel"
        Me.YFianlLabel.Size = New System.Drawing.Size(72, 19)
        Me.YFianlLabel.TabIndex = 20
        Me.YFianlLabel.Text = "Y Value"
        '
        'CurrentDataLabel
        '
        Me.CurrentDataLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CurrentDataLabel.AutoSize = True
        Me.CurrentDataLabel.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.CurrentDataLabel.Location = New System.Drawing.Point(175, 633)
        Me.CurrentDataLabel.Name = "CurrentDataLabel"
        Me.CurrentDataLabel.Size = New System.Drawing.Size(117, 19)
        Me.CurrentDataLabel.TabIndex = 21
        Me.CurrentDataLabel.Text = "Current Data"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ClientSize = New System.Drawing.Size(1328, 767)
        Me.Controls.Add(Me.CurrentDataLabel)
        Me.Controls.Add(Me.YFianlLabel)
        Me.Controls.Add(Me.YLowLabel)
        Me.Controls.Add(Me.YHighLabel)
        Me.Controls.Add(Me.XFinalLabel)
        Me.Controls.Add(Me.XLowLabel)
        Me.Controls.Add(Me.XHighLabel)
        Me.Controls.Add(Me.YFinalTextBox)
        Me.Controls.Add(Me.XFinalTextBox)
        Me.Controls.Add(Me.CurrentTextBox)
        Me.Controls.Add(Me.YLowTextBox)
        Me.Controls.Add(Me.YHighTextBox)
        Me.Controls.Add(Me.XLowTextBox)
        Me.Controls.Add(Me.XHighTextBox)
        Me.Controls.Add(Me.RadioGroupBox)
        Me.Controls.Add(Me.Connect_Button)
        Me.Controls.Add(Me.COMPort_ComboBox)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Controls.Add(Me.GraphPictureBox)
        Me.MainMenuStrip = Me.TopMenuStrip
        Me.Name = "Form1"
        Me.Text = "Etch-A-Sketch"
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
    Friend WithEvents ReadTimer As Timer
    Friend WithEvents XHighTextBox As TextBox
    Friend WithEvents XLowTextBox As TextBox
    Friend WithEvents YHighTextBox As TextBox
    Friend WithEvents YLowTextBox As TextBox
    Friend WithEvents CurrentTextBox As TextBox
    Friend WithEvents CommandTimer As Timer
    Friend WithEvents XFinalTextBox As TextBox
    Friend WithEvents YFinalTextBox As TextBox
    Friend WithEvents XHighLabel As Label
    Friend WithEvents XLowLabel As Label
    Friend WithEvents XFinalLabel As Label
    Friend WithEvents YHighLabel As Label
    Friend WithEvents YLowLabel As Label
    Friend WithEvents YFianlLabel As Label
    Friend WithEvents CurrentDataLabel As Label
    Friend WithEvents ToolTip As ToolTip
End Class
