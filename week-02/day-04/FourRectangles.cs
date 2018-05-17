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

            Random r = new Random();
            
            foxDraw.BackgroundColor(Colors.GhostWhite);
            int edge = 50;
            int numOfRectangles = 4;

            for (int i = 0; i < numOfRectangles; i++)
            {
                int x_coordinates = r.Next(edge, (int)canvas.Width - edge);
                int y_coordinates = r.Next(edge, (int)canvas.Height - edge);
                int recWidth = r.Next(20, 50);
                int recHeight = r.Next(20, 50);
               
                Color randomColor = Color.FromRgb((byte)r.Next(255), (byte)r.Next(255), (byte)r.Next(255));
                foxDraw.FillColor(randomColor);
                foxDraw.DrawRectangle(x_coordinates, y_coordinates, recWidth, recHeight);
            }


            // draw four different size and color rectangles.
            // avoid code duplication.

        }

    }
}
