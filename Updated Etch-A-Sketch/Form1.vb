'Jason Permann
'Fall 2025
'Jason Permann
'Fall 2025
'RCET 3371
'Updated Etch-A-Sketch
'https://github.com/JaceFoxman/Updated-Etch-A-Sketch.git

Option Strict On
Option Explicit On
Option Compare Text

Imports System.IO.Ports
Imports System.Threading.Thread 'add to allow sleep function to work
Public Class Form1
    'Initialize Form -------------------------------------------------------------------------------------
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub
    ''' <summary>
    ''' Set Default Values on Form Load
    ''' </summary>
    Sub SetDefaults()
        Try
            For Each port In SerialPort.GetPortNames()
                COMPort_ComboBox.Items.Add(port)
            Next
            COMPort_ComboBox.SelectedIndex = 0
        Catch ex As Exception
            'No COM Ports found
            MessageBox.Show("No COM Ports found. Please connect the Q@ Board and restart the application.")
        End Try

        MouseRadioButton.Checked = True
        QBoardRadioButton.Checked = False
        ReadTimer.Enabled = False
        CommandTimer.Enabled = False
    End Sub
    'Serial Connection -----------------------------------------------------------------------------------
    ''' <summary>
    '''  Connect to Serial Port
    ''' </summary>
    Sub Connect()

        Try
            Dim comPort As String = COMPort_ComboBox.Text
            SerialPort.Close()
            SerialPort.BaudRate = 9600 'Q@ Board Default
            SerialPort.Parity = IO.Ports.Parity.None   'No Parity
            SerialPort.StopBits = IO.Ports.StopBits.One    '1 Stop Bit
            SerialPort.DataBits = 8    '8 Data Bits
            SerialPort.PortName = comPort 'Change to your COM Port

            SerialPort.Open()  'Open Serial Port
            If SerialPort.IsOpen Then  'Check if Serial Port is open
                MessageBox.Show("Connected to " & SerialPort.PortName) 'Show message if connected
            End If

        Catch ex As Exception
            'Show error message if port is invalid
            MessageBox.Show("Error: " & ex.Message)

            Return
        End Try
    End Sub
    'Setting and Getting Color ---------------------------------------------------------------------------
    ''' <summary>
    ''' Set or Get Drawing Color
    ''' </summary>
    ''' <param name="newColor"></param>
    ''' <returns></returns>
    Function SetColor(Optional newColor As Color = Nothing) As Color
        Static _forecolor As Color = Color.White
        If newColor <> Nothing Then
            _forecolor = newColor
        End If
        Return _forecolor
    End Function
    ''' <summary>
    ''' Open Color Dialog Box
    ''' </summary>
    ''' <returns></returns>
    Function DialogBox() As Color
        'Make sure to add the tool "Color Dialog Box" added to front pannel to work
        ColorDialog.ShowDialog()
        SetColor(ColorDialog.Color)
        Return SetColor()
    End Function
    'Program Logic ---------------------------------------------------------------------------------------
    ''' <summary>
    ''' Get Random Number Around a Given Number
    ''' </summary>
    ''' <param name="thisNumber%"></param>
    ''' <param name="within%"></param>
    ''' <returns></returns>
    Function GetRandomNumberAround(thisNumber%, Optional within% = 10) As Integer
        Dim result%
        result = thisNumber - within
        result += GetRandomNumber(within) + GetRandomNumber(within)
        Return result
    End Function
    ''' <summary>
    ''' Get Random Number up to a Given Max
    ''' </summary>
    ''' <param name="max%"></param>
    ''' <returns></returns>
    Function GetRandomNumber(max%) As Integer
        Randomize()
        Return CInt(System.Math.Floor((Rnd() * (max + 1))))
    End Function
    ''' <summary>
    ''' Get Random Number between Min and Max
    ''' </summary>
    ''' <param name="min"></param>
    ''' <param name="max"></param>
    ''' <returns></returns>
    Function RNG(min As Integer, max As Integer) As Integer
        Dim value As Single
        Randomize()
        value = Rnd()
        value *= max - min
        value += min
        Return CInt(Math.Ceiling(value))
    End Function
    ''' <summary>
    ''' Shake the Form and Clear the Drawing Area
    ''' </summary>
    Sub ShakeAndClear()
        Dim movePosition As Integer = RNG(1, 350) 'RNG not nedded just added for randomness on the shake
        Try
            My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        Catch ex As Exception
            MsgBox("Missing Resources", MsgBoxStyle.Critical, "Error")
        End Try

        For i = 1 To 10
            Me.Top += movePosition
            Me.Left += movePosition
            Sleep(100)
            movePosition *= -1 'need this to bring back to original position
        Next
        GraphPictureBox.Refresh()
    End Sub
    ''' <summary>
    ''' Draw Graticules on Drawing Area
    ''' </summary>
    Sub Graticules()
        Dim graphics As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(Color.AntiqueWhite)
        Dim y As Integer = 0
        Dim x As Integer = 0

        Do Until y > GraphPictureBox.Height
            y += (GraphPictureBox.Height \ 10)
            graphics.DrawLine(pen, 0, y, GraphPictureBox.Width, y)
        Loop

        Do Until x > GraphPictureBox.Width
            x += (GraphPictureBox.Width \ 10)
            graphics.DrawLine(pen, x, 0, x, GraphPictureBox.Height)
        Loop
    End Sub
    ''' <summary>
    ''' Draw Sine Wave on Drawing Area
    ''' </summary>
    Sub SineWave()
        Dim graphics As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Green)
        Dim ymax As Integer = GraphPictureBox.Height \ 2
        Dim oldx, newy As Integer
        Dim oldy As Integer = GraphPictureBox.Height \ 2
        Dim degresPerGraticule As Double = 360 / GraphPictureBox.Width

        For x = 0 To GraphPictureBox.Width
            newy = CInt(ymax * Math.Sin((Math.PI / 180) * (x * degresPerGraticule))) + GraphPictureBox.Height \ 2
            graphics.DrawLine(pen, oldx, oldy, x, newy)
            oldx = x
            oldy = newy
        Next
    End Sub
    ''' <summary>
    ''' Draw Cosine Wave on Drawing Area
    ''' </summary>
    Sub CosineWave()
        Dim graphics As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Blue)
        Dim ymax As Integer = GraphPictureBox.Height \ 2
        Dim oldx, newy As Integer
        Dim oldy As Integer = GraphPictureBox.Height 'remove the divide 2 here so cosine starts at the right point 
        Dim degresPerGraticule As Double = 360 / GraphPictureBox.Width

        For x = 0 To GraphPictureBox.Width
            newy = CInt(ymax * Math.Cos((Math.PI / 180) * (x * degresPerGraticule))) + GraphPictureBox.Height \ 2
            graphics.DrawLine(pen, oldx, oldy, x, newy)
            oldx = x
            oldy = newy
        Next
    End Sub
    ''' <summary>
    ''' Draw Tangent Wave on Drawing Area
    ''' </summary>
    Sub TangentWave()
        Dim graphics As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)
        Dim ymax As Integer = GraphPictureBox.Height \ 2
        Dim oldx, newy As Integer
        Dim oldy As Integer = GraphPictureBox.Height \ 2
        Dim degresPerGraticule As Double = 360 / GraphPictureBox.Width
        Try
            For x = 0 To GraphPictureBox.Width
                newy = CInt(ymax * Math.Tan((Math.PI / 180) * (x * degresPerGraticule))) + GraphPictureBox.Height \ 2
                graphics.DrawLine(pen, oldx, oldy, x, newy)
                oldx = x
                oldy = newy
            Next
        Catch ex As Exception
            MsgBox("Tangent expression overflow", MsgBoxStyle.Critical, "Math Error")
        End Try


    End Sub
    'Draw with mouse_____________________________________________________________________________________________
    Private Sub GraphPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles GraphPictureBox.MouseMove
        Static oldx, oldy As Integer
        Select Case e.Button.ToString
            Case "Left"
                DrawWithMouse(oldx, oldy, e.X, e.Y)
            Case "Right"
                'context menu set in drawing picture box properties 
            Case "Middle"
                DialogBox()
        End Select
        oldx = e.X
        oldy = e.Y
    End Sub
    Sub DrawWithMouse(oldx As Integer, oldY As Integer, newX As Integer, newY As Integer)
        If MouseRadioButton.Checked = True Then
            Dim graphics As Graphics = GraphPictureBox.CreateGraphics
            Dim pen As New Pen(SetColor)
            graphics.DrawLine(pen, oldx, oldY, newX, newY)
            graphics.Dispose()
        End If
    End Sub
    'Draw with Q@ Board__________________________________________________________________________________________
    ''' <summary>
    ''' Event Handler for Command Timer Tick
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CommandTimer_Tick(sender As Object, e As EventArgs) Handles CommandTimer.Tick
        Dim command As Byte() = New Byte(0) {}
        If QBoardRadioButton.Checked Then
            command(0) = &H53 'Command to request data from Analog inputs of the Q@ Board
            CurrentTextBox.Text = "53 sent"
            SerialPort.Write(command, 0, 1)
        End If
    End Sub
    ''' <summary>
    ''' Event Handler for Serial Port Data Received
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        CheckForIllegalCrossThreadCalls = False 'disable cross-thread checking
        Dim incomingData As Integer = SerialPort.BytesToRead    'get number of bytes to read
    End Sub
    ''' <summary>
    ''' Read incoming data from Q@ Board
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ReadTimer_Tick(sender As Object, e As EventArgs) Handles ReadTimer.Tick

        If SerialPort.BytesToRead = 4 Then
            Dim incomingData(SerialPort.BytesToRead) As Byte    'create byte array to hold incoming data
            Dim value As String 'store incoming data as string
            SerialPort.Read(incomingData, 0, SerialPort.BytesToRead)    'read incoming data
            For Each dataByte In incomingData   'loop through incoming data bytes
                value &= $"{CStr(dataByte)},"   'build string of incoming data
            Next
            CurrentTextBox.Text = value 'display raw incoming data

            Dim valueSplit As String() = value.Split(","c)  'split incoming data into array

            Dim xHighSplit As Integer = CInt(valueSplit(0)) 'get x high byte
            Dim xLowSplit As Integer = CInt(valueSplit(1))  'get x low byte
            Dim yHighSplit As Integer = CInt(valueSplit(2)) 'get y high byte
            Dim yLowSplit As Integer = CInt(valueSplit(3))  'get y low byte

            Dim xHighWeighted As Integer = (xHighSplit * 4) 'weight high byte
            Dim xLowWeighted As Integer = (xLowSplit \ 64)  'weight low byte
            Dim xFinal As Integer = xHighWeighted + xLowWeighted    'final x value
            Dim yHighWeighted As Integer = (yHighSplit * 4) 'weight high byte
            Dim yLowWeighted As Integer = (yLowSplit \ 64)  'weight low byte
            Dim yFinal As Integer = yHighWeighted + yLowWeighted    'final y value

            XHighTextBox.Text = xHighWeighted.ToString()    'display weighted high byte
            XLowTextBox.Text = xLowWeighted.ToString()      'display weighted low byte
            XFinalTextBox.Text = xFinal.ToString()          'display final x value
            YHighTextBox.Text = yHighWeighted.ToString      'display weighted high byte
            YLowTextBox.Text = yLowWeighted.ToString()      'display weighted low byte
            YFinalTextBox.Text = yFinal.ToString()          'display final y value

            DrawWithQBoard(xFinal, yFinal)  'draw with Q@ Board values
        End If

    End Sub
    ''' <summary>
    ''' Draw with Q@ Board values
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    Sub DrawWithQBoard(x As Integer, y As Integer)
        Dim graphics As Graphics = GraphPictureBox.CreateGraphics   'create graphics object
        Dim pen As New Pen(SetColor)    'set pen to selected color
        pen.Width = 0.25    'fix pen so it is not to thick
        Static oldx, oldy As Integer    'store old x and y positions
        Dim scaleX As Single = CSng(GraphPictureBox.Width / 1100)   'Scale x to 1100 units (max value from Q@ Board is about 1014)
        Dim scaleY As Single = CSng((GraphPictureBox.Height / 1100) * -1)  ' Scale y to 1100 units (max value from Q@ Board is about 1014) / Invert Y-axis (makes positive Y go up)
        graphics.TranslateTransform(0, GraphPictureBox.Height) 'move origin to botton-left
        graphics.ScaleTransform(scaleX, scaleY) 'scale to 1100 x 1100 units, invert Y-axis

        Dim newX As Integer = x 'scaleX
        Dim newY As Integer = y 'scaleY

        graphics.DrawLine(pen, oldx, oldy, newX, newY)  'draw line from old to new position
        oldy = newY 'update oldy to newY
        oldx = newX 'update oldx to newX

        graphics.Dispose()  'free graphics object
    End Sub
    'radio buttons-------------------------------------------------------------------------------------
    ''' <summary>
    ''' Swithc to Mouse Drawing Mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MouseRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MouseRadioButton.CheckedChanged
        If MouseRadioButton.Checked Then
            ReadTimer.Enabled = False
            CommandTimer.Enabled = False
            ' clear all the text boxes
            XHighTextBox.Text = "N/A"
            XLowTextBox.Text = "N/A"
            XFinalTextBox.Text = "N/A"
            YHighTextBox.Text = "N/A"
            YLowTextBox.Text = "N/A"
            YFinalTextBox.Text = "N/A"
            CurrentTextBox.Text = "Mouse Mode"
        End If
    End Sub
    ''' <summary>
    ''' Switch to Q@ Board Drawing Mode
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub QBoardRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QBoardRadioButton.CheckedChanged
        Try 'make sure serial port is open
            If Not SerialPort.IsOpen Then
                Connect()
            End If
        Catch ex As Exception
            MessageBox.Show("Please connect to a valid COM Port before selecting Q@ Board mode.")
            MouseRadioButton.Checked = True
            Return
        End Try
        If QBoardRadioButton.Checked Then
            ReadTimer.Enabled = True
            CommandTimer.Enabled = True
        End If
    End Sub
    'Event Handlers -------------------------------------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        SerialPort.Close() 'Close Serial Port
        Me.Close()
    End Sub
    Private Sub GraphButton_Click(sender As Object, e As EventArgs) Handles GraphButton.Click
        ShakeAndClear()
        Graticules()
        SineWave()
        CosineWave()
        TangentWave()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ShakeAndClear()
    End Sub
    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        DialogBox()
    End Sub
    Private Sub Connect_Button_Click(sender As Object, e As EventArgs) Handles Connect_Button.Click
        Select Case COMPort_ComboBox.Text <> ""  'Wait for COM Port Selection
            Case True
                Connect()   'Connect to Serial Port
            Case False
                MessageBox.Show("Please select a COM Port")
        End Select
    End Sub
    'Menu Items -------------------------------------------------------------------------------------
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        About.Show()
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ShakeAndClear()
    End Sub
    Private Sub DrawWavefromToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWavefromToolStripMenuItem.Click
        ShakeAndClear()
        Graticules()
        SineWave()
        CosineWave()
        TangentWave()
    End Sub
    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        DialogBox()
    End Sub
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        SerialPort.Close() 'Close Serial Port
        Me.Close()
    End Sub
End Class

