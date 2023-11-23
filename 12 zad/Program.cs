using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите признак фигуры: п – прямоугольник, т – треугольник, к - квадрат ");
            char n = char.Parse(Console.ReadLine());
            switch (n)
            {
                case 'п':
                    Console.WriteLine("Введите стороны прямоугольника: ");
                    Console.Write("a= ");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    double b = double.Parse(Console.ReadLine());
                    if (a > 0 && b > 0)
                    {
                        Console.WriteLine("p={0:f2} s={1:f2}", 2 * (a + b), a * b);
                    }
                    else
                    {
                        Console.WriteLine("Прямоугольник с заданными длинами сторон не существует");
                    }
                    break;
                case 'т':
                    Console.WriteLine("Введите стороны треугольника: ");
                    Console.Write("a= ");
                    double a1 = double.Parse(Console.ReadLine());
                    Console.Write("b= ");
                    double b1 = double.Parse(Console.ReadLine());
                    Console.Write("с= ");
                    double c = double.Parse(Console.ReadLine());
                    if (a1 + b1 > c && a1 + c > b1 && b1 + c > a1)
                    {
                        double p = a1 + b1 + c;
                        double p2 = p / 2;
                        double s = Math.Sqrt(p2 * (p2 - a1) * (p2 - b1) * (p2 - c));
                        Console.WriteLine("p={0:f2} s={1:f2}", p, s);
                    }
                    else
                    {
                        Console.WriteLine("Треугольник с заданными длинами сторон не существует");
                    }
                    break;
                case 'к':
                    Console.WriteLine("Введите сторону квадрата: ");
                    Console.Write("a= ");
                    double a2 = double.Parse(Console.ReadLine());
                    if (a2 > 0)
                    {
                        double p = a2 *4;
                        double s = Math.Pow(a2,2);
                        Console.WriteLine("p={0:f2} s={1:f2}", p, s);
                    }
                    else
                    {
                        Console.WriteLine("Квадрат с заданной длиной стороны не существует");
                    }
                    break;
                default:
                    Console.WriteLine("Вы неверно указали признак фигуры!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
