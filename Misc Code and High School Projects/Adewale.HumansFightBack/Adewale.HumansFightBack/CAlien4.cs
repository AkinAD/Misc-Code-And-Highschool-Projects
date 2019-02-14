using Adewale.HumansFightBack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adewale.HumansFightBack
{
    class CAlien4 : CImageBase
    {
        private Rectangle Alien4Hotspot = new Rectangle();
        public CAlien4() : base(Resources.alien1)

        {
            Alien4Hotspot.X = Left + 126;
            Alien4Hotspot.Y = Top - 6;
            Alien4Hotspot.Width = 65;
            Alien4Hotspot.Height = 60;
        }


        public void Update4(int X, int Y)
        {
            Left = X;
            Top = Y;
            Alien4Hotspot.X = Left ;
            Alien4Hotspot.Y = Top;
        }
        public bool Hit(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1); // way to check for hit
            if (Alien4Hotspot.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}
