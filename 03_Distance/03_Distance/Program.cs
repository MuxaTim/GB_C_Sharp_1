using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Студент: Тимченко Михаил");
            Console.WriteLine("Курс: C# Уровень 1");
            Console.WriteLine("Урок: 1.Введение.Базовые типы данных.Консоль.Классы и методы.");
            Console.WriteLine("Домашнее задание №3:\nНаписать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2\nпо формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).");
            Console.WriteLine("===================================================");

            //Переменные
            double x1;
            double y1;
            double x2;
            double y2;
            double distance;

            //Ввод данных
            Console.Write("Введите для точки 1 координату X1: ");
            string str = Console.ReadLine();
            x1 = double.Parse(str);
            Console.Write("Введите для точки 1 координату Y1: ");
            str = Console.ReadLine();
            y1 = double.Parse(str);
            Console.Write("Введите для точки 2 координату X2: ");
            str = Console.ReadLine();
            x2 = double.Parse(str);
            Console.Write("Введите для точки 2 координату Y2: ");
            str = Console.ReadLine();
            y2 = double.Parse(str);

            distance = distanceCount(x1, y1, x2, y2);

            Console.WriteLine($"\nРасстояние между точками 1 и 2 составляет - {distance:F2}");


            Console.ReadLine();
        }

        //вычисление расстояния между точками в виде метода
        static double distanceCount (double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
