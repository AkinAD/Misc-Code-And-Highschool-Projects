/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT UNOFFICIAL - PING PONG
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : GAME I FOUND AND WANTED TO CODE
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adewale.TheAdventuresOfSharkeisha
{
    public partial class frmPingPong : Form
    {
        public frmPingPong()
        {
            InitializeComponent();
            tmrGame.Enabled = true;

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds; // Mkes the game run in full screen
            Cursor.Hide(); // HID THE CURSER .-.

            Racket.Top = playground.Bottom - (playground.Bottom / 10);
        }

        

        int SPEED_LEFT = 4;
        int Speed_Top = 4;
        int point = 0;
        Random rnd = new Random();

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);  // MOVE THE PAD WITH CURSOR

            Ball.Left += SPEED_LEFT;
            Ball.Top += Speed_Top;

            if (Ball.Bottom >= Racket.Top && Ball.Bottom <= Racket.Bottom && Ball.Left >= Racket.Left && Ball.Right <= Racket.Right)
            {
                Speed_Top += 2;
                SPEED_LEFT += 2;
                Speed_Top = -Speed_Top;
                point += 1;

            }
            if (Ball.Left <= playground.Left)
            {
                SPEED_LEFT = -SPEED_LEFT;
            }

            if (Ball.Right >= playground.Right)
            {
                SPEED_LEFT = -SPEED_LEFT;

            }


            if (Ball.Top <= playground.Top)
            {
                Speed_Top = -Speed_Top;
            }

            if (Ball.Bottom >= playground.Bottom)
            {
                tmrGame.Enabled = false; 
                //Stops game
                
            }
            if (Ball.Bounds.IntersectsWith(Racket.Bounds))
            {
           // randomize ball color
                int red;
            int green;
            int blue;
                
            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);
              
                
                
                point++;
                lblScore.Text = "Score: " + point;
                Ball.BackColor = Color.FromArgb(red, green, blue);
            }
        
        }

        private void frmPingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                this.Close();  // E to quit
                Cursor.Show(); // Show cursor
                 new frmBonus().Show();
            }
            if (e.KeyCode == Keys.R)
            {
                new frmPingPong().Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
          
           
        }

        private void frmPingPong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmCPT.gameover == true)
            {
                Application.Exit();
            }
            else
            {
               
            }
        }
    }
}
