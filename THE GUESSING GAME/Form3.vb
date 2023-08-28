Public Class Form3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then
            Label1.Text = "Launching the game..."
            Form5.Show()
            Timer1.Stop()
            Me.Hide()

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form5.Show()

    End Sub
End Class