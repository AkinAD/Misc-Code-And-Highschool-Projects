/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - STARTUP
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : MAKES YOU CREATE USERNAME AND PASSWORD 
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
    public partial class frmStart : Form
    {
        public static string User;
        public static string Password ;
            
        public frmStart()
        {
            InitializeComponent();
        }

       // GLOBAL VARIABLES
        Random rnd = new Random();
        int m;

        private void btnCreate_Click(object sender, EventArgs e)
        {
              User = txtUser.Text;
              Password = txtPass.Text;
            if (txtUser.Text == "Enter Username")
            {

                MessageBox.Show("UserName and password required ", "Error");

            }
            else
            {
                lblUserN.Text = "User : " + User;
            }

            if (txtPass == null)
            {
                MessageBox.Show("UserName and password required ", "Error");

            }

            tmrStart.Start();
            tmrLogin.Start();

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = true;
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Enter Password")
            {
              txtPass.Text = ""; 
            }
            else
            {
                btnCreate.Enabled = true;
            }
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text == "Enter Username")
            {
                txtUser.Text = "";
            }
            else
            {
                btnCreate.Enabled = true;
            }
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtUser.Text = "";
        }

        private void tmrLogin_Tick(object sender, EventArgs e)
        {
            int Login;
            Login = rnd.Next(1, 11);
            Login++;
            switch (Login)
            {
                    //STARTUP ANIMATION :D

                case 1:
                    picAnimate.Image = Properties.Resources.AKIN1;
                    break;
                case 2:
                    picAnimate.Image = Properties.Resources.AKIN2;
                    break;
                case 3:
                    picAnimate.Image = Properties.Resources.AKIN3;
                    break;
                case 4:
                    picAnimate.Image = Properties.Resources.AKIN4;
                    break;
                case 5:
                    picAnimate.Image = Properties.Resources.AKIN5;
                    break;
                case 6:
                    picAnimate.Image = Properties.Resources.AKIN6;
                    break;
                case 7:
                    picAnimate.Image = Properties.Resources.AKIN7;
                    break;
                case 8:
                    picAnimate.Image = Properties.Resources.AKIN8;
                    break;
                case 9:
                    picAnimate.Image = Properties.Resources.AKIN9;
                    break;
                case 10:
                    picAnimate.Image = Properties.Resources.AKIN10;
                    break;
                case 11:
                    picAnimate.Image = Properties.Resources.AKIN11;
                    break;
                case 12 :
                    picAnimate.Image = Properties.Resources.AKIN12;
                    Login = 0;
                    break;


            }
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            m = m + 10;
            if (m == 180)
            {   
                
                new frmScoreBoard().Show();                     //SHOW SCOREBOARD AND START FOMR UPON STARTUP
                new frmCPT().Show();
                
                
                tmrStart.Stop();
                this.Hide();
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            //if (txtUser.Text == "")
            //{
            //    txtUser.Text = "Enter Username";
            //    btnCreate.Enabled = false;
            //}
            //else
            //{

            //}
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            //if (txtUser.Text == "Enter Password")
            //{
            //    txtUser.Text = "";
            //    btnCreate.Enabled = false;
            //}
            //else
            //{

            //}
        }
    }
}
