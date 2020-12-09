using System;
using System.Globalization;

namespace _58._1_Exercicio_02_Vetores {
    class Program {
        static void Main(string[] args) {

            int N;
            double soma, media;
            double[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < N; i++) {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < N; i++) {
                Console.Write(vet[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            soma = 0.0;
            media = 0.0;
            for (int i = 0; i < N; i++) {
                soma += vet[i];
            }
            media = soma / N;
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
