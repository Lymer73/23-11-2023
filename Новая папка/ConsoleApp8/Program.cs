using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            if (x==1 || 1-4*x==0)
            {
                Console.WriteLine("Функция не определена");
            }
            else
            {
                double y = (1 / (x-1)) + (2 / (1 - 4 *x));
                Console.WriteLine("y({0:f2})={1:f2}", x, y);

            }
            Console.ReadKey();

        }
    }
}
