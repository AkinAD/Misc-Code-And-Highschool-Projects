using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adewale.SafeCracker
{
    public partial class frmScoreboard : Form
    {
        public static int Timer;
        public static int intForNoReason;
        public static bool GameOver;
        public static string Acheivement;
        public static string Mode;
        public static int Choice;
        public static bool HintUsed;
        public static string Hint;
        public static int NumberDigits;
        public static int M;
        public static string User;
        public static string GameMode;
        public static int Attempt;//same as SCore in teachers code
         
        int s;
       
      
        public frmScoreboard()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
          

        }

        private void frmScoreboard_Load(object sender, EventArgs e)
        {
            intForNoReason = 0;
            this.StartPosition = 0;
           
            tmrData.Start();
            s = 0;
            // This is added immediately the form loads
            clearToolStripMenuItem.Enabled = false;
            lstData.Items.Add("User\t    " + "Game Mode    " + "\tTime    " + "\tTries         " +  "\tAcheivement          \tHint used      ");                      //titles
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
            
        }

        private void tmrData_Tick(object sender, EventArgs e)
        {
            Timer = frmSafeCracker.Timer;
            GameOver = frmSafeCracker.GameOver;
            NumberDigits = frmSafeCracker.NumberDigits;
            Attempt = frmSafeCracker.Attempts;
            GameMode = frmSafeCracker.GameMode;
            HintUsed = frmSafeCracker.HintUsed;
            M = frmSafeCracker.M;
            User = frmSafeCracker.User;
           
            if (HintUsed == true)
            {
                Hint = "True";
            }
            else if (HintUsed == false)
            {
                Hint = "False";
            }
            if (Mode == "Beginner" || NumberDigits == 2)
            {
                Acheivement = "Basic Pepe";
            }
            else   if (Mode == "Noob" || NumberDigits == 3)
            {
                Acheivement = "Money Pepe";
            }
            else if (Mode == "Alpha" || NumberDigits == 4)
            {
                Acheivement = "Gold Pepe";
            }
            else if (Mode == "Shogun" || NumberDigits == 5)
            {
                Acheivement = "Diamond Pepe";
            }

            if (GameOver == true && (lstData.Items.Count - 1) == M)
            {   //Time, Acheievment, hint used attempts, user, mode
                // Time      SCore        Tries       Game Mode  Hint used
                //code in hints
                //lose points for using hints

                lblCount.Text = M.ToString();
                if (Timer <= 10 || Attempt <= 3)
                {
                    tmrAward.Start();
                    picAward.Visible = true;
                    lstData.Items.Add(User + "\t      " + Mode +"("+ NumberDigits + " digits)\t   " + Timer.ToString() + "★\t " + Attempt.ToString() + "★\t     \t" + Acheivement + "\t    " + Hint);
                    //"Game Mode" + "\tTime" + "\tScore" + "\tTries      Hint used(-500pts)      "
                    
                }
                else
                {
                    lstData.Items.Add(User + "\t      " + Mode + "(" + NumberDigits + " digits)\t   " + Timer.ToString() + " \t " + Attempt.ToString() + "\t    \t" + Acheivement + "\t     " + Hint);
                   
                }

            }
           
         

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstData.Items.Add("User\t    " + "Game Mode" + "\tTime" + "\tTries" + "\tAcheivement     \tHint used      ");                      //titles
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");

        }

        private void tmrAward_Tick(object sender, EventArgs e)
        {
            s += 5;


            picAward.Width += 5;
            picAward.Height += 5;
            picAward1.Width += 5;
            picAward1.Height += 5;
            picAward2.Width += 5;
            picAward2.Height += 5;
            picAward3.Width += 5;
            picAward3.Height += 5;


            if (s == 25)
            {
                picAward1.Visible = true;
                picAward.Visible = false;


            }
            else if (s == 40)
            {
                picAward2.Visible = true;
                picAward1.Visible = false;


            }
            else if (s == 65)
            {
                picAward3.Visible = true;
                picAward2.Visible = false;


            }

            else if (s == 80)
            {
                picAward3.Visible = false;
                s = 0;
                picAward.Width = 95;
                picAward.Height = 81;
                picAward1.Width = 81;
                picAward1.Height = 62;
                picAward2.Width = 59;
                picAward2.Height = 41;
                picAward3.Width = 42;
                picAward3.Height = 30;
                tmrAward.Stop();

            }
        }
    }
    }

