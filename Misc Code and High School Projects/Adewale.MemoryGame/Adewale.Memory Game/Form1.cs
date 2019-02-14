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
    public partial class frmMemory : Form
    {
        public frmMemory()
        {
            InitializeComponent();
        }
        Graphics myGraphics;
        public static int Timer;    
        public static int HintCost;
        public static bool GameOver;
        public static bool HintUsed;                         //Multiform Global variables for highscoreboard
        public static int GameMode;
        public static int Choice;
        public static int Checker;
        public static int M;
        public static string User;
        public static int Counter;//same as SCore in teachers code
        public static int Score;//serves a different purpose than what teacher intended
        int imageY;
        int X;
        int Login;
        int Red;    //Glabal variables
        int Green;
        int Blue;
        int GameStart;

        int[] Picked = new int[2];
        int[] Behind = new int[16];
        PictureBox[] Displayed = new PictureBox[16];
        PictureBox[] Choices = new PictureBox[8];
        Random myrandom = new Random();
        private void Form1_Load(object sender, EventArgs e)
        { }
        private void frmMemory_Load(object sender, EventArgs e)
        {
            new frmScoreboard().Show(); // shows scoreboard
            ShowPic();
            for (int i = 0; i < 16; i++)
            {
                Displayed[i].Enabled = false;
            }
                 Animate(); //Start up  Animations
                myGraphics = pnlAnimate.CreateGraphics(); // for drawing startup animation
            this.BackColor = Color.Gainsboro; 

        }
        private void NewGame()
        {
            for (int i = 0; i < 16; i++) //loop for 16 cards
            {
                //replace with card back
                Displayed[i].Image = picBack.Image;
                Displayed[i].Enabled = true;
                Displayed[i].Visible = true;
                Behind[i] = i;
            }
            //Randomly sort  16 integers (0 to 15) using shuffle routine
            //behind array contains indexes (0-7) for hidden pictures
            // Work through remaining Values
            //Start at 16 and swap one Value at each for loop step
            //After each step, remaining is decreased by 1
            for (int remaining = 16; remaining >= 1; remaining--)
            {
                //pick an item at random
                int itemPicked = myrandom.Next(remaining);
                //Swap picked item with bottom item and take it out of the loop
                int tempValue = Behind[itemPicked];
                Behind[itemPicked] = Behind[remaining - 1];
                Behind[remaining - 1] = tempValue;
            }
            //sets up  the matching pair
            for (int i = 0; i < 16; i++)
            {
                if (Behind[i] > 7)
                {
                    Behind[i] = Behind[i] - 8;
           //Q1)  
                 //   {   it creates two of  each card, basically setting up the match
                        // takes numbers from 0 to 7, and tells us which photo is behind which picture box control.
               //}
             //Q2
                    //the deck shuffing randomizes the cards, picks a value , then takes it out of the loop and repeats the process till the deck runs out of cards
                    //Q3  The for loop with tthe behind[i] sets up  a list of 16 random integers and by subtracting 8, we make two  of the random integers the same value.
                }
            }
            Choice = 0;
        }
        private void picHidden0_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 0; // assigns value for each picked choice
            Check();
        }
        private void picHidden1_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 1; // assigns value for each picked choice
            Check();
        }
        private void picHidden2_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 2;// assigns value for each picked choice
            Check();
        }

        private void picHidden3_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 3;// assigns value for each picked choice
            Check();
        }
        private void picHidden4_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 4;// assigns value for each picked choice
            Check();
        }
        private void picHidden5_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 5;// assigns value for each picked choice
            Check();
        }
        private void picHidden6_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 6;// assigns value for each picked choice
            Check();
        }
        private void picHidden7_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 7;// assigns value for each picked choice
            Check();
        }
        private void picHidden8_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 8;// assigns value for each picked choice
            Check();
        }
        private void picHidden9_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 9;// assigns value for each picked choice
            Check();
        }
        private void picHidden10_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 10;// assigns value for each picked choice
            Check();
        }
        private void picHidden11_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 11;// assigns value for each picked choice
            Check();
        }
        private void picHidden12_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 12;// assigns value for each picked choice
            Check();
        }
        private void picHidden13_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 13;// assigns value for each picked choice
            Check();
        }
        private void picHidden14_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 14;// assigns value for each picked choice
            Check();
        }
        private void picHidden15_Click(object sender, EventArgs e)
        {
            Picked[Choice] = 15;// assigns value for each picked choice
            Check();
        }
        private void Check()
        {
            // Only execute if not trying to pick the same box
            if (Choice == 0 || (Choice == 1 && Picked[0] != Picked[1])) 
                //Q4 this checks whether this is your first card choice or not and makes sure nothing happens if you click the same picture twice consecutively
            {
                //Display selected picture
                Displayed[Picked[Choice]].Image = Choices[Behind[Picked[Choice]]].Image;
                //choices[behind[picked[choice]]].Image displays the imagebehind the selected card
                // it checks if it is your first choice of cards then assigns a value based on what card is picked, e.g 
                // if Picked[Choice] = 14 , then choices[behind[14]].Image. and it shows one of the images of the pair for 14 
                if (Choice == 0)
                {
                    //first choice  - display 
                    Choice = 1;
                }

                else
                {
                    Counter++; //For number of trials
                    lblCount.Text = Counter.ToString();
                    lblScore.Text = Score.ToString();

                    //Delay for a bit before checking
                    tmrDelay.Start();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tmrDelay_Tick(object sender, EventArgs e)
        {
            tmrDelay.Enabled = false; // ensures timer ticks only once

            // after delay, Check for match
            if (Behind[Picked[0]] == Behind[Picked[1]])
            {
                

                Red = myrandom.Next(0, 256); //random value for an int for colors
                Green = myrandom.Next(0, 256);//random value for an int for colors
                Blue = myrandom.Next(0, 256);//random value for an int for colors
                this.BackColor = Color.FromArgb(Red, Green, Blue); //Flashes background color
                 pnlGame.BackColor = Color.FromArgb(Red, Green, Blue);   
                Displayed[Picked[0]].Visible = false;//If the images are the same, remove pictures
                Displayed[Picked[1]].Visible = false;
                Checker += 1; //helps program know when game over

                if (Checker == 1)
                {
                    btnHint.Enabled = true; 
                }


                if (Checker == 8 && (GameMode == 1 || GameMode == 2))
                {
                    M += 1; // for scoreboard
                    btnTimeTrial.Enabled = true; 
                    tmrBackColor.Start();
                    tmrGame.Stop();
                    if (Timer <= 10)
                    {
                        Score = 15000;
                        MessageBox.Show("WOW, that was amazing!");
                    }
                    else if (Timer <= 30)
                    {
                        Score = 10000;
                    }
                    else if (Timer > 30 && Timer < 60)
                    {
                        Score = 5000;

                    }
                    else if (Timer >= 60)
                    {
                        Score = 2500;
                    }
                    GameOver = true;
                    Score = Score + ( 1360 - Counter * 2 ) - HintCost -( Timer * 2 + 50);
                    lblScore.Text = Score.ToString();
                    MessageBox.Show("Welldone! Check the Score board to review your points!");
                    
                     Reset();

                    tmrBackColor.Stop();
                }
            }
            else
            {
                //if images are not the same, flip them back
                Displayed[Picked[0]].Image = picBack.Image;
                Displayed[Picked[1]].Image = picBack.Image;
                lblHint.Text = "If you can't match a card, use hint! \r\n worth 500 points";

            }

            Choice = 0;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameOver = false;
            Timer = 0;
            if (cboGameMode.SelectedIndex != -1)
            {
                btnStart.Enabled = false;
                btnTimeTrial.Enabled = false;
            }
            ChooseMode();
            if (GameMode == 1 || GameMode == 2 || GameMode == 3)
            {
                //ShowPic();
                Checker = 0;
                //Start Game
                // tmrGameStart.Enabled = true;
                NewGame();
                tmrGameStart.Start();
                AlphaProtocol();
            }
        }
        private void ShowPic()
        {
            Displayed[0] = picHidden0;
            Displayed[1] = picHidden1;
            Displayed[2] = picHidden2;
            Displayed[3] = picHidden3;
            Displayed[4] = picHidden4;
            Displayed[5] = picHidden5;
            Displayed[6] = picHidden6;
            Displayed[7] = picHidden7;                   // these were placed in here to make code more organized
            Displayed[8] = picHidden8;
            Displayed[9] = picHidden9;
            Displayed[10] = picHidden10;
            Displayed[11] = picHidden11;
            Displayed[12] = picHidden12;
            Displayed[13] = picHidden13;
            Displayed[14] = picHidden14;
            Displayed[15] = picHidden15;
            Choices[0] = picChoice8;
            Choices[1] = picChoice1;
            Choices[2] = picChoice2;
            Choices[3] = picChoice3;
            Choices[4] = picChoice4;
            Choices[5] = picChoice5;
            Choices[6] = picChoice6;
            Choices[7] = picChoice7;
        }
        private void tmrAnimat_Tick(object sender, EventArgs e)
        {
            Login++;
            switch (Login)
            {
                //STARTUP ANIMATION :D

                case 1:
                    this.BackgroundImage = Properties.Resources.A;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources.N;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources.K;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources.I;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources.A;
                    break;
                case 6:
                    this.BackgroundImage = Properties.Resources.AK;
                    break;
                case 7:
                    this.BackgroundImage = Properties.Resources.AKI;
                    break;
                case 8:
                    this.BackgroundImage = Properties.Resources.Akin_Vector2;
                    break;
                case 9:
                    GameLogo();
                    tmrHover.Start();
                    break;
                          }

        }
        private void GameLogo()
        {                                //drawing game ogo
            imageY = 10;
            pnlAnimate.Size = new Size(740, 653);
            pnlAnimate.Location = new Point(0, 0);
            pnlAnimate.BackgroundImage = Properties.Resources.clouds;

        }
        private void Animate()
        {
            Login = 0;
            pnlGame.Visible = false;

            X = 0;
            tmrAnimate.Start();
        }
        private void UnAnimate()
        {
            // sets program to proper state for game play
            this.BackgroundImage = null;
            this.BackColor = Color.Teal;
            pnlGame.Visible = true;
            myGraphics.Dispose();
            pnlAnimate.Visible = false;
            Login = 0;
            tmrAnimate.Stop();
            tmrHover.Stop();

        }

        private void tmrBackColor_Tick(object sender, EventArgs e)
        {
            Red = myrandom.Next(0, 256);
            Green = myrandom.Next(0, 256);
            Blue = myrandom.Next(0, 256);
                                                //flashes back color at end of game play
            this.BackColor = Color.FromArgb(Red, Green, Blue);
            pnlGame.BackColor = Color.FromArgb(Red, Green, Blue);
        }

        private void tmrGameStart_Tick(object sender, EventArgs e)
        {
            GameStart += 1;
            // Reset();

            if (GameStart == 4)
            {
                for (int i = 0; i < 16; i++)
                {
                    //replace with card back
                    Displayed[i].Image = picBack.Image;
                    Picked[Choice] = i;
                    Displayed[Picked[Choice]].Enabled = true;
                }
                tmrGame.Start();
                tmrGameStart.Enabled = false;

                GameStart = 0;
            }
        }

        private void btnAlien_Click(object sender, EventArgs e)
        {// change each picchoice image first
         //change pic back to Alien ship
         //function oved over to ComboBox
        }
        private void AlphaProtocol()
        {
            for (int i = 0; i < 16; i++)
            {
                if (Behind[i] > 7)
                {
                    Behind[i] = Behind[i] - 8;
                }
                Picked[Choice] = i;
                Displayed[Picked[Choice]].Enabled = false;
                Displayed[Picked[Choice]].Image = Choices[Behind[Picked[Choice]]].Image; // displays images for a brief period at the start of the game
            }
            Choice = 0;
        }

        private void frmMemory_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGraphics.Dispose();
        }

        private void tmrHover_Tick(object sender, EventArgs e)
        {
            X += 1;
            int imageX = 70;
            int imageW = 100;
            int imageH = 100;
            pnlAnimate.Visible = true;
            if (X == 3)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);
            }
            else if (X == 7)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);               //Draws each letter of logo
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
            }
            else if (X == 11)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH); //Draws each letter of logo
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH);
            }
            else if (X == 15)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);//Draws each letter of logo
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH);
                myGraphics.DrawImage(picO.Image, imageX + 225, imageY, imageW, imageH);
            }
            else if (X == 20)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH); //Draws each letter of logo
                myGraphics.DrawImage(picO.Image, imageX + 225, imageY, imageW, imageH);
                myGraphics.DrawImage(picR.Image, imageX + 300, imageY, imageW, imageH);
            }
            else if (X == 25)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH);
                myGraphics.DrawImage(picO.Image, imageX + 225, imageY, imageW, imageH);
                myGraphics.DrawImage(picR.Image, imageX + 300, imageY, imageW, imageH);   //Draws each letter of logo
                myGraphics.DrawImage(picY.Image, imageX + 375, imageY, imageW, imageH);

            }
            else if (X == 35)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH);
                myGraphics.DrawImage(picO.Image, imageX + 225, imageY, imageW, imageH);
                myGraphics.DrawImage(picR.Image, imageX + 300, imageY, imageW, imageH); //Draws each letter of logo
                myGraphics.DrawImage(picY.Image, imageX + 375, imageY, imageW, imageH);
                myGraphics.DrawImage(picG.Image, imageX, imageY + 100, imageW, imageH);

            }
            else if (X == 40)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH);
                myGraphics.DrawImage(picO.Image, imageX + 225, imageY, imageW, imageH); //Draws each letter of logo
                myGraphics.DrawImage(picR.Image, imageX + 300, imageY, imageW, imageH);
                myGraphics.DrawImage(picY.Image, imageX + 375, imageY, imageW, imageH);
                myGraphics.DrawImage(picG.Image, imageX, imageY + 100, imageW, imageH);
                myGraphics.DrawImage(picA.Image, imageX + 75, imageY + 100, imageW, imageH);

            }
            else if (X == 45)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH);
                myGraphics.DrawImage(picO.Image, imageX + 225, imageY, imageW, imageH);
                myGraphics.DrawImage(picR.Image, imageX + 300, imageY, imageW, imageH);
                myGraphics.DrawImage(picY.Image, imageX + 375, imageY, imageW, imageH); //Draws each letter of logo
                myGraphics.DrawImage(picG.Image, imageX, imageY + 100, imageW, imageH);
                myGraphics.DrawImage(picA.Image, imageX + 75, imageY + 100, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY + 100, imageW, imageH);

            }
            else if (X == 50)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH);
                myGraphics.DrawImage(picO.Image, imageX + 225, imageY, imageW, imageH);
                myGraphics.DrawImage(picR.Image, imageX + 300, imageY, imageW, imageH);
                myGraphics.DrawImage(picY.Image, imageX + 375, imageY, imageW, imageH);
                myGraphics.DrawImage(picG.Image, imageX, imageY + 100, imageW, imageH);   //Draws each letter of logo
                myGraphics.DrawImage(picA.Image, imageX + 75, imageY + 100, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY + 100, imageW, imageH);
                myGraphics.DrawImage(picE.Image, imageX + 225, imageY + 100, imageW, imageH);

            }
            else if (X == 55)
            {
                myGraphics.DrawImage(picM.Image, imageX, imageY, imageW, imageH);
                myGraphics.DrawImage(picE.Image, imageX + 75, imageY, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY, imageW, imageH);
                myGraphics.DrawImage(picO.Image, imageX + 225, imageY, imageW, imageH);
                myGraphics.DrawImage(picR.Image, imageX + 300, imageY, imageW, imageH);
                myGraphics.DrawImage(picY.Image, imageX + 375, imageY, imageW, imageH);
                myGraphics.DrawImage(picG.Image, imageX, imageY + 100, imageW, imageH);
                myGraphics.DrawImage(picA.Image, imageX + 75, imageY + 100, imageW, imageH);
                myGraphics.DrawImage(picM2.Image, imageX + 150, imageY + 100, imageW, imageH); //Draws each letter of logo
                myGraphics.DrawImage(picE.Image, imageX + 225, imageY + 100, imageW, imageH);
                myGraphics.DrawImage(picBrain.Image, imageX + 200, imageY + 200, imageW + 99, imageH + 77);
                myGraphics.DrawImage(picAkin.Image, imageX + 500, imageY + 575, imageW - 2, imageH - 75);

            }
            else if (X == 85)
            {
                UnAnimate(); //ends startup animation and prepares program for game play
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (GameMode == 1 || GameMode == 2) // for regular games, timer counts up
            {
                Timer += 1;  //sets up timer and displays it
                lblTime.Text = Timer.ToString();
            }
            else if (GameMode == 3) //for time trial , timer counts down, checks if game is lost or won, assigns score
            {
                Timer--;     //sets up timer and displays its
                lblTime.Text = Timer.ToString();
                if (Timer == 0 && Checker != 8)
                {
                    GameOver = true;

                    for (int i = 0; i < 16; i++)
                    {     Displayed[i].Visible = false;
                        
                    }
                    tmrGame.Stop();
                    MessageBox.Show("You tried you died.\r\n You only matched " + Checker.ToString() + " cards. \r\nBetter luck next time");
                    Reset();
                }
                else if (Checker == 8 && GameMode == 3)
                {
                    M += 1;
                GameOver = true;
                      Score = 5000;
                    Score = Score + (Counter * 2 + 1360) + HintCost + (100 - Timer);
                    tmrBackColor.Start();
                    tmrGame.Stop();
                    MessageBox.Show("Ayeee You matched " + Checker.ToString() + " cards in" + (20 - Timer).ToString() + " seconds \r\nWell Done!");
                    tmrBackColor.Stop();
                    Reset();
                  
                }


            }
        }
        private void Reset()
        {
            Timer = 0;
            Checker = 0;
            HintCost = 0;
            lblTime.Text = "0";
            Score = 0;
            Counter = 0;
            GameOver = false;
            HintUsed = false;
            btnTimeTrial.Enabled = true;
            btnStart.Enabled = true;
            GameMode = 0;
            lblRandom.Text = "Hint"; 
        }

        private void btnTimeTrial_Click(object sender, EventArgs e)
        { 
            Reset();
            GameMode = 3;
            ChooseMode();
            Timer = 20;
            btnTimeTrial.Enabled = false;
            NewGame();
            tmrGameStart.Start();
            AlphaProtocol();
            GameMode = 3;
            lblGameMode.Text = "Time Trial";

        }
        private void ChooseMode()
        {
            if (cboGameMode.SelectedIndex == -1 && GameMode != 3) 
            {
                MessageBox.Show("Please Select a game Mode");
            }
            if (cboGameMode.SelectedIndex == 0)
            {
                GameMode = 1;
                lblGameMode.Text = "Noob";
                picBack.Image = Properties.Resources.CardBack;
                picChoice1.Image = Properties.Resources.Crab;
                picChoice2.Image = Properties.Resources.Lobster;
                picChoice3.Image = Properties.Resources.Fish;
                picChoice4.Image = Properties.Resources.Octopus;
                picChoice5.Image = Properties.Resources.SeaHorse;
                picChoice6.Image = Properties.Resources.StarFish;
                picChoice7.Image = Properties.Resources.Squid;
                picChoice8.Image = Properties.Resources.Turtle;

            }
            else if (cboGameMode.SelectedIndex == 1)
            {
                GameMode = 2;
                lblGameMode.Text = "Alien";
                picBack.Image = Properties.Resources.NewBack;
                picChoice1.Image = Properties.Resources.alien;
                picChoice2.Image = Properties.Resources.Alien2;
                picChoice3.Image = Properties.Resources.bloob;
                picChoice4.Image = Properties.Resources.home;
                picChoice5.Image = Properties.Resources.Superman_HD_Cartoon_Photo__2_;
                picChoice6.Image = Properties.Resources.martian_manhunter;
                picChoice7.Image = Properties.Resources.Untitled_1;
                picChoice8.Image = Properties.Resources.a12;

            }

        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            lblRandom.Text = "Noob";
            if (GameOver == false)
            {
                HintCost = 500;
                lblHint.Visible = false;
                for (int i = 0; i < 16; i++)
                {
                    if (Choices[Behind[i]].Image == Choices[Behind[Picked[Choice]]].Image)
                    {

                        Displayed[i].Image = Choices[Behind[i]].Image;
                        HintUsed = true;
                    }
                }
                if (HintUsed == true)
                {
                    btnHint.Enabled = false;
                }
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            User = txtUser.Text;
        }
    }

}