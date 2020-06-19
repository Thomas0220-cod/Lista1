using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT3
{
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Qual a sua altura");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o seu peso");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("O seu IMC é:"+ peso / (altura * altura ));
        }
    }
}
