using System;

namespace _52._32_URI_1164 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1164
             */

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                int X = int.Parse(Console.ReadLine());
                int soma = 0;
                for (int j = 1; j < X; j++) {
                    if (X % j == 0) {
                        soma += j;
                    }
                }
                if (soma == X) {
                    Console.WriteLine(X + " eh perfeito");
                }
                else {
                    Console.WriteLine(X + " nao eh perfeito");
                }
            }
        }
    }
}
