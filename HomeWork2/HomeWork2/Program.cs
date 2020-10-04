using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.WriteLine("Введите число R");
            while (!double.TryParse(Console.ReadLine(), out r))
            {
                Console.WriteLine("Ошибка ввода! Введите число R ");
            }

            for (double x = -10; x <= 4; x += 0.2)
            {
                if (x < -10)
                {
                    Console.WriteLine("Функция не определена");
                }
                else if (x < -6)
                {
                    Console.WriteLine($"y({Math.Round(x, 1)})={Math.Round(segment1(x, r), 1)}");

                }
                else if (x < -4)
                {
                    Console.WriteLine($"y({Math.Round(x, 1)})={Math.Round(segment2(x, r), 1)}");

                }
                else if (x < 2)
                {
                    Console.WriteLine($"y({Math.Round(x, 1)})={Math.Round(segment3(x, r), 1)}");

                }
                else
                {
                    Console.WriteLine($"y({Math.Round(x, 1)})={Math.Round(segment4(x, r), 1)}");
                }

            }
        }
        //расчет первого сегмента графика
        static double segment1(double x, double r)
        {
            //центр окружности
            double a = -8;
            double b = 2;
            double y;
            //по уравнению окружности
            y = Math.Sqrt(r * r - (x - a) * (x - a)) - b;
            //возвращаем значение
            return -y;
        }

        //расчет второго сегмента графика
        static double segment2(double x, double r)
        {
            double y = 2;
            return y;
        }

        //расчет третего сегмента графика
        static double segment3(double x, double r)
        {
            double y = -0.5 * x;
            return y;
        }

        //расчет третьего сегмента графика
        static double segment4(double x, double r)
        {
            double y = x - 3;
            return y;
        }
    }

}
