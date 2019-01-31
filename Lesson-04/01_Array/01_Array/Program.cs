using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 4. Массивы. Текстовые файлы";
            string homework = "Домашнее задание: 1. Дан целочисленный массив из 20 элементов. Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно. Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. Например, для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.";
            MyClass.TextAbout(70, lesson, homework);

            int[] array = new int[20];
            Random r = new Random();
            int rndMin = -10000;
            int rndMax = 10001;
            int a = 0; //счетчик пар, отвечающих условию

            Console.WriteLine("Элементы массива:");

            // Заранее зададим значение 0-го элемента
            array[0] = r.Next(rndMin, rndMax);
            Console.Write(array[0]);

            // Далее в цикле задаём значения элементов, начиная с 1-го
            // И проверяем i-ый и (i-1)-ый элементы
            for (int i = 1; i < array.Length; i++) 
            {
                array[i] = r.Next(rndMin, rndMax);
                Console.Write(", " + array[i]);

                // Проверяем пару элементов
                // Если хотябы один из них делится на 3 без остатка, то увеличиваем счетчик
                if (array[i-1] % 3 == 0 || array[i] % 3 == 0)
                {
                    a++;
                }
            }

            Console.WriteLine("\nКоличество пар элементов массива, отвечающих условию: " + a);  

            Console.ReadLine();
        }
    }
}
