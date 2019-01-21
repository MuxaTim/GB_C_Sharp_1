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

            //Текстовое пояснение к индексу массы тела
            Console.Write("Это означает, что у вас ");
            if ( bmi <= 16)
            {
                Console.WriteLine("выраженный дефицит массы тела.");
            }
            else if ( bmi <= 18.5 )
            {
                Console.WriteLine("недостаточная (дефицит) масса тела.");
            }
            else if ( bmi <= 24.99 )
            {
                Console.WriteLine("нормальная масса тела.");
            }
            else if ( bmi <= 30)
            {
                Console.WriteLine("избыточная масса тела (предожирение).");
            }
            else if (bmi <= 35)
            {
                Console.WriteLine("ожирение.");
            }
            else if (bmi <= 40)
            {
                Console.WriteLine("ожирение резкое.");
            }
            else if (bmi > 40)
            {
                Console.WriteLine("очень резкое ожирение.");
            }

            Console.ReadLine();

        }
    }
}
