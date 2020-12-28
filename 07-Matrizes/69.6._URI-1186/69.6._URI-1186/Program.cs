using System;
using System.Globalization;

namespace _69._6._URI_1186 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI-1186
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1186
             */

            //Ler a operação desejada S ou M
            char O = char.Parse(Console.ReadLine());

            //Declarar a Matriz 12x12
            double[,] M = new double[12, 12];

            //Ler dados e popular a Matriz
            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {
                    M[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            //Realizar a operação selecionada S ou M
            // com os dados Acima da Diagonal Secundaria
            double soma = 0.0, resultado = 0.0;
            int count = 0;
            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {
                    //Se a soma de  "i + j" for MAIOR que 11 (tamanho máximo da linha da matriz)
                    // realizamos a operação selecionada
                    if ((i + j) > 11 && O == 'S') {
                        resultado += M[i, j];
                    }
                    else if ((i + j) > 11 && O == 'M') {
                        soma += M[i, j];
                        count++;
                        resultado = soma / count;
                    }
                }
            }

            //Exibir resultado
            Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
