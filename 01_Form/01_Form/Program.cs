using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Form
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Студент: Тимченко Михаил");
            Console.WriteLine("Курс: C# Уровень 1");
            Console.WriteLine("Урок: 1.Введение.Базовые типы данных.Консоль.Классы и методы.");
            Console.WriteLine("Домашнее задание №1:\nНаписать программу «Анкета».\nПоследовательно задаются вопросы (имя, фамилия, возраст, рост, вес).\nВ результате вся информация выводится в одну строчку.");
            Console.WriteLine("===================================================");

            //Переменные для работы с анкетой
            string userName; //имя
            string userSurname; //фамилия
            byte userAge; //возраст
            byte userHeight; //рост
            byte userWeight; //вес

            //Ввод данных
            Console.WriteLine("Ввод данных пользователя:");
            Console.Write("Имя: ");
            userName = Console.ReadLine();
            Console.Write("Фамилия: ");
            userSurname = Console.ReadLine();
            Console.Write("Возраст: ");
            string str = Console.ReadLine();
            userAge = byte.Parse(str);
            Console.Write("Рост: ");
            str = Console.ReadLine();
            userHeight = byte.Parse(str);
            Console.Write("Вес: ");
            str = Console.ReadLine();
            userWeight = byte.Parse(str);

            //Вывод
            Console.WriteLine(userName + " " + userSurname + ". Возраст: " + userAge + ". Рост: " + userHeight + ". Вес: " + userWeight);


            Console.ReadLine();
        }

    }
}
