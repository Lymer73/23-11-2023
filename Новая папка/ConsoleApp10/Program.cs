using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x= ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x < 3)
            //проверяем условие первой ветви
            {
                y = Math.Pow(x, 2) - 0.3;
            }
            else
            {
                if (x < 5)
                //проверяем условие второй ветви
                {
                    y = 0;
                }
                else
                {
                    y = Math.Pow(x, 2)+1;
                }
            }
            Console.WriteLine("y({0:f2})={1:f2}", x, y);
            Console.ReadKey();
        }
    }
}
