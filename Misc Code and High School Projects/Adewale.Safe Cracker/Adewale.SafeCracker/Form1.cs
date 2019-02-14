#define Debug 
// this code above is here so i can view my secret combo witout having to guess while i code
// to enable it, simply remove the two forward slashes( // ), to disable , add forward slashes

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Adewale.SafeCracker.Properties;

    


namespace Adewale.SafeCracker
{
    public partial class frmSafeCracker : Form
    {
        public static bool GameOver;
        public static int Attempts;
        public static int Timer;
        public static int M;
        public static bool HintUsed;
        public static String Mode;
        public static string User;
        public static    int NumberDigits;
        public static string GameMode;
        Label[] Combo = new Label[5];
        Button[] ComboButton = new Button[9];
    
        String SecretCombo;
        Random rnd = new Random();
        int digitsEntered;
        String EnteredCombo;
        Graphics myGraphics;
        int X;
        int Login;
        int Red;    //Glabal variables
        int Green;
        int Blue;
        int Colorz;
        int Crack;
        SoundPlayer Beepsound;
        SoundPlayer SafeOpening;

        public frmSafeCracker()
        {
            InitializeComponent();
        }

        private void frmSafeCracker_Load(object sender, EventArgs e)
        {
            new frmScoreboard().Show();
            Beepsound = new SoundPlayer(Resources.beep);
            SafeOpening = new SoundPlayer(Resources.SafeOpen);
            DoStuff();
            ToolTip();
            Animate(); //Start up  Animations
            myGraphics = pnlGame.CreateGraphics(); // for drawing startup animation

        }
        private void DoStuff()
        {
            pnlSafe.Enabled = false;
            btnHint.Enabled = false;
            Combo[0] = lblCombo1;
            Combo[1] = lblCombo2;
            Combo[2] = lblCombo3;
            Combo[3] = lblCombo4;
            Combo[4] = lblCombo5;
            ComboButton[0] = btn1;
            ComboButton[1] = btn2;
            ComboButton[2] = btn3;
            ComboButton[3] = btn4;
            ComboButton[4] = btn5;
            ComboButton[5] = btn6;
            ComboButton[6] = btn7;
            ComboButton[7] = btn8;
            ComboButton[8] = btn9;
        }
        private void Animate()
        {
            Login = 0;
            X = 0;
            tmrAnimate.Start();
            pnlBack.Visible = false;
            pnlGame.Visible = false;
            pnlNum.Visible = false;
        }
        private void UnAnimate()
        {

            this.BackgroundImage = null;
            this.BackColor = Color.Teal;
            pnlGame.Visible = true;
            pnlNum.Visible = true;
            pnlBack.Visible = true;
            myGraphics.Dispose();
            tmrAnimate.Stop();
            Login = 0;

            // tmrHover.Stop();

        }
        private void ToolTip()
        {
            
            ToolTip toolTip1 = new ToolTip();// Create the ToolTip 

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnHint, "Use Hint?");
            toolTip1.SetToolTip(this.btnStart, "Click to begin game play");
            toolTip1.SetToolTip(this.lblTime, "Time on game play");
            toolTip1.SetToolTip(this.btnExit, "Exit Game?");
            toolTip1.SetToolTip(this.pnlSafe, "Numpad");
            toolTip1.SetToolTip(this.pnlNum, "Displays Combination");
            toolTip1.SetToolTip(this.rad2Digits, "Try to guess a 2 digit combination!");
            toolTip1.SetToolTip(this.rad3Digits, "Try to guess a 3 digit combination!");
            toolTip1.SetToolTip(this.rad4Digits, "Try to guess a 4 digit combination!");
            toolTip1.SetToolTip(this.rad5Digits, "Try to guess a 5 digit combination!");
            toolTip1.SetToolTip(this.grpOptions, "Select number of combinations");
            toolTip1.SetToolTip(this.txtResults, "Results");
            toolTip1.SetToolTip(this.grpResults, "Results");
            toolTip1.SetToolTip(this.picBack, "Safe");
            toolTip1.SetToolTip(this.btnTimeTrial, "Play Time Trial!");
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            GameMode = "Regular Mode";
            btnTimeTrial.Enabled = false;
            if (btnStart.Text == "Start Game")
            {
                GameOver = false;
                tmrGame.Start();
                btnStart.Text = "Stop Game";
                grpOptions.Enabled = false;
                btnExit.Enabled = false;
                pnlSafe.Enabled = true;
                btnHint.Enabled = true;
                HintUsed = false;

                for (int i = 0; i < 9; i++)
                {
                    ComboButton[i].Enabled = true;  //fixes glitch in teachers code.. i think
                }
                //determine number of digits and sets up labels
                if (rad2Digits.Checked)
                {
                    NumberDigits = 2;
                    Mode = "Beginner";
                }

                else if (rad3Digits.Checked)
                {
                    NumberDigits = 3;
                    Mode = "Noob";
                    
                }
                else if (rad4Digits.Checked)
                {
                    NumberDigits = 4;
                    Mode = "Alpha";
                }
                else if (rad5Digits.Checked)
                {
                    NumberDigits = 5;
                    Mode = "Shogun";
                }
                for (int i = 0; i < NumberDigits; i++)
                {
                    Combo[i].Visible = true;
                    Combo[i].Text = "";
                }
                if (NumberDigits != 5)// q1 Basically if we do not have 5 digit combo selected, the program hides the other labels that are4 not being used
                {
                    for (int i = NumberDigits; i < 5; i++)
                    {
                        Combo[i].Visible = false;
                    }
                //
                }
                //determine Combination
                SecretCombo = "";
                int digit;
                bool UniqueDigit;
                for (int i = 0; i < NumberDigits; i++)
                {
                    //select unique digit
                    do
                    {
                        digit = rnd.Next(1, 10); // generate a random number from 1 to 9 ( 10 is not included)
                        UniqueDigit = true; // ensures the same number isn't repeated
                        if (i != 0)
                        {
                            for (int x = 0; x < i; x++)
                            {
                                if (SecretCombo[x].ToString() == digit.ToString()) // checks if the generated digit already exists in the combo
                                {
                                    UniqueDigit = false; //if digit does exist, bool is turned off, another different diigit is generated
                                }
                            }
                        }

                    }

                    while (!UniqueDigit); // if digit is not repeated, it adds it to the secret combo
                    SecretCombo += digit.ToString();
                }
                EnteredCombo = "";
                digitsEntered = 0;
#if Debug
                grpResults.Text = SecretCombo; 
#endif
// i learnt the abve code from a video online, a way of removing a code from final compile without having to delete the line
            }

