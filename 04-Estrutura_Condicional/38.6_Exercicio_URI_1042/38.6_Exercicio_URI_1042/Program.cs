using System;

namespace _38._6_Exercicio_URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercícios URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1042
             */

            int menor, meio, maior;

            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);
            int z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                menor = x;
                if (y < z)
                {
                    meio = y;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = y;
                }
            }
            else if (y < z)
            {
                menor = y;
                if (x < z)
                {
                    meio = x;
                    maior = z;
                }
                else
                {
                    meio = z;
                    maior = x;
                }
            }
            else
            {
                menor = z;
                if (x < y)
                {
                    meio = x;
                    maior = y;
                }
                else
                {
                    meio = y;
                    maior = x;
                }
            }
            Console.WriteLine(menor);
            Console.WriteLine(meio);
            Console.WriteLine(maior);
            Console.WriteLine();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
