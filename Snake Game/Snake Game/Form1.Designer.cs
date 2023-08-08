namespace Snake_Game
{
    partial class SnakeGame
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
            startButton = new Button();
            picCanvas = new PictureBox();
            txtScore = new Label();
            txtHighScore = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.IndianRed;
            startButton.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(889, 242);
            startButton.Margin = new Padding(4, 5, 4, 5);
            startButton.Name = "startButton";
            startButton.Size = new Size(163, 93);
            startButton.TabIndex = 0;
            startButton.Text = "Start!";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += StartGame;
            // 
            // picCanvas
            // 
            picCanvas.BackColor = Color.Gray;
            picCanvas.Location = new Point(17, 20);
            picCanvas.Margin = new Padding(4, 5, 4, 5);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(863, 922);
            picCanvas.TabIndex = 1;
            picCanvas.TabStop = false;
            picCanvas.Paint += UpdatePictureBoxGraphics;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtScore.Location = new Point(907, 360);
            txtScore.Margin = new Padding(4, 0, 4, 0);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(65, 29);
            txtScore.TabIndex = 2;
            txtScore.Text = "Score";
            txtScore.Click += txtScore_Click;
            // 
            // txtHighScore
            // 
            txtHighScore.AutoSize = true;
            txtHighScore.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtHighScore.Location = new Point(907, 412);
            txtHighScore.Margin = new Padding(4, 0, 4, 0);
            txtHighScore.Name = "txtHighScore";
            txtHighScore.Size = new Size(110, 29);
            txtHighScore.TabIndex = 3;
            txtHighScore.Text = "High Score";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 40;
            gameTimer.Tick += GameTimerEvent;
            // 
            // SnakeGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 1170);
            Controls.Add(txtHighScore);
            Controls.Add(txtScore);
            Controls.Add(picCanvas);
            Controls.Add(startButton);
            Margin = new Padding(4, 5, 4, 5);
            Name = "SnakeGame";
            Text = "Snake Game";
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private PictureBox picCanvas;
        private Label txtScore;
        private Label txtHighScore;
        private System.Windows.Forms.Timer gameTimer;
    }
}