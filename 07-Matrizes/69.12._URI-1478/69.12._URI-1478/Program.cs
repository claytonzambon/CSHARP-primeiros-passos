using System;

namespace _69._12._URI_1478 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI - 1478
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1478
             */

            //Declarar variável inteira N
            int N;

            do {
                //Ler valor digitado pelo usuario
                N = int.Parse(Console.ReadLine());

                //Declarar matriz quadrada de tamanho N x N
                int[,] M = new int[N, N];

                //Popular a matriz
                for (int linha = 0; linha < N; linha++) {
                    for (int coluna = 0; coluna < N; coluna++) {
                        if (linha == coluna) {
                            M[linha, coluna] = 1;
                        }
                        else if (linha < coluna) {
                            M[linha, coluna] = coluna - linha + 1;
                        }
                        else {
                            M[linha, coluna] = linha - coluna + 1;
                        }
                    }
                }

                //Exibir Matriz
                for (int i = 0; i < N; i++) {
                    for (int j = 0; j < N; j++) {
                        if (j == 0) {
                            Console.Write(String.Format("{0,3}", M[i, j]));
                        }
                        else {
                            Console.Write(String.Format("{0,4}", M[i, j]));
                        }
                    }
                    Console.WriteLine();
                }
                if (N == 0) {  //Para o laço caso seja digitado ZERO
                    break;
                }
                Console.WriteLine();
            } while (N > 0);
        }
    }
}
