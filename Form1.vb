Imports System.Windows.Forms
Imports System.Media

Public Class Form1


    Private remaining_seconds As Integer




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 1000
        Timer1.Enabled = False
        Update_timer(0)

        ' Включаем обработку клавиш на уровне формы
        Me.KeyPreview = True

    End Sub







    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        Select Case e.KeyCode
            Case Keys.P
                Play_pause()

            Case Keys.Escape
                Reset()

        End Select

    End Sub


    'PLAY / PAUSE
    Private Sub Play_pause() Handles But_play.Click

        If But_play.Text = "pause" Then

            Timer1.Stop()
            But_play.Text = "play"
            Me.BackColor = SystemColors.Control

        Else
            If remaining_seconds <= 0 Then
                If remaining_seconds > 0 Then
                    Update_timer(0)
                Else
                    'MessageBox.Show("Введите корректное время!")
                    Return
                End If
            End If

            Timer1.Start()
            Me.BackColor = Color.Green
            But_play.Text = "pause"

        End If
    End Sub



    'RESET
    Private Sub Reset() Handles But_reset.Click

        But_play.Text = "play"
        Timer1.Stop()
        Me.BackColor = SystemColors.Control
        remaining_seconds = 0
        Update_timer(0)

    End Sub




    'Добавляем время
    Private Sub But_30s_Click(sender As Object, e As EventArgs) Handles But_30s.Click
        Update_timer(30)
    End Sub

    Private Sub But_1m_Click(sender As Object, e As EventArgs) Handles But_1.Click
        Update_timer(60)
    End Sub

    Private Sub But_5m_Click(sender As Object, e As EventArgs) Handles But_5.Click
        Update_timer(300)
    End Sub

    Private Sub But_10m_Click(sender As Object, e As EventArgs) Handles But_10.Click
        Update_timer(600)
    End Sub






    'Обновление таймера
    Private Sub Update_timer(second As Integer)
        remaining_seconds += second
        Dim minutes As Integer = remaining_seconds \ 60
        Dim seconds As Integer = remaining_seconds Mod 60

        ' Безопасное обновление Label из потока таймера
        If Label_timer.InvokeRequired Then
            Label_timer.Invoke(Sub() Label_timer.Text = $"{minutes:00}:{seconds:00}")
        Else
            Label_timer.Text = $"{minutes:00}:{seconds:00}"
        End If
    End Sub



    'ТИК ТАК
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Update_timer(-1)

        If remaining_seconds <= 0 Then

            Me.BackColor = Color.Red
            Timer1.Stop()

            Task.Run(
                Sub()
                    While True
                        Console.Beep()
                        Threading.Thread.Sleep(1000)

                        If But_play.Text = "play" Then
                            Me.BackColor = SystemColors.Control
                            Exit While
                        End If

                        Update_timer(-1)
                    End While
                End Sub
            )

        End If
    End Sub

End Class