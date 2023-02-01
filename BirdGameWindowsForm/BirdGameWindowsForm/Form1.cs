using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdGameWindowsForm
{
    public partial class Form1 : Form
    {
        int pipespeed = 8;
         int gravity = 0;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void gamesTimerEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PoleDown.Left -= pipespeed;
            PoleUp.Left -= pipespeed;
            Coin1.Left -= pipespeed;
            Coin2.Left -= pipespeed;
            Coin5.Left-= pipespeed;

            Score.Text = "Score: "+score;
            if (PoleDown.Left < -50 || Coin1.Left<-10 || Coin2.Left<-10 || Coin5.Left<-10)
            {
                PoleDown.Left = 400;
                Coin1.Left = 400;
                Coin2.Left = 400;
                Coin5.Left = 400;
                score++;
            }
            if (PoleUp.Left < -80)
            {
                PoleUp.Left = 450; score++;
                
            }
            if(Bird.Bounds.IntersectsWith(PoleDown.Bounds) || 
                Bird.Bounds.IntersectsWith(PoleUp.Bounds) || Bird.Bounds.IntersectsWith(ground.Bounds))
            {
                endGame();
            }

            if (Bird.Bounds.IntersectsWith(Coin1.Bounds) ||
               Bird.Bounds.IntersectsWith(Coin2.Bounds) )
            {
                score = 1;
                Coin1.Visible = false;
            }

            if (Bird.Bounds.IntersectsWith(Coin5.Bounds) )
            {
                score = 5;
                Coin5.Visible = false;
            }
            if (score > 10)
            {
                pipespeed = 14;
            }
            if (Bird.Top < -25)
            {
                endGame();
            }
        }

        private void endGame()
        {
            Gametimer.Stop();
            Score.Text += "  Game Over !!";
        }

        private void keyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 5;
        }

        private void keyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -5;
        }

        private void Bird_Click(object sender, EventArgs e)
        {
           
        }
    }
}
