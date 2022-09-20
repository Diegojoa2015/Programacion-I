using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            float b, c;
            a = 10;
            b = (float)30.5;
            c = (float)(a + b);
            Console.WriteLine("{0}+{1}={2}", a, b, c);
            Console.ReadKey();
        }
    }
}
