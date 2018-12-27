Public Class FormPreferences
    Function darkChange()
        ListBoxColors.Enabled = False
        Me.BackColor = Color.Black
        FormHome.BackColor = Color.Black
        FormTimer.BackColor = Color.Black
        FormStopwatch.BackColor = Color.Black
    End Function
    Function defaultChange()
        ListBoxColors.Enabled = False
        Me.BackColor = Color.WhiteSmoke
        FormHome.BackColor = Color.WhiteSmoke
        FormTimer.BackColor = Color.WhiteSmoke
        FormStopwatch.BackColor = Color.WhiteSmoke
    End Function
    Function colorChange()
        ListBoxColors.Enabled = True
        If ListBoxColors.SelectedItem = "Green" Then
            Me.BackColor = Color.LightGreen
            FormHome.BackColor = Color.LightGreen
            FormStopwatch.BackColor = Color.LightGreen
            FormTimer.BackColor = Color.LightGreen
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Cyan" Then
            Me.BackColor = Color.Cyan
            FormHome.BackColor = Color.Cyan
            FormStopwatch.BackColor = Color.Cyan
            FormTimer.BackColor = Color.Cyan
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Blue" Then
            Me.BackColor = Color.LightBlue
            FormHome.BackColor = Color.LightBlue
            FormStopwatch.BackColor = Color.LightBlue
            FormTimer.BackColor = Color.LightBlue
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Purple" Then
            Me.BackColor = Color.Purple
            FormHome.BackColor = Color.Purple
            FormStopwatch.BackColor = Color.Purple
            FormTimer.BackColor = Color.Purple
            secondariesToWhite()
        ElseIf ListBoxColors.SelectedItem = "Pink" Then
            Me.BackColor = Color.Pink
            FormHome.BackColor = Color.Pink
            FormStopwatch.BackColor = Color.Pink
            FormTimer.BackColor = Color.Pink
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Salmon©" Then
            Me.BackColor = Color.Salmon
            FormHome.BackColor = Color.Salmon
            FormStopwatch.BackColor = Color.Salmon
            FormTimer.BackColor = Color.Salmon
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Red" Then
            Me.BackColor = Color.Tomato
            FormHome.BackColor = Color.Tomato
            FormStopwatch.BackColor = Color.Tomato
            FormTimer.BackColor = Color.Tomato
            secondariesToWhite()
        ElseIf ListBoxColors.SelectedItem = "Orange" Then
            Me.BackColor = Color.Orange
            FormHome.BackColor = Color.Orange
            FormStopwatch.BackColor = Color.Orange
            FormTimer.BackColor = Color.Orange
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Yellow" Then
            Me.BackColor = Color.Yellow
            FormHome.BackColor = Color.Yellow
            FormStopwatch.BackColor = Color.Yellow
            FormTimer.BackColor = Color.Yellow
            secondariesToBlack()
        End If
    End Function
    Function secondariesToBlack()
        Me.GroupBoxCustomization.ForeColor = Color.Black
        FormHome.LabelTitle.ForeColor = Color.Black
        FormTimer.GroupBoxTidy.ForeColor = Color.Black
        FormTimer.Label1.ForeColor = Color.Black
        FormTimer.Label2.ForeColor = Color.Black
        FormTimer.Label3.ForeColor = Color.Black
        FormStopwatch.GroupBoxSplit.ForeColor = Color.Black
        FormStopwatch.Label1.ForeColor = Color.Black
        FormStopwatch.Label2.ForeColor = Color.Black
        FormStopwatch.Label3.ForeColor = Color.Black
    End Function
    Function secondariesToWhite()
        Me.GroupBoxCustomization.ForeColor = Color.White
        Me.ListBoxColors.ForeColor = Color.Black
        FormHome.LabelTitle.ForeColor = Color.White
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
    Private Sub RadioButtonDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDefault.CheckedChanged
        If RadioButtonDark.Checked = True Then
            darkChange()
            secondariesToWhite()
        ElseIf RadioButtonColor.Checked = True Then
            colorChange()
        End If
    End Sub
    Private Sub RadioButtonDark_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonDark.CheckedChanged
        If RadioButtonDefault.Checked = True Then
            defaultChange()
            secondariesToBlack()
        ElseIf RadioButtonColor.Checked = True Then
            colorChange()
        End If
    End Sub
    Private Sub RadioButtonColor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonColor.CheckedChanged
        If RadioButtonDefault.Checked = True Then
            defaultChange()
            secondariesToBlack()
        ElseIf RadioButtonDark.Checked = True Then
            darkChange()
            secondariesToWhite()
        End If
    End Sub
    Private Sub ListBoxColors_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxColors.SelectedIndexChanged
        If ListBoxColors.SelectedItem = "Green" Then
            Me.BackColor = Color.LightGreen
            FormHome.BackColor = Color.LightGreen
            FormStopwatch.BackColor = Color.LightGreen
            FormTimer.BackColor = Color.LightGreen
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Cyan" Then
            Me.BackColor = Color.Cyan
            FormHome.BackColor = Color.Cyan
            FormStopwatch.BackColor = Color.Cyan
            FormTimer.BackColor = Color.Cyan
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Blue" Then
            Me.BackColor = Color.LightBlue
            FormHome.BackColor = Color.LightBlue
            FormStopwatch.BackColor = Color.LightBlue
            FormTimer.BackColor = Color.LightBlue
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Purple" Then
            Me.BackColor = Color.Purple
            FormHome.BackColor = Color.Purple
            FormStopwatch.BackColor = Color.Purple
            FormTimer.BackColor = Color.Purple
            secondariesToWhite()
        ElseIf ListBoxColors.SelectedItem = "Pink" Then
            Me.BackColor = Color.Pink
            FormHome.BackColor = Color.Pink
            FormStopwatch.BackColor = Color.Pink
            FormTimer.BackColor = Color.Pink
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Salmon©" Then
            Me.BackColor = Color.Salmon
            FormHome.BackColor = Color.Salmon
            FormStopwatch.BackColor = Color.Salmon
            FormTimer.BackColor = Color.Salmon
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Red" Then
            Me.BackColor = Color.Tomato
            FormHome.BackColor = Color.Tomato
            FormStopwatch.BackColor = Color.Tomato
            FormTimer.BackColor = Color.Tomato
            secondariesToWhite()
        ElseIf ListBoxColors.SelectedItem = "Orange" Then
            Me.BackColor = Color.Orange
            FormHome.BackColor = Color.Orange
            FormStopwatch.BackColor = Color.Orange
            FormTimer.BackColor = Color.Orange
            secondariesToBlack()
        ElseIf ListBoxColors.SelectedItem = "Yellow" Then
            Me.BackColor = Color.Yellow
            FormHome.BackColor = Color.Yellow
            FormStopwatch.BackColor = Color.Yellow
            FormTimer.BackColor = Color.Yellow
            secondariesToBlack()
        End If
    End Sub
End Class