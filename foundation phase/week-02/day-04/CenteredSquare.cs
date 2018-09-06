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

            int x = 10;
            int y = 10;

            foxDraw.DrawRectangle(canvas.Width/2 - x/2, canvas.Height/2 - y/2, x, y);


            // Draw a green 10x10 square to the canvas' center.
        }

    }
}
