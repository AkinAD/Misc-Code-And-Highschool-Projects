/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - HOOD/MOVING BLOCKS
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : BLOCKS MOVE RANDOMLY AND USER MUST MOVE CHARACTER TO AVOID GETTING HIT BY THE BLOCKS
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
    public partial class frmMovingBlocks : Form
    {
        public static int HoodScore;
        public static int HoodFrequency;

        public frmMovingBlocks()
        {
            InitializeComponent();
        }
        //Global Variables
        bool sRight, sLeft, sUp, sDown;
        int[] yBVelocity = new int[4];
        int[] xBVelocity = new int[10];
        int scoreTimer;

        private void frmMovingBlocks_Load(object sender, EventArgs e)
        {   //INCREASE FREQUENCY COUNTER
            HoodFrequency += 1;
            // SPEED OF MOVING BLOCKS
            yBVelocity[0] = 1;
            yBVelocity[1] = 2;
            yBVelocity[2] = 3;
            yBVelocity[3] = 3;

            xBVelocity[0] = 1;
            xBVelocity[1] = 2;
            xBVelocity[2] = 3;
            xBVelocity[3] = 3;
            xBVelocity[4] = -3;
            xBVelocity[5] = 2;
            xBVelocity[6] = 3;
            xBVelocity[7] = 3;
            xBVelocity[8] = 3;
            xBVelocity[9] = 3;


            MessageBox.Show(" Help young Tyrone rescue Keishawna from the hood before its too late ", "Instructions");
            tmrBlocks.Start();
            tmrGame.Start();
        }

        private void frmMovingBlocks_KeyUp(object sender, KeyEventArgs e)
        {   //ACTIONS THAT OCCUR WHEN KEYS ARE PRESSED
            switch (e.KeyCode)
            {
                case Keys.Right:
                    sRight = false;
                    break;
                case Keys.Left:
                    sLeft = false;
                    break;
                case Keys.Up:
                    sUp = false;
                    break;
                case Keys.Down:
                    sDown = false;
                    break;

            }
        }

        private void frmMovingBlocks_KeyDown(object sender, KeyEventArgs e)
        { // ACTIONS THAT OCCUR WHEN KEYS ARE PRESSED
            switch (e.KeyCode)
            {
                case Keys.Right:
                    sRight = true;
                    break;
                case Keys.Left:
                    sLeft = true;
                    break;
                case Keys.Up:
                    sUp = true;
                    break;
                case Keys.Down:
                    sDown = true;
                    break;
            }
        }

        private void tmrBlocks_Tick(object sender, EventArgs e)
        {
            // SO EACH LABEL DOESN'T HAVE TO BE CODDED
            Label[] lblBlocksy = new Label[] { label8, label9, label11, label12, };
            Label[] lblBlocksx = new Label[] { label1, label2, label10, label4, label3, label5, label6, label7, label13, label14, };

            int[] yBlock = new int[4];
            int[] xBlock = new int[10];

            if (sRight == true && picMe.Left + picMe.Width < this.ClientRectangle.Width)
            {
                picMe.Left += 3;
            }
            else if (sLeft == true && picMe.Left > this.ClientRectangle.Left)
            {
                picMe.Left -= 3;
            }
            else if (sUp == true && picMe.Top > this.ClientRectangle.Top)
            {
                picMe.Top -= 3;
            }
            else if (sDown == true && picMe.Top + picMe.Height < this.ClientRectangle.Height)
            {
                picMe.Top += 3;
            }


            // Moving Blocks
            for (int i = 0; i < 4; i++)
            {
                yBlock[i] = lblBlocksy[i].Top;
                yBlock[i] = yBlock[i] + yBVelocity[i];


            }

            // Moving Blocks X
            for (int i = 0; i < 10; i++)
            {
                xBlock[i] = lblBlocksx[i].Left;
                xBlock[i] = xBlock[i] + xBVelocity[i];
            }



            //Change Direction
            for (int i = 0; i < 4; i++)
            {
                if (yBlock[i] < 0 || yBlock[i] > this.ClientRectangle.Height - lblBlocksy[i].Height)
                {
                    yBVelocity[i] = (-1) * yBVelocity[i];

                }

                lblBlocksy[i].Top = yBlock[i];

            }

            //Change Direction
            for (int i = 0; i < 10; i++)
            {
                if (xBlock[i] < 0 || xBlock[i] > this.ClientRectangle.Width - lblBlocksx[i].Width)
                {
                    xBVelocity[i] = (-1) * xBVelocity[i];

                }
                lblBlocksx[i].Left = xBlock[i];


            }
            // collision with blocks
            for (int i = 0; i < 4; i++)
            {
                if (picMe.Bounds.IntersectsWith(lblBlocksy[i].Bounds))
                {
                    HoodFrequency += 1;
                    HoodScore -= 1;
                    picMe.Image = Properties.Resources.meh2;
                    endGame();
                    MessageBox.Show(" You failed Keishawna \r\n You also lost 1 point(s)  \r\n \r\n Your points in this round are " + HoodScore.ToString() + " point(s)", "You lost");
                    Reset();

                }


            }
            // collision with blocks
            for (int i = 0; i < 10; i++)
            {
                if (picMe.Bounds.IntersectsWith(lblBlocksx[i].Bounds))
                {
                    HoodFrequency += 1;
                    HoodScore -= 1;
                    picMe.Image = Properties.Resources.meh2;
                    endGame();
                    MessageBox.Show(" You failed Keishawna \r\n You also lost 1 point(s)  \r\n \r\n Your points in this round are " + HoodScore.ToString() + " point(s)", "You lost");
                    Reset();

                }


            }
            if (picMe.Bounds.IntersectsWith(picWife.Bounds))

            {
                endGame();
                HoodScore += 5;
                MessageBox.Show(" It took you " + scoreTimer + " seconds to rescue her" + "\r\n You have also been awarded 5 points \r\n \r\n Your points in this round are " + HoodScore.ToString() + " point(s).", "You Won");

                if (MessageBox.Show("Would you like to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
                {
                    Reset();
                }
                else
                {
                    if (MessageBox.Show("Exit game?", "Game Over", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        Reset();

                    }
                    else
                    {
                        this.Close();
                    }
                }
                
               
            }

        }

        void endGame() // WHEN USER  GETS HIT
        {
            tmrBlocks.Stop();
            tmrGame.Stop();
        }


        void Reset() // CHANGE EVERYTHING TO PREVIOUS STATE
        {
            HoodFrequency += 1;
            sRight = false;
            sLeft = false;
            sDown = false;
            sUp = false;
            picMe.Image = Properties.Resources._14325762165564;
            picMe.Location = new Point(2, 2);
            label8.Location = new Point(192, 2);
            label11.Location = new Point(307, 5);
            label5.Location = new Point(0, 181);
            label2.Location = new Point(61, 277);
            label1.Location = new Point(369, 181);
            label3.Location = new Point(568, 217);
            label6.Location = new Point(800, 251);
            label4.Location = new Point(475, 322);
            label7.Location = new Point(0, 381);
            label10.Location = new Point(250, 381);
            label12.Location = new Point(475, 427);
            label9.Location = new Point(585, 427);
            label13.Location = new Point(250, 517);
            label14.Location = new Point(596, 18);

            scoreTimer = 0;
            this.Text = "Save Sharkeisha - Timer : " + scoreTimer;
            tmrBlocks.Start();
            tmrGame.Start();
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {

            scoreTimer += 1;
            this.Text = "Save Sharkeisha - Timer : " + scoreTimer;
        }

        private void frmMovingBlocks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmCPT.gameover == true)
            {
                Application.Exit();
            }
            else
            {
                new frmCPT().Show();
            }
        }
    }
}
