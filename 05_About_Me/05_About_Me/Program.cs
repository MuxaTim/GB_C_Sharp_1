using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_About_Me
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Студент: Тимченко Михаил");
            Console.WriteLine("Курс: C# Уровень 1");
            Console.WriteLine("Урок: 1.Введение.Базовые типы данных.Консоль.Классы и методы.");
            Console.WriteLine("Домашнее задание №5:\nНаписать программу, которая выводит на экран ваше имя, фамилию и город проживания.");
            Console.WriteLine("===================================================");

            //Запишем имя, фамилию и город проживания в переменные
            string myName = "Михаил";
            string mySurname = "Тимченко";
            string myCity = "Кемерово";

            //Формируем строку
            string str = $"Меня зовут {myName} {mySurname}. Я - человек из {myCity}.";
             
            Console.WriteLine("Нажмите клавишу \"Enter\" для продолжения...");           
            Console.ReadLine();

            //Вывод в центре экрана
            Print(str, 35, 14);
            
            Console.ReadLine();

        }


        //Вывод текста в консоль
        static void Print(string msg, int x, int y)
        {
            Console.Clear();
            Console.SetCursorPosition(x, y);
            Console.Write(msg);
        }
    }
}
