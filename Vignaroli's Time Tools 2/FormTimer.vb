Public Class FormTimer
    Dim ss, ms, mm, hm As Integer
    Dim tsec, tmin, thrs As Integer
    Dim sec, min, hrs As Integer
    Dim Complex As Integer
    Dim possible As Boolean
    Function tidySeconds()
        While ComboBoxSeconds.Text > 59
            ms = ComboBoxSeconds.Text \ 60
            ComboBoxMinutes.Text = ComboBoxMinutes.Text + ms
            ss = ComboBoxSeconds.Text Mod 60
            ComboBoxSeconds.Text = ss
        End While
        Return 0
    End Function
    Function tidyMinutes()
        While ComboBoxMinutes.Text > 59
            hm = ComboBoxMinutes.Text \ 60
            ComboBoxHours.Text = ComboBoxHours.Text + hm
            mm = ComboBoxMinutes.Text Mod 60
            ComboBoxMinutes.Text = mm
        End While
        Return 0
    End Function
    Private Sub ButtonStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStart.Click
        'Cases and possibility
        If IsNumeric(ComboBoxHours.Text) And IsNumeric(ComboBoxMinutes.Text) And IsNumeric(ComboBoxSeconds.Text) Then
            If ComboBoxHours.Text = 0 And ComboBoxMinutes.Text = 0 And ComboBoxSeconds.Text = 0 Then
                'Values are equal to 0
                MsgBox("The values you have entered are equal to 0, please change values", MsgBoxStyle.Critical, "Error")
                possible = False
                Exit Sub
            ElseIf ComboBoxHours.Text < 0 Or ComboBoxMinutes.Text < 0 Or ComboBoxSeconds.Text < 0 Then
                'Values are less than 0
                MsgBox("The values you have entered are less than 0, please change values", MsgBoxStyle.Critical, "Error")
                possible = False
                Exit Sub
            Else
                'Tidy at start
                If RadioButtonTidy.Checked = True Then
                    If ComboBoxSeconds.Text > 59 Then
                        tidySeconds()
                        If ComboBoxMinutes.Text > 59 Then
                            tidyMinutes()
                        End If
                    ElseIf ComboBoxMinutes.Text > 59 Then
                        tidyMinutes()
                    End If
                End If
                'Values for restart
                tsec = ComboBoxSeconds.Text
                tmin = ComboBoxMinutes.Text
                thrs = ComboBoxHours.Text
                possible = True
            End If
            'All not-numeric cases:
        ElseIf IsNumeric(ComboBoxHours.Text) = False And IsNumeric(ComboBoxMinutes.Text) And IsNumeric(ComboBoxSeconds.Text) Then
            'Hours
            MsgBox("The value you have entered for the hours is not numeric, please change value", MsgBoxStyle.Critical, "Error")
            possible = False
            Exit Sub
        ElseIf IsNumeric(ComboBoxHours.Text) And IsNumeric(ComboBoxMinutes.Text) = False And IsNumeric(ComboBoxSeconds.Text) Then
            'Minutes
            MsgBox("The value you have entered for the minutes is not numeric, please change value", MsgBoxStyle.Critical, "Error")
            possible = False
            Exit Sub
        ElseIf IsNumeric(ComboBoxHours.Text) And IsNumeric(ComboBoxMinutes.Text) And IsNumeric(ComboBoxSeconds.Text) = False Then
            'Seconds
            MsgBox("The value you have entered for the seconds is not numeric, please change value", MsgBoxStyle.Critical, "Error")
            possible = False
            Exit Sub
        ElseIf IsNumeric(ComboBoxHours.Text) = False And IsNumeric(ComboBoxMinutes.Text) = False And IsNumeric(ComboBoxSeconds.Text) Then
            'Hours + Minutes
            MsgBox("The values you have entered for the hours and for the minutes are not numeric, please change values", MsgBoxStyle.Critical, "Error")
            possible = False
            Exit Sub
        ElseIf IsNumeric(ComboBoxHours.Text) And IsNumeric(ComboBoxMinutes.Text) = False And IsNumeric(ComboBoxSeconds.Text) = False Then
            'Minutes + Seconds
            MsgBox("The values you have entered for the minutes and for the seconds are not numeric, please change values", MsgBoxStyle.Critical, "Error")
            possible = False
            Exit Sub
        ElseIf IsNumeric(ComboBoxHours.Text) = False And IsNumeric(ComboBoxMinutes.Text) And IsNumeric(ComboBoxSeconds.Text) = False Then
            'Hours + Seconds
            MsgBox("The values you have entered for the hours and for the seconds are not numeric, please change values", MsgBoxStyle.Critical, "Error")
            possible = False
            Exit Sub
        Else
            'All
            MsgBox("All the values you have entered are not numeric, please change values", MsgBoxStyle.Critical, "Error")
            possible = False
            Exit Sub
        End If
        'Graphics
        ButtonStop.Enabled = True
        ButtonReset.Enabled = False
        ButtonStart.Enabled = False
        ButtonRes.Enabled = False
        GroupBoxTidy.Enabled = False
        ButtonStop.Font = New Font(ButtonStop.Font.FontFamily, 8, FontStyle.Bold)
        ButtonStart.Font = New Font(ButtonStart.Font.FontFamily, 8, FontStyle.Regular)
        ButtonStop.Height = 50
        ButtonStop.Location = New Point(94, 12)
        ButtonStart.Height = 23
        ButtonStart.Location = New Point(13, 26)
        ButtonStop.Text = "STOP"
        ButtonStart.Text = "Start"
        'Timer
        TimerTimer.Enabled = True
        'Progress Bar Values
        sec = ComboBoxSeconds.Text
        min = ComboBoxMinutes.Text
        hrs = ComboBoxHours.Text
        min = min * 60
        hrs = hrs * 3600
        Complex = sec + min + hrs
        ProgressBar.Maximum = Complex
    End Sub
    Private Sub ButtonStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStop.Click
        'Timer
        TimerTimer.Enabled = False
        'Graphics
        ButtonStop.Enabled = False
        ButtonReset.Enabled = True
        ButtonStart.Enabled = True
        ButtonRes.Enabled = True
        GroupBoxTidy.Enabled = True
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
        ComboBoxHours.Text = 0
        ComboBoxMinutes.Text = 0
        ComboBoxSeconds.Text = 0
        RadioButtonTidy.Checked = False
        ButtonStop.Enabled = False
        ButtonReset.Enabled = True
        ButtonStart.Enabled = True
        ButtonRes.Enabled = False
        GroupBoxTidy.Enabled = True
        ButtonStop.Font = New Font(ButtonStop.Font.FontFamily, 8, FontStyle.Regular)
        ButtonStart.Font = New Font(ButtonStart.Font.FontFamily, 8, FontStyle.Bold)
        ButtonStop.Height = 23
        ButtonStop.Location = New Point(13, 26)
        ButtonStart.Height = 50
        ButtonStart.Location = New Point(94, 12)
        ButtonStop.Text = "Stop"
        ButtonStart.Text = "START"
        ss = 0
        ms = 0
        mm = 0
        hm = 0
        tsec = 0
        tmin = 0
        thrs = 0
        sec = 0
        min = 0
        hrs = 0
        Complex = 0
        possible = False
        ProgressBar.Value = 0
        ProgressBar.Maximum = 100
    End Sub
    Private Sub TimerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTimer.Tick
        If possible = True Then
            If ComboBoxSeconds.Text = 0 Then
                If ComboBoxMinutes.Text > 0 Then
                    ComboBoxMinutes.Text -= 1
                    ComboBoxSeconds.Text = 59
                ElseIf ComboBoxMinutes.Text = 0 Then
                    If ComboBoxHours.Text > 0 Then
                        ComboBoxHours.Text -= 1
                        ComboBoxMinutes.Text = 59
                        ComboBoxSeconds.Text = 59
                    Else
                        TimerTimer.Enabled = False
                        MsgBox("Time is finished", MsgBoxStyle.Information, "End")
                        Exit Sub
                    End If
                End If
            End If
            ComboBoxSeconds.Text -= 1
            'Progress Bar Update
            ProgressBar.Value += 1
        End If
    End Sub
    Private Sub ButtonRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRes.Click
        ComboBoxSeconds.Text = tsec
        ComboBoxMinutes.Text = tmin
        ComboBoxHours.Text = thrs
        ProgressBar.Value = 0
    End Sub
    Private Sub ButtonTidy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTidy.Click
        If IsNumeric(ComboBoxSeconds.Text) And IsNumeric(ComboBoxMinutes.Text) And IsNumeric(ComboBoxHours.Text) Then
            If ComboBoxSeconds.Text > 59 Then
                tidySeconds()
                If ComboBoxMinutes.Text > 59 Then
                    tidyMinutes()
                End If
                MsgBox("The values are now tidied", MsgBoxStyle.Information, "Tidy")
            ElseIf ComboBoxMinutes.Text > 59 Then
                tidyMinutes()
                MsgBox("The values are now tidied", MsgBoxStyle.Information, "Tidy")
            Else
                MsgBox("Nothing to tidy", MsgBoxStyle.Information, "Tidy")
            End If
        Else
            MsgBox("Impossible to tidy these values, please change them", MsgBoxStyle.Critical, "Error")
            possible = False
        End If
        'Values for restart
        tsec = ComboBoxSeconds.Text
        tmin = ComboBoxMinutes.Text
        thrs = ComboBoxHours.Text
    End Sub
    Private Sub ComboBoxSeconds_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxSeconds.SelectedValueChanged
        If ComboBoxSeconds.Text = "" Then
            ComboBoxSeconds.Text = 0
        End If
    End Sub
    Private Sub ComboBoxMinutes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxMinutes.SelectedValueChanged
        If ComboBoxMinutes.Text = "" Then
            ComboBoxMinutes.Text = 0
        End If
    End Sub
    Private Sub ComboBoxHours_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxHours.SelectedValueChanged
        If ComboBoxHours.Text = "" Then
            ComboBoxHours.Text = 0
        End If
    End Sub
    Private Sub ButtonClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClose.Click
        If MsgBox("Are you sure you want to close this module?", vbYesNo, "Quit") = vbYes Then
            Me.Close()
        Else
            Exit Sub
        End If
    End Sub
End Class
