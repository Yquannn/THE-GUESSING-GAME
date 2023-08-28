Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then
            Label1.Text = "Launching the game.."
            Form6.Show()
            Me.Hide()
            Timer1.Stop()
        End If
    End Sub
End Class