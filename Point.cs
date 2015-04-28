using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace JP_Painter
{
    class Point
    {
        public double X, Y;
        public double Width = 0;

        public Point(double x, double y, double width)
        {
            X = x;
            Y = y;
            Width = width;
        }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
            Width = 0;
        }

        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            Width = p.Width;
        }

        public Point(System.Drawing.Point p)
        {
            X = p.X;
            Y = p.Y;
        }

        public Point(System.Drawing.Point p, double width)
        {
            X = p.X;
            Y = p.Y;
            Width = width;
        }

        public Point(PointF p)
        {
            X = p.X;
            Y = p.Y;
        }

        public Point(PointF p, double width)
        {
            X = p.X;
            Y = p.Y;
            Width = width;
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public double Distance(Point p)
        {
            return Distance(p.X, p.Y);
        }

        public double Distance(PointF p)
        {
            return Distance(p.X, p.Y);
        }

        public double Distance(double x, double y)
        {
            double a = (double)x - (double)X;
            double b = (double)y - (double)Y;

            return Math.Sqrt(a * a + b * b);
        }

        public Point Middle(Point p)
        {
            Point m = new Point(this);

            m.X = Lib.Average(X, p.X);
            m.Y = Lib.Average(Y, p.Y);
            m.Width = Lib.Average(Width, p.Width);

            return m;
        }

        public PointF ToPointF()
        {
            return new PointF((float)X, (float)Y);
        }

        public System.Drawing.Point ToPoint()
        {
            return new System.Drawing.Point((int)X, (int)Y);
        }

    }
}
