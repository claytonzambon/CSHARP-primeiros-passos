using System;

namespace _68._4_Exercicio_Matrizes {
    class Program {
        static void Main(string[] args) {

            //Ler um inteiro N
            int N;

            N = int.Parse(Console.ReadLine());

            //Declara a matriz quadrada de ordem N
            int[,] matrizQuadrada = new int[N, N];

            //Ler dados e popular a matris
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matrizQuadrada[i, j] = int.Parse(s[j]);
                }
            }

            //Somar valores acima da Diagonal Principal
            int soma = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (i == j) {
                        for (int k = j + 1; k < N; k++) {
                            soma += matrizQuadrada[i, k];
                        }
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }
}
