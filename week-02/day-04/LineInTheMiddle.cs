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

            foxDraw.BackgroundColor(Colors.Beige);

            foxDraw.StrokeColor(Colors.Red);
            foxDraw.DrawLine(0, 100, canvas.Width/2, 100 );

            foxDraw.StrokeColor(Colors.Green);
            foxDraw.DrawLine(100, 0, 100, canvas.Height/2);

            // draw a red horizontal line to the canvas' middle.
            // draw a green vertical line to the canvas' middle.
        }
    }
}
