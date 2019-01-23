using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_GoodNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 2. Управляющие конструкции";
            string homework = "Домашнее задание: 6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. Хорошим называется число, которое делится на сумму своих цифр. Реализовать подсчет времени выполнения программы, используя структуру DateTime.";
            MyClass.TextAbout(lesson, homework); //воспользуюсь своей библиотекой для создания шапки

            for (int maxNumber = 10; maxNumber <= 1000000000; maxNumber = maxNumber * 10) {
                Console.WriteLine("Считаем до {0:# ### ### ###}...", maxNumber);


                int goodNumberCount = 0; //счетчик хороших чисел

                DateTime start = DateTime.Now; //запуск таймера
                for (int i = 1; i <= maxNumber; i++)
                {
                    if (i % NumbersSum(i) == 0) goodNumberCount++;
                }
                DateTime finish = DateTime.Now; //остановка таймера

                
                Console.WriteLine("В диапазоне от 1 до {0:# ### ### ###} находится {1:# ### ### ###} хороших чисел.", maxNumber, goodNumberCount);
                Console.Write("Времени на просчет этого диапазона затрачено: ");
                Console.WriteLine(finish - start);
                
            }
            Console.ReadLine();
        }

        //метод NumbersSum подсчитывает сумму цифр в числе
        static int NumbersSum (int number)
        {
            int count = 0;
            while (number != 0)
            {
                count = count + number % 10;
                number = number / 10;
            }
            return count;
        }
    }
}
