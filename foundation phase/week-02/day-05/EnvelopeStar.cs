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

            foxDraw.BackgroundColor(Colors.White);

            int gridLength = 20;
            DrawTheEnvelopeStar(foxDraw, gridLength);

        }

        public void DrawTheEnvelopeStar(FoxDraw foxDraw, int gridLength)
        {
            int x1StartingPoint = (int)canvas.Width / 2;
            int y1StartingPoint = 0;
            int x2StartingPoint = (int)canvas.Width / 2;
            int y2StartingPoint = (int)canvas.Height / 2;
            foxDraw.StrokeColor(Colors.Green);
            for (int j = 0; j < canvas.Width / gridLength / 2 - 1; j++)
            {
                 foxDraw.DrawLine(x1StartingPoint, y1StartingPoint += gridLength, x2StartingPoint += gridLength, y2StartingPoint);
            }
            x1StartingPoint = (int)canvas.Width / 2;
            y1StartingPoint = 0;
            x2StartingPoint = (int)canvas.Width / 2;
            y2StartingPoint = (int)canvas.Height / 2;
            for (int j = 0; j < canvas.Width / gridLength / 2 - 1; j++)
            {
                foxDraw.DrawLine(x1StartingPoint, y1StartingPoint += gridLength, x2StartingPoint -= gridLength, y2StartingPoint);
            }
            x1StartingPoint = (int)canvas.Width / 2;
            y1StartingPoint = (int)canvas.Height / 2;
            x2StartingPoint = (int)canvas.Width;
            y2StartingPoint = (int)canvas.Height / 2;
            for (int j = 0; j < canvas.Width / gridLength / 2 - 1; j++)
            {
                foxDraw.DrawLine(x1StartingPoint, y1StartingPoint += gridLength, x2StartingPoint -= gridLength, y2StartingPoint );
            }
            x1StartingPoint = (int)canvas.Width / 2;
            y1StartingPoint = (int)canvas.Height / 2;
            x2StartingPoint = 0;
            y2StartingPoint = (int)canvas.Height / 2;
            for (int j = 0; j < canvas.Width / gridLength / 2 - 1; j++)
            {
                foxDraw.DrawLine(x1StartingPoint, y1StartingPoint += gridLength, x2StartingPoint += gridLength, y2StartingPoint);
            }
        }
    }
}

