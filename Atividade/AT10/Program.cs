using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o  valor da conta de luz:");
            double CL = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da conta da água:");
            double CA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da NET:");
            double NET = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da Vivo:");
            double VVI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da Oi:");
            double VOI = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do IPTU :");
            double VIT = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do IPVA :");
            double VIP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do seguro do carro :");
            double VSC = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do seguro do Jet Ski:");
            double VSJ = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do seguro do Avião:");
            double VSA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do seguro do Iate :");
            double VSI = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Valor das contas de telefone:" + (NET + VVI + VOI));
            Console.WriteLine();
            Console.WriteLine("Valor dos impostos:" + (VIT + VIP));
            Console.WriteLine();
            Console.WriteLine("Valor dos seguros:" + (VSC + VSJ + (VSA + VSI)));
            Console.WriteLine();
            Console.WriteLine("Vallor dos restantes das contas:" + (CL +CA));
            Console.WriteLine();
            Console.WriteLine("Valor total de todas as contas:" + ((CL + CA) + (VSC + VSJ + (VSA + VSI) + (VIT + VIP) + (NET + VVI + VOI))));
        }
    }
}
