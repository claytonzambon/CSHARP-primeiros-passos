using System;

namespace _52._25_URI_1151 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1151
             */

            int N = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < N; i++) {
                if (i == N - 1) {
                    Console.WriteLine(a);
                }
                else {
                    Console.Write(a + " ");
                }
                int aux = b;
                b = a;
                a = aux + b;
            }
        }
    }
}
