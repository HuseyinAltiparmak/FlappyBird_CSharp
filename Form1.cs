using System.Security.Cryptography.X509Certificates;

namespace Flappy_Bird_Game
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer(object sender, EventArgs e)
        {
            pictureBox2.Top += gravity;
            pictureBox1.Left -= pipeSpeed;
            pictureBox3.Left -= pipeSpeed;
            label1.Text = "SCORE:" + score;

            if (pictureBox1.Left < -150)
            {
                pictureBox1.Left = 800;
                score++;
            }
            if (pictureBox3.Left < -180)
            {
                pictureBox3.Left = 950;
                score++;
            }
            if (pictureBox2.Bounds.IntersectsWith(pictureBox1.Bounds) ||
               pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds) ||
               pictureBox2.Bounds.IntersectsWith(pictureBox4.Bounds) || pictureBox2.Top < -25)
            {
                EndGame();
            }
        }
        public void EndGame()
        {
            timer_GameControl.Stop();
            label1.Text = "GAME OVER!";
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
