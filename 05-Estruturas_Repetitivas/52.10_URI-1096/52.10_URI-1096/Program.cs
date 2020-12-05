using System;

namespace _52._10_URI_1096 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1096
             */

            for (int i = 1; i <= 9; i+=2) {
                for (int j = 7; j >= 5; j--) {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
        }
    }
}
