using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 3. Методы. От структур к объектам.";
            string homework = "Домашнее задание: 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse; б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию; ";
            MyClass.TextAbout(90, lesson, homework);

            string str = "";
            int a = 0;
            int sum = 0;

            do
            {
                a = MyClass.InputInt("Введите число:");

                if ( a > 0 && a%2 == 1)
                {
                    str += " " + a.ToString();
                    sum += a;
                }
            } while (a != 0);

            Console.WriteLine("\nНечетные положительные числа: {0}", str);
            Console.WriteLine("Их сумма:{0}", sum);
            Console.ReadLine();

        }
    }
}
