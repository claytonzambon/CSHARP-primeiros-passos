using System;
using System.Globalization;

namespace _38._18_Exercicio_URI_1064 {
    class Program {
        static void Main(string[] args) {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1064
             */

            int count = 0;
            double valor, media = 0.0;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0) {
                media = media + valor;
                count = count + 1;
            }

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0) {
                media = media + valor;
                count = count + 1;
            }

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0) {
                media = media + valor;
                count = count + 1;
            }

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0) {
                media = media + valor;
                count = count + 1;
            }

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0) {
                media = media + valor;
                count = count + 1;
            }

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0) {
                media = media + valor;
                count = count + 1;
            }

            media = media / count;

            Console.WriteLine(count + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
