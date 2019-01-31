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
            //Создаём экземпляр класса MyArray
            MyArray a = new MyArray(10, 5);

            Console.WriteLine(a);


            Console.ReadLine();
        }
    }
}
