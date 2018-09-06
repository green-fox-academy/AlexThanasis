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

namespace DrawingSquareGrid
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
            
            foxDraw.BackgroundColor(Colors.White);
            foxDraw.StrokeColor(Colors.Black);
            double x = canvas.Width / 2; ;
            double y = canvas.Height / 2; ;
            double side = canvas.Width / 2;
            DrawGridSquares(foxDraw, x, y, side, 5);

        }
        public static void DrawGridSquares(FoxDraw foxDraw, double x, double y, double squareSide, int thickness)
        {
            if (thickness > 1)
            {
                double side = squareSide / 2;
                
                foxDraw.DrawLine(x -= side, y -= side, x += side * 2, y, thickness);
                DrawGridSquares(foxDraw, x, y, side, thickness-1);
                foxDraw.DrawLine(x , y, x, y += side * 2, thickness);
                DrawGridSquares(foxDraw, x, y, side, thickness-1);
                foxDraw.DrawLine(x, y, x -= side * 2, y, thickness);
                DrawGridSquares(foxDraw, x, y, side, thickness-1);
                foxDraw.DrawLine(x, y, x, y -= side * 2, thickness);
                DrawGridSquares(foxDraw, x, y, side, thickness-1);
            }
        else
        {

            }
        }
       
    }
}
