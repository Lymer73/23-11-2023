using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h= ");
            double h = double.Parse(Console.ReadLine());
            double y;
            int i = 1;
            Console.WriteLine("{0,3} {1,5} {1,5}", "#", "x", "f(x)");
            for (double x = a; x <= b; x += h, ++i)
            {
                if (x < 0)
                {
                    y = 0;
                }
                else
                {
                    if (x >= 1 && x!=1 )
                    {
                        y = x*x +1;
                    }
                    else
                    {
                        y = 1;
                    }
                }
                Console.WriteLine("{0,3} {1,5:f2} {2,5:f2}", i, x, y);
            }
            Console.ReadKey();
        }
    }
}
