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

            Console.WriteLine(a);

            Console.Write("Сумма элементов массива: ");
            Console.WriteLine(a.Sum);


            Console.ReadLine();
        }
    }
}
