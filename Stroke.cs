using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace JP_Painter
{
    class Stroke
    {
        const double EPSILON = 0.001;

        
        public Color Color;
        public List<Point> Points;
        public double Width;

        Canvas canvas;

        public Stroke(Canvas canvas, Color color, double width, Point[] points)
        {
            this.canvas = canvas;
            Color = color;
            Width = width;
            setPoints(points);
        }

        public Stroke(Canvas canvas, Color color, Point[] points)
        {
            this.canvas = canvas;
            Color = color;
            Width = 1;
            setPoints(points);
        }

        private void setPoints(Point[] points)
        {
            Points = new List<Point>();

            Points.Add(points[0]);
            double ratio = canvas.Width / canvas.Height;
            for (int i = 1; i < points.Length; i++)
            {
                Point last = Points.Last();
                if (last.Distance(points[i]) > 50)
                {
                    Points.Add(generatePoint(
                        last.Middle(points[i]),
                        canvas.Width / (3.0 * ratio),
                        canvas.Height / 3.0
                   ));
                }

                Points.Add(points[i]);
            }

            List<Point> points2 = new List<Point>();
            for (int s = 0; s + 3 < Points.Count; s += 3)
            {
                double accuracy = 0.01;
                for (double t = accuracy; t < 1 + accuracy; t += accuracy)
                {
                    Point p = GetBPoint(t, s, 4);

                    points2.Add(p);
                }

                points2.Add(Points[s+3]);
            }

            Points = points2;

            int randNum = (int) (Points.Count * 0.2);
            int range = (int)(Points.Count * 0.1);
            for (int i = 0; i < randNum; i++)
            {
                int pos = (int) Lib.RandRange(0, Points.Count - 1);

                Points[pos].Width = Lib.Average(Lib.RandExp(0.13), Points[pos].Width);

                for (int j = 1; j < range; j++)
                {
                    if (pos + j < Points.Count)
                        Points[pos + j].Width = Lib.Average(Points[pos + j - 1].Width, Points[pos + j].Width);

                    if (pos - j >= 0)
                        Points[pos - j].Width = Lib.Average(Points[pos - j + 1].Width, Points[pos - j].Width);
                }
            }

        }

        public void draw()
        {
            Pen pen = new Pen(this.Color);
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;

            Graphics g = canvas.CreateGraphics();

            Point p1 = null;
            int counter = 0;
            foreach (Point p2 in Points)
            {
                counter++;
                if (p1 != null)
                {
                    pen.Width = (float)(((p1.Width + p2.Width) / 2.0) + Lib.RandRange(-1, 1));
                    g.DrawLine(pen, p1.ToPoint(), p2.ToPoint());

                    if (Lib.RandRange(0, 1) < 0.05)
                    {
                        g.FillEllipse(
                            pen.Brush,
                            (float)(p2.X + 1.5 * Lib.RandNormal(0, pen.Width * 0.5)),
                            (float)(p2.Y + 1.5 * Lib.RandNormal(0, pen.Width * 0.5)),
                            (float)(pen.Width * Lib.RandRange(0.2, 0.6)),
                            (float)(pen.Width * Lib.RandRange(0.2, 0.6))
                        );
                    }

                    if (counter == Points.Count * 0.1)
                    {
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    } else if (counter == Points.Count * 0.9)
                    {
                        pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                        pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    }

                    if (Lib.RandRange(0, 1) < 0.03)
                    {
                        g.FillEllipse(
                            pen.Brush,
                            (float)(Lib.RandRange(0, canvas.Width)),
                            (float)(Lib.RandRange(0, canvas.Height)),
                            (float)(pen.Width * Lib.RandRange(0.2, 0.6)),
                            (float)(pen.Width * Lib.RandRange(0.2, 0.6))
                        );
                    }
                }
                p1 = p2;
            }

            canvas.Update();
        }

        public Point GetBPoint(double t, int startPoint, int pointNum)
        {
            Point p = new Point();
            int n = pointNum - 1;
            for (int i = 0; i <= n; i++)
            {
                double d = Math.Pow(t, i) * Math.Pow(1 - t, n - i) * Lib.Choose(n, i);
                p.X += d * Points[startPoint + i].X;
                p.Y += d * Points[startPoint + i].Y;

                //double dw = Math.Pow(t, i) * Math.Pow(1 - t, n - i) * Lib.Choose(n, i * 2);
                p.Width += d * Points[startPoint + i].Width;
            }

            return p;
        }

        private Point generatePoint(Point point, double dx, double dy)
        {
            Point p2 = new Point(point);
            
            p2.X = point.X + Lib.RandRange(-dx, dx);
            p2.Y = point.Y + Lib.RandRange(-dy, dy);
            p2.Width = Width;

            p2.X = Math.Max(p2.X, 0);
            p2.Y = Math.Max(p2.Y, 0);

            p2.X = Math.Min(p2.X, canvas.Width);
            p2.Y = Math.Min(p2.Y, canvas.Height);

            return p2;
        }
    }
}
