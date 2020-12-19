using System;

namespace _62._1._URI_1172 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI-1172
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1172
             */
            
            //Declarar vetor X de 10 posicoes
            int[] X = new int[10];

            //Ler valores digitados
            for (int i = 0; i < 10; i++) {
                X[i] = int.Parse(Console.ReadLine());
            }

            //Trocar valores nulos e negativos por UM
            for (int i = 0; i < 10; i++) {
                if (X[i] <= 0) {
                    X[i] = 1;
                }
            }

            //Exibir o vetor
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("X[" + i + "] = " + X[i]);
            }
        }
    }
}
