using System;

namespace _38._21_Exercicio_URI_1070 {
    class Program {
        static void Main(string[] args) {
            /* Exercicios URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1070
             */

            int X;

            X = int.Parse(Console.ReadLine());

            if (X % 2 == 0)
                X = X + 1;

            Console.WriteLine(X);
            Console.WriteLine(X = X + 2);
            Console.WriteLine(X = X + 2);
            Console.WriteLine(X = X + 2);
            Console.WriteLine(X = X + 2);
            Console.WriteLine(X = X + 2);
        }
    }
}
