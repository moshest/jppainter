using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace JP_Painter
{
    class Lib
    {
        private static Random rand = new Random();
        
        public static double Radios(PointF p)
        {
            double a = (double)p.X;
            double b = (double)p.Y;

            return Math.Sqrt(a * a + b * b);
        }

        public static double Distance(PointF p1, PointF p2)
        {
            double a = (double)p2.X - (double)p1.X;
            double b = (double)p2.Y - (double)p1.Y;

            return Math.Sqrt(a * a + b * b);
        }

        public static double Average(double a, double b)
        {
            return Average(a, b, 0.5);
        }

        public static double Average(double a, double b, double r)
        {
            return (a * r) + b * (1.0 - r);
        }

        public static PointF Average(PointF p1, PointF p2)
        {
            return Average(p1, p2, 0.5f, 0.5f);
        }

        public static PointF Average(PointF p1, PointF p2, double dx, double dy)
        {
            return new PointF(
                (float)Average(p1.X, p2.X, dx),
                (float)Average(p1.Y, p2.Y, dy)
            );
        }

        public static PointF Average(PointF p1, PointF p2, double d)
        {
            return Average(p1, p2, d, d);
        }

        public static PointF PointRandMove(PointF p, float radios)
        {
            p.X += (float)RandRange(-radios, radios);
            p.Y += (float)RandRange(-radios, radios);

            return p;
        }

        public static double RandRange(double min, double max)
        {
            return min + rand.NextDouble() * (max - min);
        }

        public static double RandNormalRange(double min, double max)
        {
            double mean = (max + min) / 2;
            double stdDev = (max - min);
            double r = RandNormal(0, 0.25);

            if (r < -1)
                r = -1;
            else if (r > 1)
                r = 1;

            return mean + r * stdDev;
        }

        /**
         * return random normal(mean,stdDev^2)
         */
        public static double RandNormal(double mean, double stdDev)
        {
            //these are uniform(0,1) random doubles
            double u1 = rand.NextDouble();
            double u2 = rand.NextDouble();

            //random normal(0,1)
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);

            return mean + stdDev * randStdNormal;
        }

        public static double RandExp(double lambda)
        {
            double u;
            do
            {
                u = rand.NextDouble();
            } while (u == 1);

            return Math.Log(1 - u) / (-lambda);
        }

        public static int Choose(int n, int k)
        {
            if (k == 0 || n == 0)
                return 1;
            return Factorial(n) / (Factorial(n - k) * Factorial(k));
        }

        public static int Factorial(int n)
        {
            switch (n)
            {
                case 0:
                case 1:
                    return 1;

                case 2:
                    return 2;

                case 3:
                    return 6;

                case 4:
                    return 24;

                case 5:
                    return 120;

                default:
                    break;
            }

            int f = 120;
            for (int i = 6; i <= n; i++)
            {
                f *= i;
            }
            return f;
        }
    }
}
