using Cosmos.Core.IOGroup;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;


namespace Cosmosrace
{
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;
        public static int x=512;public static int y=0;

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1020;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {

            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();
                graf.cls(Color.White);
                tests.mainLoop();
                while (true)
                {
                    Thread.Sleep(50);
                    tests.mainLoop();




                    ;

                }
            }


        }
    }





    class tests



    {
        static int counter = 0; static int counter2 = 0; static int counter3 = 15; static int counter4 = 0;static int yyy = 0; static int yyy2=0;

        public static void mainLoop()
        {
            //

            

            Pen ppp = new Pen(Color.FromArgb(0, 0, 0), 3);
            Pen pppp = new Pen(Color.FromArgb(255, 255, 255), 3);
            graf.cls(Color.White);
            if (Console.KeyAvailable) 
            {
                //Console.Beep();
                Sys.KeyEvent key = Sys.KeyboardManager.ReadKey();
                if (graf.x > 10 && key.Key == Sys.ConsoleKeyEx.LeftArrow) graf.x = graf.x - 5;
                if (graf.x<1010 && key.Key == Sys.ConsoleKeyEx.RightArrow) graf.x = graf.x + 5;
                

            }
            graf.canvas.DrawLine(ppp, new Sys.Graphics.Point(graf.x,0), new Sys.Graphics.Point(graf.x-512, 799));
            graf.canvas.DrawLine(ppp, new Sys.Graphics.Point(graf.x, 0), new Sys.Graphics.Point(graf.x + 512, 799));
            graf.canvas.DrawLine(ppp, new Sys.Graphics.Point(graf.x, 797), new Sys.Graphics.Point(graf.x+512 , 798));
            graf.canvas.DrawLine(ppp, new Sys.Graphics.Point(graf.x - 512, 797), new Sys.Graphics.Point(graf.x , 798));
            if (counter > 450 && counter < 690) 
            {
                if (counter4 == 0 && graf.x > 60) Console.Beep();
                if (counter4 == 1 && graf.x < 900) Console.Beep();

            }
            if (counter < 650)
            {
                if (counter4 == 0)
                {
                    graf.canvas.DrawRectangle(ppp, new Sys.Graphics.Point(graf.x - counter / 6, counter), counter / 6, counter / 6);
                }
                else
                {
                    graf.canvas.DrawRectangle(ppp, new Sys.Graphics.Point(graf.x + counter / 6, counter), counter / 6,counter/6);

                }

            }
            else 
            {
                if (counter > 1000) 
                {
                    if (counter4 == 0)
                    {
                        counter = 0;
                        counter4 = 1;

                    }
                    else 
                    {
                        counter = 0;
                        counter4 = 0;
                    }
                
                }
            
            
            
            }
            for (int yy=0;yy<760;yy=yy+25) graf.canvas.DrawLine(ppp, new Sys.Graphics.Point(graf.x, yy+counter3), new Sys.Graphics.Point(graf.x, yy+15+counter3));
            if (counter3 == 15) 
            {
                counter3 = 0;

            }
            else 
            {

                counter3 = 15;

            }
            counter = counter + 1;
            
            graf.displays();
        }

    }



}
