﻿Public Class chosegame
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class