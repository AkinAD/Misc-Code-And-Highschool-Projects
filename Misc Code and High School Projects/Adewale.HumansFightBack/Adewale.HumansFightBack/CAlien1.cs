using Adewale.HumansFightBack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adewale.HumansFightBack
{
    class CAlien1 : CImageBase
    {
        private Rectangle Alien1Hotspot = new Rectangle();
        public CAlien1() : base(Resources.martian_manhunter)

        {
            Alien1Hotspot.X = Left + 126;
            Alien1Hotspot.Y = Top - 6;
            Alien1Hotspot.Width = 65;
            Alien1Hotspot.Height = 60;
        }


        public void Update1(int X, int Y)
        {
            Left = X;
            Top = Y;
            Alien1Hotspot.X = Left - 1;
            Alien1Hotspot.Y = Top + 2;
        }
        public bool Hit(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1); // way to check for hit
            if (Alien1Hotspot.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}