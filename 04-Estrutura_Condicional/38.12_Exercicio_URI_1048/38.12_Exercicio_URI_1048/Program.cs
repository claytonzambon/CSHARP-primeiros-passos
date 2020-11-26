using System;
using System.Globalization;

namespace _38._12_Exercicio_URI_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercício URI Online Judge
             * https://www.urionlinejudge.com.br/judge/pt/problems/view/1048
             */

            double salario, novoSalario, reajuste, percentual;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.00)
                percentual = 15.0;
            else if (salario <= 800.00)
                percentual = 12.0;
            else if (salario <= 1200.00) 
                percentual = 10.0;
            else if (salario <= 2000.00)
                percentual = 7.0;
            else 
                percentual = 4.0;

            reajuste = salario * percentual / 100.00;
            novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual.ToString("F0", CultureInfo.InvariantCulture) + " %");
        }
    }
}
