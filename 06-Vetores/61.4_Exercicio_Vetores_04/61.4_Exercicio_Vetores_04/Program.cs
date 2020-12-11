using System;
using System.Globalization;

namespace _61._4_Exercicio_Vetores_04 {
    class Program {
        static void Main(string[] args) {

            //Ler a quantidade de valores que terá o Vetor
            int N;
            N = int.Parse(Console.ReadLine());

            //Ler dados para popular o vetor
            double[] numeros = new double[N];

            string[] vet = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
            }

            //Realizar a Soma dos elementos do vetor populado
            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                soma += numeros[i];
            }

            //Calculando e exibindo a média
            double media = soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));


            //Exibindo todos os valores do vetor que estão abaixo da média
            for (int i = 0; i < N; i++) {
                if (numeros[i] < media) {
                    Console.WriteLine(numeros[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
