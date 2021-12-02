Public Class Form1
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        speed = 3
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8


    End Sub

    Private Sub roadmover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles roadmover.Tick
        For x As Integer = 0 To 7
            road(x).Top += 2
            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height
            End If
        Next
        If (Car.Bounds.IntersectsWith(Enemycar1.Bounds)) Then
            gameOver()
        End If
        If (Car.Bounds.IntersectsWith(Enemycar2.Bounds)) Then
            gameOver()
        End If
        If (Car.Bounds.IntersectsWith(Enemycar3.Bounds)) Then
            gameOver()
        End If
    End Sub
    Private Sub gameOver()
        Replay_Button.Visible = True
        End_Text.Visible = True
        roadmover.Stop()
        Enemy1_Mover.Stop()
        Enemy2_Mover.Stop()
        Enemy3_Mover.Stop()
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            Right_mover().Start()
        End If
        If e.KeyCode = Keys.Left Then
            Left_mover.Start()
        End If
    End Sub


    Private Sub Right_mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Right_mover.Tick
        If (Car.Location.X < 190) Then
            Car.Left += 5
        End If
    End Sub

    Private Sub Left_mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Left_mover.Tick
        If (Car.Location.X > 0) Then
            Car.Left -= 5
        End If
    End Sub
    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        Right_mover.Stop()
        Left_mover.Stop()
    End Sub

    Private Sub Enemy1_Mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enemy1_Mover.Tick

        Enemycar1.Top += 2
        If Enemycar1.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "score " & score
            Enemycar1.Top = -Enemycar1.Height
            Enemycar1.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemycar1.Height)
            Enemycar1.Left = CInt(Math.Ceiling(Rnd() * 50)) + 0
        End If
    End Sub

    Private Sub Enemy2_Mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enemy2_Mover.Tick
        Enemycar2.Top += 3
        If Enemycar2.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "score " & score
            Enemycar2.Top = -Enemycar2.Height
            Enemycar2.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemycar2.Height)
            Enemycar2.Left = CInt(Math.Ceiling(Rnd() * 50)) + 100
        End If
    End Sub

    Private Sub Enemy3_Mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Enemy3_Mover.Tick
        Enemycar3.Top += 2.5
        If Enemycar3.Top >= Me.Height Then
            score += 1
            Score_Text.Text = "score " & score
            Enemycar3.Top = -Enemycar3.Height
            Enemycar3.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + Enemycar3.Height)
            Enemycar3.Left = CInt(Math.Ceiling(Rnd() * 40)) + 150
        End If
    End Sub

   
    Private Sub Replay_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Replay_Button.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub
End Class