            else
            {
                if (EnteredCombo == SecretCombo)
                { GameOver = true;
                    M += 1;
                   
                    txtResults.AppendText("Ayeee, you got it" + "\r\n");
                    tmrBackColor.Start();
                    tmrGame.Stop();
                    Cracked();  
                btnTimeTrial.Enabled = true;

                }
                else
                {
                    txtResults.AppendText("Game Stopped" + "\r\n");
                    GameOver = true;
                    Timer = 0;
                Attempts = 0;
                 btnTimeTrial.Enabled = true;
                }
                 GameOver = true;
                tmrGame.Stop();
                btnHint.Enabled = false;  
                txtResults.AppendText("Combination: " + SecretCombo + "\r\n");
                txtResults.AppendText("Trials: " + Attempts + "\r\n");
                txtResults.AppendText("Time: " + Timer.ToString() + " seconds\r\n");
                btnStart.Text = "Start Game";
                grpOptions.Enabled = true;
                btnExit.Enabled = true;
                pnlSafe.Enabled = false;
                
                
                
            }
        }


        private void Cracked()
        {
            if (Mode == "Beginner")
            {
                Crack = 1;
            }
            else if (Mode == "Noob")
            {
                Crack = 2;
            }
            else if (Mode == "Alpha")
            {
                Crack = 3;
            }
            else if (Mode == "Shogun")
            {
                Crack = 4;
            }

            switch (Crack)
            {
                case 1:
                    tmrAnimate2.Start();
                    break;
                case 2:
                    tmrAnimate2a.Start();
                    break;
                case 3:
                    tmrAnimate2b.Start();
                    break;
                case 4:
                    tmrAnimate2C.Start();
                    break;
            }
        }

