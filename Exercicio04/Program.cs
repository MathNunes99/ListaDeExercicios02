using System;
//Exercício 4:
//• Faça um algoritmo para receber um número qualquer e informar na tela se
//é par ou ímpar.

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X;

            Console.WriteLine("ESCREVA 1 NUMERO PARA SABER SE É PAR OU IMPAR");
            X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
            {
                Console.WriteLine("SEU NUMERO É PAR");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("SEU NUMERO É IMPAR");
                Console.ReadLine();
            }

            
        }
    }
}
