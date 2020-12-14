using System;

namespace _68._2_Exercicio_Matrizes {
    class Program {
        static void Main(string[] args) {

            //Ler um número N, tamanho da matriz quadrada
            int N;

            N = int.Parse(Console.ReadLine());

            //Declarar uma matriz quadrada de tamanho N
            int[,] matriz = new int[N, N];

            //Ler dados da Matriz
            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            //Exibir a soma de cada linha
            for (int i = 0; i < N; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {
                    soma += matriz[i, j];
                }
                Console.WriteLine(soma);
            }
        }
    }
}
