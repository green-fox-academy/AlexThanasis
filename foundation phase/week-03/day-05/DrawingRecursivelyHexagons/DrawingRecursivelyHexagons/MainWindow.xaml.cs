using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using greenfox;

namespace DrawingRecursivelyHexagons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            foxDraw.FillColor(Colors.White);
            foxDraw.BackgroundColor(Colors.Gray);
            foxDraw.StrokeColor(Colors.Black);
            double x = 0;
            double y = 0;
            double baseSide = canvas.Width;
            DrawHexagonsRecursively(foxDraw, x, y, baseSide);

        }
        public static void DrawHexagonsRecursively(FoxDraw foxDraw, double x, double y, double side)
        {
            double hexagonSide = side / 2;
            if (side > 15)
            {
                DrawHexagon(foxDraw, x += hexagonSide / 2, y, hexagonSide);
                DrawHexagon(foxDraw, x, y, hexagonSide / 3);
                DrawHexagonsRecursively(foxDraw, x - hexagonSide / 6, y, hexagonSide / 3 * 2);
                DrawHexagon(foxDraw, x += hexagonSide * 2 / 3, y, hexagonSide / 3);
                DrawHexagonsRecursively(foxDraw, x - hexagonSide / 6, y, hexagonSide / 3 * 2);
                DrawHexagon(foxDraw, x += hexagonSide / 3, y += hexagonSide / 3 * Math.Sqrt(3), hexagonSide / 3);
                DrawHexagonsRecursively(foxDraw, x - hexagonSide / 6, y, hexagonSide / 3 * 2);
                DrawHexagon(foxDraw, x -= hexagonSide / 3, y += hexagonSide / 3 * Math.Sqrt(3), hexagonSide / 3);
                DrawHexagonsRecursively(foxDraw, x - hexagonSide / 6, y, hexagonSide / 3 * 2);
                DrawHexagon(foxDraw, x -= hexagonSide * 2 / 3, y, hexagonSide / 3);
                DrawHexagonsRecursively(foxDraw, x - hexagonSide / 6, y, hexagonSide / 3 * 2);
                DrawHexagon(foxDraw, x -= hexagonSide / 3, y -= hexagonSide / 3 * Math.Sqrt(3), hexagonSide / 3);
                DrawHexagonsRecursively(foxDraw, x - hexagonSide / 6, y, hexagonSide / 3 * 2);

            }
            else
            {

            }
        }
        public static void DrawHexagon(FoxDraw foxDraw, double startingPointX, double startingPointY, double side)
        {
            double height = side * Math.Sqrt(3);
            var points = new List<Point>();
            points.Add(new Point(startingPointX, startingPointY));
            points.Add(new Point(startingPointX += side, startingPointY));
            points.Add(new Point(startingPointX += side / 2, startingPointY += height / 2));
            points.Add(new Point(startingPointX -= side / 2, startingPointY += height / 2));
            points.Add(new Point(startingPointX -= side, startingPointY));
            points.Add(new Point(startingPointX -= side / 2, startingPointY -= height / 2));

            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(points);
        }
    }
}
