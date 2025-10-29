Option Strict On
Option Explicit On
Public Class Form1
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

        Return CInt(System.Math.Floor((Rnd() * (max% + 1))))
    End Function
    Function GetData() As Integer
        Return 5
    End Function

    Sub GraphData()
        Dim g As Graphics = GraphPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Purple)
        ' Define scaling factors to map 0-100 data range to PictureBox dimensions
        ' scaleX and scaleY convert data points to pixel coordinates (100 units to PictureBox size)
        ' 100 units chosen for simplicity; adjust as needed for actual data range
        Dim scaleX As Single = CSng(GraphPictureBox.Width / 100)
        Dim scaleY As Single = CSng((GraphPictureBox.Height / 100) * -1) ' Invert Y-axis (makes positive Y go up)

        g.TranslateTransform(0, GraphPictureBox.Height)
        g.ScaleTransform(scaleX, -1)

        pen.Width = 2 / scaleX ' Keep pen width consistent regardless of scaling
        g.DrawLine(pen, 5, 50, 95, 50)

        g.Dispose()
        pen.Dispose()
    End Sub
    'Event Handlers -------------------------------------------------------------------------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub GraphButton_Click(sender As Object, e As EventArgs) Handles GraphButton.Click
        'GraphData()
        For i = 1 To 100
            Console.WriteLine(GetRandomNumber(GetRandomNumberAround(50, 10)))
        Next
    End Sub
End Class
