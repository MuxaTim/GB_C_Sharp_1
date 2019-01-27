using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Fractions
{
    class Fraction
    {
        public int numerator;
        public int denominator;

        //Приведение дроби к типу string
        public string ToString()
        {
                return numerator + "/" + denominator;
            
        }

        //Сложение дробей
        public Fraction Plus(Fraction b)
        {
            Fraction a1 = new Fraction();
            Fraction b1 = new Fraction();

            a1.numerator = this.numerator;
            a1.denominator = this.denominator;
            b1.numerator = b.numerator;
            b1.denominator = b.denominator;

            Fraction.Common(ref a1, ref b1); //приведем к общему знаменателю

            a1.numerator += b1.numerator; //суммируем числители
            return a1;
        }

        //Вычитание дробей
        public Fraction Subtraction(Fraction b)
        {
            Fraction a1 = new Fraction();
            Fraction b1 = new Fraction();

            a1.numerator = this.numerator;
            a1.denominator = this.denominator;
            b1.numerator = b.numerator;
            b1.denominator = b.denominator;

            Fraction.Common(ref a1, ref b1); //приведем к общему знаменателю

            a1.numerator -= b1.numerator; //вычитаем числители
            return a1;
        }

        //Метод умножения
        public Fraction Multiplication(Fraction b)
        {
            Fraction c = new Fraction();
            c.numerator = this.numerator * b.numerator;
            c.denominator = this.denominator * b.denominator;
            return c;
        }

        //Метод деления
        public Fraction Division(Fraction b)
        {
            Fraction c = new Fraction();
            c.denominator = b.numerator;
            c.numerator = b.denominator;
            return this.Multiplication(c);
        }

        //Приведение к общему знаменателю
        public static void Common(ref Fraction a,ref Fraction b)
        {
            int aDenom = a.denominator; //сохраним в переменную значение знаменателя дроби "a"

            a.numerator = a.numerator * b.denominator;
            a.denominator = a.denominator * b.denominator;

            b.numerator = b.numerator * aDenom;
            b.denominator = b.denominator * aDenom;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 3. Методы. От структур к объектам.";
            string homework = "Домашнее задание: 3. *Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса. **Добавить проверку, чтобы знаменатель не равнялся 0.Выбрасывать исключение ArgumentException(\"Знаменатель не может быть равен 0\")";
            MyClass.TextAbout(70, lesson, homework);


            Fraction a = new Fraction();
            a.numerator = MyClass.InputInt("Задайте числитель для дроби \"A\":");
            do
            {
                a.denominator = MyClass.InputInt("Задайте знаменатель для дроби \"A\":");
                if ( a.denominator == 0 )
                {
                    Console.WriteLine("Знаменатель дроби не может быть равен \"0\"!");
                }
            } while (a.denominator == 0);
            

            Fraction b = new Fraction();
            b.numerator = MyClass.InputInt("Задайте числитель для дроби \"B\":");
            do
            {
                b.denominator = MyClass.InputInt("Задайте знаменатель для дроби \"B\":");
                if (b.denominator == 0)
                {
                    Console.WriteLine("Знаменатель дроби не может быть равен \"0\"!");
                }
            } while (b.denominator == 0);

            Fraction c = new Fraction();
            c = a.Multiplication(b);
            Console.WriteLine("\n{0} * {1} = {2}",a.ToString(), b.ToString(), c.ToString());
            c = a.Division(b);
            Console.WriteLine("\n{0} / {1} = {2}", a.ToString(), b.ToString(), c.ToString());
            c = a.Plus(b);
            Console.WriteLine("\n{0} + {1} = {2}", a.ToString(), b.ToString(), c.ToString());
            c = a.Subtraction(b);
            Console.WriteLine("\n{0} - {1} = {2}", a.ToString(), b.ToString(), c.ToString());

            Fraction.Common(ref a, ref b);
            Console.WriteLine("\nПриведение дробей к общему знаменателю: {0} {1}", a.ToString(), b.ToString());



            Console.ReadLine();
        }
    }
}
