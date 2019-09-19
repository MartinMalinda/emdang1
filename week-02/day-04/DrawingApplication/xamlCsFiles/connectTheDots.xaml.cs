using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;

namespace DrawingApplication
{
    public class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();          // začátek nevim? 
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");        //vytvoření canvasu
            var foxDraw = new FoxDraw(canvas);              //vytvoření canvasu

            double canvasWidth = canvas.Width = 600;           //zadefinování canvasu, protože to je jinak nekonečno
            double canvasHeight = canvas.Height = 600;         //zadefinování canvasu, protože to je jinak nekonečno
                                                               //foxDraw.SetBackgroundColor(Colors.Black);

            /*----------------------------------------------------------------------------------------------------------*/
            // Create a function that takes 2 parameters:
            // A list of (x, y) points and foxDraw
            // and connects them with green lines.
            // connect these to get a box: {new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290)}
            // Connect these: {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
            // new Point(120, 100), new Point(85, 130), new Point(50, 100)}

            List<Point> points = new List<Point>() { new Point(10, 10), new Point(290, 10), new Point(290, 290), new Point(10, 290) };
            List<Point> points2 = new List<Point>() {new Point(50, 100), new Point(70, 70), new Point(80, 90), new Point(90, 90), new Point(100, 70),
                                new Point(120, 100), new Point(85, 130), new Point(50, 100)};

            ConnectTheDots(foxDraw,points);
            ConnectTheDots(foxDraw, points2);
            System.Console.WriteLine(points.Count);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void ConnectTheDots(FoxDraw foxDraw, List<Point> point )
        {
            foxDraw.SetStrokeColor(Colors.Black);
            for (int i = 0; i < point.Count; i++)     // změnit 4
            {
                if (i < point.Count-1)
                {
                    foxDraw.DrawLine(point[i], point[i + 1]);
                }
                else
                    foxDraw.DrawLine(point[i], point[0]);

            }

        }



    }



    
}