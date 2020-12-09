using System;

namespace _52._22_URI_1146 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1146
             */
            int X;

            do {
                X = int.Parse(Console.ReadLine());

                for (int i = 1; i <= X; i++) {
                    Console.Write(i);
                    if (i % X == 0) {
                        Console.WriteLine();
                    }
                    else {
                        Console.Write(" ");
                    }
                }

            } while (X != 0);
        }
    }
}
