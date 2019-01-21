using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MyClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Print(string str)
        {
            Console.WriteLine(str);          
        }

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(msg);
        }

        static void Pause()                    
        {
            Console.ReadKey();
        }


        static void Pause(string str)
        {
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
