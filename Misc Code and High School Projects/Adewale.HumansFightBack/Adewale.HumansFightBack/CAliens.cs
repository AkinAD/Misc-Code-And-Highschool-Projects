using Adewale.HumansFightBack.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adewale.HumansFightBack
{
    class CAliens : CImageBase
    {        private Rectangle AlienHotspot = new Rectangle();
        public CAliens(): base (Resources.bloob)

        {
            AlienHotspot.X = Left + 126;
            AlienHotspot.Y = Top - 6;
            AlienHotspot.Width = 65;
            AlienHotspot.Height = 60;
        }
      

         public void Update (int X, int Y)
        {
            Left = X;
            Top = Y;
            AlienHotspot.X = Left-1  ;
            AlienHotspot.Y = Top +2 ;
        }
        public bool Hit(int X, int Y)
        {
            Rectangle c = new Rectangle(X, Y, 1, 1); // way to check for hit
            if (AlienHotspot.Contains(c))
            {
                return true;
            }
            return false;
        }
    }
}
