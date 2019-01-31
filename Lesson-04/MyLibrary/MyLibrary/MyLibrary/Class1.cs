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
        static public void TextAbout(int l, string lesson, string homework)
        {
            string student = "Студент: Тимченко Михаил"; //имя студента
            string course = "Курс: C# Уровень 1"; //название учебного курса

            //рисуем верхнюю грань
            Console.Write("╔");
            int i = 0;
            for (i = 0; i < l; i++)
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
            int spaсe = (l - str.Length) / 2; //вычисляем количество пробелов, необходимое для центровки текста
            int n = (l - str.Length) % 2; //не любой текст можно разместить чётко посередине
            PrintSpace(spaсe);
            Console.Write(str);
            PrintSpace(spaсe);
            if (n == 1) { Console.Write(" "); } //дописываем пробел, если текст нельзя оцентровать
            Console.WriteLine("║");
        }


        //метод InputInt для запроса у юзера числа типа Int
        static public int InputInt(string message)
        {
            int a;
            Console.Write(message);
            string str = Console.ReadLine();
            bool isInt = int.TryParse(str, out a); //проверем, введено число или нет
            if (isInt)
            {
                a = int.Parse(str); //если всё ок, то парсим строку в переменную а
            }
            else
            {
                //если нет, то предупреждаем пользователя и используем рекурсию для повторного запроса
                Console.WriteLine("Вы ввели не целое число, повторите ввод!");
                a = InputInt(message);
            }
            return a;
        }

        //метод InputFloat для запроса у юзера числа типа Float
        static public float InputFloat(string message)
        {
            float a;
            Console.Write(message);
            string str = Console.ReadLine();
            bool isFloat = float.TryParse(str, out a); //проверем, введено число или нет
            if (isFloat)
            {
                a = float.Parse(str);
            }
            else
            {
                //если нет, то предупреждаем пользователя и используем рекурсию для повторного запроса
                Console.WriteLine("Вы ввели не число, повторите ввод!");
                a = InputFloat(message);
            }

            return a;
        }

        //метод InputDouble для запроса у юзера числа типа Double
        static public double InputDouble(string message)
        {
            double a;
            Console.Write(message);
            string str = Console.ReadLine();
            bool isFloat = double.TryParse(str, out a); //проверем, введено число или нет
            if (isFloat)
            {
                a = float.Parse(str);
            }
            else
            {
                //если нет, то предупреждаем пользователя и используем рекурсию для повторного запроса
                Console.WriteLine("Вы ввели не число, повторите ввод!");
                a = InputFloat(message);
            }

            return a;
        }

        //метод DrawCat рисует кота в консоли
        static public void DrawCat()
        {
            Console.WriteLine("\n                   .                ,.");
            Console.WriteLine("                  T.\"-._..-- -.._,-\"/|");
            Console.WriteLine("                  l|\" -._.v._(\"      |");
            Console.WriteLine("                  [l /.'_ \\; _~\"-.`-t");
            Console.WriteLine("                  Y \" _(o} _{o)._ ^.|");
            Console.WriteLine("                  j  T  ,-<v>-.  T  ]");
            Console.WriteLine("                  \\  l ( /-^-\\ ) !  !");
            Console.WriteLine("                   \\. \\.  \"~\"  ./  /c-..,__");
            Console.WriteLine("                     ^r- .._ .- .-\"  `- .  ~\"--.");
            Console.WriteLine("                      > \\.                      \\ ");
            Console.WriteLine("                      ]   ^.                     \\ ");
            Console.WriteLine("                      3  .  \">            .       Y  ");
            Console.WriteLine("         ,.__.--._   _j   \\ ~   .         ;       |");
            Console.WriteLine("        (    ~\"-._~\"^._\\   ^.    ^._      I     . l");
            Console.WriteLine("         \"-._ ___ ~\"-,_7    .Z-._   7\"   Y      ;  \\        _");
            Console.WriteLine("            /\"   \"~-(r r  _/_--._~-/    /      /,.--^-._   / Y");
            Console.WriteLine("            \"-._    '\"~~~>-._~]>--^---./____,.^~        ^.^  !");
            Console.WriteLine("                ~--._    '   Y---.                        \\./");
            Console.WriteLine("                     ~~--._  l_   )                        \\ ");
            Console.WriteLine("                           ~-._~~~---._,____..---           \\ ");

        }
    }

    public class MyArray
    {
        int[] a;
        //  Создание массива и заполнение его одним значением el  
        public MyArray(int n, int el)
        {
            a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = el;
        }
        //  Создание массива и заполнение его случайными числами от min до max
        public MyArray(int n, int min, int max)
        {
            a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next(min, max);
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
