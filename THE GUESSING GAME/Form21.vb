﻿Public Class Form21
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then
            Label1.Text = "Launching the game.."
            Form17.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub
End Class