using Adewale.HumansFightBack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adewale.HumansFightBack
{
    class CAlien2 : CImageBase
    {
        private Rectangle Alien2Hotspot = new Rectangle();
        public CAlien2() : base(Resources._2531580_tumblr_m7wqdhyyuq1r1203yo1_1280)

        {
            Alien2Hotspot.X = Left + 126;
            Alien2Hotspot.Y = Top - 6;
            Alien2Hotspot.Width = 65;
            Alien2Hotspot.Height = 60;
        }


        public void Update2(int X, int Y)
        {
            Left = X;
            Top = Y;
            Alien2Hotspot.X = Left - 1;
            Alien2Hotspot.Y = Top + 2;
        }
        public bool Hit(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1); // way to check for hit
            if (Alien2Hotspot.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}
