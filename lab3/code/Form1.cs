using System;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot.Axes;
using OxyPlot.Annotations;
using OxyPlot;
using OxyPlot.Utilities;
using System.Runtime.CompilerServices;
using OxyPlot.Series;
using System.Collections.Generic;
using System.Diagnostics;

namespace lab_3 {

    public partial class Form1 : Form
    {
        private Point point1;
        private Point point2;

        public bool IsEvent = true;

        public PlotModel PlotModel;

        public Form1()
        {
            InitializeComponent();
            // Создание осей координат
            var xAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom, // Ось X внизу
                Title = "X", // Заголовок оси X
                Minimum = -1,
                Maximum = 10,
            };
            var yAxis = new LinearAxis
            {
                Position = AxisPosition.Left, // Ось Y слева
                Title = "Y", // Заголовок оси Y
                Minimum = -1,
                Maximum = 10,
            };
            PlotModel = new PlotModel();
            PlotModel.Axes.Add(xAxis);
            PlotModel.Axes.Add(yAxis);
            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MinorGridlineStyle = LineStyle.Dot;
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MinorGridlineStyle = LineStyle.Dot;
            xAxis.MajorGridlineColor = OxyColor.FromRgb(200, 200, 200); // Цвет основных линий сетки по оси X
            xAxis.MinorGridlineColor = OxyColor.FromRgb(230, 230, 230); // Цвет вспомогательных линий сетки по оси X
            yAxis.MajorGridlineColor = OxyColor.FromRgb(200, 200, 200); // Цвет основных линий сетки по оси Y
            yAxis.MinorGridlineColor = OxyColor.FromRgb(230, 230, 230); // Цвет вспомогательных линий сетки по оси Y
            PlotModel.PlotAreaBorderColor = OxyColor.FromRgb(150, 150, 150); // Цвет границы области графика
            plotView1.Model = PlotModel;

            PlotModel.PlotType = PlotType.Cartesian;
            PlotModel.Background = OxyColors.White;
            PlotModel.PlotAreaBorderColor = OxyColors.LightGray;

            xAxis.MajorGridlineStyle = LineStyle.Solid;
            xAxis.MinorGridlineStyle = LineStyle.Dot;
            yAxis.MajorGridlineStyle = LineStyle.Solid;
            yAxis.MinorGridlineStyle = LineStyle.Dot;

            PlotModel.PlotAreaBorderColor = OxyColor.FromRgb(150, 150, 150);
            
            plotView1.Model = PlotModel;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Scale_Scroll(object sender, EventArgs e)
        {
            label3.Text = $"Scale: {scale.Value}";
        }

