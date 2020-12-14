using System;

namespace _68._1_Exercicio_Matrizes {
    class Program {
        static void Main(string[] args) {

            //Ler números inteiros para o tamanho da matriz
            int M, N;

            string[] s = Console.ReadLine().Split(' ');
            M = int.Parse(s[0]);
            N = int.Parse(s[1]);

            //Declarar a Matriz de tamanho MxN
            int[,] matriz = new int[M, N];

            //Ler valores e populando a matriz
            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            //Verificar e exibir valores NEGATIVOS
            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        Console.WriteLine(matriz[i, j]);
                    }
                }
            }
        }
    }
}
