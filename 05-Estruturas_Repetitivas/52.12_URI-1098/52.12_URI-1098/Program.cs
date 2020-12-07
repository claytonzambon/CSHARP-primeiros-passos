using System;
using System.Globalization;

namespace _52._12_URI_1098 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1098
             */

            for (double i = 0; i <= 2; i = i + 0.2) {
                for (double j = 1; j <= 3; j++) {
                    Console.WriteLine("I=" + i.ToString("", CultureInfo.InvariantCulture) + 
                        " J=" + (j + i).ToString("", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
