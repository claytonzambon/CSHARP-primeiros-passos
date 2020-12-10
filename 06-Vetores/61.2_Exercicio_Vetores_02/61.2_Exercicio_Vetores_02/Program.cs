using System;

namespace _61._2_Exercicio_Vetores_02 {
    class Program {
        static void Main(string[] args) {

            int N;
            N = int.Parse(Console.ReadLine());

            int[] inteiros = new int[N];

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                inteiros[i] = int.Parse(vet[i]);
            }

            int count = 0;
            for (int i = 0; i < N; i++) {
                if (inteiros[i] % 2 == 0) {
                    Console.Write(inteiros[i] + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
        }
    }
}
