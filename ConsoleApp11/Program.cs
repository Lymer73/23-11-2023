﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("y= ");
            double y = double.Parse(Console.ReadLine());
            const int r = 10;
            if (x * x + y * y < r * r)
            {
                Console.WriteLine("да");
            }
            else
            {
                if (x * x + y * y > r * r)
                {
                    Console.WriteLine("нет");
                }
                else
                {
                    Console.WriteLine("на границе");
                }
            }
            Console.ReadKey();    
        }
    }
}
