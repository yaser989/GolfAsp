using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace golf
{
    public partial class Golf : Form
    {

       
        bool clickSpasse, isGameOver;

       
        int score;


        int meter;

        int force = 100;
        int forceSpeed = 2;


        public Golf()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Gol_Click(object sender, EventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

   

        private void MainTimerEvent(object sender, EventArgs e)
        {
           
           if (meter == 0)
            {
                // set the position of the game
                ball.Location = new Point((ball.Parent.ClientSize.Width / 2) - (ball.Width / 2),
                                      (ball.Parent.ClientSize.Height / 2 + 150) - (ball.Height / 2));


                Gol.Location = new Point((Gol.Parent.ClientSize.Width / 2) - (Gol.Width / 2),
                                      (Gol.Parent.ClientSize.Height / 2 - 150) - (Gol.Height / 2));

            }


            txtScore.Text = "Score: " + score;

            forcetxt.Text = "Force: " + force;

            meters.Text = "Meters: " + meter;

            gameOver.Visible = false;



            force -= forceSpeed;

            if (force < 0 || force > 100)
            {
                forceSpeed = -forceSpeed;
            }



            if (clickSpasse == true && force > 50)
            {
                meter++;

                if (meter > 1)
                {
                    ball.Top -= 10;
                    meter++;
                }
                ball.Top -= 200;
                score++;
               
                clickSpasse = false;
               
                
            }
            else if (clickSpasse == true && force < 50)
            {

                ball.Top -= 30;
                score++;
                meter++;
                clickSpasse = false;
               

            }
            else if (clickSpasse == true && force == 0)
            {
                clickSpasse = false;
            }
          

            if (ball.Top < 0 ||ball.Top + ball.Height > this.ClientSize.Height )
            {
                gameOver.Visible = true;
                GameTimer.Stop();
                isGameOver = true;

            }



                foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {

                    if ((string)x.Tag == "gol")
                    {
                        if (ball.Bounds.IntersectsWith(x.Bounds))
                        {
                            GameTimer.Stop();
                            isGameOver = true;
                            txtScore.Text = "Score: " + score + Environment.NewLine + "you win!";
                            ball.Visible = false;
                            
                        }
                    }


                }
            }
          
           

        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
         

            if(e.KeyCode == Keys.Space)
            {
                clickSpasse = true;

            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Space)
            {
                clickSpasse = false;
                
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RestartGame()
        {
            clickSpasse = false;
            isGameOver = false;
            gameOver.Visible = false;
        
      
            score = 0;
            meter = 0;
           

            txtScore.Text = "Score: " + score;

            forcetxt.Text = "Force: " + force;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox &&  x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            // reset the position of the game
            ball.Location = new Point((ball.Parent.ClientSize.Width / 2) - (ball.Width / 2),
                                  (ball.Parent.ClientSize.Height / 2 + 150) - (ball.Height / 2)) ;
            ball.Refresh();

            Gol.Location = new Point((Gol.Parent.ClientSize.Width / 2) - (Gol.Width / 2),
                                  (Gol.Parent.ClientSize.Height / 2 - 150) - (Gol.Height / 2));
            Gol.Refresh();

            GameTimer.Start();


        }

            }

        

    
}
