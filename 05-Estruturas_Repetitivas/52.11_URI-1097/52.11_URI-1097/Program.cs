using System;

namespace _52._11_URI_1097 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1097
             */

            for (int i = 1; i <= 9; i += 2) {
                for (int j = i + 6; j >= i + 4; j--) {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
            }
        }
    }
}
