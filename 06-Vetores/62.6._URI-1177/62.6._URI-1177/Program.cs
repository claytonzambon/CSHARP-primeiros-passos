using System;

namespace _62._6._URI_1177 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI-1177
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1177
             */

            int T = int.Parse(Console.ReadLine());

            int[] N = new int[1000];

            for (int i = 0; i < 1000; i++) {
                for (int j = 0; j < T; j++) {
                    N[i] = j;
                    i++;
                    if (i == 1000) {
                        break;
                    }
                }
                i--;
            }

            //Exibir valores do vetor
            for (int i = 0; i < 1000; i++) {
                Console.WriteLine("N[" + i + "] = " + N[i]);
            }
        }
    }
}
