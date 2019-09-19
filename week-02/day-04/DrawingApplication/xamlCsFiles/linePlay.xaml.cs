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
            //Line play 
            for (int i = 20; i <600; i+=20)
            {
                foxDraw.SetStrokeColor(Colors.Purple);
                foxDraw.DrawLine(i, 0, Width, i);

                foxDraw.SetStrokeColor(Colors.LawnGreen);
                foxDraw.DrawLine(0, i, i, Width);
            }
            
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


       
         

    }



    
}