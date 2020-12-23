using System;

namespace _62._5._URI_1176 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI-1176
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1176
             */

            int T = int.Parse(Console.ReadLine());

            Int64[] vetFibo = new Int64[T];

            for (int i = 0; i < T; i++) {
                int a = 0;
                int b = 1;
                int N = int.Parse(Console.ReadLine());
                for (int j = 0; j < N; j++) {
                    int aux = b;
                    b = a;
                    a = aux + b;
                }
                vetFibo[i] = a;
                Console.WriteLine("Fib(" + N + ") = " + vetFibo[i]);
            }
        }
    }
}
