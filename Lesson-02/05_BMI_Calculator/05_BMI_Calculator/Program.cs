using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BMI_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 2. Управляющие конструкции";
            string homework = "Домашнее задание: 5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме; б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.";
            MyClass.TextAbout(lesson, homework); //воспользуюсь своей библиотекой для создания шапки

            //Переменные для работы с анкетой
            float userHeight; //рост
            float userWeight; //вес
            float bmi; // ИМТ - индекс массы тела (BMI - body mass index)
            float bmiMin = 18.5F; //минимальный bmi для нормального веса
            float bmiMax = 24.99F; //максимальный bmi для нормального веса

            //Ввод данных
            userHeight = MyClass.InputFloat("Введите ваш рост в метрах:");
            userWeight = MyClass.InputFloat("Введите ваш вес в килограммах:");


            //Расчет ИМТ I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
            bmi = userWeight / (userHeight * userHeight);
            Console.WriteLine($"Индекс массы вашего тела равен: {bmi:F}");

            //Текстовое пояснение к индексу массы тела
            Console.Write("Это означает, что у вас ");
            if (bmi <= 16)
            {
                Console.WriteLine("выраженный дефицит массы тела.");
            }
            else if (bmi <= bmiMin)
            {
                Console.WriteLine("недостаточная (дефицит) масса тела.");
            }
            else if (bmi <= bmiMax)
            {
                Console.WriteLine("нормальная масса тела.");
            }
            else if (bmi <= 30)
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

            if (bmi <= 18.5 || bmi > 25)
            {
                WeightOk(userHeight, userWeight, bmiMin, bmiMax);
            }
            


            Console.ReadLine();
        }

        //метод WeightOk рассчитывает, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        static void WeightOk(float userHeight, float userWeight, float bmiMin, float bmiMax)
        {
            //рассчитаем нормальный вес для заданного роста
            float minWeight = bmiMin * userHeight * userHeight;
            float maxWeight = bmiMax * userHeight * userHeight;

            Console.WriteLine($"Для вашего роста нормальный вес должен быть от {minWeight:F} до {maxWeight:F} кг.");
            float deltaWeight = minWeight - userWeight; //рассчитываем разницу в весе
            if (deltaWeight > 0) {   //если разница положительная, значит рассчитали верно
                Console.WriteLine($"Для нормализации веса вам необходимо набрать {deltaWeight:F} кг.");
            }
            else
            {
                deltaWeight = userWeight - maxWeight;
                Console.WriteLine($"Для нормализации веса вам необходимо сбросить {deltaWeight:F} кг.");
            }
            
        }
    }
}
