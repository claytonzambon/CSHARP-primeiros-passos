using System;
using System.Globalization;

namespace _68._6_Exercicio_Matrizes {
    class Program {
        static void Main(string[] args) {

            //Ler um valor N
            int N;

            N = int.Parse(Console.ReadLine());

            //Declarar uma matriz quadrada com números reais de ordem N
            double[,] matrizQuadrada = new double[N, N];

            //Ler dados e popular a Matriz
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matrizQuadrada[i, j] = double.Parse(s[j], CultureInfo.InvariantCulture);
                }
            }

            //Ler um índice de uma linha da matriz e imprimir todos os elementos dela
            int linha = int.Parse(Console.ReadLine());

            //Ler um índice de uma coluna da matriz e imprimir todos os elementos dela
            int coluna = int.Parse(Console.ReadLine());

            //Calcular e imprimir a Soma dos elementos positivos da Matriz
            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matrizQuadrada[i, j] > 0.0) {
                        soma += matrizQuadrada[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma
                .ToString("F1", CultureInfo.InvariantCulture));

            //Ler um índice de uma linha da matriz e imprimir todos os elementos dela
            Console.Write("LINHA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matrizQuadrada[linha, i]
                    .ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //Ler um índice de uma coluna da matriz e imprimir todos os elementos dela
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(matrizQuadrada[i, coluna]
                    .ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            //Imprimir os elementos da Diagonal Principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (i == j) {
                        Console.Write(matrizQuadrada[i, j]
                            .ToString("F1", CultureInfo.InvariantCulture) + " ");
                    }
                }
            }
            Console.WriteLine();

            //Alterar e exibir a matriz elevando ao quadrado os números negativos
            Console.WriteLine("MATRIZ ALTERADA: ");
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matrizQuadrada[i, j] < 0.0) {
                        Console.Write(Math.Pow(matrizQuadrada[i, j], 2.0)
                            .ToString("F1", CultureInfo.InvariantCulture)
                            + " ");
                    }
                    else {
                        Console.Write(matrizQuadrada[i, j]
                            .ToString("F1", CultureInfo.InvariantCulture)
                            + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
