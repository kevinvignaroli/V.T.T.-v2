<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStopwatch
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
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ButtonStart = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.TimerStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.LabelCentiseconds = New System.Windows.Forms.Label()
        Me.LabelSeconds = New System.Windows.Forms.Label()
        Me.LabelMinutes = New System.Windows.Forms.Label()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.GroupBoxSplit = New System.Windows.Forms.GroupBox()
        Me.ButtonDLSplit = New System.Windows.Forms.Button()
        Me.ListBoxSplit = New System.Windows.Forms.ListBox()
        Me.ButtonSplit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBoxSplit.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonStop
        '
        Me.ButtonStop.Enabled = False
        Me.ButtonStop.Location = New System.Drawing.Point(13, 26)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(75, 23)
        Me.ButtonStop.TabIndex = 0
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonStart
        '
        Me.ButtonStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStart.Location = New System.Drawing.Point(94, 12)
        Me.ButtonStart.Name = "ButtonStart"
        Me.ButtonStart.Size = New System.Drawing.Size(75, 50)
        Me.ButtonStart.TabIndex = 1
        Me.ButtonStart.Text = "START"
        Me.ButtonStart.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(175, 26)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 2
        Me.ButtonReset.Text = "Reset"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'TimerStopwatch
        '
        Me.TimerStopwatch.Interval = 10
        '
        'LabelCentiseconds
        '
        Me.LabelCentiseconds.BackColor = System.Drawing.Color.White
        Me.LabelCentiseconds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelCentiseconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCentiseconds.Location = New System.Drawing.Point(175, 94)
        Me.LabelCentiseconds.Name = "LabelCentiseconds"
        Me.LabelCentiseconds.Size = New System.Drawing.Size(75, 42)
        Me.LabelCentiseconds.TabIndex = 3
        Me.LabelCentiseconds.Text = "00"
        Me.LabelCentiseconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelSeconds
        '
        Me.LabelSeconds.BackColor = System.Drawing.Color.White
        Me.LabelSeconds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSeconds.Location = New System.Drawing.Point(94, 94)
        Me.LabelSeconds.Name = "LabelSeconds"
        Me.LabelSeconds.Size = New System.Drawing.Size(75, 42)
        Me.LabelSeconds.TabIndex = 4
        Me.LabelSeconds.Text = "00"
        Me.LabelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelMinutes
        '
        Me.LabelMinutes.BackColor = System.Drawing.Color.White
        Me.LabelMinutes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LabelMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMinutes.Location = New System.Drawing.Point(13, 94)
        Me.LabelMinutes.Name = "LabelMinutes"
        Me.LabelMinutes.Size = New System.Drawing.Size(75, 42)
        Me.LabelMinutes.TabIndex = 5
        Me.LabelMinutes.Text = "00"
        Me.LabelMinutes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Location = New System.Drawing.Point(12, 312)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(237, 23)
        Me.ButtonQuit.TabIndex = 8
        Me.ButtonQuit.Text = "Close Module"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'GroupBoxSplit
        '
        Me.GroupBoxSplit.Controls.Add(Me.ButtonDLSplit)
        Me.GroupBoxSplit.Controls.Add(Me.ListBoxSplit)
        Me.GroupBoxSplit.Controls.Add(Me.ButtonSplit)
        Me.GroupBoxSplit.Location = New System.Drawing.Point(13, 140)
        Me.GroupBoxSplit.Name = "GroupBoxSplit"
        Me.GroupBoxSplit.Size = New System.Drawing.Size(237, 166)
        Me.GroupBoxSplit.TabIndex = 9
        Me.GroupBoxSplit.TabStop = False
        Me.GroupBoxSplit.Text = "Split tools"
        '
        'ButtonDLSplit
        '
        Me.ButtonDLSplit.Enabled = False
        Me.ButtonDLSplit.Location = New System.Drawing.Point(6, 137)
        Me.ButtonDLSplit.Name = "ButtonDLSplit"
        Me.ButtonDLSplit.Size = New System.Drawing.Size(225, 23)
        Me.ButtonDLSplit.TabIndex = 16
        Me.ButtonDLSplit.Text = "Delete last split"
        Me.ButtonDLSplit.UseVisualStyleBackColor = True
        '
        'ListBoxSplit
        '
        Me.ListBoxSplit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxSplit.FormattingEnabled = True
        Me.ListBoxSplit.Items.AddRange(New Object() {"#0 00:00:00"})
        Me.ListBoxSplit.Location = New System.Drawing.Point(6, 62)
        Me.ListBoxSplit.Name = "ListBoxSplit"
        Me.ListBoxSplit.Size = New System.Drawing.Size(225, 69)
        Me.ListBoxSplit.TabIndex = 15
        '
        'ButtonSplit
        '
        Me.ButtonSplit.Location = New System.Drawing.Point(6, 19)
        Me.ButtonSplit.Name = "ButtonSplit"
        Me.ButtonSplit.Size = New System.Drawing.Size(225, 37)
        Me.ButtonSplit.TabIndex = 14
        Me.ButtonSplit.Text = "Split"
        Me.ButtonSplit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Minutes:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Seconds:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(175, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Centiseconds:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormStopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(263, 344)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBoxSplit)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.LabelMinutes)
        Me.Controls.Add(Me.LabelSeconds)
        Me.Controls.Add(Me.LabelCentiseconds)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonStart)
        Me.Controls.Add(Me.ButtonStop)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(279, 382)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(279, 382)
        Me.Name = "FormStopwatch"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stopwatch"
        Me.GroupBoxSplit.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents ButtonStart As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents TimerStopwatch As System.Windows.Forms.Timer
    Friend WithEvents LabelCentiseconds As System.Windows.Forms.Label
    Friend WithEvents LabelSeconds As System.Windows.Forms.Label
    Friend WithEvents LabelMinutes As System.Windows.Forms.Label
    Friend WithEvents ButtonQuit As System.Windows.Forms.Button
    Friend WithEvents GroupBoxSplit As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonDLSplit As System.Windows.Forms.Button
    Friend WithEvents ListBoxSplit As System.Windows.Forms.ListBox
    Friend WithEvents ButtonSplit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
