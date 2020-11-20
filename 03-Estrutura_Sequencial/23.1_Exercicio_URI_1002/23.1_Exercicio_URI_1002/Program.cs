using System;
using System.Globalization;

namespace _23._1_Exercicio_URI_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1002
            */

            double area, n, raio;

            n = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = n * Math.Pow(raio, 2.0);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
