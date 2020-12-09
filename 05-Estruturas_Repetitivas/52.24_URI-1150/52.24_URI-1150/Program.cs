using System;

namespace _52._24_URI_1150 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1150
             */

            int X, Z, count, soma;

            X = int.Parse(Console.ReadLine());
            Z = int.Parse(Console.ReadLine());

            while (Z <= X) {
                Z = int.Parse(Console.ReadLine());
            }

            count = 1;
            soma = X;
            do {
                X += 1;
                soma += X;
                count += 1;
            } while (soma <= Z);

            Console.WriteLine(count);
        }
    }
}
