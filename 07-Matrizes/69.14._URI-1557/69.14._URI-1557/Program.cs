using System;

namespace _69._14._URI_1557 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI - 1435
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1435
             */

            while(true) {

                //Declarar e Ler valor digitado pelo usuario
                int N = int.Parse(Console.ReadLine());

                if (N == 0) { //Para o laço caso seja digitado ZERO
                    break;
                }

                //Declarar matriz quadrada de tamanho N x N
                int[,] M = new int[N, N];

                //Popular a matriz
                int aux = 0;
                for (int linha = 0; linha < N; linha++) {
                    for (int coluna = 0; coluna < N; coluna++) {

                        if (linha == 0 && coluna == 0) {
                            M[linha, coluna] = 1;
                            aux = M[linha, coluna];
                        }
                        else {
                            M[linha, coluna] = aux * 2;
                            aux = M[linha, coluna];
                        }
                    }
                    aux = M[linha, 0];
                }

                //Capturar o último e maior valor da matriz
                //para saber a quantidade de dígitos existente
                int T = M[N-1, N-1].ToString().Length;

                //Exibir Matriz
                for (int linha = 0; linha < N; linha++) {
                    for (int coluna = 0; coluna < N; coluna++) {
                        if (coluna == 0) {
                            Console.Write(String.Format("{0," + T + "}", M[linha, coluna]));
                        }
                        else {
                            Console.Write(String.Format("{0," + (T + 1) + "}", M[linha, coluna]));
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
