using System;

namespace _52._23_URI_1149 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1149
             */

            int A, N, count, soma;

            string[] vet = Console.ReadLine().Split(' ');
            A = int.Parse(vet[0]);

            count = 1;
            N = int.Parse(vet[count]);
            while (N <= 0) {
                count += 1;
                N = int.Parse(vet[count]);
            }

            soma = 0;
            for (int i = 0; i < N; i++) {
                soma += A + i;
            }
            Console.WriteLine(soma);
        }
    }
}
