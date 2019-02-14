/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - SCOREBOARD
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : KEEPS TRACK OF SCORES
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
    public partial class frmScoreBoard : Form
    {
        string User;
        int SlotsScore;
        int HoodScore;
        int GuessScore;
        int MazeScore;
        int MazeFrequency;
        int SlotsFrequency;
        int HoodFrequency;
        int GuessFrequency;
        

        public frmScoreBoard()
        {
            InitializeComponent();
           
            User = frmStart.User;

            SlotsScore = frmSlots.SlotsScore;
            HoodScore = frmMovingBlocks.HoodScore;
            GuessScore = frmDrinks.GuessScore;
            MazeScore = frmMaze.MazeScore;
                                                          // takes value of variables from other forms
            SlotsFrequency = frmSlots.SlotsFrequency;
            HoodFrequency = frmMovingBlocks.HoodFrequency;
            GuessFrequency = frmDrinks.GuessFrequency;
            MazeFrequency = frmMaze.MazeFrequency;
            

                // MAKE THE AWARD  PICTURE ONLY SHOW IF THE BUTTON SAYS RESUME FEED


        }
        //Global Variables
        int m;
        int Total;
        int f;

        private void tmrData_Tick(object sender, EventArgs e)
        {
            SlotsScore = frmSlots.SlotsScore;
            HoodScore = frmMovingBlocks.HoodScore;
            GuessScore = frmDrinks.GuessScore;
            MazeScore = frmMaze.MazeScore;
                                                                        // takes value of variables from other forms
            SlotsFrequency = frmSlots.SlotsFrequency;
            HoodFrequency = frmMovingBlocks.HoodFrequency;
            GuessFrequency = frmDrinks.GuessFrequency;
            MazeFrequency = frmMaze.MazeFrequency;

            m = m + 10;
            // Updates the list every 3 seconds
            if (m == 300)
            {
                lstData.Items.Add("Maze" + "\t" + "\t" + "\t" + MazeFrequency.ToString() + "\t" + "\t" + "\t" + MazeScore.ToString());
                lstData.Items.Add("In the Hood" + "\t" + "\t" + HoodFrequency.ToString() + "\t" + "\t" + "\t" + HoodScore.ToString());
                lstData.Items.Add("How many drinks" + "\t" + "\t" + GuessFrequency.ToString() + "\t" + "\t" + "\t" + GuessScore.ToString());
                lstData.Items.Add("Slots" + "\t" + "\t" + "\t" + SlotsFrequency.ToString() + "\t" + "\t" + "\t" + SlotsScore.ToString());
                lstData.Items.Add("                                                                                                 ");
                
                
                m = 0;
            }
        }

        private void frmScoreBoard_Load(object sender, EventArgs e)
        {
            lblUserN.Text = "User : " + User;   
            
            tmrData.Start();
             // This is added immediately the form loads
            lstData.Items.Add("Game" + "\t Number of \r\n Games Played" + "\t  \t Score");                      //titles
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {  
            Total = HoodScore + SlotsScore + GuessScore + MazeScore;        // Calculate Total

        if (btnTotal.Text == "Total")
        { 
            //if button text is total do action
            Total = HoodScore + SlotsScore + GuessScore + MazeScore;
            tmrData.Stop();
            lblTime.Visible = true;
            lstData.Items.Add("Total" + "\t" +"\t" + "\t" + Total.ToString());
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
            btnTotal.Text = "Resume Feed"; //change button text so next action can be done
        }
        else        //when button text is not  Total
        {
            tmrData.Start();
            btnTotal.Text = "Total";
            lblTime.Visible = false;
        }
      
             if (Total >= 250 )  //To start award timer
        {
            tmrPicture.Start();
        }
           
            

        }

        private void frmScoreBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            this.Hide();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            lstData.Items.Clear();
            lstData.Items.Add("Game" + "\t Number of \r\n Games Played" + "\t  \t Score"); //titles
            lstData.Items.Add("★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★★");
        }

        private void tmrPicture_Tick(object sender, EventArgs e)
        {
            f = f + 10;

            if (f == 30 && Total >= 250 && Total <= 499) //Timer
            {
                // show bronze award if Conditions are met
                MessageBox.Show("Achievement Unlocked : \r\n Bronze!");    
                this.BackColor = Color.White;               
                this.BackgroundImage = Properties.Resources._9008_1316809618_5_1;
               
                lstData.Visible = false;
                btnTotal.Visible = false;
                lblData.Visible = false;
                lblTime.Visible = false;
            }
            else if (f == 30 && Total >= 500 && Total <= 999)
            {
                // show silver award if Conditions are met
                MessageBox.Show("Achievement Unlocked : \r\n Silver!");
                this.BackColor = Color.White;
                this.BackgroundImage = Properties.Resources.c6j;
               
             
                lstData.Visible = false;
                btnTotal.Visible = false;
                lblData.Visible = false;
                lblTime.Visible = false;
            }
              else if (f == 30 && Total >= 1000)
            {
                // show Gold award if Conditions are met
                  MessageBox.Show("Achievement Unlocked : \r\n Gold!");
                  this.BackColor = Color.White;              
                  this.BackgroundImage = Properties.Resources.lyon_gold_cup2;
                  lstData.Visible = false;
                  btnTotal.Visible = false;
                  lblData.Visible = false;
                  lblTime.Visible = false;
             
            }
            if (f == 100) // when time is 5 seconds
                // reset to previous state
            {
                lstData.Visible = true;
                btnTotal.Visible = true;
                lblData.Visible = true;
                lblTime.Visible = true;
                this.BackgroundImage = Properties.Resources.school_bullitin_board_1;
                lblData.Text = "Feed Stopped";
                tmrPicture.Stop();
                f = 0;
            }

            }
        }
    }

