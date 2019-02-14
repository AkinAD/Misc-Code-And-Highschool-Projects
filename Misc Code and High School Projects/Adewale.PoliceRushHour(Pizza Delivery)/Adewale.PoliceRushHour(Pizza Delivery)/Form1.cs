using System;
using Adewale.PoliceRushHour_Pizza_Delivery_.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Drawing.Text;
using System.Runtime.InteropServices;

namespace Adewale.PoliceRushHour_Pizza_Delivery_
{
    public partial class frmPizzaDelivery : Form
    {
        Label[,] deliveryGrid = new Label[21, 21];
        int mSecPerMin = 3000;
        const int PizzaReadyMax = 20;
       
        const int minPer20squares = 3;
        const int OrderMaxTime = 60;
        const int OrderLateTime = 30;
        const int netsoldPizza = 10;
        const int netLatePizza = 5;                     //constants for game
        const int CostMissedPizza = 1;
        const int pizzaCost = 3;
        const double mileageCost = 0.1;
        int pizzasBakingMax = 8;
        int bakingTime = 10;
        int PizzasInCarMax = 10;
        int PB1;  int PB2; int PB3; int PB4; 
        int ProgressBar1; int ProgressBar2; int ProgressBar3; int ProgressBar4; 
        int BL; int LU; int Level; int OV = 0; int Sign; int TimeOut; int Animation; int SomeInteger;
        int Z; int G;  int A; int P;
        int QuickFlash;
        int pizzaInCar;
        int pizzaOnTime;
        int pizzaLate; //A bunch of ints
        int missedDeliveries;
        int totalSales;
        int ClockHour, ClockMinute;
        int pizzaC, pizzaR;
        int deliveryC, deliveryR;
        int ZdeliveryC, ZdeliveryR;
        int AdeliveryC, AdeliveryR;
        int PdeliveryC, PdeliveryR;
        int GdeliveryC, GdeliveryR;
        int carC, carR;
        int ZcarC, ZcarR;
        int AcarC, AcarR;
        int PcarC, PcarR;
        int GcarC, GcarR;
        int ZCarStartC, ZCarStartR; 
        int deltaC, deltaR;
        int ZdeltaC, ZdeltaR;
        int AdeltaC, AdeltaR;
        int PdeltaC, PdeltaR;
        int GdeltaC, GdeltaR;
        int mileage;
        bool carGoing;
        bool ZcarGoing;
        bool AcarGoing;
        bool PcarGoing;
        bool GcarGoing;                         //Bunch of bools
        
        bool EnterPressed;
        bool Paid;
       bool FakeStartUpDone;
       
        int pizzasBaking, pizzasReady;
        int totalPizzasBaked;
        float FontSize = 25.0F;
        PictureBox[] pizzaInOven = new PictureBox[12];
        Image[] LoadingBarFrames = new Image[150];
        int bakingMinutesLeft;
        bool ovenGoing;
        int[,] Pizzas = new int[21, 21];
        int[,] PizzaTime = new int[21, 21];
        String UserName;
        Random rnd = new Random();
        SoundPlayer GameOverSound;
        SoundPlayer PhoneSound;
        SoundPlayer DingSound;
        SoundPlayer BeepSound;
        SoundPlayer KACHING; //!
        SoundPlayer KeyTapA; SoundPlayer NeonA; SoundPlayer NeonB; SoundPlayer NeonC;
        SoundPlayer BackSpace;
        [System.Runtime.InteropServices.DllImport("gdi32.dll")] //here 
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, //here
        IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts); //here
        private PrivateFontCollection fonts = new PrivateFontCollection(); //here are all neceseray for importing new font
        private PrivateFontCollection fonts2 = new PrivateFontCollection();
        private PrivateFontCollection fonts3 = new PrivateFontCollection();

        Font myFont; //here
        Font CommandPromptFont; Font NeonLogoFont;

