/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - MAZE
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : ITS .. BASICALLY A MAZE
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
    public partial class frmMaze : Form
    {
        public static int MazeScore;
        public static int MazeFrequency;
        public frmMaze()
        {
            InitializeComponent();
        }
        // Global Variables
        int Count;
        bool gameOn;

        private void frmMaze_Load(object sender, EventArgs e)
        {
            
            MessageBox.Show("To start game, Click on start button and work your way though the green spaces, don't hit the walls! Goodluck!", "Game instructions");
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            Count++;
            lblTimer.Text = (Count.ToString());
        }

        private void lblEnd_Click(object sender, EventArgs e)
        {
            if (gameOn == true) // GAME ON BECOMES TRUE WHEN YOU GET TO DESTINATION
            {
                  MazeScore += 5; // INCREASES YOUR POINTS
                tmrGame.Stop();
                gameOn = false;
                MessageBox.Show("You made it to the Sharkeisha! Your time is " + Count.ToString() + " Seconds! Congrats! \r\n You've also been awarded 5 points \r\n  \r\n   Your points in this round are " + MazeScore.ToString() + " points");
              
                Count = 0;
                lblTimer.Text = " " + Count.ToString();
                if (MessageBox.Show("Would you like to play again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    if (gameOn == true)
                    {
                        tmrGame.Stop();
                        gameOn = false;
                       

                        Count = 0;
                        lblTimer.Text = " " + Count.ToString();
                    }
                }
                else
                {
                    if (MessageBox.Show("Exit game?", "Game Over", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                        if (gameOn == true)
                        {
                            tmrGame.Stop();
                            gameOn = false;
                          
                           
                            Count = 0;
                            lblTimer.Text = " " + Count.ToString();
                        }

                    }
                    else
                    {
                        this.Close();
                    }
                }
                
            }
        }

        private void wallEnter(object sender, EventArgs e)
        { 
              if (gameOn == true)
            {
                tmrGame.Stop();
                gameOn = false;
                  MazeScore -= 1; // LOOSE POINTS
                MessageBox.Show("Wall,oops Sharkeisha is still hidden \r\n You lost 1 Point(s) \r\n   Your points in this round are " + MazeScore.ToString() + " points", "You lose");
                Count = 0; // RESTE COUNTER
                lblTimer.Text = " " + Count.ToString();
            }
        }

        private void lblStart_Click(object sender, EventArgs e)
        {
            MazeFrequency += 1; // INCRESE VARIABLE COUNTER
             tmrGame.Start();
            gameOn = true;
        }

        private void frmMaze_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmMaze_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (frmCPT.gameover == true)
            {
                Application.Exit();
            }                                                                                               // I COULDN'T GET RID OF THIS ONE OR THE OTHER ONE WITHOUT BREAKING THE PROGRAM COMPLETELY
            else
            {
                new frmCPT().Show();
            }
        }
        }
    }