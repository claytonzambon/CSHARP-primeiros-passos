using System;
using System.Globalization;

namespace _38._7_Exercicio_URI_1043
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio URI
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1043
             */

            double A, B, C, area, perimetro;

            string[] vet = Console.ReadLine().Split(' ');
            A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            if ( A < B + C && B < A + C && C < A + B)
            {
                perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                area = ((A + B) * C) / 2.0;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }

        }
    }
}
