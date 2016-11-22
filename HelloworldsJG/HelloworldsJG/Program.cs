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
            //Bora tentar criar um programa aos poucos e poucos em que se use todos os comandos que aprendemos
            //assim funcionava como um tutorial para nos!
            string NomePessoa;
            string IdadePessoa;

            Console.WriteLine("Qual o teu nome?");
            NomePessoa = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Qual é a tua idade?");
            IdadePessoa = Console.ReadLine();
            Console.WriteLine();

            if (NomePessoa == "Quico")
            {
                Console.WriteLine("O QUICO É FIXE E TEM " + IdadePessoa + " ANOS.");
            }
            else
            {
                Console.WriteLine("O " + NomePessoa.ToUpper() + " É GAY E TEM " + IdadePessoa + " ANOS.");
            }

            Console.ReadKey();
        }
    }
}
