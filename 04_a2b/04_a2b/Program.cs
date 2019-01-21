using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_a2b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Студент: Тимченко Михаил");
            Console.WriteLine("Курс: C# Уровень 1");
            Console.WriteLine("Урок: 1.Введение.Базовые типы данных.Консоль.Классы и методы.");
            Console.WriteLine("Домашнее задание №4:\nНаписать программу обмена значениями двух переменных.");
            Console.WriteLine("===================================================");

            //переменные
            float a;
            float b;
            float c;
            Console.Write("Введите числовое значение переменной \"a\":");
            string str = Console.ReadLine();
            a = float.Parse(str);
            Console.Write("Введите числовое значение переменной \"b\":");
            str = Console.ReadLine();
            b = float.Parse(str);

            Console.WriteLine($"\nЗначения переменных ДО обмена:\na = {a}\nb = {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Значения переменных ПОСЛЕ обмена:\na = {a}\nb = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Меняем значения переменных обратно,\nно уже НЕ используем третью переменную:\na = {a}\nb = {b}");


            Console.ReadLine();
        }
    }
}
