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
            int xStartingPoint = 0;
            int yStartingPoint = 0;

            DrawLinesToTheCenter(foxDraw, xStartingPoint, yStartingPoint);
        }

        public void DrawLinesToTheCenter(FoxDraw foxDraw, int xStartingPoint, int yStartingPoint)
        {
            int lengthOfStartingPoints = 20;
            int edgeX = xStartingPoint;
            int edgeY = yStartingPoint;
            foxDraw.StrokeColor(Colors.DarkGray);
            int xCenterPoint = (int)canvas.Width / 2;
            int yCenterPoint = (int)canvas.Height / 2;
            for (int i = 0; i < canvas.Width / lengthOfStartingPoints; i++)
            {
               foxDraw.DrawLine(xStartingPoint += lengthOfStartingPoints, yStartingPoint, xCenterPoint, yCenterPoint);
               
            }
            for (int i = 0; i < canvas.Height / lengthOfStartingPoints; i++)
            {
                foxDraw.DrawLine(xStartingPoint, yStartingPoint += lengthOfStartingPoints, xCenterPoint, yCenterPoint);

            }
            
            xStartingPoint = (0);
            for (int i = 0; i < canvas.Width / lengthOfStartingPoints; i++)
            {
                foxDraw.DrawLine(xStartingPoint += lengthOfStartingPoints, yStartingPoint, xCenterPoint, yCenterPoint);

            }
            xStartingPoint = (0);
            yStartingPoint = (0);
            for (int i = 0; i < canvas.Height / lengthOfStartingPoints; i++)
            {
                foxDraw.DrawLine(xStartingPoint, yStartingPoint += lengthOfStartingPoints, xCenterPoint, yCenterPoint);

            }

        }

        // create a line drawing function that takes 2 parameters:
        // the x and y coordinates of the line's starting point
        // and draws a line from that point to the center of the canvas.
        // fill the canvas with lines from the edges, every 20 px, to the center.

    }
}
