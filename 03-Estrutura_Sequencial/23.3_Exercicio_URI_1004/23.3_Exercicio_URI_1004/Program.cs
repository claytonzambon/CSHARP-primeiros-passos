using System;

namespace _23._3_Exercicio_URI_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1004
             */

            int A, B, PROD;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            PROD = A * B;
            
            Console.WriteLine("PROD = " + PROD);
        }
    }
}