using System;

namespace _52._13_URI_1099 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1099
             */

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]);
                int Y = int.Parse(vet[1]);
                
                if (X > Y) {
                    int aux = X;
                    X = Y;
                    Y = aux;
                }

                int soma = 0;
                for (int j = X + 1; j < Y; j++) {
                    if (j % 2 != 0) {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
