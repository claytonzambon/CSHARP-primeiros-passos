using System;
using System.Globalization;

namespace _62._7._URI_1178 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI-1178
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1178
             */
            
            //Ler valor X
            decimal X = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //Declarar Vetor N
            decimal[] N = new decimal[100];

            //Preencher Vetor sempre com metade do valor anterior
            for (int i = 0; i < 100; i++) {
                N[i] = X;
                X = X / 2;
            }

            //Exibir Vetor
            for (int i = 0; i < 100; i++) {
                Console.WriteLine("N[" + i + "] = " 
                    + Math.Round(N[i], 4).ToString("F4", CultureInfo.InvariantCulture));
            }
        }
    }
}
