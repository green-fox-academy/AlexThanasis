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

namespace DrawTest
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
            int widthOfTriangles = 50;
            DrawTriangels(foxDraw, widthOfTriangles);

        }

        private void DrawTriangels(FoxDraw foxDraw, int widthOfTriangles)
        {
            double startingPointX = 0 - widthOfTriangles;
            double startingPointY = canvas.Height;
            double heightOfTriagle = widthOfTriangles * Math.Sqrt(3) / 2;
            foxDraw.FillColor(Colors.White);
            foxDraw.BackgroundColor(Colors.White);
            int counter = (int)canvas.Width / widthOfTriangles;
            for (int j = 0; j < (int)canvas.Width / widthOfTriangles; j++)
            {
                for (int i = 0; i < counter; i++)
                {
                    var points = new List<Point>();
                    points.Add(new Point(startingPointX += widthOfTriangles, startingPointY));
                    points.Add(new Point(startingPointX + widthOfTriangles, startingPointY));
                    points.Add(new Point(startingPointX + widthOfTriangles / 2, startingPointY - heightOfTriagle));
                    foxDraw.StrokeColor(Colors.Black);
                    foxDraw.DrawPolygon(points);
                }
                counter--;
                startingPointX = j * widthOfTriangles / 2 - widthOfTriangles / 2;
                startingPointY -= heightOfTriagle; 
            }
        }
    }
}
