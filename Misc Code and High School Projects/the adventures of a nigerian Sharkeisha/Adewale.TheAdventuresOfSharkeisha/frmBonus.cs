/* CREATED BY : ADEWALE AKIN
 * PROGRAM NAME: CPT - BONUS FORM
 * DATEE CREATED : 02 -06 -2015
 * DESCRIPTION : START FORM FOR BONUS GAME
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
    public partial class frmBonus : Form
    {
        public frmBonus()
        {
            InitializeComponent();
        }

        private void btnPingPong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Its pretty much like your basic ping pong game, use cursor to move the racket and try to keep up \r\n Press E to Exit \r\n PRess R to Restart", "Instructions");
            new frmPingPong().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
           
        }

        private void frmBonus_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
