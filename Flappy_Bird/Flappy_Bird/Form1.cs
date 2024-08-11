namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
        int gravity = 10;
        int score = 0;

        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FlappyBird_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            Engel.Left -= pipespeed;
            Engel2.Left -= pipespeed;
            scoreText.Text = "Score: " + score;

            if( Engel.Left < -200 )
            {
                Engel.Left = 850;
                score++;   
            }

            if( Engel2.Left < -200 )
            { 
                Engel2.Left = 750; 
                score++;
            }

            if ( FlappyBird.Bounds.IntersectsWith(Engel.Bounds) ||
                 FlappyBird.Bounds.IntersectsWith(Engel2.Bounds) ||
                 FlappyBird.Bounds.IntersectsWith(Ground.Bounds) 
            )
            {
                endGame();
            }

            if (score > 5)
            {
                pipespeed = 12;
            }

            if (FlappyBird.Top < -25)
            {
                endGame();
            }
        }

        private void gamekeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }

        private void gamekeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

            if (e.KeyCode == Keys.R && gameOver)
            {
                RestartGame();
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game Over! Press R to Retry";
            gameOver = true;
        }

        private void RestartGame()
        {  
            gameOver = false;
            FlappyBird.Location = new Point(109, 319);
            Engel.Left = 800;
            Engel2.Left = 1200;

            score = 0;
            pipespeed = 8;
            scoreText.Text = "Score: 0";
            gameTimer.Start();
           
           
        }   

    }

}
