using System;
using System.Globalization;

namespace _61._1_Exercicio_Vetores_01 {
    class Program {
        static void Main(string[] args) {

            int N;
            N = int.Parse(Console.ReadLine());

            double[] numeros = new double[N];

            string[] vet = Console.ReadLine().Split(' ');

            //Lendo os numeros
            for (int i = 0; i < N; i++) {
                numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            double maior = numeros[0];
            int posicao = 0;
            for (int i = 0; i < N; i++) {
                if (maior < numeros[i]) {
                    maior = numeros[i];
                    posicao = i;
                }
            }
            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
