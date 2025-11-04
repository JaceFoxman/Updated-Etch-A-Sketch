'Jason Permann
'Fall 2025
'RCET 3371
'Updated Etch-A-Sketch
'
Option Strict On
Option Explicit On
Option Compare Text
Public Class About
    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class