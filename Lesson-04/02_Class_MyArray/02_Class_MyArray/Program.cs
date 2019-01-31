using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _02_Class_MyArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаём шаг
            short stepA = 5;

            // Создаём экземпляр класса MyArray, третьим праметром передаём переменную типа short
            MyArray a = new MyArray(10, 5, stepA);
            MyArray b = new MyArray(10, 1, 4);

            Console.WriteLine("Массив a:");
            Console.WriteLine(a);

            Console.Write("Сумма элементов массива: ");
            Console.WriteLine(a.Sum);

            a.Inverse();
            Console.WriteLine(a);
            Console.Write("Сумма элементов массива: ");
            Console.WriteLine(a.Sum);

            a.Multi(10);
            Console.WriteLine(a);
            Console.Write("Сумма элементов массива: ");
            Console.WriteLine(a.Sum);

            Console.WriteLine("\nМассив b:");
            Console.WriteLine(b);
            Console.WriteLine("Количество максимальных элементов: " + b.MaxCount);

            string fileName = "file.txt";
            Console.WriteLine("\nЧитаем данные из файла " + fileName + " используя конструктор класса MyFile:");
            MyFile.Print(fileName);

            Console.ReadLine();
        }
    }
}
