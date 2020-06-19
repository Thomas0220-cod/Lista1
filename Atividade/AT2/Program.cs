using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AT2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("digite um nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite um sobrenome");
            string sobrenome = Console.ReadLine();


            Console.WriteLine("Seu nome completo é:"+ nome +" "+ sobrenome);

        }
    }
}
