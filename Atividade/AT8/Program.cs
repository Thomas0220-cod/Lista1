using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite uma nota:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite uma nota:");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite uma nota:");
            double n3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite uma nota:");
            double n4 = Convert.ToDouble(Console.ReadLine());
            double n5 = 4;
            Console.WriteLine("A média é de:" + (((n1 + n2 )+(n3 + n4))/ n5));
        }
    }
}
