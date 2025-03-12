namespace Taif_s_Ping_Pong
{
    partial class Pong
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            Player = new PictureBox();
            Computer = new PictureBox();
            Ball = new PictureBox();
            gametimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Computer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // Player
            // 
            Player.Image = (Image)resources.GetObject("Player.Image");
            Player.Location = new Point(0, 118);
            Player.Name = "Player";
            Player.Size = new Size(30, 120);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // Computer
            // 
            Computer.Image = (Image)resources.GetObject("Computer.Image");
            Computer.Location = new Point(769, 118);
            Computer.Name = "Computer";
            Computer.Size = new Size(30, 120);
            Computer.SizeMode = PictureBoxSizeMode.StretchImage;
            Computer.TabIndex = 1;
            Computer.TabStop = false;
            // 
            // Ball
            // 
            Ball.Image = (Image)resources.GetObject("Ball.Image");
            Ball.Location = new Point(385, 165);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.SizeMode = PictureBoxSizeMode.StretchImage;
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Tick += GameTimerEvent;
            // 
            // Pong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(Ball);
            Controls.Add(Computer);
            Controls.Add(Player);
            DoubleBuffered = true;
            Name = "Pong";
            Text = "Player: 0 -- Computer:0";
            Load += Form1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)Computer).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Player;
        private PictureBox Computer;
        private PictureBox Ball;
        private System.Windows.Forms.Timer gametimer;
    }
}
