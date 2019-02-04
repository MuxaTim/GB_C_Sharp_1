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
            // Строка допустимых символов в логине 
            // (т.к. мы не проверяем регистр, то все символы здесь в нижнем регистре)
            string allowChars = "abcdefghijklmnopqrstuvwxyz0123456789";

            char loginChar;

            // Проверяем длину логина
            if (login.Length >= 2 && login.Length <=10)
            {
                // Проверяем, является ли первый символ логина числом
                if (!Char.IsDigit(login[0]))
                {
                    for (int i = 0; i<login.Length; i++)
                    {
                        loginChar = Char.ToLower(login[i]); // Проверку символов делаем по нижнему регистру
                        if (!allowChars.Contains(loginChar))
                        {
                            return false;
                        }
                    }
                    return true;
                }

                else return false;
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
