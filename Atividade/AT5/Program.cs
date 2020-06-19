using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT5
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Infome um valor");
            double n1 = Convert.ToDouble(Console.ReadLine());
            int n2 = 1;

            Console.WriteLine("O antercessor é:" + (n1 - n2));
            Console.WriteLine();
            Console.WriteLine("O sucessor é:" + (n1 + n2));
            Console.WriteLine();
        }
    }
}
