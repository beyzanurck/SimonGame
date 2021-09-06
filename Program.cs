using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for (int i = 0; i < 80; i+=10)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 + x, 30 + y);
                Console.Write(".");
            }

            // yellow part
            r = 17;
            for (int i = 0; i < 80; i += 10)
            {
                pointX = 2 * r * Math.Cos(i * pi / 180);
                pointY = r * Math.Sin(i * pi / 180);

                int x = Convert.ToInt32(pointX);
                int y = Convert.ToInt32(pointY);
                Console.SetCursorPosition(20 + 60 - x, 30 + y);
                Console.Write(".");
            }

            Console.ReadLine();
        }
    }
}