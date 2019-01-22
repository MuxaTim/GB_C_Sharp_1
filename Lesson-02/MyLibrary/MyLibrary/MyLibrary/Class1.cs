using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class MyClass
    {

        //Шапка для моих домашних заданий в C# - уровень 1
        static public void TextAbout(string lesson, string homework)
        {
            Console.WriteLine("Студент: Тимченко Михаил");
            Console.WriteLine("Курс: C# Уровень 1");
            Console.WriteLine(lesson);
            Console.WriteLine(homework);
            Console.WriteLine("===================================================");
        }

    }
}
