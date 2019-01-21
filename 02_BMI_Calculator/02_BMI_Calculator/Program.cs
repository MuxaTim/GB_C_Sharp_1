using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Студент: Тимченко Михаил");
            Console.WriteLine("Курс: C# Уровень 1");
            Console.WriteLine("Урок: 1.Введение.Базовые типы данных.Консоль.Классы и методы.");
            Console.WriteLine("Домашнее задание №2:\nВвести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле\nI=m/(h*h); где m — масса тела в килограммах, h — рост в метрах");
            Console.WriteLine("===================================================");

            //Переменные для работы с анкетой
            float userHeight; //рост
            float userWeight; //вес
            float bmi; // ИМТ - индекс массы тела (BMI - body mass index)

            //Ввод данных
            Console.WriteLine("Введите ваш рост в метрах:");
            string str = Console.ReadLine();
            userHeight = float.Parse(str);
            Console.WriteLine("Введите ваш вес в килограммах:");
            str = Console.ReadLine();
            userWeight = float.Parse(str);

            //Расчет ИМТ I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
            bmi = userWeight / (userHeight * userHeight);
            Console.WriteLine($"Индекс массы вашего тела равен: {bmi:F}");

            Console.ReadLine();

        }
    }
}
