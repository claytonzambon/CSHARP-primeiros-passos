using System;
using System.Globalization;

namespace _61._5_Exercicio_Vetores_05 {
    class Program {
        static void Main(string[] args) {

            //Ler a quantidade de elementos do vetor
            int N;
            N = int.Parse(Console.ReadLine());

            //Declarar um vetor de inteiros de tamanho N
            int[] inteiros = new int[N];

            //Ler os dados para popular o vetor
            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                inteiros[i] = int.Parse(vet[i]);
            }

            //Verificar quais valores são PARES, somar e contar
            int pares = 0, soma = 0;
            for (int i = 0; i < N; i++) {
                if (inteiros[i] % 2 == 0) {
                    soma += inteiros[i];
                    pares++;
                }
            }

            //Calcular e Exibir a média aritmética dos PARES lidos
            double media = (double) soma / pares;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
