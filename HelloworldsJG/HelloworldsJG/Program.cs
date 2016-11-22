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
            //assim funcioanva como um tutorial para nos!
            #region Variaveis
            string NomePessoa;
            string IdadePessoa;
            #endregion

            #region Questões
            Console.Write("Qual o teu nome: ");
            NomePessoa = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Qual é a tua idade: ");
            IdadePessoa = Console.ReadLine();
            #endregion
            Console.WriteLine();

            // If-Else
            if (NomePessoa == "Quico")
            {
                Console.WriteLine("O QUICO É FIXE E TEM " + IdadePessoa + " ANOS.");
            }

            else if (NomePessoa == "MaKuiLoP")
            {

                Console.WriteLine("O joão é topo, alem de Diamond é topo, e tem " + IdadePessoa + " ANOS");
            }



            else
            {
                Console.WriteLine("O " + NomePessoa.ToUpper() + " É GAY E TEM " + IdadePessoa + " ANOS.");
            }

            Console.ReadKey();
        }
    }
}
