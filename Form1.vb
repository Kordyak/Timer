Imports System.Media
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class Form1


    Private remaining_seconds As Integer

    Private specified_seconds As Integer

    Private alarm_stop As Boolean




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

            Case Keys.R
                Replay()

            Case Keys.Escape, Keys.D
                Drop()

            Case Keys.D3, Keys.NumPad3
                But_30s_Click()

            Case Keys.D1, Keys.NumPad1
                But_1m_Click()

            Case Keys.D5, Keys.NumPad5
                But_5m_Click()

            Case Keys.D0, Keys.NumPad0
                But_10m_Click()

            Case Keys.H
                If Check_hibernate.Checked Then
                    Check_hibernate.Checked = False
                Else
                    Check_hibernate.Checked = True
                End If

        End Select

    End Sub


    'PLAY / PAUSE
    Private Sub Play_pause() Handles But_play.Click

        If specified_seconds = 0 Then
            Exit Sub

        ElseIf But_play.Text = "Pause" Then
            Timer1.Stop()
            But_play.Text = "Play"
            Me.BackColor = Color.Yellow

        ElseIf But_play.Text = "Play" Then
            Timer1.Start()
            But_play.Text = "Pause"
            Me.BackColor = Color.Green
        End If
    End Sub



    'Replay
    Private Sub Replay() Handles But_replay.Click
        remaining_seconds = specified_seconds
        alarm_stop = True
    End Sub


    'DROP
    Private Sub Drop() Handles But_drop.Click

        But_play.Text = "Play"
        Timer1.Stop()
        Me.BackColor = SystemColors.Control

        specified_seconds = 0
        remaining_seconds = 0
        Update_timer(0)

    End Sub




    'Добавляем время
    Private Sub But_30s_Click() Handles But_30s.Click
        Update_timer(30, True)
    End Sub

    Private Sub But_1m_Click() Handles But_1.Click
        Update_timer(60, True)
    End Sub

    Private Sub But_5m_Click() Handles But_5.Click
        Update_timer(300, True)
    End Sub

    Private Sub But_10m_Click() Handles But_10.Click
        Update_timer(600, True)
    End Sub




    'Удаляем время
    Private Sub minus_30s() Handles But_30s_.Click
        Update_timer(-30, True)
    End Sub

    Private Sub minus_1m_() Handles But_1_.Click
        Update_timer(-60, True)
    End Sub

    Private Sub minus_5m_() Handles But_5_.Click
        Update_timer(-300, True)
    End Sub

    Private Sub minus_10m_() Handles But_10_.Click
        Update_timer(-600, True)
    End Sub






    'Обновление таймера
    Private Sub Update_timer(second As Integer, Optional is_start As Boolean = False)

        If is_start Then
            specified_seconds += second
        End If

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
    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Update_timer(-1)

        If remaining_seconds <= 0 Then

            Me.BackColor = Color.Red
            Timer1.Stop()

            If Check_hibernate.Checked Then
                Process.Start("shutdown", "/h")
                Play_pause()
                Exit Sub
            End If

            Dim result = Await Task.Run(
                Function()
                    While True

                        Console.Beep()
                        Threading.Thread.Sleep(1000)

                        Me.Invoke(Sub()
                                      MakeWindowActive()
                                  End Sub)

                        If But_play.Text = "Play" Then
                            Return Nothing

                        ElseIf remaining_seconds > 0 Or alarm_stop Then
                            alarm_stop = False
                            Return "Play"
                        End If

                        Update_timer(-1)

                    End While
                End Function)

            If result = "Play" Then
                But_play.Text = "Play"
                Play_pause()
            End If
        End If
    End Sub




    <DllImport("user32.dll")>
    Private Shared Function SetForegroundWindow(hWnd As IntPtr) As Boolean
    End Function

    Public Sub MakeWindowActive()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If

        Me.TopMost = True
        SetForegroundWindow(Me.Handle)
        Me.TopMost = False
    End Sub


End Class