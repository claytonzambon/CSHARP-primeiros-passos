using System;

namespace _69._15._URI_1827 {
    class Program {
        static void Main(string[] args) {
            /* URI - 1827
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1827
             */

            while (true) {
                //Condição para satisfazer o EOF em C#
                if (!int.TryParse(Console.ReadLine(), out int N)) {
                    break;
                }

                int[,] M = new int[N, N];

                //Preencher a Matriz com:
                // 2 na Diagonal Principal
                // 3 na Diagonal Secundária
                // 0 nas demais posições
                for (int linha = 0; linha < N; linha++) {
                    for (int coluna = 0; coluna < N; coluna++) {
                        if (linha == coluna) {
                            M[linha, coluna] = 2;
                        }
                        else if ((linha + coluna) == (N - 1)) {
                            M[linha, coluna] = 3;
                        }
                        else {
                            M[linha, coluna] = 0;
                        }
                    }
                }

                //Utilizando a conta dada pela questão faremos o Tamanho N / 3
                //Esta será a posição que começaremos a popular com 1
                int inicio = N / 3;

                //Esta será a posição que terminamos de popular com 1
                int fim = N - inicio;

                //Preenchendo os valores com o número 1
                for (int linha = inicio; linha < fim; linha++) {
                    for (int coluna = inicio; coluna < fim; coluna++) {
                        M[linha, coluna] = 1;
                    }
                }

                //O tamanho dividido por 2 sempre será o elemento central da matriz
                M[(N / 2), (N / 2)] = 4;

                //Exibir a Matriz
                for (int linha = 0; linha < N; linha++) {
                    for (int coluna = 0; coluna < N; coluna++) {
                        Console.Write(M[linha, coluna]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
