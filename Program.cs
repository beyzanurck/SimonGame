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

            drawGameBoard();

            buttonColoring(ConsoleColor.DarkBlue, 5);
            buttonColoring(ConsoleColor.DarkYellow, 95);
            buttonColoring(ConsoleColor.DarkGreen, 185);
            buttonColoring(ConsoleColor.DarkRed, 275);           

            Thread.Sleep(500);

            flashingEffect(ConsoleColor.DarkRed, 275);           

            Console.ReadLine();
        }

        public static void buttonColoring(ConsoleColor color, int angle)
        {
            int r = 17;
            double pointX = 0;
            double pointY = 0;            
            double pi = Math.PI;

            for (int i = angle; i < (angle + 5); i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            for (int i = (angle + 5); i < (angle + 85); i += 10)
            {
                for (int radius = 17; radius > 9; radius -= 4)
                {
                    pointX = 2 * radius * Math.Cos(i * pi / 180);
                    pointY = radius * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = color;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write("•");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            for (int i = (angle + 85); i < (angle + 90); i += 1)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(" ");
            }

            r = 9;
            for (int i = (angle + 5); i < (angle + 85); i += 15)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.ForegroundColor = color;
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write("•");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void drawGameBoard()
        {
            double pointX = 0;
            double pointY = 0;
            int r = 20;
            double pi = Math.PI;

            for (int i = 0; i < 360; i += 10)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(".");
            }
        }

        public static void flashingEffect(ConsoleColor color, int angle)
        {
            int r = 17;
            double pointX = 0;
            double pointY = 0;
            double pi = Math.PI;

            for (int repeat = 0; repeat < 3; repeat++)
            {
                for (int i = angle; i < (angle + 5); i += 1)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                }

                for (int i = (angle + 5); i < (angle + 85); i += 10)
                {
                    for (int radius = 17; radius > 9; radius -= 4)
                    {
                        pointX = 2 * radius * Math.Cos(i * pi / 180);
                        pointY = radius * Math.Sin(i * pi / 180);

                        int x = Convert.ToInt32(pointX);
                        int y = Convert.ToInt32(pointY);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(20 + 60 + x, 30 + y);
                        Console.Write("•");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                for (int i = (angle + 85); i < (angle + 90); i += 1)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                }

                r = 9;
                for (int i = (angle + 5); i < (angle + 85); i += 15)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write("•");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Thread.Sleep(500);

                r = 17;
                for (int i = angle; i < (angle + 5); i += 1)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                }

                for (int i = (angle + 5); i < (angle + 85); i += 10)
                {
                    for (int radius = 17; radius > 9; radius -= 4)
                    {
                        pointX = 2 * radius * Math.Cos(i * pi / 180);
                        pointY = radius * Math.Sin(i * pi / 180);

                        int x = Convert.ToInt32(pointX);
                        int y = Convert.ToInt32(pointY);
                        Console.ForegroundColor = color;
                        Console.SetCursorPosition(20 + 60 + x, 30 + y);
                        Console.Write("•");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                for (int i = (angle + 85); i < (angle + 90); i += 1)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(" ");
                }

                r = 9;
                for (int i = (angle + 5); i < (angle + 85); i += 15)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.ForegroundColor = color;
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write("•");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Thread.Sleep(500);
            }           
        }

    }
}