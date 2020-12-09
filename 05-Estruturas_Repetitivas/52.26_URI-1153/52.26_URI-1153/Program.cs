using System;

namespace _52._26_URI_1153 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1153
             */

            int N = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= N; i++) {
                fatorial = fatorial * i;
            }
            Console.WriteLine(fatorial);
        }
    }
}
