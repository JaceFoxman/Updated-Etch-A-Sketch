Option Strict On
Option Explicit On
Public Class Form1
    Dim DataBuffer As New Queue(Of Integer)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
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

    End Sub
End Class
