using System;
using System.Globalization;

namespace _38._3_Exercicio_URI_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1038
             */

            int codigo, qtd;
            double total;

            string[] vet = Console.ReadLine().Split(' ');
            codigo = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            if (codigo == 1)
            {
                total = qtd * 4.0;
            }
            else if (codigo == 2)
            {
                total = qtd * 4.5;
            }
            else if (codigo == 3)
            {
                total = qtd * 5.0;
            }
            else if (codigo == 4)
            {
                total = qtd * 2.0;
            }
            else
            {
                total = qtd * 1.50;
            }
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
