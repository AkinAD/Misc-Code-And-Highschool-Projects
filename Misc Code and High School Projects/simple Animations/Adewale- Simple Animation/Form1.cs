using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adewale__Simple_Animation
{
    public partial class frmInvasion : Form
    {
        public frmInvasion()
        {
            InitializeComponent();
        }
        Graphics myGraphics;
        int imageY;
        int ImageX;
        int imageDirX;
        int imageDir;
        
        Brush blankBrush;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInvasion_Load(object sender, EventArgs e)
        {
            myGraphics = pnlDisplay.CreateGraphics();
            blankBrush = new SolidBrush(pnlDisplay.BackColor);
            
        }

        private void frmInvasion_FormClosing(object sender, FormClosingEventArgs e)
        {
            myGraphics.Dispose();
            blankBrush.Dispose();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           // tmrHover.Enabled = !(tmrHover.Enabled);
            if (btnStart.Text == "Start Invasion")
            {
                tmrHover.Enabled = true;
                tmrHoverX.Enabled = true;
                btnStart.Text = "Stop Invasion";
            }
            else if (btnStart.Text == "Stop Invasion")
            {
                btnStart.Text = "Start Invasion";
                tmrHover.Enabled = false;
                tmrHoverX.Enabled = false;
            }

                imageY = 0;

                imageDir = 1;
                imageDirX = 1;
            
        }

        private void tmrHover_Tick(object sender, EventArgs e)
        {
            int imageX = 10;
            int imageW = 149;
            int imageH = 37;

            if (radVertical.Checked == true)
            {
                tmrHoverX.Enabled = false;
                imageX = (int)(0.7 * (pnlDisplay.Height - imageW));

                myGraphics.FillRectangle(blankBrush, imageX, imageY, imageW, imageH);

                imageY = imageY + imageDir * pnlDisplay.Height / 40;

                myGraphics.DrawImage(picAlien.Image, imageX, imageY, imageW, imageH);
                if (imageY + imageH > pnlDisplay.Height)
                {
                    imageY = pnlDisplay.Height - imageH;
                    imageDir = -1;
                }
                else if (imageY < 0)
                {
                    imageY = 0;
                    imageDir = 1;
                }

            }
            else
            {
                tmrHoverX.Enabled = true;
            }
        }

        private void tmrHoverX_Tick(object sender, EventArgs e)
        {
            int ImageY = 10;
            int imageW = 149;
            int imageH = 37;

            if (radHorizontal.Checked == true)
            {
                tmrHover.Enabled = false;

                myGraphics.FillRectangle(blankBrush, ImageX, ImageY, imageW, imageH);
                 myGraphics.DrawImage(picAlien.Image, ImageX, ImageY, imageW, imageH);
                ImageX = ImageX + imageDirX * pnlDisplay.Width / 4;

               
                if (ImageX + imageW > pnlDisplay.Width)
                {
                    ImageX = pnlDisplay.Width - imageW;
                    imageDirX = -1;
                }
                else if (ImageX < 0)
                {
                   ImageX = 0;
                    imageDirX = 1;
                }


            }
            else
            {
                tmrHover.Enabled = true;
                tmrHoverX.Enabled = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        } 

            
      
    }
}
