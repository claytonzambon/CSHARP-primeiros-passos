using System;
using System.Globalization;

namespace _52._27_URI_1155 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1155
             */

            double S = 0;
            for (int i = 1; i <= 100; i++) {
                S += 1.0 / i;
            }
            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
