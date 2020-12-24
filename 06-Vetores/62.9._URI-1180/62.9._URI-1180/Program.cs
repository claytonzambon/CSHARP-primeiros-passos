using System;

namespace _62._9._URI_1180 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI - 1180
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1180
             */

            int N = int.Parse(Console.ReadLine());

            int[] X = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                X[i] = int.Parse(s[i]);
            }

            int menor = X[0];
            int posicao = 0;
            for (int i = 0; i < N; i++) {
                if (menor > X[i]) {
                    menor = X[i];
                    posicao = i;
                }
            }

            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + posicao);
        }
    }
}
