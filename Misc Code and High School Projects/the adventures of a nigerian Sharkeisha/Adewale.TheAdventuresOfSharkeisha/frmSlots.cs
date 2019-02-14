/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - SLOTS
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : EASY FORM TO GET EXTRA GAME POINTS FROM
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
    public partial class frmSlots : Form
    {

        public static int SlotsScore;
        public static int SlotsFrequency;
        public frmSlots()
        {
            InitializeComponent();
        }
        //Global Variables
        int Value;
        int PicOne;
        int PicTwo;
        int PicThree;
        Random rnd = new Random();
        int count;
        int m;
        private void btnSpin_Click(object sender, EventArgs e)
        {
            SlotsFrequency += 1;
            count++;
            tmrGame.Enabled = true;
            if (count == 10) // IF YOU'VE SPUN 10 TIMES
            {
                MessageBox.Show("Oops! you've gone broke, try again later", "All cashed out");
                // Place yes or no here
                btnSpin.Enabled = false;
                tmrSucker.Start();
            }
        }

        private void frmSlots_Load(object sender, EventArgs e)
        {
            SlotsFrequency += 1; // INCREASE GAME FREQUENCY COUNTER
            tmrGame.Enabled = false;
            MessageBox.Show("Get lucky! spin the slots and get three of the same image! Good luck!", "How to Play");

        }
        private void tmrGame_Tick(object sender, EventArgs e)
        {
            Value = Value + 10; //TIMER 

            if (Value <= 400)
            {
                PicOne = rnd.Next(1, 4);
                PicTwo = rnd.Next(1, 4);
                PicThree = rnd.Next(1, 4);

                switch (PicOne)
                {
                    case 1:

                        picOne.Image = Properties.Resources.greendevil;
                        break;

                    case 2:
                        picOne.Image = Properties.Resources.download__1_;
                        break;

                    case 3:
                        picOne.Image = Properties.Resources.money_bag3;
                        break;

                }

                switch (PicTwo)
                {

                    case 1:

                        picTwo.Image = Properties.Resources.greendevil;
                        break;

                    case 2:
                        picTwo.Image = Properties.Resources.download__1_;
                        break;

                    case 3:
                        picTwo.Image = Properties.Resources.money_bag3;
                        break;
                }

                switch (PicThree)
                {

                    case 1:
                        picThree.Image = Properties.Resources.greendevil;
                        break;

                    case 2:
                        picThree.Image = Properties.Resources.download__1_;
                        break;

                    case 3:
                        picThree.Image = Properties.Resources.money_bag3;
                        break;

                }

            }
            else
            {

                tmrGame.Enabled = false;

                Value = 0;


                PicOne.ToString();
                PicTwo.ToString();
                PicThree.ToString();

                if ((PicOne == PicTwo) && (PicOne == PicThree) && (PicTwo == PicThree))
                {
                    SlotsScore += 500; // AWARD POINTS
                    MessageBox.Show("Jackpot! You won 500 points \r\n \r\n Your points in this round are " + SlotsScore.ToString() + " point(s)." , "You Won!");
                }

                else
                {                           // DEDUCTY POINTS
                    SlotsScore -= 25;
                    MessageBox.Show("No luck, try again" + "\r\n  You just lost  25 points. \r\n \r\n Your points in this round are " + SlotsScore.ToString() + " point(s)", " Try again?");

                }
            }



        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void frmSlots_FormClosing(object sender, FormClosingEventArgs e)
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

        private void tmrSucker_Tick(object sender, EventArgs e)
        {
            m = m + 10;
            if (m == 1500)
            {
                MessageBox.Show("Account Renewed, Resume Game!");

                tmrSucker.Stop();
                btnSpin.Enabled =true;
            }
        }
    }
}

      
    
