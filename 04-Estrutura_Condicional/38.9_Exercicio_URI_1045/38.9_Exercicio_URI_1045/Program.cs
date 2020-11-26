using System;
using System.Globalization;

namespace _38._9_Exercicio_URI_1045
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1045
             */

            double a, b, c, maior, meio, menor;

            string[] vet = Console.ReadLine().Split(' ');
            a = double.Parse(vet[0]);
            b = double.Parse(vet[1]);
            c = double.Parse(vet[2]);

            if (a > b && a > c)
            {
                maior = a;
                if (b > c)
                {
                    meio = b;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = b;
                }
            }
            else if (b > c)
            {
                maior = b;
                if (a > c)
                {
                    meio = a;
                    menor = c;
                }
                else
                {
                    meio = c;
                    menor = a;
                }
            }
            else
            {
                maior = c;
                if (a > b)
                {
                    meio = a;
                    menor = b;
                }
                else
                {
                    meio = b;
                    menor = a;
                }
            }

            if (maior >= (meio + menor))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (Math.Pow(maior, 2.0) == (Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0)))
                    Console.WriteLine("TRIANGULO RETANGULO");

                else if (Math.Pow(maior, 2.0) > (Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0)))
                    Console.WriteLine("TRIANGULO OBTUSANGULO");

                else if (Math.Pow(maior, 2.0) < (Math.Pow(meio, 2.0) + Math.Pow(menor, 2.0)))
                    Console.WriteLine("TRIANGULO ACUTANGULO");

                if (maior == meio && meio == menor)
                    Console.WriteLine("TRIANGULO EQUILATERO");

                else if (maior == meio || maior == menor || meio == menor)
                    Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
