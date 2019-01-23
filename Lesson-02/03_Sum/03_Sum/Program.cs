using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _03_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 2. Управляющие конструкции";
            string homework = "Домашнее задание: 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.";
            MyClass.TextAbout(lesson, homework); //воспользуюсь своей библиотекой для создания шапки

            int sum = 0; //здесь будем хранить сумму
            int a = MyClass.InputInt("Введите число и нажмите \"Enter\". Введите \"0\", чтобы закончить ввод:");

            while (a != 0)
            {
                if (a > 0 && a % 2 == 1) { sum = sum + a; }
                a = MyClass.InputInt("");
            }

            Console.Write("Сумма всех нечетных положительных чисел: ");
            Console.WriteLine(sum);


            Console.ReadLine();
        }
    }
}
