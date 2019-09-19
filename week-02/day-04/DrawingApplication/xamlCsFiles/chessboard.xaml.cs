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
            // Fill the canvas with a checkerboard pattern.

            foxDraw.SetStrokeColor(Colors.Black);

            for (int j = 0; j < 8; j++)         // loop for adding rows
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 8; i++)                        // loop na změnu barvy kostek
                    {
                        if (i % 2 == 0)
                        {
                            foxDraw.SetFillColor(Colors.Black);
                            foxDraw.DrawRectangle(i * 75, j * 75, 75, 75);
                        }
                        else
                        {
                            foxDraw.SetFillColor(Colors.White);
                            foxDraw.DrawRectangle(i * 75, j * 75, 75, 75);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 8; i++)                        // loop na změnu barvy kostek
                    {
                        if (i % 2 != 0)
                        {
                            foxDraw.SetFillColor(Colors.Black);
                            foxDraw.DrawRectangle(i * 75, j * 75, 75, 75);
                        }
                        else
                        {
                            foxDraw.SetFillColor(Colors.White);
                            foxDraw.DrawRectangle(i * 75, j * 75, 75, 75);
                        }
                    }
                }
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        

      


    }
}