        private void MyButtons(object sender, EventArgs e)
        {
            String n;
            Beepsound.Play();
            int numberRight, PositionRight;
            //determine which button was clicked
            Button ClickedButton;
            ClickedButton = (Button)sender;
            //button text is clicked number
            n = ClickedButton.Text;
            //disable button since digits can't repeat
            ClickedButton.Enabled = false;
            //if first button is combo, clear out label boxes
            if (digitsEntered == 0)
            {
                Combo[0].Text = "";
                Combo[1].Text = "";
                Combo[2].Text = "";     // these clear labels after each combo, so next cobo can be inputed
                Combo[3].Text = "";
                Combo[4].Text = "";

            }
            //add button to code
            EnteredCombo += n; //entered value of button to "entered combo"
            digitsEntered++;
            Combo[digitsEntered - 1].Text = n; // changes the text in label to the value of the clicked button
            // if all digits entered, check combo
            if (digitsEntered == NumberDigits) 
            {
                Attempts += 1;
                //reset combo buttons 
                for (int i = 0; i < 9; i++)
                {
                    ComboButton[i].Enabled = true;
                }
                txtResults.AppendText("Entered : " + EnteredCombo + "\r\n");
                if (EnteredCombo == SecretCombo) //checks if entered combo matches the secret combo
                {

                    btnStart.PerformClick();
                }
                else
                {
                    numberRight = 0;
                    for (int i = 0; i < NumberDigits; i++)
                    {
                        n = EnteredCombo[i].ToString();
                        for (int j = 0; j < NumberDigits; j++)
                            if (n == SecretCombo[j].ToString()) // checks if one of the entered digits is one of the digits in the Secretcombo
                                numberRight++;
                    }
                    //how many in correct position
                    PositionRight = 0;
                    for (int i = 0; i < NumberDigits; i++)
                        if (SecretCombo[i] == EnteredCombo[i])
                            PositionRight++; 
                    txtResults.AppendText(numberRight.ToString() + " digits correct" + "\r\n");
                    txtResults.AppendText(PositionRight.ToString() + " in correct position" + "\r\n");
                    txtResults.AppendText("Try Again ..." + "\r\n\r\n");
                    //clear combo to try again
                    EnteredCombo = "";
                    digitsEntered = 0;
                    //Q4 "numberRight" checks if one of the entered digits is one of the digits in the Secretcombo
                    //while position right checks each digit in your entered combo and compares with the secret combo to see if it is in the right spot
                }

                
            }
        }

