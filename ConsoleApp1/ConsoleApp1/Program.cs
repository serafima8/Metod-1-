using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Задача 1

        // 1.Вызов пустого метода Func без возвращения значений для вычисления функции y = x2.
        //static void Func()
        //{
        //    Console.Write("x = ");
        //    double x = double.Parse(Console.ReadLine());
        //    double y = Math.Pow(x, 2);
        //    Console.WriteLine($"y = {y}");
        //}
        //static void Main(string[] args)
        //{
        //    Func();
        //    Console.ReadKey();
        //}


        //2. Преобразуйте программу так, чтобы метод Func вызывался n раз.
        //static void Func()
        //{
        //    Console.Write("x = ");
        //    double x = double.Parse(Console.ReadLine());
        //    double y = Math.Pow(x, 2);
        //    Console.WriteLine($"y = {y}");
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("Введите n: ");
        //    int n = Convert.ToInt32(Console.ReadLine());
        //    for (double i = 0; i <= n; i++)
        //    {
        //        Func();
        //    }
        //    Console.ReadKey();
        //}


        // 3. Преобразуйте программу так, чтобы метод Func вычислял значение выражения.
        //static void Func()
        //{
        //    Console.Write("x = ");
        //    double x = double.Parse(Console.ReadLine());
        //    double y = (3*Math.Pow(x, 2)+8*x-10)/15;
        //    Console.WriteLine($"y = {y}");
        //}
        //static void Main(string[] args)
        //{
        //       Func();
        //    Console.ReadKey();
        //}


        // Задача 2. Нахождение суммы двух чисел с использованием метода сложения двух чисел.
        ////public static int Add(int x, int y)
        ////{
        ////    int sum = x + y;
        ////    x = 100;
        ////    y = 500;
        ////    return sum;
        ////}
        ////static void Main(string[] args)
        ////{
        ////    Console.Write("Введите x: ");
        ////    int x = Convert.ToInt32(Console.ReadLine());
        ////    Console.Write("Введите y: ");
        ////    int y = Convert.ToInt32(Console.ReadLine());
        ////    Add(x, y);
        ////    int Z = Add(x, y);
        ////    Console.Write($"Сумма двух чисел = {Z}");
        ////    Console.ReadKey();
        ////}



        //Задача 4. Составьте таблицу значений функции y = 5x² - 2x +1 на отрезке[-5; 5] с шагом h = 2 с использованием дополнительного метода.
        //static void Func()
        //{
        //    for (int x = -5; x <= 5; x += 2)
        //    {
        //        Console.WriteLine($"x = {x}\t y = {5 * Math.Pow(x, 2) - 2 * x + 1}");
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    Func();
        //    Console.ReadKey();
        //}



        // Задача 5. Напишите дополнительный метод для вычисления функции
        // public static double calculation(double x,double y)
        //{

        //    if (x < 5)
        //    {
        //        y = (4 * Math.Pow(x, 2) + 1) / (x - 5);
        //    }
        //    else if (x >= 5)
        //    {
        //        y = 3 * Math.Pow(x, 2) - 2;
        //    }
        //  return y;
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("x = ");
        //    double x = Convert.ToDouble(Console.ReadLine());
        //    double y = 0;
        //    double Z = calculation( x, y);
        //    Console.Write($"y = {Z}");
        //    Console.ReadKey();
        //}


        //Задача 6. Создайте приложение, которое выводит сумму, вычитание, умножение и деление двух параметров входных данных.
        //public static int Add(int x, int y)
        //{
        //    return x + y;
        //}
        //public static int Dif(int x, int y)
        //{
        //    return x - y;
        //}
        //public static int Mult(int x, int y)
        //{
        //    return x * y;
        //}
        //public static double Div(int x, int y)
        //{
        //    return(double) x / y;
        //}
        //static void Main(string[] args)
        //{
        //    Console.Write("x = ");
        //    int x = int.Parse(Console.ReadLine());
        //    Console.Write("y = ");
        //    int y = int.Parse(Console.ReadLine());
        //    int sum = Add(x, y);
        //    Console.WriteLine($"Сумма = {sum}");
        //    int razn = Dif(x, y);
        //    Console.WriteLine($"Разность = {razn}");
        //    int proizv = Mult(x, y);
        //    Console.WriteLine($"Произведение = {proizv}");
        //    double del = Div(x, y);
        //    Console.WriteLine($"Деление = {del}");
        //    Console.ReadKey();
        //}


    }
}
