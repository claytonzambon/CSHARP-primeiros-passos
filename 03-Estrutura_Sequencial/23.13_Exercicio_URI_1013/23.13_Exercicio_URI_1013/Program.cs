using System;

namespace _23._13_Exercicio_URI_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1013
             */

            int A, B, C, maiorAB, maior;
            string[] vetor = Console.ReadLine().Split(' ');
            A = int.Parse(vetor[0]);
            B = int.Parse(vetor[1]);
            C = int.Parse(vetor[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;
            maior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(maior + " eh o maior");
        }
    }
}
