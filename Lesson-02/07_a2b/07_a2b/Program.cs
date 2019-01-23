using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_a2b
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 2. Управляющие конструкции";
            string homework = "Домашнее задание: 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b); б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.";
            MyClass.TextAbout(lesson, homework); //воспользуюсь своей библиотекой для создания шапки

            int a = MyClass.InputInt("Введите число a:");
            int b = a;
            while (a >= b)
            {
                b = MyClass.InputInt($"Введите число b, оно должно быть больше, чем число a={a}:");
            }

            Console.WriteLine($"Выводим числа от {a} до {b}:");
            PrintA2B(a, b);

            Console.WriteLine($"\nСчитаем сумму чисел от {a} до {b}...");
            
            int sum = SumA2B(a, b, 0);
            Console.WriteLine($"Сумма чисел = {sum}");

            Console.ReadLine();
        }

        //рекурсивный метод, считающий сумму чисел
        static int SumA2B (int a, int b, int sum)
        {
            sum = sum + a;
            if (a<b)
            {
                a++;
                return SumA2B(a, b, sum);
            }
            return sum;
        }

        //Рекурсивный метод, выводящий в консоль числа от a до b
        static void PrintA2B (int a, int b)
        {
            Console.Write($"{a} ");
            a++;
            if (a <= b) {
                PrintA2B(a, b);
            }
        }
    }
}
