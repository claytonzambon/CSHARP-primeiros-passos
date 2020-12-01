using System;
using System.Globalization;

namespace _38._15_Exercicio_URI_1051 {
    class Program {
        static void Main(string[] args) {
            /* Exercício URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1051
             */

            double salario, totalImpostoDeRenda;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.0) {
                totalImpostoDeRenda = 0.0;
            }
            else if (salario <= 3000.0) {
                totalImpostoDeRenda = (salario - 2000.0) * 0.08;
            }
            else if (salario <= 4500.0) {
                totalImpostoDeRenda = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            }
            else {
                totalImpostoDeRenda = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (totalImpostoDeRenda == 0.0)
                Console.WriteLine("Isento");
            else
                Console.WriteLine("R$ " + totalImpostoDeRenda.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
