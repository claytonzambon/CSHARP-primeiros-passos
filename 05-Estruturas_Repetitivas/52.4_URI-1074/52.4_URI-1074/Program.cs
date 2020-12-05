using System;

namespace _52._4_URI_1074 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1074
             */

            int N, X;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {

                X = int.Parse(Console.ReadLine());

                if (X % 2 == 0) {
                    if (X > 0) {
                        Console.WriteLine("EVEN POSITIVE");
                    }
                    else if (X < 0){
                        Console.WriteLine("EVEN NEGATIVE");
                    }
                    else {
                        Console.WriteLine("NULL");
                    }
                }
                else {
                    if (X > 0) {
                        Console.WriteLine("ODD POSITIVE");
                    }
                    else {
                        Console.WriteLine("ODD NEGATIVE");
                    }
                }
            }
        }
    }
}
