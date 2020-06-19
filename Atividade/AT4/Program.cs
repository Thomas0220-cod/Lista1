using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Infome um valor");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Infome um valor");
            double n2 = Convert.ToDouble(Console.ReadLine());
         

            Console.WriteLine("A soma dos valores sâo:" + (n1 + n2));
            Console.WriteLine();
            Console.WriteLine("A subrtracâo dos valores sâo:" + (n1 - n2));
            Console.WriteLine();
            Console.WriteLine("A multiplicaçâo dos valores sâo:" +(n1 * n2));
            Console.WriteLine();
            Console.WriteLine("A divisâo dos valores sâo:"+ (n1 / n2));

        }
    }
}
