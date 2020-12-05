using System;
using System.Globalization;

namespace _52._6_URI_1079 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1079
             */

            int N;
            double n1, n2, n3, mediaPonderada;

            N = int.Parse(Console.ReadLine());

            mediaPonderada = 0.0;
            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                n1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                n2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                n3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                mediaPonderada = (n1 * 2.0 + n2 * 3.0 + n3 * 5.0) / (2.0 + 3.0 + 5.0);
                Console.WriteLine(mediaPonderada.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
