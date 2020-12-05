using System;

namespace _52._2_URI_1072 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1072
             */

            int N, X, countIn, countOut;

            N = int.Parse(Console.ReadLine());

            countIn = 0;
            countOut = 0;
            for (int i = 0; i < N; i++) {
                X = int.Parse(Console.ReadLine());
                if (X >= 10 && X <= 20)
                    countIn++;
                else
                    countOut++;
            }
            Console.WriteLine(countIn + " in");
            Console.WriteLine(countOut + " out");
        }
    }
}
