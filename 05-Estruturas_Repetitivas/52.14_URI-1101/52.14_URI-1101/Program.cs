using System;

namespace _52._14_URI_1101 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1101
             */

            string[] vet = Console.ReadLine().Split(' ');
            int N = int.Parse(vet[0]);
            int M = int.Parse(vet[1]);

            while (N > 0 && M > 0) {
                
                if (N < M) {
                    int aux = N;
                    N = M;
                    M = aux;
                }
                int soma = 0;
                for (int i = M; i <= N; i++) {
                    soma += i;
                    Console.Write(i + " ");
                }
                Console.WriteLine("Sum=" + soma);
                vet = Console.ReadLine().Split(' ');
                N = int.Parse(vet[0]);
                M = int.Parse(vet[1]);
            }
        }
    }
}
