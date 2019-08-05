using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PongGame : Form
    {
        bool goup;
        bool godown;
        int speed = 10;
        int ballX = 5;
        int ballY = 5;
        int score = 0;
        int cpuPoint = 0;

        public PongGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerTick(object sender, EventArgs e)
        {
            PlayerScore.Text = "" + score;
            CpuLable.Text = "" + cpuPoint;

            ball.Top -= ballY;
            ball.Left -= ballX;

            cpu.Top += speed;

            if(score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                cpu.Top = ball.Top + 30;
            }
            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballX = -ballX;
                ballX -= 2;
                cpuPoint++;
            }
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballX = -ballX;
                ballX += 2;
                score++;
            }
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                ballY = -ballY;
            }
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballX = -ballX;
            }
            if (goup == true && player.Top > 0)
            {
                player.Top -= 8;
            }
            if (godown == true && player.Top < 455)
            {
                player.Top += 8;
            }
            if (score > 20)
            {
                gameTimer.Stop();
                MessageBox.Show("You win this game");
            }
            if (cpuPoint > 20)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU wins, you loose");
            }
        }
        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }
    }
}
