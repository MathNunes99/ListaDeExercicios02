using System;

//Exercício 5:
//• Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem
//iguais deverá se somar os dois, caso contrário multiplique A por B.
//Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
//variável C e mostrar seu conteúdo na tela.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int A, B, C;

            Console.WriteLine("ESCREVA O VALOR 'A'");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("ESCREVA O VALOR 'B'");
            B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                C = A + B;
                Console.WriteLine("A E B SAO IGUAIS, VALORES SOMADOS SÃO: " + C);
                Console.ReadLine();
            }
            else
            {
                C = A * B;
                Console.WriteLine("A E B SAO DIFERENTES, VALORES MULTIPLICADOS SÃO: " + C);
                Console.ReadLine();
            }
                



        }
    }
}
