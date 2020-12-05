using System;

namespace _52._5_URI_1075 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1075
             */

            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++) {
                if (i % N == 2) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
