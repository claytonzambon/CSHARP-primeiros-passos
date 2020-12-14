using System;

namespace _68._7_Exercicio_Matrizes {
    class Program {
        static void Main(string[] args) {

            //Ler valores para M e N
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            //Declarar Matriz de ordem MxN
            int[,] soldados = new int[M, N];

            //Ler dados e popular a Matriz
            for (int i = 0; i < M; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    soldados[i, j] = int.Parse(s[j]);
                }
            }

            //Girar fila
            int fila = int.Parse(Console.ReadLine());

            // como nossa matriz comeca na linha 0, vamos decrementar o valor da fila
            fila = fila - 1;

            // passo 1: vamos salvar o ultimo da fila escolhida
            int ultimoDaFila = soldados[fila, N - 1];

            // passo 2: vamos mover todos da fila (menos o ultimo) para a direita,
            // mas teremos que fazer isso da direita para a esquerda (contagem decrescente)
            for (int j = N - 1; j > 0; j--) {
                soldados[fila, j] = soldados[fila, j - 1];
            }

            // passo 3: agora vamos armazenar o ultimo na primeira posicao da fila
            soldados[fila, 0] = ultimoDaFila;

            // pronto! Agora vamos imprimir a matriz alterada:
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(soldados[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
