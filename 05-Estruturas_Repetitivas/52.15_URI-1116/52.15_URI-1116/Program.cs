using System;
using System.Globalization;

namespace _52._15_URI_1116 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1116
             */

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]);
                int Y = int.Parse(vet[1]);
                if (Y != 0) {
                    Console.WriteLine(((double)X / Y).ToString("F1", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}
