namespace Taif_s_Ping_Pong
{
    public partial class Pong : Form
    {

        int ballXspeed = 4;
        int ballYspeed = 4;
        int speed = 2;
        Random rand= new Random();
        bool goDown, goUp;
        int computer_speed_change = 50;
        int playerScore = 0;
        int computerScore = 0;
        int playerSpeed = 8;
        int[] i = {5,6,8,9};
        int[]j = {10,9,8,11,12};

        public Pong()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            Ball.Top -= ballYspeed;
            Ball.Left -= ballXspeed;

            this.Text = "Player Score: " + playerScore + "-- Computer Score: " + computerScore;

            if (Ball.Top < 0 || Ball.Bottom > this.ClientSize.Height)
            {
                ballYspeed = -ballYspeed;
            }
            if (Ball.Left < -2)
            {
                Ball.Left = 300;
                ballXspeed = -ballXspeed;
                computerScore++;
            }
            if (Ball.Right > this.ClientSize.Width + 2)
            {
                ballXspeed = -ballXspeed;
                playerScore++;
            }
            if (Computer.Top <= 1)
            {
                Computer.Top = 0;

            }

            else if (Computer.Bottom >= this.ClientSize.Height)
            {
                Computer.Top = this.ClientSize.Height - Computer.Height;
            }
            if (Ball.Top < Computer.Top + (Computer.Height / 2) && Ball.Left > 300)
            {
                Computer.Top -= speed;
            }

            if (Ball.Top > Computer.Top + (Computer.Height / 2) && Ball.Left > 300)
            {
                Computer.Top += speed;
            }
            computer_speed_change -= 1;
            if (computer_speed_change < 0)
            {
                speed = i[rand.Next(i.Length)];
                computer_speed_change = 50;
            }

            if (goDown && Player.Top + Player.Height < this.ClientSize.Height)
            {
                Player.Top += playerSpeed;
            }

            if (goUp && Player.Top > 0)
            {
                Player.Top -= playerSpeed;
            }

            CheckCollision(Ball, Player, Player.Right + 5);
            CheckCollision(Ball, Computer, Computer.Left - 35);

            if (computerScore > 5)
            {
                GameOver("Sorry you lost the game:(");
            }

            else if(playerScore > 5)
            {
                GameOver("CONGRATULATIONS YOU WON!!!!");
            }
        }
                    

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                goDown = true;

            }
            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down)
            {
                goDown = false;
            }
            if(e.KeyCode==Keys.Up)
            {
                goUp = false;
            }
        }


        private void CheckCollision(PictureBox PicOne, PictureBox PicTwo, int offset)
        {
            if (PicOne.Bounds.IntersectsWith(PicTwo.Bounds))
            {
                PicOne.Left = offset;

                int x = j[rand.Next(j.Length)];
                int y = j[rand.Next(j.Length)];


                if (ballXspeed < 0)
                {
                    ballXspeed = x;
                }
                else
                {
                    ballXspeed = -x;
                }
                if(ballYspeed < 0)
                {
                    ballYspeed = -y;
                }
                else
                {
                    ballYspeed = y;
                }
            }
        }

        private void GameOver(string message)
        {
            gametimer.Stop();
            MessageBox.Show(message, "Taif Says: ");
            computerScore = 0;
            playerScore = 0;
            ballXspeed = ballYspeed = 4;
            computer_speed_change = 50;
            gametimer.Start();
        }


    }
}
