using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public string lastName;
    public string firstName;
    public string university;
    public string faculty;
    public int course;
    public string department;
    public int group;
    public string city;
    public int age;
    // Создаем конструктор
    public Student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.university = university;
        this.faculty = faculty;
        this.department = department;
        this.course = course;
        this.age = age;
        this.group = group;
        this.city = city;
    }
}

class Program
{
    static int MyDelegat(Student st1, Student st2)          // Создаем метод для сравнения для экземпляров
    {

        return String.Compare(st1.firstName, st2.firstName);          // Сравниваем две строки
    }

    static int MyDelegatAge(Student st1, Student st2)          // Создаем метод для сравнения по возрасту для экземпляров
    {
        return String.Compare(st1.age.ToString(), st2.age.ToString());          // Сравниваем две строки
    }

    // Считаем количество студентов от 18 до 20 на каждом курсе используя частотный массив
    static int[] CountCourse(List<Student> list)
    {
        // Создаем частотный массив и заполняем нулями
        int[] course = new int[6];
        for (int i = 0; i < course.Length; i++) course[i] = 0;
        // Для каждого студента от 18 до 20 считаем курсы
        foreach (var v in list)
        {
            if (v.age >= 18 && v.age <= 20)
            {
                course[v.course - 1]++;
            }
        }
        return course;
    }

    static void Main(string[] args)
    {
        int bakalavr = 0;
        int magistr = 0;
        List<Student> list = new List<Student>();                             // Создаем список студентов
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("../../students_6.csv");
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                // Добавляем в список новый экземпляр класса Student
                list.Add(new Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7]), s[8]));
                // Одновременно подсчитываем количество бакалавров и магистров
                if (int.Parse(s[6]) < 5) bakalavr++; else magistr++;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                // Выход из Main
                if (Console.ReadKey().Key == ConsoleKey.Escape) return;
            }
        }
        sr.Close();
        //list.Sort(new Comparison<Student>(MyDelegat));
        Console.WriteLine("Всего студентов:" + list.Count);
        Console.WriteLine("Магистров:{0}", magistr);
        Console.WriteLine("Бакалавров:{0}", bakalavr);
        //foreach (var v in list) Console.WriteLine(v.firstName);

        #region Задание б)
        //Выполняем задание б) подсчитать сколько студентов в возрасте от 18 до 20 лет
        //на каком курсе учатся (*частотный массив);
        var studentCourse = CountCourse(list);
        Console.WriteLine("\n\nСтудентов в возрасте от 18 до 20 обучается:");
        for (int i = 0; i<studentCourse.Length; i++)
        {
            Console.WriteLine("На {0} курсе - {1} человек", i+1, studentCourse[i]);
        }
        #endregion

        #region Задание в)
        //отсортировать список по возрасту студента
        Console.WriteLine("\n\nСортируем список по возрасту студентов:");
        list.Sort(new Comparison<Student>(MyDelegatAge));
        foreach (var v in list) Console.WriteLine("Возраст: {0}; Имя: {1} {2}", v.age, v.firstName, v.lastName);
        #endregion

        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}
