using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adewale.HumansFightBack
{
    class CImageBase : IDisposable  
    {
        bool Disposed = false;
        Bitmap bitmap;
        private int X;
        private int Y;
         
        public int Left { get { return X; } set { X = value; } }
        public int Top { get { return Y; } set { Y = value; } }
        public CImageBase(Bitmap Resource)
        {
            bitmap = new Bitmap(Resource);
        }
        public void DrawImage(Graphics gfx)
        {
            gfx.DrawImage(bitmap, X, Y);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
        protected virtual void Dispose (bool Disposing)
        {
            if (Disposed)
            {
                return;
            }
            if (Disposing)
            {

                bitmap.Dispose();
            }
            Disposed = true;
        }

    }
}
