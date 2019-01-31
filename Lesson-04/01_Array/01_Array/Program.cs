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

            for (int i = 0; i<array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }

            Console.ReadLine();
        }
    }
}
