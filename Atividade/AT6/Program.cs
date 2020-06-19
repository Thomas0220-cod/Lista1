using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de litros de água por dia?");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual a quantidade de anos consumidos?");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Qual o valor pago por litro?");
            double n3 = Convert.ToDouble(Console.ReadLine());
            double n4 = 365;
            Console.WriteLine("Quantidade de litros consumidos:" +  (n1 *(n2 * n4)));
            Console.WriteLine("O valor total é:"+ (n3*(n1*(n2 * n4))));

        }
    }
}
