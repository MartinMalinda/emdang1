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
            foxDraw.SetStrokeColor(Colors.Red);                 //první nastavení barvy pro první line
            // draw a red horizontal line to the canvas' middle.
            foxDraw.DrawLine(0, canvasHeight/2, canvasWidth/2, canvasHeight/2);

            // draw a green vertical line to the canvas' middle.
            foxDraw.SetStrokeColor(Colors.Green);                 //druhé nastavení  barvy pro druhou line
            foxDraw.DrawLine(canvasWidth/2, 0, canvasWidth/2, canvasHeight/2);

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}