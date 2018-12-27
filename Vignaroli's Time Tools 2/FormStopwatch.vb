Public Class FormStopwatch
    Dim splitNumber As Integer
    Dim minutes, seconds, centiseconds As String
    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        'Timer
        TimerStopwatch.Enabled = True
        'Graphics
        ButtonStop.Enabled = True
        ButtonReset.Enabled = True
        ButtonStart.Enabled = False
        ButtonStop.Font = New Font(ButtonStop.Font.FontFamily, 8, FontStyle.Bold)
        ButtonStart.Font = New Font(ButtonStart.Font.FontFamily, 8, FontStyle.Regular)
        ButtonStop.Height = 50
        ButtonStop.Location = New Point(94, 12)
        ButtonStart.Height = 23
        ButtonStart.Location = New Point(13, 26)
        ButtonStop.Text = "STOP"
        ButtonStart.Text = "Start"
    End Sub
    Private Sub ButtonStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStop.Click
        'Timer
        TimerStopwatch.Enabled = False
        'Graphics
        ButtonStop.Enabled = False
        ButtonReset.Enabled = True
        ButtonStart.Enabled = True
        ButtonStop.Font = New Font(ButtonStop.Font.FontFamily, 8, FontStyle.Regular)
        ButtonStart.Font = New Font(ButtonStart.Font.FontFamily, 8, FontStyle.Bold)
        ButtonStop.Height = 23
        ButtonStop.Location = New Point(13, 26)
        ButtonStart.Height = 50
        ButtonStart.Location = New Point(94, 12)
        ButtonStop.Text = "Stop"
        ButtonStart.Text = "START"
    End Sub
    Private Sub ButtonReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReset.Click
        LabelCentiseconds.Text = "00"
        LabelSeconds.Text = "00"
        LabelMinutes.Text = "00"
        ListBoxSplit.Items.Clear()
        splitNumber = 1
    End Sub
    Private Sub ButtonSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSplit.Click
        'Centiseconds
        If LabelCentiseconds.Text = 0 Then
            centiseconds = "00"
        ElseIf LabelCentiseconds.Text < 10 Then
            centiseconds = "0" & LabelCentiseconds.Text
        Else
            centiseconds = LabelCentiseconds.Text
        End If
        'Seconds
        If LabelSeconds.Text = 0 Then
            seconds = "00"
        ElseIf LabelSeconds.Text < 10 Then
            seconds = "0" & LabelSeconds.Text
        Else
            seconds = LabelSeconds.Text
        End If
        'Minutes
        If LabelMinutes.Text = 0 Then
            minutes = "00"
        ElseIf LabelMinutes.Text < 10 Then
            minutes = "0" & LabelMinutes.Text
        Else
            minutes = LabelMinutes.Text
        End If
        'ListBoxSplit
        ListBoxSplit.Items.Add("#" & splitNumber & " " & minutes & ":" & seconds & ":" & centiseconds)
        splitNumber += 1
        ButtonDLSplit.Enabled = True
    End Sub
    Private Sub TimerStopwatch_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerStopwatch.Tick
        LabelCentiseconds.Text += 1
        If LabelCentiseconds.Text = 99 Then
            LabelSeconds.Text += 1
            LabelCentiseconds.Text = 0
        End If
        If LabelSeconds.Text = 59 Then
            LabelMinutes.Text += 1
            LabelSeconds.Text = 0
        End If
    End Sub
    Private Sub FormStopwatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        splitNumber = 1
        ListBoxSplit.Items.Clear()
    End Sub
    Private Sub ButtonQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuit.Click
        If MsgBox("Are you sure you want to close this module", vbYesNo, "Quit") = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
    Private Sub ButtonDLSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDLSplit.Click
        splitNumber -= 1
        ListBoxSplit.Items.RemoveAt(splitNumber - 1)
        If splitNumber = 1 Then
            ButtonDLSplit.Enabled = False
        End If
    End Sub
End Class
