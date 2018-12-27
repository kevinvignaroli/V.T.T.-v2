<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPreferences
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
        Me.GroupBoxCustomization = New System.Windows.Forms.GroupBox()
        Me.ListBoxColors = New System.Windows.Forms.ListBox()
        Me.RadioButtonColor = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDark = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDefault = New System.Windows.Forms.RadioButton()
        Me.GroupBoxCustomization.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCustomization
        '
        Me.GroupBoxCustomization.Controls.Add(Me.ListBoxColors)
        Me.GroupBoxCustomization.Controls.Add(Me.RadioButtonColor)
        Me.GroupBoxCustomization.Controls.Add(Me.RadioButtonDark)
        Me.GroupBoxCustomization.Controls.Add(Me.RadioButtonDefault)
        Me.GroupBoxCustomization.Location = New System.Drawing.Point(13, 13)
        Me.GroupBoxCustomization.Name = "GroupBoxCustomization"
        Me.GroupBoxCustomization.Size = New System.Drawing.Size(259, 183)
        Me.GroupBoxCustomization.TabIndex = 0
        Me.GroupBoxCustomization.TabStop = False
        Me.GroupBoxCustomization.Text = "Color Customization"
        '
        'ListBoxColors
        '
        Me.ListBoxColors.Enabled = False
        Me.ListBoxColors.FormattingEnabled = True
        Me.ListBoxColors.Items.AddRange(New Object() {"Green", "Cyan", "Blue", "Purple", "Pink", "Salmon©", "Red", "Orange", "Yellow"})
        Me.ListBoxColors.Location = New System.Drawing.Point(7, 92)
        Me.ListBoxColors.Name = "ListBoxColors"
        Me.ListBoxColors.Size = New System.Drawing.Size(246, 82)
        Me.ListBoxColors.TabIndex = 3
        '
        'RadioButtonColor
        '
        Me.RadioButtonColor.AutoSize = True
        Me.RadioButtonColor.Location = New System.Drawing.Point(7, 68)
        Me.RadioButtonColor.Name = "RadioButtonColor"
        Me.RadioButtonColor.Size = New System.Drawing.Size(91, 17)
        Me.RadioButtonColor.TabIndex = 2
        Me.RadioButtonColor.Text = "Colored Mode"
        Me.RadioButtonColor.UseVisualStyleBackColor = True
        '
        'RadioButtonDark
        '
        Me.RadioButtonDark.AutoSize = True
        Me.RadioButtonDark.Location = New System.Drawing.Point(7, 44)
        Me.RadioButtonDark.Name = "RadioButtonDark"
        Me.RadioButtonDark.Size = New System.Drawing.Size(109, 17)
        Me.RadioButtonDark.TabIndex = 1
        Me.RadioButtonDark.Text = "Dark Mode (Beta)"
        Me.RadioButtonDark.UseVisualStyleBackColor = True
        '
        'RadioButtonDefault
        '
        Me.RadioButtonDefault.AutoSize = True
        Me.RadioButtonDefault.Checked = True
        Me.RadioButtonDefault.Location = New System.Drawing.Point(7, 20)
        Me.RadioButtonDefault.Name = "RadioButtonDefault"
        Me.RadioButtonDefault.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonDefault.TabIndex = 0
        Me.RadioButtonDefault.TabStop = True
        Me.RadioButtonDefault.Text = "Default"
        Me.RadioButtonDefault.UseVisualStyleBackColor = True
        '
        'FormPreferences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(284, 206)
        Me.Controls.Add(Me.GroupBoxCustomization)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 244)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 244)
        Me.Name = "FormPreferences"
        Me.ShowIcon = False
        Me.Text = "Preferences"
        Me.GroupBoxCustomization.ResumeLayout(False)
        Me.GroupBoxCustomization.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxCustomization As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxColors As System.Windows.Forms.ListBox
    Friend WithEvents RadioButtonColor As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDark As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonDefault As System.Windows.Forms.RadioButton
End Class
