using System;

namespace _63._1_Exemplo_01_Matrizes {
    class Program {
        static void Main(string[] args) {

            //Declarar variáveis para ler o tamanho da matriz
            int M, N;
            
            string[] vet1 = Console.ReadLine().Split(' ');
            M = int.Parse(vet1[0]);
            N = int.Parse(vet1[1]);

            //Declarar e instanciar uma matriz de tamanho M, N
            int[,] A = new int[M, N];

            //Ler dados do teclado e preencher a matriz
            for (int i = 0; i < M; i++) {
                string[] vet2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(vet2[j]);
                }
            }

            //Percorrer e exibir a matriz
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
