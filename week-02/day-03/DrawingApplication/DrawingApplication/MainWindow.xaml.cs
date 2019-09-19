﻿using Avalonia;
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
            // Create a function that draws a single line and takes 3 parameters:
            // the x and y coordinates of the line's starting point and the
            // foxDraw and draws a line from that point to the center of the
            // canvas.
            // Fill the canvas with lines from the edges, every 20 px, to the center.

            for (int i = 0; i < canvasWidth; i++)
            {
                for (int i = 0; i <= canvasHeight; i++)
                {
                    GoToCenter(foxDraw, i * 20, j * 20);         
                }
            }
            




        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }


        public void GoToCenter(FoxDraw foxDraw, int x, int y)
        {
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.DrawLine(x, y, Height / 2, Width / 2);

        }



    }
}