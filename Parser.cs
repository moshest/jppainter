using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;

namespace JP_Painter
{
    class Parser
    {

        public class Entities
        {
            public List<Entity> Container;
            public SortedList<double, double> Powers;

            public Entities()
            {
                Container = new List<Entity>();
                Powers = new SortedList<double, double>();
            }

            public void Add(Entity entity)
            {
                Container.Add(entity);
                if (!Powers.ContainsKey(entity.Power))
                {
                    Powers.Add(entity.Power, entity.Power);
                }
            }

            public List<Entity> Shuffle()
            {
                List<Entity> list = new List<Entity>(Container);
                Random r = new Random();

                for (int n = list.Count-1; n >= 0; n--)
                {
                    int k = r.Next(n+1);
                    Entity value = list[k];

                    list[k] = list[n];
                    list[n] = value;
                }

                return list;
            }
        }

        public class Entity
        {
            public PointF Source, Target;
            public double Power;

            public Entity(PointF source, PointF target, double power)
            {
                Source = source;
                Target = target;
                Power = power;
            }
        }

        public List<Color> ParseColors(string colorsFile)
        {
            List<Color> colors = new List<Color>();

            Excel.Application excelApp = new Excel.Application();
            try
            {
                Excel.Workbook workbook = excelApp.Workbooks.Open(colorsFile);
                Excel.Worksheet mySheet = (Excel.Worksheet)workbook.Sheets[1];

                for (int row = 1; ((Excel.Range)mySheet.Cells[row, 1]).Value2 != null; row++)
                {
                    int
                    r = int.Parse(((Excel.Range)mySheet.Cells[row, 1]).Value2.ToString()),
                    g = int.Parse(((Excel.Range)mySheet.Cells[row, 2]).Value2.ToString()),
                    b = int.Parse(((Excel.Range)mySheet.Cells[row, 3]).Value2.ToString());

                    colors.Add(Color.FromArgb(r, g, b));
                }

                workbook.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }

            excelApp.Quit();

            return colors;
        }

        public Entities Parse(string pointsFile, string dataFile)
        {
            Dictionary<string, PointF> points = parsePoints(pointsFile);
            Entities entities = new Entities();

            Excel.Application excelApp = new Excel.Application();
            bool showError = false;

            try
            {
                Excel.Workbook workbook = excelApp.Workbooks.Open(dataFile);//, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Excel.Worksheet mySheet = (Excel.Worksheet) workbook.Sheets[1];
                for (int row = 1; ((Excel.Range)mySheet.Cells[row, 1]).Value2 != null; row++)
                {

                    String from = ((Excel.Range) mySheet.Cells[row, 1]).Value2.ToString();
                    String to = ((Excel.Range) mySheet.Cells[row, 2]).Value2.ToString();
                    double power = double.Parse(((Excel.Range)mySheet.Cells[row, 3]).Value2.ToString());

                    PointF source, target;
                    if (!points.TryGetValue(from, out source) || !points.TryGetValue(to, out target))
                    {
                        if (!showError)
                        {
                            showError = true;
                            System.Windows.Forms.MessageBox.Show("The points map is not full");
                        }
                        continue;
                    }

                    entities.Add(new Entity(source, target, power));
                }

                workbook.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }

            excelApp.Quit();

            return entities;
        }

        private Dictionary<string, PointF> parsePoints(string pointsFile)
        {
            Dictionary<string, PointF> points = new Dictionary<string, PointF>();

            Excel.Application excelApp = new Excel.Application();
            String country;
            try
            {
                Excel.Workbook workbook = excelApp.Workbooks.Open(pointsFile);//, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Excel.Worksheet mySheet = (Excel.Worksheet) workbook.Sheets[1];

                for (int row = 1; ((Excel.Range) mySheet.Cells[row, 1]).Value2 != null; row++)
                {
                    country = ((Excel.Range) mySheet.Cells[row, 1]).Value2.ToString();

                    String Xcoord = ((Excel.Range) mySheet.Cells[row, 2]).Value2.ToString();
                    String Ycoord = ((Excel.Range) mySheet.Cells[row, 3]).Value2.ToString();
                    
                    points[country] = new PointF(float.Parse(Xcoord), float.Parse(Ycoord));
                }

                workbook.Close();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                Console.WriteLine(ex.Message);
            }

            excelApp.Quit();

            return points;
        }

    }
}
