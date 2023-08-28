Imports System.Net
Imports WMPLib
Public Class Form1
    Dim mp3 As WindowsMediaPlayer = New WindowsMediaPlayer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As Integer

        response = MessageBox.Show("Are you sure you want to exit the Application?", "THE GUESSING GAME",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then

            Application.ExitThread()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        mp3.URL = "D:/HTML/melodyloops-preview-puzzle-game-3m30s.mp3"
        mp3.controls.play()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        mp3.controls.stop()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        chosegame.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        mp3.URL = "D:/HTML/positive-winter-10785.mp3"
        mp3.controls.play()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        mp3.URL = "D:/HTML/it-is-happy-main-9622.mp3"
        mp3.controls.play()
    End Sub
End Class
