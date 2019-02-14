using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adewale.Memory_Game
{
    public partial class frmScoreboard : Form
    {
        public static int Timer;
        public static bool GameOver;
        public static int GameMode;
        public static string Mode;
        public static int Choice;
        public static bool HintUsed;
        public static string Hint;
        public static int Checker;
        public static int M;
        public static string User;
        public static int Counter;//same as SCore in teachers code
        public static int Score;
        public static bool Form2Open;
        int s;
        int Highscore;
        string HighPlayer;             //Lol
        int HighTime;
        int HighTries;

        public frmScoreboard()
        {
            InitializeComponent();
        }
       

        private void frmScoreboard_Load_1(object sender, EventArgs e)
        {
            this.StartPosition = 0;
            Highscore = 0;
            Form2Open = true;
            tmrData.Start();
            s = 0;
            // This is added immediately the form loads
            lstData.Items.Add("User\t    " + "Game Mode" + "\tTime" + "\tScore" + "\tTries      \tHint used(-500pts)      ");                      //titles
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");

        }

        private void tmrData_Tick(object sender, EventArgs e)
        {
            Timer = frmMemory.Timer;
            GameMode = frmMemory.GameMode;
            GameOver = frmMemory.GameOver;
            Choice = frmMemory.Choice;
            Checker = frmMemory.Checker;
            Counter = frmMemory.Counter;
            Score = frmMemory.Score;
            HintUsed = frmMemory.HintUsed;
            M = frmMemory.M;
            User = frmMemory.User;
            if (HintUsed == true)
            {
                Hint = "True";
            }
            else if (HintUsed == false)
            {
                Hint = "False";
            }
            if (GameMode == 1)
            {
                Mode = "Custom Game";
            }
            else if (GameMode == 2)
            {
                Mode = "Alien Mode";
            }
           else if (GameMode == 3)
            {
                Mode = "Time Trial";
            }
            if (GameOver == true && (lstData.Items.Count -1) == M)
            {
                 // Time      SCore        Tries       Game Mode  Hint used
                //code in hints
                //lose points for using hints

                   lblCount.Text = M.ToString();
                if (Timer <= 15)
                {
                    tmrAward.Start();
                    picAward.Visible = true;
                    lstData.Items.Add(User + "\t " + Mode + "\t  " + Timer.ToString() + "\t" + Score.ToString() + "★\t" + Counter.ToString() + "\t" + Hint);
                    //"Game Mode" + "\tTime" + "\tScore" + "\tTries      Hint used(-500pts)      "
                }
                else
                {
                    lstData.Items.Add(User + "\t " + Mode + "\t  " + Timer.ToString() + "\t" + Score.ToString() + "\t" + Counter.ToString() +  "\t" + Hint);
                }

            }
            if (Score > Highscore)
            {
                Highscore = Score;
                HighPlayer = User;
                HighTime = Timer;
                HighTries = Counter;
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
            lstData.Items.Add("User\t   " + "Game Mode" + "\tTime" + "\tScore" + "\tTries      \tHint used(-500pts)      ");                      //titles
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2Open = false;
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

        private void frmScoreboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2Open = false;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User: " + HighPlayer + "★" + "\r\nScore: "+ Highscore.ToString() + "\r\nTime: "+ HighTime.ToString() + "\r\nTries: " + HighTries.ToString());
        }
    }
}
