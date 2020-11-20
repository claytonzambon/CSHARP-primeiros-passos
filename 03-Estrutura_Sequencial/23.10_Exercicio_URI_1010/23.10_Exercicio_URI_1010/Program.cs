using System;
using System.Globalization;

namespace _23._10_Exercicio_URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1010
             */
            
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(peca1[0]);
            int numeroPeca1 = int.Parse(peca1[1]);
            double valorPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(peca2[0]);
            int numeroPeca2 = int.Parse(peca2[1]);
            double valorPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double totalPagar = (valorPeca1 * numeroPeca1) + (valorPeca2 * numeroPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
