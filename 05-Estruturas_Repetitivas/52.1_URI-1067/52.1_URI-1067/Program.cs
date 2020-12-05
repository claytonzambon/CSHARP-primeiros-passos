using System;

namespace _52._1_URI_1067 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1067
             */

            int X;

            X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
