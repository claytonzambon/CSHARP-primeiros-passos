using System;
using System.Globalization;

namespace _62._3._URI_1174 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI-1174
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1174
             */

            double[] A = new double[100];

            for (int i = 0; i < 100; i++) {
                A[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            for (int i = 0; i < 100; i++) {
                if (A[i] <= 10) {
                    Console.WriteLine("A[" + i + "] = " + A[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
