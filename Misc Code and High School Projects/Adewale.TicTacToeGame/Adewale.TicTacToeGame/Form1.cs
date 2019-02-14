using Adewale.TicTacToeGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adewale.TicTacToeGame
{
    public partial class frmXandO : Form
    {
        Label[] boxArray = new Label[9];
        String[] possibleWins = new String[8];
        Random rnd = new Random();
        SoundPlayer Blop;
        SoundPlayer TaDa;
        bool xTurn;
        bool canClick = false;
        int numberClicks;
        int hintLeft = 2;
        int XWins;
        int OWins;
        int red;
        int green;
        int blue;
        int M;
        int TX9000;
        bool GameOver;
        public frmXandO()
        {
            InitializeComponent();
        }

        private void frmXandO_Load(object sender, EventArgs e)
        {
            Blop = new SoundPlayer(Resources.Blop);
            TaDa = new SoundPlayer(Resources.Ta_Da);
            // establish array
            boxArray[0] = lblBox1;
            boxArray[1] = lblBox2;
            boxArray[2] = lblBox3;
            boxArray[3] = lblBox4;
            boxArray[4] = lblBox5;
            boxArray[5] = lblBox6;
            boxArray[6] = lblBox7;
            boxArray[7] = lblBox8;
            boxArray[8] = lblBox9;
            //Possible Wins
            possibleWins[0] = "012";
            possibleWins[1] = "345";
            possibleWins[2] = "678";
            possibleWins[3] = "036";
            possibleWins[4] = "147";
            possibleWins[5] = "258";
            possibleWins[6] = "048";
            possibleWins[7] = "246";
            //ClearBoxes
            for (int i = 0; i < 9; i++)
            {
                boxArray[i].Text = "";
                boxArray[i].Image = null;
            }
            lblMessage.Text = "Game Stopped";
            grpTurns.Enabled = false;
            grpCompMode.Enabled = false;
            radTwoPlayer.Checked = true;
        }
        private void ComputerTurn()
        {
            int SelectedBox;
            int i, n;
            int j, k;
            String ComputerMark, playerMark, markToFind;
            int [] boxNumber = new int [3];
            String[] mark = new String[3];
            int emptyBox;
            int[] bestMoves = { 4, 0, 2, 6, 8,1,3,5,7};

            if (radDumbPc.Checked)
            {
               //random Logic
                //put mark in Nth available square
                n = rnd.Next(9 - numberClicks) + 1; //n is assined a random value based off the number of boxes and number of clicks in the game
                i = 0;
                for (SelectedBox = 0; SelectedBox < 9; SelectedBox++)
                {// selected box represents ll the clickable boxes in the game
                    if (boxArray[SelectedBox].Text == "") // checks if it has been clicked or not, and if it hasn't,  the value of i increases
                    {
                        i++;
                    }
                    if (i == n) // when the value of i reaches the randomvalue of n, it stops i from increasing and puts a mark on that point
                    {
                        break;
                    }
                    //put MArk in SelectedBox
                }
                    lblBox_Click(boxArray[SelectedBox], null);
                //the program runs through a bunch of random variables each representing a spot on the game, it checks if that spot is already filled and if it is, it moves on to the next rndom variable and repeats the process till it finds an ooen spot. it then places a mark there.
            
         
            }
          else
                {
                    //smart Computer
                //determine who has what mark
                    if (radCompFirstTurn.Checked)
                    {
                        ComputerMark = "X";
                        playerMark = "O";
                    }
                    else
                    {
                        ComputerMark = "O";
                        playerMark = "X";
                    }
            //step 1 (k -=1) - check for win -
                // see if two boxes hold computer mark and one is empty
                //step 2 (k = 2) - check for bloc
                //see if two boxes hold player mark and one is empty
                    for (k = 1; k <= 2; k++)
                    {
                        if (k == 1)
                            markToFind = ComputerMark;
                        else
                            markToFind = playerMark;
                        for (i = 0; i < 8; i++)
                        {
                            n = 0; //sets previously generated value of n to 0
                            emptyBox = 0; // sets int emptybox to 0
                            for (j = 0; j < 3; j++) //loop to check three digit combination
                            {
                                boxNumber[j] = Convert.ToInt32(possibleWins[i][j].ToString()); //sets int array boxnumber to an individual value out of the three possible digits for each combination 
                                mark[j] = boxArray[boxNumber[j]].Text;// sets string arrray "mark" to whtever text character is contained in each checked position for possible 3 digit combo
                                if (mark[j] == markToFind) // if the spot being checked already contains text
                                    n++; //keep checking
                                else if (mark[j] == "") // if the spot is free
                                    emptyBox = boxNumber[j]; // label that position of combo as free/open
                            }
                            if (n == 2 && emptyBox != 0)
                            {
                            // mark empty box to win (k ==1) or block ( k =2)
                                lblBox_Click(boxArray[emptyBox], null); // takes that empty box amd initiates a click event  (to place character in box) 
                                return;
                            }
                        }
                    }
            //Step 3 - find next best moves
                    for (i = 0; i < 9; i++)
                    {
                        if (boxArray[bestMoves[i]].Text == "")
                        {
                            lblBox_Click(boxArray[bestMoves[i]], null);
                            return;
                        }
                    }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start Game")
            {
                btnStart.Text = "Stop Game";
                btnHint.Enabled = true;
                hintLeft = 2;
                lblHintsUsed.Text = "2";
                grpPlayer.Enabled = false;
                grpTurns.Enabled = false;
                grpCompMode.Enabled = false;
                btnExit.Enabled = false;
                xTurn = true;
                lblMessage.Text = " X's Turn!";
                //reset boxes
                for (int i = 0; i < 9; i++)
                {
                    boxArray[i].Text = "";
                    boxArray[i].Image = null;
                    boxArray[i].BackColor = Color.White;
                }
                canClick = true;
                numberClicks = 0;
                GameOver = false;
                if (radCompFirstTurn.Checked && radOnePlayer.Checked)
                {
                    ComputerTurn();
                }
            }
            else
            {
                btnStart.Text = "Start Game";
                if (!GameOver)
                {
                    lblMessage.Text = "Game Stopped";

                }

                grpPlayer.Enabled = true;
                if (radOnePlayer.Checked)
                {
                    grpTurns.Enabled = true;
                    grpCompMode.Enabled = true;
                }
                btnExit.Enabled = true;
                btnHint.Enabled = true;
                hintLeft = 2;
                canClick = false;
            }
        }

        private void lblBox_Click(object sender, EventArgs e)
        {
            String WhoWon = "";
            int i;
            if (canClick == true)
            {
                //see Which Box is clicked
                Blop.Play();
                Label clickedBox;
                clickedBox = (Label)sender;
                //last digit of name (-1) is index
                i = Convert.ToInt32(clickedBox.Name[clickedBox.Name.Length - 1].ToString()) - 1;
                //if already clicked then exit
                if (boxArray[i].Text != "")
                {
                    return;

                } 
                numberClicks++;
                if (xTurn)
                {
                    boxArray[i].Text = "X";
                    boxArray[i].Image = Properties.Resources.RedX; //assigns image to whatever box is clicked based 
                    xTurn = false;
                    lblMessage.Text = "O's Turn!";

                }
                else
                {
                     boxArray[i].Text = "O";
                    boxArray[i].Image = Properties.Resources.RedO; //assigns image to whatever box is clicked based 

                    xTurn = true;
                    lblMessage.Text = "X's Turn!";

                }
            //Check For win - will establish value for who won
                WhoWon = CheckForWin();
                if (WhoWon != "")
                {
                    lblMessage.Text = WhoWon + " wins!";
                    TaDa.Play();
                    if (WhoWon  == "X")
                    {
                        XWins++;
                        lblX.Text = XWins.ToString();
                    }
                    else if (WhoWon == "O")
                    {
                        OWins++;
                        lblO.Text = OWins.ToString();
                    }
                    tmrBackcolor.Start();
                    GameOver = true;
                    btnStart.PerformClick();
                    return;
                }
                else if (numberClicks == 9)
                {
                    //draw 
                    lblMessage.Text = "It's a draw!";
                    GameOver = true;
                    btnStart.PerformClick();
                    return;
                }
                if (radOnePlayer.Checked)
                    if ((xTurn && radCompFirstTurn.Checked) || (!xTurn && radPlayerFirstTurn.Checked))
                        ComputerTurn();
            }
        }
        private String CheckForWin()
        {
            String winner = "";
            int[] boxNumber = new int[3];
            String[] mark = new String[3];
            //Check all possible for wins
            for (int i = 0; i < 8; i++)
            { // there are 8 possible three digit combinations to win, this loop checks each of the possible digits(3) and combinations(8) for wins 
                for (int j = 0; j < 3; j++)
                {
                    boxNumber[j] = Convert.ToInt32(possibleWins[i][j].ToString());
                    mark[j] = boxArray[boxNumber[j]].Text;
                }
                if (mark[0] == mark[1] && mark[0] == mark[2] && mark[1] == mark[2] && mark[0] != "")
                {
                    //We have a winner 
                    winner = mark[0];
                    for (int j = 0; j < 3; j++)
                    {
                        boxArray[boxNumber[j]].BackColor = Color.Green;
                       
                    }
                }
            }
            return (winner);
        }

        private void radOnePlayer_CheckedChanged(object sender, EventArgs e)
        {
            grpTurns.Enabled = true;
            grpCompMode.Enabled = true;
        }

        private void radTwoPlayer_CheckedChanged(object sender, EventArgs e)
        {
            grpTurns.Enabled = false;
            grpCompMode.Enabled = false;
        }

        private void tmrBackcolor_Tick(object sender, EventArgs e)
        {
            M++;
            red = rnd.Next(0, 256); //random value for an int for colors
            green = rnd.Next(0, 256);//random value for an int for colors
            blue = rnd.Next(0, 256);//random value for an int for colors
            this.BackColor = Color.FromArgb(red, green, blue); //Flashes background color
            pnlForFun.BackColor = Color.FromArgb(red, green, blue);
      if (M == 25)
      {
      tmrBackcolor.Stop();
          M =0;
      }
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            // Suggests best possible location for user to play
            //works off code of smart computer, but rather tan click the ox, it hightlights it for the user
            hintLeft--;
            lblHintsUsed.Text = hintLeft.ToString();
            int i, n;
            int j, k;
            String ComputerMark, playerMark, markToFind;
            int[] boxNumber = new int[3];
            String[] mark = new String[3];
            int emptyBox;
            int[] bestMoves = { 4, 0, 2, 6, 8, 1, 3, 5, 7 };

            if (hintLeft == 0)
            {
                btnHint.Enabled = false;
                hintLeft = 2;
            }
            //smart Computer
            //determine who has what mark
            if (radCompFirstTurn.Checked || radTwoPlayer.Checked)
            {
                ComputerMark = "X";
                playerMark = "O";
            }
            else
            {
                ComputerMark = "O";
                playerMark = "X";
            }
            //step 1 (k -=1) - check for win -
            // see if two boxes hold computer mark and one is empty
            //step 2 (k = 2) - check for bloc
            //see if two boxes hold player mark and one is empty
            for (k = 1; k <= 2; k++)
            {
                if (k == 1)
                    markToFind = playerMark;
                else
                    markToFind = ComputerMark;
                for (i = 0; i < 8; i++)
                {
                    n = 0;
                    emptyBox = 0;
                    for (j = 0; j < 3; j++)
                    {
                        boxNumber[j] = Convert.ToInt32(possibleWins[i][j].ToString());
                        mark[j] = boxArray[boxNumber[j]].Text;
                        if (mark[j] == markToFind)
                            n++;
                        else if (mark[j] == "")
                            emptyBox = boxNumber[j];
                    }
                    if (n == 2 && emptyBox != 0)
                    {
                        // mark empty box to win (k ==1) or block ( k =2)
                        boxArray[emptyBox].BackColor = Color.Red;
                        tmrReset.Start();

                        return;
                    }
                }
            }
            //Step 3 - find next best moves
            for (i = 0; i < 9; i++)
            {
                if (boxArray[bestMoves[i]].Text == "")
                {
                    // lblBox_Click(boxArray[bestMoves[i]], null);
                    boxArray[bestMoves[i]].BackColor = Color.Red;
                    tmrReset.Start();
                    return;
                }
            }
        }

        private void tmrReset_Tick(object sender, EventArgs e)
        {
            TX9000++;
            if (TX9000 == 4)
            {
                for (int i = 0; i < 9; i++)
                {
                    boxArray[i].BackColor = Color.White;
                }
                TX9000 = 0;
                tmrReset.Stop();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //always leave the best line of code for last
            //drumroll
            //*simulate drumroll*
            //this
            //.
            //close()
            //BOOM
            this.Close();
            //So simple
            //YET SO POWERFUL 
        }
    }
        }

