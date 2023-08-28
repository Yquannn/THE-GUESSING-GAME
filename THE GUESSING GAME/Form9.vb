Public Class Form9
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim count, Number As Integer
        Dim Correct As Boolean
        Dim Guess As String
        Dim score As Integer = 1000

        Randomize()
        Number = Int(Rnd() * 999) + 1 ' Select the random number to guess
        Correct = False
        count = 1

        Do While count < 16 And Correct = False ' Give the user 20 guesses
            Guess = InputBox("Your number guess", "Attempt " & count)
            If Val(Guess) = Number Then ' if the guess is correct
                Correct = True
                ScoreText.Text = "score: " & score
                score += 1000
            Else 'if the guess is wrong
                If Guess < Number Then
                    MsgBox("Too low!!", vbExclamation, "Attempt " & count) 'guessing is too low
                Else
                    MsgBox("Too high!!", vbExclamation, "Attempt " & count) ' guessing is too high
                End If


                count = count + 1
            End If
        Loop
        MsgBox(" YOU GUESS THE NUMBER!! THE NUMBER WAS " & Number)
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class