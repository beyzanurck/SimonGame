using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace simon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            double pointX = 0;
            double pointY = 0;
            int r = 20;
            double pi = Math.PI;

            for (int i = 0; i < 360; i+=10)
            {
                pointX = 2 * r * Math.Cos(i*pi/180);
                pointY = r * Math.Sin(i*pi/180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20+60 + x, 30 + y);
                Console.Write(".");
             
            }

            // blue part
            r = 17;

            for (int i = 5; i < 10; i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }           

            for (int i = 15; i < 90; i+=10)
            {        
                for (int radius = 17; radius > 9; radius -= 4)
                {
                    pointX = 2 * radius * Math.Cos(i * pi / 180);
                    pointY = radius * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write("•");
                    Console.ForegroundColor = ConsoleColor.White;
                }                           

            }

            for (int i = 90; i < 95; i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            r = 9;
            for (int i = 15; i < 90; i += 15)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write("•");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // yellow part
            r = 17;
            for (int i = 95; i < 100; i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            for (int i = 100; i < 180; i += 10)
            {
                for (int radius = 17; radius > 9; radius -= 4)
                {
                    pointX = 2 * radius * Math.Cos(i * pi / 180);
                    pointY = radius * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write("•");
                    Console.ForegroundColor = ConsoleColor.White;
                }                
            }

            for (int i = 180; i < 185; i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            r = 9;
            for (int i = 100; i < 180; i += 15)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write("•");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // green part
            r = 17;
            for (int i = 185; i < 190; i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            for (int i = 190; i < 270; i += 10)
            {
                for (int radius = 17; radius > 9; radius -= 4)
                {
                    pointX = 2 * radius * Math.Cos(i * pi / 180);
                    pointY = radius * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write("•");
                    Console.ForegroundColor = ConsoleColor.White;
                }                
            }

            for (int i = 270; i < 275; i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            r = 9;
            for (int i = 190; i < 270; i += 15)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write("•");
                Console.ForegroundColor = ConsoleColor.White;
            }

            // red part
            r = 17;
            for (int i = 275; i < 280; i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            for (int i = 280; i < 360; i += 10)
            {
                for (int radius = 17; radius > 9; radius -= 4)
                {
                    pointX = 2 * radius * Math.Cos(i * pi / 180);
                    pointY = radius * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write("•");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            }

            for (int i = 360; i < 365; i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            r = 9;
            for (int i = 280; i < 360; i += 15)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write("•");
                Console.ForegroundColor = ConsoleColor.White;
            }


            Random random = new Random();
            int flashingButton = random.Next(1,5);

            // red part         
            Thread.Sleep(500);

            for (int a = 0; a < 3; a++)
            {
                r = 17;

                r = 17;
                for (int i = 275; i < 280; i += 1)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                }

                for (int i = 280; i < 360; i += 10)
                {
                    for (int radius = 17; radius > 9; radius -= 4)
                    {
                        pointX = 2 * radius * Math.Cos(i * pi / 180);
                        pointY = radius * Math.Sin(i * pi / 180);

                        int x = Convert.ToInt32(pointX);
                        int y = Convert.ToInt32(pointY);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(20 + 60 + x, 30 + y);
                        Console.Write(" ");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }

                for (int i = 360; i < 365; i += 1)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                }

                r = 9;
                for (int i = 280; i < 360; i += 15)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Thread.Sleep(500);

                for (int i = 275; i < 280; i += 1)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                }

                for (int i = 280; i < 360; i += 10)
                {
                    for (int radius = 17; radius > 9; radius -= 4)
                    {
                        pointX = 2 * radius * Math.Cos(i * pi / 180);
                        pointY = radius * Math.Sin(i * pi / 180);

                        int x = Convert.ToInt32(pointX);
                        int y = Convert.ToInt32(pointY);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.SetCursorPosition(20 + 60 + x, 30 + y);
                        Console.Write("•");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }

                for (int i = 360; i < 365; i += 1)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                }

                r = 9;
                for (int i = 280; i < 360; i += 15)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write("•");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Thread.Sleep(500);


                

            }



            Console.ReadLine();
        }

        public static void buttonColoring(ConsoleColor color, int x, int y)
        {
           
                Console.ForegroundColor = color;
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(500);


                Console.ForegroundColor = color;
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write("•");
                Console.ForegroundColor = ConsoleColor.White;

                Thread.Sleep(500);


            


        }
    }
}