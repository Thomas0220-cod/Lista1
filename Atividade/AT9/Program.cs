using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do carro:");
            double NC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do carro:");
            double VC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de cada parcela:");
            double VCP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a quantide de parcelas:");
            double QP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a valor total do financiamento:");
            double VTF = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a :");
            double DVF = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Nome do carro:" + NC);
            Console.WriteLine("Valor do carro:" + VC);
            Console.WriteLine("Valor de cada parcela:" + VCP);
            Console.WriteLine("Quantidade de pacelas:" + QP);
            Console.WriteLine("Valor total do financiamento:" + VTF);
            Console.WriteLine("Diferença entre o valor total do financiamento e valor do carro:"+ (NC - VTF));
        }
    }
}
