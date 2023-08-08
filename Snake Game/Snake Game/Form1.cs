using System.Globalization;

namespace Snake_Game
{
    public partial class SnakeGame : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;
        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;

        public SnakeGame()
        {
            InitializeComponent();
            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if(goLeft)
            {
                Settings.directions = "left";
            }
            if(goRight)
            {
                Settings.directions = "right";
            }
            if(goDown) 
            {
                Settings.directions = "down";
            }
            if(goUp)
            {
                Settings.directions = "up";
            }

            for(int i= Snake.Count-1; i>=0; i--)
            {
                if(i==0)
                {
                    switch(Settings.directions) 
                    { 
                        case "left":
                            Snake[i].x--;
                            break;
                        case "right":
                            Snake[i].x++;
                            break;
                        case "down":
                            Snake[i].y++;
                            break;
                        case "up":
                            Snake[i].y--;
                            break;
                    }
                    if (Snake[i].x < 0 || Snake[i].x > 1091)
                    {
                        GameOver();
                    }
                    if (Snake[i].y < 0 || Snake[i].y > 1226)
                    {
                        GameOver();
                    }
                    if (Snake[i].x==food.x && Snake[i].y==food.y)
                        EatFood();
                    for (int j = 1; j < Snake.Count - 1; j++)
                        if (Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y)
                            GameOver();
                }
                else 
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;
            for(int i=0;i<Snake.Count;i++) 
            {
                if(i==0)
                {
                    snakeColour = Brushes.Black;
                }
                else snakeColour = Brushes.DarkGreen;

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].x * Settings.Width,
                    Snake[i].y * Settings.Height,
                    Settings.Width, Settings.Height
                    )
                    );
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle
                    (
                    food.x * Settings.Width,
                    food.y * Settings.Height,
                    Settings.Width, Settings.Height
                    )
                    );
        }

        private void RestartGame()
        {
            maxWidth = picCanvas.Width / Settings.Width - 1;
            maxHeight = picCanvas.Height / Settings.Height - 1;

            Snake.Clear();
            startButton.Enabled = false;
            score = 0;
            txtScore.Text = "Score: " + score;
            Circle head = new Circle { x = 10, y = 5 };
            Snake.Add(head);
            for(int i = 0; i < 10; i++) 
            { 
                Circle body = new Circle();
                Snake.Add(body);
            }
            food = new Circle { x = rand.Next(2, maxWidth),y=rand.Next(2,maxHeight) };
            gameTimer.Start(); 


        }
        private void EatFood()
        {
            score += 1;
            txtScore.Text = "Score: " + score;

            Circle body = new Circle
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y
            };
            Snake.Add(body);
            food = new Circle { x = rand.Next(2, maxWidth), y = rand.Next(2, maxHeight) };
        }
        private void GameOver()
        {
            gameTimer.Stop();
            startButton.Enabled = true;

            if(score>highScore)
            {
                highScore = score;
                txtHighScore.Text = "High Score: " + highScore;
            }
        }
    }
}