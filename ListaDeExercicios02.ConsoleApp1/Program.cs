using System;

//Exercício 1:
//• Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
//soma de A + B é menor que C.

namespace ListaDeExercicios02.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, result;

            Console.WriteLine("EXERCICIO 01");

            Console.WriteLine("ESCREVA O VALOR A");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine("ESCREVA O VALOR B");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("ESCREVA O VALOR C");
            C = double.Parse(Console.ReadLine());

            result = A + B;
            if (result > C)
                Console.WriteLine("SOMA DE A+B É MAIOR QUE C : " + result);
            else
                Console.WriteLine("A SOMA DE A+B É MENOR QUE C");

            Console.ReadLine();
            



        }
    }
}
