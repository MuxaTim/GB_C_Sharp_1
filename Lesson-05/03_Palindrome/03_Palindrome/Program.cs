using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Palindrome
{
    class Program
    {
        static bool Palindrome(string message1, string message2)
        {
            if (message1.Length == message2.Length)
            {
                int l = message1.Length - 1;
                for (int i = 0; i < l; i++)
                {
                    if (message1[i] != message2[l - i])
                    {
                        return false;
                    }
                }
                return true;
                
            }
            else return false;
        }

        static void Main(string[] args)
        {
            string lesson = "Урок 5. Символы, строки, регулярные выражения";
            string homework = "Домашнее задание: 3. Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Например: badc являются перестановкой abcd.";
            MyClass.TextAbout(70, lesson, homework);

            string message1 = String.Empty;
            string message2 = String.Empty;

            do
            {
                Console.WriteLine("\nВведите первое сообщение:");
                message1 = Console.ReadLine();
                Console.WriteLine("Введите второе сообщение:");
                message2 = Console.ReadLine();
                if ( Palindrome(message1,message2) )
                {
                    Console.WriteLine("\nСтроки зеркальные!");
                }
                else Console.WriteLine("\nСтроки НЕ зеркальные!");

            } while (message1 != "");
        }
    }
}
