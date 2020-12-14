using System;

namespace _68._3_Exercicio_Matrizes {
    class Program {
        static void Main(string[] args) {

            //Ler tamanho da Matriz quadrada
            int N;

            N = int.Parse(Console.ReadLine());

            //Declarar matriz quadrada de tamanho N
            int[,] matrizQuadrada = new int[N, N];

            //Ler dados e popular matriz
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matrizQuadrada[i, j] = int.Parse(s[j]);
                }
            }

            //Exibir o maior elemento de cada linha da matriz
            for (int i = 0; i < N; i++) {
                int maior = matrizQuadrada[i, i];
                for (int j = 0; j < N; j++) {
                    if (maior < matrizQuadrada[i, j]) {
                        maior = matrizQuadrada[i, j];
                    }
                }
                Console.WriteLine(maior);
            }
        }
    }
}
