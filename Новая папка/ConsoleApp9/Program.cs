using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x < 0)
            //проверяем условие первой ветви
            {
                y = Math.Pow(Math.Pow(x, 3) + 1, 2);
            }
            else
            {
                if (x < 1)
                //проверяем условие второй ветви
                {
                    y = 0;
                }
                else
                {
                    y = Math.Abs(x * x - 5 * x + 1);
                }
            }
            Console.WriteLine("y({0:f2})={1:f2}", x, y);
            Console.ReadKey();
        }
    }
}
