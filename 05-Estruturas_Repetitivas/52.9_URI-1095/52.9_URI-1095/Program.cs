using System;

namespace _52._9_URI_1095 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1095
             */

            int i = 1;
            int j = 60;

            while (j >= 0) {
                Console.WriteLine("I=" + i + " J=" + j);
                i += 3;
                j -= 5;
            }
        }
    }
}
