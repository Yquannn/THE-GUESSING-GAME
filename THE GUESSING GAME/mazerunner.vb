
Public Class mazerunner
        Dim score As Integer = 1000

        Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown



            If e.KeyCode = Keys.W Then
                PictureBox1.Top = PictureBox1.Top - 3
            End If

            If e.KeyCode = Keys.A Then
                PictureBox1.Left = PictureBox1.Left - 3

            End If

            If e.KeyCode = Keys.S Then
                PictureBox1.Top = PictureBox1.Top + 3
            End If
            If e.KeyCode = Keys.D Then
                PictureBox1.Left = PictureBox1.Left + 3
            End If


            If PictureBox1.Bounds.IntersectsWith(Lbl1.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18

                score = score - 100

            End If

            If PictureBox1.Bounds.IntersectsWith(Lbl3.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl4.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl5.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl6.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl7.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl8.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl9.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl10.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl11.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl12.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl13.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl14.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl15.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl16.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl17.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl18.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl19.Bounds) Then

                PictureBox1.Top = 84
                PictureBox1.Left = 18
                score = score - 100
            End If
            If PictureBox1.Bounds.IntersectsWith(Lbl20.Bounds) Then
                score = score - 100
                PictureBox1.Top = 84
                PictureBox1.Left = 18

            End If
            If PictureBox1.Bounds.IntersectsWith(LblFinish.Bounds) Then

                Timer1.Stop()

            MsgBox("Your patient is survive!   Your Score Is:" & " " & score)

        End If



        End Sub



        Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

            Timer1.Start()

        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            score = score - 10
            LblScore.Text = CStr(score)

            If score = 0 Then
                Timer1.Stop()

            MsgBox("your patient is die!")

        End If
        End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class