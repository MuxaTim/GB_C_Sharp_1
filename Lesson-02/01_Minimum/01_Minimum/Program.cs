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
            float a1 = MyClass.InputFloat("Введите число 1:");
            float a2 = MyClass.InputFloat("Введите число 2:");
            float a3 = MyClass.InputFloat("Введите число 3:");

            float min = Minimum(a1, a2, a3);
            Console.WriteLine($"Вы ввели числа {a1}, {a2}, {a3}.\nМинимальное из этих чисел: {min}");

            Console.ReadLine();
        }

        //метод Minimum возвращает минимальное из 3 переданных ему чисел
        static float Minimum(float a1, float a2, float a3)
        {
            float min = a1;
            if (min>a2) {
                min = a2;
            }
            else if (min > a3) {
                min = a3;
            }
            return min;
        }
    }
}
