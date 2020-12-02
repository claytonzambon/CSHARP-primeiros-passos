using System;
using System.Globalization;

namespace _45._7_URI_1154 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1154
             */

            int idade, somaIdades = 0, countIdades = 0;
            double media;

            idade = int.Parse(Console.ReadLine());
            while (idade > 0) {
                somaIdades = somaIdades + idade;
                countIdades++;
                idade = int.Parse(Console.ReadLine());
            }

            media = (double)somaIdades / countIdades;
            Console.WriteLine(media.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
