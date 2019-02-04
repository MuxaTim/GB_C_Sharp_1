using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Login
{
    class Program
    {

        //Метод LoginCheck проверяет корректность логина
        static bool LoginCheck(string login)
        {
            if (login.Length >= 2 && login.Length <=10)
            {
                return true;
            }
            else return false;
        }

        static void Main(string[] args)
        {
            string lesson = "Урок 5. Символы, строки, регулярные выражения";
            string homework = "Домашнее задание: 1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой: а) без использования регулярных выражений; б) **с использованием регулярных выражений.";
            MyClass.TextAbout(70, lesson, homework);

            string login = string.Empty;
            
            do
            {
                Console.WriteLine("Введите логин (от 2 до 10 символов):");
                login = Console.ReadLine();
                if (LoginCheck(login))
                {
                    Console.WriteLine("Логин подходит");
                }
                else
                {
                    Console.WriteLine("Логин не подходит. Придумайте другой.");
                }
            } while (login != ""); // Выход из программы, если ничего не введено





        }
    }
}
