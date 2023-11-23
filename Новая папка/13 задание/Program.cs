using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            byte n = byte.Parse(Console.ReadLine());
            for (byte i = 1; i <= n; ++i)
            {
                for (byte j = 1; j <= i; ++j)
                {
                    Console.Write("{0,4}", i);
                }
                Console.WriteLine();
                for (byte j = 1; j <= i; ++j)
                {
                    Console.Write("{0,4}", i + 2);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
