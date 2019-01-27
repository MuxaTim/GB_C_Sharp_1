using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olympiad_challenge
{
    class Program
    {
        //считаем кол-во групп
        static int NumberOfGroups(int n)
        {
            int i = 0;
            do
            {
                i++;
            } while (Math.Pow(2, i) < n);
            return i;
        }


        //Наглядный пример построения групп
        static void PrintGroups(int n)
        {
            int j = 30; // ограничение на количество выводимых на печать чисел
            Console.WriteLine("\nПринцип построения групп:");
            for (int i=1; i<=n && i<=j; i++)
            {
                Console.Write(i + " ");
                if (Math.Log((i+1), 2) % 1 == 0)
                {
                    Console.WriteLine();
                }
            }
            if (n>j) Console.WriteLine("...\nи т.д.");

            Console.WriteLine("\n\nКаждая новая группа начинается с 2^i.\n");
        }


        static void Main(string[] args)
        {
            string lesson = "Урок 3. Методы. От структур к объектам.";
            string homework = "Дополнительное задание. ...учитель выписал все целые числа от 1 до N в несколько групп, при этом если одно число делится на другое, то они обязательно оказались в разных группах. Требуется определить минимальное число групп, на которое можно разбить все числа от 1 до N в соответствии с приведённым выше условием.";
            MyClass.TextAbout(70, lesson, homework);

            int n = MyClass.InputInt("Укажите N:");
            PrintGroups(n);

            int groups = NumberOfGroups(n);
            Console.WriteLine("Для N={0:### ### ### ###} минимальное число групп составит - {1} (2^{1} = {2:### ### ### ###})", n, groups, Math.Pow(2, groups));
            n = 1000000000;
            groups = NumberOfGroups(n);
            Console.WriteLine("Для N={0:### ### ### ###} минимальное число групп составит - {1} (2^{1} = {2:### ### ### ###})", n, groups, Math.Pow(2, groups));
            

            Console.ReadLine();
        }
    }
}
