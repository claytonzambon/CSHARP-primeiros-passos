using System;

namespace _69._11._URI_1435 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI - 1435
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1435
             */
            
            //Declarar variável inteira N
            int N;

            do {
                //Ler valor digitado pelo usuario
                N = int.Parse(Console.ReadLine());

                //Declarar matriz quadrada de tamanho N x N
                int[,] M = new int[N, N];

                int hn = N / 2;
                int a = 0;
                int b = N - 1;

                if (N % 2 == 1) {
                    hn++;
                }

                //Popular a matriz
                for (int l = 1; l <= hn; l++) {
                    for (int i = a; i <= b; i++) {
                        for (int j = a; j <= b; j++) {
                            M[i , j] = l;
                        }
                    }
                    a++;
                    b--;
                }

                //Exibir Matriz
                for (int i = 0; i < N; i++) {
                    for (int j = 0; j < N; j++) {
                        if (j == 0) {
                            Console.Write(String.Format("{0,3}", M[i, j]));
                        }
                        else {
                            Console.Write(String.Format("{0,4}", M[i, j]));
                        }
                    }
                    Console.WriteLine();
                }
                if (N == 0) {  //Para o laço caso seja digitado ZERO
                    break;
                }
                Console.WriteLine();
            } while (N > 0);
        }
    }
}
