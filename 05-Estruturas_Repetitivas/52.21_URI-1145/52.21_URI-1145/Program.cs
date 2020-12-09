using System;

namespace _52._21_URI_1145 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1145
             */

            string[] vet = Console.ReadLine().Split(' ');
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            for (int i = 1; i <= Y; i++) {
                Console.Write(i);
                if (i % X == 0) {
                    Console.WriteLine();
                }
                else {
                    Console.Write(" ");
                }
            }
        }
    }
}
