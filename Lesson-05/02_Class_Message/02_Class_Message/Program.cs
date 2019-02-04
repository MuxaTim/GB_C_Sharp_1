using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Class_Message
{
    static class Message
    {
        // Вывести только те слова сообщения,  которые содержат не более n букв.
        public static string WordsByLength (int n, string str)
        {
            string str2 = String.Empty;
            char[] div = { ' ', ',', '.', '!', '?' }; // создаем массив разделителей
            string[] parts = str.Split(div); //создаём массив слов
            for (int i = 0; i < parts.Length; i++)
            {
                if ( parts[i].Length >= n )
                {
                    str2 += parts[i] + " ";
                }
            }
            return str2;
        }

        // Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        public static string DeleteByChar(string endChar, string str)
        {
            string str2 = String.Empty;
            char[] div = { ' ', ',', '.', '!', '?' }; // создаем массив разделителей
            string[] parts = str.Split(div); // создаём массив слов
            foreach (var value in parts)
            {
                if (!value.EndsWith(endChar))
                {
                    str2 += value + " ";
                }
            }
            return str2;
        }

        // Найти самое длинное слово сообщения
        public static string LongestWord(string str)
        {
            char[] div = { ' ', ',', '.', '!', '?' }; // создаем массив разделителей
            string[] parts = str.Split(div); // создаём массив слов
            string longest = parts[0];

            foreach (var value in parts)
            {
                if (value.Length > longest.Length)
                {
                    longest = value;
                }
            }
            return longest;
        }
    }

    class Program
    {
        
        static void Main(string[] args)
        {
            string lesson = "Урок 5. Символы, строки, регулярные выражения";
            string homework = "Домашнее задание: 2. Разработать статический класс Message, содержащий следующие статические методы для обработки текста: а) Вывести только те слова сообщения,  которые содержат не более n букв. б) Удалить из сообщения все слова, которые заканчиваются на заданный символ. в) Найти самое длинное слово сообщения. г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения. д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary";
            MyClass.TextAbout(90, lesson, homework);

            string message = String.Empty;
            int n = 5; //количество букв для первого метода
            string endChar = "о";


            do
            {
                Console.WriteLine("Введите сообщение:");
                message = Console.ReadLine();
                Console.WriteLine("\n\nСлова, которые содержат не менее {0} букв:", n);
                Console.WriteLine(Message.WordsByLength(n, message));
                Console.WriteLine("\nСлова, которые не заканчиваются на символ \"{0}\":", endChar);
                Console.WriteLine(Message.DeleteByChar(endChar, message));
                Console.WriteLine("\nСамое длиное слово:");
                Console.WriteLine(Message.LongestWord(message));

            } while (message != "");
        }
    }
}
