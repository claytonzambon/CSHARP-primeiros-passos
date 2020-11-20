using System;
using System.Globalization;

namespace _23._11_Exercicio_URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1011
             */

            double R, pi, VOLUME;

            pi = 3.14159;
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            VOLUME = (4 / 3.0) * pi * Math.Pow(R, 3.0);

            Console.WriteLine("VOLUME = " + VOLUME.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
