/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - GUESS
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : GUESSING GAME
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
    public partial class frmDrinks : Form
    {
        public static int GuessScore;
        public static int GuessFrequency;
        public frmDrinks()
        {
            InitializeComponent();
          
        }

        //global variables
        int secretNumber;
        int Counter;
        Random rnd = new Random();
        
        private void btnStart_Click(object sender, EventArgs e)
        {
            txtInput.Visible = true;

            if (btnStart.Text == "Start Game")
            {
                secretNumber = rnd.Next(1, 11);
                Counter = 0;
                lblNumberOfGuesses.Text = "Number of Guesses : ";
                txtInput.Text = " ";
                picPictures.BackgroundImage = null;
                MessageBox.Show(" I've had between 1 -10 drinks, guess how many! ");
                btnCheck.Enabled = true;
                btnStart.Text = " Show Answer ";
                txtInput.Focus();
                lblRightorWrong.Text = " ";
                lblNumber.Visible = false;
            }
            else
            {
                lblRightorWrong.Text = "The Number is " + secretNumber;
                lblNumberOfGuesses.Text = "Number of Guesses : ";
                btnCheck.Enabled = false;
                picPictures.Image = Properties.Resources.image;
                picPictures.BackgroundImageLayout = ImageLayout.Zoom;
                
                btnStart.Text = "Start Game";
                lblNumber.Visible = false;
                Counter = 0;
                lblCount.Text = " ";
            }



        }
    private void tmrBackColor_Tick(object sender, EventArgs e)
        {
           // CAHNGE BACKGROUND COLOR RANDOMLY
            int red;
            int green;
            int blue;

            red = rnd.Next(0, 256);
            green = rnd.Next(0, 256);
            blue = rnd.Next(0, 256);

            this.BackColor = Color.FromArgb(red, green, blue);
            
        }

        private void lblGuess_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
          

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int myguess;
            myguess = int.Parse(txtInput.Text);
            
            Counter++;
            lblCount.Text = Counter.ToString();
            

            if (myguess > 10 || myguess < 1)        // IF USER DECIDES TO GUESS OVER 10
            {
                GuessScore -= 1;
                GuessFrequency += 1;
                MessageBox.Show(" I said between 1- 10  -_- \r\n  You just lost  1 points. \r\n \r\n Your points in this round are " + GuessScore.ToString() + " point(s)", "Really?");
                txtInput.Text = null;
                txtInput.Focus();
                picPictures.BackgroundImage = Properties.Resources.uwrong;
                picPictures.BackgroundImageLayout = ImageLayout.Zoom;
            }
            else if (myguess == secretNumber) // IF USER GUESSES RIGHT
            {    tmrBackColor.Start();
                 GuessScore += 5;
                 GuessFrequency += 1;
                 MessageBox.Show(" Yep *burp* You got it right " + "\r\n You have also been awarded 5 points \r\n \r\n Your points in this round are " + GuessScore.ToString() + " point(s).", "You're right!");
                txtInput.Text = null;
                btnCheck.Enabled = false;
                txtInput.Visible = false;
               
                picPictures.BackgroundImage = Properties.Resources.resized_jesus_says_meme_generator_yeah_you_right_d77cba;
                picPictures.BackgroundImageLayout = ImageLayout.Zoom;
                tmrBackColor.Stop();
                lblNumberOfGuesses.Text = "Number of Guesses : ";
                btnCheck.Enabled = false;
                btnStart.Text = "Start Game";
                lblNumber.Visible = false;
                Counter = 0;
                lblCount.Text = " ";

            }
            else if (myguess < secretNumber) // IF USER GUESS IS LOWER THAN  THE GENERATED NUMBER
            {
                GuessScore -= 1;
                GuessFrequency += 1;
                MessageBox.Show("Come on, I can take alot more! Your guess is too low" +"\r\n You just lost  1 points. \r\n \r\n  Your points in this round are " + GuessScore.ToString() + " point(s)", " Try again?");
                picPictures.BackgroundImage = Properties.Resources.uwrong;


            }
            else             // IF GUESS IS OVER THER GENERATED NUMBER
            {
                GuessScore -= 1;
                GuessFrequency += 1;
                MessageBox.Show("Whoa! Your guess is too high, what you want me dead??"+"\r\n  You just lost  1 points. \r\n \r\n Your points in this round are " + GuessScore.ToString() + " point(s)", " Try again?");
                picPictures.BackgroundImage = Properties.Resources.uwrong;
            }

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblNumberOfGuesses.Text = "Number of Guesses : ";
            picPictures.Image = null;
        }

        private void frmDrinks_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (frmCPT.gameover == true)
            {
                Application.Exit();
            }
            else
            {
                new frmCPT().Show();
            }
        }

        private void frmDrinks_Load(object sender, EventArgs e) // UPON FORM LOAD
        {
            MessageBox.Show("Click Start Game to start.", "Instructions");
            GuessFrequency += 1;

        }

       
    }
}
