Option Strict On
Option Explicit On

Imports System.Threading.Thread 'add to allow sleep function to work
Public Class Form1
    Dim DataBuffer As New Queue(Of Integer)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'Setting and Getting Color ---------------------------------------------------------------------------
    Function SetColor(Optional newColor As Color = Nothing) As Color
        Static _forecolor As Color = Color.Black
        If newColor <> Nothing Then
            _forecolor = newColor
        End If
        Return _forecolor
    End Function
    Function DialogBox() As Color
        'Make sure to add the tool "Color Dialog Box" added to front pannel to work
        ColorDialog.ShowDialog()
        SetColor(ColorDialog.Color)
        Return SetColor()
    End Function
    'Program Logic --------------------------------------------------------------------------------------
    Function GetRandomNumberAround(thisNumber%, Optional within% = 10) As Integer
        Dim result%
        result = thisNumber - within
        result += GetRandomNumber(within) + GetRandomNumber(within)
        Return result
    End Function
    Function GetRandomNumber(max%) As Integer
        Randomize()

        Return CInt(System.Math.Floor((Rnd() * (max + 1))))
    End Function
    Sub GetData()
        Dim last%
        If Me.DataBuffer.Count > 0 Then
            last = Me.DataBuffer.Last
        Else
            last = GetRandomNumberAround(50, 50)
        End If
        If DataBuffer.Count >= 100 Then 'keep the queue trimmed to graph x length
            Me.DataBuffer.Dequeue()
        End If

        Me.DataBuffer.Enqueue(GetRandomNumberAround(last, 5))

    End Sub
    Sub GraphData()
        Dim g As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Purple)
        ' Define scaling factors to map 0-100 data range to PictureBox dimensions
        ' scaleX and scaleY convert data points to pixel coordinates (100 units to PictureBox size)
        ' 100 units chosen for simplicity; adjust as needed for actual data range
        Dim scaleX As Single = CSng(GraphPictureBox.Width / 100)
        Dim scaleY As Single = CSng((GraphPictureBox.Height / 100) * -1) ' Invert Y-axis (makes positive Y go up)

        g.TranslateTransform(0, GraphPictureBox.Height) 'move origin to botton-left
        g.ScaleTransform(scaleX, -1) 'scale to 100 x 100 units, invert Y-axis
        pen.Width = 0.25 'fix pen so it is not to thick

        Dim oldY% = 0
        Dim x = -1
        For Each y In Me.DataBuffer.Reverse
            x += 1
            g.DrawLine(pen, x - 1, oldY, x, y)
            oldY = y
        Next

        g.Dispose()
        pen.Dispose()
    End Sub
    Function RNG(min As Integer, max As Integer) As Integer
        Dim value As Single
        Randomize()
        value = Rnd()
        value *= max - min
        value += min
        Return CInt(Math.Ceiling(value))
    End Function
    Sub ShakeAndClear()
        Dim movePosition As Integer = RNG(1, 350) 'RNG not nedded just added for randomness on the shake
        'Try
        '    My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        'Catch ex As Exception
        '    MsgBox("Missing Resources", MsgBoxStyle.Critical, "Error")
        'End Try

        For i = 1 To 10
            Me.Top += movePosition
            Me.Left += movePosition
            Sleep(100)
            movePosition *= -1 'need this to bring back to original position
        Next
        GraphPictureBox.Refresh()
    End Sub
    'Draw with mouse_____________________________________________________________________________________________
    Private Sub DrawingPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles GraphPictureBox.MouseMove
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
        Dim graphics As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(SetColor)
        graphics.DrawLine(pen, oldx, oldY, newX, newY)
        graphics.Dispose()
    End Sub
    'Event Handlers -------------------------------------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub GraphButton_Click(sender As Object, e As EventArgs) Handles GraphButton.Click
        GetData()
        GraphData()
        'For i = 1 To 100
        '    Console.WriteLine(GetRandomNumber(GetRandomNumberAround(50, 10)))
        'Next
        'GetData()
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ShakeAndClear()
    End Sub
    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        DialogBox()
    End Sub
End Class
