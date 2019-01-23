using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _04_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 2. Управляющие конструкции";
            string homework = "Домашнее задание: 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.";
            MyClass.TextAbout(lesson, homework); //воспользуюсь своей библиотекой для создания шапки

            string loginOk = "root";
            string passwordOk = "GeekBrains";

            

            bool loginGood = SignIn(loginOk, passwordOk);

            if (loginGood)
            {
                Console.Write($"Пароль верный. Вы вошли в систему под пользователем {loginOk}");
            }
            else
            {
                Console.Write($"Логин или пароль не верный. Попробуйте еще раз.");

            }

            Console.ReadLine();
        }

        static bool SignIn (string loginOk, string passwordOk)
        {
            Console.Write("Введите логин: ");
            string loginTry = Console.ReadLine();
            Console.Write("Введите пароль: ");
            string passwordTry = Console.ReadLine();

            if (loginTry == loginOk && passwordTry == passwordOk) return true;
            else return false;
        }
    }
}
