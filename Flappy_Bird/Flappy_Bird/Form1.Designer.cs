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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fileSystemWatcher1 = new FileSystemWatcher();
            Ground = new PictureBox();
            Engel = new PictureBox();
            FlappyBird = new PictureBox();
            Engel2 = new PictureBox();
            scoreText = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ground).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Engel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Engel2).BeginInit();
            SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Ground
            // 
            Ground.BackColor = Color.Cyan;
            Ground.Image = Properties.Resources.ground;
            Ground.Location = new Point(-16, 687);
            Ground.Name = "Ground";
            Ground.Size = new Size(813, 207);
            Ground.SizeMode = PictureBoxSizeMode.StretchImage;
            Ground.TabIndex = 0;
            Ground.TabStop = false;
            Ground.Click += pictureBox1_Click;
            // 
            // Engel
            // 
            Engel.Image = Properties.Resources.pipe;
            Engel.Location = new Point(572, 465);
            Engel.Name = "Engel";
            Engel.Size = new Size(111, 299);
            Engel.SizeMode = PictureBoxSizeMode.StretchImage;
            Engel.TabIndex = 1;
            Engel.TabStop = false;
            // 
            // FlappyBird
            // 
            FlappyBird.Image = (Image)resources.GetObject("FlappyBird.Image");
            FlappyBird.Location = new Point(109, 319);
            FlappyBird.Name = "FlappyBird";
            FlappyBird.Size = new Size(73, 58);
            FlappyBird.SizeMode = PictureBoxSizeMode.StretchImage;
            FlappyBird.TabIndex = 2;
            FlappyBird.TabStop = false;
            FlappyBird.Click += FlappyBird_Click;
            // 
            // Engel2
            // 
            Engel2.Image = Properties.Resources.pipedown;
            Engel2.Location = new Point(627, -33);
            Engel2.Name = "Engel2";
            Engel2.Size = new Size(112, 310);
            Engel2.SizeMode = PictureBoxSizeMode.StretchImage;
            Engel2.TabIndex = 3;
            Engel2.TabStop = false;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            scoreText.Location = new Point(12, 12);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(129, 37);
            scoreText.TabIndex = 4;
            scoreText.Text = "Score: 0";
            scoreText.Click += label1_Click;
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(779, 848);
            Controls.Add(scoreText);
            Controls.Add(Engel2);
            Controls.Add(Ground);
            Controls.Add(Engel);
            Controls.Add(FlappyBird);
            Name = "Form1";
            Text = "Form1";
            KeyDown += gamekeyDown;
            KeyUp += gamekeyUp;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ground).EndInit();
            ((System.ComponentModel.ISupportInitialize)Engel).EndInit();
            ((System.ComponentModel.ISupportInitialize)FlappyBird).EndInit();
            ((System.ComponentModel.ISupportInitialize)Engel2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FileSystemWatcher fileSystemWatcher1;
        private PictureBox Engel2;
        private PictureBox FlappyBird;
        private PictureBox Engel;
        private PictureBox Ground;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
    }
}
