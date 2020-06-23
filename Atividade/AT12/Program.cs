using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AT12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Em qual ano você nasceu?");
            double AN = Convert.ToDouble(Console.ReadLine());
            /*Console.WriteLine(" Que ano é?");
            double ANT = Convert.ToDouble(Console.ReadLine());*/

            Console.WriteLine("Sua idade:" + (2020 - AN));
        }
    }
}
