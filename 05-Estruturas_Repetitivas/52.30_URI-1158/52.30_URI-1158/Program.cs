using System;

namespace _52._30_URI_1158 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1158
             */

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {

                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]);
                int Y = int.Parse(vet[1]);

                int somaImpar = 0;
                int count = 0;
                for (int j = X; count < Y; j++) {
                    if (j % 2 != 0) {
                        somaImpar = somaImpar + j;
                        count = count + 1;
                    }
                }
                Console.WriteLine(somaImpar);
            }
        }
    }
}
