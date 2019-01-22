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
            MyClass.TextAbout(lesson, homework); //воспользуюсь своей библиотекой для создания шапки

            //запросим у пользователя 3 числа
            int a1 = MyClass.InputInt("Введите число 1:");
            float a2 = MyClass.InputFloat("Введите число 2:");

            Console.WriteLine(a1);
            Console.WriteLine(a2);


            Console.ReadLine();
        }
    }
}
