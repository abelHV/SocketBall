using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace SocketBall.CLASSES
{
     public class clPala
    {
        public Rectangle Rect { get; set; }
        public Color ColorPala { get; set; } = Color.White;

        public clPala(int x, int y, int w = 20, int h = 100)
        {
            Rect = new Rectangle(x, y, w, h);
        }

        public void Moure(int mouseX, int mouseY, int fW, int fH)
        {
            int nX = mouseX - (Rect.Width / 2);
            int nY = mouseY - (Rect.Height / 2);

            if (nX < 0) nX = 0;
            if (nX + Rect.Width > fW) nX = fW - Rect.Width;
            if (nY < 0) nY = 0;
            if (nY + Rect.Height > fH) nY = fH - Rect.Height;

            Rect = new Rectangle(nX, nY, Rect.Width, Rect.Height);
        }

        public void Dibuixar(Graphics g)
        {
            using (SolidBrush sb = new SolidBrush(ColorPala)) g.FillRectangle(sb, Rect);
        }
    }
}
