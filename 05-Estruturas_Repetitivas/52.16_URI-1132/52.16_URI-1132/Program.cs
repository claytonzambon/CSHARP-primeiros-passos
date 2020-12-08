using System;

namespace _52._16_URI_1132 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1132
             */

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X > Y) {
                int aux = X;
                X = Y;
                Y = aux;
            }

            int soma = 0;
            for (int i = X; i <= Y; i++) {
                if (i % 13 != 0) {
                    soma += i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
