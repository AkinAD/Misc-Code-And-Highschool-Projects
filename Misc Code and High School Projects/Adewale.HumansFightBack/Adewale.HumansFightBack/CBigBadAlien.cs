using Adewale.HumansFightBack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adewale.HumansFightBack
{
    class CBigBadAlien : CImageBase
    {
        private Rectangle BigBadAlienHotspot = new Rectangle();
        public CBigBadAlien() : base(Resources.Alien21)

        {
            BigBadAlienHotspot.X = Left + 126;
            BigBadAlienHotspot.Y = Top - 6;
            BigBadAlienHotspot.Width = 65;
            BigBadAlienHotspot.Height = 60;
        }


        public void Update5(int X, int Y)
        {
            Left = X;
            Top = Y;
            BigBadAlienHotspot.X = Left - 1;
            BigBadAlienHotspot.Y = Top + 2;
        }
        public bool Hit(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1); // way to check for hit
            if (BigBadAlienHotspot.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}
