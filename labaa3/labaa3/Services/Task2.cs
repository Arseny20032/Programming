using System;
using System.Collections.Generic;
using System.Text;


namespace labaa3.Services
{
    public class Task2
    {
        public static double Funtion(double z)
        {
            int branch = 2;
            double x, y1, y2, y;
            if (z <= 0)
            {
                x = Math.Pow(z, 2) + 5;
                branch = 1;
            }
            else
            {
                x = 1 / Math.Sqrt(z - 1);
            }

            y1 = Math.Pow(Math.Sin(Math.Pow(x, 2) - 1), 3);
            y2 = Math.Log(Math.Abs(x)) + Math.Pow(Math.E, x);
            y = y1 + y2;
            Console.WriteLine("Результат: " + y);
            Console.WriteLine("Номер ветки: " + branch);

            return y;
        }
    }
}
