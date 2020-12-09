using System;
using System.Globalization;

namespace _52._28_URI_1156 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1156
             */

            double denominador = 1.0, soma = 0.0;

            for (int i = 1; i <= 39; i += 2) {
                soma += i / denominador;
                denominador *= 2.0;
            }
            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
