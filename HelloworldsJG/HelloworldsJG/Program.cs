using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloworldsJG
{
    class Program
    {
        static void Main(string[] args)
        {

            string NomePessoa;
            string IdadePessoa;

            Console.WriteLine("Qual o teu nome?");
            NomePessoa = Console.ReadLine();

            Console.WriteLine("Qual é a tua idade?");
            IdadePessoa = Console.ReadLine();

            Console.WriteLine("O " + NomePessoa.ToUpper() + " É GAY E TEM " + IdadePessoa + " ANOS.");

            Console.ReadKey();
        }
    }
}
