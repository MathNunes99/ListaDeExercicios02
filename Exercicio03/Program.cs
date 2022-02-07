using System;

//Exercício 3:
//• O IMC – Índice de Massa Corporal é um critério da Organização Mundial
//de Saúde para dar uma indicação sobre a condição de peso de uma pessoa
//adulta

//• A fórmula é IMC = peso / (altura) ²

//• Elabore um algoritmo que leia o peso e a altura de um adulto e mostre
//sua condição de acordo com a tabela abaixo.

//IMC em adultos Condição
//Abaixo de 18,5 Abaixo do peso
//Entre 18,5 e 25 Peso normal
//Entre 25 e 30 Acima do peso
//Acima de 30 obeso


namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double peso, altura, IMC;
            

            Console.WriteLine("ESCREVA O SEU PESO");
            peso = double.Parse(Console.ReadLine());
            Console.WriteLine("ESCREVA O SEU ALTURA");
            altura = double.Parse(Console.ReadLine());


            IMC = peso / Math.Pow(altura, 2);
            

            if (IMC < 18.5)
            {
                Console.WriteLine("Voce está ABAIXO DO PESO " + IMC);
                Console.ReadLine();
            }
            else if (IMC >= 18.5 && IMC < 25)
            {
                Console.WriteLine("VOCE ESTA NO SEU PESO NORMAL " + IMC);
                Console.ReadLine();
            }
            else if (IMC >= 25 && IMC < 30)
            {
                Console.WriteLine("VOCE ESTA ACIMA DO PESO " + IMC);
                Console.ReadLine();
            }
            else if (IMC >= 30) 
            {
                Console.WriteLine("VOCE ESTA OBES O" + IMC);
                Console.ReadLine();
            }


        }
    }
}
