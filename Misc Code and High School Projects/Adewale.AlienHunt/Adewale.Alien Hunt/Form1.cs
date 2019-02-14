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
    public partial class frmAlienHunt : Form
    {
        public static int Moves;
        public static int NumberPeople;
        public static int Difficulty;
        public static bool GameOver;                //these variables extend beyond form1
        public static bool DisplayScore;
       
        public static int GameCounter;
        public static int Timer;
        public static int PeopleLeft;

        public static int tries;

        public frmAlienHunt()
        {
            InitializeComponent();
        }

        string GameStatus;

        int ShipRow, ShipColumn;
        int red;
        int green;
        int blue;
        int[] PeopleRow = new int[25];
        int[] PeopleColumn = new int[25];
        int[,] A = new int[15, 25];
        int k;
        int L;
        int P;
        int Login;
        Image[] Person = new Image[26];
        bool Form2Open;
        Graphics gamePanel;
        Random myRandom = new Random();
        

        private void button7_Click(object sender, EventArgs e)
        {
            // Clicked this button accidentally while naming 
            //btnMouseUpLeft
            CheckMove(-1, -1);
        }

        private void frmAlienHunt_Load(object sender, EventArgs e)
        {
            new frmScoreboard().Show();
            Animate();

            GameCounter = 0;
            Timer = 0;
            Difficulty = 1;
            GameStatus = "Initial";
            lblInstructions.Text = "Abduct the Humans";
            lblInstructions.Text += "\r\n\r\nEliminate all humans on screen";
            lblInstructions.Text += "\r\n\r\nSelect Difficulty by Pressing '<'  and  '>' buttons";
            lblInstructions.Text += "\r\n\r\nClick on Start Button to begin game";
            lblInstructions.Text += "\r\n\r\nClick on Stop Button to End game";
            lblInstructions.Text += "\r\n\r\nUse Move Buttons to move UFO in different directions";
            lblInstructions.Text += "\r\n\r\nUse Shoot Buttons to unleash death ray on nearest Human";
            lblInstructions.Text += "\r\n\r\nUse Beam Burst and Teleportation at your own risk ";
            lblInstructions.Text += "\r\n\r\nCHARACTER HIGHLIGHTED IN RED AT THE BEGINNING OF GAME PLAY IS YOUR AVATAR";
            L = 3;
            P = 1;


            Person[1] = picBay.Image;
            Person[2] = picIron.Image;
            Person[3] = picMonkey.Image;
            Person[4] = picSONOFODIN.Image;
            Person[5] = picWonder.Image;
            Person[6] = picHuman.Image;
            Person[7] = picBoy.Image;
            Person[8] = picCaptain.Image;
            Person[9] = picDeadpool.Image;
            Person[10] = picHomer.Image;
            Person[11] = picMother.Image;
            Person[12] = picLady.Image;
            Person[13] = picPergnant.Image;
            Person[14] = picSpiderman.Image;
            Person[15] = picStewie.Image;
            Person[16] = picWolverine.Image;
            Person[17] = picScared.Image;
            Person[18] = picJohnny.Image;
            Person[19] = PicJerry.Image;
            Person[20] = picPopeye.Image;
            Person[21] = picPikachu.Image;
            Person[22] = picDexter.Image;
            Person[23] = picGarfield.Image;
            Person[24] = picMinion.Image;
            Person[25] = picMike.Image;
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (GameStatus == "Initial")
            {
                Difficulty--;
                if (Difficulty < 1)
                    Difficulty = 1;
                lblDifficulty.Text = Difficulty.ToString();
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {


            if (GameStatus == "Initial")
            {
                Difficulty++;
                if (Difficulty > 20)
                    Difficulty = 20;
                lblDifficulty.Text = Difficulty.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Clicked Start
            Reset();
            tmrGame.Start();
            GameCounter += 1;
            k = 0;
            GameStatus = "AlienMove";
            GameOver = false;
            lblInstructions.Visible = false;
            Moves = 0;
            NumberPeople = Difficulty + 5;
            PeopleLeft = NumberPeople;
            lblMoves.Text = Moves.ToString();
            lblPeople.Text = PeopleLeft.ToString();
            //Draw grid structure
            gamePanel = pnlGame.CreateGraphics();

            gamePanel.FillRectangle(Brushes.Black, 0, 0, 935, 750);

            gamePanel.FillRectangle(Brushes.White, 5, 5, 925, 730); //gamePanel.FillRectangle(Brushes.White, 50, 50, 800, 500);
            for (int I = 0; I < 16; I++)
                gamePanel.DrawLine(Pens.Gray, 0, 50 * I, 930, 50 * I);
            for (int I = 0; I < 23; I++)
                gamePanel.DrawLine(Pens.Gray, 50 + 40 * I, 0, 50 + 40 * I, 700);
            gamePanel.DrawImage(picLogo.Image, 10, 700);
            //1)Because one structure only has to run 9 ( 16 in my case) times to draw 9 horizontal lines 
            //and the other structure needs to only run 19 (23 in my case) times to draw vertical lines

            //2a) 50 * i + 100 represents the end popint of where the line horizontal line should end  (y2)
            //2b) it changes where on the y axis the horizontal line ends, mives it down
            //2c) it also changes where on the x axis the line ends, it goes wider when you increase to 100
            for (int i = 0; i < 15; i++)
                for (int j = 0; j < 25; j++)
                    A[i, j] = 0;
            // Place Trees
            // Array A ( 0 -  nothing, 1- rocks, 2- lion, 3 - hunter)
            A[3, 4] = 1;
            A[3, 15] = 1;
            A[6, 4] = 1;
            A[6, 15] = 1;
            A[9, 4] = 1;
            A[9, 15] = 1;

            gamePanel.FillRectangle(Brushes.Brown, 228, 225, 8, 24);
            gamePanel.FillEllipse(Brushes.Green, 220, 205, 23, 27);

            gamePanel.FillRectangle(Brushes.Brown, 663, 225, 8, 24);
            gamePanel.FillEllipse(Brushes.Green, 655, 205, 23, 27);

            gamePanel.FillRectangle(Brushes.Brown, 228, 375, 8, 24);
            gamePanel.FillEllipse(Brushes.Green, 220, 355, 23, 27);

            gamePanel.FillRectangle(Brushes.Brown, 663, 375, 8, 24);
            gamePanel.FillEllipse(Brushes.Green, 655, 355, 23, 27);

            gamePanel.FillRectangle(Brushes.Brown, 228, 525, 8, 24);
            gamePanel.FillEllipse(Brushes.Green, 220, 505, 23, 27);

            gamePanel.FillRectangle(Brushes.Brown, 663, 525, 8, 24);
            gamePanel.FillEllipse(Brushes.Green, 655, 505, 23, 27);
            //3)two loos are required, one loop makes the action happen 9 times on the drawn horizontal lines
            //makes the action happen 19 times on the drawn Vertical lines

            //A[i, j ] = 0;  means that nothing can pass through that location on the panel, for whatever value I or J are assigned

            //Place ship
            int row, column;
            do
            {
                row = myRandom.Next(13); // picks random location(number) for row value
                column = myRandom.Next(22);// picks random location(number) for Column value
            }
            while (A[row, column] != 0);  //makes sure the value of row and column isn't a spot nothing can exist on
            A[row, column] = 3; // makes random values the location where the hunter(ship) is
            ShipRow = row; //prepares to draw
            ShipColumn = column; //prepares to draw

            gamePanel.DrawImage(picRed.Image, ShipColumn * 40 + 55, ShipRow * 50 + 55);//Serves as an indicator for what character the player is

            //gamePanel.FillEllipse(Brushes.Red, ShipColumn * 40 + 55, ShipRow* 50 + 55, 5, 9);  
            //gamePanel.FillEllipse(Brushes.Red ShipColumn , ShipRow, ShipColumn * 40 + 81, ShipRow * 50 + 61);

            //greenPen.Alignment = PenAlignment.Center;

            //Draws Alien ship image at randomly generated location based on row(shipRow) and column (shipcolumn)
            //Place People
            for (int i = 0; i < NumberPeople; i++)
            {
                k++;
                do
                {
                    row = myRandom.Next(13);
                    column = myRandom.Next(22);
                }
                while (A[row, column] != 0);
                A[row, column] = 2;
                PeopleRow[i] = row;
                PeopleColumn[i] = column;

                gamePanel.DrawImage(Person[k], PeopleColumn[i] * 40 + 55, PeopleRow[i] * 50 + 55);
            }
            //4)the line while (A[row, column] != 0) ensures that as the program draws locatioons for lions(humans) 
            //on the panel, it doesn't draw it on a location that isn't on the game, 
            //i.e on a rock, or outside the grid  

            //6) we use the do while loop because we want an action to happen over and over, based on certain conditions (for Placing lions/humans)
            // but we don't use it for placing the  alien ship because we only need the event happening once

            if (GameStatus == "AlienMove")
            {
                btnStart.Enabled = false;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (GameStatus == "Initial")
            {
                Reset();
            }
            else
            {
                //Stop clicked during game play
                GameCounter -= 1; // part of structure that keeps scorebored functional
                tmrGame.Stop();
                GameStatus = "Initial";
                MessageBox.Show("You've failed to abduct all the humans. Report to the overlord", "Game Over");
                Reset();
                for (int i = 0; i < NumberPeople; i++)
                    RemovePeople(i);
                RemoveShip();
            }
        }
        private void Reset()
        {
            L = 3;
            P = 1;
            tmrGame.Enabled = false;
            lblTimeValue.Text = "0";
            Timer = 0;
            GameOver = false;
            GameStatus = "Initial";
            btnBurst.Enabled = true;
            btnTeleport.Enabled = true;
            tmrBackcolor.Stop();
            pnlGame.BackColor = Color.White;
            pnlNoIdeaWhyThisPanelExists.BackColor = Color.SandyBrown;
            btnStart.Enabled = true;

            //Clear panel, and get ready for replay
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            CheckMove(-1, 0);
        }

        private void btnMoveUpRight_Click(object sender, EventArgs e)
        { //check here
            CheckMove(-1, 1);


        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            CheckMove(0, -1);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            L--;
            lblCountTele.Text = "You can use Teleport " + L.ToString() + " more times ";
            //btnNomove
            // CheckMove(-0, 0);
            int row, column;
            int XRow, YColumn;
            do
            {
                row = myRandom.Next(13);
                column = myRandom.Next(22);
            }
            while (A[row, column] != 0);
            A[row, column] = 3;
            XRow = row;
            YColumn = column;
            //////////////////////////////////////////////
            RemoveShip();
            gamePanel.DrawImage(picAlien.Image, YColumn * 40 + 55, XRow * 50 + 55);
            ShipColumn = column;
            ShipRow = row;
            gamePanel.DrawImage(picAlien.Image, ShipColumn * 40 + 55, ShipRow * 50 + 55);
            CheckMove(row, column);
            if (L == 0)
            {
                btnTeleport.Enabled = false;
            }

        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            CheckMove(0, 1);
        }

        private void btnMovedownLeft_Click(object sender, EventArgs e)
        {
            CheckMove(1, -1);
        }

        private void lblDirect_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            CheckMove(1, 0);
        }

        private void picHomer_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveDownRight_Click(object sender, EventArgs e)
        {
            CheckMove(1, 1);
        }

        private void CheckMove(int DeltaRow, int DeltaColumn)
        {
            int NewRow, NewColumn;
            bool MoveOkay;
            Moves++;
            //Check if Move is Valid
            NewRow = ShipRow + DeltaRow;
            NewColumn = ShipColumn + DeltaColumn;
            MoveOkay = true;
            if (NewRow < 0 || NewRow > 12 || NewColumn < 0 || NewColumn > 21)
            { //off grid
              //7) NewRow< 0 || NewRow > 12 || NewColumn< 0 || NewColumn > 21 checks to make sure the image isn't off the grid (0 and 12 are row limits) (0  and 21 are limits for columns)
                MoveOkay = false;
            }
            else if (A[NewRow, NewColumn] == 1)
            {  // else if (A[NewRow,NewColumn] == 1) means there is a rock (tree) at that point and characters can't move to that point

                //Approaching tree
                MoveOkay = false;
            }
            else if (A[NewRow, NewColumn] == 2)
            { //else if (A[NewRow, NewColumn] == 2) checks if there is already a lion(person) there , if ther is, then nothing can move ontop of it
                //Approaching Human
                MoveOkay = false;
                GameOver = true;
                tries += 1;
                //Remove Alien Ship
                RemoveShip();
            }

            if (MoveOkay)
            {
                //move to new location
                RemoveShip(); //Clears the image of ship at where it used to be
                gamePanel.DrawImage(picAlien.Image, NewColumn * 40 + 55, NewRow * 50 + 55); //Redraws image  at new location
                A[ShipRow, ShipColumn] = 0; //makes sure toset the old location as free so another character can move there
                ShipRow = NewRow; //Updates ShipRow value 
                ShipColumn = NewColumn; //Updates ShipColumn to the value
                A[ShipRow, ShipColumn] = 3; //Sets Location as filled by hunter(ship)
            }

            UpdateGame(); //Goes to update game code


        }
        private void RemoveShip()
        {
            gamePanel.FillRectangle(Brushes.White, ShipColumn * 40 + 55, ShipRow * 50 + 55, 35, 45);

        }

        private void UpdateGame()
        {
            k = 0;

            int NewRow, NewColumn;
            int DeltaRow, DeltaColumn;
            bool MoveOkay;
            lblMoves.Text = Moves.ToString();
            lblPeople.Text = PeopleLeft.ToString();
            if (!GameOver)
            {
                //Move People
                GameStatus = "PeopleMove";
                for (int i = 0; i < NumberPeople; i++)
                {
                    k++;
                    if (A[PeopleRow[i], PeopleColumn[i]] == 2)
                    {
                        if (PeopleRow[i] > ShipRow)
                        {
                            DeltaRow = -1;
                        }
                        else if (PeopleRow[i] < ShipRow)
                        {
                            DeltaRow = 1;
                        }

                        else
                        {
                            DeltaRow = 0;
                        }
                        if (PeopleColumn[i] > ShipColumn)
                        {
                            DeltaColumn = -1;
                        }
                        else if (PeopleColumn[i] < ShipColumn)
                        {
                            DeltaColumn = 1;
                        }
                        else

                            DeltaColumn = 0;
                        NewRow = PeopleRow[i] + DeltaRow;
                        NewColumn = PeopleColumn[i] + DeltaColumn;
                        MoveOkay = true;
                        if (NewRow < 0 || NewRow > 12 || NewColumn < 0 || NewColumn > 21)
                            MoveOkay = false;
                        else if (A[NewRow, NewColumn] == 1)
                            //moving to Tree 
                            MoveOkay = false;
                        else if (A[NewRow, NewColumn] == 2)
                            //moving to another person
                            MoveOkay = false;
                        if (MoveOkay == true)
                        {
                            if (A[NewRow, NewColumn] == 3)
                            {
                                //Moving to Ship
                                GameOver = true;
                                tries += 1;
                                RemoveShip();
                            }
                            RemovePeople(i);
                            gamePanel.DrawImage(Person[k], NewColumn * 40 + 55, NewRow * 50 + 55);
                            A[PeopleRow[i], PeopleColumn[i]] = 0;
                            PeopleRow[i] = NewRow;
                            PeopleColumn[i] = NewColumn;
                            A[PeopleRow[i], PeopleColumn[i]] = 2;
                        }
                    }
                }
                GameStatus = "AlienMove";
            }
            if (GameOver)
            {
                //then the game is over .. duh
                GameStatus = "Initial";
                if (PeopleLeft > 0)
                {
                    tmrGame.Stop();
                    MessageBox.Show("The SpaceCraft was taken down by a human!", "Game Over");

                    Reset();
                    for (int i = 0; i < NumberPeople; i++)
                    { //Clear all the people
                        RemovePeople(i);
                    }
                }
                else
                {
                    tmrGame.Stop();
                    MessageBox.Show("The Aliens abducted " + NumberPeople.ToString() + " humans in " + Moves.ToString() + " moves.", "Take Me To Your Leader");
                    Reset();

                    RemoveShip();
                }
            }
        }

        private void btnShootUpLeft_Click(object sender, EventArgs e)
        {
            ShootBeam(-1, -1);
        }

        private void btnShootUp_Click(object sender, EventArgs e)
        {
            ShootBeam(-1, 0);
        }

        private void btnShootUpRight_Click(object sender, EventArgs e)
        {
            ShootBeam(-1, 1);
        }

        private void btnShootLeft_Click(object sender, EventArgs e)
        {
            ShootBeam(0, -1);
        }

        private void btnShootRight_Click(object sender, EventArgs e)
        {
            ShootBeam(0, 1);
        }

        private void btnShootDownLeft_Click(object sender, EventArgs e)
        {
            ShootBeam(1, -1);
        }

        private void btnShootDownRight_Click(object sender, EventArgs e)
        {
            ShootBeam(1, 1);
        }

        private void btnShootDown_Click(object sender, EventArgs e)
        {
            ShootBeam(1, 0);
        }
        private void ShootBeam(int DeltaRow, int DeltaColumn)
        {
            int BeamRow, BeamColumn;
            bool moveOkay;
            if (DeltaRow != 0 || DeltaColumn != 0)
                Moves++;
            BeamRow = ShipRow;
            BeamColumn = ShipColumn;
        MoveAgain:
            //Check if move is okay
            BeamRow += DeltaRow;
            BeamColumn += DeltaColumn;
            moveOkay = true;

            if (BeamRow < 0 || BeamRow > 14 || BeamColumn < 0 || BeamColumn > 24 || (DeltaRow == 0 && DeltaColumn == 0))

            { //Off grid or Centre button Arrea clicked
                moveOkay = false;
            }
            else if (A[BeamRow, BeamColumn] == 1)  // this line of code causes problems for some reason?
            {   //Moving to Tree
                moveOkay = false;
            }
            int i;
            if (moveOkay)
            {
                if (A[BeamRow, BeamColumn] == 2)
                {
                    //Abducted a human - find that human
                    for (i = 0; i < NumberPeople; i++)
                    {
                        if (BeamRow == PeopleRow[i] && BeamColumn == PeopleColumn[i])
                            goto FoundHim;
                    }   //The goto statement transfers the program control directly to a labeled statement, it is also used to get out of deeply nested loops and make the program less messy

                FoundHim:
                    moveOkay = false; //i Believe this prevents the other characters from moving
                    red = myRandom.Next(0, 256); //random value for an int for colors
                    green = myRandom.Next(0, 256);//random value for an int for colors
                    blue = myRandom.Next(0, 256);//random value for an int for colors
                    this.BackColor = Color.FromArgb(red, green, blue); //Flashes background color
                    pnlNoIdeaWhyThisPanelExists.BackColor = Color.FromArgb(green, red, blue); //Flashes panel color

                    A[BeamRow, BeamColumn] = 0; //Makes whereve the Beam ends an empty spot so it can be filled by something else
                    RemovePeople(i); // checks for i value of character and removes them from screen
                    PeopleRow[i] = 0; //Empties location person used to be at
                    PeopleLeft--; //Decreases number of people counter
                    if (PeopleLeft == 0)
                    {
                        tmrBackcolor.Start(); //Flashes colors
                        GameOver = true;

                    }
                }
            }
            if (moveOkay)
                goto MoveAgain;
            UpdateGame();
        }
        private void btnMoveUpLeft_Click(object sender, EventArgs e)
        {
            CheckMove(-1, -1);
        }

        private void tmrBackcolor_Tick(object sender, EventArgs e)
        {


            red = myRandom.Next(0, 256);
            green = myRandom.Next(0, 256);
            blue = myRandom.Next(0, 256);

            this.BackColor = Color.FromArgb(red, green, blue);
            pnlGame.BackColor = Color.FromArgb(red, green, blue);
            pnlNoIdeaWhyThisPanelExists.BackColor = Color.FromArgb(red, green, blue);
            //this.Text = red.ToString() + "," + green.ToString() + "," + blue.ToString();
        }

        private void frmAlienHunt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad4)
            { //Left
                CheckMove(0, -1);
            }
            if (e.KeyCode == Keys.A)
            { //Left
                CheckMove(0, -1);
            }

            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D)
            {//Right
                CheckMove(0, 1);
            }

            else if (e.KeyCode == Keys.W || e.KeyCode == Keys.NumPad8)
            {//Up
                CheckMove(-1, 0);
            }

            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.NumPad8)
            {//Down
                CheckMove(1, 0);
            }
            ///////////////////////////////////////////////////////////////////////////////
            else if ((e.KeyCode == Keys.W || e.KeyCode == Keys.NumPad8) && (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.A))
            { //UpLeft
                CheckMove(-1, 1);
            }

            else if ((e.KeyCode == Keys.W || e.KeyCode == Keys.NumPad8) && (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D))
            { //UpRight
                CheckMove(-1, 1);
            }
            else if ((e.KeyCode == Keys.S || e.KeyCode == Keys.NumPad8) && (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.A))
            {//DownLeft
                CheckMove(1, -1);
            }
            else if ((e.KeyCode == Keys.S || e.KeyCode == Keys.NumPad8) && (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D))
            {//DownRight
                CheckMove(1, 1);
            }

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBurst_Click(object sender, EventArgs e)
        {
            P--;
            lblBeamCount.Text = "You have " + P.ToString() + " BeamBurst left";
            Moves += 5;
            lblMoves.Text = Moves.ToString();
            for (int i = 0; i < 2; i++)
            {
                BeamBurst(-1, -1);
                BeamBurst(-1, 0);
                BeamBurst(-1, 1);
                BeamBurst(1, -1);
                BeamBurst(1, 0);
                BeamBurst(1, 1);
                BeamBurst(1, -1);
                BeamBurst(0, -1);
                BeamBurst(0, 1);
                lblPeople.Text = PeopleLeft.ToString();

            }
            if (GameOver)
            {
                //then the game is over .. duh
                GameStatus = "Initial";
                if (PeopleLeft > 0)
                {
                    GameOver = false;
                    MessageBox.Show("The SpaceCraft was taken down by a human!", "Game Over");
                    Reset();
                    UpdateScore();
                    for (int J = 0; J < NumberPeople; J++)
                    { //Clear all the people
                        RemovePeople(J);
                    }
                }
                else
                {
                    GameOver = false;
                    MessageBox.Show("The Aliens abducted " + NumberPeople.ToString() + " humans in " + Moves.ToString() + " moves.", "Take Me To Your Leader");
                    Reset();

                    RemoveShip();
                }
            }
            if (P == 0)
            {
                btnBurst.Enabled = false;
            }
        }

        private void UpdateScore()
        {

        }

        private void BeamBurst(int DeltaRow, int DeltaColumn)
        {
            int BeamRow, BeamColumn;
            bool moveOkay;
            //   if (DeltaRow != 0 || DeltaColumn != 0)
            // { Moves++; }
            BeamRow = ShipRow;
            BeamColumn = ShipColumn;
        MoveAgain:
            //Check if move is okay
            BeamRow += DeltaRow;
            BeamColumn += DeltaColumn;
            moveOkay = true;

            if (BeamRow < 0 || BeamRow > 14 || BeamColumn < 0 || BeamColumn > 24 || (DeltaRow == 0 && DeltaColumn == 0))

            { //Off grid or Centre button Arrea clicked
                moveOkay = false;
            }
            else if (A[BeamRow, BeamColumn] == 1)
            {   //Moving to Tree
                moveOkay = false;
            }
            int i;
            if (moveOkay)
            {
                if (A[BeamRow, BeamColumn] == 2)
                {
                    //Abducted a human - find that human
                    for (i = 0; i < NumberPeople; i++)
                    {
                        if (BeamRow == PeopleRow[i] && BeamColumn == PeopleColumn[i])
                            goto FoundHim;
                    }
                FoundHim:
                    moveOkay = false;
                    red = myRandom.Next(0, 256);
                    green = myRandom.Next(0, 256);
                    blue = myRandom.Next(0, 256);
                    this.BackColor = Color.FromArgb(red, green, blue);
                    pnlNoIdeaWhyThisPanelExists.BackColor = Color.FromArgb(green, red, blue);

                    A[BeamRow, BeamColumn] = 0;
                    RemovePeople(i);
                    PeopleRow[i] = 0;
                    PeopleLeft--;
                    if (PeopleLeft == 0)
                    {
                        tmrBackcolor.Start();
                        GameOver = true;

                    }
                }
            }
            if (moveOkay)
                goto MoveAgain;

        }

        private void lblMovename_Click(object sender, EventArgs e)
        {

        }

        private void lblMoves_Click(object sender, EventArgs e)
        {

        }

        private void pnlNoIdeaWhyThisPanelExists_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            Timer += 1;
            lblTimeValue.Text = Timer.ToString();

        }

        private void tmrAnimate_Tick(object sender, EventArgs e)
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
                    this.BackgroundImage = Properties.Resources.Akin_Vector21;
                    break;
                case 9:
                    this.BackgroundImage = Properties.Resources.alien_abduction;
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
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    UnAnimate();
                    break;

            }

        }
        private void Animate()
        {
            Login = 0;
            pnlGame.Visible = false;
            pnlNoIdeaWhyThisPanelExists.Visible = false;
            tmrAnimate.Start();
        }
        private void UnAnimate()
        {

            this.BackgroundImage = null;
            pnlNoIdeaWhyThisPanelExists.Visible = true;
            pnlGame.Visible = true;
            Login = 0;
            tmrAnimate.Stop();
        }

        private void btnScoreboard_Click(object sender, EventArgs e)
        {
            Form2Open = frmScoreboard.Form2Open;
            if (Form2Open == false)
            {
                new frmScoreboard().Show();
                //GameCounter = 0;
                Form2Open = true;
            }
            else
            {
                //button will do nothing
            }
        }

        private void RemovePeople(int i)
        {
            gamePanel.FillRectangle(Brushes.White, PeopleColumn[i] * 40 + 55, PeopleRow[i] * 50 + 55, 35, 45);
        }

        private void btnTeleport_MouseEnter(object sender, EventArgs e)
        {
            //toolTip1.Show("Teleport your character to safety. Or certain death!");
        }
    }
}
