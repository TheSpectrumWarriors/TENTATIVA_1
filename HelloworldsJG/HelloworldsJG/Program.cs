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
            //assim funciona como um tutorial para nós!
            #region NomesDosUtilizadores
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
            Console.WriteLine();
            #endregion

            #region CondiçoesDoNome
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
            #endregion
            #endregion

            #region PassagemDosAdotados

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Agora que sabemos o teu nome, vamos fazer operações matemáticas! seu adotado!");
            Console.WriteLine("Enter para Continuar");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Calculadora 
            //Calculadora
            #region VariaveisDaCalculadora

            double numero1;
            double numero2;
            double Total;
            String operação;
            #endregion

            Console.Write("Introduza o primeiro valor: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Introduza a operação: ");
            operação = Console.ReadLine();

            Console.Write("Introduza o segundo valor: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            Total = 0;


            switch(operação)
            {
               case "+" : Total = numero1 + numero2;
                    Console.WriteLine("A soma é" + Total);
                    break;
               case "-" : Total = numero1 - numero2;
                    Console.WriteLine("A Divisao é" + Total);
                    break;
               case "*" : Total = numero1 * numero2;
                    Console.WriteLine("A multiplicação é" + Total);
                    break;
                case "/": Total = numero1 / numero2;
                    Console.WriteLine("A divisão é" + Total);
                    break; 



            }


            Console.WriteLine();

            #endregion

            #region  array! e for

            // Array
             
            String[] lista;

            lista = new string[3];

            lista[0] = "Joao";
            lista[1] = "Tiago";
            lista[2] = "Rodrigo";

            for (int i = 0 ; i<3; i++)
            {

                Console.Write(lista[i] + " ");



            }




            #endregion







            Console.ReadKey();
        }
    }
}
