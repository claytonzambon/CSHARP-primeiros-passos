using System;

namespace _52._19_URI_1143 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1143
             */

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                int produto = 1;
                Console.Write((produto *= i) + " ");
                Console.Write((produto *= i) + " ");
                Console.WriteLine(produto *= i);
            }
        }
    }
}
