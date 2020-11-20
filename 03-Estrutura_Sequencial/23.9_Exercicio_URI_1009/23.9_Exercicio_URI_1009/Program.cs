using System;
using System.Globalization;

namespace _23._9_Exercicio_URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1009
             */

            string nome;
            double salarioFixo, totalVendas, totalReceber;

            nome = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalReceber = salarioFixo + (totalVendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
