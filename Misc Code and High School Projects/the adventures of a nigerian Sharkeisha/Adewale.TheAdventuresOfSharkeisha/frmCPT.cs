/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - START fORM
 * DATEE CREATED : 01 -06 -2015
 * DESCRIPTION : START UP FORM FOR ALL OTHER FORMS IN PROGRAM
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
    public partial class frmCPT : Form
    {          public static bool UGH;
             string User;
             public static bool gameover = false;
        public frmCPT()
        {
            InitializeComponent();
           User = frmStart.User;
        }
        
       

        private void btnTheDance_Click(object sender, EventArgs e)
        {
            new frmParty().Show();
            this.Hide();
        }

        private void btnHood_Click(object sender, EventArgs e)
        {
            new frmMovingBlocks().Show();
            this.Hide();
        }

        private void btnMaze_Click(object sender, EventArgs e)
        {
            new frmMaze().Show();
            this.Hide();
        }

        private void btnDrinks_Click(object sender, EventArgs e)
        {
            new frmDrinks().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSlots_Click(object sender, EventArgs e)
        {
            new frmSlots().Show();
            this.Hide();
        }

        private void btnBonus_Click(object sender, EventArgs e)
        {
            new frmPassword().Show();
            this.Hide();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutBox1().Show();
            
        }

        private void frmCPT_FormClosing(object sender, FormClosingEventArgs e)
        {
            gameover = true;
            Application.Exit();
        }

        public void btnCreate_Click(object sender, EventArgs e)
        {
           

          
        }

        private void frmCPT_Load(object sender, EventArgs e)
        {
            lblUserN.Text = "User : " + User;   
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void showScoreboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmScoreBoard().Show();

           

          
        }
    }
}
