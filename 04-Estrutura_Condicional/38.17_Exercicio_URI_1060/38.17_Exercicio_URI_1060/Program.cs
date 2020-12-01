using System;
using System.Globalization;

namespace _38._17_Exercicio_URI_1060 {
    class Program {
        static void Main(string[] args) {
            /* Exercício URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1060
             */

            int count = 0;
            double valor;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0)
                count = count + 1;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0)
                count++;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0)
                count++;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0)
                count++;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0)
                count++;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor > 0.0)
                count++;

            Console.WriteLine(count + " valores positivos");
        }
    }
}
