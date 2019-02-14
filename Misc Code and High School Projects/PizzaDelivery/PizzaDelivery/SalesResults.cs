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
    public partial class SalesResults : Form
    {
        public SalesResults()
        {
            InitializeComponent();
        }
        
        public SalesResults(int clockHour, int clockMinute, 
            int pizzasOnTime, int netSoldPizza, int pizzasLate, 
            int netLatePizza, int totalPizzasBaked, int pizzaCost, 
            int mileage, double mileageCost, int missedDeliveries, 
            int costMissedPizza)
        {
            double totalSales, totalCosts;
            InitializeComponent();

            // populate label controls
            lblStopTime.Text = "Stop Time: " +
            clockHour.ToString() + ":";
            if (clockMinute < 10)
                lblStopTime.Text += "0";
            lblStopTime.Text += clockMinute.ToString();
            lblOnTime.Text = pizzasOnTime.ToString() + " On-Time Deliveries";
            lblOnTimeSales.Text = "$" + (pizzasOnTime *
            netSoldPizza).ToString();
            lblLate.Text = pizzasLate.ToString() + " Late Deliveries";
            lblLateSales.Text = "$" + (pizzasLate *
            netLatePizza).ToString();
            totalSales = pizzasOnTime * netSoldPizza + pizzasLate
            * netLatePizza;
            lblSales.Text = "$" + totalSales.ToString();
            lblBaked.Text = totalPizzasBaked.ToString() + " Pizzas Baked";
            lblBakedCosts.Text = "$" + (totalPizzasBaked *
            pizzaCost).ToString();
            lblMiles.Text = mileage.ToString() + " Units Driven";
            lblMilesCosts.Text = "$" + (mileage *
            mileageCost).ToString();
            lblMissed.Text = missedDeliveries.ToString() + " Missed Deliveries";
            lblMissedCosts.Text = "$" + (missedDeliveries *
            costMissedPizza).ToString();
            totalCosts = totalPizzasBaked * pizzaCost + mileage *
            mileageCost + missedDeliveries * costMissedPizza;
            lblCosts.Text = "$" +
            Convert.ToInt32(totalCosts).ToString();
            lblProfits.Text = "$" + Convert.ToInt32(totalSales -
            totalCosts).ToString();
            if (clockHour > 6)
            {
                // only show hourly profits if been selling for more than one hour
                lblHourly.Visible = true;
                lblHourlyProfits.Visible = true;
                double hours = clockHour - 6 +
                Convert.ToDouble(clockMinute) / 60;
                lblHourly.Text = "$" + Convert.ToInt32((totalSales
                - totalCosts) / hours).ToString();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
