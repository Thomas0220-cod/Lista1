using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT11
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número:");
            double N1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            double N2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Primeiro número digitado:" + N2);
            Console.WriteLine("Segundo número digitado:" + N1);
        }
    }
}
