using System;
using System.Globalization;

namespace _38._2_Exercicio_URI_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1037
             */

            double valor;

            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }
        }
    }
}