        private void Bresenham_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEvent)
            {
                IsEvent = false;
                stepBystep.Checked = !bresenham.Checked;
                IsEvent = true;
            }
        }

        private void StepBystep_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEvent)
            {
                IsEvent = false;
                bresenham.Checked = !stepBystep.Checked;
                IsEvent = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (TryParse(firstPoint.Text, out point1) && 
                TryParse(secondPoint.Text, out point2))
            {
                DrawSquare(point1);
                DrawSquare(point2);

                var time = new Stopwatch();

                time.Start();
                var points = bresenham.Checked ? DrawLineBresenham(point1,point2) : DrawLinePointByPoint(point1, point2);
                time.Stop();

                foreach (var point in points)
                {
                    DrawSquare(point);
                }

                label3.Text = $"Time: {time.ElapsedMilliseconds} ms";
            }
        }

        private static bool TryParse(string s, out Point point)
        {
            var coordinates = s.Split(',');

            if (coordinates.Length == 2 &&
                int.TryParse(coordinates[0], out var x) &&
                int.TryParse(coordinates[1],out var y))
            {
                point = new Point(x, y);
                return true;
            }

            point = new Point(-1, -1);
            return false;
        }

        private void DrawSquare(Point point)
        {
            var rectangle = new RectangleBarSeries
            {
                StrokeThickness = 1, // Толщина обводки
                StrokeColor = OxyColors.Black, // Цвет обводки
                FillColor = OxyColors.Blue // Цвет заливки
            };

            rectangle.Items.Add(new RectangleBarItem
            {
                X0 = point.X, // Левая координата X
                X1 = point.X + 1, // Правая координата X
                Y0 = point.Y, // Верхняя координата Y
                Y1 = point.Y - 1  // Нижняя координата Y
            });

            PlotModel.Series.Add(rectangle);
            plotView1.InvalidatePlot(true);
        }

        public static List<Point> DrawLinePointByPoint(Point p1, Point p2)
        {
            int dx = p2.X - p1.X;
            int dy = p2.Y - p1.Y;

            int x = p1.X;
            int y = p1.Y;

            List<Point> points = new List<Point>();

            if (Math.Abs(dx) > Math.Abs(dy))
            {
                bool steep = Math.Abs(dy) > Math.Abs(dx);
                if (steep)
                {
                    Swap(ref x, ref y);
                    Swap(ref p1);
                    Swap(ref p2);
                    dx = p2.X - p1.X;
                    dy = p2.Y - p1.Y;
                }
                if (p1.X > p2.X)
                {
                    SwapX(ref p1, ref p2);
                    SwapY(ref p1, ref p2);
                    dx = p2.X - p1.X;
                    dy = p2.Y - p1.Y;
                }
                int d = 2 * Math.Abs(dy) - Math.Abs(dx);
                int yStep = p1.Y > p2.Y ? -1 : 1;
                while (x <= p2.X)
                {
                    points.Add(steep ? new Point(y, x) : new Point(x, y));
                    if (d > 0)
                    {
                        y += yStep;
                        d -= 2 * Math.Abs(dx);
                    }
                    x += 1;
                    d += 2 * Math.Abs(dy);
                }
            }
            else
            {
                bool steep = Math.Abs(dx) > Math.Abs(dy);
                if (steep)
                {
                    Swap(ref x, ref y);
                    Swap(ref p1);
                    Swap(ref p2);
                    dx = p2.X - p1.X;
                    dy = p2.Y - p1.Y;
                }
                if (p1.Y > p2.Y)
                {
                    SwapY(ref p1, ref p2);
                    SwapX(ref p1, ref p2);
                    dy = p2.Y - p1.Y;
                    dx = p2.X - p1.X;
                }
                int d = 2 * Math.Abs(dx) - Math.Abs(dy);
                int xStep = p1.X > p2.X ? -1 : 1;
                while (y <= p2.Y)
                {
                    points.Add(steep ? new Point(y, x) : new Point(x, y));
                    if (d > 0)
                    {
                        x += xStep;
                        d -= 2 * Math.Abs(dy);
                    }
                    y += 1;
                    d += 2 * Math.Abs(dx);
                }
            }

            return points;
        }

        public static List<Point> DrawLineBresenham(Point p1, Point p2)
        {
            int dx = Math.Abs(p2.X - p1.X);
            int dy = Math.Abs(p2.Y - p1.Y);

            bool steep = dy > dx;

            if (steep)
            {
                Swap(ref p1);
                Swap(ref p2);
                dx = Math.Abs(p2.X - p1.X);
                dy = Math.Abs(p2.Y - p1.Y);
            }

            if (p1.X > p2.X)
            {
                SwapX(ref p1, ref p2);
                SwapY(ref p1, ref p2);
            }

            int yStep = p1.Y < p2.Y ? 1 : -1;
            int d = 2 * dy - dx;
            int y = p1.Y;

            List<Point> points = new List<Point>();
            for (int x = p1.X; x <= p2.X; x++)
            {
                points.Add(steep ? new Point(y, x) : new Point(x, y));

                if (d > 0)
                {
                    y += yStep;
                    d -= 2 * dx;
                }
                d += 2 * dy;
            }

            return points;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref Point point)
        {
            int temp = point.X;
            point.X = point.Y;
            point.Y = temp;
        }

        public static void SwapX(ref Point point1, ref Point point2)
        {
            int temp = point1.X;
            point1.X = point2.X;
            point2.X = temp;
        }

        public static void SwapY(ref Point point1, ref Point point2)
        {
            int temp = point1.Y;
            point1.Y = point2.Y;
            point2.Y = temp;
        }

    }
}
