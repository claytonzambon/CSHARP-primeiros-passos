using System;

namespace _62._2._URI_1173 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI 1173
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1173
             */

            int N = int.Parse(Console.ReadLine());

            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++) {
                vetor[i] = N;
                N *= 2;
            }

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("N[" + i + "] = " + vetor[i]);
            }
        }
    }
}
