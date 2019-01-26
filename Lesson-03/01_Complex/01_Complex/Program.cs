using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace _01_Complex
{
    struct Complex
    {
        public double im;
        public double re;
        // Метод для сложения комплексных чисел
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        //  Пример произведения двух комплексных чисел
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        // Метод Subtraction служит для вычитания комплексных чисел
        public Complex Subtraction(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        // Метод Division служит для деления комплексных чисел
        public Complex Division(Complex x)
        {
            Complex c = Conjugate(x); //получаем "c" - сопряженное к "x" (делителю) число
            Complex y1 = this.Multi(c); //числитель
            Complex y2 = x.Multi(c); //знаменатель
            y1.re = y1.re / (y2.re + y2.im);
            y1.im = y1.im / (y2.re + y2.im);
            return y1;
        }

        //Возвращает сопряженное комплексное число
        public Complex Conjugate(Complex x)
        {
            Complex y;
            y.im = x.im * -1;
            y.re = x.re;
            return y;
        }

        public string ToString()
        {
            if (im == 0)
            {
                return re + "";
            }
            else if (im == 1)
            {
                return re + "+i";
            }
            else if (im == -1)
            {
                return re + "-i";
            }
            else if (im<0)
            {
                return re + "" + im + "i";
            }
            else
            {
                return re + "+" + im + "i";
            }
            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string lesson = "Урок 3. Методы. От структур к объектам.";
            string homework = "Домашнее задание: 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры; б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса; ";
            MyClass.TextAbout(70, lesson, homework);

            double re = MyClass.InputDouble("Введите значение вещественной части комплексного числа 1:");
            double im = MyClass.InputDouble("Введите значение мнимой части комплексного числа 1:");
            Complex complex1;
            complex1.re = re;
            complex1.im = im;

            re = MyClass.InputDouble("Введите значение вещественной части комплексного числа 2:");
            im = MyClass.InputDouble("Введите значение мнимой части комплексного числа 2:");
            Complex complex2;
            complex2.re = re;
            complex2.im = im;
            
            Complex result = complex1.Plus(complex2);
            Console.WriteLine("\n({0}) + ({1}) = {2}", complex1.ToString(), complex2.ToString(), result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("\n({0}) * ({1}) = {2}", complex1.ToString(), complex2.ToString(), result.ToString());
            result = complex1.Subtraction(complex2);
            Console.WriteLine("\n({0}) - ({1}) = {2}", complex1.ToString(), complex2.ToString(), result.ToString());
            result = complex1.Division(complex2);
            Console.WriteLine("\n({0}) / ({1}) = {2}", complex1.ToString(), complex2.ToString(), result.ToString());
            Console.ReadLine();
        }

        
    }

}
