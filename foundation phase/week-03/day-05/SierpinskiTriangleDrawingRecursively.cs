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

namespace SierpinskiTriangleDrawingRecursively
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
            DrawSierpinskiTriangle(foxDraw, x, y, baseSide, false);

        }
        public static void DrawSierpinskiTriangle(FoxDraw foxDraw, double x, double y, double side, bool reverse)
        {
            bool reverseSwitch = reverse;
            if (side > 20)
            {
                double triangleSide = side / 2;
                DrawTriangle(foxDraw, x, y, triangleSide, reverseSwitch);
                DrawSierpinskiTriangle(foxDraw, x, y, triangleSide, reverseSwitch);
                DrawTriangle(foxDraw, x += triangleSide, y, triangleSide, reverseSwitch);
                DrawSierpinskiTriangle(foxDraw, x, y, triangleSide, reverseSwitch);
                DrawTriangle(foxDraw, x -= (triangleSide / 2), y += triangleSide * Math.Sqrt(3) / 2, triangleSide, !reverseSwitch);
                DrawTriangle(foxDraw, x, y, triangleSide, reverseSwitch);
                DrawSierpinskiTriangle(foxDraw, x, y, triangleSide, reverseSwitch);
            }
            else
            {
               
            }
        }
        public static void DrawTriangle(FoxDraw foxDraw, double startingPointX, double startingPointY, double side, bool reverseSwitch)
        {
            double height = side * Math.Sqrt(3) / 2;
            var points = new List<Point>();
            points.Add(new Point(startingPointX, startingPointY));
            points.Add(new Point(startingPointX += side, startingPointY));
            if (reverseSwitch)
            {
                points.Add(new Point(startingPointX -= side / 2, startingPointY -= height));
            }
            else
            {
                points.Add(new Point(startingPointX -= side / 2, startingPointY += height));
            }
            foxDraw.StrokeColor(Colors.Black);
            foxDraw.DrawPolygon(points);
        }
    }
}

