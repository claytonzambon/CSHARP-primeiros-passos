using System;
using System.Globalization;

namespace _23._7_Exercicio_URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercicio do URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1008
             */

            int numero, horas;
            double valorPorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = horas * valorPorHora;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
