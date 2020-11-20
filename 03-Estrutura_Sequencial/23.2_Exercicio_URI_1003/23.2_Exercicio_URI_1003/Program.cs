using System;

namespace _23._2_Exercicio_URI_1003
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1003
             */

            int A, B, SOMA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            SOMA = A + B;
                       
            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
