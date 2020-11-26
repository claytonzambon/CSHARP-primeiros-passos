using System;

namespace _38._8_Exercicio_URI_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1044
             */

            int a, b;

            string[] vet = Console.ReadLine().Split(' ');
            a = int.Parse(vet[0]);
            b = int.Parse(vet[1]);

            if (a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
