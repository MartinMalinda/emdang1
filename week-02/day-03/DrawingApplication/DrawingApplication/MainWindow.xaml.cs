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
            //  PURPLE STEPS 3D

            PurpleSteps(foxDraw, 5, 20);
           
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


        public void PurpleSteps(FoxDraw foxDraw, int mnozstvi, double x)  // i = kolikrát, x = size
        {
            for (int i = 1; i <= mnozstvi; i++)
            {
                foxDraw.SetFillColor(Colors.Purple);
                foxDraw.DrawRectangle((x*i) + (2 * i), x*i + (2 * i), x+(2*i), x + (2 * i));

            }
            

        }


    }
}