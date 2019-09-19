using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
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
            // Draw the night sky:
            //  - The background should be black
            //  - The stars can be small squares
            //  - The stars should have random positions on the canvas
            //  - The stars should have random color (some shade of grey)

            StarryNight(foxDraw, 400);
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public int RandomNumber(int min, int max)           //funkce na random čísla int
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void StarryNight(FoxDraw foxDraw, int maxPocetHvezd)
        {
            List<Color> barvy = new List<Color> { Colors.Blue, Colors.Cyan, Colors.DarkBlue, Colors.Yellow, Colors.Orange }; // definice barev
            foxDraw.SetBackgroundColor(Colors.Black);

            for (int i = 0; i < RandomNumber(20, maxPocetHvezd); i++) // 20 je min pocet hvezd
            {
                foxDraw.SetFillColor(barvy[RandomNumber(0, 4)]);
                foxDraw.DrawRectangle(RandomNumber(0, 600), RandomNumber(0, 600), 5, 5);  // vytvoření random hvězdy 5x5
            }
        }
         

    }



    
}