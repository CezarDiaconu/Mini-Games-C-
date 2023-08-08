namespace Flappy_Bird
{
    partial class Form1
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
            ground = new PictureBox();
            pipeTop = new PictureBox();
            pipeBot = new PictureBox();
            flappyBird = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeBot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).BeginInit();
            SuspendLayout();
            // 
            // ground
            // 
            ground.Image = Properties.Resources.ground;
            ground.Location = new Point(-4, 668);
            ground.Name = "ground";
            ground.Size = new Size(614, 117);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 0;
            ground.TabStop = false;
            // 
            // pipeTop
            // 
            pipeTop.Image = Properties.Resources.pipedown;
            pipeTop.Location = new Point(364, -35);
            pipeTop.Name = "pipeTop";
            pipeTop.Size = new Size(150, 324);
            pipeTop.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeTop.TabIndex = 1;
            pipeTop.TabStop = false;
            // 
            // pipeBot
            // 
            pipeBot.Image = Properties.Resources.pipe;
            pipeBot.Location = new Point(364, 485);
            pipeBot.Name = "pipeBot";
            pipeBot.Size = new Size(150, 196);
            pipeBot.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeBot.TabIndex = 2;
            pipeBot.TabStop = false;
            // 
            // flappyBird
            // 
            flappyBird.ErrorImage = null;
            flappyBird.Image = Properties.Resources.bird;
            flappyBird.Location = new Point(120, 284);
            flappyBird.Name = "flappyBird";
            flappyBird.Size = new Size(77, 55);
            flappyBird.TabIndex = 3;
            flappyBird.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.BackColor = Color.Transparent;
            scoreText.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            scoreText.Location = new Point(46, 29);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(140, 48);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: ";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(603, 748);
            Controls.Add(flappyBird);
            Controls.Add(pipeBot);
            Controls.Add(pipeTop);
            Controls.Add(ground);
            Controls.Add(scoreText);
            Name = "Form1";
            Text = "Flappy Bird";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeTop).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeBot).EndInit();
            ((System.ComponentModel.ISupportInitialize)flappyBird).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ground;
        private PictureBox pipeTop;
        private PictureBox pipeBot;
        private PictureBox flappyBird;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}