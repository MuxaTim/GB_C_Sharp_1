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
            string a;
            string b;
            string c;
            Console.Write("Введите значение строковой переменной \"a\":");
            a = Console.ReadLine();
            Console.Write("Введите значение строковой переменной \"b\":");
            b = Console.ReadLine();

            Console.WriteLine($"\nЗначения переменных ДО обмена:\na = {a}\nb = {b}");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Значения переменных ПОСЛЕ обмена:\na = {a}\nb = {b}");


            Console.ReadLine();
        }
    }
}
