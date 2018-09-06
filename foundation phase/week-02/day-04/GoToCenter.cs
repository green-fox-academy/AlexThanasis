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

            foxDraw.BackgroundColor(Colors.GhostWhite);

            int x = 0;
            int y = 100;

            for (int i = 0; i < 3; i++)
            {
                Drawing(foxDraw, x, y);
                x *= 2;
                y *= 2;
            }
            

            // Create a line drawing function that takes 2 parameters:
            // The x and y coordinates of the line's starting point
            // and draws a line from that point to the center of the canvas.
            // Draw 3 lines with that function. Use loop for that.
        }

        public static void Drawing(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.StrokeColor(Colors.Blue);
            foxDraw.DrawLine(x, y, foxDraw.Canvas.Width/2, foxDraw.Canvas.Height/2);
        }
    }
}
