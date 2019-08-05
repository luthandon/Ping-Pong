namespace WindowsFormsApp1
{
    partial class PongGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerScore = new System.Windows.Forms.Label();
            this.CpuLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.AccessibleName = "BALL";
            this.ball.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ball.Location = new System.Drawing.Point(437, 239);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.AccessibleName = "CPU";
            this.cpu.BackColor = System.Drawing.Color.Black;
            this.cpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpu.Location = new System.Drawing.Point(889, 186);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(27, 127);
            this.cpu.TabIndex = 1;
            this.cpu.TabStop = false;
            // 
            // player
            // 
            this.player.AccessibleName = "PLAYER";
            this.player.BackColor = System.Drawing.Color.Green;
            this.player.Location = new System.Drawing.Point(12, 186);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(27, 127);
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // PlayerScore
            // 
            this.PlayerScore.AccessibleName = "PlayerScore";
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerScore.ForeColor = System.Drawing.Color.GreenYellow;
            this.PlayerScore.Location = new System.Drawing.Point(12, 9);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(38, 25);
            this.PlayerScore.TabIndex = 3;
            this.PlayerScore.Text = "00";
            // 
            // CpuLable
            // 
            this.CpuLable.AutoSize = true;
            this.CpuLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpuLable.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.CpuLable.Location = new System.Drawing.Point(878, 9);
            this.CpuLable.Name = "CpuLable";
            this.CpuLable.Size = new System.Drawing.Size(38, 25);
            this.CpuLable.TabIndex = 4;
            this.CpuLable.Text = "00";
            // 
            // PongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.CpuLable);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Name = "PongGame";
            this.Text = "Pong Game MOO ICT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label CpuLable;
    }
}

