using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;

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
            foxDraw.SetBackgroundColor(Colors.Black);

            /*----------------------------------------------------------------------------------------------------------*/
            // Draw the canvas' diagonals.
            // If it starts from the upper-left corner it should be green, otherwise it should be red.

            foxDraw.SetStrokeColor(Colors.Green);                 //top-left > down
            foxDraw.DrawLine(0, 0, 600, 600);

            foxDraw.SetStrokeColor(Colors.Red);                 //top-right > down
            foxDraw.DrawLine(0, 600, 600, 0);

            /*
            foxDraw.SetStrokeColor(Colors.Red);                 //první nastavení barvy pro první line
            foxDraw.DrawLine(100, 100, 100, 500);

            foxDraw.SetStrokeColor(Colors.Blue);                 //druhé nastavení barvy pro druhou line
            foxDraw.DrawLine(100, 500, 500, 500);
            
            foxDraw.SetStrokeColor(Colors.Green);                 //třetí nastavení barvy pro třetí line
            foxDraw.DrawLine(500, 500, 500, 100);

            foxDraw.SetStrokeColor(Colors.Cyan);                 //třetí nastavení barvy pro třetí line
            foxDraw.DrawLine(500, 100, 100, 100);
            */

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}