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
            int squareSize = 20;

                DrawCheckBoard(foxDraw, squareSize);
            
        }

        public void DrawCheckBoard(FoxDraw foxDraw, int size)
        {
            foxDraw.StrokeColor(Colors.DarkGray);
            int x = 0;
            int y = 0;
            bool blackSwitcher = true;

            for (int i = 0; i < canvas.Height/size; i++)
            {
                for (int j = 0; j < canvas.Width/size; j++)
                {
                    if (blackSwitcher)
                    {
                        foxDraw.FillColor(Colors.Black);
                    }
                    else
                    {
                        foxDraw.FillColor(Colors.White);
                    }
                    foxDraw.DrawRectangle(x += size, y, size, size);
                    blackSwitcher = !blackSwitcher;
                }
                blackSwitcher = !blackSwitcher;
                y += size;
                x = 0;
            }
            
            
            

        }
        // Fill the canvas with a checkerboard pattern.

    }
}
