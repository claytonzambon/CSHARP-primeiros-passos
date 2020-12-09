using System;

namespace _52._33_URI_1165 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1165
             */

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                int X = int.Parse(Console.ReadLine());
                int count = 0;
                for (int j = 1; j <= X; j++) {
                    if (X % j == 0) {
                        count++;
                    }
                }
                if (count == 2) {
                    Console.WriteLine(X + " eh primo");
                }
                else {
                    Console.WriteLine(X + " nao eh primo");
                }
            }
        }
    }
}
