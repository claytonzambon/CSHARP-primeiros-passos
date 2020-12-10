using System;

namespace _61._3_Exercicio_Vetores_03 {
    class Program {
        static void Main(string[] args) {

            int N;

            N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];

            //Lendo valores para o Vetor A
            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                A[i] = int.Parse(vet[i]);
            }

            //Lendo valores para o Vetor B
            vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                B[i] = int.Parse(vet[i]);
            }

            //Populando o Vetor C
            for (int i = 0; i < N; i++) {
                C[i] = A[i] + B[i];
            }

            //Exibindo o Vetor C
            for (int i = 0; i < N; i++) {
                Console.Write(C[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
