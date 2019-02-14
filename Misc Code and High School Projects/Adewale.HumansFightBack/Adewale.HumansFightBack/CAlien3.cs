using Adewale.HumansFightBack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adewale.HumansFightBack
{
    class CAlien3 : CImageBase
    {
        private Rectangle Alien3Hotspot = new Rectangle();
        public CAlien3() : base(Resources.Alien2)

        {
            Alien3Hotspot.X = Left + 126;
            Alien3Hotspot.Y = Top - 6;
            Alien3Hotspot.Width = 65;
            Alien3Hotspot.Height = 60;
        }


        public void Update3(int X, int Y)
        {
            Left = X;
            Top = Y;
            Alien3Hotspot.X = Left - 1;
            Alien3Hotspot.Y = Top + 2;
        }
        public bool Hit(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1); // way to check for hit
            if (Alien3Hotspot.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}
