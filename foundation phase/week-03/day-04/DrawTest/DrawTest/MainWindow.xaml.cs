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
            foxDraw.FillColor(Colors.Yellow);
            foxDraw.BackgroundColor(Colors.Yellow);
            foxDraw.StrokeColor(Colors.Black);
            double x = 0;
            double y = 0;
            double baseSide = canvas.Width;
            DrawSquare(foxDraw, x, y, baseSide);
            
        }
        public static void DrawSquare(FoxDraw foxDraw, double x, double y, double side)
        {
            if (side < 3)
            {

            }
            else
            {
                double squareSide = side / 3;
                foxDraw.DrawRectangle(x += squareSide, y, squareSide, squareSide);
                DrawSquare(foxDraw, x, y, squareSide);
                foxDraw.DrawRectangle(x -= squareSide, y += squareSide, squareSide, squareSide);
                DrawSquare(foxDraw, x, y, squareSide);
                foxDraw.DrawRectangle(x += squareSide * 2, y, squareSide, squareSide);
                DrawSquare(foxDraw, x, y, squareSide);
                foxDraw.DrawRectangle(x -= squareSide, y += squareSide, squareSide, squareSide);
                DrawSquare(foxDraw, x, y, squareSide);
            }
        } 
    }
}

