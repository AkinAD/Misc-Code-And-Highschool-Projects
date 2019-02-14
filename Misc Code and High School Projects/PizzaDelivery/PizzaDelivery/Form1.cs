using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery
{
    public partial class frmPizzaDelivery : Form
    {
        public frmPizzaDelivery()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        Label[,] deliveryGrid = new Label[21, 21];
        int[,] pizzas = new int[21, 21];
        int[,] pizzaTime = new int[21, 21];
        int pizzasBaking, pizzasReady;
        int totalPizzasBaked;
        PictureBox[] pizzasInOven = new PictureBox[8];
        int bakingMinutesLeft;
        bool ovenGoing;
        int pizzasInCar;

        int pizzaC, pizzaR;
        int deliveryC, deliveryR;
        int carC, carR;
        int deltaC, deltaR;
        int mileage;
        bool carGoing;
        int pizzasOnTime;
        int pizzasLate;
        int missedDeliveries;
        int totalSales;


        int clockHour, clockMinute;

        System.Media.SoundPlayer gameOverSound;
        System.Media.SoundPlayer phoneSound;
        System.Media.SoundPlayer dingSound;
        System.Media.SoundPlayer beepSound;

        const int mSecPerMin = 100;
        const int minPer20Squares = 3;
        const int pizzasReadyMax = 20;
        const int pizzasBakingMax = 8;
        const int bakingTime = 10;
        const int pizzasInCarMax = 10;
        const int orderMaxTime = 60;
        const int orderLateTime = 30;
        const int netSoldPizza = 10;
        const int netLatePizza = 5;
        const int costMissedPizza = 1;
        const int pizzaCost = 3;
        const double mileageCost = 0.1;


        private void frmPizzaDelivery_Load(object sender, EventArgs e)
        {
            {
                int w = pnlGrid.Width / 24;
                int l = w;
                int t = w;
                // J is row, I is column; build one row at a time
                for (int j = 0; j < 21; j++)
                {
                    for (int i = 0; i < 21; i++)
                    {
                        deliveryGrid[i, j] = new Label();
                        deliveryGrid[i, j].Width = w;
                        deliveryGrid[i, j].Height = w;
                        deliveryGrid[i, j].Top = t;
                        deliveryGrid[i, j].Left = l;
                        deliveryGrid[i, j].Font = new Font
                            ("Microsoft Sans Serif", 10, FontStyle.Bold);
                        deliveryGrid[i, j].TextAlign =
                        ContentAlignment.MiddleCenter;
                        if (i == 0)
                        {
                            if (j != 0)
                            {
                                // row numbers
                                deliveryGrid[i, j].Text =
                                j.ToString();
                                deliveryGrid[i, j].Width =
                                Convert.ToInt32(1.5 * w);
                                deliveryGrid[i, j].Left =
                                Convert.ToInt32(0.5 * w);
                                deliveryGrid[i, j].ForeColor =
                                Color.DarkBlue;
                            }
                        }
                        else if (j == 0)
                        {
                            if (i != 0)
                            {
                                // column letters
                                deliveryGrid[i, j].Text = ((char)
                                    (i + 64)).ToString();
                                deliveryGrid[i, j].ForeColor =
                                Color.DarkBlue;
                            }
                        }
                        else
                        {
                            deliveryGrid[i, j].BorderStyle =
                            BorderStyle.FixedSingle;
                            deliveryGrid[i, j].BackColor =
                            Color.White;
                            deliveryGrid[i, j].ForeColor =
                            Color.Yellow;
                            if (i < 10)
                                deliveryGrid[i, j].Tag = "0" +
                                i.ToString();
                            else
                                deliveryGrid[i, j].Tag = i.ToString();
                            if (j < 10)
                                deliveryGrid[i, j].Tag += "0" +
                                j.ToString();
                            else
                                deliveryGrid[i, j].Tag += j.ToString();
                            deliveryGrid[i, j].Click += new System.EventHandler
                                (this.DeliveryGrid_Click);
                        }
                        pnlGrid.Controls.Add(deliveryGrid[i, j]);
                        l += w;
                    }
                    // new row
                    l = w;
                    t += w;
                }
            }
            pizzasInOven[0] = picPizza1;
            pizzasInOven[1] = picPizza2;
            pizzasInOven[2] = picPizza3;
            pizzasInOven[3] = picPizza4;
            pizzasInOven[4] = picPizza5;
            pizzasInOven[5] = picPizza6;
            pizzasInOven[6] = picPizza7;
            pizzasInOven[7] = picPizza8;
            grpOven.Enabled = false;
            grpCar.Enabled = false;
            tmrClock.Interval = mSecPerMin;
            tmrOven.Interval = mSecPerMin;
            tmrCar.Interval = mSecPerMin * minPer20Squares / 20;
            gameOverSound = new System.Media.SoundPlayer
                (Application.StartupPath + "\\tada.wav");
            phoneSound = new System.Media.SoundPlayer
                (Application.StartupPath + "\\phone.wav");
            dingSound = new System.Media.SoundPlayer
                (Application.StartupPath + "\\ding.wav");
            beepSound = new System.Media.SoundPlayer
                (Application.StartupPath + "\\carbeep.wav");


        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            int clockMinutes;
            int c, r;
            String s;
            bool expired = false;
            clockMinute++;
            if (clockMinute > 59)
            {
                clockMinute = 0;
                clockHour++;
                if (clockHour == 11)
                {
                    lblTime.Text = "11:00";
                    btnExitStop.PerformClick();
                    return;
                }
            }
            lblTime.Text = clockHour.ToString() + ":";
            if (clockMinute < 10)
                lblTime.Text += "0";
            lblTime.Text += clockMinute.ToString();
            // check for late orders - check to if first is expired
            clockMinutes = clockMinute + 60 * clockHour;
            if (lstOrders.Items.Count != 0)
            {
                for (int i = 0; i < lstOrders.Items.Count; i++)
                {
                    s = lstOrders.Items[i].ToString();
                    c = ((int)s[6]) - 64;
                    r = Convert.ToInt32(s.Substring(8, 2));
                    if (i == 0 && clockMinutes - pizzaTime[c, r]
                    >= orderMaxTime)
                    {
                        expired = true;
                        deliveryGrid[c, r].BackColor =
                        Color.White;
                        deliveryGrid[c, r].Text = "";
                        missedDeliveries += pizzas[c, r];
                        pizzas[c, r] = 0;
                    }
                    else if (clockMinutes - pizzaTime[c, r] >=
                    orderLateTime)
                    {
                        deliveryGrid[c, r].BackColor =
                        Color.DarkRed;
                    }
                }
                if (expired)
                    lstOrders.Items.RemoveAt(0);
            }
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (btnStartPause.Text == "Start Game")
            {
                btnStartPause.Text = "Pause Game";
                btnExitStop.Text = "Stop Game";
                // clear grid
                for (int i = 1; i < 21; i++)
                {
                    for (int j = 1; j < 21; j++)
                    {
                        deliveryGrid[i, j].BackColor =
                        Color.White;
                        deliveryGrid[i, j].Text = "";
                        pizzas[i, j] = 0;
                        pizzaTime[i, j] = 0;
                    }
                }
                lstOrders.Items.Clear();
                for (int i = 0; i < 8; i++)
                    pizzasInOven[i].Visible = false;
                pizzasBaking = 0;
                pizzasReady = pizzasBakingMax;
                totalPizzasBaked = pizzasReady;
                lblPizzasReady.Text = pizzasReady.ToString();
                pizzasInCar = 0;
                lblInCar.Text = "0";
                btnLoadCar.Enabled = true;
                // initialize pizza parlor and car location
                deliveryGrid[carC, carR].Image = null;
                pizzaC = rnd.Next(2, 19);
                pizzaR = rnd.Next(2, 19);
                deliveryGrid[pizzaC, pizzaR].BackColor =
                Color.Black;
                deliveryGrid[pizzaC, pizzaR].Text = "X";
                carC = pizzaC;
                carR = pizzaR;
                mileage = 0;
                pizzasOnTime = 0;
                pizzasLate = 0;
                missedDeliveries = 0;
                totalSales = 0;
                lblSales.Text = "$0.00";
                lblMessage.Text = "Car at Pizza Parlor:\r\n" + Display(carC, carR);
                clockHour = 6;
                clockMinute = 0;
                lblTime.Text = "6:00";
                tmrClock.Enabled = true;
                tmrPhone.Interval = mSecPerMin * rnd.Next(1, 8);
                tmrPhone.Enabled = true;
                ovenGoing = tmrOven.Enabled;
                tmrOven.Enabled = false;
                grpOven.Enabled = true;
                grpCar.Enabled = true;
            }
            else if (btnStartPause.Text == "Pause Game")
            {
                btnStartPause.Text = "Restart Game";
                btnExitStop.Enabled = false;
                tmrClock.Enabled = false;
                tmrPhone.Enabled = false;
                ovenGoing = tmrOven.Enabled;
                tmrOven.Enabled = false;
                carGoing = tmrCar.Enabled;
                tmrCar.Enabled = false;
                grpOven.Enabled = false;
                grpCar.Enabled = false;
            }
            else
            {
                // game restarted
                btnStartPause.Text = "Pause Game";
                btnExitStop.Enabled = true;
                tmrClock.Enabled = true;
                tmrPhone.Enabled = true;
                tmrOven.Enabled = ovenGoing;
                tmrCar.Enabled = carGoing;
                grpOven.Enabled = true;
                grpCar.Enabled = true;
            }
        }

        private void btnExitStop_Click(object sender, EventArgs e)
        {
            if (btnExitStop.Text == "Stop Game")
            {
                gameOverSound.Play();
                btnExitStop.Text = "Exit";
                btnStartPause.Text = "Start Game";
                tmrClock.Enabled = false;
                tmrPhone.Enabled = false;
                tmrOven.Enabled = false;
                tmrCar.Enabled = false;
                grpOven.Text = "Oven Off";
                grpOven.BackColor = Color.Blue;
                for (int i = 0; i < 8; i++)
                    pizzasInOven[i].Visible = false;
                btnAddPizza.Enabled = true;
                btnBakePizza.Enabled = true;
                grpOven.Enabled = false;
                grpCar.Enabled = false;
                // bring up sales report
                Form salesReport = new SalesResults(clockHour, clockMinute, 
                    pizzasOnTime, netSoldPizza, pizzasLate, netLatePizza, 
                    totalPizzasBaked, pizzaCost, mileage, mileageCost, 
                    missedDeliveries, costMissedPizza);
                salesReport.ShowDialog();
            }
            else
            {
                this.Close();
            }
        }

        private void tmrPhone_Tick(object sender, EventArgs e)
        {
            {
                int i, j, k;
                String order;
                phoneSound.Play();
                if (clockHour == 10 && clockMinute >= 30)
                {
                    tmrPhone.Enabled = false;
                    return;
                }
                do
                {
                    i = rnd.Next(1, 21);
                    j = rnd.Next(1, 21);
                }
                while (pizzas[i, j] != 0);
                k = rnd.Next(1, 100);
                if (k <= 29)
                    pizzas[i, j] = 1;
                else if (k <= 49)
                    pizzas[i, j] = 2;
                else if (k <= 69)
                    pizzas[i, j] = 3;
                else if (k <= 84)
                    pizzas[i, j] = 4;
                else
                    pizzas[i, j] = 5;
                pizzaTime[i, j] = clockMinute + 60 * clockHour;

                // build string listing order
                order = lblTime.Text + " ";
                if (lblTime.Text.Length == 4)
                    order = " " + order;
                order += ((char)(i + 64)).ToString() + " ";
                if (j < 10)
                    order += " ";
                order += j.ToString() + " -> " + pizzas[i,
                j].ToString();
                lstOrders.Items.Add(order);
                lstOrders.Refresh();
                deliveryGrid[i, j].BackColor = Color.DarkGreen;
                deliveryGrid[i, j].Text = pizzas[i, j].ToString();
                tmrPhone.Interval = mSecPerMin * rnd.Next(1, 8);
            }
        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            {
                pizzasBaking++;
                pizzasInOven[pizzasBaking - 1].Visible = true;
                if (pizzasBaking == pizzasBakingMax)
                    btnAddPizza.Enabled = false;
            }
        }

        private void btnBakePizza_Click(object sender, EventArgs e)
        {

            int hOut, mOut;
            if (pizzasBaking == 0)
                return;
            grpOven.BackColor = Color.Red;
            btnAddPizza.Enabled = false;
            btnBakePizza.Enabled = false;
            hOut = clockHour;
            mOut = clockMinute + bakingTime;
            if (mOut > 59)
            {
                mOut -= 60;
                hOut++;
            }
            if (pizzasBaking == 1)
                grpOven.Text = "Pizza Out At ";
            else
                grpOven.Text = "Pizzas Out At ";
            grpOven.Text += hOut.ToString() + ":";
            if (mOut < 10)
                grpOven.Text += "0";
            grpOven.Text += mOut.ToString();
            bakingMinutesLeft = bakingTime;
            tmrOven.Enabled = true;

        }

        private void tmrOven_Tick(object sender, EventArgs e)
        {

            if (bakingMinutesLeft != 0)
                bakingMinutesLeft--;
            else
            {
                dingSound.Play();
                tmrOven.Enabled = false;
                pizzasReady += pizzasBaking;
                totalPizzasBaked += pizzasBaking;
                if (pizzasReady > pizzasReadyMax)
                    pizzasReady = pizzasReadyMax;
                lblPizzasReady.Text = pizzasReady.ToString();
                grpOven.Text = "Oven Off";
                grpOven.BackColor = Color.Blue;
                for (int i = 0; i < 8; i++)
                    pizzasInOven[i].Visible = false;
                pizzasBaking = 0;
                btnAddPizza.Enabled = true;
                btnBakePizza.Enabled = true;
            }
        }

        private void btnLoadCar_Click(object sender, EventArgs e)
        {
            if (pizzasReady == 0)
                return;
            if (pizzasReady > pizzasInCarMax)
            {
                pizzasInCar += pizzasInCarMax;
                pizzasReady -= pizzasInCarMax;
            }
            else
            {
                pizzasInCar += pizzasReady;
                pizzasReady = 0;
            }
            lblPizzasReady.Text = pizzasReady.ToString();
            lblInCar.Text = pizzasInCar.ToString();
            btnLoadCar.Enabled = false;
        }

        private String Display(int c, int r)
        {
            return (((char)(c + 64)).ToString() + " " +
            r.ToString());
        }

        private void DeliveryGrid_Click(object sender, EventArgs e)
        {
            Label gridClicked;
            if (!tmrCar.Enabled && grpCar.Enabled &&
            !btnLoadCar.Enabled)
            {
                gridClicked = (Label)sender;
                deliveryC =
                Convert.ToInt32(gridClicked.Tag.ToString().Substring(0, 2))
                ;
                deliveryR =
                Convert.ToInt32(gridClicked.Tag.ToString().Substring(2, 2))
                ;
                deltaC = deliveryC - carC;
                deltaR = deliveryR - carR;
                if (deltaC == 0 && deltaR == 0)
                    return;
                lblMessage.Text = "Car Going To:\r\n" +
                Display(deliveryC, deliveryR);
                tmrCar.Enabled = true;
            }

        }

        private void tmrCar_Tick(object sender, EventArgs e)
        {
            Image carImage;
            int i, c, r;
            String s;
            deliveryGrid[carC, carR].Image = null;
            // move horizontally first
            if (deltaC != 0)
            {
                mileage++;
                carImage = picHCar.Image;
                carC += Math.Sign(deltaC);
                deltaC = deliveryC - carC;
            }
            else
            {
                mileage++;
                carImage = picVCar.Image;
                carR += Math.Sign(deltaR);
                deltaR = deliveryR - carR;
            }
            deliveryGrid[carC, carR].Image = carImage;
            if (carC == deliveryC && carR == deliveryR)
            {
                beepSound.Play();
                tmrCar.Enabled = false;
                if (carC == pizzaC && carR == pizzaR)
                {
                    lblMessage.Text = "Car at Pizza Parlor:\r\n" +
                    Display(carC, carR);
                    deliveryGrid[carC, carR].Image = null;

                    pizzasInCar = 0;
                    lblInCar.Text = "0";
                    btnLoadCar.Enabled = true;
                }
                else
                {
                    lblMessage.Text = "Car at " + Display(carC,
                    carR);
                    // check delivery status
                    if (pizzas[deliveryC, deliveryR] == 0)
                    {
                        lblMessage.Text += "\r\nNo Pizza Wanted";
                    }
                    else
                    {
                        if (pizzas[deliveryC, deliveryR] >
                        pizzasInCar)
                        {
                            lblMessage.Text += "\r\nNot Enough Pizzas";
                        }
                        else
                        {
                            lblMessage.Text += "\r\nDelivered " +
                            pizzas[deliveryC, deliveryR].ToString() + " Pizza";
                            if (pizzas[deliveryC, deliveryR] > 1)
                                lblMessage.Text += "s";
                            // see if on-time
                            if ((clockMinute + 60 * clockHour) -
                            pizzaTime[deliveryC, deliveryR] <= orderLateTime)
                            {
                                lblMessage.Text += ": On-Time";
                                totalSales += pizzas[deliveryC, deliveryR] * netSoldPizza;
                                pizzasOnTime += pizzas[deliveryC, deliveryR];
                            }
                            else
                            {
                                lblMessage.Text += ": Late!";
                                totalSales += pizzas[deliveryC, deliveryR] * netLatePizza;
                                pizzasLate += pizzas[deliveryC, deliveryR];
                            }
                            lblSales.Text = "$" +
                            totalSales.ToString();
                            pizzasInCar -= pizzas[deliveryC, deliveryR];
                            lblInCar.Text =
                            pizzasInCar.ToString();
                            pizzas[deliveryC, deliveryR] = 0;
                            deliveryGrid[deliveryC, deliveryR].BackColor = Color.White;
                            deliveryGrid[deliveryC, deliveryR].Text = "";
                            // remove from list
                            for (i = 0; i < lstOrders.Items.Count;
                            i++)
                            {
                                s = lstOrders.Items[i].ToString();
                                c = ((int)s[6]) - 64;
                                r =
                                Convert.ToInt32(s.Substring(8, 2));
                                if (c == deliveryC && r ==
                                deliveryR)
                                    break;
                            }
                            lstOrders.Items.RemoveAt(i);
                        }
                    }
                }
            }
        }

    }
}
