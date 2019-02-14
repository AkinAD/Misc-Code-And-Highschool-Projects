using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adewale.Alien_Hunt
{
       
    public partial class frmScoreboard : Form
    {  
        int Moves;
        int Difficulty;
        int People;
        int PeopleLeft;
        int PeopleAbducted;
        int Tries;
        int Timer;
        int s;
        int GameCounter;
        double Highscore;
        bool GameOver;
      public static bool Form2Open;




        public frmScoreboard()
        {
            InitializeComponent();
            
        }
       

        private void lblUserN_Click(object sender, EventArgs e)
        {
            
        }

        private void tmrData_Tick(object sender, EventArgs e)
        {       Moves = frmAlienHunt.Moves;
                Difficulty = frmAlienHunt.Difficulty;
                Tries = frmAlienHunt.tries;
                People = frmAlienHunt.NumberPeople;
                GameOver = frmAlienHunt.GameOver;
                GameCounter = frmAlienHunt.GameCounter;
                Timer = frmAlienHunt.Timer;
                PeopleLeft = frmAlienHunt.PeopleLeft;
                PeopleAbducted = People - PeopleLeft;
            if (GameOver == true && (lstData.Items.Count -1) == GameCounter )
            {                Highscore = People + 2;
                // fix scoreboard glitch where it doesn't update again because scoreboard is hidden and re opened.
                //store lst.items.count into a multiform variable maybe?
                
                lstData.Items.Count.ToString();
                lblCount.Text = (lstData.Items.Count - 2).ToString();
                if (Moves <= Highscore && Moves >= People)
                {   tmrAward.Start();
                picAward.Visible = true;
                    Highscore = Moves / Difficulty;
                    lstData.Items.Add(Difficulty.ToString() + "\t\t  " + Moves.ToString() + "★\t\t" + PeopleAbducted.ToString() + "\t      " + PeopleLeft.ToString() + "\t\tTries" + "\t\t" + Timer.ToString());
                     
                }
                else
                {
                    lstData.Items.Add(Difficulty.ToString() + "\t\t  " + Moves.ToString() + "\t\t" + PeopleAbducted.ToString() + "\t      " + PeopleLeft.ToString() + "\t\tTries" + "\t\t" + Timer.ToString());
                }
            }
           
                
            
        }


        

        private void frmScoreboard_Load(object sender, EventArgs e)
        {
            Form2Open = true;
            tmrData.Start();
            s = 0;
            // This is added immediately the form loads
            lstData.Items.Add("Difficulty Level" + "\tMoves" + "\tPeople Abducted" + "\tPeople Left      Number of Attempts      Time");                      //titles
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
        }

        private void tmrScore_Tick(object sender, EventArgs e)
        {
            
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstData.Items.Clear();
             lstData.Items.Add("Difficulty Level" + "\tMoves" + "\tPeople Abducted" + "\tPeople Left      Number of Attempts      Time");                      //titles
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
       
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form2Open = false;
        }

      
        private void btnTotal_Click(object sender, EventArgs e)
        {
            //tmrAward.Start();
            //picAward.Visible = true;
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
            {   picAward1.Visible = true;
                picAward.Visible = false;
                
                
            }
            else if (s == 40)
            {   picAward2.Visible = true;
                picAward1.Visible = false;
                
                
            }
            else if (s == 65)
            {   picAward3.Visible = true;
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
                picAward2.Height =41; 
                picAward3.Width = 42;
                picAward3.Height = 30;
                tmrAward.Stop();

            }

            //picAward1.Visible = true;
            //picAward.Visible = false;
            //picAward2.Visible = true;
            //picAward1.Visible = false;
            //picAward3.Visible = true;
            //picAward2.Visible = false;
            //picAward3.Visible = false;
            //tmrAward.Stop();
        }

        private void frmScoreboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2Open = false;
        }
    }
}
