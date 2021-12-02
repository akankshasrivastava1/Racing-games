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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.roadmover = New System.Windows.Forms.Timer(Me.components)
        Me.Car = New System.Windows.Forms.PictureBox()
        Me.Left_mover = New System.Windows.Forms.Timer(Me.components)
        Me.Right_mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemycar1 = New System.Windows.Forms.PictureBox()
        Me.Enemycar2 = New System.Windows.Forms.PictureBox()
        Me.Enemycar3 = New System.Windows.Forms.PictureBox()
        Me.Enemy1_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy2_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.Enemy3_Mover = New System.Windows.Forms.Timer(Me.components)
        Me.End_Text = New System.Windows.Forms.Label()
        Me.Score_Text = New System.Windows.Forms.Label()
        Me.Replay_Button = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemycar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemycar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemycar3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.Location = New System.Drawing.Point(51, -41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 89)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox2.Location = New System.Drawing.Point(51, 77)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(10, 89)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox3.Location = New System.Drawing.Point(51, 316)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 89)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox4.Location = New System.Drawing.Point(51, 197)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 89)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox5.Location = New System.Drawing.Point(156, -41)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(10, 89)
        Me.PictureBox5.TabIndex = 4
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox6.Location = New System.Drawing.Point(156, 77)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(10, 89)
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox7.Location = New System.Drawing.Point(156, 197)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(10, 89)
        Me.PictureBox7.TabIndex = 6
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox8.Location = New System.Drawing.Point(156, 316)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(10, 89)
        Me.PictureBox8.TabIndex = 7
        Me.PictureBox8.TabStop = False
        '
        'roadmover
        '
        Me.roadmover.Enabled = True
        Me.roadmover.Interval = 10
        '
        'Car
        '
        Me.Car.Image = CType(resources.GetObject("Car.Image"), System.Drawing.Image)
        Me.Car.Location = New System.Drawing.Point(103, 288)
        Me.Car.Name = "Car"
        Me.Car.Size = New System.Drawing.Size(34, 67)
        Me.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Car.TabIndex = 8
        Me.Car.TabStop = False
        '
        'Left_mover
        '
        Me.Left_mover.Interval = 10
        '
        'Right_mover
        '
        Me.Right_mover.Interval = 10
        '
        'Enemycar1
        '
        Me.Enemycar1.Image = CType(resources.GetObject("Enemycar1.Image"), System.Drawing.Image)
        Me.Enemycar1.Location = New System.Drawing.Point(13, 165)
        Me.Enemycar1.Name = "Enemycar1"
        Me.Enemycar1.Size = New System.Drawing.Size(32, 66)
        Me.Enemycar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemycar1.TabIndex = 9
        Me.Enemycar1.TabStop = False
        '
        'Enemycar2
        '
        Me.Enemycar2.Image = CType(resources.GetObject("Enemycar2.Image"), System.Drawing.Image)
        Me.Enemycar2.Location = New System.Drawing.Point(85, -29)
        Me.Enemycar2.Name = "Enemycar2"
        Me.Enemycar2.Size = New System.Drawing.Size(32, 66)
        Me.Enemycar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemycar2.TabIndex = 10
        Me.Enemycar2.TabStop = False
        '
        'Enemycar3
        '
        Me.Enemycar3.Image = CType(resources.GetObject("Enemycar3.Image"), System.Drawing.Image)
        Me.Enemycar3.Location = New System.Drawing.Point(180, 43)
        Me.Enemycar3.Name = "Enemycar3"
        Me.Enemycar3.Size = New System.Drawing.Size(32, 66)
        Me.Enemycar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Enemycar3.TabIndex = 11
        Me.Enemycar3.TabStop = False
        '
        'Enemy1_Mover
        '
        Me.Enemy1_Mover.Enabled = True
        Me.Enemy1_Mover.Interval = 10
        '
        'Enemy2_Mover
        '
        Me.Enemy2_Mover.Enabled = True
        Me.Enemy2_Mover.Interval = 10
        '
        'Enemy3_Mover
        '
        Me.Enemy3_Mover.Enabled = True
        Me.Enemy3_Mover.Interval = 10
        '
        'End_Text
        '
        Me.End_Text.AutoSize = True
        Me.End_Text.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.End_Text.Font = New System.Drawing.Font("Bernard MT Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Text.ForeColor = System.Drawing.Color.Red
        Me.End_Text.Location = New System.Drawing.Point(36, 64)
        Me.End_Text.Name = "End_Text"
        Me.End_Text.Size = New System.Drawing.Size(138, 31)
        Me.End_Text.TabIndex = 12
        Me.End_Text.Text = "Game Over"
        Me.End_Text.Visible = False
        '
        'Score_Text
        '
        Me.Score_Text.AutoSize = True
        Me.Score_Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_Text.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Score_Text.Location = New System.Drawing.Point(0, 9)
        Me.Score_Text.Name = "Score_Text"
        Me.Score_Text.Size = New System.Drawing.Size(61, 16)
        Me.Score_Text.TabIndex = 13
        Me.Score_Text.Text = "Score 0"
        '
        'Replay_Button
        '
        Me.Replay_Button.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Replay_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Replay_Button.ForeColor = System.Drawing.Color.Red
        Me.Replay_Button.Location = New System.Drawing.Point(75, 117)
        Me.Replay_Button.Name = "Replay_Button"
        Me.Replay_Button.Size = New System.Drawing.Size(75, 40)
        Me.Replay_Button.TabIndex = 14
        Me.Replay_Button.Text = "Replay"
        Me.Replay_Button.UseVisualStyleBackColor = False
        Me.Replay_Button.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(224, 383)
        Me.Controls.Add(Me.Replay_Button)
        Me.Controls.Add(Me.Score_Text)
        Me.Controls.Add(Me.End_Text)
        Me.Controls.Add(Me.Enemycar3)
        Me.Controls.Add(Me.Enemycar2)
        Me.Controls.Add(Me.Enemycar1)
        Me.Controls.Add(Me.Car)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemycar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemycar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemycar3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents roadmover As System.Windows.Forms.Timer
    Friend WithEvents Car As System.Windows.Forms.PictureBox
    Friend WithEvents Left_mover As System.Windows.Forms.Timer
    Friend WithEvents Right_mover As System.Windows.Forms.Timer
    Friend WithEvents Enemycar1 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemycar2 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemycar3 As System.Windows.Forms.PictureBox
    Friend WithEvents Enemy1_Mover As System.Windows.Forms.Timer
    Friend WithEvents Enemy2_Mover As System.Windows.Forms.Timer
    Friend WithEvents Enemy3_Mover As System.Windows.Forms.Timer
    Friend WithEvents End_Text As System.Windows.Forms.Label
    Friend WithEvents Score_Text As System.Windows.Forms.Label
    Friend WithEvents Replay_Button As System.Windows.Forms.Button

End Class
