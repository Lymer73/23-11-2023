using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b= ");
            int b = int.Parse(Console.ReadLine());
            int i;
            Console.Write("FOR: ");
            a = (a % 2 == 0) ? a : a + 1;
            for (i = a; i <= b; i += 2)
            {
                Console.Write(" {0}", i * i);
            }
            Console.Write("\nWHILE: ");
            i = a;
            while (i <= b)
            {
                Console.Write(" {0}", i * i);
                i += 2;
            }
            Console.Write("\nDO: ");
            i = a;
            do
            {
                Console.Write(" {0}", i * i);
                i += 2;
            }
            while (i <= b);
            Console.ReadKey();  
        }
    }
}
