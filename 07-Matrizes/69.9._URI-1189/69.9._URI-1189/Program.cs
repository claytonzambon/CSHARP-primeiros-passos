using System;
using System.Globalization;

namespace _69._9._URI_1189 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI-1189
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1189
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
            //com os dados da Area Superior
            double soma = 0.0, resultado = 0.0;
            int count = 0;
            for (int i = 0; i < 12; i++) {
                for (int j = 0; j < 12; j++) {
                    //Se "i > j" e "i + j < 11" (tamanho máximo da matriz) 
                    //realizamos a operação selecionada apenas com a Area Esquerda da Matriz
                    if (i > j && (i + j) < 11) {
                        if (O == 'S') {
                            resultado += M[i, j];
                        }
                        else if (O == 'M') {
                            soma += M[i, j];
                            count++;
                            resultado = soma / count;
                        }
                    }
                }
            }

            //Exibir resultado
            Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
