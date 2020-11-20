using System;
using System.Globalization;

namespace _23._17_Exercicio_URI_1017
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1017
             */

            int tempoGasto, velocidadeMedia;
            double combustivelGasto;

            tempoGasto = int.Parse(Console.ReadLine());
            velocidadeMedia = int.Parse(Console.ReadLine());
            combustivelGasto = (double)(tempoGasto * velocidadeMedia) / 12;

            Console.WriteLine(combustivelGasto.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
