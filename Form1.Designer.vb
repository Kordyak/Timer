<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.But_play = New System.Windows.Forms.Button()
        Me.But_reset = New System.Windows.Forms.Button()
        Me.But_10 = New System.Windows.Forms.Button()
        Me.But_5 = New System.Windows.Forms.Button()
        Me.But_1 = New System.Windows.Forms.Button()
        Me.Label_timer = New System.Windows.Forms.Label()
        Me.But_30s = New System.Windows.Forms.Button()
        Me.But_drop = New System.Windows.Forms.Button()
        Me.Check_hibernate = New System.Windows.Forms.CheckBox()
        Me.But_30s_ = New System.Windows.Forms.Button()
        Me.But_10_ = New System.Windows.Forms.Button()
        Me.But_5_ = New System.Windows.Forms.Button()
        Me.But_1_ = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'But_play
        '
        Me.But_play.Location = New System.Drawing.Point(232, 87)
        Me.But_play.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_play.Name = "But_play"
        Me.But_play.Size = New System.Drawing.Size(75, 77)
        Me.But_play.TabIndex = 1
        Me.But_play.Text = "play"
        Me.But_play.UseVisualStyleBackColor = True
        '
        'But_reset
        '
        Me.But_reset.Location = New System.Drawing.Point(316, 87)
        Me.But_reset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_reset.Name = "But_reset"
        Me.But_reset.Size = New System.Drawing.Size(75, 77)
        Me.But_reset.TabIndex = 2
        Me.But_reset.Text = "reset"
        Me.But_reset.UseVisualStyleBackColor = True
        '
        'But_10
        '
        Me.But_10.Location = New System.Drawing.Point(22, 197)
        Me.But_10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_10.Name = "But_10"
        Me.But_10.Size = New System.Drawing.Size(68, 35)
        Me.But_10.TabIndex = 6
        Me.But_10.Text = "+10m"
        Me.But_10.UseVisualStyleBackColor = True
        '
        'But_5
        '
        Me.But_5.Location = New System.Drawing.Point(22, 152)
        Me.But_5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_5.Name = "But_5"
        Me.But_5.Size = New System.Drawing.Size(68, 35)
        Me.But_5.TabIndex = 5
        Me.But_5.Text = "+5m"
        Me.But_5.UseVisualStyleBackColor = True
        '
        'But_1
        '
        Me.But_1.Location = New System.Drawing.Point(22, 108)
        Me.But_1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_1.Name = "But_1"
        Me.But_1.Size = New System.Drawing.Size(68, 35)
        Me.But_1.TabIndex = 4
        Me.But_1.Text = "+1m"
        Me.But_1.UseVisualStyleBackColor = True
        '
        'Label_timer
        '
        Me.Label_timer.AutoSize = True
        Me.Label_timer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label_timer.Location = New System.Drawing.Point(110, 14)
        Me.Label_timer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_timer.Name = "Label_timer"
        Me.Label_timer.Size = New System.Drawing.Size(77, 25)
        Me.Label_timer.TabIndex = 7
        Me.Label_timer.Text = "Label1"
        '
        'But_30s
        '
        Me.But_30s.Location = New System.Drawing.Point(22, 63)
        Me.But_30s.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_30s.Name = "But_30s"
        Me.But_30s.Size = New System.Drawing.Size(68, 35)
        Me.But_30s.TabIndex = 8
        Me.But_30s.Text = "+30s"
        Me.But_30s.UseVisualStyleBackColor = True
        '
        'But_drop
        '
        Me.But_drop.Location = New System.Drawing.Point(316, 174)
        Me.But_drop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_drop.Name = "But_drop"
        Me.But_drop.Size = New System.Drawing.Size(75, 77)
        Me.But_drop.TabIndex = 9
        Me.But_drop.Text = "drop"
        Me.But_drop.UseVisualStyleBackColor = True
        '
        'Check_hibernate
        '
        Me.Check_hibernate.AutoSize = True
        Me.Check_hibernate.Location = New System.Drawing.Point(232, 43)
        Me.Check_hibernate.Name = "Check_hibernate"
        Me.Check_hibernate.Size = New System.Drawing.Size(130, 24)
        Me.Check_hibernate.TabIndex = 10
        Me.Check_hibernate.Text = "Hibernate PC"
        Me.Check_hibernate.UseVisualStyleBackColor = True
        '
        'But_30s_
        '
        Me.But_30s_.Location = New System.Drawing.Point(98, 63)
        Me.But_30s_.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_30s_.Name = "But_30s_"
        Me.But_30s_.Size = New System.Drawing.Size(68, 35)
        Me.But_30s_.TabIndex = 14
        Me.But_30s_.Text = "-30s"
        Me.But_30s_.UseVisualStyleBackColor = True
        '
        'But_10_
        '
        Me.But_10_.Location = New System.Drawing.Point(98, 197)
        Me.But_10_.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_10_.Name = "But_10_"
        Me.But_10_.Size = New System.Drawing.Size(68, 35)
        Me.But_10_.TabIndex = 13
        Me.But_10_.Text = "-10m"
        Me.But_10_.UseVisualStyleBackColor = True
        '
        'But_5_
        '
        Me.But_5_.Location = New System.Drawing.Point(98, 152)
        Me.But_5_.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_5_.Name = "But_5_"
        Me.But_5_.Size = New System.Drawing.Size(68, 35)
        Me.But_5_.TabIndex = 12
        Me.But_5_.Text = "-5m"
        Me.But_5_.UseVisualStyleBackColor = True
        '
        'But_1_
        '
        Me.But_1_.Location = New System.Drawing.Point(98, 108)
        Me.But_1_.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.But_1_.Name = "But_1_"
        Me.But_1_.Size = New System.Drawing.Size(68, 35)
        Me.But_1_.TabIndex = 11
        Me.But_1_.Text = "-1m"
        Me.But_1_.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(404, 265)
        Me.Controls.Add(Me.But_30s_)
        Me.Controls.Add(Me.But_10_)
        Me.Controls.Add(Me.But_5_)
        Me.Controls.Add(Me.But_1_)
        Me.Controls.Add(Me.Check_hibernate)
        Me.Controls.Add(Me.But_drop)
        Me.Controls.Add(Me.But_30s)
        Me.Controls.Add(Me.Label_timer)
        Me.Controls.Add(Me.But_10)
        Me.Controls.Add(Me.But_5)
        Me.Controls.Add(Me.But_1)
        Me.Controls.Add(Me.But_reset)
        Me.Controls.Add(Me.But_play)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Timer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents But_play As Button
    Friend WithEvents But_reset As Button
    Friend WithEvents But_10 As Button
    Friend WithEvents But_5 As Button
    Friend WithEvents But_1 As Button
    Friend WithEvents Label_timer As Label
    Friend WithEvents But_30s As Button
    Friend WithEvents But_drop As Button
    Friend WithEvents Check_hibernate As CheckBox
    Friend WithEvents But_30s_ As Button
    Friend WithEvents But_10_ As Button
    Friend WithEvents But_5_ As Button
    Friend WithEvents But_1_ As Button
End Class
