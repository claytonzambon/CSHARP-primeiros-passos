using System;
using System.Globalization;

namespace _69._1._URI_1181 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI 1181
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1181
             */
            
            //Ler a linha desejada
            int L = int.Parse(Console.ReadLine());

            //Ler a operação desejada
            char T = char.Parse(Console.ReadLine());

            //Declarar a Matriz 12x12
            double[,] M = new double[12, 12];

            //Ler dados e popular a linha da Matriz
            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {
                    M[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            double soma = 0.0, resultado = 0.0;
            for (int i = 0; i < 12; i++) {
                //Somar
                if (T == 'S') {
                    resultado += M[L, i];
                }
                //Calcular Media
                else if (T == 'M') {
                    soma += M[L, i];
                    resultado = soma / (i + 1);
                }
            }
            //Exibir resultado
            Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
