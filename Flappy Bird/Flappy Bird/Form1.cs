namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipespeed = 15;
        int gravity = 30;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBot.Left -= pipespeed;
            pipeTop.Left -= pipespeed;
            scoreText.Text = "Score: " + score;

            if (pipeBot.Left < -50)
            {
                pipeBot.Left = 850;
                score++;
            }
            if (pipeTop.Left < -55)
            {
                pipeTop.Left = 675;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBot.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < 25 )
            {
                endgame();
            }

            if (score > 3)
                pipespeed += 1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -15;
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 15;
        }

        private void endgame()
        {
            gameTimer.Stop();
            scoreText.Text += "Game over!";
        }
    }
}