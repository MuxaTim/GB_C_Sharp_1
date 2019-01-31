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
            short stepB = -2;

            // Создаём экземпляр класса MyArray, третьим праметром передаём переменную типа short
            MyArray a = new MyArray(10, 5, stepA);
            MyArray b = new MyArray(22, 10, stepB);

            Console.WriteLine(a);
            Console.WriteLine(b);


            Console.ReadLine();
        }
    }
}
