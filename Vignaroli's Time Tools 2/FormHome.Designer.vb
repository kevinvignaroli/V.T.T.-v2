<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHome
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
        Me.ButtonStopwatch = New System.Windows.Forms.Button()
        Me.ButtonTimer = New System.Windows.Forms.Button()
        Me.ButtonPreferences = New System.Windows.Forms.Button()
        Me.ButtonAbout = New System.Windows.Forms.Button()
        Me.ButtonQuit = New System.Windows.Forms.Button()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtonStopwatch
        '
        Me.ButtonStopwatch.Location = New System.Drawing.Point(12, 63)
        Me.ButtonStopwatch.Name = "ButtonStopwatch"
        Me.ButtonStopwatch.Size = New System.Drawing.Size(260, 23)
        Me.ButtonStopwatch.TabIndex = 0
        Me.ButtonStopwatch.Text = "Stopwatch"
        Me.ButtonStopwatch.UseVisualStyleBackColor = True
        '
        'ButtonTimer
        '
        Me.ButtonTimer.Location = New System.Drawing.Point(12, 93)
        Me.ButtonTimer.Name = "ButtonTimer"
        Me.ButtonTimer.Size = New System.Drawing.Size(260, 23)
        Me.ButtonTimer.TabIndex = 1
        Me.ButtonTimer.Text = "Timer"
        Me.ButtonTimer.UseVisualStyleBackColor = True
        '
        'ButtonPreferences
        '
        Me.ButtonPreferences.Location = New System.Drawing.Point(12, 123)
        Me.ButtonPreferences.Name = "ButtonPreferences"
        Me.ButtonPreferences.Size = New System.Drawing.Size(260, 23)
        Me.ButtonPreferences.TabIndex = 2
        Me.ButtonPreferences.Text = "Preferences"
        Me.ButtonPreferences.UseVisualStyleBackColor = True
        '
        'ButtonAbout
        '
        Me.ButtonAbout.Location = New System.Drawing.Point(12, 153)
        Me.ButtonAbout.Name = "ButtonAbout"
        Me.ButtonAbout.Size = New System.Drawing.Size(260, 23)
        Me.ButtonAbout.TabIndex = 3
        Me.ButtonAbout.Text = "About"
        Me.ButtonAbout.UseVisualStyleBackColor = True
        '
        'ButtonQuit
        '
        Me.ButtonQuit.Location = New System.Drawing.Point(12, 183)
        Me.ButtonQuit.Name = "ButtonQuit"
        Me.ButtonQuit.Size = New System.Drawing.Size(260, 23)
        Me.ButtonQuit.TabIndex = 4
        Me.ButtonQuit.Text = "Quit"
        Me.ButtonQuit.UseVisualStyleBackColor = True
        '
        'LabelTitle
        '
        Me.LabelTitle.Font = New System.Drawing.Font("Rockwell", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(12, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(260, 51)
        Me.LabelTitle.TabIndex = 5
        Me.LabelTitle.Text = "Vignaroli's Time Tools 2"
        Me.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(284, 218)
        Me.ControlBox = False
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.ButtonQuit)
        Me.Controls.Add(Me.ButtonAbout)
        Me.Controls.Add(Me.ButtonPreferences)
        Me.Controls.Add(Me.ButtonTimer)
        Me.Controls.Add(Me.ButtonStopwatch)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 256)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 256)
        Me.Name = "FormHome"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonStopwatch As System.Windows.Forms.Button
    Friend WithEvents ButtonTimer As System.Windows.Forms.Button
    Friend WithEvents ButtonPreferences As System.Windows.Forms.Button
    Friend WithEvents ButtonAbout As System.Windows.Forms.Button
    Friend WithEvents ButtonQuit As System.Windows.Forms.Button
    Friend WithEvents LabelTitle As System.Windows.Forms.Label
End Class
