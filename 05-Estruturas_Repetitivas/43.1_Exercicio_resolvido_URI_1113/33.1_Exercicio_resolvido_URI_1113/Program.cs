using System;

namespace _33._1_Exercicio_resolvido_URI_1113 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1113
             */

            int n1, n2;

            string[] vet = Console.ReadLine().Split(' ');
            n1 = int.Parse(vet[0]);
            n2 = int.Parse(vet[1]);

            while (n1 != n2) {
                if (n1 < n2) {
                    Console.WriteLine("Crescente");
                }
                else {
                    Console.WriteLine("Decrescente");
                }

                vet = Console.ReadLine().Split(' ');
                n1 = int.Parse(vet[0]);
                n2 = int.Parse(vet[1]);
            }
        }
    }
}
