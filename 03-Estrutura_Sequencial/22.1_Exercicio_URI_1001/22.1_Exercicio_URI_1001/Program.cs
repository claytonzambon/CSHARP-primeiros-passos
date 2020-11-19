using System;

namespace _22._1_Exercicio_URI_1001
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1001
             */

            int A, B, X;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            X = A + B;
            
            Console.WriteLine("X = " + X);
        }
    }
}
