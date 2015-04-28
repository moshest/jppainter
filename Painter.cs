using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace JP_Painter
{

    public partial class Painter : Form
    {

        enum DrawStatus { NONE, BEGIN, END };

        Size panelSize;
        bool isLoadData = false;
        //string dataFile = null, pointsMapFile = null;
        Color[] colorsBank;
        //float min = float.MaxValue;
        //float max = 0;
        Stack<Stroke> drawStrokes = new Stack<Stroke>();
        Canvas canvas;

        PointF begin, end;
        DrawStatus status = DrawStatus.BEGIN;
        Parser.Entities entities = null;

        public Painter(Size size, Image bgImage, string colorsFile)
        {
            this.panelSize = size;

            Parser parser = new Parser();
            colorsBank = parser.ParseColors(colorsFile).ToArray();

            InitializeComponent();
            panel1.BackgroundImage = bgImage;
        }

        public Painter(Size size, Image bgImage, string colorsFile, string dataFile, string pointsMapFile)
        {
            this.panelSize = size;

            //this.dataFile = dataFile;
            //this.pointsMapFile = pointsMapFile;

            Parser parser = new Parser();
            entities = parser.Parse(pointsMapFile, dataFile);
            colorsBank = parser.ParseColors(colorsFile).ToArray();

            this.isLoadData = true;
            InitializeComponent();

            panel1.BackgroundImage = bgImage;

            freestyle.Visible = false;
            status = DrawStatus.NONE;
        }

        void loadStrocks()
        {
            if (!this.isLoadData || entities == null)
                return;


            foreach (Parser.Entity entity in entities.Shuffle())
            {

                List<Point> points = new List<Point>();

                double power = ((double)entities.Powers.IndexOfValue(entity.Power)) / ((double)entities.Powers.Count - 1.0);
                Color color = getColor(power);

                points.Add(new Point(entity.Source, 1.0 + Lib.RandExp(0.1)));

                int pointNum = (int) Lib.RandRange(2, 5);
                for (int i = 0; i < pointNum; i++)
                {
                    points.Add(generatePoint(points[i], 100, 100));
                }

                points.Add(new Point(entity.Target, 1.0 + Lib.RandExp(0.1)));

                Stroke stroke = new Stroke(canvas, color, 2, points.ToArray());
                drawStrokes.Push(stroke);
            }

        }

        private Point generatePoint(Point point, double dx, double dy)
        {
            Point p2 = new Point(point);

            p2.X = point.X + Lib.RandRange(-dx, dx);
            p2.Y = point.Y + Lib.RandRange(-dy, dy);
            p2.Width = 1.0 + Lib.RandExp(0.1);

            p2.X = Math.Max(p2.X, 0);
            p2.Y = Math.Max(p2.Y, 0);

            p2.X = Math.Min(p2.X, canvas.Width);
            p2.Y = Math.Min(p2.Y, canvas.Height);

            return p2;
        }

        private Color getColor(double r)
        {
            int i = (int)(r * (double)(colorsBank.Length));
            
            if (i < 0)
                i = 0;
            if (i >= colorsBank.Length)
                i = colorsBank.Length - 1;

            i = colorsBank.Length - 1 - i;

            return colorsBank[i];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int diff_x = panelSize.Width - panel1.Width;
            int diff_y = panelSize.Height - panel1.Height;

            panel1.Width += diff_x;
            panel1.Height += diff_y;

            this.Width += diff_x;
            this.Height += diff_y;

            freestyle.Width += diff_x;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            drawStrokes.Clear();
            canvas.Clear();
            panel1.Refresh();

            loadStrocks();
        }

        private void draw_Click(object sender, EventArgs e)
        {
            status = DrawStatus.BEGIN;
        }

        private void drawStroke()
        {
            Color color = Color.FromArgb((int)transp.Value, colorPicker.BackColor);
            SizeF size = new SizeF((float)sizeW.Value, (float)sizeH.Value);

            Point[] points = new Point[] {
                new Point(begin, 1),
                new Point(end, 10)
            };

            Stroke stroke = new Stroke(canvas, color, points);
            drawStrokes.Push(stroke);
        }

        private void randBt_Click(object sender, EventArgs e)
        {
            Random rand = new Random();


            List<Point> points = new List<Point>();
            points.Add(randPoint());

            int pointNum = (int)Lib.RandRange(2, 5);
            for (int i = 0; i < pointNum; i++)
            {
                points.Add(generatePoint(points[i], 100, 100));
            }

            points.Add(randPoint());

            Color color = colorsBank[rand.Next(0, colorsBank.Length)];

            Stroke stroke = new Stroke(canvas, color, points.ToArray());
            drawStrokes.Push(stroke);
        }

        private Point randPoint()
        {
            Point p = new Point();

            p.X = Lib.RandRange(10, canvas.Width - 10);
            p.Y = Lib.RandRange(10, canvas.Height - 10);
            p.Width = Lib.RandExp(0.1);//Lib.RandNormal(5, 1.25);

            return p;
        }

        private void changeColor(object sender, EventArgs e)
        {
            colorDialog1.Color = colorPicker.BackColor;
            colorDialog1.ShowDialog();
            colorPicker.BackColor = colorDialog1.Color;
        }

        private void updatePosition(object sender, MouseEventArgs e)
        {
            position.Text = e.X + "," + e.Y;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (status == DrawStatus.NONE)
                return;

            begin = new PointF(e.X, e.Y);
            status = DrawStatus.END;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (status == DrawStatus.END)
            {
                end = new PointF(e.X, e.Y);
                drawStroke();

                status = DrawStatus.BEGIN;
            }
        }

        private void Painter_Shown(object sender, EventArgs e)
        {
            canvas = new Canvas(panel1);

            loadStrocks();
            drawTimer.Enabled = true;
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            if (drawStrokes.Count < 1)
                return;

            Stroke stroke = drawStrokes.Pop();
            stroke.draw();
        }

    }
}
