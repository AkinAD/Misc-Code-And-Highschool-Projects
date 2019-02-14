/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - PASSWORD
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : PREVENTS UNAUTHORISED ACESS TO BONUS FORM.. WHICH SHOULDN'T REALLY BE THERE BUT I FELT LIKE TAKING THE CHALLENGE OF MAKING THE PROGRAM..
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
    public partial class frmPassword : Form
    {
        string User;
        public frmPassword()
        {
            InitializeComponent();
            User = frmStart.User;
        }
      
        
        //Global Declerations
        const string SECRET_PASSWORD = "S421781";
        int numOfGuesses;
        Random rnd = new Random();
        int m;
        private void btnEnter_Click(object sender, EventArgs e)
        {
           string guess;

            guess = txtPassword.Text.ToUpper();
            numOfGuesses++;

            if (guess == SECRET_PASSWORD) //  IF YOU GET PASSWORD RIGHT
            {
                MessageBox.Show("Acess Granted");
                lblWelcome.Text = " Welcome ";
                tmrStart.Start();
                tmrPictures.Start();
            }
            else
                if (numOfGuesses == 4) // IF USER ENTERS WRONG PASSWORD 4 TIMES
                {
                    MessageBox.Show("Acess Denied");
                    MessageBox.Show("Warning! You have one try left");
                    lblWelcome.Text = " One try left ";
                    btnEnter.BackColor = Color.Red;

                }
                else if (numOfGuesses == 5) //  IF USER ENTERS WRONG PASSWORD 5 TIMES
                {
                    btnEnter.Enabled = false;
                    MessageBox.Show("Acess Denied");
                     MessageBox.Show(" You have been locked out of System", "Unauthorized personel");
                    this.Close();
                    new frmCPT().Show(); // FORM CLOSES AND OPENS START FORM
                }
                else
                {
                    MessageBox.Show("Acess Denied"); // IF USER HASN'T TRIED UP TO 4 OR 5 TIMES
                    lblWelcome.Text = " Try again ";

                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //CLOSE FORM
           
        }

        private void tmrPictures_Tick(object sender, EventArgs e)
        {
            int pictrues1;
            int pictrues2;
            int pictrues3;


            // ensure to put break after case code

            pictrues1 = rnd.Next(1, 5);
            switch (pictrues1)
            {
                case 1:
                    picFirst.Image = Properties.Resources.ANIMATEDDaddyElvisanimated300ELVISDANCINGWITHMICROPHONENEWNEW_zpsef3cc168;
                    break;
                case 2:
                    picFirst.Image = Properties.Resources.tumblr_mnjuhfW8yt1s5dvodo1_500;
                    break;
                case 3:
                    picFirst.Image = Properties.Resources.tumblr_mt3q3mFvlS1svdumlo1_500;
                    break;
                case 4:
                    picFirst.Image = Properties.Resources.Robot_dance_by_C_Puff;
                    break;
            }
            pictrues2 = rnd.Next(1, 5);
            switch (pictrues2)
            {
                case 1:
                    picSecond.Image = Properties.Resources.ANIMATEDDaddyElvisanimated300ELVISDANCINGWITHMICROPHONENEWNEW_zpsef3cc168;
                    break;
                case 2:
                    picSecond.Image = Properties.Resources.tumblr_mnjuhfW8yt1s5dvodo1_500;
                    break;
                case 3:
                    picSecond.Image = Properties.Resources.tumblr_mt3q3mFvlS1svdumlo1_500;
                    break;
                case 4:
                    picSecond.Image = Properties.Resources.Robot_dance_by_C_Puff;
                    break;

            }
            pictrues3 = rnd.Next(1, 5);
            switch (pictrues3)
            {
                case 1:
                    picThird.Image = Properties.Resources.ANIMATEDDaddyElvisanimated300ELVISDANCINGWITHMICROPHONENEWNEW_zpsef3cc168;
                    break;
                case 2:
                    picThird.Image = Properties.Resources.tumblr_mnjuhfW8yt1s5dvodo1_500;
                    break;
                case 3:
                    picThird.Image = Properties.Resources.tumblr_mt3q3mFvlS1svdumlo1_500;
                    break;
                case 4:
                    picThird.Image = Properties.Resources.Robot_dance_by_C_Puff;
                    break;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblWelcome.Text = " ";
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            

            m = m + 10;
            if (m == 150)
            {
                new frmBonus().Show();
                this.Close();
                tmrStart.Stop();
            }

        }

        private void frmPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmCPT.gameover == true)
            {
                Application.Exit();
            }
            else
            {
                string guess;

                guess = txtPassword.Text.ToUpper();

                if (guess == SECRET_PASSWORD) // IF USER GETS PASSWORD RIGHHT
                {
                   
                    tmrStart.Start();
                    tmrPictures.Start();

                }

                else
                {
                    
                    new frmCPT().Show();
                }
            }
        }
    }
}
