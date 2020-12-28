using System;
using System.Globalization;

namespace _69._2._URI_1182 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI-1182
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1182
             */

            //Ler a coluna de 0 a 11
            int C = int.Parse(Console.ReadLine());

            //Ler a operação S ou M
            char T = char.Parse(Console.ReadLine());

            //Declarar a Matriz 12x12
            double[,] M = new double[12, 12];

            //Ler dados e Popular a Matriz
            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {
                    M[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            //Declarar variáveis
            double soma = 0.0, resultado = 0.0;

            //Fluxo que irá realizar a operação desejada
            for (int i = 0; i < 12; i++) {
                if (T == 'S') {
                    resultado += M[i, C];
                }
                else if (T == 'M'){
                    soma += M[i, C];
                    resultado = soma / (i + 1);
                }
            }

            //Exibir o resultado na tela
            Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
