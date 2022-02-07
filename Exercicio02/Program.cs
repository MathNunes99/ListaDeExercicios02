using System;

//Exercício 2:
//• Escreva um algoritmo que leia três valores inteiros e diferentes e
//mostre-os em ordem decrescente.
namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;

            Console.WriteLine("EXERCICIO 02");

            Console.WriteLine("ESCREVA O VALOR A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCREVA O VALOR B");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCREVA O VALOR C");
            C = int.Parse(Console.ReadLine());

            Console.WriteLine("a ordem decrescente é: ");

            if (A > B && A > C && B > C)
            {
                Console.WriteLine(A + " " + B + " " + C);
                Console.ReadLine();
            }
            else if (A > B && B > C)
            {
                Console.WriteLine(A + " " + C + " " + B);
                Console.ReadLine();
            }
            else if (A < B && A > C)
            {
                Console.WriteLine(B + " " + A + " " + C);
                Console.ReadLine();
            }
            else if (B > C && A < C)
            {
                Console.WriteLine(B + " " + C + " " + A);
                Console.ReadLine();
            }
            else if (C > B && B < A)
            {
                Console.WriteLine(C + " " + A + " " + B);
                Console.ReadLine();
            }
            else if (C > B && A < B)
            {
                Console.WriteLine(C + " " + B + " " + A);
                Console.ReadLine();
            }

        }
    }
}
