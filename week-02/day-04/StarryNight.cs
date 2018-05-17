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
            
            int numberOfStars = 150;
            DrawStars(foxDraw, numberOfStars);
        }

        public void DrawStars(FoxDraw foxDraw, int numberOfStars)
        {
            Random r = new Random();
            foxDraw.BackgroundColor(Colors.Black);
            
            int edge = 1;
            for (int i = 0; i < numberOfStars; i++)
            {
                int x_coordinates = r.Next(edge, (int)canvas.Width - edge);
                int y_coordinates = r.Next(edge, (int)canvas.Height - edge);
                int randomSize = r.Next(1, 10);
                byte grayColor = (byte)r.Next(255);
                
                Color randomColor = Color.FromRgb(grayColor, grayColor, grayColor);
                foxDraw.FillColor(randomColor);
                foxDraw.StrokeColor(randomColor);
                foxDraw.DrawEllipse(x_coordinates, y_coordinates, randomSize, randomSize);

            }
        }

            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

    }
}
