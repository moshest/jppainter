using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace JP_Painter
{
    class Canvas
    {
        Panel panel;
        Graphics g = null;

       public int Width
        {
            get { return panel.Width; }
        }

        public int Height
        {
            get { return panel.Height; }
        }

        public Canvas(Panel panel)
        {
            this.panel = panel;
        }

        public Graphics CreateGraphics()
        {
            if(g != null)
                g.Dispose();

            g = panel.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            return g;
        }

        public void Clear()
        {
            if (g != null)
                g.Dispose();

            Graphics g2 = panel.CreateGraphics();
            g2.Clear(panel.BackColor);
            g2.Dispose();
        }

        public void Update()
        {
            if (g == null)
                return;

            g.Dispose();
            g = null;
        }
    }
}
