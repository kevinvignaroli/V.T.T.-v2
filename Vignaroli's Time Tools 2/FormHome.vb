Public Class FormHome
    Dim stopwatchVisible, timerVisible, preferencesVisible As Boolean
    'Show stopwatch window
    Private Sub ButtonStopwatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStopwatch.Click
        colorCheck()
        FormStopwatch.Show()
    End Sub
    'Show timer window
    Private Sub ButtonTimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonTimer.Click
        colorCheck()
        FormTimer.Show()
    End Sub
    'Show preferences window
    Private Sub ButtonPreferences_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPreferences.Click
        colorCheck()
        FormPreferences.Show()
    End Sub
    'Show about window and hide all others windows
    Private Sub ButtonAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAbout.Click
        Me.Hide()
        FormTimer.Hide()
        FormStopwatch.Hide()
        FormPreferences.Hide()
        AboutBox.Show()
    End Sub
    'Quit the application
    Private Sub ButtonQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonQuit.Click
        If MsgBox("Are you sure you want to quit the application?", vbYesNo, "Quit") = vbYes Then
            End
        Else
            Exit Sub
        End If
    End Sub
    'If you close one of the windows the preferences that you applied before don't work anymore. With this function everytime you open a window the program checks for the preferences and applies them again
    Function colorCheck()
        If Me.BackColor = Color.WhiteSmoke Then
            FormPreferences.RadioButtonDefault.Checked = True
            FormPreferences.ListBoxColors.Enabled = False
            FormTimer.BackColor = Color.WhiteSmoke
            FormStopwatch.BackColor = Color.WhiteSmoke
            secondariesToBlackHome()
        ElseIf Me.BackColor = Color.Black Then
            FormPreferences.BackColor = Color.Black
            FormPreferences.RadioButtonDark.Checked = True
            FormPreferences.ListBoxColors.Enabled = False
            FormTimer.BackColor = Color.Black
            FormStopwatch.BackColor = Color.Black
            secondariesToWhiteHome()
        Else
            FormPreferences.RadioButtonColor.Checked = True
            FormPreferences.ListBoxColors.Enabled = True
            If Me.BackColor = Color.LightGreen Then
                FormPreferences.BackColor = Color.LightGreen
                FormStopwatch.BackColor = Color.LightGreen
                FormTimer.BackColor = Color.LightGreen
                secondariesToBlackHome()
            ElseIf Me.BackColor = Color.Cyan Then
                FormPreferences.BackColor = Color.Cyan
                FormStopwatch.BackColor = Color.Cyan
                FormTimer.BackColor = Color.Cyan
                secondariesToBlackHome()
            ElseIf Me.BackColor = Color.LightBlue Then
                FormPreferences.BackColor = Color.LightBlue
                FormStopwatch.BackColor = Color.LightBlue
                FormTimer.BackColor = Color.LightBlue
                secondariesToBlackHome()
            ElseIf Me.BackColor = Color.Purple Then
                FormPreferences.BackColor = Color.Purple
                FormStopwatch.BackColor = Color.Purple
                FormTimer.BackColor = Color.Purple
                secondariesToWhiteHome()
            ElseIf Me.BackColor = Color.Pink Then
                FormPreferences.BackColor = Color.Pink
                FormStopwatch.BackColor = Color.Pink
                FormTimer.BackColor = Color.Pink
                secondariesToBlackHome()
            ElseIf Me.BackColor = Color.Salmon Then
                FormPreferences.BackColor = Color.Salmon
                FormStopwatch.BackColor = Color.Salmon
                FormTimer.BackColor = Color.Salmon
                secondariesToBlackHome()
            ElseIf Me.BackColor = Color.Tomato Then
                FormPreferences.BackColor = Color.Tomato
                FormStopwatch.BackColor = Color.Tomato
                FormTimer.BackColor = Color.Tomato
                secondariesToWhiteHome()
            ElseIf Me.BackColor = Color.Orange Then
                FormPreferences.BackColor = Color.Orange
                FormStopwatch.BackColor = Color.Orange
                FormTimer.BackColor = Color.Orange
                secondariesToBlackHome()
            ElseIf Me.BackColor = Color.Yellow Then
                FormPreferences.BackColor = Color.Yellow
                FormStopwatch.BackColor = Color.Yellow
                FormTimer.BackColor = Color.Yellow
                secondariesToBlackHome()
            End If
        End If
    End Function
    Function secondariesToBlackHome()
        FormPreferences.GroupBoxCustomization.ForeColor = Color.Black
        Me.LabelTitle.ForeColor = Color.Black
        FormTimer.GroupBoxTidy.ForeColor = Color.Black
        FormTimer.Label1.ForeColor = Color.Black
        FormTimer.Label2.ForeColor = Color.Black
        FormTimer.Label3.ForeColor = Color.Black
        FormStopwatch.GroupBoxSplit.ForeColor = Color.Black
        FormStopwatch.Label1.ForeColor = Color.Black
        FormStopwatch.Label2.ForeColor = Color.Black
        FormStopwatch.Label3.ForeColor = Color.Black
    End Function
    Function secondariesToWhiteHome()
        FormPreferences.GroupBoxCustomization.ForeColor = Color.White
        FormPreferences.ListBoxColors.ForeColor = Color.Black
        Me.LabelTitle.ForeColor = Color.White
        FormTimer.GroupBoxTidy.ForeColor = Color.White
        FormTimer.ButtonTidy.ForeColor = Color.Black
        FormTimer.Label1.ForeColor = Color.White
        FormTimer.Label2.ForeColor = Color.White
        FormTimer.Label3.ForeColor = Color.White
        FormStopwatch.GroupBoxSplit.ForeColor = Color.White
        FormStopwatch.ButtonSplit.ForeColor = Color.Black
        FormStopwatch.ButtonDLSplit.ForeColor = Color.Black
        FormStopwatch.ListBoxSplit.ForeColor = Color.Black
        FormStopwatch.Label1.ForeColor = Color.White
        FormStopwatch.Label2.ForeColor = Color.White
        FormStopwatch.Label3.ForeColor = Color.White
    End Function
End Class