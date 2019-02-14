/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - THE DANCE
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : ACTS AS STORY MODE/ STORY TELLER IN PROGRAM
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
    public partial class frmParty : Form
    {
        public frmParty()
        {
            InitializeComponent();
        }

        //Global Declerations
        Random rnd = new Random();
        int Person1;
        int Person2;
        int Person3;
        int Person4;
        int Person5;
        int font;
        int K;
        int AnimateBack;
        int AnimateBack2;
        bool Animate;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void tmrBackground_Tick(object sender, EventArgs e)
        {
            if (Animate == true)
            {  
                // when this timer starts, random colours are generated for the background of the form
                int red;
                int blue;
                int green;

                red = rnd.Next(0, 256);
                blue = rnd.Next(0, 256);
                green = rnd.Next(0, 256);
                this.BackColor = Color.FromArgb(red, green, blue);
                lblbEmptySpaceeeee.BackColor = Color.FromArgb(red, green, blue);
            }
            else
            {       // IF BOOL ANIMATE IS FALSE 
                this.BackColor = Color.White;

                AnimateBack++;
                switch (AnimateBack)
                {
                    case 1:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_000;
                        break;
                    case 2:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_001;
                        break;
                    case 3:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_002;
                        break;
                    case 4:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_003;
                        break;
                    case 5:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_004;
                        break;
                    case 6:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_005;
                        break;
                    case 7:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_006;
                        break;
                    case 8:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_007;
                        break;
                    case 9:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_008;
                        break;
                    case 10:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_009;
                        break;
                    case 11:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_010;
                        break;
                    case 12:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_011;
                        break;
                    case 13:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_012;
                        break;
                    case 14:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_013;
                        break;
                    case 15:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_014;
                        break;
                    case 16:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_015;
                        break;
                    case 17:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_016;
                        break;
                    case 18:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_017;
                        break;
                    case 19:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_018;
                        break;
                    case 20:
                        this.BackgroundImage = Properties.Resources._5517ca6c23_gif_019;
                      
                        AnimateBack = 0; // RESET
                      
                        tmrBackground.Stop();
                        tmrHeart.Start();
                        break;



                }
            }
        }

        private void tmrPerson1_Tick(object sender, EventArgs e)
        {
            Person1++;       // ANIMATION FOR PERSON
            switch (Person1)
            {

                case 1:
                    picPerson1.Image = Properties.Resources._143335288364470;
                    break;
                case 2:
                    picPerson1.Image = Properties.Resources._143335288364470__1_;
                    break;
                case 3:
                    picPerson1.Image = Properties.Resources._143335288364470__2_;
                    break;
                case 4:
                    picPerson1.Image = Properties.Resources._143335288364470__3_;
                    break;
                case 5:
                    picPerson1.Image = Properties.Resources._143335288364470__4_;
                    Person1 = 0;
                    break;

            }
        }

        private void frmParty_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Here is a brief introduction to the story", "The dance");
            // These Timers are for the dancers
            Animate = true;
            tmrPerson1.Start();
            tmrBackground.Start();
            tmrPerson2.Start();
            tmrPerson3.Start();
            tmrPerson4.Start();
            tmrPerson5.Enabled = true;
           
            tmrGameLoad.Start();
            
        }

        private void tmrPerson2_Tick(object sender, EventArgs e)
        {
            // when each timer ticks, this happens each time
            // differnet pictures are loaded according to a specific time interval
            Person2++;
            switch (Person2)
            {

                case 1:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_000;
                    break;
                case 2:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_001;
                    break;
                case 3:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_002;
                    break;
                case 4:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_003;
                    break;
                case 5:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_004;
                    break;
                case 6:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_005;
                    break;
                case 7:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_006;
                    break;
                case 8:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_007;
                    break;
                case 9:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_008;
                    break;
                case 10:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_009;
                    break;
                case 11:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_010;
                    break;
                case 12:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_011;
                    break;
                case 13:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_012;
                    break;
                case 14:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_013;
                    break;
                case 15:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_014;
                    break;
                case 16:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_015;
                    break;
                case 17:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_016;
                    break;
                case 18:
                    picPerson2.Image = Properties.Resources.deb220911e_gif_017;
                    // resets variable for animation so it returns to case 1 and restarts till ... whenever timer is stopped
                    Person2 = 0;
                    break;


            }
        }

        private void tmrPerson3_Tick(object sender, EventArgs e)
        {
            Person3++;
            switch (Person3)
            {

                case 1:
                    picPerson3.Image = Properties.Resources.dance1;

                    break;
                case 2:
                    picPerson3.Image = Properties.Resources.Dance2;

                    break;
                case 3:
                    picPerson3.Image = Properties.Resources.dance3;

                    break;
                case 4:
                    picPerson3.Image = Properties.Resources.damce5;

                    break;
                case 5:
                    picPerson3.Image = Properties.Resources.dance4;

                    Person3 = 0;
                    break;

            }
        }

        private void frmParty_FormClosing(object sender, FormClosingEventArgs e)
        {
           //REDIRECT TO START FORM AND CLOSE PRESENT FORM
            if (frmCPT.gameover == true)
            {
                Application.Exit();
            }
            else
            {

                new frmCPT().Show();
            }




        }

        private void tmrPerson4_Tick(object sender, EventArgs e)
        {
            Person4++;
            switch (Person4)
            {

                case 1:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_000;
                    picPerson5.Image = Properties.Resources.guy1;
                    break;
                case 2:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_001;
                    picPerson5.Image = Properties.Resources.guy2;
                    break;
                case 3:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_002;
                    picPerson5.Image = Properties.Resources.guy3;
                    break;
                case 4:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_003;
                    picPerson5.Image = Properties.Resources.guy4;
                    break;
                case 5:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_004;
                    picPerson5.Image = Properties.Resources.guy5;
                    break;
                case 6:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_005;
                    picPerson5.Image = Properties.Resources.guy6;
                    break;
                case 7:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_006;
                    picPerson5.Image = Properties.Resources.guy7;
                    break;
                case 8:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_007;
                    picPerson5.Image = Properties.Resources.guy8;
                    break;
                case 9:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_008;
                    picPerson5.Image = Properties.Resources.guy9;
                    break;
                case 10:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_009;
                    picPerson5.Image = Properties.Resources.guy10;
                    break;
                case 11:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_010;
                    picPerson5.Image = Properties.Resources.guy11;
                    break;
                case 12:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_011;
                    picPerson5.Image = Properties.Resources.guy12;
                    break;
                case 13:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_012;
                    picPerson5.Image = Properties.Resources.guy13;
                    break;
                case 14:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_013;
                    picPerson5.Image = Properties.Resources.guy14;
                    break;
                case 15:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_014;
                    picPerson5.Image = Properties.Resources.guy15;
                    break;
                case 16:
                    picPerson4.Image = Properties.Resources._8ac05f82e8_gif_015;
                    picPerson5.Image = Properties.Resources.guy16;
                    Person4 = 0;

                    break;
            }
        }

        private void tmrGameLoad_Tick(object sender, EventArgs e)
        {
            // story teller
            //changes label text at different time lengths 

            lblHolUp.Visible = true;
            // to determine these time lengths
            font = font + 10;
            if (font == 250)
            {
                lblHolUp.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                lblHolUp.Text = "People are dancing...";
            }

            else if (font == 500)
            {
                lblHolUp.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                lblHolUp.Text = "The party goes on...";
            }
            else if (font == 750)
            {
                //simply changing the font style and size
                lblHolUp.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
                lblHolUp.Text = "Meanwhile Tyrone walks \r\n up to ";
                lblName.Visible = true;
            }
            else if (font == 1000)
            {
                // when timer reaches this point,  everything is cleared for next action
                lblHolUp.Text = null;
                lblHolUp.BackColor = Color.Transparent;

                picPerson1.Visible = false;
                picPerson2.Visible = false;
                picPerson3.Visible = false;
                picPerson4.Visible = false;
                picPerson5.Visible = false;
                picPerson6.Visible = false;
                picPerson7.Visible = false;

                tmrBackground.Stop();
                tmrPerson1.Stop();
                tmrPerson2.Stop();
                tmrPerson3.Stop();
                tmrPerson4.Stop();
                tmrPerson5.Enabled = false;

                this.BackgroundImageLayout = ImageLayout.Center;
                this.BackgroundImage = Properties.Resources._1;

                lblName.Visible = false;
                lblHolUp.Visible = false;



                lblbEmptySpaceeeee.Visible = false;

            }
            else if (font == 1250)
            { //Next actin begins
                picPerson4.Image = Properties.Resources.chat_bubble;
                picPerson4.Location = new Point(11, 12);
                picPerson4.Size = new Size(235, 178);
                picPerson4.BackColor = Color.Transparent;
                picPerson4.Visible = true;

                lblName.Location = new Point(52, 24);
                lblName.BackColor = Color.White;
                lblName.Text = "Hi I'm \r\n Tyrone";
                lblName.Visible = true;
                lblName.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }


            else if (font == 1500)
            {
                picPerson7.Image = Properties.Resources._4ibzgn5ig;
                picPerson7.Location = new Point(546, 2);
                picPerson7.Size = new Size(264, 192);
                picPerson7.BackColor = Color.Transparent;
                picPerson7.Visible = true;

                lblHolUp.Location = new Point(582, 18);
                lblHolUp.BackColor = Color.White;
                lblHolUp.Text = "Hello I'm \r\n Sharkeisha";
                lblHolUp.Visible = true;
                lblHolUp.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);


            }
            else if (font == 1750)
            {

                picPerson4.Image = Properties.Resources.chat_bubble;
                picPerson4.Location = new Point(11, 12);
                picPerson4.Size = new Size(235, 178);
                picPerson4.BackColor = Color.Transparent;
                picPerson4.Visible = true;

                lblName.Location = new Point(52, 24);
                lblName.BackColor = Color.White;
                lblName.Text = "...great party huh?";
                lblName.Visible = true;
                lblName.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }


            else if (font == 2000)
            {
                picPerson7.Image = Properties.Resources._4ibzgn5ig;
                picPerson7.Location = new Point(546, 2);
                picPerson7.Size = new Size(264, 192);
                picPerson7.BackColor = Color.Transparent;
                picPerson7.Visible = true;

                lblHolUp.Location = new Point(582, 18);
                lblHolUp.BackColor = Color.White;
                lblHolUp.Text = "...yeah its pretty nice";
                lblHolUp.Visible = true;
                lblHolUp.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);


            }
            else if (font == 2250)
            {
                this.BackgroundImage = Properties.Resources._2;
                picPerson4.Image = Properties.Resources.chat_bubble;
                picPerson4.Location = new Point(05, 12);
                picPerson4.Size = new Size(340, 250);
                picPerson4.BackColor = Color.Transparent;
                picPerson4.Visible = true;

                lblName.Location = new Point(70, 24);
                lblName.BackColor = Color.White;
                lblName.Text = "...I like basketball,\r\n hockey, action movies, \r\n comedies people don't get \r\n this but i hate\r\n chicken... weird right? ";
                lblName.Visible = true;
                lblName.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                // "\r\n" moves whatever is ext to a line lower.. makes it neat and more realistic
            }


            else if (font == 2500)
            {
                picPerson7.Image = Properties.Resources._4ibzgn5ig;
                picPerson7.Location = new Point(546, 2);
                picPerson7.Size = new Size(264, 192);
                picPerson7.BackColor = Color.Transparent;
                picPerson7.Visible = true;

                lblHolUp.Location = new Point(582, 18);
                lblHolUp.BackColor = Color.White;
                lblHolUp.Text = "...HAHA ME TOO! \r\n Its totally not \r\n weird!!";
                lblHolUp.Visible = true;
                lblHolUp.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);


            }
            else if (font == 2750)
            {

                picPerson4.Image = Properties.Resources.chat_bubble;
                picPerson4.Location = new Point(11, 12);
                picPerson4.Size = new Size(235, 178);
                picPerson4.BackColor = Color.Transparent;
                picPerson4.Visible = true;

                lblName.Location = new Point(52, 24);
                lblName.BackColor = Color.White;
                lblName.Text = "...This has been \r\n nice";
                lblName.Visible = true;
                lblName.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }


            else if (font == 3000)
            {
                picPerson7.Image = Properties.Resources._4ibzgn5ig;
                picPerson7.Location = new Point(546, 2);
                picPerson7.Size = new Size(264, 192);
                picPerson7.BackColor = Color.Transparent;
                picPerson7.Visible = true;

                lblHolUp.Location = new Point(582, 18);
                lblHolUp.BackColor = Color.White;
                lblHolUp.Text = "...yeah it has";
                lblHolUp.Visible = true;
                lblHolUp.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);


            }

            else if (font == 3250)
            {
                this.BackgroundImage = Properties.Resources._3;
                picPerson4.Image = Properties.Resources.chat_bubble;
                picPerson4.Location = new Point(11, 12);
                picPerson4.Size = new Size(235, 178);
                picPerson4.BackColor = Color.Transparent;
                picPerson4.Visible = true;

                lblName.Location = new Point(52, 24);
                lblName.BackColor = Color.White;
                lblName.Text = "...hey, you want to \r\n go out and have \r\n some real fun?";
                lblName.Visible = true;
                lblName.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            }


            else if (font == 3500)
            {
                picPerson7.Image = Properties.Resources._4ibzgn5ig;
                picPerson7.Location = new Point(546, 2);
                picPerson7.Size = new Size(264, 192);
                picPerson7.BackColor = Color.Transparent;
                picPerson7.Visible = true;

                lblHolUp.Location = new Point(582, 18);
                lblHolUp.BackColor = Color.White;
                lblHolUp.Text = "...yeah sure";
                lblHolUp.Visible = true;
                lblHolUp.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);


            }

            else if (font == 3800)
            {
                Animate = false;
                tmrBackground.Start();

                this.BackColor = Color.White;
                this.BackgroundImageLayout = ImageLayout.Center;
                this.BackgroundImage = Properties.Resources._5517ca6c23_gif_000;

                lblHolUp.Text = null;
                lblName.Text = null;
                picPerson4.Visible = false;
                picPerson7.Visible = false;

                lblName.Visible = false;
                lblHolUp.Visible = false;

                tmrGameLoad.Enabled = false;
                font = 0;


            }
            
        }

        void Reset()            // RESETS PROGRAM TO START STATE SO ACTIONS CAN BE REPERFORMED IS NECESARRY
        {
           this.BackgroundImage = null;
           tmrGameLoad.Enabled = true; 
            MessageBox.Show("Here is a brief introduction to the story", "The dance");

            Animate = true;
            tmrPerson1.Start();
            tmrBackground.Start();
            tmrPerson2.Start();
            tmrPerson3.Start();
            tmrPerson4.Start();
            tmrPerson5.Enabled = true;
            tmrEnd.Stop();
           

            
          
           
          
            picPerson1.Visible = true;
            picPerson2.Visible = true;
            picPerson3.Visible = true;
            picPerson4.Visible = true;
            picPerson5.Visible = true;
            picPerson6.Visible = true;
            picPerson7.Visible = true;

            picPerson4.Location = new Point(11, 395);
            picPerson4.Size = new Size(106, 156);
            picPerson7.Location = new Point(320, 12);
            picPerson7.Size = new Size(184, 151);
            

            lblHolUp.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            lblHolUp.Text = "At the party...";
            lblHolUp.Visible = true;
            lblHolUp.Location = new Point(8, 47);
            lblHolUp.Size = new Size(118, 20);
            lblHolUp.BackColor = Color.Transparent;

          

            lblName.Text = "Sharkeisha";
            lblName.Visible = false;
            lblName.Location =  new Point (4, 110);
            lblName.Size = new Size(201, 39);
            lblName.Font = new Font("Microsoft Sans Serif", 26, FontStyle.Bold);
            lblName.BackColor = Color.Transparent;


        }



        private void tmrPerson5_Tick(object sender, EventArgs e)
        {

            Person5++;
            switch (Person5)
            {

                case 1:
                    picPerson6.Image = Properties.Resources.d719ff8f88_gif_000;
                    picPerson7.Image = Properties.Resources.fd92cb23fd_gif_000;
                    break;
                case 2:
                    picPerson6.Image = Properties.Resources.d719ff8f88_gif_001;
                    picPerson7.Image = Properties.Resources.fd92cb23fd_gif_001;
                    break;
                case 3:
                    picPerson6.Image = Properties.Resources.d719ff8f88_gif_002;
                    picPerson7.Image = Properties.Resources.fd92cb23fd_gif_002;
                    break;
                case 4:
                    picPerson6.Image = Properties.Resources.d719ff8f88_gif_003;
                    picPerson7.Image = Properties.Resources.fd92cb23fd_gif_003;
                    break;
                case 5:
                    picPerson6.Image = Properties.Resources.d719ff8f88_gif_004;
                    picPerson7.Image = Properties.Resources.fd92cb23fd_gif_004;
                    break;
                case 6:
                    picPerson6.Image = Properties.Resources.d719ff8f88_gif_005;
                    picPerson7.Image = Properties.Resources.fd92cb23fd_gif_005;

                    Person5 = 0;
                    break;
            }
        }

        private void tmrHeart_Tick(object sender, EventArgs e)
        {
            AnimateBack2++;  // ANIMATION FOR FORM BACKGROUND
            switch (AnimateBack2)
            {
                case 1:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_000;
                    break;
                case 2:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_001;
                    break;
                case 3:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_002;
                    break;
                case 4:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_003;
                    break;
                case 5:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_004;
                    break;
                case 6:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_005;
                    break;
                case 7:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_006;
                    break;
                case 8:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_007;
                    break;
                case 9:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_008;
                    break;
                case 10:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_009;
                    break;
                case 11:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_010;
                    break;
                case 12:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_011;
                    break;
                case 13:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_012;
                    break;
                case 14:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_013;
                    break;
                case 15:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_014;
                    break;
                case 16:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_015;
                    break;
                case 17:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_016;
                    break;
                case 18:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_017;
                    break;
                case 19:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_018;
                    break;
                case 20:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_019;
                    break;
                case 21:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_020;
                    break;
                case 22:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_021;
                    break;
                case 23:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_022;
                    break;
                case 24:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_023;
                    break;
                case 25:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_024;
                    break;
                case 26:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_025;
                    break;
                case 27:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_026;
                    break;
                case 28:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_027;
                    break;
                case 29:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_028;
                    break;
                case 30:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_029;
                    break;
                case 31:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_030;
                    break;
                case 32:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_031;
                    break;
                case 33:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_032;
                    break;
                case 34:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_033;
                    break;
                case 35:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_034;
                    break;
                case 36:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_035;
                    break;
                case 37:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_036;
                    break;
                case 38:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_037;
                    break;
                case 39:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_038;
                    break;
                case 40:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_039;
                    break;
                case 41:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_040;
                    break;
                case 42:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_041;
                    break;
                case 43:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_042;
                    break;
                case 44:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_043;
                    break;
                case 45:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_044;
                    break;
                case 46:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_045;
                    break;
                case 47:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_046;
                    break;
                case 48:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_047;
                    break;
                case 49:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_048;
                    break;
                case 50:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_049;
                    break;
                case 51:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_050;
                    break;
                case 52:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_051;
                    break;
                case 53:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_052;
                    break;
                case 54:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_053;
                    break;
                case 55:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_054;
                    break;
                case 56:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_055;
                    break;
                case 57:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_056;
                    break;
                case 58:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_057;
                    break;
                case 59:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_058;
                    break;
                case 60:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_059;
                    break;
                case 61:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_060;
                    break;
                case 62:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_061;
                    break;
                case 63:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_062;
                    break;
                case 64:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_063;
                    break;
                case 65:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_064;
                    break;
                case 66:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_065;
                    break;
                case 67:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_066;
                    break;
                case 68:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_067;
                    break;
                case 69:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_068;
                    break;
                case 70:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_069;
                    break;
                case 71:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_070;
                    break;
                case 72:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_071;
                    break;
                case 73:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_072;
                    break;
                case 74:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_073;
                    break;
                case 75:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_074;
                    break;
                case 76:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_075;
                    break;
                case 77:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_076;
                    break;
                case 78:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_077;
                    break;
                case 79:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_078;
                    break;
                case 80:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_079;
                    break;
                case 81:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_080;
                    break;
                case 82:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_081;
                    break;
                case 83:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_082;
                    break;
                case 84:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_083;
                    break;
                case 85:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_084;
                    break;
                case 86:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_085;
                    break;
                case 87:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_086;
                    break;
                case 88:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_087;
                    break;
                case 89:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_088;
                    break;
                case 90:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_089;
                    break;
                case 91:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_090;
                    break;
                case 92:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_091;
                    break;
                case 93:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_092;
                    break;
                case 94:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_093;
                    break;
                case 95:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_094;
                    break;
                case 96:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_095;
                    break;
                case 97:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_096;
                    break;
                case 98:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_097;
                    break;
                case 99:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_098;
                    break;
                case 100:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_099;
                    break;
                case 101:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_100;
                    break;
                case 102:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_101;
                    break;
                case 103:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_102;
                    break;
                case 104:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_103;
                    break;
                case 105:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_104;
                    break;
                case 106:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_105;
                    break;
                case 107:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_106;
                    break;
                case 108:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_107;
                    break;
                case 109:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_108;
                    break;
                case 110:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_109;
                    break;
                case 111:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_110;
                    break;
                case 112:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_111;
                    break;
                case 113:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_112;
                    break;
                case 114:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_113;
                    break;
                case 115:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_114;
                    break;
                case 116:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_115;
                    break;
                case 117:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_116;
                    break;
                case 118:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_117;
                    break;
                case 119:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_118;
                    break;
                case 120:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_119;
                    break;
                case 121:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_120;
                    break;
                case 122:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_121;
                    break;
                case 123:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_122;
                    break;
                case 124:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_123;
                    break;
                case 125:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_124;
                    break;
                case 126:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_125;
                    break;
                case 127:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_126;
                    break;
                case 128:
                    this.BackgroundImage = Properties.Resources._4cf17a9f1c_gif_127;
                    AnimateBack2 = 0;
                    
                    tmrHeart.Stop();
                    tmrEnd.Start();

                    break;

            }

        }

        private void tmrEnd_Tick(object sender, EventArgs e)
        {
            K = K + 10;
            if (K == 100)
            {

                if (MessageBox.Show("Story ended, would you like to watch again?", "Play Again?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes) // IF USER WISHES TO WATCH AGAIN
                {
                   
                  
                    Reset();
                }
                else
                {
                    if (MessageBox.Show("Exit ?", "Story Over", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    {
                       
                        Reset();
                    }
                    else
                    {
                        this.Close(); // IF USER DOESN'T WISH TO WATCH AGAIN, FORM CLOSES
                    }
                
                }
             K = 0; //RESET K VALUE
            }
     
        }
        
    }
}

