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

            foxDraw.SetStrokeColor(Colors.Black);
            /*----------------------------------------------------------------------------------------------------------*/
            //Line play 
            int strana = 80;
            int prurez = strana*2;


            foxDraw.DrawLine(300, 0, 300, 600);         // ref osa
            foxDraw.DrawLine(0, 300, 600, 300);         // ref osa


            foxDraw.SetStrokeColor(Colors.Red);
            foxDraw.DrawLine(260, 600, 340, 600);         // spodní 

            for (int i = 0; i < 4; i++)
            {
                foxDraw.SetStrokeColor(Colors.Red);
                foxDraw.DrawLine(260, 600, 340, 600);         // spodní
            }

            /* 
            for (int i = 0; i <20; i++)
            {
                foxDraw.SetStrokeColor(Colors.Purple);
                foxDraw.DrawLine(a, 600, 300+b, a);

                foxDraw.SetStrokeColor(Colors.Cyan);
                foxDraw.DrawLine(600-a, 600, 300 -b, a);

                foxDraw.SetStrokeColor(Colors.Yellow);
                foxDraw.DrawLine(b, 600-a, 600-b, 600-a);


                
                foxDraw.SetStrokeColor(Colors.Cyan);
                foxDraw.DrawLine(300, a, 300 - a, 300);

                foxDraw.SetStrokeColor(Colors.Yellow);
                foxDraw.DrawLine(300, 600-a, 300-a, 300);

                foxDraw.SetStrokeColor(Colors.LightPink);
                foxDraw.DrawLine(300, 600-a, 300+a, 300);
                
                a += 30;
                b += 15;
                
                foxDraw.DrawLine()
                

            }*/


        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


       
         

    }



    
}