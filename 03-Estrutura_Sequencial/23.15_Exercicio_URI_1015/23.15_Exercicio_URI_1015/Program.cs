using System;
using System.Globalization;

namespace _23._15_Exercicio_URI_1015
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1015
             */

            double x1, y1, x2, y2, distanciaDoisPontos;

            string[] vetor1 = Console.ReadLine().Split(' ');
            x1 = double.Parse(vetor1[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(vetor1[1], CultureInfo.InvariantCulture);

            string[] vetor2 = Console.ReadLine().Split(' ');
            x2 = double.Parse(vetor2[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(vetor2[1], CultureInfo.InvariantCulture);

            distanciaDoisPontos = Math.Sqrt(Math.Pow((x2-x1), 2.0) + Math.Pow((y2-y1), 2.0));

            Console.WriteLine(distanciaDoisPontos.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
