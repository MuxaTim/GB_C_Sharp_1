using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _01_Minimum
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 2. Управляющие конструкции";
            string homework = "Домашнее задание: 1. Написать метод, возвращающий минимальное из трех чисел.";
            MyClass.TextAbout(lesson, homework);


            Console.ReadLine();
        }
    }
}
