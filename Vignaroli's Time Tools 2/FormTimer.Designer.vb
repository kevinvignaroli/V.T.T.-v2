<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ComboBoxHours = New System.Windows.Forms.ComboBox()
        Me.ComboBoxMinutes = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSeconds = New System.Windows.Forms.ComboBox()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.TimerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonRes = New System.Windows.Forms.Button()
        Me.ButtonTidy = New System.Windows.Forms.Button()
        Me.GroupBoxTidy = New System.Windows.Forms.GroupBox()
        Me.RadioButtonTidy = New System.Windows.Forms.RadioButton()
        Me.GroupBoxTidy.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Seconds:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Minutes:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Hours:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(175, 26)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 15
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(94, 12)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 50)
        Me.ButtonStart.TabIndex = 14
        Me.ButtonStart.Text = "START"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonStop
        '
        Me.ButtonStop.Enabled = False
        Me.ButtonStop.Location = New System.Drawing.Point(13, 26)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStop.TabIndex = 13
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ComboBoxHours
        '
        Me.ComboBoxHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxHours.FormattingEnabled = True
        Me.ComboBoxHours.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.ComboBoxHours.Location = New System.Drawing.Point(13, 197)
        Me.ComboBoxHours.Name = "ComboBoxHours"
        Me.ComboBoxHours.Size = New System.Drawing.Size(75, 41)
        Me.ComboBoxHours.TabIndex = 22
        Me.ComboBoxHours.Text = "0"
        '
        'ComboBoxMinutes
        '
        Me.ComboBoxMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMinutes.FormattingEnabled = True
        Me.ComboBoxMinutes.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.ComboBoxMinutes.Location = New System.Drawing.Point(94, 198)
        Me.ComboBoxMinutes.Name = "ComboBoxMinutes"
        Me.ComboBoxMinutes.Size = New System.Drawing.Size(75, 41)
        Me.ComboBoxMinutes.TabIndex = 23
        Me.ComboBoxMinutes.Text = "0"
        '
        'ComboBoxSeconds
        '
        Me.ComboBoxSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxSeconds.FormattingEnabled = True
        Me.ComboBoxSeconds.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.ComboBoxSeconds.Location = New System.Drawing.Point(175, 198)
        Me.ComboBoxSeconds.Name = "ComboBoxSeconds"
        Me.ComboBoxSeconds.Size = New System.Drawing.Size(75, 41)
        Me.ComboBoxSeconds.TabIndex = 24
        Me.ComboBoxSeconds.Text = "0"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(13, 246)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(237, 23)
        Me.ProgressBar.TabIndex = 25
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(13, 276)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(237, 23)
        Me.ButtonClose.TabIndex = 26
        Me.ButtonClose.Text = "Close Module"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'TimerTimer
        '
        Me.TimerTimer.Interval = 1000
        '
        'ButtonRes
        '
        Me.ButtonRes.Location = New System.Drawing.Point(12, 68)
        Me.ButtonRes.Name = "ButtonRes"
        Me.ButtonRes.Size = New System.Drawing.Size(237, 23)
        Me.ButtonRes.TabIndex = 27
        Me.ButtonRes.Text = "Restart"
        Me.ButtonRes.UseVisualStyleBackColor = True
        '
        'ButtonTidy
        '
        Me.ButtonTidy.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonTidy.Location = New System.Drawing.Point(6, 42)
        Me.ButtonTidy.Name = "ButtonTidy"
        Me.ButtonTidy.Size = New System.Drawing.Size(224, 23)
        Me.ButtonTidy.TabIndex = 28
        Me.ButtonTidy.Text = "Tidy your values now"
        Me.ButtonTidy.UseVisualStyleBackColor = False
        '
        'GroupBoxTidy
        '
        Me.GroupBoxTidy.Controls.Add(Me.RadioButtonTidy)
        Me.GroupBoxTidy.Controls.Add(Me.ButtonTidy)
        Me.GroupBoxTidy.Location = New System.Drawing.Point(13, 98)
        Me.GroupBoxTidy.Name = "GroupBoxTidy"
        Me.GroupBoxTidy.Size = New System.Drawing.Size(236, 73)
        Me.GroupBoxTidy.TabIndex = 29
        Me.GroupBoxTidy.TabStop = False
        Me.GroupBoxTidy.Text = "Values Tidy System©"
        '
        'RadioButtonTidy
        '
        Me.RadioButtonTidy.AutoSize = True
        Me.RadioButtonTidy.Location = New System.Drawing.Point(6, 19)
        Me.RadioButtonTidy.Name = "RadioButtonTidy"
        Me.RadioButtonTidy.Size = New System.Drawing.Size(114, 17)
        Me.RadioButtonTidy.TabIndex = 29
        Me.RadioButtonTidy.TabStop = True
        Me.RadioButtonTidy.Text = "Tidy values at start"
        Me.RadioButtonTidy.UseVisualStyleBackColor = True
        '
        'FormTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(261, 307)
        Me.Controls.Add(Me.GroupBoxTidy)
        Me.Controls.Add(Me.ButtonRes)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.ComboBoxSeconds)
        Me.Controls.Add(Me.ComboBoxMinutes)
        Me.Controls.Add(Me.ComboBoxHours)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonStop)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(277, 345)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(277, 345)
        Me.Name = "FormTimer"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Timer"
        Me.GroupBoxTidy.ResumeLayout(False)
        Me.GroupBoxTidy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents ComboBoxHours As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxMinutes As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxSeconds As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents ButtonClose As System.Windows.Forms.Button
    Friend WithEvents TimerTimer As System.Windows.Forms.Timer
    Friend WithEvents ButtonRes As System.Windows.Forms.Button
    Friend WithEvents ButtonTidy As System.Windows.Forms.Button
    Friend WithEvents GroupBoxTidy As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButtonTidy As System.Windows.Forms.RadioButton
End Class
