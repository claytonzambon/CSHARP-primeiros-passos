using System;

namespace _52._17_URI_1133 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1133
             */

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X > Y) {
                int aux = X;
                X = Y;
                Y = aux;
            }

            for (int i = X + 1; i < Y; i++) {
                if (i % 5 == 2 || i % 5 == 3) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
