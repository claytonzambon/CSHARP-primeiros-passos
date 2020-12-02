using System;

namespace _45._8_URI_1159 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1159
             */

            int x, soma;

            x = int.Parse(Console.ReadLine());
            while (x != 0) {
                if (x % 2 != 0) {
                    x = x + 1;
                }
                soma = x + x + 2 + x + 4 + x + 6 + x + 8;
                Console.WriteLine(soma);
                x = int.Parse(Console.ReadLine());
            }
        }
    }
}
