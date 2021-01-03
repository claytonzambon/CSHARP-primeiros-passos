using System;

namespace _69._13._URI_1534 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI - 1534
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1534
             */

            do {
                //Condição para satisfazer o EOF
                if (!int.TryParse(Console.ReadLine(), out int N)) {
                    break;
                }

                //Declarar matriz quadrada de tamanho N x N
                int[,] M = new int[N, N];

                //Popular a matriz
                for (int linha = 0; linha < N; linha++) {
                    for (int coluna = 0; coluna < N; coluna++) {
                        if (linha == coluna) {
                            M[linha, coluna] = 1;
                            if (N % 2 == 1) { //Insere número 2 se a Matriz for impar
                                int count = (N - 1) / 2;
                                M[count, count] = 2;
                            }
                        }
                        else if (linha + coluna == N - 1) {
                            M[linha, coluna] = 2;
                        }
                        else if (linha != coluna && linha != N - coluna - 1) {
                            M[linha, coluna] = 3;
                        }
                    }
                }

                //Exibir Matriz
                for (int i = 0; i < N; i++) {
                    for (int j = 0; j < N; j++) {
                        Console.Write(String.Format("{0}", M[i, j]));
                    }
                    Console.WriteLine();
                }
            } while (true);
        }
    }
}
