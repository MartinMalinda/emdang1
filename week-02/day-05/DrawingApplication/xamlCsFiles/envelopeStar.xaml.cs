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

            foxDraw.SetBackgroundColor(Colors.Black);
            /*----------------------------------------------------------------------------------------------------------*/
            //Line play 
            int a = 0;
            for (int i = 0; i <15; i++)
            {
                foxDraw.SetStrokeColor(Colors.Purple);
                foxDraw.DrawLine(300, a, 300+a, 300);
                
                foxDraw.SetStrokeColor(Colors.Cyan);
                foxDraw.DrawLine(300, a, 300 - a, 300);

                foxDraw.SetStrokeColor(Colors.Yellow);
                foxDraw.DrawLine(300, 600-a, 300-a, 300);

                foxDraw.SetStrokeColor(Colors.LightPink);
                foxDraw.DrawLine(300, 600-a, 300+a, 300);
                
                a += 20;

                //foxDraw.SetStrokeColor(Colors.LawnGreen);
                //foxDraw.DrawLine(0, i, i, Width);
            }


        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


       
         

    }



    
}