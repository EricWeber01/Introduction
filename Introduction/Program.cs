using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch(key.KeyChar)
            {
                case '1':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 1");
                        Console.WriteLine("Дано значение температуры T в градусах");
                        Console.WriteLine("Фаренгейта. Определить значение этой же температуры в градусах");
                        Console.WriteLine("Цельсия. Температура по Цельсию TC и температура по");
                        Console.WriteLine("Фаренгейту TF связаны следующим соотношением:");
                        Console.WriteLine("TC = (TF – 32)·5/9.");
                        Console.WriteLine("\n");
                        Console.Write("Введите температуру по Фаренгейту ==> ");
                        double f = Convert.ToDouble(Console.ReadLine());
                        double c = (f -32) * 5 / 9;
                        Console.WriteLine("Температура в градусах Цельсия равна ==> {0}", Math.Round(c));
                        Console.ReadKey();
                        break;
                    }
                case '2':
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("\t Задание 2");
                        Console.WriteLine("Даны координаты трех вершин треугольника:");
                        Console.WriteLine("(x1, y1), (x2, y2), (x3, y3). Найти его периметр и площадь, используя ");
                        Console.WriteLine("формулу для расстояния между двумя точками на плоскости: ");
                        Console.WriteLine("D = ");
                        Console.WriteLine("Для нахождения площади треугольника со сторонами a, b, c ");
                        Console.WriteLine("использовать формулу Герона: ");
                        Console.WriteLine("S = (p·(p – a)·(p – b)·(p – c))1/2,");
                        Console.WriteLine("где p = (a + b + c)/2 — полупериметр.");
                        Console.WriteLine("\n");
                        double x1, x2, x3, y1, y2, y3;
                        Console.WriteLine("Введите координаты x1 ==>");
                        
                        x1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите координаты y1 ==>");
                        y1 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите координаты x2 ==>");
                        x2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите координаты y2 ==>");
                        y2 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите координаты x3 ==>");
                        x3 = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите координаты y3 ==>");
                        y3 = Double.Parse(Console.ReadLine());
                        double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                        double b = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
                        double c = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
                        double p = (a + b + c) / 2;
                        double Area = p * (p - a) * (p - b) * (p - c);
                        Console.WriteLine("Площадь равна ==> {0}", Math.Round(Area));
                        Console.ReadKey();
                        break;
                    }
                case '3':
                    {

                        break;
                    }
            }
        }
    }
}