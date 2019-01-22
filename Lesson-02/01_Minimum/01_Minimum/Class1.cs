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
            int l = 61; //длина рамки
            string student = "Студент: Тимченко Михаил"; //имя студента
            string course = "Курс: C# Уровень 1"; //название учебного курса
            
            //рисуем верхнюю грань
            Console.Write("╔"); 
            int i = 0;
            for( i = 0; i < l; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╗");
            //верхняя грань нарисована

            //рисуемм "Студент"
            PrintTextInsideFrame(student, l);

            //рисуем "Курс"
            PrintTextInsideFrame(course, l);

            //рисуем "Урок"
            PrintTextInsideFrame(lesson, l);

            //рисуем "ДЗ"
            PrintTextInsideFrame(homework, l);
            
            

            //рисуем нижнюю грань
            Console.Write("╚");
            for (i = 0; i < l; i++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╝");
            //нижняя грань нарисована
        }


        //метод PrintSpace пишет пробелы " " в консоль
        static void PrintSpace(int i2)
        {
            for (int i = 0; i < i2; i++)
            {
                Console.Write(" ");
            }
        }

        //метод PrintTextInsideFrame пишет текст внутри рамки по центру
        static void PrintTextInsideFrame(string str, int l)
        {
            //Если длина строки больше ширины рамки - разбиваем на несколько строк,
            //Выводим их на экран, используя рекурсию
            //(по-хорошему допилить, чтобы слова правильно переносились,
            //но, кажется, для начала нужно будет изучить регулярные выражения
            //иначе кода будет слишком много:))

            if (str.Length > l)
            {
                int lines = str.Length / l; //какое количество строк нам понадобится?

                for (int j = 0; j < lines; j++) //в этом цикле выводим на печать строку кусочками заданной длины
                {
                    PrintTextInsideFrame(str.Substring(j * l, l), l);
                }
                str = str.Substring(lines * l); //сохраняем в str последний хвостик от всей строки и снова его в печать
            }
            //конец цикла для длинных строк

            Console.Write("║");
            int spaсe = ( l - str.Length ) / 2; //вычисляем количество пробелов, необходимое для центровки текста
            int n = ( l - str.Length ) % 2; //не любой текст можно разместить чётко посередине
            PrintSpace(spaсe);
            Console.Write(str);
            PrintSpace(spaсe);
            if (n==1) { Console.Write(" "); } //дописываем пробел, если текст нельзя оцентровать
            Console.WriteLine("║");
        }

    }
}
