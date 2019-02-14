using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adewale.PoliceRushHour_Pizza_Delivery_
{
    public partial class Sales_Results : Form
    {
        private int clockHour;
        private int clockMinute;

        public Sales_Results()
        {
            InitializeComponent();
        }

        public Sales_Results(int clockHour, int clockMinute)
        {
            this.clockHour = clockHour;
            this.clockMinute = clockMinute;
        }

        public Sales_Results(int ClockHour, int ClockMinute, int pizzaOnTime,int pizzaLate,
            int netSoldPizza,int netLatePizza, int totalPizzasBaked, int CostOfPizza, int mileage,
            double mileageCost, int missedDeliveries, int costMissedPizza)
        {
            double totalSales, totalCosts;
            InitializeComponent();
            // populate label controls 
            lblStopTime.Text = "Stop Time: " + ClockHour.ToString() + ":";
            if (ClockMinute < 10)
                lblStopTime.Text += "0";
           lblStopTime.Text += ClockMinute.ToString();
            lblOnTime.Text = pizzaOnTime.ToString() + " On- Time Deliveries";
            lblOnTimeSales.Text = "$" + (pizzaOnTime * netSoldPizza).ToString();
            lblLate.Text = pizzaLate.ToString() + "Late Deliveries";
            lblLateSales.Text = "$" + (pizzaLate * netLatePizza).ToString();
            totalSales = pizzaOnTime * netLatePizza + pizzaLate * netLatePizza;
            lblSales.Text = "$" + totalSales.ToString();
            lblBaked.Text = totalPizzasBaked.ToString() + "Pizzas Baked";
            lblBakedCosts.Text = "$" + (totalPizzasBaked * CostOfPizza).ToString();
            lblMiles.Text = mileage.ToString() + " Units Driven";
            lblMilesCost.Text = "$" + (mileage * mileageCost).ToString();
            lblMissed.Text = missedDeliveries.ToString() + " Missed Deliveries";
            lblMissedCosts.Text = "$" + (missedDeliveries * costMissedPizza).ToString();
            totalCosts = totalPizzasBaked * CostOfPizza + mileage * mileageCost + missedDeliveries * costMissedPizza;
            lblCosts.Text = "$" + Convert.ToInt32(totalCosts).ToString();
            lblProfits.Text = "$" + Convert.ToInt32(totalSales - totalCosts).ToString();

            if (ClockHour > 4)
            {
                //only show ourly profits if sales have been occurring for more than one hour
                lblHourly.Visible = true;
                lblHourlyProfits.Visible = true;
                double hours = ClockHour - 4 + Convert.ToDouble(ClockMinute) / 60;
                lblHourly.Text = "$" + Convert.ToInt32((totalSales - totalCosts) / hours).ToString();
               
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
