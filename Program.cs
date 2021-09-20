﻿using System;
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

            Thread.Sleep(800);

            Random random = new Random();
            //int counterForButton = 1;
           
            int[] buttons = new int[10];
            int[] userChoice = new int[10];
            for (int i = 0; i < buttons.Length; i++)
            {
                string process = "WATCH";
                Console.SetCursorPosition(78, 30);
                Console.Write(process);

                int flashingButton = random.Next(1, 5);
                buttons[i] = flashingButton;

                for (int x = 0; x <= i; x++)
                {
                    switch (buttons[x])
                    {
                        case 1:
                            flashingEffect(ConsoleColor.DarkBlue, 5);
                            break;
                        case 2:
                            flashingEffect(ConsoleColor.DarkYellow, 95);
                            break;
                        case 3:
                            flashingEffect(ConsoleColor.DarkGreen, 185);
                            break;
                        case 4:
                            flashingEffect(ConsoleColor.DarkRed, 275);
                            break;
                    }
                }
                

                Thread.Sleep(500);

                process = " PLAY ";
                Console.SetCursorPosition(78, 30);
                Console.Write(process);
                

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.NumPad1:
                        userChoice[i] = 1;
                        break;

                    case ConsoleKey.NumPad2:
                        userChoice[i] = 2;
                        break;
                    case ConsoleKey.NumPad3:
                        userChoice[i] = 3;
                        break;

                    case ConsoleKey.NumPad4:
                        userChoice[i] = 4;
                        break;
                }

                bool isMatch = true;

                for (int a = 0; a <= i; a++)
                {
                    if (userChoice[a] != buttons[a])
                    {
                        isMatch = false;
                    }
                }

                if (isMatch == false)
                {
                    break;
                }
                Thread.Sleep(500);

                //counterForButton++;
               // buttons = new int[counterForButton];//!!!!
            }

            Console.SetCursorPosition(78, 30);
            Console.Write("GAME OVER");
            Console.ReadLine();
        }
        public static void drawGameBoard()
        {
            double pointX = 0;
            double pointY = 0;
            int r = 20;
            double pi = Math.PI;

            for (int i = 0; i < 360; i += 10)
            {
               

                if (i != 50 && i != 140 && i != 230 && i != 320)
                {
                    pointX = 2 * r * Math.Cos(i * pi / 180);
                    pointY = r * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                    Console.Write(".");
                }
                else
                {
                    pointX = 2 * 22 * Math.Cos(i * pi / 180);
                    pointY = 22 * Math.Sin(i * pi / 180);

                    int x = Convert.ToInt32(pointX);
                    int y = Convert.ToInt32(pointY);
                    Console.SetCursorPosition(20 + 60 + x, 30 + y);
                   
                    if (i == 50)
                    {
                        Console.Write("1");
                    }
                    else if (i == 140)
                    {
                        Console.Write("2");
                    }
                    else if (i == 230)
                    {
                        Console.Write("3");
                    }
                    else
                    {
                        Console.Write("4");
                    }
                }
            }
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

        public static void flashingEffect(ConsoleColor color, int angle)
        {
            int r = 17;
            double pointX = 0;
            double pointY = 0;
            double pi = Math.PI;

            for (int repeat = 0; repeat < 1; repeat++)
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

                Thread.Sleep(1000);
            }           
        }

    }
}