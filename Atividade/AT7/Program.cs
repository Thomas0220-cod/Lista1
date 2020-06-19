using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT7
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 1 a 10:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(n1 + "X" + 1 + "="+(n1 * 1));
            Console.WriteLine(n1 + "X" + 2 + "=" + (n1 * 2));
            Console.WriteLine(n1 + "X" + 3 + "=" + (n1 * 3));
            Console.WriteLine(n1 + "X" + 4 + "=" + (n1 * 4));
            Console.WriteLine(n1 + "X" + 5 + "=" + (n1 * 5));
            Console.WriteLine(n1 + "X" + 6 + "=" + (n1 * 6));
            Console.WriteLine(n1 + "X" + 7 + "=" + (n1 * 7));
            Console.WriteLine(n1 + "X" + 8 + "=" + (n1 * 8));
            Console.WriteLine(n1 + "X" + 9 + "=" + (n1 * 9));
            Console.WriteLine(n1 + "X" + 10 + "=" + (n1 * 10));
        }
    }
}
