using System;

namespace _68._5_Exercicio_Matrizes {
    class Program {
        static void Main(string[] args) {

            //Ler valores e M e N
            int M, N;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            //Declarar matrizes de Ordem MxN
            int[,] A, B, C;
            A = new int[M, N];
            B = new int[M, N];
            C = new int[M, N];

            //Ler os dados e popular a Matriz A de ordem MxN
            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(s[j]);
                }
            }

            //Ler os dados e popular a Matriz B de ordem MxN
            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    B[i, j] = int.Parse(s[j]);
                }
            }

            //Somar matriz A e B e popular uma matriz C
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            //Exibir os dados da Matriz C
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