        private void tmrAnimate_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.Gainsboro)
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

                        break;
                    case 10:
                        break;
                    case 11:
                        break;
                    case 12:
                        break;
                    case 13:
                        break;
                    case 14:
                        UnAnimate();
                        GameSign();
                        Timer = 0;
                        Attempts = 0;
                        break;
                }
            }




        }
        private void GameSign()
        {

            picBack.BringToFront();
            picBack.Size = this.Size;
            picBack.Location = new Point(0, 0);
            picBack.BringToFront();
            pnlBack.Visible = false;
            tmrLogo.Start();
        }
        private void tmrBackColor_Tick(object sender, EventArgs e)
        {
            Colorz += 1;
            Red = rnd.Next(0, 256);
            Green = rnd.Next(0, 256);
            Blue = rnd.Next(0, 256);

            this.BackColor = Color.FromArgb(Red, Green, Blue);
            pnlBack.BackColor = Color.FromArgb(Red, Green, Blue);
            if (Colorz == 10)
            {
                tmrBackColor.Stop();
                Colorz = 0;
            }
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            if (GameMode != "Time Trial")
            {
                Timer++;
                if (Timer < 10)
                {
                    lblTime.Text = "0" + Timer.ToString();
                }
                if (Timer >= 9)
                {
                    lblTime.Text = Timer.ToString();
                }
            }
            else if (GameMode == "Time Trial")
            {
                Timer--;
                lblTime.Text = Timer.ToString();
                if (Timer < 10)
                {
                    lblTime.Text = "0" + Timer.ToString();
                }
                if (Timer >= 9)
                {
                    lblTime.Text = Timer.ToString();
                }

                if (EnteredCombo == SecretCombo)
                {   M += 1;
                    GameOver = true;
                                       
                    txtResults.AppendText("Ayeee, you got it" + "\r\n");
                    tmrBackColor.Start();
                    tmrGame.Stop();
                    Cracked();
                    txtResults.AppendText("Combination: " + SecretCombo + "\r\n");
                    txtResults.AppendText("Trials: " + Attempts + "\r\n");
                    txtResults.AppendText("Time: " + Timer.ToString() + " seconds \r\n");
                
                    btnStart.Text = "Start Game";
                    grpOptions.Enabled = true;
                    btnExit.Enabled = true;
                    pnlSafe.Enabled = false;
                    btnTimeTrial.Enabled = true;
                    btnHint.Enabled = false;
                    tmrGame.Stop();
                
                }
              
                
                 if (Timer == 0)
            {
                if (EnteredCombo == SecretCombo)
                {
                    GameOver = true;
                    M += 1;                    
                    txtResults.AppendText("Ayeee, you got it" + "\r\n");
                    tmrBackColor.Start();
                    tmrGame.Stop();
                    Cracked();
                    btnTimeTrial.Enabled = true;

                    }
                else
                {
                    txtResults.AppendText("Game Stopped" + "\r\n");
                    txtResults.AppendText("You failed the time trial" + "\r\n");
                    btnTimeTrial.Enabled = true;
                    GameOver = true;

                }
                 GameOver = true;
                 tmrGame.Stop();
                 btnHint.Enabled = false;

                txtResults.AppendText("Combination: " + SecretCombo + "\r\n");
                txtResults.AppendText("Trials: " + Attempts + "\r\n");
                txtResults.AppendText("Time: " + Timer.ToString() + " seconds\r\n");
                
                btnStart.Text = "Start Game";
                grpOptions.Enabled = true;
                btnExit.Enabled = true;
                pnlSafe.Enabled = false;
               }
            }
        }

        private void tmrAnimate2_Tick(object sender, EventArgs e)
        {
            X++;
            switch (X)
            {
                //Code Cracked Animation

                case 1:
                    picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                    SafeOpening.Play();
                    pnlNum.Visible = false;
                    break;
                case 2:
                    picBack.Image = Properties.Resources.frame_1_delay_0_1s;
                    break;
                case 3:
                    picBack.Image = Properties.Resources.frame_2_delay_0_1s;
                    break;
                case 4:
                    picBack.Image = Properties.Resources.frame_3_delay_0_1s;
                    break;
                case 5:
                    picBack.Image = Properties.Resources.frame_4_delay_0_1s;
                    break;
                case 6:
                    picBack.Image = Properties.Resources.frame_5_delay_0_1s;
                    break;
                case 7:
                    picBack.Image = Properties.Resources.frame_6_delay_0_1s;
                    break;
                case 8:
                    picBack.Image = Properties.Resources.frame_7_delay_0_1s;
                    break;
                case 9:
                    picBack.Image = Properties.Resources.frame_8_delay_0_1s;
                    break;
                case 10:
                    picBack.Image = Properties.Resources.frame_9;
                    break;
                case 11:
                    picBack.Image = Properties.Resources.frame_10;
                    break;
                case 12:
                    picBack.Image = Properties.Resources.frame_11;
                    break;
                case 13:
                    picBack.Image = Properties.Resources.frame_12;
                    break;
                case 14:
                    picBack.Image = Properties.Resources.frame_13;
                    break;
                case 15:
                    picBack.Image = Properties.Resources.frame_14;
                    break;
                case 16:
                    picBack.Image = Properties.Resources.frame_15;
                    break;
                case 17:
                    picBack.Image = Properties.Resources.pepe;
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    tmrAnimate2.Stop();
                    picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                    pnlNum.Visible = true;
                    X = 0;
                    Timer = 0;
                    Attempts = 0;
                    break;

            }
        }

        private void tmrAnimate2a_Tick(object sender, EventArgs e)
        {
            X++;
            switch (X)
            {
                //Code Cracked Animation
                case 1:
                    picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                    pnlNum.Visible = false;
                    SafeOpening.Play();
                    break;
                case 2:
                    picBack.Image = Properties.Resources.frame_1_delay_0_1s;
                    break;
                case 3:
                    picBack.Image = Properties.Resources.frame_2_delay_0_1s;
                    break;
                case 4:
                    picBack.Image = Properties.Resources.frame_3_delay_0_1s;
                    break;
                case 5:
                    picBack.Image = Properties.Resources.frame_4_delay_0_1s;
                    break;
                case 6:
                    picBack.Image = Properties.Resources.frame_5_delay_0_1s;
                    break;
                case 7:
                    picBack.Image = Properties.Resources.frame_6_delay_0_1s;
                    break;
                case 8:
                    picBack.Image = Properties.Resources.frame_7_delay_0_1s;
                    break;
                case 9:
                    picBack.Image = Properties.Resources.frame_8_delay_0_1s;
                    break;
                case 10:
                    picBack.Image = Properties.Resources.frame_9;
                    break;
                case 11:
                    picBack.Image = Properties.Resources.frame10M;
                    break;
                case 12:
                    picBack.Image = Properties.Resources.frame_11M;
                    break;
                case 13:
                    picBack.Image = Properties.Resources.frame_12M;
                    break;
                case 14:
                    picBack.Image = Properties.Resources.frame_13M;
                    break;
                case 15:
                    picBack.Image = Properties.Resources.frame_14M;
                    break;
                case 16:
                    picBack.Image = Properties.Resources.frame_15M;
                    break;
                case 17:
                    picBack.Image = Properties.Resources.MoneyPepe;
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                    pnlNum.Visible = true;
                    X = 0;
                    tmrAnimate2a.Stop();
                    Timer = 0;
                    Attempts = 0;
                    break;
            }
        }

        private void tmrAnimate2b_Tick(object sender, EventArgs e)
        {
            X++;
            switch (X)
            {
                //Code Cracked Animation
                case 1:
                    picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                    pnlNum.Visible = false;
                    SafeOpening.Play();

                    break;
                case 2:
                    picBack.Image = Properties.Resources.frame_1_delay_0_1s;
                    break;
                case 3:
                    picBack.Image = Properties.Resources.frame_2_delay_0_1s;
                    break;
                case 4:
                    picBack.Image = Properties.Resources.frame_3_delay_0_1s;
                    break;
                case 5:
                    picBack.Image = Properties.Resources.frame_4_delay_0_1s;
                    break;
                case 6:
                    picBack.Image = Properties.Resources.frame_5_delay_0_1s;
                    break;
                case 7:
                    picBack.Image = Properties.Resources.frame_6_delay_0_1s;
                    break;
                case 8:
                    picBack.Image = Properties.Resources.frame_7_delay_0_1s;
                    break;
                case 9:
                    picBack.Image = Properties.Resources.frame_8_delay_0_1s;
                    break;
                case 10:
                    picBack.Image = Properties.Resources.frame_9;
                    break;
                case 11:
                    picBack.Image = Properties.Resources.frame10g;
                    break;
                case 12:
                    picBack.Image = Properties.Resources.frame_11G;
                    break;
                case 13:
                    picBack.Image = Properties.Resources.frame_12G;
                    break;
                case 14:
                    picBack.Image = Properties.Resources.frame_13G;
                    break;
                case 15:
                    picBack.Image = Properties.Resources.frame_14G;
                    break;
                case 16:
                    picBack.Image = Properties.Resources.frame_15G;
                    break;
                case 17:
                    picBack.Image = Properties.Resources.Goldpepe;
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                    pnlNum.Visible = true;
                    X = 0;
                    tmrAnimate2b.Stop();
                    Timer = 0;
                    Attempts = 0;
                    break;
            }
        }
        private void tmrAnimate2c_Tick(object sender, EventArgs e)
        {
            X++;
            switch (X)
            {
                //Code Cracked Animation
                case 1:
                    picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                    pnlNum.Visible = false;
                    SafeOpening.Play();
                    break;
                case 2:
                    picBack.Image = Properties.Resources.frame_1_delay_0_1s;
                    break;
                case 3:
                    picBack.Image = Properties.Resources.frame_2_delay_0_1s;
                    break;
                case 4:
                    picBack.Image = Properties.Resources.frame_3_delay_0_1s;
                    break;
                case 5:
                    picBack.Image = Properties.Resources.frame_4_delay_0_1s;
                    break;
                case 6:
                    picBack.Image = Properties.Resources.frame_5_delay_0_1s;
                    break;
                case 7:
                    picBack.Image = Properties.Resources.frame_6_delay_0_1s;
                    break;
                case 8:
                    picBack.Image = Properties.Resources.frame_7_delay_0_1s;
                    break;
                case 9:
                    picBack.Image = Properties.Resources.frame_8_delay_0_1s;
                    break;
                case 10:
                    picBack.Image = Properties.Resources.frame_9;
                    break;
                case 11:
                    picBack.Image = Properties.Resources.frame10d;
                    break;
                case 12:
                    picBack.Image = Properties.Resources.frame_11D;
                    break;
                case 13:
                    picBack.Image = Properties.Resources.frame_12D;
                    break;
                case 14:
                    picBack.Image = Properties.Resources.frame_13D;
                    break;
                case 15:
                    picBack.Image = Properties.Resources.frame_14D;
                    break;
                case 16:
                    picBack.Image = Properties.Resources.frame_15D;
                    break;
                case 17:
                    picBack.Image = Properties.Resources.diamondpepe;
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                case 23:
                    break;
                case 24:
                    break;
                case 25:
                    break;
                case 26:
                    picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                    pnlNum.Visible = true;
                    X = 0;
                    tmrAnimate2C.Stop();
                    Timer = 0;
                    Attempts = 0;
                    break;
            }
        }
        private void btnHint_Click(object sender, EventArgs e)
        {
            double myInt = int.Parse(SecretCombo);
            double myvalue = ((((((myInt * 4) + 98) / 3) + 69) * 1.876) - 7);
            double Answer = Math.Round(myvalue, MidpointRounding.AwayFromZero);
            txtResults.AppendText("If you multiply the secret code by 4 add 98 divide by 3, add 69 (cuz why not) multiply by 1.876 subtract 7 and round to the nearest whole number,you'll get : " 
                + Answer + "\r\nI'd personally just guess, but to each their own");
            HintUsed = true;
         }

        private void tmrLogo_Tick(object sender, EventArgs e)
        {
            X += 1;
            if (X == 3)
            { picBack.Size = new Size(923, 603);
                picBack.Image = Properties.Resources.frame_0_delay_0_1s;
                tmrLogo.Stop();
                X = 0;
                picBack.SendToBack();
                pnlBack.Visible = true;
            }
        }
         private void btnTimeTrial_Click(object sender, EventArgs e)
        {
            GameMode = "Time Trial";
           btnTimeTrial.Enabled = false;
            Timer =  60;
            lblTime.Text = Timer.ToString();
            if (btnStart.Text == "Start Game")
            {
                GameOver = false;
                tmrGame.Start();
                btnStart.Text = "Stop Game";
                grpOptions.Enabled = false;
                btnExit.Enabled = false;
                pnlSafe.Enabled = true;
                btnHint.Enabled = true;
                HintUsed = false;

                for (int i = 0; i < 9; i++)
                {
                    ComboButton[i].Enabled = true;  //fixes glitch in teachers code
                }
                //determine number of digits and sets up labels
                if (rad2Digits.Checked)
                {
                    NumberDigits = 2;
                    Mode = "Beginner";
                }
                else if (rad3Digits.Checked)
                {
                    NumberDigits = 3;
                    Mode = "Noob";
                }
                else if (rad4Digits.Checked)
                {
                    NumberDigits = 4;
                    Mode = "Alpha";
                }
                else if (rad5Digits.Checked)
                {
                    NumberDigits = 5;
                    Mode = "Shogun";
                }
                for (int i = 0; i < NumberDigits; i++)
                {
                    Combo[i].Visible = true;
                    Combo[i].Text = "";
                }
                if (NumberDigits != 5)// q1 Basically if we do not have 5 digit combo selected, the program hides the other labels that are4 not being used
                {
                    for (int i = NumberDigits; i < 5; i++)
                    {
                        Combo[i].Visible = false;
                    }
                }
                //determine Combination
                SecretCombo = "";
                int digit;
                bool UniqueDigit;
                for (int i = 0; i < NumberDigits; i++)
                {
                    //select unique digit
                    do
                    {
                        digit = rnd.Next(1, 10); // generate a random number from 1 to 9 ( 10 is not included)
                        UniqueDigit = true; // ensures the same number isn't repeated
                        if (i != 0)
                        {
                            for (int x = 0; x < i; x++)
                            {
                                if (SecretCombo[x].ToString() == digit.ToString()) // checks if the generated digit already exists in the combo
                                {
                                    UniqueDigit = false; //if digit does exist, bool is turned off, another different diigit is generated
                                }
                            }
                        }

                    }

                    while (!UniqueDigit); // if digit is not repeated, it adds it to the secret combo
                    SecretCombo += digit.ToString();
                }
                EnteredCombo = "";
                digitsEntered = 0;
#if Debug
                grpResults.Text = SecretCombo; 
#endif


            }
           else
            {
                if (EnteredCombo == SecretCombo)
                {
                    GameOver = true;
                    M += 1;
                    
                    txtResults.AppendText("Ayeee, you got it" + "\r\n");
                    tmrBackColor.Start();
                    tmrGame.Stop();
                    Cracked();
                 }
                else
                {
                    txtResults.AppendText("Game Stopped" + "\r\n");
                    GameOver = true;

                }
                GameOver = true;
                tmrGame.Stop();
                btnHint.Enabled = false;

                txtResults.AppendText("Combination: " + SecretCombo + "\r\n");
                txtResults.AppendText("Trials: " + Attempts + "\r\n");
                txtResults.AppendText("Time: " + Timer.ToString() + " seconds\r\n");
                btnStart.Text = "Start Game";
                grpOptions.Enabled = true;
                btnExit.Enabled = true;
                pnlSafe.Enabled = false;
               
            }
        }
    private void txtUser_TextChanged(object sender, EventArgs e)
        {
            User = txtUser.Text;
        }
    private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