        public frmPizzaDelivery()
        {
            InitializeComponent();  // the following code is used to load up custom font into the game
            byte[] fontData = Properties.Resources.Clock_Font;//also here
            byte[] fontData2 = Properties.Resources.Command_Prompt;
            byte[] fontData3 = Properties.Resources.BeautySchoolDropoutII;

            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length); //here as well
            IntPtr fontPtr2 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData2.Length);
            IntPtr fontPtr3 = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData3.Length);

            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length); //here
            System.Runtime.InteropServices.Marshal.Copy(fontData2, 0, fontPtr2, fontData2.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData3, 0, fontPtr3, fontData3.Length);

            uint dummy = 0; //here
            uint dummy2 = 0;                                    //All this is to genereate two seperate Custom fonts
            uint dummy3 = 0;
            fonts.AddMemoryFont(fontPtr, Properties.Resources.Clock_Font.Length); //then heere
            fonts2.AddMemoryFont(fontPtr2, Properties.Resources.Command_Prompt.Length);
            fonts3.AddMemoryFont(fontPtr3, Properties.Resources.BeautySchoolDropoutII.Length);

            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.Clock_Font.Length, IntPtr.Zero, ref dummy); //here likewise
            AddFontMemResourceEx(fontPtr2, (uint)Properties.Resources.Command_Prompt.Length, IntPtr.Zero, ref dummy2);
            AddFontMemResourceEx(fontPtr2, (uint)Properties.Resources.Command_Prompt.Length, IntPtr.Zero, ref dummy3);

            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);//here
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr2);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr3);

            myFont = new Font(fonts.Families[0], FontSize); // and finally here, all the code used to make custom font work (remember to import the .ttf file ~font install file~ into the program first)
            CommandPromptFont = new Font(fonts2.Families[0], 12.0F); // specify font size (12.0F in this case)
            NeonLogoFont = new Font(fonts3.Families[0], 75.0F);
        }
        private void PizzaInOven()
        {   // array for piccture of pizza
            pizzaInOven[0] = picPizza1;
            pizzaInOven[1] = picPizza2;
            pizzaInOven[2] = picPizza3;
            pizzaInOven[3] = picPizza4;
            pizzaInOven[4] = picPizza5;
            pizzaInOven[5] = picPizza6;
            pizzaInOven[6] = picPizza7;
            pizzaInOven[7] = picPizza8;
            pizzaInOven[8] = picPizza9;
            pizzaInOven[9] = picPizza10;
            pizzaInOven[10] = picPizza11;
            pizzaInOven[11] = picPizza12;
           
        }
      
        private void frmPizzaPolice_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true; //makes graphics better 
            this.KeyPreview = true;  //for some reason i don't know, key down was not working on its own and required me to add these lines to the from load event
            this.KeyDown += new KeyEventHandler(frmPizzaDelivery_KeyDown);
            
            Animate(); //in the typical Akin fashion, there is a start up animation
            ToolTip(); // little messages that pop up when you hover on a form object
            
            lstOrders.Font = CommandPromptFont;          //makes use of the custom font created above
            lblMessage.Font = CommandPromptFont;

            pnlUpgrade.Visible = false;
            this.Size = new Size(905, 745);
            lblA.Visible = lblP.Visible = lblG.Visible = lblZ.Visible = false; //i used these labels to test feautures i added
            PizzaInOven();                                          // all this sets up the game for first play
            grpOven.Enabled = false; pnlOven.Enabled = false;
            grpPizza.Enabled = false;
            tmrClock.Interval = mSecPerMin; 
            tmrOven.Interval = mSecPerMin;
            tmrCar.Interval = mSecPerMin * minPer20squares / 20;
            tmrCar2.Interval = (mSecPerMin - 300) * (minPer20squares -1)/ 20;  // each new car is faster than the last
            tmrCar3.Interval = (mSecPerMin - 600) * (minPer20squares - 1 )/ 20;
            tmrCar4.Interval = (mSecPerMin - 900) * (minPer20squares - (1 + (1/2))) / 20;
            tmrCar5.Interval = (mSecPerMin - 1200) * (minPer20squares - 2) / 20;

            tmrLevelUpCheck.Start(); // timer always running to check for when user reaches certain point
            
            //i imported the wav file rather than have the program search for it in my computer files
            //initializing all sound in Game
            GameOverSound = new SoundPlayer(Resources.tada);
            PhoneSound = new SoundPlayer(Resources.phone);
            DingSound = new SoundPlayer(Resources.ding);
            BeepSound = new SoundPlayer(Resources.carbeep);
            KACHING = new SoundPlayer(Resources.ka_ching_Sound_Effect);
             KeyTapA = new SoundPlayer(Resources.keytap);
            BackSpace = new SoundPlayer(Resources.Backspace);
            NeonA = new SoundPlayer(Resources.First_Neon);
            NeonB = new SoundPlayer(Resources.Second_Neon);
            NeonC = new SoundPlayer(Resources.Third_Neon);
             {
                int w = pnlGrid.Width / 24;
                int l = w;
                int t = w;
                // J is row, I is Column; build one row at a time
                for (int j = 0; j < 21; j++)
                {
                    for (int i = 0; i < 21; i++)
                    { // Drawing grid onto the panel
                        deliveryGrid[i, j] = new Label();
                        deliveryGrid[i, j].Width = w;
                        deliveryGrid[i, j].Height = w;
                        deliveryGrid[i, j].Top = t;
                        deliveryGrid[i, j].Left = l;
                        deliveryGrid[i, j].Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                        deliveryGrid[i, j].TextAlign = ContentAlignment.MiddleCenter;
                        if (i == 0)
                        {
                            if (j != 0)
                            {
                            //row numbers
                                deliveryGrid[i, j].Text = j.ToString();
                                deliveryGrid[i, j].Width = Convert.ToInt32(1.5 * w);
                                deliveryGrid[i, j].Left = Convert.ToInt32(0.5 * w);
                                deliveryGrid[i, j].ForeColor = Color.DarkBlue;
                            }
                         }
                        else if (j == 0)
                        {
                            if (i != 0)
                            {
                                //column Letters
                                deliveryGrid[i, j].Text = ((char)(i + 64)).ToString();
                                deliveryGrid[i, j].ForeColor = Color.DarkBlue;
                            }
                        }
                        else
                        {
                            deliveryGrid[i, j].BorderStyle = BorderStyle.FixedSingle;
                            deliveryGrid[i, j].BackColor = Color.White;
                            deliveryGrid[i, j].ForeColor = Color.Yellow;
                            if (i < 10)
                                deliveryGrid[i, j].Tag = "0" + i.ToString();
                            else
                                deliveryGrid[i, j].Tag = i.ToString();
                            if (j < 10)
                                deliveryGrid[i, j].Tag += "0" + j.ToString();
                            else
                                deliveryGrid[i, j].Tag += j.ToString();
                            deliveryGrid[i, j].Click += new System.EventHandler(this.DeliveryGrid_Click);

                        }
                        pnlGrid.Controls.Add(deliveryGrid[i, j]);
                        l += w;
                    }
                    l = w;
                    t += w;
                }
            }
        }
        private void Animate()
        { //Animation starts here
            FontSize += 100.0f;
            myFont = new Font(fonts.Families[0], FontSize);
            lblAnimate.Font = myFont;
            lblPressEnter.Font = CommandPromptFont;
            tmrAnimate.Start();
            pnlAnimate.Location = new Point(0, 0);
            pnlAnimate.Size = this.Size;
            pnlAnimate.Visible = true;
           

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
            //toolTip1.SetToolTip(this.btnHint, "Use Hint?");
            //toolTip1.SetToolTip(this.btnStart, "Click to begin game play");
            //toolTip1.SetToolTip(this.lblTime, "Time on game play");
            //toolTip1.SetToolTip(this.btnExit, "Exit Game?");
            //toolTip1.SetToolTip(this.pnlSafe, "Numpad");
            //toolTip1.SetToolTip(this.pnlNum, "Displays Combination");
            //toolTip1.SetToolTip(this.rad2Digits, "Try to guess a 2 digit combination!");
            //toolTip1.SetToolTip(this.rad3Digits, "Try to guess a 3 digit combination!");
            //toolTip1.SetToolTip(this.rad4Digits, "Try to guess a 4 digit combination!");
            //toolTip1.SetToolTip(this.rad5Digits, "Try to guess a 5 digit combination!");
            //toolTip1.SetToolTip(this.grpOptions, "Select number of combinations");
            //toolTip1.SetToolTip(this.txtResults, "Results");
            //toolTip1.SetToolTip(this.grpResults, "Results");
            //toolTip1.SetToolTip(this.picBack, "Safe");
            //toolTip1.SetToolTip(this.btnTimeTrial, "Play Time Trial!");
        }
        private void Instructions()
            //To ensure users know what they are doing with the game
        {   if (btnStart.Text == "Pause Game")
                btnStart.PerformClick();
            btnBegin.Visible = true;
             lblCredits.Font = new Font(fonts.Families[0], 25.0F);
            lblAnimate.Font = new Font(fonts2.Families[0], 15.0F);
            lblCredits.Text = "INSTRUCTIONS";
            lblCredits.Visible = true;
            lblCredits.Location = new Point(341, 26);
            lblAnimate.Location = new Point(35, 104);
            lblAnimate.Text = "Hello " + UserName;
            lblAnimate.Text += "\r\nWelcome to the Pizza Delivery game ";
            lblAnimate.Text += "\r\nYour mission is to bake and deliver as many boxes of pizza as possible in 5 hours";
            lblAnimate.Text += "\r\nOh and also to earn as much money as possible of course!";
            lblAnimate.Text += "\r\nYou start at the pizza parlor and make your way around the map";
            lblAnimate.Text += "\r\nWhen you're out of pizza or don't have enough, click back at to pizza parlor to reload";
            lblAnimate.Text += "\r\nReload only works if you have enough pizzas already pre-baked and ready to load";
            lblAnimate.Text += "\r\nUse the 'Load' button to transfer pizza to the car and get back to deliveries!";
            lblAnimate.Text += "\r\n\r\nBAKING PIZZA";
            lblAnimate.Text += "\r\nIt is advisable to place as much Pizza as possible in the oven at time ";
            lblAnimate.Text += "\r\nTo place Pizza in the oven, tap the plus sign on the oven till the oven fills up";
            lblAnimate.Text += "\r\nBe sure to bake (hit the flame sign on the oven) and see that the oven door closes!";
            lblAnimate.Text += "\r\nThe oven will tell you when to expect your pizza out";
            lblAnimate.Text += "\r\nWhen the pizza is done, it is automatically added to your pre-baked but you still have to load the car!";
            lblAnimate.Text += "\r\n\r\nGETTING AROUND";
            lblAnimate.Text += "\r\nGetting around is pretty easy, when a new order comes in simply click the area highlighted in green";
            lblAnimate.Text += "\r\nThe car then goes to that spot and the amount of pizza wanted is deducted from the number in the car";
            lblAnimate.Text += "\r\nMoney is automatically added to your 'Total Sales' counter, then you wait for the next order and head out again!";
            lblAnimate.Text += "\r\n\r\nUPGRADES AND LEVELING UP";
            lblAnimate.Text += "\r\nAfter a certain goal is reached, you automatically level up and get Bonus feautures";
            lblAnimate.Text += "\r\nAt the highest level, you get access to the fastest vehicle in the game - The Bat Mobile :)";
            lblAnimate.Text += "\r\nOf course if you don't want to wait and are rich enough, you can click the 'Upgrades' button";
            lblAnimate.Text += "\r\nIt'll open up the store and you can get all you need for more efficient Pizza Delivery!";
            lblAnimate.Text += "\r\n\r\nDon't worry about remembering all this, You can always come back to it from the menu bar";
            lblAnimate.Text += "\r\nGoodLuck! and may the odds be ever in your favor! "; //should probably check if this is what the actual quote is
            pnlAnimate.Visible = true;
            
        }
        private void tmrClock_Tick(object sender, EventArgs e)
        {   int ClockMinutes;
            int c, r;
            String s;
            bool expired = false;
            ClockMinute++;
            if (ClockMinute > 59) 
            {
                ClockMinute = 0; //sets up minute tick from 0 to 59 and resets to 0 after it hits 59
                ClockHour++;
                if (ClockHour == 10) // stop game play at 10pm
                {
                    lblTime.Text = "10: 00";
                    MessageBox.Show("Congratulations! You made it through the day", "Welldone" + UserName);
                    btnExit.PerformClick();
                    return;
                }
            }
            lblTime.Text = ClockHour.ToString() + ": "; //update time label
            if (ClockMinute == 1 || ClockMinute == 10 || ClockMinute == 21 || ClockMinute == 31 || ClockMinute == 41 || ClockMinute == 51)
            { 
                lblBlinkA.Location = new Point(45, 24);
                lblBlinkA.Size = new Size(16, 32); //I added a little blinker to the clock.. to make it look real.. 
            }
            else if(ClockMinute == 2 || ClockMinute == 20 || ClockMinute == 22 ||ClockMinute == 30 || ClockMinute == 32 ||ClockMinute == 40 || ClockMinute == 42 ||ClockMinute == 50 || ClockMinute == 52 )
            {
                lblBlinkA.Location = new Point(41, 24);
            }
            else if (ClockMinute == 11)             // getting the clock to look fancy might have been the most stressful part of the project honestly
            {
                lblBlinkA.Location = new Point(51, 24);
            }
            else if (ClockMinute == 12)
            {
                lblBlinkA.Location = new Point(47, 24);
            }
            if (ClockMinute < 10)
            {
                lblTime.Text += "0"; 
            }
            lblTime.Text += ClockMinute.ToString();
            //check for late orders - check too if first is expired
            ClockMinutes = ClockMinute + 60 * ClockHour;
            if (lstOrders.Items.Count != 0)
            {

                for (int i = 0; i < lstOrders.Items.Count; i++)
                { 
                    s = lstOrders.Items[i].ToString();
                    c = ((int)s[6]) - 64;
                    r = Convert.ToInt32(s.Substring(8, 2));
                    if (i == 0 && ClockMinutes - PizzaTime[c, r] >= OrderMaxTime)
                    {
                        expired = true;
                        deliveryGrid[c, r].BackColor = Color.White;         //reset  if you miss an order
                        deliveryGrid[c, r].Text = "";
                        missedDeliveries += Pizzas[c, r];
                        Pizzas[c, r] = 0;
                    }
                    else if (ClockMinutes - PizzaTime[c, r] >= OrderLateTime) 
                    {
                        deliveryGrid[c, r].BackColor = Color.DarkRed; //shows that order is now marked as late

                    }
                }
                if (expired)
                {
                    lstOrders.Items.RemoveAt(0);
                }
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        { 
            if(btnStart.Text == "Start Game")
            {
                btnStart.Text = "Pause Game";
                btnExit.Text = "Stop Game";
                // clear grid
                for (int i = 1; i< 21; i++)
                {
                    for(int j = 1; j<21; j++)
                    {
                        deliveryGrid[i, j].BackColor = Color.White;
                        deliveryGrid[i, j].Text = "";
                        Pizzas[i, j] = 0;
                        PizzaTime[i, j] = 0;
                    }
                }
                lstOrders.Items.Clear();
                for (int i = 0; i < 12; i++)
                    pizzaInOven[i].Visible = false; // hides all the pizza
                pizzasBaking = 0; //resets the amount of pizza baking
                pizzasBakingMax = 8; //resetsAMount of pizza available;
                bakingTime = 10; //resets baking time
                PizzasInCarMax = 10; //rsets number of pizza in car
                G = A = P = Z = 0; // resets the number of cars .. GAPZ.. :)
                pizzasReady = pizzasBakingMax; 
                totalPizzasBaked = pizzasReady;
                lblBaked.Text = pizzasReady.ToString();
                pizzaInCar = 0;
                lblPizza.Text = "0";
                btnLoad.Enabled = true;
                //initialize pizza parlor and car location
                deliveryGrid[carC, carR].Image = null;
                deliveryGrid[ZcarC, ZcarR].Image = null;
                deliveryGrid[AcarR, AcarR].Image = null;            //here
                deliveryGrid[PcarR, PcarR].Image = null;
                deliveryGrid[GcarR, GcarR].Image = null;
                pizzaC = rnd.Next(2, 19);
                pizzaR = rnd.Next(2, 19);
                ZCarStartC = pizzaC; //sets location for new cars to start from
                ZCarStartR = pizzaR;
                deliveryGrid[pizzaC, pizzaR].BackColor = Color.Black; // sets up pizza parlor
                deliveryGrid[pizzaC, pizzaR].Text = "X"; //marks it with an 
                carC = pizzaC;
                carR = pizzaR;
                mileage = 0;               
                pizzaOnTime = 0;
                pizzaLate = 0;
                missedDeliveries = 0;
                totalSales = 0;
                lblSales.Text = "$0.00"; // showws how broke the player is 
                lblMessage.Text = "Car at Pizza Parlor :\r\n" + Display(carC, carR); 
                ClockHour = 4; //resets time hours
                ClockMinute = 0;//resets time minutes
                lblTime.Text = "4: 00";
                tmrClock.Enabled = true;
                tmrForAesthetics.Enabled = true; //for all things that blink on the form
                 tmrPhone.Interval = mSecPerMin * rnd.Next(1, 8); 
                 ovenGoing = tmrOven.Enabled;
                tmrOven.Enabled = false;
                tmrPhone.Enabled = true;
                tmrOvenImage.Start();
                grpOven.Enabled = pnlOven.Enabled =  grpPizza.Enabled = btnUpgrades.Enabled = true; //basically enabling everything that needs enabling
                
            }
            else if  (btnStart.Text == "Pause Game") 
            {
                btnStart.Text = "Resume Game";
                btnExit.Enabled =  tmrClock.Enabled =  tmrForAesthetics.Enabled =  tmrPhone.Enabled = false;//basically disabling everything that needs disabling
                ovenGoing = tmrOven.Enabled;
                tmrOven.Enabled = false;
                tmrOvenImage.Stop();
                carGoing = tmrCar.Enabled;
                ZcarGoing = tmrCar2.Enabled;            
                AcarGoing = tmrCar3.Enabled;
                PcarGoing = tmrCar4.Enabled;
                GcarGoing = tmrCar5.Enabled;
                tmrCar.Enabled = tmrCar2.Enabled = tmrCar3.Enabled = tmrCar4.Enabled = tmrCar5.Enabled = false; 
                // i feel like this reduces the number of lines of codes so yeah, equate everything to eachother.
                grpOven.Enabled = pnlOven.Enabled = grpPizza.Enabled = false;
                          }
            else
            {
                //Game Resumed
                btnStart.Text = "Pause Game";
                //btnStart.Enabled = true;
                btnExit.Enabled = tmrClock.Enabled = tmrForAesthetics.Enabled = tmrPhone.Enabled = true;
                tmrOven.Enabled = ovenGoing;
                tmrOvenImage.Enabled = true;
                grpOven.Enabled = true; pnlOven.Enabled = true;
                tmrCar.Enabled = carGoing;                           // here
                tmrCar2.Enabled = ZcarGoing;
                tmrCar3.Enabled = AcarGoing;
                tmrCar4.Enabled = PcarGoing;
                tmrCar5.Enabled = GcarGoing;
                grpPizza.Enabled = true;
            }
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (btnExit.Text == "Stop Game")
            {
                GameOverSound.Play(); //play sound indicating game is done
                btnExit.Text = "Exit"; //change button text
                btnStart.Text = "Start Game"; 
                tmrClock.Enabled = false;  //disable a bunch of timers
                tmrForAesthetics.Enabled = false;
                tmrOvenImage.Stop(); OV = 0;
                tmrPhone.Enabled =  tmrOven.Enabled =tmrCar.Enabled = tmrCar2.Enabled =  tmrCar3.Enabled = tmrCar4.Enabled = tmrCar5.Enabled = false;
                //disablle some more timers
                grpOven.Text = "Oven Off"; //change groupbox text
                grpOven.BackColor = Color.Blue;
                for (int i = 0; i < 12; i++)
                    pizzaInOven[i].Visible = false;
               btnAddPizza.Enabled =  btnAddNBake.Enabled = picAddNBake.Enabled =true;
               
                picAdd.Enabled =  btnBakePizza.Enabled = picBake.Enabled = true;
                grpOven.Enabled = pnlOven.Enabled =  grpPizza.Enabled =  false;
                 // bring up sales report
                Form SalesResults = new Sales_Results(ClockHour, ClockMinute, pizzaOnTime, 
                    netLatePizza, pizzaLate, netLatePizza, totalPizzasBaked, pizzaCost,       //Glitchy
                    mileage, mileageCost, missedDeliveries, CostMissedPizza);
                SalesResults.ShowDialog();

            }
            else
            {
                this.Close(); //as the code implies, it closes the form
            }
        }
        private void tmrPhone_Tick(object sender, EventArgs e)
        {
            {
                int i, j, k;
                String Order;
                PhoneSound.Play();
                if (ClockHour == 9 && ClockMinute >= 55) //stop phone at 9:55
                {
                    tmrPhone.Enabled = false; 
                    return;
                }
                do
                {
                    i = rnd.Next(1, 21);
                    j = rnd.Next(1, 21);
                    //in certain cases, pizza deliveries were at the pizza parlor, meaning you couldn't deliver at the spot
                    //because it is already marked as pizza parlor and when you get ther it simply sets you location to pizza prlor
                    //and  leaves the order spot till it times out and cleas itself( and also the parlor identifier)
                    //soo , correctional code
                    if (i == ZCarStartC && j == ZCarStartR)
                    {
                        i = rnd.Next(1, 21);
                        j = rnd.Next(1, 21);
                    }
                }
                while (Pizzas[i, j] != 0); //sets up number of pizzas to be dliered to each location an order is made
                k = rnd.Next(1, 100);
                if (k <= 29)
                {
                    Pizzas[i, j] = 1;
                  
                }
                else if (k <= 49)
                {
                    Pizzas[i, j] = 2;
                   
                }
                else if (k <= 69)
                {
                    Pizzas[i, j] = 3;
                 
                }
                else if (k <= 84)
                {
                    Pizzas[i, j] = 4;
                   
                }
                else
                {
                    Pizzas[i, j] = 5;
                   
                }
                PizzaTime[i, j] = ClockMinute + 60 * ClockHour;
                //build string listing order
                Order = lblTime.Text + " ";
                if (lblTime.Text.Length == 4)
                    Order = " " + Order;
                Order += ((char)(i + 64)).ToString() + " ";
                if (j < 10)
                    Order += " ";
                Order += j.ToString() + "->" + Pizzas[i, j].ToString() ; 
                lstOrders.Items.Add(Order);
                lstOrders.Refresh();
                LblBlinkB.Location.Offset(5, +5);
                LblBlinkB.Top +=14;
              //displays pizza request on the panel
                deliveryGrid[i, j].BackColor = Color.DarkGreen; 
                deliveryGrid[i, j].Text = Pizzas[i, j].ToString();
                tmrPhone.Interval = mSecPerMin * rnd.Next(1, 8); // sets up timer for next ring

            }
        }

        private void btnUpgrades_Click(object sender, EventArgs e)
        {//one button does multiple things, and  sooo ...
                     
            if (btnUpgrades.Text == "Return to Game")
            {
                btnUpgrades.Size = new Size(63, 214); //change button size
                btnUpgrades.Location = new Point(820, 84); //change button location
                pnlUpgrade.Visible = false;
                this.Size = new Size(905, 745);  //updates form size
                btnUpgrades.Text = "Upgrades";
                
            }
            else
            {
                this.Width = 1200; //simulates closing the store
                btnUpgrades.Text = "Return to Game";
                btnUpgrades.Size = new Size(153, 23);//change button size
                btnUpgrades.Location = new Point(960, 492);
                pnlUpgrade.Visible = true;
                btnUpgrades.BringToFront();
                pnlUpgrade.Contains(btnUpgrades);
            }
        }

        private void btnUpgrades_MouseEnter(object sender, EventArgs e)
        {
            btnUpgrades.BackColor = Color.White;   // just for looks
            btnUpgrades.ForeColor = Color.Black;
        }
        private void btnUpgrades_MouseLeave(object sender, EventArgs e)
        {
             btnUpgrades.ForeColor = Color.White;
            btnUpgrades.BackColor = Color.Black;
        }
        private void btAddPizza_Click(object sender, EventArgs e)
        { //adds pizza to oven (makes image visbile) based on how much pizza user is allowd to bake at a go
            if (pizzasBakingMax == 8)
            {
                OV++;
                pizzasBaking++;
                pizzaInOven[pizzasBaking - 1].Visible = true;
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    picAdd.Enabled = false;
                }

            }
            else if (pizzasBakingMax == 9)
            {
                OV++;
                pizzasBaking++;
                pizzaInOven[pizzasBaking - 1].Visible = true;
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    picAdd.Enabled = false;
                }
            }
            else if (pizzasBakingMax == 10)
            {
                OV++;
                pizzasBaking++;
                pizzaInOven[pizzasBaking - 1].Visible = true;
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    picAdd.Enabled = false;
                }
            }
            else if (pizzasBakingMax == 11)
            {
                OV++;
                pizzasBaking++;
                pizzaInOven[pizzasBaking - 1].Visible = true;
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    picAdd.Enabled = false;
                }
            }
            else if (pizzasBakingMax == 12)
            {
                OV++;
                pizzasBaking++;
                pizzaInOven[pizzasBaking - 1].Visible = true;
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    picAdd.Enabled = false;
                }
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            //Accidental double click
        }

        private void tmrAesthetics_Tick(object sender, EventArgs e)
        {    
            //this timer has multiple purposes since it is always running, it can be used to check and fix errors and other stuff
            //Controls everything that blinks
            BL++;
            Sign++;
            int Money;
            if (BL == 1)
            {
                picCar10.Image = picCar9.Image = Resources.Batman;   //just cause.. batmobile
              LblBlinkB.BackColor = Color.Black;
            }
             else  if (BL == 2)
            {
                lblBlinkA.ForeColor = Color.Blue;       
                LblBlinkB.BackColor = Color.Green;
               
            }
            else if (BL == 3)
            {
                LblBlinkB.BackColor = Color.Black;
               
            }
            else if (BL == 4)
            {
                picCar9.Image = Resources.GCarH;
                picCar10.Image = Resources.GCarV;
                lblBlinkA.ForeColor = Color.Gray;
                LblBlinkB.BackColor = Color.Green;
                BL = 0;

            }
                
            if (lstOrders.Items.Count == 1 )
            {
                LblBlinkB.Location = new Point(598, 104); 
            }
          else if(lstOrders.Items.Count ==0)
            {
                LblBlinkB.Location = new Point(518, 106);
                
            }
             if(LblBlinkB.Bounds.IntersectsWith(lstOrders.Bounds) && lstOrders.Items.Count >= 6) // this is supposed to keep the blinking text input thingy from passing the edge of the screen
            {
                LblBlinkB.Location = new Point(598, 174);
            }
           if (chkInstantBake.Checked)

            {
                if (!Paid)
                {
                    if (totalSales >= 300)
                    {
                        Money = 300;  //Deduct 300 everytime you enable autobake
                        totalSales = totalSales - Money;
                        lblSales.Text = "$" + totalSales.ToString();
                        Paid = true;
                        TimeOut = 0;
                    }
                    else
                {
                    chkInstantBake.Checked = false;
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
                }
               

                if (!tmrOven.Enabled && bakingMinutesLeft == 0)
                {
                    if (totalSales >= 50 && Paid)
                    {
                         Money = 50; // show -50 animation
                        totalSales = totalSales - Money; //Deduct 50 everytime Oven restarts itself (after 300 isi deducted)
                        lblSales.Text = "$" + totalSales.ToString();
                        btnAddNBake.PerformClick();
                        TimeOut++;

                    }
                    else
                    {
                        chkInstantBake.Checked = false;
                        MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                    }
                   
                    if (TimeOut == 6)
                {
                    TimeOut = 0;
                    chkInstantBake.Checked = false;
                MessageBox.Show("Oven Has been running for too long, Instant Bake has been disabled", "Time Out");
                 }
                
                }
               
                  }
          
        }

        private void tmrLevelUpAnimate_Tick(object sender, EventArgs e)
        { //Level up animation 
            LU++;
            switch(LU)
            {
                case 1:
                    picLevelUpT.Image = Properties.Resources.Level_UP1;
                    picLevelUpA.Image = Properties.Resources.frame_0_delay_0_07s;
                    break;

                case 2:
                    picLevelUpT.Image = Properties.Resources.Level_UP2;
                    picLevelUpA.Image = Properties.Resources.frame_1_delay_0_07s;
                    break;

                case 3:
                    picLevelUpT.Image = Properties.Resources.Level_UP3;
                    picLevelUpA.Image = Properties.Resources.frame_2_delay_0_07s;
                    break;

                case 4:
                    picLevelUpT.Image = Properties.Resources.Level_UP1;
                    picLevelUpA.Image = Properties.Resources.frame_3_delay_0_07s;
                    break;

                case 5:
                    picLevelUpT.Image = Properties.Resources.Level_UP2;
                    picLevelUpA.Image = Properties.Resources.frame_4_delay_0_07s;
                    break;

                case 6:
                    picLevelUpT.Image = Properties.Resources.Level_UP3;
                    picLevelUpA.Image = Properties.Resources.frame_5_delay_0_07s;
                    break;

                case 7:
                    picLevelUpT.Image = Properties.Resources.Level_UP1;
                    picLevelUpA.Image = Properties.Resources.frame_6_delay_0_07s;
                    break;

                case 8:
                    picLevelUpT.Image = Properties.Resources.Level_UP2;
                    picLevelUpA.Image = Properties.Resources.frame_7_delay_0_07s;
                    break;

                case 9:
                    picLevelUpT.Image = Properties.Resources.Level_UP3;
                    picLevelUpA.Image = Properties.Resources.frame_8_delay_0_06s;
                    break;

                case 10:
                    picLevelUpT.Image = Properties.Resources.Level_UP1;
                    picLevelUpA.Image = Properties.Resources.frame_9_delay_0_05s;
                    break;

                case 11:
                    picLevelUpT.Image = Properties.Resources.Level_UP2;
                    picLevelUpA.Image = Properties.Resources.frame_10_delay_0_04s;
                    break;

                case 12:
                    picLevelUpT.Image = Properties.Resources.Level_UP3;
                    picLevelUpA.Image = Properties.Resources.frame_11_delay_0_5s;
                    break;

                case 13:
                    picLevelUpT.Image = Properties.Resources.Level_UP1;
                    picLevelUpA.Image = Properties.Resources.frame_12_delay_0_05s;
                    break;

                case 14:
                    picLevelUpT.Image = Properties.Resources.Level_UP2;
                    picLevelUpA.Image = Properties.Resources.frame_13_delay_0_05s;
                    break;

                case 15:
                    picLevelUpT.Image = Properties.Resources.Level_UP3;
                    picLevelUpA.Image = Properties.Resources.frame_14_delay_0_07s;
                    LU = 0;
                    picLevelUpA.Visible = false;
                    picLevelUpT.Visible = false;
                    btnStart.PerformClick();
                    tmrLevelUpAnimate.Stop();
                    break;

                

            }
        }

        

        private void btnBakePizza_Click(object sender, EventArgs e)
        {
            OV = 0;
            {
                int hOut, mOut;
                if (pizzasBaking == 0)
                    return;
                grpOven.BackColor = Color.Red;
                btnAddPizza.Enabled = picAdd.Enabled = btnAddNBake.Enabled = picAddNBake.Enabled =  btnBakePizza.Enabled = picBake.Enabled = false;            
               hOut = ClockHour;
                mOut = ClockMinute + bakingTime;
                if (mOut > 59)
                {
                    mOut -= 60;
                    hOut++;
                }
                if (pizzasBaking == 1)
                {
                    grpOven.Text =  lblOvenScreen.Text = "Pizza Out At ";
                }
                else
                grpOven.Text = lblOvenScreen.Text = "Pizza Out At ";
                grpOven.Text += hOut.ToString() + ":";  lblOvenScreen.Text += hOut.ToString() + ":"; //probably best not to combine these two
                if (mOut < 10)
                {
                    grpOven.Text += "0"; lblOvenScreen.Text += "0"; //and these
                }
                grpOven.Text += mOut.ToString(); lblOvenScreen.Text += mOut.ToString();
                bakingMinutesLeft = bakingTime;
                tmrOven.Enabled = true;

            }
        }
        private void tmrOven_Tick(object sender, EventArgs e)
        {
            if (bakingMinutesLeft != 0)
            {
                bakingMinutesLeft--;
            }
            else
            {
                DingSound.Play(); //play sound when oven is done
                tmrOven.Enabled = false; //disable timer
                pizzasReady += pizzasBaking; // update number of pizaa ready
                totalPizzasBaked += pizzasBaking;
                if (pizzasReady > PizzaReadyMax + 30)
                    pizzasReady = PizzaReadyMax + 30;
                lblBaked.Text = pizzasReady.ToString();
                grpOven.Text = "Oven Off";
                grpOven.BackColor = Color.Blue;
                for (int i = 0; i < 12; i++)
                    pizzaInOven[i].Visible = false;
                pizzasBaking = 0;
                btnAddPizza.Enabled = picAdd.Enabled = btnAddNBake.Enabled = picAddNBake.Enabled = btnBakePizza.Enabled =picBake.Enabled = true; 
            }
        }

      

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int Valuez;
            if (pizzasReady == 0)
                return;
            if (pizzaInCar >= PizzasInCarMax)
            {
                Valuez = pizzaInCar - PizzasInCarMax;
                pizzaInCar = PizzasInCarMax;
                
                pizzasReady += Valuez;
            }
            else if ((pizzaInCar + pizzasReady) > PizzasInCarMax)
            {
                Valuez = (pizzaInCar + pizzasReady) - PizzasInCarMax;
                pizzaInCar = PizzasInCarMax;
                pizzasReady = 0;
                pizzasReady += Valuez;
            }

            if (pizzasReady >= PizzasInCarMax)
            {
                pizzaInCar += PizzasInCarMax;
                pizzasReady -= PizzasInCarMax;
                 if (pizzaInCar >= PizzasInCarMax)
                {
                    Valuez = pizzaInCar - PizzasInCarMax;
                    pizzaInCar = PizzasInCarMax;
                     pizzasReady += Valuez;
                }
               else if((pizzaInCar + pizzasReady) > PizzasInCarMax)
                {
                    Valuez = (pizzaInCar + pizzasReady) - PizzasInCarMax;
                    pizzaInCar = PizzasInCarMax;
                    pizzasReady += Valuez;
                }
            }
            else
            {
                pizzaInCar += pizzasReady;
                pizzasReady = 0;
            }
            lblBaked.Text = pizzasReady.ToString();
            lblPizza.Text = pizzaInCar.ToString();
            btnLoad.Enabled = false;
        }
        private String Display(int c, int r)
        {
            return (((char)(c + 64)).ToString() + " " + r.ToString());
        }
       
        private void DeliveryGrid_Click(object sender, EventArgs e)
        {
            Label gridClicked;
            if (!tmrCar.Enabled && grpPizza.Enabled && pizzaInCar == 0)
            {
                gridClicked = (Label)sender;
                deliveryR = ZCarStartR;  // bug proofing, if there is nothing in the car, go back to parlor
                deliveryC = ZCarStartC;
                //deltaC = ZCarStartC;         
                //deltaR = ZCarStartR;
                deltaC = deliveryC - carC;
                deltaR = deliveryR - carR;
                

                lblMessage.Text = "Car going to Pizza Parlor\r\n" + Display(deliveryC, deliveryR);
                lblMessage.Text += "\r\nNo Pizza Left in car!";
                tmrCar.Enabled = true;
            }
            else  if (!tmrCar.Enabled && grpPizza.Enabled && pizzaInCar != 0)
            {
                gridClicked = (Label)sender;
                deliveryR = Convert.ToInt32(gridClicked.Tag.ToString().Substring(2, 2));  
                deliveryC = Convert.ToInt32(gridClicked.Tag.ToString().Substring(0, 2)); 
                deltaC = deliveryC - carC;
                deltaR = deliveryR - carR;
               
                if (deltaC == 0 && deltaR == 0)
                    return;
               
                lblMessage.Text = "Car going to :\r\n" + Display(deliveryC, deliveryR);
                tmrCar.Enabled = true;
               

            }
            else if (!tmrCar2.Enabled && tmrCar.Enabled && grpPizza.Enabled && pizzaInCar != 0)
            {
                gridClicked = (Label)sender;
                ZdeliveryR = Convert.ToInt32(gridClicked.Tag.ToString().Substring(2, 2));  //error
                ZdeliveryC = Convert.ToInt32(gridClicked.Tag.ToString().Substring(0, 2));
                ZdeltaC = ZdeliveryC - ZcarC;
                ZdeltaR = ZdeliveryR - ZcarR;

              if (ZdeltaC == 0 && ZdeltaR == 0)
                    return;
                lblMessage.Text = "Second Car going to :\r\n" + Display(ZdeliveryC, ZdeliveryR);
                if (Z >= 15) //Z = 15
                {
                    tmrCar2.Enabled = true;
                }

            }
            else if (!tmrCar3.Enabled && tmrCar2.Enabled && tmrCar.Enabled && grpPizza.Enabled && pizzaInCar != 0)
            {
                gridClicked = (Label)sender;
                AdeliveryR = Convert.ToInt32(gridClicked.Tag.ToString().Substring(2, 2));  //error
                AdeliveryC = Convert.ToInt32(gridClicked.Tag.ToString().Substring(0, 2));
                AdeltaC = AdeliveryC - AcarC;
                AdeltaR = AdeliveryR - AcarR;

                if (AdeltaC == 0 && AdeltaR == 0)
                    return;
                lblMessage.Text = "Third Car going to :\r\n" + Display(AdeliveryC, AdeliveryR);
                if ( Z >= 30) //Z = 30
                {
                    tmrCar3.Enabled = true;
                }

            }
            else if (!tmrCar4.Enabled && tmrCar3.Enabled && tmrCar2.Enabled && tmrCar.Enabled && grpPizza.Enabled && pizzaInCar != 0)
            {
                gridClicked = (Label)sender;
                PdeliveryR = Convert.ToInt32(gridClicked.Tag.ToString().Substring(2, 2));  //error
                PdeliveryC = Convert.ToInt32(gridClicked.Tag.ToString().Substring(0, 2));
                PdeltaC = PdeliveryC - PcarC;
                PdeltaR = PdeliveryR - PcarR;

                if (PdeltaC == 0 && PdeltaR == 0)
                    return;
                lblMessage.Text = "Fourth Car going to :\r\n" + Display(PdeliveryC, PdeliveryR);
                if (Z >= 45) 
                {
                    tmrCar4.Enabled = true;
                }

            }

            else if (!tmrCar5.Enabled && tmrCar4.Enabled && tmrCar3.Enabled && tmrCar2.Enabled && tmrCar.Enabled && grpPizza.Enabled && pizzaInCar != 0)
            {
                gridClicked = (Label)sender;
                GdeliveryR = Convert.ToInt32(gridClicked.Tag.ToString().Substring(2, 2));  //error
                GdeliveryC = Convert.ToInt32(gridClicked.Tag.ToString().Substring(0, 2));
                GdeltaC = GdeliveryC - GcarC;
                GdeltaR = GdeliveryR - GcarR;

                if (GdeltaC == 0 && GdeltaR == 0)
                    return;
                lblMessage.Text = "Bat Mobile going to :\r\n" + Display(GdeliveryC, GdeliveryR);
                if (Z >= 60) 
                {
                    tmrCar5.Enabled = true;
                }

            }
        }

        private void tmrOvenImage_Tick(object sender, EventArgs e)
        {
            switch (OV)
            {
                case 1:
                    picOven.Image = Properties.Resources.Frame1;
                    break;
                case 2:
                    picOven.Image = Properties.Resources.Frame2;
                    break;
                case 3:
                    picOven.Image = Properties.Resources.Frame3;
                    break;
                case 4:
                    picOven.Image = Properties.Resources.Frame4;
                    break;
                case 5:
                    picOven.Image = Properties.Resources.Frame5;
                    break;
                case 6:
                    picOven.Image = Properties.Resources.Frame6;
                    break;
                case 7:
                    picOven.Image = Properties.Resources.Frame7;
                    break;
                case 8:
                    picOven.Image = Properties.Resources.Frame8;
                    break;
                case 9:
                    picOven.Image = Properties.Resources.Frame9;
                    break;
                case 10:
                    picOven.Image = Properties.Resources.Frame10;
                    break;
                case 11:
                    picOven.Image = Properties.Resources.Frame11;
                    break;
                case 12:
                    picOven.Image = Properties.Resources.Frame12;
                    break;
            }
            if (tmrOven.Enabled)
            {
                picOven.Image = Properties.Resources.ClosedPizzaOven;
                lblOvenScreen.Visible = true;
                picAdd.Visible = false;
                picAddNBake.Visible = false;
                picBake.Visible = false;
            }
            else if (!tmrOven.Enabled && OV ==0)
            {
                picOven.Image = Properties.Resources.PizzzaOven;
                lblOvenScreen.Visible = false;
                picAddNBake.Visible = true;
                picAdd.Visible = true;
                picBake.Visible = true;

            }
        }

        private void hungryForRealPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Launch browser to Search for closest pizza parlor...
            System.Diagnostics.Process.Start("https://www.google.ca/maps/search/pizza+stores+near+me/");
        }

        private void dominosToolStripMenuItem_Click(object sender, EventArgs e)
        { //Launch to Dominos Site
            System.Diagnostics.Process.Start("https://order.dominos.ca/en/pages/order/#/locations/search/");
        }

        private void pizzaPizzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Launch to Pizza Pizza Site
            System.Diagnostics.Process.Start("https://order.pizzapizza.ca/PhoenixWEB/order/#home");
        }

        private void btAddNBake_Click(object sender, EventArgs e)
        {
            
            if (pizzasBakingMax == 8)
            {
              
                for (int i = 0; i < pizzasBakingMax; i++)
                {     OV++;
                pizzasBaking++;
                     pizzaInOven[i].Visible = true;
                }
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    btnAddNBake.Enabled = false;  picAddNBake.Enabled = false;
                    picAdd.Enabled = false;
                    btnBakePizza.PerformClick();
                }

            }
            else if (pizzasBakingMax == 9)
            {
               
                for (int i = 0; i < pizzasBakingMax; i++)
                { OV++;
                pizzasBaking++;
                    pizzaInOven[i].Visible = true;
                }
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddNBake.Enabled = false; picAddNBake.Enabled = false;
                    btnAddPizza.Enabled = false;
                    btnBakePizza.PerformClick();

                    picAdd.Enabled = false;
                }
            }
            else if (pizzasBakingMax == 10)
            {
              
                for (int i = 0; i < pizzasBakingMax; i++)
                {  OV++;
                pizzasBaking++;
                    pizzaInOven[i].Visible = true;
                }
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    btnAddNBake.Enabled = false; picAddNBake.Enabled = false;
                    btnBakePizza.PerformClick();
                    picAdd.Enabled = false;
                }
            }
            else if (pizzasBakingMax == 11)
            {
               
               
                for (int i = 0; i < pizzasBakingMax; i++)
                { pizzasBaking++; OV++;
                    pizzaInOven[i].Visible = true;
                }
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    btnAddNBake.Enabled = false; picAddNBake.Enabled = false;
                    btnBakePizza.PerformClick();
                    picAdd.Enabled = false;
                }
            }
            else if (pizzasBakingMax == 12)
            {
               
                for (int i = 0; i < pizzasBakingMax; i++)
                { pizzasBaking++;
                OV++;
                    pizzaInOven[i].Visible = true;
                }
                if (pizzasBaking == pizzasBakingMax)
                {
                    btnAddPizza.Enabled = false;
                    btnBakePizza.PerformClick();
                    btnAddNBake.Enabled = false; picAddNBake.Enabled = false;
                    picAdd.Enabled = false;
                }
            }
        }

        private void chkInstantBake_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInstantBake.Checked)
            {
                if (totalSales >= 50)
                {
                   //all this is handled under a timer, this is just big proofing
                }
                else
                {   //chkInstantBake.Checked = false;
                //    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                    
                }
            }
        }

        private void tmrAnimate_Tick(object sender, EventArgs e)
        {
            BL++;
            if (!EnterPressed)
            {
                switch (BL)
                {
                    case 1:
                        lblBlinkC.BackColor = Color.Black;
                        break;
                    case 3:
                        lblBlinkC.BackColor = Color.Green;
                        BL = 0;
                        break;

                }
            }
            if (EnterPressed)
            {
                lblBlinkC.Size = new Size(4, 4);
                lblBlinkD.Visible = true;
                lblBlinkE.Visible = true;
                switch (BL)
                {
                    case 1:
                        lblBlinkC.BackColor = Color.Black;
                        lblBlinkD.BackColor = Color.Black;
                        lblBlinkD.BackColor = Color.Black;
                        break;
                    case 2:
                        lblBlinkC.BackColor = Color.Green;
                        break;

                    case 3:
                        lblBlinkD.BackColor = Color.Green;
                        break;
                    case 4:
                        lblBlinkE.BackColor = Color.Green;
                        BL = 0;
                        TimeOut++;

                        break;

                }
                if (TimeOut == 3)
                {
                    SomeInteger++;
                    lblBlinkC.Visible = false;
                    lblBlinkD.Visible = false;
                    lblBlinkE.Visible = false;

                    if (SomeInteger == 1)
                    {
                        lblPressEnter.Text = "Loading files";
                        lblPressEnter.Text += "\r\n " + label1.ToString(); ; // this is all jargon to make it look more legit, lol
                        lblPressEnter.Text += "\r\n " + picAdd.ToString();
                        lblPressEnter.Text += "\r\n" + pnlAnimate.ToString();
                    }
                    else if (SomeInteger == 2)
                    {
                        lblPressEnter.Text += "\r\n" + pnlGrid.ToString();
                        lblPressEnter.Text += "\r\n" + lblPressEnter.ToString();
                        lblPressEnter.Text += "\r\n" + mnuMenu.ToString();
                        lblPressEnter.Text += "\r\n" + carR;
                    }
                    else if (SomeInteger == 3)
                    {
                        lblPressEnter.Text += "\r\n" + ZcarGoing;
                        lblPressEnter.Text += "\r\n" + GameOverSound;
                        lblPressEnter.Text += "\r\n" + rnd;
                        lblPressEnter.Text += "\r\n" + P;
                        lblPressEnter.Text += "\r\n " + label4.ToString(); ;
                        lblPressEnter.Text += "\r\n " + picBake.ToString();
                        lblPressEnter.Text += "\r\n" + pnlOven.ToString();
                        lblPressEnter.Text += "\r\n" + picCar10.ToString();
                        lblPressEnter.Text += "\r\n All Files added";
                        lblBlinkC.Top = lblPressEnter.Bottom;
                        //  SomeInteger += 1;
                    }
                    else if (SomeInteger == 4)
                    {
                        SomeInteger = 0;
                        lblPressEnter.Visible = false;
                        EnterPressed = false;
                        FakeStartUpDone = true;
                    }
                }
            }
            if (FakeStartUpDone)
            {
                Animation++;
                switch (BL)
                {
                    case 1:
                        lblBlinkC.BackColor = Color.Black;
                        break;


                    case 3:
                        lblBlinkC.BackColor = Color.Green; BL = 0;
                        break;
                }
                                      
                switch (Animation)
                {
                    case 1:
                        KeyTapA.Play();
                        break;
                    case 3:
                        lblAnimate.Text = "H";
                       lblBlinkC.Visible = true;
                        lblBlinkC.Location = new Point(175, 407);
                        lblBlinkC.Size = new Size(25, 5);
                        break;
                    case 4:
                        lblAnimate.Text += "A";
                        lblBlinkC.Left += 100;
                        

                        break;
                    case 5:
                        lblAnimate.Text += "C";
                        lblBlinkC.Left += 100;
                        break;
                    case 6:
                        lblBlinkC.Left += 100;
                        lblAnimate.Text += "K";
                        break;
                    case 7:
                        lblBlinkC.Left += 100;
                        lblAnimate.Text += "I";

                        break;
                    case 8:
                        lblBlinkC.Left += 100;
                        lblAnimate.Text += "N";
                        break;
                    case 9:
                        KeyTapA.Stop();
                        lblBlinkC.Left += 50;
                        lblAnimate.Text += "G";
                        break;
                   
                    case 2:case 11:case 12:case 13:case 14:
                    // Skip a few cases
                    case 10: case 17:                       
                        break;
                    case 20:
                        BackSpace.Play();
                        break;
                    case 21:
                        // if only i could use  lblAnimate.Text -= "G";
                        lblAnimate.Text = "HACKIN";
                        lblBlinkC.Left -= 50;
                        break;
                    case 22:
                        BackSpace.Play();
                        lblAnimate.Text = "HACKI";
                        lblBlinkC.Left -= 100;
                        
                        break;
                    case 23:
                        BackSpace.Play();
                        lblAnimate.Text = "HACK";
                        lblBlinkC.Left -= 100;
                        
                        break;
                    case 24:
                        lblAnimate.Text = "HAC";
                        lblBlinkC.Left -= 100;
                        break;
                    case 25:
                        lblAnimate.Text = "HA";
                        lblBlinkC.Left -= 100;
                        break;
                    case 26:
                        BackSpace.Play();
                        lblAnimate.Text = "H";
                        lblBlinkC.Left -= 100;
                        break;
                    case 27:
                        lblAnimate.Text = "";
                        lblBlinkC.Location = new Point(175, 407);

                        break;
                    //Skip  few cases, make them wait
                    case 34:
                        KeyTapA.Play();
                        lblAnimate.Text += "A";
                        lblBlinkC.Left += 100;

                        break;
                    case 35:
                        lblAnimate.Text += "K";
                        lblBlinkC.Left += 100;

                        break;
                    case 36:
                        lblAnimate.Text += "I";
                        lblBlinkC.Left += 100;

                        break;
                    case 37:
                        lblAnimate.Text += "N";
                        lblBlinkC.Left += 100;

                        break;
                    case 38:
                        KeyTapA.Stop();
                        break;
                    //Skip a few cases, make them wait some more 
                    case 43:
                        BackSpace.Play();
                        lblAnimate.Text += "  :-)";
                        lblBlinkC.Left += 100;

                        FontSize = 25.0F;
                        myFont = new Font(fonts.Families[0], FontSize);
                        lblCredits.Font = myFont;
                        lblTime.Font = myFont;
                        lblBlinkA.Font = myFont;
                        lblSales.Font = myFont; lblOvenScreen.Font = myFont;
                        break;
                    case 48:
                        BackSpace.Play();
                        lblCredits.Text = "Original";
                        break;
                    case 50:
                        lblCredits.Text += " Code";
                        break;
                    case 51:
                        lblCredits.Text += " By ";
                        break;
                    case 52:
                        lblCredits.Text += "Mr Sully";
                        break;

                    case 72:
                        
                        lblCredits.Visible = lblAnimate.Visible = lblBlinkC.Visible = false; //didn't think it would work, but it does 
                        lblAnimate.Font = new Font(fonts3.Families[0], 75.0F);
                        tmrAnimate.Stop();
                        tmrAnimate2.Start();
                        pnlAnimate.Size = this.Size;
                        break;
                }


            }
        }

        private void frmPizzaDelivery_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode != Keys.Enter)
            //{
            //    txtUser.Text += e.KeyCode;
            //}
            //else if
          
           if (e.KeyCode == Keys.ControlKey && UserName != null)
            {
               
                SomeInteger = 999;

            }
            else if (e.KeyCode == Keys.Enter && !EnterPressed)
            {
                lblPressEnter.Text = "Running";
                EnterPressed = true;
               
            }
        }

        private void frmPizzaDelivery_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void pnlAnimate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrAnimate2_Tick(object sender, EventArgs e)
        {
            SomeInteger++;
            switch(SomeInteger)
            {
                case 1:
                    lblAnimate.ForeColor = Color.Red;
                    lblAnimate.Location =lblCredits.Location = new Point(44, 269);
                   
                    break;
                case 2:
                     NeonA.Play();
                    lblAnimate.Text = "Pizza";
                    lblAnimate.Visible = true;
                    break;
                case 3:
                    lblAnimate.ForeColor = Color.Black;
                    break;
                case 4 :
                    lblAnimate.Text += " Delivery";
                    break;
                case 6:
                    lblAnimate.ForeColor = Color.Red;
                    break;
                
                case 10:
                   
                    lblAnimate.Text = "Pizza Delivery";
                    break;
                    case 12:
                    NeonB.Play();
                    lblAnimate.Text = "      Delivery";
                    break;
               
                case 14:
                   
                    lblAnimate.Text = "Pizza";
                   
                    break;
               
                case 16:
                    lblAnimate.Text = "Pizza Delivery";
                    NeonC.Play();
                    break;
                case 20:
                    lblAnimate.Font = new Font(fonts.Families[0], 25.0F);
                    lblAnimate.Text = "Choose Username and tap enter when you're done ";
                    tmrInput.Start();
                    UserName = txtUser.Text = null;
                    txtUser.Focus();
                    lblAnimate.Text += UserName;
                    txtUser.Font = new Font(fonts.Families[0], 25.0F);
                    break;
                case 1000:
                    tmrInput.Stop();
                    lblBlinkC.Visible = false;
                    lblAnimate.Text = lblCredits.Text =null;
                    tmrAnimate.Enabled =  tmrAnimate2.Enabled = false;
                     BL = 0;
                    SomeInteger = 0;
                    Instructions();
                    break;
            }
        }

        private void tmrInput_Tick(object sender, EventArgs e)
        {

            UserName = txtUser.Text;
            btnBegin.Font = CommandPromptFont;
            lblAnimate.Text = "Choose Username (tap Ctrl key when done) : ";
            if (UserName != "")
            {
                lblAnimate.Text = "Choose Username : " + UserName;
            }
           if (UserName == "Akin The Hacker" )
            {
                UserName = "Administrator";
                lblAnimate.Text = "Choose Username : " + UserName;
                tmrInput.Stop();
            }
           else if (UserName == "Administrator")
                {
                    UserName = "Liar"; // don't try to play tricks, lol
                lblAnimate.Text = "Choose Username : " + UserName;
                 tmrInput.Stop();
                }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            UserName = txtUser.Text;
            lblAnimate.Text += UserName;
        }

        private void instructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instructions();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            //start here
            pnlAnimate.Visible = false;
            tmrAnimate.Enabled = tmrAnimate2.Enabled = false;
        }

        private void btnBegin_MouseEnter(object sender, EventArgs e)
        {
            btnBegin.BackColor = Color.White;
            btnBegin.ForeColor = Color.Red;
        }

        private void btnBegin_MouseLeave(object sender, EventArgs e)
        {
            btnBegin.ForeColor = Color.White;
            btnBegin.BackColor = Color.Red;
        }

        private void instructionsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Instructions();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UPGRADED by Akin, Original Code by Mr Sullivan", "About"); //this was supposed to do alot more, but time did not permit
        }

        private void tmrCar_Tick(object sender, EventArgs e)
        {
            Image carImage;
            int i, c, r;
            String s;
            deliveryGrid[carC, carR].Image = null;
            //Move horizontally first
            if(deltaC !=0)
            {
                mileage++;
                carImage = picCar1.Image;
                carC += Math.Sign(deltaC);
                deltaC = deliveryC - carC;
            }
            else
            {
                mileage++;
                carImage = picCar2.Image;
                carR += Math.Sign(deltaR);
                deltaR = deliveryR - carR;
            }
             
            deliveryGrid[carC, carR].Image = carImage;
            if (carC == deliveryC && carR == deliveryR)
            {
                BeepSound.Play();
                tmrCar.Enabled = false;
                if (carC == pizzaC && carR == pizzaR)
                {
                    lblMessage.Text = "Car at Pizza Parlor:\r\n" + Display(carC, carR);
                    deliveryGrid[carC, carR].Image = null;

                    //pizzaInCar = 0;
                    //lblPizza.Text = "0";
                    btnLoad.Enabled = true;
                }
                else
                {
                    lblMessage.Text = "Car at : " + Display(carC, carR);
                    //check delivery status
                    if (Pizzas[deliveryC, deliveryR] == 0)
                    {
                        lblMessage.BackColor = Color.Red;
                        lblMessage.Text += "\r\nNo Pizza Wanted";
                        tmrQuickFlash.Start();
                    }
                    else
                    {
                        if (Pizzas[deliveryC, deliveryR] > pizzaInCar)
                        {
                            lblMessage.BackColor = Color.Red;
                         lblMessage.Text += "\r\nNot Enough Pizzas";
                            tmrQuickFlash.Start();

                        }
                        else
                        {
                            lblMessage.BackColor = Color.Green;
                            lblMessage.Text += "\r\nDelivered " + Pizzas[deliveryC, deliveryR].ToString() + " Pizza";
                            tmrQuickFlash.Start();
                            Z++; lblZ.Text = Z.ToString();
                            A++; lblA.Text = A.ToString();
                            P++; lblP.Text = P.ToString();
                            
                            if (Pizzas[deliveryC, deliveryR] > 1)
                                lblMessage.Text += "s";
                            //check if delivery person is on time
                            if ((ClockMinute + 60 *ClockHour)- PizzaTime[deliveryC,deliveryR] <= OrderLateTime)
                            {
                                lblMessage.Text += ": On- Time";
                                totalSales += Pizzas[deliveryC, deliveryR] * netsoldPizza;
                                if (UserName == "Administrator")
                                {
                                    totalSales = 200000; // quick feauture to let me test stuff without having to play the entire game
                                }
                                pizzaOnTime += Pizzas[deliveryC, deliveryR];
                            }
                            else
                            {
                                lblMessage.Text += " Late!";
                                totalSales += Pizzas[deliveryC, deliveryR] * netLatePizza;
                                pizzaLate += Pizzas[deliveryC, deliveryR];
                            }
                            lblSales.Text = "$" + totalSales.ToString();
                            pizzaInCar -= Pizzas[deliveryC, deliveryR];
                            lblPizza.Text = pizzaInCar.ToString();
                            Pizzas[deliveryC, deliveryR] = 0;
                            deliveryGrid[deliveryC, deliveryR].BackColor = Color.White;
                            deliveryGrid[deliveryC, deliveryR].Text = "";
                            //remove from list
                            for (i = 0; i < lstOrders.Items.Count; i++)
                            {
                                s = lstOrders.Items[i].ToString();
                                c = ((int)s[6]) - 64;
                                r = Convert.ToInt32(s.Substring(8, 2));
                                if (c == deliveryC && r == deliveryR)
                                    break;

                            }
                            lstOrders.Items.RemoveAt(i);
                            LblBlinkB.Top -= 14;
                        }
                    }
                }
            }
        }

      
        private void tmrQuickFlash_Tick(object sender, EventArgs e)
        {
            QuickFlash++;
            if (QuickFlash == 5)
            {
                QuickFlash = 0;
                tmrQuickFlash.Stop();
                lblMessage.BackColor = Color.Khaki;
            }
        }

      

        private void tmrLevelUp_Tick(object sender, EventArgs e)
        {
            lblA.Text = deltaC.ToString();
            if (Z == 15) // Z = 15
            {
                this.BackColor = Color.Red;
                deliveryGrid[ZcarC, ZcarR].Image = null;
                ZcarC = ZCarStartC;
                ZcarR = ZCarStartR;
                if (picLevelUpA.Visible == false && Level!= 2)
                {
                    Level += 1;
                    picLevelUpA.Visible = true;
                    picLevelUpT.Visible = true;
                    btnStart.PerformClick();
                    tmrLevelUpAnimate.Start();
                }
                
            }

         else   if (Z == 30) //Z = 30
            { this.BackColor = Color.Blue;
                deliveryGrid[AcarC, AcarR].Image = null;
                AcarC = ZCarStartC;
                AcarR = ZCarStartR;
                if (picLevelUpA.Visible == false && Level != 4)
                {
                    Level += 1;
                    picLevelUpA.Visible = true;
                    picLevelUpT.Visible = true;
                    btnStart.PerformClick();
                    tmrLevelUpAnimate.Start();
                }

            }
            else if (Z == 45) 
            {
                this.BackColor = Color.Purple;
                deliveryGrid[PcarC, PcarR].Image = null;
                PcarC = ZCarStartC;
                PcarR = ZCarStartR;
                if (picLevelUpA.Visible == false && Level != 6)
                {
                    Level += 1;
                    picLevelUpA.Visible = true;
                    picLevelUpT.Visible = true;
                    btnStart.PerformClick();
                    tmrLevelUpAnimate.Start();
                }

            }
            else if (Z == 60) 
            {
                this.BackColor = Color.Gray;
                deliveryGrid[GcarC, GcarR].Image = null;
                GcarC = ZCarStartC;
                GcarR = ZCarStartR;
                if (picLevelUpA.Visible == false && Level != 8)
                {
                    Level += 1;
                    picLevelUpA.Visible = true;
                    picLevelUpT.Visible = true;
                    btnStart.PerformClick();
                    tmrLevelUpAnimate.Start();
                }

            }

        }

        private void mnuMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       

        private void tmrCar2_Tick(object sender, EventArgs e)
        {
            Image carImage;
            int i, c, r;
            String s;
            deliveryGrid[ZcarC, ZcarR].Image = null;
            //Move horizontally first
            if (ZdeltaC != 0)
            {
                mileage++;
                carImage = picCar3.Image;
                ZcarC += Math.Sign(ZdeltaC);
                ZdeltaC = ZdeliveryC - ZcarC;
            }
            else
            {
                mileage++;
                carImage = picCar4.Image;
                ZcarR += Math.Sign(ZdeltaR);
                ZdeltaR = ZdeliveryR - ZcarR;
            }
            deliveryGrid[ZcarC, ZcarR].Image = carImage;
            if (ZcarC == ZdeliveryC && ZcarR == ZdeliveryR)
            {
                BeepSound.Play();
                tmrCar2.Enabled = false;
                if (ZcarC == pizzaC && ZcarR == pizzaR)
                {
                    lblMessage.Text = "Car at Pizza Parlor:\r\n" + Display(ZcarC, ZcarR);
                    deliveryGrid[ZcarC, ZcarR].Image = null;

                    //pizzaInCar = 0;
                    //lblPizza.Text = "0";
                    btnLoad.Enabled = true;
                }
                else
                {
                    lblMessage.Text = "Car at : " + Display(ZcarC, ZcarR);
                    //check delivery status
                    if (Pizzas[ZdeliveryC, ZdeliveryR] == 0)
                    {
                        lblMessage.BackColor = Color.Red;
                        lblMessage.Text += "\r\nNo Pizza Wanted";
                        tmrQuickFlash.Start();
                    }
                    else
                    {
                        if (Pizzas[ZdeliveryC, ZdeliveryR] > pizzaInCar)
                        {
                            lblMessage.BackColor = Color.Red;
                            lblMessage.Text += "\r\nNot Enough Pizzas";
                            tmrQuickFlash.Start();

                        }
                        else
                        {
                            lblMessage.BackColor = Color.Green;
                            lblMessage.Text += "\r\nDelivered" + Pizzas[ZdeliveryC, ZdeliveryR].ToString() + " Pizza";
                            tmrQuickFlash.Start();
                            Z++; lblZ.Text = Z.ToString();
                            A++; lblA.Text = A.ToString();
                            P++; lblP.Text = P.ToString();

                            if (Pizzas[ZdeliveryC, ZdeliveryR] > 1)
                                lblMessage.Text += "s";
                            //check if delivery person is on time
                            if ((ClockMinute + 60 * ClockHour) - PizzaTime[ZdeliveryC, ZdeliveryR] <= OrderLateTime)

                            {
                                lblMessage.Text += ": On- Time";
                                totalSales += Pizzas[ZdeliveryC, ZdeliveryR] * netsoldPizza;
                                pizzaOnTime += Pizzas[ZdeliveryC, ZdeliveryR];
                            }
                            else
                            {
                                lblMessage.Text += " Late!";
                                totalSales += Pizzas[ZdeliveryC, ZdeliveryR] * netLatePizza;
                                pizzaLate += Pizzas[ZdeliveryC, ZdeliveryR];
                            }
                            lblSales.Text = "$" + totalSales.ToString();
                            pizzaInCar -= Pizzas[ZdeliveryC, ZdeliveryR];
                            lblPizza.Text = pizzaInCar.ToString();
                            Pizzas[ZdeliveryC, ZdeliveryR] = 0;
                            deliveryGrid[ZdeliveryC, ZdeliveryR].BackColor = Color.White;
                            deliveryGrid[ZdeliveryC, ZdeliveryR].Text = "";
                            //remove from list
                            for (i = 0; i < lstOrders.Items.Count; i++)
                            {
                                s = lstOrders.Items[i].ToString();
                                c = ((int)s[6]) - 64;
                                r = Convert.ToInt32(s.Substring(8, 2));
                                if (c == ZdeliveryC && r == ZdeliveryR)
                                    break;
                            }
                            lstOrders.Items.RemoveAt(i);
                            LblBlinkB.Top -= 14;
                        }
                    }
                }
            }
        }

       

        private void tmrCar3_Tick(object sender, EventArgs e)
        {
            Image carImage;
            int i, c, r;
            String s;
            deliveryGrid[AcarC, AcarR].Image = null;
            //Move horizontally first
            if (AdeltaC != 0)
            {
                mileage++;
                carImage = picCar5.Image;
                AcarC += Math.Sign(AdeltaC);
                AdeltaC = AdeliveryC - AcarC;
            }
            else
            {
                mileage++;
                carImage = picCar6.Image;
                AcarR += Math.Sign(AdeltaR);
                AdeltaR = AdeliveryR - AcarR;
            }
            deliveryGrid[AcarC, AcarR].Image = carImage;
            if (AcarC == AdeliveryC && AcarR == AdeliveryR)
            {
                BeepSound.Play();
                tmrCar3.Enabled = false;
                if (AcarC == pizzaC && AcarR == pizzaR)
                {
                    lblMessage.Text = "Car at Pizza Parlor:\r\n" + Display(AcarC, AcarR);
                    deliveryGrid[AcarC, AcarR].Image = null;

                    //pizzaInCar = 0;
                    //lblPizza.Text = "0";
                    btnLoad.Enabled = true;
                }
                else
                {
                    lblMessage.Text = "Car at : " + Display(AcarC, AcarR);
                    //check delivery status
                    if (Pizzas[AdeliveryC, AdeliveryR] == 0)
                    {
                        lblMessage.BackColor = Color.Red;
                        lblMessage.Text += "\r\nNo Pizza Wanted";
                        tmrQuickFlash.Start();
                    }
                    else
                    {
                        if (Pizzas[AdeliveryC, AdeliveryR] > pizzaInCar)
                        {
                            lblMessage.BackColor = Color.Red;
                            lblMessage.Text += "\r\nNot Enough Pizzas";
                            tmrQuickFlash.Start();

                        }
                        else
                        {
                            lblMessage.BackColor = Color.Green;
                            lblMessage.Text += "\r\nDelivered" + Pizzas[AdeliveryC, AdeliveryR].ToString() + " Pizza";
                            tmrQuickFlash.Start();
                            Z++;lblZ.Text = Z.ToString();
                            A++; lblA.Text = A.ToString();
                            P++; lblP.Text = P.ToString();
                            if (Pizzas[AdeliveryC, AdeliveryR] > 1)
                                lblMessage.Text += "s";
                            //check if delivery person is on time
                            if ((ClockMinute + 60 * ClockHour) - PizzaTime[AdeliveryC, AdeliveryR] <= OrderLateTime)

                            {
                                lblMessage.Text += ": On- Time";
                                totalSales += Pizzas[AdeliveryC, AdeliveryR] * netsoldPizza;
                                pizzaOnTime += Pizzas[AdeliveryC, AdeliveryR];
                            }
                            else
                            {
                                lblMessage.Text += " Late!";
                                totalSales += Pizzas[AdeliveryC, AdeliveryR] * netLatePizza;
                                pizzaLate += Pizzas[AdeliveryC, AdeliveryR];
                            }
                            lblSales.Text = "$" + totalSales.ToString();
                            pizzaInCar -= Pizzas[AdeliveryC, AdeliveryR];
                            lblPizza.Text = pizzaInCar.ToString();
                            Pizzas[AdeliveryC, AdeliveryR] = 0;
                            deliveryGrid[AdeliveryC, AdeliveryR].BackColor = Color.White;
                            deliveryGrid[AdeliveryC, AdeliveryR].Text = "";
                            //remove from list
                            for (i = 0; i < lstOrders.Items.Count; i++)
                            {
                                s = lstOrders.Items[i].ToString();
                                c = ((int)s[6]) - 64;
                                r = Convert.ToInt32(s.Substring(8, 2));
                                if (c == AdeliveryC && r == AdeliveryR)
                                    break;
                            }
                            lstOrders.Items.RemoveAt(i);
                            LblBlinkB.Top -= 14;

                        }
                    }
                }
            }
        }
         private void tmrCar4_Tick(object sender, EventArgs e)
        {
            Image carImage;
            int i, c, r;
            String s;
            deliveryGrid[PcarC, PcarR].Image = null;
            //Move horizontally first
            if (PdeltaC != 0)
            {
                mileage++;
                carImage = picCar7.Image;
                PcarC += Math.Sign(PdeltaC);
                PdeltaC = PdeliveryC - PcarC;
            }
            else
            {
                mileage++;
                carImage = picCar8.Image;
                PcarR += Math.Sign(PdeltaR);
                PdeltaR = PdeliveryR - PcarR;
            }
            deliveryGrid[PcarC, PcarR].Image = carImage;
            if (PcarC == PdeliveryC && PcarR == PdeliveryR)
            {
                BeepSound.Play();
                tmrCar4.Enabled = false;
                if (PcarC == pizzaC && PcarR == pizzaR)
                {
                    lblMessage.Text = "Car at Pizza Parlor:\r\n" + Display(PcarC, PcarR);
                    deliveryGrid[PcarC, PcarR].Image = null;

                    //pizzaInCar = 0;
                    //lblPizza.Text = "0";
                    btnLoad.Enabled = true;
                }
                else
                {
                    lblMessage.Text = "Car at : " + Display(ZcarC, ZcarR);
                    //check delivery status
                    if (Pizzas[PdeliveryC, PdeliveryR] == 0)
                    {
                        lblMessage.BackColor = Color.Red;
                        lblMessage.Text += "\r\nNo Pizza Wanted";
                        tmrQuickFlash.Start();
                    }
                    else
                    {
                        if (Pizzas[PdeliveryC, PdeliveryR] > pizzaInCar)
                        {
                            lblMessage.BackColor = Color.Red;
                            lblMessage.Text += "\r\nNot Enough Pizzas";
                            tmrQuickFlash.Start();

                        }
                        else
                        {
                            lblMessage.BackColor = Color.Green;
                            lblMessage.Text += "\r\nDelivered" + Pizzas[PdeliveryC, PdeliveryR].ToString() + " Pizza";
                            tmrQuickFlash.Start();
                            Z++; lblZ.Text = Z.ToString();
                            A++; lblA.Text = A.ToString();
                            P++; lblP.Text = P.ToString();
                            G++; lblG.Text = G.ToString();

                            if (Pizzas[PdeliveryC, PdeliveryR] > 1)
                                lblMessage.Text += "s";
                            //check if delivery person is on time
                            if ((ClockMinute + 60 * ClockHour) - PizzaTime[PdeliveryC, PdeliveryR] <= OrderLateTime)

                            {
                                lblMessage.Text += ": On- Time";
                                totalSales += Pizzas[PdeliveryC, PdeliveryR] * netsoldPizza;
                                pizzaOnTime += Pizzas[PdeliveryC, PdeliveryR];
                            }
                            else
                            {
                                lblMessage.Text += " Late!";
                                totalSales += Pizzas[PdeliveryC, PdeliveryR] * netLatePizza;
                                pizzaLate += Pizzas[PdeliveryC, PdeliveryR];
                            }
                            lblSales.Text = "$" + totalSales.ToString();
                            pizzaInCar -= Pizzas[PdeliveryC, PdeliveryR];
                            lblPizza.Text = pizzaInCar.ToString();
                            Pizzas[PdeliveryC, PdeliveryR] = 0;
                            deliveryGrid[PdeliveryC, PdeliveryR].BackColor = Color.White;
                            deliveryGrid[PdeliveryC, PdeliveryR].Text = "";
                            //remove from list
                            for (i = 0; i < lstOrders.Items.Count; i++)
                            {
                                s = lstOrders.Items[i].ToString();
                                c = ((int)s[6]) - 64;
                                r = Convert.ToInt32(s.Substring(8, 2));
                                if (c == PdeliveryC && r == PdeliveryR)
                                    break;
                            }
                            lstOrders.Items.RemoveAt(i);
                            LblBlinkB.Top -= 14;

                        }
                    }
                }
            }
        }
        private void tmrCar5_Tick(object sender, EventArgs e)
        {
            Image carImage;
            int i, c, r;
            String s;
            deliveryGrid[GcarC, GcarR].Image = null;
            //Move horizontally first
            if (GdeltaC != 0)
            {
                mileage++;
                carImage = picCar9.Image;
                GcarC += Math.Sign(GdeltaC);
                GdeltaC = GdeliveryC - GcarC;
            }
            else
            {
                mileage++;
                carImage = picCar10.Image;
                GcarR += Math.Sign(GdeltaR);
                GdeltaR = GdeliveryR - GcarR;
            }
            deliveryGrid[GcarC, GcarR].Image = carImage;
            if (GcarC == GdeliveryC && GcarR == GdeliveryR)
            {
                BeepSound.Play();
                tmrCar5.Enabled = false;
                if (GcarC == pizzaC && GcarR == pizzaR)
                {
                    lblMessage.Text = "Car at Pizza Parlor:\r\n" + Display(GcarC, GcarR);
                    deliveryGrid[GcarC, GcarR].Image = null;

                    //pizzaInCar = 0;
                    //lblPizza.Text = "0";
                    btnLoad.Enabled = true;
                }
                else
                {
                    lblMessage.Text = "Car at : " + Display(GcarC, GcarR);
                    //check delivery status
                    if (Pizzas[GdeliveryC, GdeliveryR] == 0)
                    {
                        lblMessage.BackColor = Color.Red;
                        lblMessage.Text += "\r\nNo Pizza Wanted";
                        tmrQuickFlash.Start();
                    }
                    else
                    {
                        if (Pizzas[GdeliveryC, GdeliveryR] > pizzaInCar)
                        {
                            lblMessage.BackColor = Color.Red;
                            lblMessage.Text += "\r\nNot Enough Pizzas";
                            tmrQuickFlash.Start();

                        }
                        else
                        {
                            lblMessage.BackColor = Color.Green;
                            lblMessage.Text += "\r\nDelivered" + Pizzas[GdeliveryC, GdeliveryR].ToString() + " Pizza";
                            tmrQuickFlash.Start();
                            Z++; lblZ.Text = Z.ToString();
                            A++; lblA.Text = A.ToString();
                            P++; lblP.Text = P.ToString();
                            G++; lblG.Text = G.ToString();

                            if (Pizzas[GdeliveryC, GdeliveryR] > 1)
                                lblMessage.Text += "s";
                            //check if delivery person is on time
                            if ((ClockMinute + 60 * ClockHour) - PizzaTime[GdeliveryC, GdeliveryR] <= OrderLateTime)

                            {
                                lblMessage.Text += ": On- Time";
                                totalSales += Pizzas[GdeliveryC, GdeliveryR] * netsoldPizza;
                                pizzaOnTime += Pizzas[GdeliveryC, GdeliveryR];
                            }
                            else
                            {
                                lblMessage.Text += " Late!";
                                totalSales += Pizzas[GdeliveryC, GdeliveryR] * netLatePizza;
                                pizzaLate += Pizzas[GdeliveryC, GdeliveryR];
                            }
                            lblSales.Text = "$" + totalSales.ToString();
                            pizzaInCar -= Pizzas[GdeliveryC, GdeliveryR];
                            lblPizza.Text = pizzaInCar.ToString();
                            Pizzas[GdeliveryC, GdeliveryR] = 0;
                            deliveryGrid[GdeliveryC, GdeliveryR].BackColor = Color.White;
                            deliveryGrid[GdeliveryC, GdeliveryR].Text = "";
                            //remove from list
                            for (i = 0; i < lstOrders.Items.Count; i++)
                            {
                                s = lstOrders.Items[i].ToString();
                                c = ((int)s[6]) - 64;
                                r = Convert.ToInt32(s.Substring(8, 2));
                                if (c == GdeliveryC && r == GdeliveryR)
                                    break;
                            }
                            lstOrders.Items.RemoveAt(i);
                            LblBlinkB.Top -= 14;

                        }
                    }
                }
            }
        }
        private void btnMoreCarsClick(object sender, EventArgs e)
     {
         int Valuez;
            int Money;
           if (Z < 15  )  //Z <15
         {
                if (totalSales >= 150)
                {
                   Money = 150;
                totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                lblbMoreCCost.Text = "$" + Money.ToString();
             Valuez = 15 - Z;
             Z = Valuez + Z; //Stop at frame 50
                tmrProgress1.Start();
                ProgressBar1 = 1;
                    KACHING.Play();
                    
             // load car
            }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!","Not Enough Cash!" );
                }
            }

         else if ( Z >= 15 &&  A < 30)//&& totalSales >= 300  //  Z >= 15 &&  A < 30
            {
                if (totalSales >= 300)
                {
                    Money = 300;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblbMoreCCost.Text = "$" + Money.ToString();
                    ProgressBar1 = 2;
                    Valuez = 30 - A;
                    A = Valuez + A;
                    Valuez = 30 - Z;
                    Z = Valuez + Z;
                    tmrProgress1.Start();
                    ProgressBar1 = 2;
                    KACHING.Play();
                   
                    //Stop at frame 100
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
         else if (Z >= 15 && A >= 30 && P < 45)
            {
                if (totalSales >= 450)
                {
                    Money = 450;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblbMoreCCost.Text = "$" + Money.ToString();
                    ProgressBar1 = 3;
                    Valuez = 45 - P;
                    P = Valuez + P;
                    Valuez = 45 - A;
                    A = Valuez + A;
                    Valuez = 45 - Z;
                    Z = Valuez + Z;
                    tmrProgress1.Start();
                    ProgressBar1 = 3;
                    KACHING.Play();
                 

                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (Z >= 15 && A >= 30 && P >= 45 && G < 60)
            {
                if (totalSales >= 600)
                { 
                    Money = 450;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    lblbMoreCCost.Text = "Full!";
                    ProgressBar1 = 3;
                    Valuez = 60 - P;
                    P = Valuez + P;
                    Valuez = 60 - A;
                    A = Valuez + A;
                    Valuez = 60 - G;
                    G = Valuez + G;
                    Valuez = 60 - Z;
                    Z = Valuez + Z;
                    tmrProgress1.Start();
                    ProgressBar1 = 4;
                    KACHING.Play();
                  
                    btnGetCar.Enabled = false; //Stop at frame 152
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
        }

     private void btnPizzaSlotsSpots_Click(object sender, EventArgs e)
     {
            int Money;
            if (pizzasBakingMax == 8)
            {
                if (totalSales >= 150)
                {
                    KACHING.Play();
                    Money = 150;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblPlusPizzaSlot.Text = "$" + Money.ToString();
                    pizzasBakingMax += 1;
                    tmrProgress2.Start();
                    ProgressBar2 = 1;
                  
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }

            }
            else if (pizzasBakingMax == 9)
            {
                if (totalSales >= 300)
                {
                    Money = 300;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblPlusPizzaSlot.Text = "$" + Money.ToString();
                    pizzasBakingMax += 1;
                    tmrProgress2.Start();
                    ProgressBar2 = 2;
                    KACHING.Play();
                    
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (pizzasBakingMax == 10)
            {
                if (totalSales >= 450)
                {
                    Money = 450;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblPlusPizzaSlot.Text = "$" + Money.ToString();
                    pizzasBakingMax += 1;
                    tmrProgress2.Start();
                    ProgressBar2 = 3;
                    KACHING.Play();
                                    }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (pizzasBakingMax == 11)
            {
                if (totalSales >= 600)
                {
                    Money = 600;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblPlusPizzaSlot.Text = "$" + Money.ToString();

                    pizzasBakingMax += 1;
                    tmrProgress2.Start();
                    ProgressBar2 = 4;
                    KACHING.Play();
                  

                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (pizzasBakingMax == 12)
            {
                if (totalSales >= 750)
                {
                    Money = 750;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    lblPlusPizzaSlot.Text = "Full!";
                    btnPlusPizzaSlot.Enabled = false;
                    tmrProgress2.Start();
                    ProgressBar2 = 5;
                    KACHING.Play();
                  
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }

     }

     private void btnDecreaseOvenTime_Click(object sender, EventArgs e)
     {
         int Money;
            if (bakingTime == 10)
            {
                if (totalSales >= 150)
                {
                    Money = 150;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblDOvenTime.Text = "$" + Money.ToString();
                    bakingTime -= 1;
                    tmrProgress4.Start();
                    ProgressBar4 = 1;
                    KACHING.Play();
                    


                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (bakingTime == 9)
            {
                if (totalSales >= 300)
                {
                    Money = 300;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblDOvenTime.Text = "$" + Money.ToString();
                    bakingTime -= 1;
                    tmrProgress4.Start();
                    ProgressBar4 = 2;
                    KACHING.Play();

                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (bakingTime == 8)
            {
                if (totalSales >= 450)
                {
                    Money = 450;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblDOvenTime.Text = "$" + Money.ToString();
                    bakingTime -= 1;
                    tmrProgress4.Start();
                    ProgressBar4 = 3;
                    KACHING.Play();

                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (bakingTime == 7)
            {
                if (totalSales >= 600)
                {
                    Money = 600;
                    totalSales = totalSales - Money;
                      lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblDOvenTime.Text = "$" + Money.ToString();
                    bakingTime -= 1;
                    tmrProgress4.Start();
                    ProgressBar4 = 4;
                    KACHING.Play();

                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (bakingTime == 6)
            {
                if (totalSales >= 750)
                {
                    Money = 750;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblDOvenTime.Text = "$" + Money.ToString();
                    bakingTime -= 1;
                    tmrProgress4.Start();
                    ProgressBar4 = 5;
                    KACHING.Play();

                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }

            else if (bakingTime == 5)
            {
                if (totalSales >= 900)
                {
                    Money = 900;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    lblDOvenTime.Text = "Full!";
                    bakingTime -= 1;
                    tmrProgress4.Start();
                    ProgressBar4 = 6;
                    KACHING.Play();
                    btnDecreaseOvenTime.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
        
     }
   private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   private void btnPlusTwoSpace_Click(object sender, EventArgs e)
   {
            int Money;
            if (PizzasInCarMax == 10)
            {
                if (totalSales >= 150)
                {
                    Money = 150;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblbPlusCarSpace.Text = "$" + Money.ToString();
                    PizzasInCarMax += 2;
                    tmrProgress3.Start();
                    ProgressBar3 = 1;
                    KACHING.Play();
                   
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (PizzasInCarMax == 12)
            {
                if (totalSales >= 300)
                {
                    Money = 300;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblbPlusCarSpace.Text = "$" + Money.ToString();
                    PizzasInCarMax += 2;
                    tmrProgress3.Start();
                    ProgressBar3 = 2;
                    KACHING.Play();
                   


                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (PizzasInCarMax == 14)
            {
                if (totalSales >= 450)
                {
                    Money = 450;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblbPlusCarSpace.Text = "$" + Money.ToString();
                    PizzasInCarMax += 2;
                    tmrProgress3.Start();
                    ProgressBar3 = 3;
                    KACHING.Play();
                   

                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }

            }
            else if (PizzasInCarMax == 16)
            {
                if (totalSales >= 600)
                {
                    Money = 600;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblbPlusCarSpace.Text = "$" + Money.ToString();
                    PizzasInCarMax += 2;
                    tmrProgress3.Start();
                    ProgressBar3 = 4;
                    KACHING.Play();
                  
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (PizzasInCarMax == 18)
            {
                if (totalSales >= 750)
                {
                    Money = 750;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    Money += 150;
                    lblbPlusCarSpace.Text = "$" + Money.ToString();
                    PizzasInCarMax += 2;
                    tmrProgress3.Start();
                    ProgressBar3 = 5;
                    KACHING.Play();
                  
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (PizzasInCarMax == 20)
            {
                if (totalSales >= 900)
                {
                    Money = 900;
                    totalSales = totalSales - Money;
                    lblSales.Text = "$" + totalSales.ToString();
                    lblbPlusCarSpace.Text = "Full!";
                    lblA.Text = PizzasInCarMax.ToString();
                    tmrProgress3.Start();
                    ProgressBar3 = 6;
                    KACHING.Play();
                   
                    btnTwoSpace.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You dont have enough money to make this transaction!", "Not Enough Cash!");
                }
            }
            else if (PizzasInCarMax == 22)
            {
                btnTwoSpace.Enabled = false;
            }
        

   }

   private void pictureBox3_Click(object sender, EventArgs e)
   {

   }

   private void panel1_Paint(object sender, PaintEventArgs e)
   {

   }

   private void tmrProgress1_Tick(object sender, EventArgs e)
   {
       PB1++;
       switch (PB1)
       {
           case 1:
                    
                    picProgressBar1.Image = Properties.Resources.frame_0_delay_0_03s;
               break;
           case 2:
              picProgressBar1.Image = Properties.Resources.frame_1_delay_0_03s;
               break;
           case 3:
             picProgressBar1.Image = Properties.Resources.frame_2_delay_0_03s;
               break;
           case 4:
               picProgressBar1.Image = Properties.Resources.frame_3_delay_0_03s;
               break;
           case 5:
                    picProgressBar1.Image = Properties.Resources.frame_4_delay_0_03s;
               break;
                case 6:
                   
                    picProgressBar1.Image = Properties.Resources.frame_5_delay_0_03s;
                    break;
                case 7:
                    picProgressBar1.Image = Properties.Resources.frame_6_delay_0_03s;
                    break;
                case 8:
                    picProgressBar1.Image = Properties.Resources.frame_7_delay_0_03s;
                    break;
                case 9:
                    picProgressBar1.Image = Properties.Resources.frame_8_delay_0_03s;
                    break;
                case 10:
                    picProgressBar1.Image = Properties.Resources.frame_9_delay_0_03s;
                    break;
                case 11:
                    picProgressBar1.Image = Properties.Resources.frame_10_delay_0_03s;
                    break;
                case 12:
                  
                    picProgressBar1.Image = Properties.Resources.frame_11_delay_0_03s;
                    break;
                case 13:
                    picProgressBar1.Image = Properties.Resources.frame_12_delay_0_03s;
                    break;
                case 14:
                    picProgressBar1.Image = Properties.Resources.frame_13_delay_0_03s;
                    break;
                case 15:
                    picProgressBar1.Image = Properties.Resources.frame_14_delay_0_03s;
                    break;
                case 16:
                    picProgressBar1.Image = Properties.Resources.frame_15_delay_0_03s;
                    break;
                case 17:
                    picProgressBar1.Image = Properties.Resources.frame_16_delay_0_03s;
                    break;
                case 18:
                   
                    picProgressBar1.Image = Properties.Resources.frame_17_delay_0_03s;
                    break;
                case 19:
                    picProgressBar1.Image = Properties.Resources.frame_18_delay_0_03s;
                    break;
                case 20:
                    picProgressBar1.Image = Properties.Resources.frame_19_delay_0_03s;
                    break;
                case 21:
                    picProgressBar1.Image = Properties.Resources.frame_20_delay_0_03s;
                    break;
                case 22:
                    picProgressBar1.Image = Properties.Resources.frame_21_delay_0_03s;
                    break;
                case 23:
                    picProgressBar1.Image = Properties.Resources.frame_22_delay_0_03s;
                    break;
                case 24:
                   picProgressBar1.Image = Properties.Resources.frame_23_delay_0_03s;
                    break;
                case 25:
                    picProgressBar1.Image = Properties.Resources.frame_24_delay_0_03s;
                    break;
                case 26:
                    picProgressBar1.Image = Properties.Resources.frame_25_delay_0_03s;
                    break;
                case 27:
                    picProgressBar1.Image = Properties.Resources.frame_26_delay_0_03s;
                    break;
                case 28:
                    picProgressBar1.Image = Properties.Resources.frame_27_delay_0_03s;
                    break;
                case 29:
                    picProgressBar1.Image = Properties.Resources.frame_28_delay_0_03s;
                    break;
                case 30:
                   picProgressBar1.Image = Properties.Resources.frame_29_delay_0_03s;
                    break;
                case 31:
                    picProgressBar1.Image = Properties.Resources.frame_30_delay_0_03s;
                    break;
                case 32:
                    picProgressBar1.Image = Properties.Resources.frame_31_delay_0_03s;
                    break;
                case 33:
                    picProgressBar1.Image = Properties.Resources.frame_32_delay_0_03s;
                    break;
                case 34:
                    picProgressBar1.Image = Properties.Resources.frame_33_delay_0_03s;
                    break;
                case 35:
                    picProgressBar1.Image = Properties.Resources.frame_34_delay_0_03s;
                    break;
                case 36:
                   picProgressBar1.Image = Properties.Resources.frame_35_delay_0_03s;
                    break;
                case 37:
                    picProgressBar1.Image = Properties.Resources.frame_36_delay_0_03s;
                    break;
                case 38:
                    picProgressBar1.Image = Properties.Resources.frame_37_delay_0_03s;
                    if (ProgressBar1 == 1)
                    {
                                             
                        tmrProgress1.Stop();
                    }
                    break;
                case 39:
                    
                    picProgressBar1.Image = Properties.Resources.frame_38_delay_0_03s;
                    break;
                case 40:
                    picProgressBar1.Image = Properties.Resources.frame_39_delay_0_03s;
                    break;
                case 41:
                    picProgressBar1.Image = Properties.Resources.frame_40_delay_0_03s;
                    break;
                case 42:
                    picProgressBar1.Image = Properties.Resources.frame_41_delay_0_03s;
               
                    break;
                case 43:
                    picProgressBar1.Image = Properties.Resources.frame_42_delay_0_03s;
                    break;
                case 44:
                    picProgressBar1.Image = Properties.Resources.frame_43_delay_0_03s;
                    break;
                case 45:
                    picProgressBar1.Image = Properties.Resources.frame_44_delay_0_03s;
                    break;
                case 46:
                    picProgressBar1.Image = Properties.Resources.frame_45_delay_0_03s;
                    break;
                case 47:
                    picProgressBar1.Image = Properties.Resources.frame_46_delay_0_03s;
                    break;
                case 48:
                    picProgressBar1.Image = Properties.Resources.frame_47_delay_0_03s;
                   
                    break;
                case 49:
                    picProgressBar1.Image = Properties.Resources.frame_48_delay_0_03s;
                    break;
                case 50:
                    picProgressBar1.Image = Properties.Resources.frame_49_delay_0_03s;
                    break;
                case 51:
                    picProgressBar1.Image = Properties.Resources.frame_50_delay_0_03s;
                    break;
                case 52:
                    picProgressBar1.Image = Properties.Resources.frame_51_delay_0_03s;
                    break;
                case 53:
                    picProgressBar1.Image = Properties.Resources.frame_52_delay_0_03s;
                    break;
                case 54:
                   picProgressBar1.Image = Properties.Resources.frame_53_delay_0_03s;
                    break;
                case 55:
                    picProgressBar1.Image = Properties.Resources.frame_54_delay_0_03s;
                    break;
                case 56:
                    picProgressBar1.Image = Properties.Resources.frame_55_delay_0_03s;
                    break;
                case 57:
                    picProgressBar1.Image = Properties.Resources.frame_56_delay_0_03s;
                    break;
                case 58:
                    picProgressBar1.Image = Properties.Resources.frame_57_delay_0_03s;
                    break;
                case 59:
                    picProgressBar1.Image = Properties.Resources.frame_58_delay_0_03s;
                    break;
                case 60:
                   picProgressBar1.Image = Properties.Resources.frame_59_delay_0_03s;
                    break;
                case 61:
                    picProgressBar1.Image = Properties.Resources.frame_60_delay_0_03s;
                    break;
                case 62:
                    picProgressBar1.Image = Properties.Resources.frame_61_delay_0_03s;
                    break;
                case 63:
                    picProgressBar1.Image = Properties.Resources.frame_62_delay_0_03s;
                    break;
                case 64:
                    picProgressBar1.Image = Properties.Resources.frame_63_delay_0_03s;
                    break;
                case 65:
                    picProgressBar1.Image = Properties.Resources.frame_64_delay_0_03s;
                    break;
                case 66:
                   picProgressBar1.Image = Properties.Resources.frame_65_delay_0_03s;
                    break;
                case 67:
                    picProgressBar1.Image = Properties.Resources.frame_66_delay_0_03s;
                    break;
                case 68:
                    picProgressBar1.Image = Properties.Resources.frame_67_delay_0_03s;
                    break;
                case 69: //;)
                    picProgressBar1.Image = Properties.Resources.frame_68_delay_0_03s;   
                    break;
                case 70:
                    picProgressBar1.Image = Properties.Resources.frame_69_delay_0_03s; //;)
                    break;
                case 71:
                    picProgressBar1.Image = Properties.Resources.frame_70_delay_0_03s;
                    break;
                case 72:
                    picProgressBar1.Image = Properties.Resources.frame_71_delay_0_03s;
                    break;
                case 73:
                    picProgressBar1.Image = Properties.Resources.frame_72_delay_0_03s;
                    break;
                case 74:
                   
                    picProgressBar1.Image = Properties.Resources.frame_73_delay_0_03s;
                    break;
                case 75:
                    picProgressBar1.Image = Properties.Resources.frame_74_delay_0_03s;
                    break;
                case 76:
                    picProgressBar1.Image = Properties.Resources.frame_75_delay_0_03s;

                    if (ProgressBar1 == 2)
                    {
                        tmrProgress1.Stop();
                        
                    }
                    break;
                case 77:
                    picProgressBar1.Image = Properties.Resources.frame_76_delay_0_03s;
                    break;
                case 78:
                    picProgressBar1.Image = Properties.Resources.frame_77_delay_0_03s;
                    break;
                case 79:
                    picProgressBar1.Image = Properties.Resources.frame_78_delay_0_03s;
                    break;
                case 80:
                    picProgressBar1.Image = Properties.Resources.frame_79_delay_0_03s;
                    break;
                case 81:
                    picProgressBar1.Image = Properties.Resources.frame_80_delay_0_03s;
                    break;                    
                case 82:
                    picProgressBar1.Image = Properties.Resources.frame_81_delay_0_03s;
                    break;
                case 83:
                    picProgressBar1.Image = Properties.Resources.frame_82_delay_0_03s;
                    break;
                case 84:
                    picProgressBar1.Image = Properties.Resources.frame_83_delay_0_03s;
                    break;
                case 85:
                    picProgressBar1.Image = Properties.Resources.frame_84_delay_0_03s;
                    break;
                case 86:
                    picProgressBar1.Image = Properties.Resources.frame_85_delay_0_03s;
                    break;
                case 87:
                    picProgressBar1.Image = Properties.Resources.frame_86_delay_0_03s;
                    break;
                case 88:
                    picProgressBar1.Image = Properties.Resources.frame_87_delay_0_03s;
                    break;
                case 89:
                    picProgressBar1.Image = Properties.Resources.frame_88_delay_0_03s;
                    break;
                case 90:
                    picProgressBar1.Image = Properties.Resources.frame_89_delay_0_03s;
                    break;
                case 91:
                    picProgressBar1.Image = Properties.Resources.frame_90_delay_0_03s;
                    break;
                case 92:
                    picProgressBar1.Image = Properties.Resources.frame_91_delay_0_03s;
                    break;
                case 93:
                    picProgressBar1.Image = Properties.Resources.frame_92_delay_0_03s;
                    break;
                case 94:
                    picProgressBar1.Image = Properties.Resources.frame_93_delay_0_03s;
                    break;                    
                case 95:
                    picProgressBar1.Image = Properties.Resources.frame_94_delay_0_03s;
                    break;
                case 96:
                    picProgressBar1.Image = Properties.Resources.frame_95_delay_0_03s;
                    break;
                case 97:
                    picProgressBar1.Image = Properties.Resources.frame_96_delay_0_03s;
                    break;
                case 98:
                    picProgressBar1.Image = Properties.Resources.frame_97_delay_0_03s;
                    break;
                case 99:
                    picProgressBar1.Image = Properties.Resources.frame_98_delay_0_03s;
                    break;
                case 100:
                    picProgressBar1.Image = Properties.Resources.frame_99_delay_0_03s;
                    break;
                case 101:
                    picProgressBar1.Image = Properties.Resources.frame_100_delay_0_03s;
                     break;
                case 102:
                    picProgressBar1.Image = Properties.Resources.frame_101_delay_0_03s;
                    break;
                case 103:
                    picProgressBar1.Image = Properties.Resources.frame_102_delay_0_03s;
                    break;
                case 104:
                    picProgressBar1.Image = Properties.Resources.frame_103_delay_0_03s;
                    if (ProgressBar1 == 3)
                    {
                        tmrProgress1.Stop();
                    }
                    break;
                case 105:
                    picProgressBar1.Image = Properties.Resources.frame_104_delay_0_03s;
                    break;
                case 106:
                    picProgressBar1.Image = Properties.Resources.frame_105_delay_0_03s;
                    break;
                case 107:
                    picProgressBar1.Image = Properties.Resources.frame_106_delay_0_03s;
                    break;
                case 108:
                    picProgressBar1.Image = Properties.Resources.frame_107_delay_0_03s;
                    break;
                case 109:
                    picProgressBar1.Image = Properties.Resources.frame_108_delay_0_03s;
                    break;
                case 110:
                    picProgressBar1.Image = Properties.Resources.frame_109_delay_0_03s;
                    break;
                case 111:
                    picProgressBar1.Image = Properties.Resources.frame_110_delay_0_03s;
                    break;
                case 112:
                    picProgressBar1.Image = Properties.Resources.frame_111_delay_0_03s;
                    break;
                case 113:
                    picProgressBar1.Image = Resources.frame_112_delay_0_03s; // works without "properties" 
                    break;
                case 114:
                    picProgressBar1.Image = Properties.Resources.frame_113_delay_0_03s;
                    break;
                case 115:
                    picProgressBar1.Image = Properties.Resources.frame_114_delay_0_03s;
                    break;
                case 116:
                    picProgressBar1.Image = Properties.Resources.frame_115_delay_0_03s;
                    break;
                case 117:
                    picProgressBar1.Image = Properties.Resources.frame_116_delay_0_03s;
                    break;
                case 118:
                    picProgressBar1.Image = Properties.Resources.frame_117_delay_0_03s;
                    break;
                case 119:
                    picProgressBar1.Image = Properties.Resources.frame_118_delay_0_03s;
                    break;
                case 120:
                    picProgressBar1.Image = Properties.Resources.frame_119_delay_0_03s;
                    break;
                case 121:
                    picProgressBar1.Image = Properties.Resources.frame_120_delay_0_03s;
                    break;
                case 122:
                    picProgressBar1.Image = Properties.Resources.frame_121_delay_0_03s;
                    break;
                case 123:
                    picProgressBar1.Image = Properties.Resources.frame_122_delay_0_03s;
                    break;
                case 124:
                    picProgressBar1.Image = Properties.Resources.frame_123_delay_0_03s;
                    break;
                case 125:
                    picProgressBar1.Image = Properties.Resources.frame_124_delay_0_03s;
                    break;
                case 126:
                    picProgressBar1.Image = Properties.Resources.frame_125_delay_0_03s;
                    break;
                case 127:
                    picProgressBar1.Image = Properties.Resources.frame_126_delay_0_03s;
                    break;
                case 128:
                    picProgressBar1.Image = Properties.Resources.frame_127_delay_0_03s;
                    break;
                case 129:
                    picProgressBar1.Image = Properties.Resources.frame_128_delay_0_03s;
                    break;
                case 130:
                    picProgressBar1.Image = Properties.Resources.frame_129_delay_0_03s;
                    break;
                case 131:
                    picProgressBar1.Image = Properties.Resources.frame_130_delay_0_03s;
                    break;
                case 132:
                    picProgressBar1.Image = Properties.Resources.frame_131_delay_0_03s;
                    break;
                case 133:
                    picProgressBar1.Image = Properties.Resources.frame_132_delay_0_03s;
                    break;
                case 134:
                    picProgressBar1.Image = Properties.Resources.frame_133_delay_0_03s;
                    break;
                case 135:
                    picProgressBar1.Image = Properties.Resources.frame_134_delay_0_03s;
                    break;
                case 136:
                    picProgressBar1.Image = Properties.Resources.frame_135_delay_0_03s;
                    break;
                case 137:
                    picProgressBar1.Image = Properties.Resources.frame_136_delay_0_03s;
                    break;
                case 138:
                    picProgressBar1.Image = Properties.Resources.frame_137_delay_0_03s;
                    break;
                case 139:
                    picProgressBar1.Image = Properties.Resources.frame_138_delay_0_03s;
                    break;
                case 140:
                    picProgressBar1.Image = Properties.Resources.frame_139_delay_0_03s;
                    break;
                case 141:
                    picProgressBar1.Image = Properties.Resources.frame_140_delay_0_03s;
                    break;
                case 142:
                    picProgressBar1.Image = Properties.Resources.frame_141_delay_0_03s;
                    break;
                case 143:
                    picProgressBar1.Image = Properties.Resources.frame_142_delay_0_03s;
                    break;
                case 144:
                    picProgressBar1.Image = Properties.Resources.frame_143_delay_0_03s;
                    break;
                case 145:
                    picProgressBar1.Image = Properties.Resources.frame_144_delay_0_03s;
                    break;
                case 146:
                    tmrProgress1.Interval = 1000;
                    picProgressBar1.Image = Properties.Resources.frame_145delay_0;
                    break;
                case 147:
                    picProgressBar1.Image = Properties.Resources.frame_146;
                    break;
                case 148:
                    tmrProgress1.Interval = 20;
                    picProgressBar1.Image = Properties.Resources.frame_147;
                    break;
                case 149:
                    picProgressBar1.Image = Properties.Resources.frame_148;
                    break;
                case 150:
                    tmrProgress1.Interval = 1000;
                    picProgressBar1.Image = Properties.Resources.frame_149;
                    break;
                case 151:
                    picProgressBar1.Image = Properties.Resources.frame_150;
                    PB1 = 0;
                    if (ProgressBar1 == 4)
                    {
                        tmrProgress1.Stop();
                    }
                    break;

            }
        }
        private void tmrProgress2_Tick(object sender, EventArgs e)
        {
            PB2++;
            switch (PB2)
            {
                case 1:
                    picProgressBar2.Image = Properties.Resources.frame_0_delay_0_03s;
                    break;
                case 2:
                    picProgressBar2.Image = Properties.Resources.frame_1_delay_0_03s;
                    break;
                case 3:
                    picProgressBar2.Image = Properties.Resources.frame_2_delay_0_03s;
                    break;
                case 4:
                    picProgressBar2.Image = Properties.Resources.frame_3_delay_0_03s;
                    break;
                case 5:
                    picProgressBar2.Image = Properties.Resources.frame_4_delay_0_03s;
                    break;
                case 6:
                    picProgressBar2.Image = Properties.Resources.frame_5_delay_0_03s;
                    break;
                case 7:
                    picProgressBar2.Image = Properties.Resources.frame_6_delay_0_03s;
                    break;
                case 8:
                    picProgressBar2.Image = Properties.Resources.frame_7_delay_0_03s;
                    break;
                case 9:
                    picProgressBar2.Image = Properties.Resources.frame_8_delay_0_03s;
                    break;
                case 10:
                    picProgressBar2.Image = Properties.Resources.frame_9_delay_0_03s;
                    break;
                case 11:
                    picProgressBar2.Image = Properties.Resources.frame_10_delay_0_03s;
                    break;
                case 12:
                    picProgressBar2.Image = Properties.Resources.frame_11_delay_0_03s;
                    break;
                case 13:
                    picProgressBar2.Image = Properties.Resources.frame_12_delay_0_03s;
                    break;
                case 14:
                    picProgressBar2.Image = Properties.Resources.frame_13_delay_0_03s;
                    break;
                case 15:
                    picProgressBar2.Image = Properties.Resources.frame_14_delay_0_03s;
                    break;
                case 16:
                    picProgressBar2.Image = Properties.Resources.frame_15_delay_0_03s;
                    break;
                case 17:
                    picProgressBar2.Image = Properties.Resources.frame_16_delay_0_03s;
                    break;
                case 18:
                    picProgressBar2.Image = Properties.Resources.frame_17_delay_0_03s;
                    break;
                case 19:
                    picProgressBar2.Image = Properties.Resources.frame_18_delay_0_03s;
                    break;
                case 20:
                    picProgressBar2.Image = Properties.Resources.frame_19_delay_0_03s;
                    break;
                case 21:
                    picProgressBar2.Image = Properties.Resources.frame_20_delay_0_03s;
                    break;
                case 22:
                    picProgressBar2.Image = Properties.Resources.frame_21_delay_0_03s;
                    break;
                case 23:
                    picProgressBar2.Image = Properties.Resources.frame_22_delay_0_03s;
                    break;
                case 24:
                    picProgressBar2.Image = Properties.Resources.frame_23_delay_0_03s;
                    break;
                case 25:
                    picProgressBar2.Image = Properties.Resources.frame_24_delay_0_03s;
                    break;
                case 26:
                    picProgressBar2.Image = Properties.Resources.frame_25_delay_0_03s;
                    break;
                case 27:
                    picProgressBar2.Image = Properties.Resources.frame_26_delay_0_03s;
                    break;
                case 28:
                    picProgressBar2.Image = Properties.Resources.frame_27_delay_0_03s;
                    break;
                case 29:
                    picProgressBar2.Image = Properties.Resources.frame_28_delay_0_03s;
                    break;
                case 30:
                    picProgressBar2.Image = Properties.Resources.frame_29_delay_0_03s;
                    break;
                case 31:
                    picProgressBar2.Image = Properties.Resources.frame_30_delay_0_03s;
                    if (ProgressBar2 == 1)
                    {
                        tmrProgress2.Stop();
                    }
                    break;
                case 32:
                    picProgressBar2.Image = Properties.Resources.frame_31_delay_0_03s;
                    break;
                case 33:
                    picProgressBar2.Image = Properties.Resources.frame_32_delay_0_03s;
                    break;
                case 34:
                    picProgressBar2.Image = Properties.Resources.frame_33_delay_0_03s;
                    break;
                case 35:
                    picProgressBar2.Image = Properties.Resources.frame_34_delay_0_03s;
                    break;
                case 36:
                    picProgressBar2.Image = Properties.Resources.frame_35_delay_0_03s;
                    break;
                case 37:
                    picProgressBar2.Image = Properties.Resources.frame_36_delay_0_03s;
                    break;
                case 38:
                    picProgressBar2.Image = Properties.Resources.frame_37_delay_0_03s;
                    break;
                case 39:
                    picProgressBar2.Image = Properties.Resources.frame_38_delay_0_03s;
                    break;
                case 40:
                    picProgressBar2.Image = Properties.Resources.frame_39_delay_0_03s;
                    break;
                case 41:
                    picProgressBar2.Image = Properties.Resources.frame_40_delay_0_03s;
                    break;
                case 42:
                    picProgressBar2.Image = Properties.Resources.frame_41_delay_0_03s;
                    break;
                case 43:
                    picProgressBar2.Image = Properties.Resources.frame_42_delay_0_03s;
                    break;
                case 44:
                    picProgressBar2.Image = Properties.Resources.frame_43_delay_0_03s;
                    break;
                case 45:
                    picProgressBar2.Image = Properties.Resources.frame_44_delay_0_03s;
                    break;
                case 46:
                    picProgressBar2.Image = Properties.Resources.frame_45_delay_0_03s;
                    break;
                case 47:
                    picProgressBar2.Image = Properties.Resources.frame_46_delay_0_03s;
                    break;
                case 48:
                    picProgressBar2.Image = Properties.Resources.frame_47_delay_0_03s;
                    break;
                case 49:
                    picProgressBar2.Image = Properties.Resources.frame_48_delay_0_03s;
                    break;
                case 50:
                    picProgressBar2.Image = Properties.Resources.frame_49_delay_0_03s;
                    break;
                case 51:
                    picProgressBar2.Image = Properties.Resources.frame_50_delay_0_03s;
                    break;
                case 52:
                    picProgressBar2.Image = Properties.Resources.frame_51_delay_0_03s;
                    break;
                case 53:
                    picProgressBar2.Image = Properties.Resources.frame_52_delay_0_03s;
                    break;
                case 54:
                    picProgressBar2.Image = Properties.Resources.frame_53_delay_0_03s;
                    break;
                case 55:
                    picProgressBar2.Image = Properties.Resources.frame_54_delay_0_03s;
                    break;
                case 56:
                    picProgressBar2.Image = Properties.Resources.frame_55_delay_0_03s;
                    break;
                case 57:
                    picProgressBar2.Image = Properties.Resources.frame_56_delay_0_03s;
                    break;
                case 58:
                    picProgressBar2.Image = Properties.Resources.frame_57_delay_0_03s;
                    break;
                case 59:
                    picProgressBar2.Image = Properties.Resources.frame_58_delay_0_03s;
                    break;
                case 60:
                    picProgressBar2.Image = Properties.Resources.frame_59_delay_0_03s;
                    if (ProgressBar2 == 2)
                    {
                        tmrProgress2.Stop();
                    }
                    break;
                case 61:
                    picProgressBar2.Image = Properties.Resources.frame_60_delay_0_03s;
                    break;
                case 62:
                    picProgressBar2.Image = Properties.Resources.frame_61_delay_0_03s;
                    break;
                case 63:
                    picProgressBar2.Image = Properties.Resources.frame_62_delay_0_03s;
                    break;
                case 64:
                    picProgressBar2.Image = Properties.Resources.frame_63_delay_0_03s;
                    break;
                case 65:
                    picProgressBar2.Image = Properties.Resources.frame_64_delay_0_03s;
                    break;
                case 66:
                    picProgressBar2.Image = Properties.Resources.frame_65_delay_0_03s;
                    break;
                case 67:
                    picProgressBar2.Image = Properties.Resources.frame_66_delay_0_03s;
                    break;
                case 68:
                    picProgressBar2.Image = Properties.Resources.frame_67_delay_0_03s;
                    break;
                case 69: //;)
                    picProgressBar2.Image = Properties.Resources.frame_68_delay_0_03s;
                    break;
                case 70:
                    picProgressBar2.Image = Properties.Resources.frame_69_delay_0_03s; //;)
                    break;
                case 71:
                    picProgressBar2.Image = Properties.Resources.frame_70_delay_0_03s;
                    break;
                case 72:
                    picProgressBar2.Image = Properties.Resources.frame_71_delay_0_03s;
                    break;
                case 73:
                    picProgressBar2.Image = Properties.Resources.frame_72_delay_0_03s;
                    break;
                case 74:
                    picProgressBar2.Image = Properties.Resources.frame_73_delay_0_03s;
                    break;
                case 75:
                    picProgressBar2.Image = Properties.Resources.frame_74_delay_0_03s;
                    break;
                case 76:
                    picProgressBar2.Image = Properties.Resources.frame_75_delay_0_03s;
                    break;
                case 77:
                    picProgressBar2.Image = Properties.Resources.frame_76_delay_0_03s;
                    break;
                case 78:
                    picProgressBar2.Image = Properties.Resources.frame_77_delay_0_03s;
                    break;
                case 79:
                    picProgressBar2.Image = Properties.Resources.frame_78_delay_0_03s;
                    break;
                case 80:
                    picProgressBar2.Image = Properties.Resources.frame_79_delay_0_03s;
                    break;
                case 81:
                    picProgressBar2.Image = Properties.Resources.frame_80_delay_0_03s;
                    break;
                case 82:
                    picProgressBar2.Image = Properties.Resources.frame_81_delay_0_03s;
                    break;
                case 83:
                    picProgressBar2.Image = Properties.Resources.frame_82_delay_0_03s;
                    break;
                case 84:
                    picProgressBar2.Image = Properties.Resources.frame_83_delay_0_03s;
                    break;
                case 85:
                    picProgressBar2.Image = Properties.Resources.frame_84_delay_0_03s;
                    break;
                case 86:
                    picProgressBar2.Image = Properties.Resources.frame_85_delay_0_03s;
                    break;
                case 87:
                    picProgressBar2.Image = Properties.Resources.frame_86_delay_0_03s;
                    break;
                case 88:
                    picProgressBar2.Image = Properties.Resources.frame_87_delay_0_03s;
                    break;
                case 89:
                    picProgressBar2.Image = Properties.Resources.frame_88_delay_0_03s;
                    break;
                case 90:
                    picProgressBar2.Image = Properties.Resources.frame_89_delay_0_03s;
                    break;
                case 91:
                    picProgressBar2.Image = Properties.Resources.frame_90_delay_0_03s;

                    if (ProgressBar2 == 3)
                    {
                        tmrProgress2.Stop();
                    }
                    break;
                case 92:
                    picProgressBar2.Image = Properties.Resources.frame_91_delay_0_03s;
                    break;
                case 93:
                    picProgressBar2.Image = Properties.Resources.frame_92_delay_0_03s;
                    break;
                case 94:
                    picProgressBar2.Image = Properties.Resources.frame_93_delay_0_03s;
                    break;
                case 95:
                    picProgressBar2.Image = Properties.Resources.frame_94_delay_0_03s;
                    break;
                case 96:
                    picProgressBar2.Image = Properties.Resources.frame_95_delay_0_03s;
                    break;
                case 97:
                    picProgressBar2.Image = Properties.Resources.frame_96_delay_0_03s;
                    break;
                case 98:
                    picProgressBar2.Image = Properties.Resources.frame_97_delay_0_03s;
                    break;
                case 99:
                    picProgressBar2.Image = Properties.Resources.frame_98_delay_0_03s;
                    break;
                case 100:
                    picProgressBar2.Image = Properties.Resources.frame_99_delay_0_03s;
                    break;
                case 101:
                    picProgressBar2.Image = Properties.Resources.frame_100_delay_0_03s;
                     break;
                case 102:
                    picProgressBar2.Image = Properties.Resources.frame_101_delay_0_03s;
                    break;
                case 103:
                    picProgressBar2.Image = Properties.Resources.frame_102_delay_0_03s;
                    break;
                case 104:
                    picProgressBar2.Image = Properties.Resources.frame_103_delay_0_03s;
                    break;
                case 105:
                    picProgressBar2.Image = Properties.Resources.frame_104_delay_0_03s;
                    break;
                case 106:
                    picProgressBar2.Image = Properties.Resources.frame_105_delay_0_03s;
                    break;
                case 107:
                    picProgressBar2.Image = Properties.Resources.frame_106_delay_0_03s;
                    break;
                case 108:
                    picProgressBar2.Image = Properties.Resources.frame_107_delay_0_03s;
                    break;
                case 109:
                    picProgressBar2.Image = Properties.Resources.frame_108_delay_0_03s;
                    break;
                case 110:
                    picProgressBar2.Image = Properties.Resources.frame_109_delay_0_03s;
                    break;
                case 111:
                    picProgressBar2.Image = Properties.Resources.frame_110_delay_0_03s;
                    break;
                case 112:
                    picProgressBar2.Image = Properties.Resources.frame_111_delay_0_03s;
                    break;
                case 113:
                    picProgressBar2.Image = Properties.Resources.frame_112_delay_0_03s;
                    break;
                case 114:
                    picProgressBar2.Image = Properties.Resources.frame_113_delay_0_03s;
                    break;
                case 115:
                    picProgressBar2.Image = Properties.Resources.frame_114_delay_0_03s;
                    break;
                case 116:
                    picProgressBar2.Image = Properties.Resources.frame_115_delay_0_03s;
                    break;
                case 117:
                    picProgressBar2.Image = Properties.Resources.frame_116_delay_0_03s;
                    break;
                case 118:
                    picProgressBar2.Image = Properties.Resources.frame_117_delay_0_03s;
                    break;
                case 119:
                    picProgressBar2.Image = Properties.Resources.frame_118_delay_0_03s;
                    break;
                case 120:
                    picProgressBar2.Image = Properties.Resources.frame_119_delay_0_03s;
                    break;
                case 121:
                    picProgressBar2.Image = Properties.Resources.frame_120_delay_0_03s;
                    if (ProgressBar2 == 4)
                    {
                        tmrProgress2.Stop();
                    }
                    break;
                case 122:
                    picProgressBar2.Image = Properties.Resources.frame_121_delay_0_03s;
                    break;
                case 123:
                    picProgressBar2.Image = Properties.Resources.frame_122_delay_0_03s;
                    break;
                case 124:
                    picProgressBar2.Image = Properties.Resources.frame_123_delay_0_03s;
                    break;
                case 125:
                    picProgressBar2.Image = Properties.Resources.frame_124_delay_0_03s;
                    break;
                case 126:
                    picProgressBar2.Image = Properties.Resources.frame_125_delay_0_03s;
                    break;
                case 127:
                    picProgressBar2.Image = Properties.Resources.frame_126_delay_0_03s;
                    break;
                case 128:
                    picProgressBar2.Image = Properties.Resources.frame_127_delay_0_03s;
                    break;
                case 129:
                    picProgressBar2.Image = Properties.Resources.frame_128_delay_0_03s;
                    break;
                case 130:
                    picProgressBar2.Image = Properties.Resources.frame_129_delay_0_03s;
                    break;
                case 131:
                    picProgressBar2.Image = Properties.Resources.frame_130_delay_0_03s;
                    break;
                case 132:
                    picProgressBar2.Image = Properties.Resources.frame_131_delay_0_03s;
                    break;
                case 133:
                    picProgressBar2.Image = Properties.Resources.frame_132_delay_0_03s;
                    break;
                case 134:
                    picProgressBar2.Image = Properties.Resources.frame_133_delay_0_03s;
                    break;
                case 135:
                    picProgressBar2.Image = Properties.Resources.frame_134_delay_0_03s;
                    break;
                case 136:
                    picProgressBar2.Image = Properties.Resources.frame_135_delay_0_03s;
                    break;
                case 137:
                    picProgressBar2.Image = Properties.Resources.frame_136_delay_0_03s;
                    break;
                case 138:
                    picProgressBar2.Image = Properties.Resources.frame_137_delay_0_03s;
                    break;
                case 139:
                    picProgressBar2.Image = Properties.Resources.frame_138_delay_0_03s;
                    break;
                case 140:
                    picProgressBar2.Image = Properties.Resources.frame_139_delay_0_03s;
                    break;
                case 141:
                    picProgressBar2.Image = Properties.Resources.frame_140_delay_0_03s;
                    break;
                case 142:
                    picProgressBar2.Image = Properties.Resources.frame_141_delay_0_03s;
                    break;
                case 143:
                    picProgressBar2.Image = Properties.Resources.frame_142_delay_0_03s;
                    break;
                case 144:
                    picProgressBar2.Image = Properties.Resources.frame_143_delay_0_03s;
                    break;
                case 145:
                    picProgressBar2.Image = Properties.Resources.frame_144_delay_0_03s;
                    break;
                case 146:
                    tmrProgress2.Interval = 1000;
                    picProgressBar2.Image = Properties.Resources.frame_145delay_0;
                    break;
                case 147:
                    picProgressBar2.Image = Properties.Resources.frame_146;
                    break;
                case 148:
                    tmrProgress2.Interval = 20;
                    picProgressBar2.Image = Properties.Resources.frame_147;
                    break;
                case 149:
                    picProgressBar2.Image = Properties.Resources.frame_148;
                    break;
                case 150:
                    tmrProgress2.Interval = 1000;
                    picProgressBar2.Image = Properties.Resources.frame_149;
                    break;
                case 151:
                    picProgressBar2.Image = Properties.Resources.frame_150;
                    PB2 = 0;
                    if (ProgressBar2 == 5)
                    {
                        tmrProgress2.Stop();
                    }
                    break;

            }
        }
        private void tmrProgress3_Tick(object sender, EventArgs e)
        {
            PB3++;
            switch (PB3)
            {
                case 1:
                    picProgressBar3.Image = Properties.Resources.frame_0_delay_0_03s;
                    break;
                case 2:
                    picProgressBar3.Image = Properties.Resources.frame_1_delay_0_03s;
                    break;
                case 3:
                    picProgressBar3.Image = Properties.Resources.frame_2_delay_0_03s;
                    break;
                case 4:
                    picProgressBar3.Image = Properties.Resources.frame_3_delay_0_03s;
                    break;
                case 5:
                    picProgressBar3.Image = Properties.Resources.frame_4_delay_0_03s;
                    break;
                case 6:
                    picProgressBar3.Image = Properties.Resources.frame_5_delay_0_03s;
                    break;
                case 7:
                    picProgressBar3.Image = Properties.Resources.frame_6_delay_0_03s;
                    break;
                case 8:
                    picProgressBar3.Image = Properties.Resources.frame_7_delay_0_03s;
                    break;
                case 9:
                    picProgressBar3.Image = Properties.Resources.frame_8_delay_0_03s;
                    break;
                case 10:
                    picProgressBar3.Image = Properties.Resources.frame_9_delay_0_03s;
                    break;
                case 11:
                    picProgressBar3.Image = Properties.Resources.frame_10_delay_0_03s;
                    break;
                case 12:
                    picProgressBar3.Image = Properties.Resources.frame_11_delay_0_03s;
                    break;
                case 13:
                    picProgressBar3.Image = Properties.Resources.frame_12_delay_0_03s;
                    break;
                case 14:
                    picProgressBar3.Image = Properties.Resources.frame_13_delay_0_03s;
                    break;
                case 15:
                    picProgressBar3.Image = Properties.Resources.frame_14_delay_0_03s;
                    break;
                case 16:
                    picProgressBar3.Image = Properties.Resources.frame_15_delay_0_03s;
                    break;
                case 17:
                    picProgressBar3.Image = Properties.Resources.frame_16_delay_0_03s;
                    break;
                case 18:
                    picProgressBar3.Image = Properties.Resources.frame_17_delay_0_03s;
                    break;
                case 19:
                    picProgressBar3.Image = Properties.Resources.frame_18_delay_0_03s;
                    break;
                case 20:
                    picProgressBar3.Image = Properties.Resources.frame_19_delay_0_03s;
                    break;
                case 21:
                    picProgressBar3.Image = Properties.Resources.frame_20_delay_0_03s;
                    break;
                case 22:
                    picProgressBar3.Image = Properties.Resources.frame_21_delay_0_03s;
                    break;
                case 23:
                    picProgressBar3.Image = Properties.Resources.frame_22_delay_0_03s;
                    break;
                case 24:
                    picProgressBar3.Image = Properties.Resources.frame_23_delay_0_03s;
                    break;
                case 25:
                    picProgressBar3.Image = Properties.Resources.frame_24_delay_0_03s;
                    if (ProgressBar3 == 1)
                    {
                        tmrProgress3.Stop();
                    }
                    break;
                case 26:
                    picProgressBar3.Image = Properties.Resources.frame_25_delay_0_03s;
                    break;
                case 27:
                    picProgressBar3.Image = Properties.Resources.frame_26_delay_0_03s;
                    break;
                case 28:
                    picProgressBar3.Image = Properties.Resources.frame_27_delay_0_03s;
                    break;
                case 29:
                    picProgressBar3.Image = Properties.Resources.frame_28_delay_0_03s;
                    break;
                case 30:
                    picProgressBar3.Image = Properties.Resources.frame_29_delay_0_03s;
                    break;
                case 31:
                    picProgressBar3.Image = Properties.Resources.frame_30_delay_0_03s;
                    break;
                case 32:
                    picProgressBar3.Image = Properties.Resources.frame_31_delay_0_03s;
                    break;
                case 33:
                    picProgressBar3.Image = Properties.Resources.frame_32_delay_0_03s;
                    break;
                case 34:
                    picProgressBar3.Image = Properties.Resources.frame_33_delay_0_03s;
                    break;
                case 35:
                    picProgressBar3.Image = Properties.Resources.frame_34_delay_0_03s;
                    break;
                case 36:
                    picProgressBar3.Image = Properties.Resources.frame_35_delay_0_03s;
                    break;
                case 37:
                    picProgressBar3.Image = Properties.Resources.frame_36_delay_0_03s;
                    break;
                case 38:
                    picProgressBar3.Image = Properties.Resources.frame_37_delay_0_03s;
                    break;
                case 39:
                    picProgressBar3.Image = Properties.Resources.frame_38_delay_0_03s;
                    break;
                case 40:
                    picProgressBar3.Image = Properties.Resources.frame_39_delay_0_03s;
                    break;
                case 41:
                    picProgressBar3.Image = Properties.Resources.frame_40_delay_0_03s;
                    break;
                case 42:
                    picProgressBar3.Image = Properties.Resources.frame_41_delay_0_03s;
                    break;
                case 43:
                    picProgressBar3.Image = Properties.Resources.frame_42_delay_0_03s;
                    break;
                case 44:
                    picProgressBar3.Image = Properties.Resources.frame_43_delay_0_03s;
                    break;
                case 45:
                    picProgressBar3.Image = Properties.Resources.frame_44_delay_0_03s;
                    break;
                case 46:
                    picProgressBar3.Image = Properties.Resources.frame_45_delay_0_03s;
                    break;
                case 47:
                    picProgressBar3.Image = Properties.Resources.frame_46_delay_0_03s;
                    break;
                case 48:
                    picProgressBar3.Image = Properties.Resources.frame_47_delay_0_03s;
                    break;
                case 49:
                    picProgressBar3.Image = Properties.Resources.frame_48_delay_0_03s;
                    break;
                case 50:
                    picProgressBar3.Image = Properties.Resources.frame_49_delay_0_03s;
                    if (ProgressBar3 == 2)
                    {
                        tmrProgress3.Stop();
                    }
                    break;
                case 51:
                    picProgressBar3.Image = Properties.Resources.frame_50_delay_0_03s;
                    break;
                case 52:
                    picProgressBar3.Image = Properties.Resources.frame_51_delay_0_03s;
                    break;
                case 53:
                    picProgressBar3.Image = Properties.Resources.frame_52_delay_0_03s;
                    break;
                case 54:
                    picProgressBar3.Image = Properties.Resources.frame_53_delay_0_03s;
                    break;
                case 55:
                    picProgressBar3.Image = Properties.Resources.frame_54_delay_0_03s;
                    break;
                case 56:
                    picProgressBar3.Image = Properties.Resources.frame_55_delay_0_03s;
                    break;
                case 57:
                    picProgressBar3.Image = Properties.Resources.frame_56_delay_0_03s;
                    break;
                case 58:
                    picProgressBar3.Image = Properties.Resources.frame_57_delay_0_03s;
                    break;
                case 59:
                    picProgressBar3.Image = Properties.Resources.frame_58_delay_0_03s;
                    break;
                case 60:
                    picProgressBar3.Image = Properties.Resources.frame_59_delay_0_03s;
                    break;
                case 61:
                    picProgressBar3.Image = Properties.Resources.frame_60_delay_0_03s;
                    break;
                case 62:
                    picProgressBar3.Image = Properties.Resources.frame_61_delay_0_03s;
                    break;
                case 63:
                    picProgressBar3.Image = Properties.Resources.frame_62_delay_0_03s;
                    break;
                case 64:
                    picProgressBar3.Image = Properties.Resources.frame_63_delay_0_03s;
                    break;
                case 65:
                    picProgressBar3.Image = Properties.Resources.frame_64_delay_0_03s;
                    break;
                case 66:
                    picProgressBar3.Image = Properties.Resources.frame_65_delay_0_03s;
                    break;
                case 67:
                    picProgressBar3.Image = Properties.Resources.frame_66_delay_0_03s;
                    break;
                case 68:
                    picProgressBar3.Image = Properties.Resources.frame_67_delay_0_03s;
                    break;
                case 69: //;)
                    picProgressBar3.Image = Properties.Resources.frame_68_delay_0_03s;
                    break;
                case 70:
                    picProgressBar3.Image = Properties.Resources.frame_69_delay_0_03s; //;)
                    break;
                case 71:
                    picProgressBar3.Image = Properties.Resources.frame_70_delay_0_03s;
                    break;
                case 72:
                    picProgressBar3.Image = Properties.Resources.frame_71_delay_0_03s;
                    break;
                case 73:
                    picProgressBar3.Image = Properties.Resources.frame_72_delay_0_03s;
                    break;
                case 74:
                    picProgressBar3.Image = Properties.Resources.frame_73_delay_0_03s;
                    break;
                case 75:
                    picProgressBar3.Image = Properties.Resources.frame_74_delay_0_03s;
                    if (ProgressBar3 == 3)
                    {
                        tmrProgress3.Stop();
                    }
                    break;
                case 76:
                    picProgressBar3.Image = Properties.Resources.frame_75_delay_0_03s;
                    break;
                case 77:
                    picProgressBar3.Image = Properties.Resources.frame_76_delay_0_03s;
                    break;
                case 78:
                    picProgressBar3.Image = Properties.Resources.frame_77_delay_0_03s;
                    break;
                case 79:
                    picProgressBar3.Image = Properties.Resources.frame_78_delay_0_03s;
                    break;
                case 80:
                    picProgressBar3.Image = Properties.Resources.frame_79_delay_0_03s;
                    break;
                case 81:
                    picProgressBar3.Image = Properties.Resources.frame_80_delay_0_03s;
                    break;
                case 82:
                    picProgressBar3.Image = Properties.Resources.frame_81_delay_0_03s;
                    break;
                case 83:
                    picProgressBar3.Image = Properties.Resources.frame_82_delay_0_03s;
                    break;
                case 84:
                    picProgressBar3.Image = Properties.Resources.frame_83_delay_0_03s;
                    break;
                case 85:
                    picProgressBar3.Image = Properties.Resources.frame_84_delay_0_03s;
                    break;
                case 86:
                    picProgressBar3.Image = Properties.Resources.frame_85_delay_0_03s;
                    break;
                case 87:
                    picProgressBar3.Image = Properties.Resources.frame_86_delay_0_03s;
                    break;
                case 88:
                    picProgressBar3.Image = Properties.Resources.frame_87_delay_0_03s;
                    break;
                case 89:
                    picProgressBar3.Image = Properties.Resources.frame_88_delay_0_03s;
                    break;
                case 90:
                    picProgressBar3.Image = Properties.Resources.frame_89_delay_0_03s;
                    break;
                case 91:
                    picProgressBar3.Image = Properties.Resources.frame_90_delay_0_03s;
                     break;
                case 92:
                    picProgressBar3.Image = Properties.Resources.frame_91_delay_0_03s;
                    break;
                case 93:
                    picProgressBar3.Image = Properties.Resources.frame_92_delay_0_03s;
                    break;
                case 94:
                    picProgressBar3.Image = Properties.Resources.frame_93_delay_0_03s;
                    break;
                case 95:
                    picProgressBar3.Image = Properties.Resources.frame_94_delay_0_03s;
                    break;
                case 96:
                    picProgressBar3.Image = Properties.Resources.frame_95_delay_0_03s;
                    break;
                case 97:
                    picProgressBar3.Image = Properties.Resources.frame_96_delay_0_03s;
                    break;
                case 98:
                    picProgressBar3.Image = Properties.Resources.frame_97_delay_0_03s;
                    break;
                case 99:
                    picProgressBar3.Image = Properties.Resources.frame_98_delay_0_03s;
                    break;
                case 100:
                    picProgressBar3.Image = Properties.Resources.frame_99_delay_0_03s;
                    if (ProgressBar3 == 4)
                    {
                        tmrProgress3.Stop();
                    }
                    break;
                case 101:
                    picProgressBar3.Image = Properties.Resources.frame_100_delay_0_03s;
                    break;
                case 102:
                    picProgressBar3.Image = Properties.Resources.frame_101_delay_0_03s;
                    break;
                case 103:
                    picProgressBar3.Image = Properties.Resources.frame_102_delay_0_03s;
                    break;
                case 104:
                    picProgressBar3.Image = Properties.Resources.frame_103_delay_0_03s;
                    break;
                case 105:
                    picProgressBar3.Image = Properties.Resources.frame_104_delay_0_03s;
                    break;
                case 106:
                    picProgressBar3.Image = Properties.Resources.frame_105_delay_0_03s;
                    break;
                case 107:
                    picProgressBar3.Image = Properties.Resources.frame_106_delay_0_03s;
                    break;
                case 108:
                    picProgressBar3.Image = Properties.Resources.frame_107_delay_0_03s;
                    break;
                case 109:
                    picProgressBar3.Image = Properties.Resources.frame_108_delay_0_03s;
                    break;
                case 110:
                    picProgressBar3.Image = Properties.Resources.frame_109_delay_0_03s;
                    break;
                case 111:
                    picProgressBar3.Image = Properties.Resources.frame_110_delay_0_03s;
                    break;
                case 112:
                    picProgressBar3.Image = Properties.Resources.frame_111_delay_0_03s;
                    break;
                case 113:
                    picProgressBar3.Image = Properties.Resources.frame_112_delay_0_03s;
                    break;
                case 114:
                    picProgressBar3.Image = Properties.Resources.frame_113_delay_0_03s;
                    break;
                case 115:
                    picProgressBar3.Image = Properties.Resources.frame_114_delay_0_03s;
                    break;
                case 116:
                    picProgressBar3.Image = Properties.Resources.frame_115_delay_0_03s;
                    break;
                case 117:
                    picProgressBar3.Image = Properties.Resources.frame_116_delay_0_03s;
                    break;
                case 118:
                    picProgressBar3.Image = Properties.Resources.frame_117_delay_0_03s;
                    break;
                case 119:
                    picProgressBar3.Image = Properties.Resources.frame_118_delay_0_03s;
                    break;
                case 120:
                    picProgressBar3.Image = Properties.Resources.frame_119_delay_0_03s;
                    break;
                case 121:
                    picProgressBar3.Image = Properties.Resources.frame_120_delay_0_03s;
                    break;
                case 122:
                    picProgressBar3.Image = Properties.Resources.frame_121_delay_0_03s;
                    break;
                case 123:
                    picProgressBar3.Image = Properties.Resources.frame_122_delay_0_03s;
                    break;
                case 124:
                    picProgressBar3.Image = Properties.Resources.frame_123_delay_0_03s;
                    break;
                case 125:
                    picProgressBar3.Image = Properties.Resources.frame_124_delay_0_03s;
                    if (ProgressBar3 == 5)
                    {
                        tmrProgress3.Stop();
                    }
                    break;
                case 126:
                    picProgressBar3.Image = Properties.Resources.frame_125_delay_0_03s;
                    break;
                case 127:
                    picProgressBar3.Image = Properties.Resources.frame_126_delay_0_03s;
                    break;
                case 128:
                    picProgressBar3.Image = Properties.Resources.frame_127_delay_0_03s;
                    break;
                case 129:
                    picProgressBar3.Image = Properties.Resources.frame_128_delay_0_03s;
                    break;
                case 130:
                    picProgressBar3.Image = Properties.Resources.frame_129_delay_0_03s;
                    break;
                case 131:
                    picProgressBar3.Image = Properties.Resources.frame_130_delay_0_03s;
                    break;
                case 132:
                    picProgressBar3.Image = Properties.Resources.frame_131_delay_0_03s;
                    break;
                case 133:
                    picProgressBar3.Image = Properties.Resources.frame_132_delay_0_03s;
                    break;
                case 134:
                    picProgressBar3.Image = Properties.Resources.frame_133_delay_0_03s;
                    break;
                case 135:
                    picProgressBar3.Image = Properties.Resources.frame_134_delay_0_03s;
                    break;
                case 136:
                    picProgressBar3.Image = Properties.Resources.frame_135_delay_0_03s;
                    break;
                case 137:
                    picProgressBar3.Image = Properties.Resources.frame_136_delay_0_03s;
                    break;
                case 138:
                    picProgressBar3.Image = Properties.Resources.frame_137_delay_0_03s;
                    break;
                case 139:
                    picProgressBar3.Image = Properties.Resources.frame_138_delay_0_03s;
                    break;
                case 140:
                    picProgressBar3.Image = Properties.Resources.frame_139_delay_0_03s;
                    break;
                case 141:
                    picProgressBar3.Image = Properties.Resources.frame_140_delay_0_03s;
                    break;
                case 142:
                    picProgressBar3.Image = Properties.Resources.frame_141_delay_0_03s;
                    break;
                case 143:
                    picProgressBar3.Image = Properties.Resources.frame_142_delay_0_03s;
                    break;
                case 144:
                    picProgressBar3.Image = Properties.Resources.frame_143_delay_0_03s;
                    break;
                case 145:
                    picProgressBar3.Image = Properties.Resources.frame_144_delay_0_03s;
                    break;
                case 146:
                    tmrProgress3.Interval = 1000;
                    picProgressBar3.Image = Properties.Resources.frame_145delay_0;
                    break;
                case 147:
                    picProgressBar3.Image = Properties.Resources.frame_146;
                    break;
                case 148:
                    tmrProgress3.Interval = 20;
                    picProgressBar3.Image = Properties.Resources.frame_147;
                    break;
                case 149:
                    picProgressBar3.Image = Properties.Resources.frame_148;
                    break;
                case 150:
                    tmrProgress3.Interval = 1000;
                    picProgressBar3.Image = Properties.Resources.frame_149;
                    break;
                case 151:
                    picProgressBar3.Image = Properties.Resources.frame_150;
                    PB3 = 0;
                    if (ProgressBar3 == 6)
                    {
                        tmrProgress3.Stop();
                    }
                    break;

            }
        }

        private void tmrProgress4_Tick(object sender, EventArgs e)
        {
            PB4++;
            switch (PB4)
            {
                case 1:
                    picProgressBar4.Image = Properties.Resources.frame_0_delay_0_03s;
                    break;
                case 2:
                    picProgressBar4.Image = Properties.Resources.frame_1_delay_0_03s;
                    break;
                case 3:
                    picProgressBar4.Image = Properties.Resources.frame_2_delay_0_03s;
                    break;
                case 4:
                    picProgressBar4.Image = Properties.Resources.frame_3_delay_0_03s;
                    break;
                case 5:
                    picProgressBar4.Image = Properties.Resources.frame_4_delay_0_03s;
                    break;
                case 6:
                    picProgressBar4.Image = Properties.Resources.frame_5_delay_0_03s;
                    break;
                case 7:
                    picProgressBar4.Image = Properties.Resources.frame_6_delay_0_03s;
                    break;
                case 8:
                    picProgressBar4.Image = Properties.Resources.frame_7_delay_0_03s;
                    break;
                case 9:
                    picProgressBar4.Image = Properties.Resources.frame_8_delay_0_03s;
                    break;
                case 10:
                    picProgressBar4.Image = Properties.Resources.frame_9_delay_0_03s;
                    break;
                case 11:
                    picProgressBar4.Image = Properties.Resources.frame_10_delay_0_03s;
                    break;
                case 12:
                    picProgressBar4.Image = Properties.Resources.frame_11_delay_0_03s;
                    break;
                case 13:
                    picProgressBar4.Image = Properties.Resources.frame_12_delay_0_03s;
                    break;
                case 14:
                    picProgressBar4.Image = Properties.Resources.frame_13_delay_0_03s;
                    break;
                case 15:
                    picProgressBar4.Image = Properties.Resources.frame_14_delay_0_03s;
                    break;
                case 16:
                    picProgressBar4.Image = Properties.Resources.frame_15_delay_0_03s;
                    break;
                case 17:
                    picProgressBar4.Image = Properties.Resources.frame_16_delay_0_03s;
                    break;
                case 18:
                    picProgressBar4.Image = Properties.Resources.frame_17_delay_0_03s;
                    break;
                case 19:
                    picProgressBar4.Image = Properties.Resources.frame_18_delay_0_03s;
                    break;
                case 20:
                    picProgressBar4.Image = Properties.Resources.frame_19_delay_0_03s;
                    break;
                case 21:
                    picProgressBar4.Image = Properties.Resources.frame_20_delay_0_03s;
                    break;
                case 22:
                    picProgressBar4.Image = Properties.Resources.frame_21_delay_0_03s;
                    break;
                case 23:
                    picProgressBar4.Image = Properties.Resources.frame_22_delay_0_03s;
                    break;
                case 24:
                    picProgressBar4.Image = Properties.Resources.frame_23_delay_0_03s;
                    break;
                case 25:
                    picProgressBar4.Image = Properties.Resources.frame_24_delay_0_03s;
                    if (ProgressBar4 == 1)
                    {
                        tmrProgress4.Stop();
                    }
                    break;
                case 26:
                    picProgressBar4.Image = Properties.Resources.frame_25_delay_0_03s;
                    break;
                case 27:
                    picProgressBar4.Image = Properties.Resources.frame_26_delay_0_03s;
                    break;
                case 28:
                    picProgressBar4.Image = Properties.Resources.frame_27_delay_0_03s;
                    break;
                case 29:
                    picProgressBar4.Image = Properties.Resources.frame_28_delay_0_03s;
                    break;
                case 30:
                    picProgressBar4.Image = Properties.Resources.frame_29_delay_0_03s;
                    break;
                case 31:
                    picProgressBar4.Image = Properties.Resources.frame_30_delay_0_03s;
                    break;
                case 32:
                    picProgressBar4.Image = Properties.Resources.frame_31_delay_0_03s;
                    break;
                case 33:
                    picProgressBar4.Image = Properties.Resources.frame_32_delay_0_03s;
                    break;
                case 34:
                    picProgressBar4.Image = Properties.Resources.frame_33_delay_0_03s;
                    break;
                case 35:
                    picProgressBar4.Image = Properties.Resources.frame_34_delay_0_03s;
                    break;
                case 36:
                    picProgressBar4.Image = Properties.Resources.frame_35_delay_0_03s;
                    break;
                case 37:
                    picProgressBar4.Image = Properties.Resources.frame_36_delay_0_03s;
                    break;
                case 38:
                    picProgressBar4.Image = Properties.Resources.frame_37_delay_0_03s;
                    break;
                case 39:
                    picProgressBar4.Image = Properties.Resources.frame_38_delay_0_03s;
                    break;
                case 40:
                    picProgressBar4.Image = Properties.Resources.frame_39_delay_0_03s;
                    break;
                case 41:
                    picProgressBar4.Image = Properties.Resources.frame_40_delay_0_03s;
                    break;
                case 42:
                    picProgressBar4.Image = Properties.Resources.frame_41_delay_0_03s;
                    break;
                case 43:
                    picProgressBar4.Image = Properties.Resources.frame_42_delay_0_03s;
                    break;
                case 44:
                    picProgressBar4.Image = Properties.Resources.frame_43_delay_0_03s;
                    break;
                case 45:
                    picProgressBar4.Image = Properties.Resources.frame_44_delay_0_03s;
                    break;
                case 46:
                    picProgressBar4.Image = Properties.Resources.frame_45_delay_0_03s;
                    break;
                case 47:
                    picProgressBar4.Image = Properties.Resources.frame_46_delay_0_03s;
                    break;
                case 48:
                    picProgressBar4.Image = Properties.Resources.frame_47_delay_0_03s;
                    break;
                case 49:
                    picProgressBar4.Image = Properties.Resources.frame_48_delay_0_03s;
                    break;
                case 50:
                    picProgressBar4.Image = Properties.Resources.frame_49_delay_0_03s;
                    if (ProgressBar4 == 2)
                    {
                        tmrProgress4.Stop();
                    }
                    break;
                case 51:
                    picProgressBar4.Image = Properties.Resources.frame_50_delay_0_03s;
                    break;
                case 52:
                    picProgressBar4.Image = Properties.Resources.frame_51_delay_0_03s;
                    break;
                case 53:
                    picProgressBar4.Image = Properties.Resources.frame_52_delay_0_03s;
                    break;
                case 54:
                    picProgressBar4.Image = Properties.Resources.frame_53_delay_0_03s;
                    break;
                case 55:
                    picProgressBar4.Image = Properties.Resources.frame_54_delay_0_03s;
                    break;
                case 56:
                    picProgressBar4.Image = Properties.Resources.frame_55_delay_0_03s;
                    break;
                case 57:
                    picProgressBar4.Image = Properties.Resources.frame_56_delay_0_03s;
                    break;
                case 58:
                    picProgressBar4.Image = Properties.Resources.frame_57_delay_0_03s;
                    break;
                case 59:
                    picProgressBar4.Image = Properties.Resources.frame_58_delay_0_03s;
                    break;
                case 60:
                    picProgressBar4.Image = Properties.Resources.frame_59_delay_0_03s;
                    break;
                case 61:
                    picProgressBar4.Image = Properties.Resources.frame_60_delay_0_03s;
                    break;
                case 62:
                    picProgressBar4.Image = Properties.Resources.frame_61_delay_0_03s;
                    break;
                case 63:
                    picProgressBar4.Image = Properties.Resources.frame_62_delay_0_03s;
                    break;
                case 64:
                    picProgressBar4.Image = Properties.Resources.frame_63_delay_0_03s;
                    break;
                case 65:
                    picProgressBar4.Image = Properties.Resources.frame_64_delay_0_03s;
                    break;
                case 66:
                    picProgressBar4.Image = Properties.Resources.frame_65_delay_0_03s;
                    break;
                case 67:
                    picProgressBar4.Image = Properties.Resources.frame_66_delay_0_03s;
                    break;
                case 68:
                    picProgressBar4.Image = Properties.Resources.frame_67_delay_0_03s;
                    break;
                case 69: //;)
                    picProgressBar4.Image = Properties.Resources.frame_68_delay_0_03s;
                    break;
                case 70:
                    picProgressBar4.Image = Properties.Resources.frame_69_delay_0_03s; //;)
                    break;
                case 71:
                    picProgressBar4.Image = Properties.Resources.frame_70_delay_0_03s;
                    break;
                case 72:
                    picProgressBar4.Image = Properties.Resources.frame_71_delay_0_03s;
                    break;
                case 73:
                    picProgressBar4.Image = Properties.Resources.frame_72_delay_0_03s;
                    break;
                case 74:
                    picProgressBar4.Image = Properties.Resources.frame_73_delay_0_03s;
                    break;
                case 75:
                    picProgressBar4.Image = Properties.Resources.frame_74_delay_0_03s;
                    if (ProgressBar4 == 3)
                    {
                        tmrProgress4.Stop();
                    }
                    break;
                case 76:
                    picProgressBar4.Image = Properties.Resources.frame_75_delay_0_03s;
                    break;
                case 77:
                    picProgressBar4.Image = Properties.Resources.frame_76_delay_0_03s;
                    break;
                case 78:
                    picProgressBar4.Image = Properties.Resources.frame_77_delay_0_03s;
                    break;
                case 79:
                    picProgressBar4.Image = Properties.Resources.frame_78_delay_0_03s;
                    break;
                case 80:
                    picProgressBar4.Image = Properties.Resources.frame_79_delay_0_03s;
                    break;
                case 81:
                    picProgressBar4.Image = Properties.Resources.frame_80_delay_0_03s;
                    break;
                case 82:
                    picProgressBar4.Image = Properties.Resources.frame_81_delay_0_03s;
                    break;
                case 83:
                    picProgressBar4.Image = Properties.Resources.frame_82_delay_0_03s;
                    break;
                case 84:
                    picProgressBar4.Image = Properties.Resources.frame_83_delay_0_03s;
                    break;
                case 85:
                    picProgressBar4.Image = Properties.Resources.frame_84_delay_0_03s;
                    break;
                case 86:
                    picProgressBar4.Image = Properties.Resources.frame_85_delay_0_03s;
                    break;
                case 87:
                    picProgressBar4.Image = Properties.Resources.frame_86_delay_0_03s;
                    break;
                case 88:
                    picProgressBar4.Image = Properties.Resources.frame_87_delay_0_03s;
                    break;
                case 89:
                    picProgressBar4.Image = Properties.Resources.frame_88_delay_0_03s;
                    break;
                case 90:
                    picProgressBar4.Image = Properties.Resources.frame_89_delay_0_03s;
                    break;
                case 91:
                    picProgressBar4.Image = Properties.Resources.frame_90_delay_0_03s;
                    break;
                case 92:
                    picProgressBar4.Image = Properties.Resources.frame_91_delay_0_03s;
                    break;
                case 93:
                    picProgressBar4.Image = Properties.Resources.frame_92_delay_0_03s;
                    break;
                case 94:
                    picProgressBar4.Image = Properties.Resources.frame_93_delay_0_03s;
                    break;
                case 95:
                    picProgressBar4.Image = Properties.Resources.frame_94_delay_0_03s;
                    break;
                case 96:
                    picProgressBar4.Image = Properties.Resources.frame_95_delay_0_03s;
                    break;
                case 97:
                    picProgressBar4.Image = Properties.Resources.frame_96_delay_0_03s;
                    break;
                case 98:
                    picProgressBar4.Image = Properties.Resources.frame_97_delay_0_03s;
                    break;
                case 99:
                    picProgressBar4.Image = Properties.Resources.frame_98_delay_0_03s;
                    break;
                case 100:
                    picProgressBar4.Image = Properties.Resources.frame_99_delay_0_03s;
                    if (ProgressBar4 == 4)
                    {
                        tmrProgress4.Stop();
                    }
                    break;
                case 101:
                    picProgressBar4.Image = Properties.Resources.frame_100_delay_0_03s;
                    break;
                case 102:
                    picProgressBar4.Image = Properties.Resources.frame_101_delay_0_03s;
                    break;
                case 103:
                    picProgressBar4.Image = Properties.Resources.frame_102_delay_0_03s;
                    break;
                case 104:
                    picProgressBar4.Image = Properties.Resources.frame_103_delay_0_03s;
                    break;
                case 105:
                    picProgressBar4.Image = Properties.Resources.frame_104_delay_0_03s;
                    break;
                case 106:
                    picProgressBar4.Image = Properties.Resources.frame_105_delay_0_03s;
                    break;
                case 107:
                    picProgressBar4.Image = Properties.Resources.frame_106_delay_0_03s;
                    break;
                case 108:
                    picProgressBar4.Image = Properties.Resources.frame_107_delay_0_03s;
                    break;
                case 109:
                    picProgressBar4.Image = Properties.Resources.frame_108_delay_0_03s;
                    break;
                case 110:
                    picProgressBar4.Image = Properties.Resources.frame_109_delay_0_03s;
                    break;
                case 111:
                    picProgressBar4.Image = Properties.Resources.frame_110_delay_0_03s;
                    break;
                case 112:
                    picProgressBar4.Image = Properties.Resources.frame_111_delay_0_03s;
                    break;
                case 113:
                    picProgressBar4.Image = Properties.Resources.frame_112_delay_0_03s;
                    break;
                case 114:
                    picProgressBar4.Image = Properties.Resources.frame_113_delay_0_03s;
                    break;
                case 115:
                    picProgressBar4.Image = Properties.Resources.frame_114_delay_0_03s;
                    break;
                case 116:
                    picProgressBar4.Image = Properties.Resources.frame_115_delay_0_03s;
                    break;
                case 117:
                    picProgressBar4.Image = Properties.Resources.frame_116_delay_0_03s;
                    break;
                case 118:
                    picProgressBar4.Image = Properties.Resources.frame_117_delay_0_03s;
                    break;
                case 119:
                    picProgressBar4.Image = Properties.Resources.frame_118_delay_0_03s;
                    break;
                case 120:
                    picProgressBar4.Image = Properties.Resources.frame_119_delay_0_03s;
                    break;
                case 121:
                    picProgressBar4.Image = Properties.Resources.frame_120_delay_0_03s;
                    break;
                case 122:
                    picProgressBar4.Image = Properties.Resources.frame_121_delay_0_03s;
                    break;
                case 123:
                    picProgressBar4.Image = Properties.Resources.frame_122_delay_0_03s;
                    break;
                case 124:
                    picProgressBar4.Image = Properties.Resources.frame_123_delay_0_03s;
                    break;
                case 125:
                    picProgressBar4.Image = Properties.Resources.frame_124_delay_0_03s;
                    if (ProgressBar4 == 5)
                    {
                        tmrProgress4.Stop();
                    }
                    break;
                case 126:
                    picProgressBar4.Image = Properties.Resources.frame_125_delay_0_03s;
                    break;
                case 127:
                    picProgressBar4.Image = Properties.Resources.frame_126_delay_0_03s;
                    break;
                case 128:
                    picProgressBar4.Image = Properties.Resources.frame_127_delay_0_03s;
                    break;
                case 129:
                    picProgressBar4.Image = Properties.Resources.frame_128_delay_0_03s;
                    break;
                case 130:
                    picProgressBar4.Image = Properties.Resources.frame_129_delay_0_03s;
                    break;
                case 131:
                    picProgressBar4.Image = Properties.Resources.frame_130_delay_0_03s;
                    break;
                case 132:
                    picProgressBar4.Image = Properties.Resources.frame_131_delay_0_03s;
                    break;
                case 133:
                    picProgressBar4.Image = Properties.Resources.frame_132_delay_0_03s;
                    break;
                case 134:
                    picProgressBar4.Image = Properties.Resources.frame_133_delay_0_03s;
                    break;
                case 135:
                    picProgressBar4.Image = Properties.Resources.frame_134_delay_0_03s;
                    break;
                case 136:
                    picProgressBar4.Image = Properties.Resources.frame_135_delay_0_03s;
                    break;
                case 137:
                    picProgressBar4.Image = Properties.Resources.frame_136_delay_0_03s;
                    break;
                case 138:
                    picProgressBar4.Image = Properties.Resources.frame_137_delay_0_03s;
                    break;
                case 139:
                    picProgressBar4.Image = Properties.Resources.frame_138_delay_0_03s;
                    break;
                case 140:
                    picProgressBar4.Image = Properties.Resources.frame_139_delay_0_03s;
                    break;
                case 141:
                    picProgressBar4.Image = Properties.Resources.frame_140_delay_0_03s;
                    break;
                case 142:
                    picProgressBar4.Image = Properties.Resources.frame_141_delay_0_03s;
                    break;
                case 143:
                    picProgressBar4.Image = Properties.Resources.frame_142_delay_0_03s;
                    break;
                case 144:
                    picProgressBar4.Image = Properties.Resources.frame_143_delay_0_03s;
                    break;
                case 145:
                    picProgressBar4.Image = Properties.Resources.frame_144_delay_0_03s;
                    break;
                case 146:
                    tmrProgress4.Interval = 1000;
                    picProgressBar4.Image = Properties.Resources.frame_145delay_0;
                    break;
                case 147:
                    picProgressBar4.Image = Properties.Resources.frame_146;
                    break;
                case 148:
                    tmrProgress4.Interval = 20;
                    picProgressBar4.Image = Properties.Resources.frame_147;
                    break;
                case 149:
                    picProgressBar4.Image = Properties.Resources.frame_148;
                    break;
                case 150:
                    tmrProgress4.Interval = 1000;
                    picProgressBar4.Image = Properties.Resources.frame_149;
                    break;
                case 151:
                    picProgressBar4.Image = Properties.Resources.frame_150;
                    PB3 = 0;
                    if (ProgressBar4 == 6)
                    {
                        tmrProgress4.Stop();
                    }
                    break;

            }
        }
    }

}
