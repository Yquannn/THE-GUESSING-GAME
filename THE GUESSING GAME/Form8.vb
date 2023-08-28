Public Class Form8
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
        Number = Int(Rnd() * 99) + 1 ' Select the random number to guess
        Correct = False
        count = 1

        Do While count < 11 And Correct = False ' Give the user 3 guesses
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

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class