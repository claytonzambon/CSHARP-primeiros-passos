using System;

namespace _49._1_URI_1078 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1078
             */

            int N, produto;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                produto = i * N;
                Console.WriteLine(i + " x " + N + " = " + produto);
            }
        }
    }
}
