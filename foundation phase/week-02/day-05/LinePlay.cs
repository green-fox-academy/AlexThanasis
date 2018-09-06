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
            DrawTheGreenLines(foxDraw, gridLength);
            DrawThePurpleLines(foxDraw, gridLength);
        }

        public void DrawTheGreenLines(FoxDraw foxDraw, int gridLength)
        {
            int x1StartingPoint = 0;
            int y1StartingPoint = 0;
            int x2StartingPoint = 0;
            int y2StartingPoint = (int)canvas.Height;
            foxDraw.StrokeColor(Colors.Green);

            for (int i = 0; i < canvas.Width / gridLength - 1; i++)
            {
                foxDraw.DrawLine(x1StartingPoint, y1StartingPoint += gridLength, x2StartingPoint += gridLength, y2StartingPoint);
            }

        }

        public void DrawThePurpleLines(FoxDraw foxDraw, int gridLength)
        {

            int x1StartingPoint = (int)canvas.Width;
            int y1StartingPoint = (int)canvas.Height;
            int x2StartingPoint = (int)canvas.Width;
            int y2StartingPoint = 0;
            foxDraw.StrokeColor(Colors.Purple);

            for (int i = 0; i < canvas.Width / gridLength - 1; i++)
            {
                foxDraw.DrawLine(x1StartingPoint, y1StartingPoint -= gridLength, x2StartingPoint -= gridLength, y2StartingPoint);
            }
        }

    }
}
