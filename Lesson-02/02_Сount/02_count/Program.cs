using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _02_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 2. Управляющие конструкции";
            string homework = "Домашнее задание: 2. Написать метод подсчета количества цифр числа.";
            MyClass.TextAbout(lesson, homework); //воспользуюсь своей библиотекой для создания шапки

            int a = MyClass.InputInt("Введите целое число:");
            int count = digitСount(a);
            Console.WriteLine($"Количество цифр в вашем числе: {count}");

            Console.ReadLine();
        }


        //метод digitСount считает количество цифр числа
        static int digitСount(int a)
        {
            string str = a.ToString(); //преобразуем число в строку и вернем длину этой строки
            if (a<0)
            {
                return (str.Length - 1); //если число отрицательное, то знак минуса не считаем, ведь он - не цифра
            }
            else
            {
                return str.Length; //если число положительное, то возвращаем длину как есть
            }
            
        }
    }
}
